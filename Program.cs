using RYM2_Capstone_Scheduling_App.Database;
using System;
using System.IO;
using System.Windows.Forms;

namespace RYM2_Capstone_Scheduling_App
{
    internal static class Program
    {
        [STAThread]

        static void Main()
        {
            string LogFilePath = "C:\\Users\\LabUser\\source\\repos\\BSatWork\\RYM2 Capstone Scheduling App\\LoginLogFile.txt";

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