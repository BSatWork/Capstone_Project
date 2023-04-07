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
        //public new DateTime createDate;
        //public new string createdBy;
        public new DateTime lastUpdate;
        public new string lastUpdatedBy;

        public City()
        {
            cityID = 0;         //Todo Pull this from the city table
            city = null;        //Todo Pull this from the city table
            cityCountryID = 0;  //Todo Pull this from the city table
        }

        public new void Update(DateTime createDate, string createdBy)
        {
            lastUpdate = DateTime.Now;  //Todo Send to the city table, when there's a change to the city
            lastUpdatedBy = "somebody"; //Todo Send to the city table, when there's a change to the city

            //Todo Send createDate to the city table, when there's a change to the city
            //Todo Send createdBy to the city table, when there's a change to the city
        }
    }
}
