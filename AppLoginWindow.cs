using BOP3_Task_1_DB_and_File_Server_App.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BOP3_Task_1_DB_and_File_Server_App
{
    public partial class AppLoginForm : Form
    {
        //public bool loginSuccessful;
        private readonly string LoginError = "Invalid Login Credentials.  Please try again.";

        public AppLoginForm()
        {
            InitializeComponent();
            //Show();
            //Activate();

            //CultureInfo.CurrentCulture = new CultureInfo("de"); //Todo For Testing purposes only.  Remove before submission!!!

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
            //Todo Validate that the User Name field is populated and the User Name is in the DB.
            if (!string.IsNullOrEmpty(UserNameInputBox.Text))// || UserNameInputBox.Text is in the UserDB for the UserID)
            {
                //Todo Test this step.  Verify that when "Test" or "test" or "TEST" or any other option is input that is goes green.
                UserNameInputBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            }
            else
            {
                UserNameInputBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            }
        }

        private void PasswordInputBox_TextChanged(object sender, EventArgs e)
        {            
            if (string.IsNullOrEmpty(PasswordInputBox.Text))  //Todo && password is in the User DB for the input UserName
            {
                PasswordInputBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            } //Todo Is there a need/benefit to use coloring for the password field?  Is this a security concern?
            /**else
            {
                PasswordInputBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            }*/
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {            
            //If all fields have been validated, then continue processing.  Otherwise, inform the user.
            if (UserNameInputBox.BackColor == System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192))))) &&
                PasswordInputBox.BackColor == System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192))))))// &&
                //UserNameInputBox.Text is in the UserDB for the UserID row && PasswordInputBox.Text is in the UserDB for the UserID row)
            {
                //Todo Update DB user table to add new record with active = true, create date and created by.
                
                Hide();
                _ = new MainScreen();
            }
            else
            {
                //Todo Validate that the User Name field is populated and the User Name is in the DB.
                if (!string.IsNullOrEmpty(UserNameInputBox.Text))// || UserNameInputBox.Text is in the UserDB)
                {
                    UserNameInputBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
                }
                else
                {
                    UserNameInputBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
                }

                //Todo Validate that the Password field is populated and the Password is in the DB.
                if (!string.IsNullOrEmpty(PasswordInputBox.Text))// || PasswordInputBox.Text is in the UserDB)
                {
                    PasswordInputBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
                }
                else
                {
                    PasswordInputBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
                }

                LoginErrorLabel.Text = LoginError;
            }
        }

        private void CloseLoginLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
