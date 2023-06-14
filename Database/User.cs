using System;

namespace RYM2_Capstone_Scheduling_App.Database
{
    public class User
    {
        public int userId;
        public string userName;
        public string password;

        //The following variables are not used in the app, but are in the tables so they have default values.
        public int active = 1;
        public DateTime createDate = DateTime.UtcNow;
        public string createdBy = "Somebody";
        public DateTime lastUpdate = DateTime.UtcNow;
        public string lastUpdateBy = "Somebody";
    }
}