using BOP3_Task_1_DB_and_File_Server_App.Database;
using System;
using System.Windows.Forms;

namespace BOP3_Task_1_DB_and_File_Server_App
{
    public partial class AppointmentForm : Form
    {
        public MainScreen appMainScreen;
        public string query;
        public int apptId;
        public bool apptUpdate;
        public bool noUpdates = true;
        public int existingUserId;
        public string existingType;
        public string existingCustomerName;
        public DateTime existingStart;
        public DateTime existingEnd;

        public AppointmentForm(MainScreen mainScreen, int appointmentId)//Appointment appointment = null)
        {
            InitializeComponent();
            Show();
            Activate();
            appMainScreen = mainScreen;
            apptId = appointmentId;

            ApptUserIDComboBox.DataSource = DBConnection.GetSQLTable("Select distinct user.userId from client_schedule.user");
            ApptUserIDComboBox.DisplayMember = "userId";
            ApptUserIDComboBox.SelectedIndex = -1;
            //ApptTypeComboBox.DataSource is populated by default in my design.
            ApptCustomerComboBox.DataSource = DBConnection.GetSQLTable("Select distinct customer.customerName from client_schedule.customer");
            ApptCustomerComboBox.DisplayMember = "customerName";
            ApptCustomerComboBox.SelectedIndex = -1;
            ApptStartDateTime.Value = DateTime.Now.AddMinutes(15);

            if (appointmentId == 0) //Save a new appt.
            {
                ApptDeleteButton.Visible = false;
                ApptCancelButton.Visible = true;
            }
            else //Update an existing appt.
            {
                ApptCancelButton.Visible = false;
                ApptDeleteButton.Visible = true;
                
                apptUpdate = true;
                existingUserId = Int32.Parse(DBConnection.GetSQLTableValue($"Select appointment.userId From client_schedule.appointment Where appointmentId = '{appointmentId}' "));
                existingType = DBConnection.GetSQLTableValue($"Select appointment.type From client_schedule.appointment Where appointmentId = '{appointmentId}' ").ToString();
                existingCustomerName = DBConnection.GetSQLTableValue($"Select customer.customerName From client_schedule.customer Left Join client_schedule.appointment on customer.customerId = appointment.customerId Where appointmentId = '{appointmentId}' ").ToString();
                existingStart = DateTime.Parse(DBConnection.GetSQLTableValue($"Select appointment.start From client_schedule.appointment Where appointmentId = '{appointmentId}' "));
                existingEnd = DateTime.Parse(DBConnection.GetSQLTableValue($"Select appointment.end From client_schedule.appointment Where appointmentId = '{appointmentId}' "));

                ApptUserIDComboBox.Text = existingUserId.ToString();
                ApptTypeComboBox.Text = existingType;
                ApptCustomerComboBox.Text = existingCustomerName;
                ApptStartDateTime.Value = existingStart;
                ApptEndDateTime.Value = existingEnd;
            }
        }

