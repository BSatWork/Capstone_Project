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
    }
}
