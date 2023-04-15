namespace BOP3_Task_1_DB_and_File_Server_App
{
    partial class AppointmentForm
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
            System.Windows.Forms.DateTimePicker ApptStartDateTime;
            System.Windows.Forms.DateTimePicker ApptEndDateTime;
            this.ApptSaveButton = new System.Windows.Forms.Button();
            this.ApptDeleteButton = new System.Windows.Forms.Button();
            this.ApptTypeLabel = new System.Windows.Forms.Label();
            this.ApptEndDateLabel = new System.Windows.Forms.Label();
            this.ApptCustomerIDLabel = new System.Windows.Forms.Label();
            this.ApptStartDateLabel = new System.Windows.Forms.Label();
            this.ApptCancelButton = new System.Windows.Forms.Button();
            this.ApptUserID = new System.Windows.Forms.TextBox();
            this.ApptUserIDLabel = new System.Windows.Forms.Label();
            this.ApptTypeListBox = new System.Windows.Forms.ListBox();
            this.ApptCustomerListBox = new System.Windows.Forms.ListBox();
            ApptStartDateTime = new System.Windows.Forms.DateTimePicker();
            ApptEndDateTime = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // ApptStartDateTime
            // 
            ApptStartDateTime.CustomFormat = "MM/dd/yyyy hh:mm tt";
            ApptStartDateTime.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ApptStartDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            ApptStartDateTime.Location = new System.Drawing.Point(205, 182);
            ApptStartDateTime.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            ApptStartDateTime.Name = "ApptStartDateTime";
            ApptStartDateTime.Size = new System.Drawing.Size(194, 21);
            ApptStartDateTime.TabIndex = 20;
            ApptStartDateTime.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // ApptEndDateTime
            // 
            ApptEndDateTime.CustomFormat = "MM/dd/yyyy hh:mm tt";
            ApptEndDateTime.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ApptEndDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            ApptEndDateTime.Location = new System.Drawing.Point(205, 232);
            ApptEndDateTime.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            ApptEndDateTime.Name = "ApptEndDateTime";
            ApptEndDateTime.Size = new System.Drawing.Size(194, 21);
            ApptEndDateTime.TabIndex = 22;
            ApptEndDateTime.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // ApptSaveButton
            // 
            this.ApptSaveButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApptSaveButton.Location = new System.Drawing.Point(280, 284);
            this.ApptSaveButton.Name = "ApptSaveButton";
            this.ApptSaveButton.Size = new System.Drawing.Size(118, 31);
            this.ApptSaveButton.TabIndex = 0;
            this.ApptSaveButton.Text = "Save";
            this.ApptSaveButton.UseVisualStyleBackColor = true;
            this.ApptSaveButton.Click += new System.EventHandler(this.ApptSave_Click);
            // 
            // ApptDeleteButton
            // 
            this.ApptDeleteButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApptDeleteButton.Location = new System.Drawing.Point(50, 284);
            this.ApptDeleteButton.Name = "ApptDeleteButton";
            this.ApptDeleteButton.Size = new System.Drawing.Size(118, 31);
            this.ApptDeleteButton.TabIndex = 1;
            this.ApptDeleteButton.Text = "Delete";
            this.ApptDeleteButton.UseVisualStyleBackColor = true;
            this.ApptDeleteButton.Click += new System.EventHandler(this.ApptDelete_Click);
            // 
            // ApptTypeLabel
            // 
            this.ApptTypeLabel.AutoSize = true;
            this.ApptTypeLabel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApptTypeLabel.Location = new System.Drawing.Point(50, 84);
            this.ApptTypeLabel.Name = "ApptTypeLabel";
            this.ApptTypeLabel.Size = new System.Drawing.Size(44, 18);
            this.ApptTypeLabel.TabIndex = 12;
            this.ApptTypeLabel.Text = "Type";
            // 
            // ApptEndDateLabel
            // 
            this.ApptEndDateLabel.AutoSize = true;
            this.ApptEndDateLabel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApptEndDateLabel.Location = new System.Drawing.Point(50, 234);
            this.ApptEndDateLabel.Name = "ApptEndDateLabel";
            this.ApptEndDateLabel.Size = new System.Drawing.Size(119, 18);
            this.ApptEndDateLabel.TabIndex = 2;
            this.ApptEndDateLabel.Text = "End Date/Time";
            // 
            // ApptCustomerIDLabel
            // 
            this.ApptCustomerIDLabel.AutoSize = true;
            this.ApptCustomerIDLabel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApptCustomerIDLabel.Location = new System.Drawing.Point(50, 134);
            this.ApptCustomerIDLabel.Name = "ApptCustomerIDLabel";
            this.ApptCustomerIDLabel.Size = new System.Drawing.Size(79, 18);
            this.ApptCustomerIDLabel.TabIndex = 14;
            this.ApptCustomerIDLabel.Text = "Customer";
            // 
            // ApptStartDateLabel
            // 
            this.ApptStartDateLabel.AutoSize = true;
            this.ApptStartDateLabel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApptStartDateLabel.Location = new System.Drawing.Point(50, 184);
            this.ApptStartDateLabel.Name = "ApptStartDateLabel";
            this.ApptStartDateLabel.Size = new System.Drawing.Size(130, 18);
            this.ApptStartDateLabel.TabIndex = 16;
            this.ApptStartDateLabel.Text = "Start Date/Time";
            // 
            // ApptCancelButton
            // 
            this.ApptCancelButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApptCancelButton.Location = new System.Drawing.Point(50, 284);
            this.ApptCancelButton.Name = "ApptCancelButton";
            this.ApptCancelButton.Size = new System.Drawing.Size(118, 31);
            this.ApptCancelButton.TabIndex = 24;
            this.ApptCancelButton.Text = "Cancel";
            this.ApptCancelButton.UseVisualStyleBackColor = true;
            this.ApptCancelButton.Click += new System.EventHandler(this.ApptCancelButton_Click);
            // 
            // ApptUserID
            // 
            this.ApptUserID.BackColor = System.Drawing.Color.White;
            this.ApptUserID.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApptUserID.ForeColor = System.Drawing.Color.Black;
            this.ApptUserID.Location = new System.Drawing.Point(205, 30);
            this.ApptUserID.Name = "ApptUserID";
            this.ApptUserID.Size = new System.Drawing.Size(194, 27);
            this.ApptUserID.TabIndex = 25;
            this.ApptUserID.TextChanged += new System.EventHandler(this.ApptUserID_TextChanged);
            // 
            // ApptUserIDLabel
            // 
            this.ApptUserIDLabel.AutoSize = true;
            this.ApptUserIDLabel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApptUserIDLabel.Location = new System.Drawing.Point(50, 34);
            this.ApptUserIDLabel.Name = "ApptUserIDLabel";
            this.ApptUserIDLabel.Size = new System.Drawing.Size(65, 18);
            this.ApptUserIDLabel.TabIndex = 26;
            this.ApptUserIDLabel.Text = "User ID";
            // 
            // ApptTypeListBox
            // 
            this.ApptTypeListBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApptTypeListBox.FormattingEnabled = true;
            this.ApptTypeListBox.ItemHeight = 19;
            this.ApptTypeListBox.Location = new System.Drawing.Point(205, 81);
            this.ApptTypeListBox.Name = "ApptTypeListBox";
            this.ApptTypeListBox.Size = new System.Drawing.Size(194, 23);
            this.ApptTypeListBox.TabIndex = 27;
            this.ApptTypeListBox.SelectedIndexChanged += new System.EventHandler(this.ApptTypeListBox_SelectedIndexChanged);
            // 
            // ApptCustomerListBox
            // 
            this.ApptCustomerListBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApptCustomerListBox.FormattingEnabled = true;
            this.ApptCustomerListBox.ItemHeight = 19;
            this.ApptCustomerListBox.Location = new System.Drawing.Point(205, 130);
            this.ApptCustomerListBox.Name = "ApptCustomerListBox";
            this.ApptCustomerListBox.Size = new System.Drawing.Size(194, 23);
            this.ApptCustomerListBox.TabIndex = 28;
            this.ApptCustomerListBox.SelectedIndexChanged += new System.EventHandler(this.ApptCustomerListBox_SelectedIndexChanged);
            // 
            // AppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 337);
            this.ControlBox = false;
            this.Controls.Add(this.ApptCustomerListBox);
            this.Controls.Add(this.ApptTypeListBox);
            this.Controls.Add(this.ApptUserIDLabel);
            this.Controls.Add(this.ApptUserID);
            this.Controls.Add(this.ApptCancelButton);
            this.Controls.Add(ApptEndDateTime);
            this.Controls.Add(ApptStartDateTime);
            this.Controls.Add(this.ApptStartDateLabel);
            this.Controls.Add(this.ApptCustomerIDLabel);
            this.Controls.Add(this.ApptTypeLabel);
            this.Controls.Add(this.ApptEndDateLabel);
            this.Controls.Add(this.ApptDeleteButton);
            this.Controls.Add(this.ApptSaveButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AppointmentForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Appointment Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ApptSaveButton;
        private System.Windows.Forms.Button ApptDeleteButton;
        private System.Windows.Forms.Label ApptTypeLabel;
        private System.Windows.Forms.Label ApptEndDateLabel;
        private System.Windows.Forms.Label ApptCustomerIDLabel;
        private System.Windows.Forms.Label ApptStartDateLabel;
        private System.Windows.Forms.Button ApptCancelButton;
        private System.Windows.Forms.TextBox ApptUserID;
        private System.Windows.Forms.Label ApptUserIDLabel;
        private System.Windows.Forms.ListBox ApptTypeListBox;
        private System.Windows.Forms.ListBox ApptCustomerListBox;
    }
}