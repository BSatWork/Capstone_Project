using BOP3_Task_1_DB_and_File_Server_App.Database;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BOP3_Task_1_DB_and_File_Server_App
{
    public partial class ReportForm : Form
    {
        public MainScreen appMainScreen;
        private readonly string query;

        public ReportForm(MainScreen mainScreen)
        {
            InitializeComponent();
            Show();
            Activate();
            appMainScreen = mainScreen;

            NumberApptTypesByMonth.SetToolTip(NumberApptTypesByMonthButton, "Select a Type and Month below to show the resulting count.");
            ConsultantScheduleToolTip.SetToolTip(ConsultantScheduleButton, "Select a Consultant below to show their schedule.");
            TotalApptsThisYearToolTip.SetToolTip(TotalApptsThisYearButton, "Shows a total count of appointments for the current calendar year.");

            DataTable dataTable = new DataTable();

            try
            {
                query = "Select distinct appointment.userId from client_schedule.appointment";

                MySqlCommand cmd = new MySqlCommand(query, DBConnection.ConnectToDB);

                using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                {
                    da.Fill(dataTable);
                }

                ConsultantComboBox.DataSource = dataTable;
                ConsultantComboBox.DisplayMember = "userId";
                ConsultantComboBox.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("An error occurred {0}", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NumberApptTypesByMonthButton_Click(object sender, EventArgs e)
        {
            string type = ApptTypeComboBox.Text;
            string month = MonthsComboBox.Text;
            string monthnumber = string.Empty;

            if (string.IsNullOrEmpty(type) || string.IsNullOrEmpty(month))
            {
                MessageBox.Show("Please select an appointment type and month before running this report.", "Selection Validation");
            }
            else
            {
                if (month == "January")
                {
                    monthnumber = "01";
                }
                else if (month == "February")
                {
                    monthnumber = "02";
                }
                else if (month == "March")
                {
                    monthnumber = "03";
                }
                else if (month == "April")
                {
                    monthnumber = "04";
                }
                else if (month == "May")
                {
                    monthnumber = "05";
                }
                else if (month == "June")
                {
                    monthnumber = "06";
                }
                else if (month == "July")
                {
                    monthnumber = "07";
                }
                else if (month == "August")
                {
                    monthnumber = "08";
                }
                else if (month == "September")
                {
                    monthnumber = "09";
                }
                else if (month == "October")
                {
                    monthnumber = "10";
                }
                else if (month == "November")
                {
                    monthnumber = "11";
                }
                else if (month == "December")
                {
                    monthnumber = "12";
                }

                DataTable TotalAppointments = new DataTable();
                string query = "Select Count(appointment.userId) as Count from client_schedule.appointment where type = '" + type + "' and month(start) = '" + monthnumber + "'";

                MySqlCommand cmd = new MySqlCommand(query, DBConnection.ConnectToDB);

                using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                {
                    da.Fill(TotalAppointments);
                }

                if (string.IsNullOrEmpty(TotalAppointments.ToString()))
                {
                    int outputTotal = 0;
                    MessageBox.Show("There are a total of " + outputTotal + " " + type + " appointments scheduled in " + month + ".", "Appts by Month", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("There are a total of " + TotalAppointments + " " + type + " appointments scheduled in " + month + ".", "Appts by Month", MessageBoxButtons.OK);

                }
            }
        }

        private void ConsultantScheduleButton_Click(object sender, EventArgs e)
        {
            string Consultant = ConsultantComboBox.Text;

            if (string.IsNullOrEmpty(Consultant))
            {
                MessageBox.Show("Please select a Consultant before running this report.", "Selection Validation");
            }
            else
            {
                _ = new ConsultantScheduleForm(this, Consultant);
                this.Hide();
            }

        }

        private void TotalApptsThisYearButton_Click(object sender, EventArgs e)
        {
            DataTable TotalAppointments = new DataTable();
            string query = "Select count(appointmentId) from client_schedule.appointment";

            MySqlCommand cmd = new MySqlCommand(query, DBConnection.ConnectToDB);

            using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
            {
                da.Fill(TotalAppointments);
            }

            MessageBox.Show("There are a total of " + TotalAppointments + " remaining appointments this year.", "Remaining Appointments This Year", MessageBoxButtons.OK);
        }

        private void ReportFormCloseButton_Click(object sender, EventArgs e)
        {
            Close();
            appMainScreen.Show();
        }

        private void ApptTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReportApptTypeLabel.Hide();
        }

        private void ConsultantComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReportUserIDLabel.Hide();
        }

        private void MonthsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReportMonthLabel.Hide();
        }
    }
}
