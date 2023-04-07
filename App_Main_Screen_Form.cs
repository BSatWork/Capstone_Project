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

        public MainScreen()
        {
            InitializeComponent();
            Show();
            Activate();
            AddUpdateDeleteApptToolTip.SetToolTip(AddUpdateDeleteApptButton, "To Update or Delete, Select an Appointment First");
            CustomerDBToolTip.SetToolTip(CustomerDBButton, "View or Update the Customer Database");
            ApptCount.Text = "0";

        }

        private void AddUpdateDeleteApptButton_Click(object sender, EventArgs e)
        {
            _ = new AppointmentForm(this);
            this.Hide();
        }

        private void CustomerDBButton_Click(object sender, EventArgs e)
        {
            _ = new CustomerDatabaseForm(this);
            this.Hide();
        }

        /*private void MainScreen_Closing(Object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();

            }
        }*/

        private void MainScreenCloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
            /*DialogResult delete = MessageBox.Show("Close the app and return to the Login Window?", "Close Confirmation", MessageBoxButtons.YesNo);

            switch (delete)
            {
                case DialogResult.Yes:
                    Close();
                    _ = new AppLoginForm();
                    break;
                case DialogResult.No:
                    break;
            }*/
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
    }
}
