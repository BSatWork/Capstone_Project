using BOP3_Task_1_DB_and_File_Server_App.Database;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BOP3_Task_1_DB_and_File_Server_App
{
    public partial class MainScreen : Form
    {
        public AppLoginForm appLogin;
        public string query;
        private readonly int appts;

        public MainScreen()
        {
            InitializeComponent();
            Show();
            Activate();
            AddUpdateDeleteApptToolTip.SetToolTip(AddUpdateDeleteApptButton, "To Update or Delete, Select an Appointment First");
            CustomerDBToolTip.SetToolTip(CustomerDBButton, "View or Update the Customer Database");
            ReportsToolTip.SetToolTip(ReportsButton, "Generate Reports");
            
            DataTable mainScreendataTable = new DataTable();

            try
            {
                string query = "Select appointment.userId, customer.customerName, appointment.type, appointment.start, appointment.end from client_schedule.appointment Left Join client_schedule.customer on appointment.customerId = customer.customerId;;";

                MySqlCommand cmd = new MySqlCommand(query, DBConnection.ConnectToDB);

                using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                {
                    da.Fill(mainScreendataTable);
                }

                AppointmentsDGV.DataSource = mainScreendataTable;
                AppointmentsDGV.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("An error occurred {0}", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            DataTable apptCount = new DataTable();

            try
            {
                string query = "Select appointmentID from client_schedule.appointment;";

                MySqlCommand cmd = new MySqlCommand(query, DBConnection.ConnectToDB);

                using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                {
                    da.Fill(apptCount);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("An error occurred {0}", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            appts = apptCount.Rows.Count;
            ApptCount.Text = appts.ToString();

            //Todo check the appt database for qty of ALL appointments and if there's an upcoming appt within 15 min.
            //Todo If there's an appt upcoming within 15 min, then MessageBox.Show("The highlighted appointment begins within the next 15 minutes.")

        }

        public void AddUpdateDeleteApptButton_Click(object sender, EventArgs e)
        {
            Appointment appointment = (Appointment)AppointmentsDGV.CurrentRow.DataBoundItem;

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
