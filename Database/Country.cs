using System;

namespace BOP3_Task_1_DB_and_File_Server_App.Database
{
    public class Country
    {
        public int countryId;
        public string country;

        //The following variables are not used in the app, but are in the tables so they have default values.
        public DateTime createDate = DateTime.Parse("2019-01-01 00:00:00");
        public string createdBy = "Test";
        public DateTime lastUpdate = DateTime.Parse("2019-01-01 00:00:00");
        public string lastUpdateBy = "Test";
    }
}
