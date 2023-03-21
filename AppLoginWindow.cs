using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BOP3_Task_1_DB_and_File_Server_App
{
    public partial class AppLoginForm : Form
    {
        public bool loginSuccessful;
        private int DBuserID;
        private string DBuserName;
        private string DBpassword;

        //private DB User...
        //public DB Appointment...
        public MainScreen myMainScreen;

        public AppLoginForm()
        {
            InitializeComponent();
            LoginErrorLabelEnglish.Text = string.Empty;
            LoginErrorLabelOtherLanguage.Text = string.Empty;
        }

        private void UserNameInputBox_TextChanged(object sender, EventArgs e)
        {
            LoginErrorLabelEnglish.Text = string.Empty;
            LoginErrorLabelOtherLanguage.Text = string.Empty;
            // Validate that the User Name field is populated and the User Name is in the DB.
            if (!string.IsNullOrEmpty(UserNameInputBox.Text))// || UserNameInputBox.Text is in the UserDB for the UserID)
            {
                //Test this step.  Verify that when "Test" or "test" or "TEST" or any other option is input that is goes green.
                UserNameInputBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            }
            else
            {
                UserNameInputBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            }
        }

        private void PasswordInputBox_TextChanged(object sender, EventArgs e)
        {
            LoginErrorLabelEnglish.Text = string.Empty;
            LoginErrorLabelOtherLanguage.Text = string.Empty;
            // Validate that the Password field is populated and the Password is in the DB.
            if (!string.IsNullOrEmpty(PasswordInputBox.Text))
            {
                PasswordInputBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            }
            else
            {
                PasswordInputBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            // If all fields have been validated, then continue processing.  Otherwise, inform the user.
            if (UserNameInputBox.BackColor == System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192))))) &&
                PasswordInputBox.BackColor == System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192))))))// &&
                //UserNameInputBox.Text is in the UserDB for the UserID row && PasswordInputBox.Text is in the UserDB for the UserID row)
            {
                loginSuccessful = true;
                //Update DB user table to add a loginSuccessful = true row.
                Hide();
                _ = new MainScreen();
            }
            else
            {
                // Validate that the User Name field is populated and the User Name is in the DB.
                if (!string.IsNullOrEmpty(UserNameInputBox.Text))// || UserNameInputBox.Text is in the UserDB)
                {
                    UserNameInputBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
                }
                else
                {
                    UserNameInputBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
                }

                // Validate that the Password field is populated and the Password is in the DB.
                if (!string.IsNullOrEmpty(PasswordInputBox.Text))// || PasswordInputBox.Text is in the UserDB)
                {
                    PasswordInputBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
                }
                else
                {
                    PasswordInputBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
                }
               
                LoginErrorLabelEnglish.Text = "Invalid User Name and/or Password.  Please try again.";
                LoginErrorLabelOtherLanguage.Text = "Invalid User Name and/or Password.  Please try again.";

                //Update DB user table to add a loginSuccessful = false row.


            }
        }
    }
}
