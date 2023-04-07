//Customer class to pull the data from the Customer table in the SQL database.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOP3_Task_1_DB_and_File_Server_App.Classes
{
    public class Customer : Address
    {
        public int customerID;
        public string customerName;
        public int customerAddressID;
        public int active;
        public DateTime createDate;
        public string createdBy;
        public new DateTime lastUpdate;
        public new string lastUpdatedBy;

        // The following column strings are used to create the column header in the Appointments DGV.
        public string Customer_Name_Column { get { return customerName; } }

        public Customer()
        {
            customerID = 0;
            customerName = string.Empty;
            customerAddressID = 0;
            active = 0;


        }

        public void Update()
        {
            lastUpdate = DateTime.Now;  //Todo Send to the customer table, when there's a change to the customer
            lastUpdatedBy = "somebody"; //Todo Send to the customer table, when there's a change to the customer

            //Todo Send createDate to the customer table, when there's a change to the customer
            //Todo Send createdBy to the customer table, when there's a change to the customer
        }
    }
}
