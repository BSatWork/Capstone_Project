using BOP3_Task_1_DB_and_File_Server_App.Database;
using System;
using System.Data;
using System.Windows.Forms;

namespace BOP3_Task_1_DB_and_File_Server_App
{
    public partial class MainScreen : Form
    {
        public AppLoginForm appLogin;
        public string query;
        public string userId;
        public int appointmentId = 0;

        public MainScreen(string userName)
        {
            InitializeComponent();
            Show();
            Activate();
            AddUpdateDeleteApptToolTip.SetToolTip(AddUpdateDeleteApptButton, "To Update or Delete, Select an Appointment First");
            CustomerDBToolTip.SetToolTip(CustomerDBButton, "View or Update the Customer Database");
            ReportsToolTip.SetToolTip(ReportsButton, "Generate Reports");

            // Populate the Appointments table.
            CalendarView.SelectedIndex = 0;

            //Todo If there's an appt upcoming within 15 min, then MessageBox.Show("The highlighted appointment begins within the next 15 minutes.")
            query = "Select user.userId " +
                    "From client_schedule.user " +
                    "Where user.userName = '" + userName + "'";
            userId = DBConnection.GetSQLTableValue(query);
            
            query = "Select Count(appointmentId) " +
                    "From client_schedule.appointment " +
                    "Where appointment.start between '" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:00") + "' and ('" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:00") + "' + interval(15) minute) " +
                    "And appointment.userId = '" + userId + "'";
            string upcomingAppointments = DBConnection.GetSQLTableValue(query);
            int upcomingAppointment = upcomingAppointments.IndexOf((char)0);

            if (upcomingAppointment != -1)
            {
                MessageBox.Show("!ATTENTION! You have an appt in the next 15 minutes.\n\nSee the highlighted appt for details.");
                AppointmentsDGV.Rows[upcomingAppointment].Selected = true;
            }
        }

        public void AddUpdateDeleteApptButton_Click(object sender, EventArgs e)
        {
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

        private void CalendarView_SelectedIndexChanged(object sender, EventArgs e)
        {
            string todaysDay = DateTime.Today.ToString("dddd");
            int endOfWeek = 0;
            if (todaysDay == "Sunday")
            {
                endOfWeek = Int32.Parse(DateTime.Today.ToString("dd"));
            }
            else if (todaysDay == "Monday")
            {
                endOfWeek = Int32.Parse(DateTime.Today.ToString("dd")) + 6;
            }
            else if (todaysDay == "Tuesday")
            {
                endOfWeek = Int32.Parse(DateTime.Today.ToString("dd")) + 5;
            }
            else if (todaysDay == "Wednesday")
            {
                endOfWeek = Int32.Parse(DateTime.Today.ToString("dd")) + 4;
            }
            else if (todaysDay == "Thursday")
            {
                endOfWeek = Int32.Parse(DateTime.Today.ToString("dd")) + 3;
            }
            else if (todaysDay == "Friday")
            {
                endOfWeek = Int32.Parse(DateTime.Today.ToString("dd")) + 2;
            }
            else if (todaysDay == "Saturday")
            {
                endOfWeek = Int32.Parse(DateTime.Today.ToString("dd")) + 1;
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

            int todaysMonth = Int32.Parse(DateTime.Today.ToString("MM"));
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
            
            int todaysYear = Int32.Parse(DateTime.Today.ToString("yyyy"));
            string nextYear;
            if (todaysMonth == 12)
            {
                nextYear = (todaysYear + 1).ToString();
            }
            else
            {
                nextYear = todaysYear.ToString();
            }

            if (CalendarView.SelectedIndex == 0)        // All
            {
                // Populate the Appointments table with all appointments.
                query = "Select appointment.appointmentId, appointment.userId, customer.customerName, appointment.type, appointment.start, appointment.end " +
                        "from client_schedule.appointment " +
                        "Left Join client_schedule.customer on appointment.customerId = customer.customerId " +
                        "Where appointment.start > '" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:00") + "'";
            }
            else if (CalendarView.SelectedIndex == 1)   // Current Week
            {
                // Populate the Appointments table with only the appointments for the current week.
                query = "Select appointment.appointmentId, appointment.userId, customer.customerName, appointment.type, appointment.start, appointment.end " +
                        "from client_schedule.appointment " +
                        "Left Join client_schedule.customer on appointment.customerId = customer.customerId " +
                        "Where appointment.start between '" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:00") + "' and '" + DateTime.Now.ToString($"{nextYear}-MM-{weekEnd} 00:00:00") + "'";
            }
            else if (CalendarView.SelectedIndex == 2)   // Current Month
            {
                // Populate the Appointments table with only the appointments for the current week.
                query = "Select appointment.appointmentId, appointment.userId, customer.customerName, appointment.type, appointment.start, appointment.end " +
                        "from client_schedule.appointment " +
                        "Left Join client_schedule.customer on appointment.customerId = customer.customerId " +
                        "Where appointment.start between '" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:00") + "' and '" + DateTime.Now.ToString($"{nextYear}-{nextMonth}-01 00:00:00") + "'";
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
            AppointmentsDGV.DataSource = mainScreendataTable;
            AppointmentsDGV.ClearSelection();

            query = "Select Count(appointmentId) " +
                "From client_schedule.appointment " +
                "Where appointment.start > '" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:00") + "' ";
            string apptCount = DBConnection.GetSQLTableValue(query);
            ApptCount.Text = apptCount;
            return query;
        }
    }
}
