using System;

namespace BOP3_Task_1_DB_and_File_Server_App.Database
{
    public class Appointment : Customer
    {
        public int appointmentId;
        public int userId;
        public string type;
        public DateTime start;
        public DateTime end;

        //The following variables are not used in the app, but are in the tables so they have default values.
        public string title = "Title";
        public string description = "Description";
        public string location = "Location";
        public string contact = "Contact";
        public string url = "URL";
        public new DateTime createDate = DateTime.UtcNow;
        public new string createdBy = "Somebody";
        public new DateTime lastUpdate = DateTime.UtcNow;
        public new string lastUpdateBy = "Somebody";

        public void AddAppointment(Appointment appointment)
        {
            
            
            //AppointmentDB.Add(appointment);
        }

        public void UpdateAppointment(int existingAppointmentIndex, Appointment updatedAppointment)
        {
            
            
            
            
            /*Appointment existingAppointment = AppointmentDB[existingAppointmentIndex];
            int _ = existingAppointmentIndex++;

            if (updatedAppointment != existingAppointment)
            {
                AppointmentDB.Insert(existingAppointmentIndex, updatedAppointment);
                AppointmentDB.RemoveAt(_);
            }*/
        }

        public void DeleteAppointment(int appointmentID)
        {
            /*Appointment appointment = AppointmentDB[appointmentID];

            // Prompt the user for delete confirmation.
            DialogResult delete = MessageBox.Show("This will delete Appoointment ID " + appointment.appointmentID + " which cannot be undone."
                    + "  Are you sure?", "Delete Confirmation", MessageBoxButtons.YesNo);

            switch (delete)
            {
                case DialogResult.Yes:
                    AppointmentDB.Remove(appointment);
                    break;
                case DialogResult.No:
                    break;
            }*/
        }
    }
}
