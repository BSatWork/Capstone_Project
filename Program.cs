using BOP3_Task_1_DB_and_File_Server_App.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BOP3_Task_1_DB_and_File_Server_App
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DBConnection.StartConnection();
            //Test data for the DB...

            //Add "test" for the userName and password of userID 1.
            //Add "BSPatterson" and "P@$$w0rd" for userID 2.
            //Add 


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AppLoginForm());
            DBConnection.CloseConnection();
        }
    }
}
