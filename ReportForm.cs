using RYM2_Capstone_Scheduling_App.Database;
using System;
using System.Windows.Forms;

namespace RYM2_Capstone_Scheduling_App
{
    public partial class ReportForm : Form
    {
        public MainScreen appMainScreen;
        public string query;

        public ReportForm(MainScreen mainScreen)
        {
            InitializeComponent();
            Show();
            Activate();
            appMainScreen = mainScreen;

            NumberApptTypesByMonth.SetToolTip(NumberApptTypesByMonthButton, "Select a Type and Month below to show the resulting count.");
            ConsultantScheduleToolTip.SetToolTip(EmployeeScheduleButton, "Select an Employee below to show their schedule.");
            TotalApptsThisYearToolTip.SetToolTip(TotalApptsThisYearButton, "Shows a total count of appointments for the current calendar year.");

            EmployeeUserNameComboBox.DataSource = DBConnection.GetSQLTable("Select distinct user.employeeName from client_schedule.user where user.active = 1 ");
            EmployeeUserNameComboBox.DisplayMember = "employeeName";
            EmployeeUserNameComboBox.SelectedIndex = -1;
        }

        private void NumberApptTypesByMonthButton_Click(object sender, EventArgs e)
        {
            string type = ApptTypeComboBox.Text;
            string month = MonthsComboBox.Text;
            string monthnumber = string.Empty;

            if (string.IsNullOrEmpty(type) || string.IsNullOrEmpty(month))
            {
                MessageBox.Show("Please select an appointment type and month before running this report.", "Selection Validation", MessageBoxButtons.OK);
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

                query = "Select Count(appointment.userId) as Count from client_schedule.appointment where type = '" + type + "' and month(start) = '" + monthnumber + "'";
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
            string EmployeeUserName = EmployeeUserNameComboBox.Text;

            if (string.IsNullOrEmpty(EmployeeUserName))
            {
                MessageBox.Show("Please select an Employee before running this report.", "Selection Validation");
            }
            else
            {
                _ = new EmployeeScheduleForm(this, EmployeeUserName);
                this.Hide();
            }
        }

        private void TotalApptsThisYearButton_Click(object sender, EventArgs e)
        {
            string endOfYear = DateTime.UtcNow.ToString("yyyy") + "-12-31 23:45:00";
            query = "Select Count(appointmentId) from client_schedule.appointment " +
                    $"Where appointment.start between '" + DateTime.UtcNow.ToString("yyyy-MM-dd hh:mm:00") + "' and '" + DateTime.UtcNow.ToString(endOfYear) + "' ";
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