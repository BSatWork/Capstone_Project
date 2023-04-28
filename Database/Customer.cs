using System;

namespace BOP3_Task_1_DB_and_File_Server_App.Database
{
    public class Customer : Address
    {
        public int customerId;
        public string customerName;
        //public int addressId;

        //The following variables are not used in the app, but are in the tables so they have default values.
        public int active = 1;
        //public new DateTime createDate = DateTime.UtcNow;
        //public new string createdBy = "Somebody";
        //public new DateTime lastUpdate = DateTime.UtcNow;
        //public new string lastUpdateBy = "Somebody";
    }
}
