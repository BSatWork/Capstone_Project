using BOP3_Task_1_DB_and_File_Server_App.Database;
using System;
using System.Data;
using System.Windows.Forms;

namespace BOP3_Task_1_DB_and_File_Server_App
{
    public partial class ReportForm : Form
    {
        public MainScreen appMainScreen;

        public ReportForm(MainScreen mainScreen)
        {
            InitializeComponent();
            Show();
            Activate();
            appMainScreen = mainScreen;

            NumberApptTypesByMonth.SetToolTip(NumberApptTypesByMonthButton, "Select a Type and Month below to show the resulting count.");
            ConsultantScheduleToolTip.SetToolTip(ConsultantScheduleButton, "Select a Consultant below to show their schedule.");
            TotalApptsThisYearToolTip.SetToolTip(TotalApptsThisYearButton, "Shows a total count of appointments for the current calendar year.");

            //query = "Select distinct appointment.userId from client_schedule.appointment";
            //DataTable ConsultantList = DBConnection.GetSQLTable(query);
            //ConsultantComboBox.DataSource = ConsultantList;
            ConsultantComboBox.DataSource = DBConnection.GetSQLTable("Select distinct appointment.userId from client_schedule.appointment");
            ConsultantComboBox.DisplayMember = "userId";
            ConsultantComboBox.SelectedIndex = -1;
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

                string query = "Select Count(appointment.userId) as Count from client_schedule.appointment where type = '" + type + "' and month(start) = '" + monthnumber + "'";
                string TotalAppointments = DBConnection.GetSQLTableValue(query);

                if (string.IsNullOrEmpty(TotalAppointments.ToString()))
                {
                    TotalAppointments = "0";
                }
                
                MessageBox.Show("There are a total of " + TotalAppointments + " " + type + " appointments scheduled in " + month + ".", "Appts by Month", MessageBoxButtons.OK);
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
            string query = "Select Count(appointmentId) from client_schedule.appointment";
            string TotalAppointments = DBConnection.GetSQLTableValue(query);
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

        private void MonthsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReportMonthLabel.Hide();
        }
    }
}
