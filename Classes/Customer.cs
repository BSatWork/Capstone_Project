//Customer class to pull the data from the Customer table in the SQL database.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOP3_Task_1_DB_and_File_Server_App.Classes
{
    public class Customer
    {
        public int customerID;
        public string customerName;
        public int AddressID;
        public int active;
        public DateTime createDate;
        public string createdBy;
        public DateTime lastUpdate;
        public string lastUpdateBy;

        // The following column strings are used to create the column header in the Appointments DGV.
        public string Customer_Name_Column { get { return customerName; } }

        public Customer()
        {
        
        }
    }
}
