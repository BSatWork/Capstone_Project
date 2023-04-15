using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOP3_Task_1_DB_and_File_Server_App.Classes
{
    public class User
    {
        public int userID;
        public string userName;
        public string password;

        //The following variables are not used in the app, but are in the tables so they have default values.
        public int active = 1;
        public DateTime createDate = DateTime.UtcNow;
        public string createdBy = "Somebody";
        public DateTime lastUpdate = DateTime.UtcNow;
        public string lastUpdateBy = "Somebody";

        public void AddUser()
        {

        }

        public void UpdateUser()
        {
            lastUpdate = DateTime.Now;  //Todo Send to the user table, when there's a change to the user
            lastUpdateBy = "somebody"; //Todo Send to the user table, when there's a change to the user

            //Todo Send createDate to the user table, when there's a change to the user
            //Todo Send createdBy to the user table, when there's a change to the user
        }

        public void DeleteUser()
        {
            
        }
    }
}
