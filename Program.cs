using BOP3_Task_1_DB_and_File_Server_App.Database;
using System;
using System.IO;
using System.Windows.Forms;

namespace BOP3_Task_1_DB_and_File_Server_App
{
    internal static class Program
    {
        [STAThread]

        static void Main()
        {
            string LogFilePath = "C:\\Users\\LabUser\\Documents\\Capstone Project\\LoginLogFile.txt";//For use on the Virtual Lab PC.

            if (File.Exists(LogFilePath))
            {
                DBConnection.StartConnection();
            }
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AppLoginForm());

            if (File.Exists(LogFilePath))
            {
                DBConnection.CloseConnection();
            }
        }
    }
}