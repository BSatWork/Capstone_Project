using BOP3_Task_1_DB_and_File_Server_App.Database;
using System;
using System.Windows.Forms;

namespace BOP3_Task_1_DB_and_File_Server_App
{
    public partial class AppointmentForm : Form
    {
        public MainScreen appMainScreen;
        public string query;
        public int appointmentId;

        public AppointmentForm(MainScreen mainScreen, Appointment appointment = null)
        {
            InitializeComponent();
            Show();
            Activate();
            appMainScreen = mainScreen;

            ApptUserIDComboBox.DataSource = DBConnection.GetSQLTable("Select distinct appointment.userId from client_schedule.appointment");
            ApptUserIDComboBox.DisplayMember = "userId";
            ApptUserIDComboBox.SelectedIndex = -1;
            //ApptTypeComboBox.DataSource is populated by default in my design.
            ApptCustomerComboBox.DataSource = DBConnection.GetSQLTable("Select distinct customer.customerName from client_schedule.customer");
            ApptCustomerComboBox.DisplayMember = "customerName";
            ApptCustomerComboBox.SelectedIndex = -1;
            ApptStartDateTime.Value = DateTime.Now;
            ApptEndDateTime.Value = DateTime.Now;

            if (appointment == null)
            {
                ApptDeleteButton.Visible = false;
                ApptCancelButton.Visible = true;
            }
            else
            {
                ApptCancelButton.Visible = false;
                ApptDeleteButton.Visible = true;

                appointmentId = appointment.appointmentId;
                ApptUserIDComboBox.Text = appointment.userId.ToString();
                ApptCustomerComboBox.Text = appointment.customerName.ToString();
                ApptTypeComboBox.Text = appointment.type.ToString();
                ApptStartDateTime.Value = appointment.start;
                ApptEndDateTime.Value = appointment.end;
            }
        }

        private void ApptSave_Click(object sender, EventArgs e)
        {
            // If all fields have been validated, then continue processing.  Otherwise, inform the user.
            if (!string.IsNullOrEmpty(ApptUserIDComboBox.Text) && !string.IsNullOrEmpty(ApptTypeComboBox.Text) && !string.IsNullOrEmpty(ApptCustomerComboBox.Text)
                )
            {
                Appointment NewAppointment = new Appointment();
                
                //Todo Save the Appt data to the DB
                ApptUserIDComboBox.Text = NewAppointment.userId.ToString();
                ApptCustomerComboBox.Text = NewAppointment.customerName.ToString();
                ApptTypeComboBox.Text = NewAppointment.type.ToString();
                ApptStartDateTime.Value = NewAppointment.start;
                ApptEndDateTime.Value = NewAppointment.end;

                query = "Insert Into client_schedule.appointment " +
                        "Values(" + NewAppointment + ")";
                DBConnection.SaveToSQLTable(query);

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
                    query = "Delete from client_schedule.appointment " +
                    "where appointmentId = '" + appointmentId + "'";
                    DBConnection.DeleteSQLTableRow(query);

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
