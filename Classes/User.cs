﻿using System;
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
        public bool active;
        public DateTime createDate;
        public string createdBy;
        public DateTime lastUpdate;
        public string lastUpdateBy;

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
    }
}
