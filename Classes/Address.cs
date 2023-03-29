using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOP3_Task_1_DB_and_File_Server_App.Classes
{
    public class Address
    {
        public int addressID;
        public string address1;
        public string address2;
        public int cityID;
        public string postalCode;
        public string phone;
        public DateTime createDate;
        public string createdBy;
        public DateTime lastUpdate;
        public string lastUpdateBy;

        public Address() { }
    }
}
