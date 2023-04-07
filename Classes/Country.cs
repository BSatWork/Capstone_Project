using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOP3_Task_1_DB_and_File_Server_App.Classes
{
    public class Country
    {
        public int countryID;
        public string country;
        //public DateTime createDate;
        //public string createdBy;
        public DateTime lastUpdate;
        public string lastUpdateBy;

        public Country()
        {
            countryID = 0;  //Todo Pull this from the country table
            country = null; //Todo Pull this from the country table
        }

        public void Update(DateTime createDate, string createdBy)
        {
            lastUpdate = DateTime.Now;  //Todo Send to the country table, when there's a change to the country
            lastUpdateBy = "somebody"; //Todo Send to the country table, when there's a change to the country

            //Todo Send createDate to the country table, when there's a change to the country
            //Todo Send createdBy to the country table, when there's a change to the country
        }
    }
}
