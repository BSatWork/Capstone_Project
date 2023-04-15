using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOP3_Task_1_DB_and_File_Server_App.Database
{
    public class Address : City
    {
        public int addressID;
        public string addressLine1;
        public string addressLine2;
        public int addressCityID;
        public string phone;

        //The following variables are not used in the app, but are in the tables so they have default values.
        public string postalCode = "Somewhere";
        public new DateTime createDate = DateTime.UtcNow;
        public new string createdBy = "Somebody";
        public new DateTime lastUpdate = DateTime.UtcNow;
        public new string lastUpdateBy = "Somebody";

        public void AddAddress()
        {

        }

        public void UpdateAddress(DateTime createDate, string createdBy)
        {
            lastUpdate = DateTime.Now;
            lastUpdateBy = "somebody";  //Todo Update to use the logged in User Name.

            //Todo Send createDate to the address table, when there's a change to the address
            //Todo Send createdBy to the address table, when there's a change to the address
        }

        public void DeleteAddress()
        {

        }
    }
}
