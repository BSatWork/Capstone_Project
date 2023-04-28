using System;

namespace BOP3_Task_1_DB_and_File_Server_App.Database
{
    public class Address : City
    {
        public int addressId;
        public string addressLine1;
        public string addressLine2;
        //public int cityId;
        public string phone;

        //The following variables are not used in the app, but are in the tables so they have default values.
        public string postalCode = "Somewhere";
        //public new DateTime createDate = DateTime.UtcNow;
        //public string createdBy = "Somebody";
        //public new DateTime lastUpdate = DateTime.UtcNow;
        //public string lastUpdateBy = "Somebody";
    }
}
