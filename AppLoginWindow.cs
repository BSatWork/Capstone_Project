using BOP3_Task_1_DB_and_File_Server_App.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace BOP3_Task_1_DB_and_File_Server_App
{
    public partial class AppLoginForm : Form
    {
        private readonly string LoginError = "Invalid Login Credentials.  Please try again.";
        private string LoginCheck;

        public AppLoginForm()
        {
            InitializeComponent();
            UserNameInputBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(CheckEnter);
            PasswordInputBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(CheckEnter);
            Show();

            //CultureInfo.CurrentCulture = new CultureInfo("de"); //For Testing purposes only.  Comment out for submission!  Do a similar line for TZ test.

            //Language check - German
            if (CultureInfo.CurrentCulture.TwoLetterISOLanguageName == "de")
            {
                AppLoginForm.ActiveForm.Text = "Anmeldefenster";
                LoginWelcomeLabel.Text = "Terminplaner";
                UserNameLabel.Text = "Nutzername";
                PasswordLabel.Text = "Passwort";
                LoginButton.Text = "Anmeldung";
                CloseLoginLabel.Text = "Schließen";

                LoginError = "Ungültige Login-Details. Bitte versuche es erneut.";
            }
        }

        private void UserNameInputBox_TextChanged(object sender, EventArgs e)
        {
            LoginErrorLabel.Text = string.Empty;
        }

        private void PasswordInputBox_TextChanged(object sender, EventArgs e)
        {
            LoginErrorLabel.Text = string.Empty;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            User validateUserName = new User();
            User validatePassword = new User();

            if (validateUserName.GetSingleTableValue("userName", UserNameInputBox.Text) == UserNameInputBox.Text &&     //Verify if the User Name is in the User table.
                validatePassword.GetSingleTableValue("password", PasswordInputBox.Text) == PasswordInputBox.Text)       //Verify if the Password is in the User table.
            {
                Hide();
                _ = new MainScreen();
                LoginCheck = "User " + UserNameInputBox.Text + " logged in successfully at " + DateTime.UtcNow + "\n";
            }
            else
            {
                LoginErrorLabel.Text = LoginError;
                LoginCheck = "Failed Login Attempt with User " + UserNameInputBox.Text + " at " + DateTime.UtcNow + "\n";
            }

            LoginAttempt(LoginCheck);
        }

        private void CheckEnter(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                LoginButton_Click(sender, e);
            }
        }

        static void LoginAttempt(string LoginCheck)
        {
            string LogFilePathHome = "C:\\Users\\Owner\\source\\repos\\BSatWork\\BOP3-Task-1---Brady-Patterson\\LoginLogFile.txt";//For use on my home PC.
            string LogFilePath = "C:\\Users\\LabUser\\Documents\\C969 Project\\LoginLogFile.txt";//For use on the Virtual Lab PC.
            
            if(File.Exists(LogFilePathHome))
            {
                File.AppendAllText(LogFilePathHome, LoginCheck);//add text to existing file
            }

            if (File.Exists(LogFilePath))
            {
                File.AppendAllText(LogFilePath, LoginCheck);//add text to existing file
            }
        }

        private void CloseLoginLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
