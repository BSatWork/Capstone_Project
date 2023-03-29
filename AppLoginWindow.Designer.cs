namespace BOP3_Task_1_DB_and_File_Server_App
{
    partial class AppLoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LoginWelcomeLabel = new System.Windows.Forms.Label();
            this.UserNameInputBox = new System.Windows.Forms.TextBox();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.PasswordInputBox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.LoginErrorLabelEnglish = new System.Windows.Forms.Label();
            this.LoginErrorLabelUsersLanguage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LoginWelcomeLabel
            // 
            this.LoginWelcomeLabel.AutoSize = true;
            this.LoginWelcomeLabel.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginWelcomeLabel.Location = new System.Drawing.Point(50, 34);
            this.LoginWelcomeLabel.Name = "LoginWelcomeLabel";
            this.LoginWelcomeLabel.Size = new System.Drawing.Size(359, 35);
            this.LoginWelcomeLabel.TabIndex = 0;
            this.LoginWelcomeLabel.Text = "Appointment Scheduler";
            this.LoginWelcomeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // UserNameInputBox
            // 
            this.UserNameInputBox.AcceptsReturn = true;
            this.UserNameInputBox.AcceptsTab = true;
            this.UserNameInputBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameInputBox.Location = new System.Drawing.Point(189, 121);
            this.UserNameInputBox.Name = "UserNameInputBox";
            this.UserNameInputBox.Size = new System.Drawing.Size(218, 27);
            this.UserNameInputBox.TabIndex = 1;
            this.UserNameInputBox.WordWrap = false;
            this.UserNameInputBox.TextChanged += new System.EventHandler(this.UserNameInputBox_TextChanged);
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameLabel.Location = new System.Drawing.Point(54, 124);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(98, 19);
            this.UserNameLabel.TabIndex = 2;
            this.UserNameLabel.Text = "User Name";
            // 
            // PasswordInputBox
            // 
            this.PasswordInputBox.AcceptsReturn = true;
            this.PasswordInputBox.AcceptsTab = true;
            this.PasswordInputBox.BackColor = System.Drawing.Color.White;
            this.PasswordInputBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordInputBox.Location = new System.Drawing.Point(189, 189);
            this.PasswordInputBox.Name = "PasswordInputBox";
            this.PasswordInputBox.PasswordChar = '*';
            this.PasswordInputBox.Size = new System.Drawing.Size(218, 27);
            this.PasswordInputBox.TabIndex = 3;
            this.PasswordInputBox.WordWrap = false;
            this.PasswordInputBox.TextChanged += new System.EventHandler(this.PasswordInputBox_TextChanged);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.Location = new System.Drawing.Point(55, 189);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(87, 19);
            this.PasswordLabel.TabIndex = 4;
            this.PasswordLabel.Text = "Password";
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LoginButton.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.Location = new System.Drawing.Point(189, 251);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(218, 34);
            this.LoginButton.TabIndex = 5;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // LoginErrorLabelEnglish
            // 
            this.LoginErrorLabelEnglish.AutoSize = true;
            this.LoginErrorLabelEnglish.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginErrorLabelEnglish.ForeColor = System.Drawing.Color.Red;
            this.LoginErrorLabelEnglish.Location = new System.Drawing.Point(12, 306);
            this.LoginErrorLabelEnglish.Name = "LoginErrorLabelEnglish";
            this.LoginErrorLabelEnglish.Size = new System.Drawing.Size(360, 16);
            this.LoginErrorLabelEnglish.TabIndex = 6;
            this.LoginErrorLabelEnglish.Text = "Invalid User Name and/or Password.  Please try again.";
            // 
            // LoginErrorLabelUsersLanguage
            // 
            this.LoginErrorLabelUsersLanguage.AutoSize = true;
            this.LoginErrorLabelUsersLanguage.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginErrorLabelUsersLanguage.ForeColor = System.Drawing.Color.Red;
            this.LoginErrorLabelUsersLanguage.Location = new System.Drawing.Point(52, 85);
            this.LoginErrorLabelUsersLanguage.Name = "LoginErrorLabelUsersLanguage";
            this.LoginErrorLabelUsersLanguage.Size = new System.Drawing.Size(360, 16);
            this.LoginErrorLabelUsersLanguage.TabIndex = 7;
            this.LoginErrorLabelUsersLanguage.Text = "Invalid User Name and/or Password.  Please try again.";
            // 
            // AppLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 330);
            this.Controls.Add(this.LoginErrorLabelUsersLanguage);
            this.Controls.Add(this.LoginErrorLabelEnglish);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.PasswordInputBox);
            this.Controls.Add(this.UserNameLabel);
            this.Controls.Add(this.UserNameInputBox);
            this.Controls.Add(this.LoginWelcomeLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AppLoginForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Window";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LoginWelcomeLabel;
        private System.Windows.Forms.TextBox UserNameInputBox;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.TextBox PasswordInputBox;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label LoginErrorLabelEnglish;
        private System.Windows.Forms.Label LoginErrorLabelUsersLanguage;
    }
}

