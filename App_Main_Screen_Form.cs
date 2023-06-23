using RYM2_Capstone_Scheduling_App.Database;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace RYM2_Capstone_Scheduling_App
{
    public partial class MainScreen : Form
    {
        public AppLoginForm appLogin;
        public string allApptsQuery;
        public string query;
        public string userId;
        public int appointmentId;
        public int rowIndex = -1;
        public DataGridViewRow row;

        public MainScreen(string userName)
        {
            InitializeComponent();
            Show();
            Activate();
            AddUpdateDeleteApptToolTip.SetToolTip(AddUpdateDeleteApptButton, "To Update or Delete, Select an Appointment First");
            CustomerDBToolTip.SetToolTip(CustomerDBButton, "View or Update the Customer Database");
            ReportsToolTip.SetToolTip(ReportsButton, "Generate Reports");

            // Query used to refresh the Appts table when returning from other screens.
            allApptsQuery = "Select appointment.appointmentId, appointment.userId, user.First_Name, user.Last_Name, customer.customerName, appointment.type, appointment.start, appointment.end " +
                            "from client_schedule.appointment " +
                            "Left Join client_schedule.customer on appointment.customerId = customer.customerId " +
                            "Left Join client_schedule.user on appointment.userId = user.userId " +
                            $"Where appointment.start > '{DateTime.UtcNow:yyyy-MM-dd hh:mm:00}' " +
                            "Order by appointment.start asc ";
            
            // Populate the Appointments table.
            CalendarView.SelectedIndex = 0;

            query = "Select user.userId " +
                    "From client_schedule.user " +
                    $"Where user.userName = '{userName}' ";
            userId = DBConnection.GetSQLTableValue(query);

            query = "Select appointmentId " +
                    "From client_schedule.appointment " +
                    $"Where appointment.end between '{DateTime.UtcNow:yyyy-MM-dd HH:mm:00}' and ('{DateTime.UtcNow:yyyy-MM-dd HH:mm:00}' + interval(14) minute) " +
                    $"And appointment.userId = {userId} ";
            string getLateApptId = DBConnection.GetSQLTableValue(query);

            if (!string.IsNullOrEmpty(getLateApptId))
            {
                MessageBox.Show("!YOU'RE LATE to an appt that has already started!\n\nSee the first highlighted appt for details.", "Appt Reminder", MessageBoxButtons.OK);

                //Lambda expression used to identify which appt needs to be highlighted that's in-process appt.
                row = AppointmentsDGV.Rows
                    .Cast<DataGridViewRow>()
                    .Where(r => r.Cells[0].Value.ToString().Equals(getLateApptId))
                    .First();
                rowIndex = row.Index;

                AppointmentsDGV.MultiSelect = true;
                AppointmentsDGV.Rows[rowIndex].Selected = true;
            }

            query = "Select appointmentId " +
                    "From client_schedule.appointment " +
                    $"Where appointment.start between '{DateTime.UtcNow:yyyy-MM-dd HH:mm:00}' and ('{DateTime.UtcNow:yyyy-MM-dd HH:mm:00}' + interval(15) minute) " +
                    $"And appointment.userId = {userId} ";
            string getApptId = DBConnection.GetSQLTableValue(query);

            if (!string.IsNullOrEmpty(getApptId))
            {
                MessageBox.Show("!ATTENTION! You have an appt in the next 15 minutes.\n\nSee the second highlighted appt for details.", "Appt Reminder", MessageBoxButtons.OK);

                //Lambda expression used to identify which appt needs to be highlighted that's upcoming appt.
                rowIndex = -1;
                row = AppointmentsDGV.Rows
                    .Cast<DataGridViewRow>()
                    .Where(r => r.Cells[0].Value.ToString().Equals(getApptId))
                    .First();
                rowIndex = row.Index;

                AppointmentsDGV.Rows[rowIndex].Selected = true;
            }
        }

        public void AddUpdateDeleteApptButton_Click(object sender, EventArgs e)
        {
            appointmentId = 0;

            if (AppointmentsDGV.SelectedRows.Count == 1)
            {
                appointmentId = (int)AppointmentsDGV.CurrentRow.Cells[0].Value;
            }

            _ = new AppointmentForm(this, appointmentId);
            this.Hide();
        }

        private void CustomerDBButton_Click(object sender, EventArgs e)
        {
            _ = new CustomerDatabaseForm(this);
            this.Hide();
        }

        private void MainScreenCloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AppointmentDGV_CellValueChanged(object sender, EventArgs e)
        {
            AppointmentsDGV.MultiSelect = false;
        }

        private void CalendarView_SelectedIndexChanged(object sender, EventArgs e)
        {
            string todaysDay = DateTime.Today.ToString("dddd");
            int endOfWeek = 0;
            if (todaysDay == "Sunday")
            {
                endOfWeek = int.Parse(DateTime.Today.ToString("dd"));
            }
            else if (todaysDay == "Monday")
            {
                endOfWeek = int.Parse(DateTime.Today.ToString("dd")) + 6;
            }
            else if (todaysDay == "Tuesday")
            {
                endOfWeek = int.Parse(DateTime.Today.ToString("dd")) + 5;
            }
            else if (todaysDay == "Wednesday")
            {
                endOfWeek = int.Parse(DateTime.Today.ToString("dd")) + 4;
            }
            else if (todaysDay == "Thursday")
            {
                endOfWeek = int.Parse(DateTime.Today.ToString("dd")) + 3;
            }
            else if (todaysDay == "Friday")
            {
                endOfWeek = int.Parse(DateTime.Today.ToString("dd")) + 2;
            }
            else if (todaysDay == "Saturday")
            {
                endOfWeek = int.Parse(DateTime.Today.ToString("dd")) + 1;
            }

            string weekEnd = "";
            if (endOfWeek > 9)
            {
                weekEnd = endOfWeek.ToString();
            }
            else if (endOfWeek < 10)
            {
                weekEnd = "0" + endOfWeek.ToString();
            }

            int todaysMonth = int.Parse(DateTime.Today.ToString("MM"));
            string nextMonth;
            if (todaysMonth == 12)
            {
                nextMonth = "01";
            }
            else if (todaysMonth < 10)
            {
                nextMonth = "0" + (todaysMonth + 1).ToString();
            }
            else
            {
                nextMonth = todaysMonth.ToString();
            }
            
            int todaysYear = int.Parse(DateTime.Today.ToString("yyyy"));
            string nextYear;
            if (todaysMonth == 12)
            {
                nextYear = (todaysYear + 1).ToString();
            }
            else
            {
                nextYear = todaysYear.ToString();
            }

            if (CalendarView.SelectedIndex == 0)        // All filter
            {
                // Populate the Appointments table with all appointments.
                query = allApptsQuery;
            }
            else if (CalendarView.SelectedIndex == 1)   // Current Week filter
            {
                // Populate the Appointments table with only the appointments for the current week.
                query = "Select appointment.appointmentId, appointment.userID, user.First_Name, user.Last_Name, customer.customerName, appointment.type, appointment.start, appointment.end " +
                        "from client_schedule.appointment " +
                        "Left Join client_schedule.customer on appointment.customerId = customer.customerId " +
                        "Left Join client_schedule.user on appointment.userId = user.userId " +
                        "Where appointment.start between '" + DateTime.UtcNow.ToString("yyyy-MM-dd hh:mm:00") + "' and '" + DateTime.UtcNow.ToString($"{nextYear}-MM-{weekEnd} 00:00:00") + "' " +
                        "Order by appointment.start asc ";
            }
            else if (CalendarView.SelectedIndex == 2)   // Current Month filter
            {
                // Populate the Appointments table with only the appointments for the current week.
                query = "Select appointment.appointmentId, appointment.userID, user.First_Name, user.Last_Name, customer.customerName, appointment.type, appointment.start, appointment.end " +
                        "from client_schedule.appointment " +
                        "Left Join client_schedule.customer on appointment.customerId = customer.customerId " +
                        "Left Join client_schedule.user on appointment.userId = user.userId " +
                        "Where appointment.start between '" + DateTime.UtcNow.ToString("yyyy-MM-dd hh:mm:00") + "' and '" + DateTime.UtcNow.ToString($"{nextYear}-{nextMonth}-01 00:00:00") + "' " +
                        "Order by appointment.start asc ";
            }
            GetAppointmentData(query);
        }

        private void ReportsButton_Click(object sender, EventArgs e)
        {
            _ = new ReportForm(this);
            this.Hide();
        }

        public string GetAppointmentData(string query)
        {
            DataTable mainScreendataTable = DBConnection.GetSQLTable(query);
            for (int index = 0; index < mainScreendataTable.Rows.Count; index++)
            {
                mainScreendataTable.Rows[index]["start"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)mainScreendataTable.Rows[index]["start"], TimeZoneInfo.Local).ToString();
                mainScreendataTable.Rows[index]["end"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)mainScreendataTable.Rows[index]["end"], TimeZoneInfo.Local).ToString();
            }

            AppointmentsDGV.DataSource = mainScreendataTable;
            AppointmentsDGV.ClearSelection();

            query = "Select Count(appointmentId) " +
                "From client_schedule.appointment " +
                $"Where appointment.start > '{DateTime.UtcNow:yyyy-MM-dd hh:mm:00}' ";
            string apptCount = DBConnection.GetSQLTableValue(query);
            ApptCount.Text = apptCount;
            return query;
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            string searchText = SearchTextBox.Text;
            query = "Select appointment.appointmentId, appointment.userID, user.First_Name, user.Last_Name, customer.customerName, appointment.type, appointment.start, appointment.end " +
                    "from client_schedule.appointment " +
                    "Left Join client_schedule.customer on appointment.customerId = customer.customerId " +
                    "Left Join client_schedule.user on appointment.userId = user.userId " +
                    $"Where user.First_Name Like '%{searchText}%' " +
                    $"Or user.Last_Name Like '%{searchText}%' " +
                    $"Or customer.customerName like '%{searchText}%' " +
                    $"Or appointment.type like '%{searchText}%' " +
                    $"Or appointment.start like '%{searchText}%' " +
                    $"Or appointment.end like '%{searchText}%' " +
                    $"And appointment.start > '{DateTime.UtcNow:yyyy-MM-dd hh:mm:00}' " +
                    "Order by appointment.start asc ";
            GetAppointmentData(query);
        }
    }
}