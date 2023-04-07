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
            System.Windows.Forms.DateTimePicker ApptStartDate;
            System.Windows.Forms.DateTimePicker ApptEndDate;
            this.ApptSaveButton = new System.Windows.Forms.Button();
            this.ApptDeleteButton = new System.Windows.Forms.Button();
            this.ApptTypeLabel = new System.Windows.Forms.Label();
            this.ApptType = new System.Windows.Forms.TextBox();
            this.ApptEndDateLabel = new System.Windows.Forms.Label();
            this.ApptCustomerLabel = new System.Windows.Forms.Label();
            this.ApptCustomer = new System.Windows.Forms.TextBox();
            this.ApptStartDateLabel = new System.Windows.Forms.Label();
            this.ApptCancelButton = new System.Windows.Forms.Button();
            ApptStartDate = new System.Windows.Forms.DateTimePicker();
            ApptEndDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // ApptStartDate
            // 
            ApptStartDate.AllowDrop = true;
            ApptStartDate.CustomFormat = "MM/DD/YYY HH:MM";
            ApptStartDate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ApptStartDate.Location = new System.Drawing.Point(205, 138);
            ApptStartDate.MinDate = new System.DateTime(2023, 1, 1, 0, 0, 0, 0);
            ApptStartDate.Name = "ApptStartDate";
            ApptStartDate.Size = new System.Drawing.Size(194, 21);
            ApptStartDate.TabIndex = 20;
            ApptStartDate.ValueChanged += new System.EventHandler(this.ApptStartDate_ValueChanged);
            // 
            // ApptEndDate
            // 
            ApptEndDate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ApptEndDate.Location = new System.Drawing.Point(205, 188);
            ApptEndDate.MinDate = new System.DateTime(2023, 1, 1, 0, 0, 0, 0);
            ApptEndDate.Name = "ApptEndDate";
            ApptEndDate.Size = new System.Drawing.Size(194, 21);
            ApptEndDate.TabIndex = 22;
            ApptEndDate.Value = new System.DateTime(2023, 3, 10, 0, 0, 0, 0);
            ApptEndDate.ValueChanged += new System.EventHandler(this.ApptEndDate_ValueChanged);
            // 
            // ApptSaveButton
            // 
            this.ApptSaveButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApptSaveButton.Location = new System.Drawing.Point(280, 240);
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
            this.ApptDeleteButton.Location = new System.Drawing.Point(50, 240);
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
            this.ApptTypeLabel.Location = new System.Drawing.Point(50, 40);
            this.ApptTypeLabel.Name = "ApptTypeLabel";
            this.ApptTypeLabel.Size = new System.Drawing.Size(44, 18);
            this.ApptTypeLabel.TabIndex = 12;
            this.ApptTypeLabel.Text = "Type";
            // 
            // ApptType
            // 
            this.ApptType.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApptType.Location = new System.Drawing.Point(205, 36);
            this.ApptType.Name = "ApptType";
            this.ApptType.Size = new System.Drawing.Size(194, 27);
            this.ApptType.TabIndex = 13;
            this.ApptType.TextChanged += new System.EventHandler(this.ApptType_TextChanged);
            // 
            // ApptEndDateLabel
            // 
            this.ApptEndDateLabel.AutoSize = true;
            this.ApptEndDateLabel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApptEndDateLabel.Location = new System.Drawing.Point(50, 190);
            this.ApptEndDateLabel.Name = "ApptEndDateLabel";
            this.ApptEndDateLabel.Size = new System.Drawing.Size(74, 18);
            this.ApptEndDateLabel.TabIndex = 2;
            this.ApptEndDateLabel.Text = "End Date";
            // 
            // ApptCustomerLabel
            // 
            this.ApptCustomerLabel.AutoSize = true;
            this.ApptCustomerLabel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApptCustomerLabel.Location = new System.Drawing.Point(50, 90);
            this.ApptCustomerLabel.Name = "ApptCustomerLabel";
            this.ApptCustomerLabel.Size = new System.Drawing.Size(79, 18);
            this.ApptCustomerLabel.TabIndex = 14;
            this.ApptCustomerLabel.Text = "Customer";
            // 
            // ApptCustomer
            // 
            this.ApptCustomer.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApptCustomer.Location = new System.Drawing.Point(205, 86);
            this.ApptCustomer.Name = "ApptCustomer";
            this.ApptCustomer.Size = new System.Drawing.Size(194, 27);
            this.ApptCustomer.TabIndex = 15;
            this.ApptCustomer.TextChanged += new System.EventHandler(this.ApptCustomer_TextChanged);
            // 
            // ApptStartDateLabel
            // 
            this.ApptStartDateLabel.AutoSize = true;
            this.ApptStartDateLabel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApptStartDateLabel.Location = new System.Drawing.Point(50, 140);
            this.ApptStartDateLabel.Name = "ApptStartDateLabel";
            this.ApptStartDateLabel.Size = new System.Drawing.Size(85, 18);
            this.ApptStartDateLabel.TabIndex = 16;
            this.ApptStartDateLabel.Text = "Start Date";
            // 
            // ApptCancelButton
            // 
            this.ApptCancelButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApptCancelButton.Location = new System.Drawing.Point(50, 240);
            this.ApptCancelButton.Name = "ApptCancelButton";
            this.ApptCancelButton.Size = new System.Drawing.Size(118, 31);
            this.ApptCancelButton.TabIndex = 24;
            this.ApptCancelButton.Text = "Cancel";
            this.ApptCancelButton.UseVisualStyleBackColor = true;
            this.ApptCancelButton.Click += new System.EventHandler(this.ApptCancelButton_Click);
            // 
            // AppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 304);
            this.ControlBox = false;
            this.Controls.Add(this.ApptCancelButton);
            this.Controls.Add(ApptEndDate);
            this.Controls.Add(ApptStartDate);
            this.Controls.Add(this.ApptStartDateLabel);
            this.Controls.Add(this.ApptCustomer);
            this.Controls.Add(this.ApptCustomerLabel);
            this.Controls.Add(this.ApptType);
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
        private System.Windows.Forms.TextBox ApptType;
        private System.Windows.Forms.Label ApptEndDateLabel;
        private System.Windows.Forms.Label ApptCustomerLabel;
        private System.Windows.Forms.TextBox ApptCustomer;
        private System.Windows.Forms.Label ApptStartDateLabel;
        private System.Windows.Forms.Button ApptCancelButton;
    }
}