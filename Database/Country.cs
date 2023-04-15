using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOP3_Task_1_DB_and_File_Server_App.Database
{
    public class Country
    {
        public int countryID;
        public string country;

        //The following variables are not used in the app, but are in the tables so they have default values.
        public DateTime createDate = DateTime.UtcNow;
        public string createdBy = "Somebody";
        public DateTime lastUpdate = DateTime.UtcNow;
        public string lastUpdateBy = "Somebody";

        public void AddCountry()
        {
            
        }

        public void UpdateCountry(DateTime createDate, string createdBy)
        {
            lastUpdate = DateTime.Now;
            lastUpdateBy = "somebody"; //Todo Update to use the logged in User Name.

            //Todo Send createDate to the country table, when there's a change to the country
            //Todo Send createdBy to the country table, when there's a change to the country
        }

        public void DeleteCountry()
        {
            
        }
    }
}
