using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BOP3_Task_1_DB_and_File_Server_App.Classes
{
    internal class Appointment
    {
        public BindingList<Appointment> AppointmentDB = new BindingList<Appointment>();

        public int appointmentID;
        public int customerID;
        public int userID;
        public string type;
        public DateTime start;
        public DateTime end;

        //The following variables are not used in the app, but are in the tables so they have default values.
        public string title = "Title";
        public string description = "Description";
        public string location = "Location";
        public string contact = "Contact";
        public string url = "URL";
        public DateTime createDate = DateTime.UtcNow;
        public string createdBy = "Somebody";
        public DateTime lastUpdate = DateTime.UtcNow;
        public string lastUpdateBy = "Somebody";

        public void AddAppointment(Appointment appointment)
        {
            AppointmentDB.Add(appointment);
        }

        public void UpdateAppointment(int existingAppointmentIndex, Appointment updatedAppointment)
        {
            Appointment existingAppointment = AppointmentDB[existingAppointmentIndex];
            int _ = existingAppointmentIndex++;

            if (updatedAppointment != existingAppointment)
            {
                AppointmentDB.Insert(existingAppointmentIndex, updatedAppointment);
                AppointmentDB.RemoveAt(_);
            }
        }

        public void DeleteAppointment(int appointmentID)
        {
            Appointment appointment = AppointmentDB[appointmentID];

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
            }
        }

        // The following column strings are used to create the column header in the Appointments DGV.
        public string Appointment_ID_Column { get { return appointmentID.ToString(); } }

        public string Type_Column { get { return type; } } 

        public string Start_DateTime_Column { get { return start.ToString(); } }

        public string End_DateTime_Column { get { return end.ToString(); } }
    }
}