        private void ApptSave_Click(object sender, EventArgs e)
        {
            if (ApptEndDateTime.Value <= ApptStartDateTime.Value)
            {
                MessageBox.Show("Please make sure the requested End time is after the Start time.  Then Try again.", "Input Validation");
            }
            else
            {
                // If all fields have been validated, then continue processing.  Otherwise, inform the user.
                if (!string.IsNullOrEmpty(ApptUserIDComboBox.Text) &&
                !string.IsNullOrEmpty(ApptTypeComboBox.Text) &&
                !string.IsNullOrEmpty(ApptCustomerComboBox.Text) &&
                Int32.Parse(ApptStartDateTime.Value.ToString(@"HH")) > 8 &&
                Int32.Parse(ApptStartDateTime.Value.ToString(@"HH")) < 17 &&
                Int32.Parse(ApptEndDateTime.Value.ToString(@"HH")) > 8 &&
                Int32.Parse(ApptEndDateTime.Value.ToString(@"HH")) < 17)
                {
                    Appointment appointment = new Appointment
                    {
                        appointmentId = apptId,
                    };

                    if (!apptUpdate)
                    {
                        appointment.appointmentId = Int32.Parse(DBConnection.GetSQLTableValue("Select Max(appointment.appointmentId) From client_schedule.appointment")) + 1;
                        appointment.userId = Int32.Parse(ApptUserIDComboBox.Text);
                        appointment.customerId = Int32.Parse(DBConnection.GetSQLTableValue($"Select customer.customerId From client_schedule.customer Where customerName = '{ApptCustomerComboBox.Text}'"));
                        appointment.type = ApptTypeComboBox.Text;
                        appointment.start = ApptStartDateTime.Value;
                        appointment.end = ApptEndDateTime.Value;

                        if (!ApptConflict(appointment.appointmentId, appointment.userId, appointment.start, appointment.end))
                        {
                            query = "Insert Into client_schedule.appointment " +
                                "Values(" +
                                "'" + appointment.appointmentId + "', " +
                                "'" + appointment.customerId + "', " +
                                "'" + appointment.userId + "', " +
                                "'" + appointment.title + "', " +
                                "'" + appointment.description + "', " +
                                "'" + appointment.location + "', " +
                                "'" + appointment.contact + "', " +
                                "'" + appointment.type + "', " +
                                "'" + appointment.url + "', " +
                                "'" + appointment.start.ToString("yyyy-MM-dd HH:mm:00") + "', " +
                                "'" + appointment.end.ToString("yyyy-MM-dd HH:mm:00") + "', " +
                                "'" + appointment.createDate.ToString("yyyy-MM-dd HH:mm:00") + "', " +
                                "'" + appointment.createdBy + "', " +
                                "'" + appointment.lastUpdate.ToString("yyyy-MM-dd HH:mm:00") + "', " +
                                "'" + appointment.lastUpdateBy + "') ";
                            DBConnection.SaveToSQLTable(query);

                            //Todo After Save, make sure the DGV updates.
                            Close();
                            appMainScreen.Show();
                        }
                        else
                        {
                            MessageBox.Show("Please select another Start/End time.  The selected time conflicts with an existing appointment." +
                                            "Input Validation");
                        }
                    }
                    else
                    {
                        if (Int32.Parse(ApptUserIDComboBox.Text.ToString()) == existingUserId)
                        {
                            appointment.userId = existingUserId;
                        }
                        else
                        {
                            noUpdates = false;
                            appointment.userId = Int32.Parse(ApptUserIDComboBox.Text.ToString());
                        }

                        if (ApptTypeComboBox.Text == existingType)
                        {
                            appointment.type = existingType;
                        }
                        else
                        {
                            noUpdates = false;
                            appointment.type = ApptTypeComboBox.Text;
                        }

                        if (ApptCustomerComboBox.Text != existingCustomerName)
                        {
                            query = "Select customerId from client_schedule.appointment " +
                                    $"Left Join client_schedule.appointment on customer.customerId = appointment.customerId Where appointmentId = '{appointment.appointmentId}' ";
                            int customerId = Int32.Parse(DBConnection.GetSQLTableValue(query));
                            query = "Update client_schedule.customer " +
                                    $"Set customer.customerName = {ApptCustomerComboBox.Text} " +
                                    $"Where customer.customerId = {customerId} ";
                            DBConnection.SaveToSQLTable(query);
                        }

                        if (DateTime.Parse(ApptStartDateTime.Text) == existingStart)
                        {
                            appointment.start = existingStart;
                        }
                        else
                        {
                            noUpdates = false;
                            appointment.start = DateTime.Parse(ApptStartDateTime.Text);
                        }

                        if (DateTime.Parse(ApptEndDateTime.Text) == existingEnd)
                        {
                            appointment.end = existingEnd;
                        }
                        else
                        {
                            noUpdates = false;

                            appointment.end = DateTime.Parse(ApptEndDateTime.Text);
                        }

                        if (!noUpdates)
                        {
                            if (!ApptConflict(appointment.appointmentId, appointment.userId, appointment.start, appointment.end))
                            {
                                query = "Update client_schedule.appointment " +
                                        $"Set appointment.userId = '{appointment.userId}', " +
                                        $"appointment.type = '{appointment.type}', " +
                                        $"appointment.start = '{appointment.start.ToString("yyyy-MM-dd HH:mm:00")}', " +
                                        $"appointment.end = '{appointment.end.ToString("yyyy-MM-dd HH:mm:00")}' " +
                                        $"Where appointment.appointmentId = '{appointment.appointmentId}'";
                                DBConnection.SaveToSQLTable(query);
                            }
                            else
                            {
                                MessageBox.Show("Please select another Start/End time.  The selected time conflicts with an existing appointment." +
                                                "Input Validation");
                            }
                        }
                        //Todo After Update, make sure the DGV updates.
                        Close();
                        appMainScreen.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Please verify all fields are populated and the start/end times are within the " +
                                    "open business hours of 8 AM and 5 PM.\n\nThen try again.", "Input Validation");
                }
            }
        }

        private void ApptDelete_Click(object sender, EventArgs e)
        {
            DialogResult delete = MessageBox.Show("This will delete the appointment, which cannot be undone. \n\n" +
                                                  "Are you sure?", "Delete Confirmation", MessageBoxButtons.YesNo);
            
            switch (delete)
            {
                case DialogResult.Yes:
                    query = "Delete from client_schedule.appointment " +
                    "Where appointmentId = '" + apptId + "' ";
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
                    $"And (('{start:yyyy-MM-dd HH:mm:ss}' between appointment.start and appointment.end " +
                    $"Or '{end:yyyy-MM-dd HH:mm:ss}' between appointment.start and appointment.end) " +
                    $"Or (appointment.start between '{start:yyyy-MM-dd HH:mm:ss}' and '{end:yyyy-MM-dd HH:mm:ss}' " +
                    $"Or appointment.end between '{start:yyyy-MM-dd HH:mm:ss}' and '{end:yyyy-MM-dd HH:mm:ss}')) ";
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

        private void ApptStartDateTime_ValueChanged(object sender, EventArgs e)
        {
            ApptEndDateTime.Value = ApptStartDateTime.Value.AddMinutes(15);
        }

        private void ApptCancelButton_Click(object sender, EventArgs e)
        {
            Close();
            appMainScreen.Show();
        }

        private void ApptScreenCloseButton_Click(object sender, EventArgs e)
        {
            Close();
            appMainScreen.Show();
        }
    }
}
