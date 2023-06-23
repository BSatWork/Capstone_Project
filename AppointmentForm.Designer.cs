namespace RYM2_Capstone_Scheduling_App
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
            this.ApptUserNameLabel = new System.Windows.Forms.Label();
            this.ApptTypeComboBox = new System.Windows.Forms.ComboBox();
            this.ApptCustomerComboBox = new System.Windows.Forms.ComboBox();
            this.ApptEmployeeComboBox = new System.Windows.Forms.ComboBox();
            this.ApptScreenCloseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ApptStartDateTime
            // 
            this.ApptStartDateTime.CustomFormat = "MM/dd/yyyy hh:mm tt";
            this.ApptStartDateTime.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApptStartDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ApptStartDateTime.Location = new System.Drawing.Point(210, 182);
            this.ApptStartDateTime.MinDate = new System.DateTime(2023, 1, 1, 12, 0, 0, 0);
            this.ApptStartDateTime.Name = "ApptStartDateTime";
            this.ApptStartDateTime.Size = new System.Drawing.Size(194, 21);
            this.ApptStartDateTime.TabIndex = 20;
            this.ApptStartDateTime.Value = new System.DateTime(2023, 1, 1, 12, 0, 0, 0);
            this.ApptStartDateTime.ValueChanged += new System.EventHandler(this.ApptStartDateTime_ValueChanged);
            // 
            // ApptEndDateTime
            // 
            this.ApptEndDateTime.CustomFormat = "MM/dd/yyyy hh:mm tt";
            this.ApptEndDateTime.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApptEndDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ApptEndDateTime.Location = new System.Drawing.Point(210, 232);
            this.ApptEndDateTime.MinDate = new System.DateTime(2023, 1, 1, 12, 0, 0, 0);
            this.ApptEndDateTime.Name = "ApptEndDateTime";
            this.ApptEndDateTime.Size = new System.Drawing.Size(194, 21);
            this.ApptEndDateTime.TabIndex = 22;
            this.ApptEndDateTime.Value = new System.DateTime(2023, 1, 1, 12, 0, 0, 0);
            // 
            // ApptSaveButton
            // 
            this.ApptSaveButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApptSaveButton.Location = new System.Drawing.Point(285, 284);
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
            this.ApptDeleteButton.Location = new System.Drawing.Point(45, 284);
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
            this.ApptTypeLabel.Location = new System.Drawing.Point(45, 84);
            this.ApptTypeLabel.Name = "ApptTypeLabel";
            this.ApptTypeLabel.Size = new System.Drawing.Size(44, 18);
            this.ApptTypeLabel.TabIndex = 12;
            this.ApptTypeLabel.Text = "Type";
            // 
            // ApptEndDateLabel
            // 
            this.ApptEndDateLabel.AutoSize = true;
            this.ApptEndDateLabel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApptEndDateLabel.Location = new System.Drawing.Point(45, 234);
            this.ApptEndDateLabel.Name = "ApptEndDateLabel";
            this.ApptEndDateLabel.Size = new System.Drawing.Size(119, 18);
            this.ApptEndDateLabel.TabIndex = 2;
            this.ApptEndDateLabel.Text = "End Date/Time";
            // 
            // ApptCustomerIDLabel
            // 
            this.ApptCustomerIDLabel.AutoSize = true;
            this.ApptCustomerIDLabel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApptCustomerIDLabel.Location = new System.Drawing.Point(45, 134);
            this.ApptCustomerIDLabel.Name = "ApptCustomerIDLabel";
            this.ApptCustomerIDLabel.Size = new System.Drawing.Size(79, 18);
            this.ApptCustomerIDLabel.TabIndex = 14;
            this.ApptCustomerIDLabel.Text = "Customer";
            // 
            // ApptStartDateLabel
            // 
            this.ApptStartDateLabel.AutoSize = true;
            this.ApptStartDateLabel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApptStartDateLabel.Location = new System.Drawing.Point(45, 184);
            this.ApptStartDateLabel.Name = "ApptStartDateLabel";
            this.ApptStartDateLabel.Size = new System.Drawing.Size(130, 18);
            this.ApptStartDateLabel.TabIndex = 16;
            this.ApptStartDateLabel.Text = "Start Date/Time";
            // 
            // ApptCancelButton
            // 
            this.ApptCancelButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApptCancelButton.Location = new System.Drawing.Point(45, 284);
            this.ApptCancelButton.Name = "ApptCancelButton";
            this.ApptCancelButton.Size = new System.Drawing.Size(118, 31);
            this.ApptCancelButton.TabIndex = 24;
            this.ApptCancelButton.Text = "Cancel";
            this.ApptCancelButton.UseVisualStyleBackColor = true;
            this.ApptCancelButton.Click += new System.EventHandler(this.ApptCancelButton_Click);
            // 
            // ApptUserNameLabel
            // 
            this.ApptUserNameLabel.AutoSize = true;
            this.ApptUserNameLabel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApptUserNameLabel.Location = new System.Drawing.Point(45, 34);
            this.ApptUserNameLabel.Name = "ApptUserNameLabel";
            this.ApptUserNameLabel.Size = new System.Drawing.Size(80, 18);
            this.ApptUserNameLabel.TabIndex = 26;
            this.ApptUserNameLabel.Text = "Employee";
            // 
            // ApptTypeComboBox
            // 
            this.ApptTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ApptTypeComboBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApptTypeComboBox.FormattingEnabled = true;
            this.ApptTypeComboBox.Items.AddRange(new object[] {
            "Initial Consultation",
            "Presentation",
            "Scrum",
            "Follow-up",
            "Emergency",
            "Project Closing"});
            this.ApptTypeComboBox.Location = new System.Drawing.Point(210, 81);
            this.ApptTypeComboBox.Name = "ApptTypeComboBox";
            this.ApptTypeComboBox.Size = new System.Drawing.Size(194, 27);
            this.ApptTypeComboBox.TabIndex = 36;
            // 
            // ApptCustomerComboBox
            // 
            this.ApptCustomerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ApptCustomerComboBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApptCustomerComboBox.FormattingEnabled = true;
            this.ApptCustomerComboBox.Location = new System.Drawing.Point(210, 130);
            this.ApptCustomerComboBox.Name = "ApptCustomerComboBox";
            this.ApptCustomerComboBox.Size = new System.Drawing.Size(194, 27);
            this.ApptCustomerComboBox.TabIndex = 37;
            // 
            // ApptEmployeeComboBox
            // 
            this.ApptEmployeeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ApptEmployeeComboBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApptEmployeeComboBox.FormattingEnabled = true;
            this.ApptEmployeeComboBox.Location = new System.Drawing.Point(210, 30);
            this.ApptEmployeeComboBox.Name = "ApptEmployeeComboBox";
            this.ApptEmployeeComboBox.Size = new System.Drawing.Size(194, 27);
            this.ApptEmployeeComboBox.TabIndex = 38;
            // 
            // ApptScreenCloseButton
            // 
            this.ApptScreenCloseButton.BackColor = System.Drawing.SystemColors.Control;
            this.ApptScreenCloseButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.ApptScreenCloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ApptScreenCloseButton.Font = new System.Drawing.Font("Tahoma", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApptScreenCloseButton.Location = new System.Drawing.Point(406, -3);
            this.ApptScreenCloseButton.Margin = new System.Windows.Forms.Padding(0);
            this.ApptScreenCloseButton.Name = "ApptScreenCloseButton";
            this.ApptScreenCloseButton.Size = new System.Drawing.Size(52, 23);
            this.ApptScreenCloseButton.TabIndex = 40;
            this.ApptScreenCloseButton.Text = "Close";
            this.ApptScreenCloseButton.UseVisualStyleBackColor = false;
            this.ApptScreenCloseButton.Click += new System.EventHandler(this.ApptScreenCloseButton_Click);
            // 
            // AppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 337);
            this.ControlBox = false;
            this.Controls.Add(this.ApptScreenCloseButton);
            this.Controls.Add(this.ApptEmployeeComboBox);
            this.Controls.Add(this.ApptCustomerComboBox);
            this.Controls.Add(this.ApptTypeComboBox);
            this.Controls.Add(this.ApptUserNameLabel);
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
        private System.Windows.Forms.Label ApptUserNameLabel;
        private System.Windows.Forms.ComboBox ApptTypeComboBox;
        private System.Windows.Forms.ComboBox ApptCustomerComboBox;
        private System.Windows.Forms.ComboBox ApptEmployeeComboBox;
        private System.Windows.Forms.DateTimePicker ApptStartDateTime;
        private System.Windows.Forms.DateTimePicker ApptEndDateTime;
        private System.Windows.Forms.Button ApptScreenCloseButton;
    }
}