using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOP3_Task_1_DB_and_File_Server_App.Database
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

        //public BindingList<City> CityDB = new BindingList<City>();
        //public BindingList<City> CityDB = 

        public void AddCity()
        {
            //string sqlAddCity = "";
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
