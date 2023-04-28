using System;

namespace BOP3_Task_1_DB_and_File_Server_App.Database
{
    public class City : Country
    {
        public int cityId;
        public string city;
        //public int countryId;

        //The following variables are not used in the app, but are in the tables so they have default values.
        //public new DateTime createDate = DateTime.UtcNow;
        //public string createdBy = "Somebody";
        //public new DateTime lastUpdate = DateTime.UtcNow;
        //public string lastUpdateBy = "Somebody";
    }
}
