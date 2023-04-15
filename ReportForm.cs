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

        public ReportForm(MainScreen mainScreen)
        {
            InitializeComponent();
            Show();
            Activate();
            appMainScreen = mainScreen;

            NumberApptTypesByMonth.SetToolTip(NumberApptTypesByMonthButton, "Select a Type and Month below to show the resulting count.");
            ConsultantScheduleToolTip.SetToolTip(ConsultantScheduleButton, "Select a Consultant below to show their schedule.");
            TotalApptsThisYearToolTip.SetToolTip(TotalApptsThisYearButton, "Shows a total count of appointments for the current calendar year.");

            //Todo Create and instance of the Appointment table
        }

        private void NumberApptTypesByMonthButton_Click(object sender, EventArgs e)
        {
            int TotalAppointments = 52;//Todo Update this to actually pull the count of Appt types by the selected Type and Month.
            var Month = "Sometime"; //MonthsListBox.SelectedItem.ToString(); //Todo Fix this.

            MessageBox.Show("There are a total of " + TotalAppointments + " appointments scheduled in " + Month + ".", "Appts by Month", MessageBoxButtons.OK);
        }

        private void ConsultantScheduleButton_Click(object sender, EventArgs e)
        {
            string Consultant = "";

            _ = new ConsultantScheduleForm(this, Consultant);
            this.Hide();
        }

        private void TotalApptsThisYearButton_Click(object sender, EventArgs e)
        {
            int TotalAppointments = 52; //Todo Replace 52 with the Total count of remaining Appts for this year.

            MessageBox.Show("There are a total of " + TotalAppointments + " remaining appointments this year.", "Appts This Year", MessageBoxButtons.OK);
        }

        private void ReportFormCloseButton_Click(object sender, EventArgs e)
        {
            Close();
            appMainScreen.Show();
        }
    }
}
