using RYM2_Capstone_Scheduling_App.Database;
using System;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace RYM2_Capstone_Scheduling_App
{
    public partial class AppLoginForm : Form
    {
        private readonly string LoginError = "Invalid Login Credentials.  Please try again.";
        private string LoginCheck;
        public string query;

        public AppLoginForm()
        {
            InitializeComponent();
            UserNameInputBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(CheckEnter);
            PasswordInputBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(CheckEnter);
            Show();

            //CultureInfo.CurrentCulture = new CultureInfo("de"); //For Testing purposes only.  Comment out for submission!
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
            //Verify if the User Name and password combination is in the User table.
            query = "Select Count(userName) " +
                    "From client_schedule.user " +
                    $"Where BINARY userName = '{UserNameInputBox.Text}' " +
                    $"And BINARY password =  '{PasswordInputBox.Text}' ";
            int credentialsCheck = int.Parse(DBConnection.GetSQLTableValue(query));

            if (credentialsCheck == 0)
            {
                LoginErrorLabel.Text = LoginError;
                LoginCheck = "Failed Login Attempt with User " + UserNameInputBox.Text + " at " + DateTime.UtcNow + "\n";
            }
            else
            {
                Hide();
                _ = new MainScreen(UserNameInputBox.Text);
                LoginCheck = "User " + UserNameInputBox.Text + " logged in successfully at " + DateTime.UtcNow + "\n";
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
            string LogFilePathHome = "C:\\Users\\Owner\\source\\repos\\BSatWork\\RYM2 Capstone Scheduling App\\LoginLogFile.txt";//For use on my home PC.
            string LogFilePath = "C:\\Users\\LabUser\\Documents\\Capstone_Project\\LoginLogFile.txt";//For use on the Virtual Lab PC.
            
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