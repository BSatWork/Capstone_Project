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
            this.ApptStartDateTime = new System.Windows.Forms.DateTimePicker();
            this.ApptEndDateTime = new System.Windows.Forms.DateTimePicker();
            this.ApptSaveButton = new System.Windows.Forms.Button();
            this.ApptDeleteButton = new System.Windows.Forms.Button();
            this.ApptTypeLabel = new System.Windows.Forms.Label();
            this.ApptEndDateLabel = new System.Windows.Forms.Label();
            this.ApptCustomerIDLabel = new System.Windows.Forms.Label();
            this.ApptStartDateLabel = new System.Windows.Forms.Label();
            this.ApptCancelButton = new System.Windows.Forms.Button();
            this.ApptUserIDLabel = new System.Windows.Forms.Label();
            this.ApptTypeComboBox = new System.Windows.Forms.ComboBox();
            this.CustomerComboBox = new System.Windows.Forms.ComboBox();
            this.ApptUserIDComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ApptStartDateTime
            // 
            this.ApptStartDateTime.CustomFormat = "MM/dd/yyyy hh:mm tt";
            this.ApptStartDateTime.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApptStartDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ApptStartDateTime.Location = new System.Drawing.Point(205, 182);
            this.ApptStartDateTime.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.ApptStartDateTime.Name = "ApptStartDateTime";
            this.ApptStartDateTime.Size = new System.Drawing.Size(194, 21);
            this.ApptStartDateTime.TabIndex = 20;
            this.ApptStartDateTime.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // ApptEndDateTime
            // 
            this.ApptEndDateTime.CustomFormat = "MM/dd/yyyy hh:mm tt";
            this.ApptEndDateTime.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApptEndDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ApptEndDateTime.Location = new System.Drawing.Point(205, 232);
            this.ApptEndDateTime.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.ApptEndDateTime.Name = "ApptEndDateTime";
            this.ApptEndDateTime.Size = new System.Drawing.Size(194, 21);
            this.ApptEndDateTime.TabIndex = 22;
            this.ApptEndDateTime.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
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
            // ApptTypeComboBox
            // 
            this.ApptTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ApptTypeComboBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApptTypeComboBox.FormattingEnabled = true;
            this.ApptTypeComboBox.Items.AddRange(new object[] {
            "Initial Consultation",
            "Follow-up",
            "Emergency",
            "Contract Closing"});
            this.ApptTypeComboBox.Location = new System.Drawing.Point(205, 81);
            this.ApptTypeComboBox.Name = "ApptTypeComboBox";
            this.ApptTypeComboBox.Size = new System.Drawing.Size(194, 27);
            this.ApptTypeComboBox.TabIndex = 36;
            // 
            // CustomerComboBox
            // 
            this.CustomerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CustomerComboBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerComboBox.FormattingEnabled = true;
            this.CustomerComboBox.Location = new System.Drawing.Point(205, 130);
            this.CustomerComboBox.Name = "CustomerComboBox";
            this.CustomerComboBox.Size = new System.Drawing.Size(194, 27);
            this.CustomerComboBox.TabIndex = 37;
            // 
            // ApptUserIDComboBox
            // 
            this.ApptUserIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ApptUserIDComboBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApptUserIDComboBox.FormattingEnabled = true;
            this.ApptUserIDComboBox.Location = new System.Drawing.Point(205, 30);
            this.ApptUserIDComboBox.Name = "ApptUserIDComboBox";
            this.ApptUserIDComboBox.Size = new System.Drawing.Size(194, 27);
            this.ApptUserIDComboBox.TabIndex = 38;
            // 
            // AppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 337);
            this.ControlBox = false;
            this.Controls.Add(this.ApptUserIDComboBox);
            this.Controls.Add(this.CustomerComboBox);
            this.Controls.Add(this.ApptTypeComboBox);
            this.Controls.Add(this.ApptUserIDLabel);
            this.Controls.Add(this.ApptCancelButton);
            this.Controls.Add(this.ApptEndDateTime);
            this.Controls.Add(this.ApptStartDateTime);
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
        private System.Windows.Forms.Label ApptUserIDLabel;
        private System.Windows.Forms.ComboBox ApptTypeComboBox;
        private System.Windows.Forms.ComboBox CustomerComboBox;
        private System.Windows.Forms.ComboBox ApptUserIDComboBox;
        private System.Windows.Forms.DateTimePicker ApptStartDateTime;
        private System.Windows.Forms.DateTimePicker ApptEndDateTime;
    }
}