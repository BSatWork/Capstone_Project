using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BOP3_Task_1_DB_and_File_Server_App.Classes
{
    internal class Appointment
    {
        //public BindingList<Customer> CustomerTable = new BindingList<Customer>();

        public int appointmentID;
        public int customerID;
        public int userID;
        public string type;
        public DateTime start;
        public DateTime end;

        public string title;
        public string description;
        public string location;
        public string contact;
        public string url;
        public DateTime createDate;
        public string createdBy;
        public DateTime lastUpdate;
        public string lastUpdateBy;





        public void AddAppointment()
        {

            createDate = DateTime.UtcNow;
            createdBy = "somebody";
            //Todo Send to the appointment table
            //Todo Send to the appointment table
        }

        public void UpdateAppointment()
        {
            lastUpdate = DateTime.UtcNow;   //Todo Send to the appointment table
            lastUpdateBy = "somebody";      //Todo Send to the appointment table
        }

        public void DeleteAppointment()
        {

        }

        // The following column strings are used to create the column header in the Appointments DGV.
        public string Appointment_ID_Column { get { return appointmentID.ToString(); } }

        public string Type_Column { get { return type; } } 

        public string Start_DateTime_Column { get { return start.ToString(); } }

        public string End_DateTime_Column { get { return end.ToString(); } }
    }
}
