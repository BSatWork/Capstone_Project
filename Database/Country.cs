using System;

namespace BOP3_Task_1_DB_and_File_Server_App.Database
{
    public class Country
    {
        public int countryID;
        public string country;

        //The following variables are not used in the app, but are in the tables so they have default values.
        public DateTime createDate = DateTime.UtcNow;
        public string createdBy = "Somebody";
        public DateTime lastUpdate = DateTime.UtcNow;
        public string lastUpdateBy = "Somebody";
    }
}
