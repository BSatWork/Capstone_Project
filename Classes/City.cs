using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOP3_Task_1_DB_and_File_Server_App.Classes
{
    public class City : Country
    {
        public int cityID;
        public string city;
        public int cityCountryID;

        //The following variables are not used in the app, but are in the tables so they have default values.
        public new DateTime createDate = DateTime.UtcNow;
        public new string createdBy = "Somebody";
        public new DateTime lastUpdate = DateTime.UtcNow;
        public new string lastUpdateBy = "Somebody";

        public void AddCity()
        {
            
        }

        public void UpdateCity(DateTime createDate, string createdBy)
        {
            lastUpdate = DateTime.Now;
            lastUpdateBy = "somebody"; //Todo Update to use the logged in User Name.

            //Todo Send createDate to the city table, when there's a change to the city
            //Todo Send createdBy to the city table, when there's a change to the city
        }

        public void DeleteCity()
        {
            
        }
    }
}
