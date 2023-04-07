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
        public BindingList<User> UserTable = new BindingList<User>();
        //public BindingList<Appointment> AppointmentTable = new BindingList<Appointment>();

        public bool loginSuccessful;
        private string usersLanguage;
        private string LoginErrorEnglish = "Invalid User Name and/or Password.  Please try again.";

        //private int DBuserID;
        //private string DBuserName;
        //private string DBpassword;

        //private DB User...
        //public DB Appointment...

        public AppLoginForm()
        {
            InitializeComponent();
            Show();
            Activate();
            LoginErrorLabelUsersLanguage.Text = string.Empty;
            LoginErrorLabelEnglish.Text = string.Empty;

            //Todo How to get the language the user's PC is set to.
            //Todo Set LoginErrorLabelOtherLanguage to German so there's a single place to update it, if needed.  Good place for Lambda use?
            usersLanguage = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;

        }

        private void UserNameInputBox_TextChanged(object sender, EventArgs e)
        {
            LoginErrorLabelUsersLanguage.Text = string.Empty;
            LoginErrorLabelEnglish.Text = string.Empty;
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
            LoginErrorLabelUsersLanguage.Text = string.Empty;
            LoginErrorLabelEnglish.Text = string.Empty;
            
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
            //Todo Capture the system language for user input errors.
            
            //If all fields have been validated, then continue processing.  Otherwise, inform the user.
            if (UserNameInputBox.BackColor == System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192))))) &&
                PasswordInputBox.BackColor == System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192))))))// &&
                //UserNameInputBox.Text is in the UserDB for the UserID row && PasswordInputBox.Text is in the UserDB for the UserID row)
            {
                loginSuccessful = true;
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

                if (usersLanguage == "en")
                {
                    LoginErrorLabelUsersLanguage.Text = LoginErrorEnglish.ToString();
                }
                
                if (usersLanguage != "en")
                {
                    //Todo LoginErrorLabelUsersLanguage.Text = LoginErrorLabelEnglish.ToString(usersLanguage);
                    LoginErrorLabelEnglish.Text = LoginErrorEnglish.ToString();
                }


                //Todo Update DB user table to add a loginSuccessful = false row?


            }
        }

        private void CloseLoginButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
