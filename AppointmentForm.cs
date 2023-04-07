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
        
        public AppointmentForm(MainScreen mainScreen)   //Todo Include pulling in the ApptDGV DB in here.
        {
            InitializeComponent();
            Show();
            Activate();
            appMainScreen = mainScreen;
            
            if (!string.IsNullOrEmpty(ApptType.Text))
            {
                ApptCancelButton.Visible = false;
                ApptDeleteButton.Visible = true;
            }
            else
            {
                ApptDeleteButton.Visible = false;
                ApptCancelButton.Visible = true;

                //Todo Pull the selected DGV row data and populate the fields.
            }

        }

        public void CreateMyDateTimePicker()
        {
            // Create a new DateTimePicker control and initialize it.
            DateTimePicker dateTimePicker1 = new DateTimePicker();

            // Set the MinDate and MaxDate.
            dateTimePicker1.MinDate = DateTime.Today;
            dateTimePicker1.MaxDate = new DateTime(9999, 12, 31);

            // Set the CustomFormat string.
            dateTimePicker1.CustomFormat = "MMMM dd, yyyy - dddd";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;

            // Show the CheckBox and display the control as an up-down control.
            dateTimePicker1.ShowCheckBox = true;
            dateTimePicker1.ShowUpDown = true;
        }

        private void ApptSave_Click(object sender, EventArgs e)
        {
            // If all fields have been validated, then continue processing.  Otherwise, inform the user.
            if (ApptUserID.BackColor == System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192))))) && 
                ApptType.BackColor == System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192))))) &&
                ApptCustomerID.BackColor == System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192))))) /*&&
                Customer_City.BackColor == System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192))))) &&
                Customer_Country.BackColor == System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))))*/
                )
            {
                //Todo Save the Appt data to the DB

                Close();
                appMainScreen.Show();
            }
            else
            {
                MessageBox.Show("Please verify all required fields are populated." + Environment.NewLine +
                                "(Fields will turn green when populated.)", "Input Validation");
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

        // Form field validation...
        // Fields will turn green, indicating the input is acceptable, or they will stay red.


        private void ApptUserID_TextChanged(object sender, EventArgs e)
        {
            // Validate the User ID field is populated.
            if (!string.IsNullOrEmpty(ApptUserID.Text))
            {
                ApptUserID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            }
            else
            {
                ApptUserID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            }
        }
        
        private void ApptType_TextChanged(object sender, EventArgs e)
        {
            // Validate the Type field is populated.
            if (!string.IsNullOrEmpty(ApptType.Text))
            {
                ApptType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            }
            else
            {
                ApptType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            }
        }

        private void ApptCustomer_TextChanged(object sender, EventArgs e)
        {
            // Validate the Customer field is populated.
            if (!string.IsNullOrEmpty(ApptCustomerID.Text))
            {
                ApptCustomerID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            }
            else
            {
                ApptCustomerID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            }
        }

        private void ApptStartDate_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void ApptEndDate_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
