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

        public MainScreen(string userName)
        {
            InitializeComponent();
            Show();
            Activate();
            AddUpdateDeleteApptToolTip.SetToolTip(AddUpdateDeleteApptButton, "To Update or Delete, Select an Appointment First");
            CustomerDBToolTip.SetToolTip(CustomerDBButton, "View or Update the Customer Database");
            ReportsToolTip.SetToolTip(ReportsButton, "Generate Reports");

            // Populate the Appointments table.
            query = "Select appointment.appointmentId, appointment.userId, customer.customerName, appointment.type, appointment.start, appointment.end " +
                    "from client_schedule.appointment " +
                    "Left Join client_schedule.customer on appointment.customerId = customer.customerId";
            DataTable mainScreendataTable = DBConnection.GetSQLTable(query);
            AppointmentsDGV.DataSource = mainScreendataTable;
            AppointmentsDGV.ClearSelection();

            // Populate the Count of Appointments label.
            query = "Select Count(appointmentID) " +
                    "From client_schedule.appointment";
            string apptCount = DBConnection.GetSQLTableValue(query);
            ApptCount.Text = apptCount;

            //Todo check the appt database for qty of ALL appointments and if there's an upcoming appt within 15 min.
            //Todo If there's an appt upcoming within 15 min, then MessageBox.Show("The highlighted appointment begins within the next 15 minutes.")
            query = "Select user.userId " +
                    "From client_schedule.user " +
                    "Where user.userName = '" + userName + "'";
            userId = DBConnection.GetSQLTableValue(query);
            
            query = "Select Count(appointmentID) " +
                    "From client_schedule.appointment " +
                    "Where appointment.start between '" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss tt") + "' and ('" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss tt") + "' + interval(15) minute) " +
                    "And appointment.userId = '" + userId + "'";
            string upcomingAppointments = DBConnection.GetSQLTableValue(query);
            int upcomingAppointment = Int32.Parse(upcomingAppointments);
            
            if (upcomingAppointment > 0)
            {
                MessageBox.Show("!ATTENTION! You have an appt in the next 15 minutes." + "\n" + "\n" + "See the highlighted appt for details.");
            }
        }

        public void AddUpdateDeleteApptButton_Click(object sender, EventArgs e)
        {
            Appointment appointment = null;

            if (AppointmentsDGV.CurrentRow.Selected)
            {
                //appointment = (Appointment)AppointmentsDGV.CurrentRow.DataBoundItem;
                //appointment.appointmentId = AppointmentsDGV.SelectedCells[0].RowIndex;
                //appointment.userId = AppointmentsDGV.SelectedCells[1].RowIndex;
                //appointment.customerName = AppointmentsDGV.SelectedCells[2].RowIndex.ToString();
                //appointment.type = AppointmentsDGV.SelectedCells[3].RowIndex.ToString();
                MessageBox.Show("AppointmentsDGV selected row column 0 = " + AppointmentsDGV.SelectedRows[1].Cells[0].Value + "\n" +
                                "AppointmentsDGV selected row column 1 = " + AppointmentsDGV.SelectedRows[1].Cells[1].Value + "\n" +
                                "AppointmentsDGV.selected row column 2 = " + AppointmentsDGV.SelectedRows[1].Cells[2].Value + "\n" +
                                "AppointmentsDGV.selected row column 3 = " + AppointmentsDGV.SelectedRows[1].Cells[3].Value);
                //appointment.end = AppointmentsDGV.SelectedCells[6].RowIndex.ToString();
            }

            _ = new AppointmentForm(this, appointment);
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
            if (CalendarView.SelectedIndex == 0)        // All
            {
                //Todo Show All appointments
            }
            else if (CalendarView.SelectedIndex == 1)   // 30 days
            {
                //Todo Show only the appointments within the next 30 days.
            }
            else if (CalendarView.SelectedIndex == 2)   // 7 days
            {
                //Todo Show All appointments within the next 7 days.
            }
        }

        private void ReportsButton_Click(object sender, EventArgs e)
        {
            _ = new ReportForm(this);
            this.Hide();
        }
    }
}
