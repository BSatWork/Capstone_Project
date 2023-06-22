using System;

namespace RYM2_Capstone_Scheduling_App.Database
{
    public class Appointment
    {
        public int appointmentId;
        public int customerId;
        public int userId;
        public string type;
        public DateTime start;
        public DateTime end;

        //The following variables are not used in the app, but are in the tables so they have default values.
        public DateTime createDate = DateTime.Parse("2019-01-01 00:00:00");
        public string createdBy = "Test";
        public DateTime lastUpdate = DateTime.Parse("2019-01-01 00:00:00");
        public string lastUpdateBy = "Test";
    }
}