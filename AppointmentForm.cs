using BOP3_Task_1_DB_and_File_Server_App.Database;
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
    public partial class AppointmentForm : Form
    {
        public MainScreen appMainScreen;

        public AppointmentForm(MainScreen mainScreen, Appointment appointment = null)
        {
            InitializeComponent();
            Show();
            Activate();
            appMainScreen = mainScreen;
            
            if (appointment == null)
            {
                ApptDeleteButton.Visible = false;
                ApptCancelButton.Visible = true; 
            }
            else
            {
                ApptCancelButton.Visible = false;
                ApptDeleteButton.Visible = true;

                ApptUserIDComboBox.Text = appointment.userID.ToString();
                ApptTypeComboBox.Text = appointment.type.ToString();
                CustomerComboBox.Text = appointment.customerID.ToString();
                ApptStartDateTime.Value = appointment.start;
                ApptEndDateTime.Value = appointment.end;
            }
        }

        private void ApptSave_Click(object sender, EventArgs e)
        {
            // If all fields have been validated, then continue processing.  Otherwise, inform the user.
            if (!string.IsNullOrEmpty(ApptUserIDComboBox.Text) && !string.IsNullOrEmpty(ApptTypeComboBox.Text) && !string.IsNullOrEmpty(CustomerComboBox.Text)
                )
            {
                //Todo Save the Appt data to the DB

                Close();
                appMainScreen.Show();
            }
            else
            {
                MessageBox.Show("Please verify all fields are populated and try again.", "Input Validation");
            }
        }

        private void ApptDelete_Click(object sender, EventArgs e)
        {
            DialogResult delete = MessageBox.Show("Deleting an appt cannot be undone." + Environment.NewLine +
                                                  "Are you sure?", "Delete Confirmation", MessageBoxButtons.YesNo);

            switch (delete)
            {
                case DialogResult.Yes:
                    //Todo Delete the Appt from the DB.
                    Close();
                    appMainScreen.Show();
                    break;
                case DialogResult.No:
                    break;
            }
        }

        private void ApptCancelButton_Click(object sender, EventArgs e)
        {
            Close();
            appMainScreen.Show();
        }
    }
}
