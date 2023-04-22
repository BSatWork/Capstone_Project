using BOP3_Task_1_DB_and_File_Server_App.Database;
using System;
using System.Data;
using System.Windows.Forms;

namespace BOP3_Task_1_DB_and_File_Server_App
{
    public partial class AppointmentForm : Form
    {
        public MainScreen appMainScreen;
        public string query;
        public int appointmentId;

        public AppointmentForm(int appointmentId, MainScreen mainScreen, Appointment appointment = null)
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
            if (!string.IsNullOrEmpty(ApptUserIDComboBox.Text) &&
                !string.IsNullOrEmpty(ApptTypeComboBox.Text) &&
                !string.IsNullOrEmpty(ApptCustomerComboBox.Text) &&
                Int32.Parse(ApptStartDateTime.Value.ToString("hh")) > 8 &&
                Int32.Parse(ApptStartDateTime.Value.ToString("hh")) < 17 &&
                Int32.Parse(ApptEndDateTime.Value.ToString("hh")) > 8 &&
                Int32.Parse(ApptEndDateTime.Value.ToString("hh")) < 17)
            {
                Appointment appointment = new Appointment
                {
                    userId = Int32.Parse(ApptUserIDComboBox.Text),
                    customerName = ApptCustomerComboBox.Text,
                    type = ApptTypeComboBox.Text,
                    start = ApptStartDateTime.Value,
                    end = ApptEndDateTime.Value
                };

                //Todo Save the Appt data to the DB
                if (!ApptConflict(appointment.appointmentId, appointment.userId, appointment.start, appointment.end))
                {
                    query = "Insert Into client_schedule.appointment " +
                        $"Values({appointment})";
                    DBConnection.SaveToSQLTable(query);

                    Close();
                    appMainScreen.Show();
                }
                else
                {
                    MessageBox.Show("Please select another Start/End time.  The selected time conflicts with an existing appointment.");
                }
            }
            else
            {
                MessageBox.Show("Please verify all fields are populated and the start/end times are within the " +
                                "open business hours of 8 AM and 5 PM. Then try again.", "Input Validation");
            }
        }

        private void ApptDelete_Click(object sender, EventArgs e)
        {
            DialogResult delete = MessageBox.Show("This will delete the selected appointment, which cannot be undone. \n" +
                                                  "      Are you sure?", "Delete Confirmation", MessageBoxButtons.YesNo);

            switch (delete)
            {
                case DialogResult.Yes:
                    //Todo Delete the Appt from the DB.
                    query = "Delete from client_schedule.appointment " +
                    "where appointmentId = '" + appointmentId + "' ";
                    DBConnection.DeleteSQLTableRow(query);
                    Close();
                    appMainScreen.Show();
                    break;
                case DialogResult.No:
                    break;
            }
        }

        private bool ApptConflict(int appointmentId, int userId, DateTime start, DateTime end)
        {
            query = "Select Count(appointmentId) " +
                    "From client_schedule.appointment " +
                    $"Where appointment.userId = '{userId}' " +
                    $"And appointment.appointmentId <> '{appointmentId}' " +
                    $"And ('{start}' between appointment.start and appointment.end " +
                    $"Or '{end}' between appointment.start and appointment.end) " +
                    $"Or (appointment.start between '{start}' and '{end}' " +
                    $"Or appointment.end between '{start}' and '{end}' ";
            int DBCheck = Int32.Parse(DBConnection.GetSQLTableValue(query));

            if (DBCheck > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void ApptCancelButton_Click(object sender, EventArgs e)
        {
            Close();
            appMainScreen.Show();
        }

        private void ApptStartDateTime_ValueChanged(object sender, EventArgs e)
        {
            if(Int32.Parse(ApptStartDateTime.Value.ToString("hh")) < 8 ||
               Int32.Parse(ApptStartDateTime.Value.ToString("hh")) > 17)
            {
                MessageBox.Show("Please update your requested start time to be within the open business hours (8 AM - 5 PM).");
            }
        }

        private void ApptEndDateTime_ValueChanged(object sender, EventArgs e)
        {
            if (Int32.Parse(ApptEndDateTime.Value.ToString("hh")) < 8 ||
               Int32.Parse(ApptEndDateTime.Value.ToString("hh")) > 17)
            {
                MessageBox.Show("Please update your requested start time to be within the open business hours (8 AM - 5 PM).");
            }
        }
    }
}
