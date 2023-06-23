namespace RYM2_Capstone_Scheduling_App
{
    partial class MainScreen
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
            this.components = new System.ComponentModel.Container();
            this.AppointmentsDGV = new System.Windows.Forms.DataGridView();
            this.AddUpdateDeleteApptButton = new System.Windows.Forms.Button();
            this.ApptCountLabel = new System.Windows.Forms.Label();
            this.ApptCount = new System.Windows.Forms.Label();
            this.AddUpdateDeleteApptToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.CustomerDBButton = new System.Windows.Forms.Button();
            this.CustomerDBToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.MainScreenCloseButton = new System.Windows.Forms.Button();
            this.ReportsButton = new System.Windows.Forms.Button();
            this.ReportsToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.ApptSearchLabel = new System.Windows.Forms.Label();
            this.Appointment_ID_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User_ID_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Employee_Name_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer_Name_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Start_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.End_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // AppointmentsDGV
            // 
            this.AppointmentsDGV.AllowUserToAddRows = false;
            this.AppointmentsDGV.AllowUserToDeleteRows = false;
            this.AppointmentsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AppointmentsDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Appointment_ID_Column,
            this.User_ID_Column,
            this.Employee_Name_Column,
            this.Customer_Name_Column,
            this.Type_Column,
            this.Start_Column,
            this.End_Column});
            this.AppointmentsDGV.Location = new System.Drawing.Point(36, 52);
            this.AppointmentsDGV.Margin = new System.Windows.Forms.Padding(4);
            this.AppointmentsDGV.MultiSelect = false;
            this.AppointmentsDGV.Name = "AppointmentsDGV";
            this.AppointmentsDGV.ReadOnly = true;
            this.AppointmentsDGV.RowHeadersVisible = false;
            this.AppointmentsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AppointmentsDGV.Size = new System.Drawing.Size(975, 360);
            this.AppointmentsDGV.TabIndex = 0;
            // 
            // AddUpdateDeleteApptButton
            // 
            this.AddUpdateDeleteApptButton.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddUpdateDeleteApptButton.Location = new System.Drawing.Point(30, 13);
            this.AddUpdateDeleteApptButton.Margin = new System.Windows.Forms.Padding(4);
            this.AddUpdateDeleteApptButton.Name = "AddUpdateDeleteApptButton";
            this.AddUpdateDeleteApptButton.Size = new System.Drawing.Size(243, 36);
            this.AddUpdateDeleteApptButton.TabIndex = 1;
            this.AddUpdateDeleteApptButton.Text = "Add/Update/Delete Appt";
            this.AddUpdateDeleteApptButton.UseVisualStyleBackColor = true;
            this.AddUpdateDeleteApptButton.Click += new System.EventHandler(this.AddUpdateDeleteApptButton_Click);
            // 
            // ApptCountLabel
            // 
            this.ApptCountLabel.AutoSize = true;
            this.ApptCountLabel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApptCountLabel.Location = new System.Drawing.Point(33, 419);
            this.ApptCountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ApptCountLabel.Name = "ApptCountLabel";
            this.ApptCountLabel.Size = new System.Drawing.Size(154, 18);
            this.ApptCountLabel.TabIndex = 2;
            this.ApptCountLabel.Text = "Appointment Count:";
            // 
            // ApptCount
            // 
            this.ApptCount.AutoSize = true;
            this.ApptCount.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApptCount.Location = new System.Drawing.Point(188, 419);
            this.ApptCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ApptCount.Name = "ApptCount";
            this.ApptCount.Size = new System.Drawing.Size(18, 18);
            this.ApptCount.TabIndex = 3;
            this.ApptCount.Text = "0";
            // 
            // AddUpdateDeleteApptToolTip
            // 
            this.AddUpdateDeleteApptToolTip.AutoPopDelay = 5000;
            this.AddUpdateDeleteApptToolTip.InitialDelay = 500;
            this.AddUpdateDeleteApptToolTip.IsBalloon = true;
            this.AddUpdateDeleteApptToolTip.ReshowDelay = 100;
            // 
            // CustomerDBButton
            // 
            this.CustomerDBButton.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerDBButton.Location = new System.Drawing.Point(831, 420);
            this.CustomerDBButton.Margin = new System.Windows.Forms.Padding(4);
            this.CustomerDBButton.Name = "CustomerDBButton";
            this.CustomerDBButton.Size = new System.Drawing.Size(175, 29);
            this.CustomerDBButton.TabIndex = 4;
            this.CustomerDBButton.Text = "Customer Database";
            this.CustomerDBButton.UseVisualStyleBackColor = true;
            this.CustomerDBButton.Click += new System.EventHandler(this.CustomerDBButton_Click);
            // 
            // CustomerDBToolTip
            // 
            this.CustomerDBToolTip.AutoPopDelay = 5000;
            this.CustomerDBToolTip.InitialDelay = 500;
            this.CustomerDBToolTip.IsBalloon = true;
            this.CustomerDBToolTip.ReshowDelay = 100;
            // 
            // MainScreenCloseButton
            // 
            this.MainScreenCloseButton.BackColor = System.Drawing.SystemColors.Control;
            this.MainScreenCloseButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.MainScreenCloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainScreenCloseButton.Font = new System.Drawing.Font("Tahoma", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainScreenCloseButton.Location = new System.Drawing.Point(988, -4);
            this.MainScreenCloseButton.Margin = new System.Windows.Forms.Padding(0);
            this.MainScreenCloseButton.Name = "MainScreenCloseButton";
            this.MainScreenCloseButton.Size = new System.Drawing.Size(52, 23);
            this.MainScreenCloseButton.TabIndex = 9;
            this.MainScreenCloseButton.Text = "Close";
            this.MainScreenCloseButton.UseVisualStyleBackColor = false;
            this.MainScreenCloseButton.Click += new System.EventHandler(this.MainScreenCloseButton_Click);
            // 
            // ReportsButton
            // 
            this.ReportsButton.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportsButton.Location = new System.Drawing.Point(723, 420);
            this.ReportsButton.Margin = new System.Windows.Forms.Padding(4);
            this.ReportsButton.Name = "ReportsButton";
            this.ReportsButton.Size = new System.Drawing.Size(100, 29);
            this.ReportsButton.TabIndex = 11;
            this.ReportsButton.Text = "Reports";
            this.ReportsButton.UseVisualStyleBackColor = true;
            this.ReportsButton.Click += new System.EventHandler(this.ReportsButton_Click);
            // 
            // ReportsToolTip
            // 
            this.ReportsToolTip.IsBalloon = true;
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTextBox.Location = new System.Drawing.Point(746, 21);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(265, 23);
            this.SearchTextBox.TabIndex = 12;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // ApptSearchLabel
            // 
            this.ApptSearchLabel.AutoSize = true;
            this.ApptSearchLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApptSearchLabel.Location = new System.Drawing.Point(657, 25);
            this.ApptSearchLabel.Name = "ApptSearchLabel";
            this.ApptSearchLabel.Size = new System.Drawing.Size(83, 14);
            this.ApptSearchLabel.TabIndex = 13;
            this.ApptSearchLabel.Text = "Appt Search";
            // 
            // Appointment_ID_Column
            // 
            this.Appointment_ID_Column.DataPropertyName = "appointmentId";
            this.Appointment_ID_Column.HeaderText = "Appointment ID";
            this.Appointment_ID_Column.Name = "Appointment_ID_Column";
            this.Appointment_ID_Column.ReadOnly = true;
            this.Appointment_ID_Column.Visible = false;
            // 
            // User_ID_Column
            // 
            this.User_ID_Column.DataPropertyName = "userId";
            this.User_ID_Column.HeaderText = "User ID";
            this.User_ID_Column.Name = "User_ID_Column";
            this.User_ID_Column.ReadOnly = true;
            this.User_ID_Column.Visible = false;
            // 
            // Employee_Name_Column
            // 
            this.Employee_Name_Column.DataPropertyName = "employeeName";
            this.Employee_Name_Column.HeaderText = "Employee Name";
            this.Employee_Name_Column.Name = "Employee_Name_Column";
            this.Employee_Name_Column.ReadOnly = true;
            this.Employee_Name_Column.Width = 250;
            // 
            // Customer_Name_Column
            // 
            this.Customer_Name_Column.DataPropertyName = "customerName";
            this.Customer_Name_Column.HeaderText = "Customer Name";
            this.Customer_Name_Column.Name = "Customer_Name_Column";
            this.Customer_Name_Column.ReadOnly = true;
            this.Customer_Name_Column.Width = 250;
            // 
            // Type_Column
            // 
            this.Type_Column.DataPropertyName = "type";
            this.Type_Column.HeaderText = "Type";
            this.Type_Column.Name = "Type_Column";
            this.Type_Column.ReadOnly = true;
            this.Type_Column.Width = 150;
            // 
            // Start_Column
            // 
            this.Start_Column.DataPropertyName = "start";
            this.Start_Column.HeaderText = "Start";
            this.Start_Column.Name = "Start_Column";
            this.Start_Column.ReadOnly = true;
            this.Start_Column.Width = 150;
            // 
            // End_Column
            // 
            this.End_Column.DataPropertyName = "end";
            this.End_Column.HeaderText = "End";
            this.End_Column.Name = "End_Column";
            this.End_Column.ReadOnly = true;
            this.End_Column.Width = 150;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 461);
            this.ControlBox = false;
            this.Controls.Add(this.ApptSearchLabel);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.ReportsButton);
            this.Controls.Add(this.MainScreenCloseButton);
            this.Controls.Add(this.CustomerDBButton);
            this.Controls.Add(this.ApptCount);
            this.Controls.Add(this.ApptCountLabel);
            this.Controls.Add(this.AddUpdateDeleteApptButton);
            this.Controls.Add(this.AppointmentsDGV);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainScreen";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Appointment Scheduler";
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentsDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView AppointmentsDGV;
        private System.Windows.Forms.Button AddUpdateDeleteApptButton;
        private System.Windows.Forms.Label ApptCountLabel;
        private System.Windows.Forms.Label ApptCount;
        private System.Windows.Forms.ToolTip AddUpdateDeleteApptToolTip;
        private System.Windows.Forms.Button CustomerDBButton;
        private System.Windows.Forms.ToolTip CustomerDBToolTip;
        private System.Windows.Forms.Button MainScreenCloseButton;
        private System.Windows.Forms.Button ReportsButton;
        private System.Windows.Forms.ToolTip ReportsToolTip;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Label ApptSearchLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Appointment_ID_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn User_ID_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Employee_Name_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer_Name_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Start_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn End_Column;
    }
}