using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOP3_Task_1_DB_and_File_Server_App.Classes
{
    public class Address : City
    {
        public int addressID;
        public string addressLine1;
        public string addressLine2;
        public int addressCityID;
        public string postalCode;
        public string phone;
        public DateTime createDate;
        public string createdBy;
        public new DateTime lastUpdate;
        public new string lastUpdatedBy;

        public Address()
        {

        }

        public new void Update(DateTime createDate, string createdBy)
        {
            lastUpdate = DateTime.Now;  //Todo Send to the address table, when there's a change to the address
            lastUpdatedBy = "somebody"; //Todo Send to the address table, when there's a change to the address

            //Todo Send createDate to the address table, when there's a change to the address
            //Todo Send createdBy to the address table, when there's a change to the address
        }
    }
}
