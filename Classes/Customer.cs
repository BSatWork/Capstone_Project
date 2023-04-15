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

        //The following variables are not used in the app, but are in the tables so they have default values.
        public int active = 1;
        public new DateTime createDate = DateTime.UtcNow;
        public new string createdBy = "Somebody";
        public new DateTime lastUpdate = DateTime.UtcNow;
        public new string lastUpdateBy = "Somebody";

        // The following column strings are used to create the column header in the Appointments DGV.
        public string Customer_Name_Column { get { return customerName; } }

        public void AddCustomer()
        {
            
        }

        public void UpdateCustomer()
        {
            lastUpdate = DateTime.Now;  //Todo Send to the customer table, when there's a change to the customer
            lastUpdateBy = "somebody"; //Todo Send to the customer table, when there's a change to the customer

            //Todo Send createDate to the customer table, when there's a change to the customer
            //Todo Send createdBy to the customer table, when there's a change to the customer
        }

        public void DeleteCustomer()
        {

        }
    }
}
