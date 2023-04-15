namespace BOP3_Task_1_DB_and_File_Server_App
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
            this.AppoinmentsDGV = new System.Windows.Forms.DataGridView();
            this.Appointment_ID_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer_ID_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer_Name_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Location_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contact_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.URL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Start_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.End_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateDate_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Created_By_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Last_Update_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Last_Update_By_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddUpdateDeleteApptButton = new System.Windows.Forms.Button();
            this.ApptCountLabel = new System.Windows.Forms.Label();
            this.ApptCount = new System.Windows.Forms.Label();
            this.AddUpdateDeleteApptToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.CustomerDBButton = new System.Windows.Forms.Button();
            this.CustomerDBToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.CalendarView = new System.Windows.Forms.ComboBox();
            this.MainScreenCloseButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ReportsButton = new System.Windows.Forms.Button();
            this.ReportsToolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.AppoinmentsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // AppoinmentsDGV
            // 
            this.AppoinmentsDGV.AllowUserToAddRows = false;
            this.AppoinmentsDGV.AllowUserToDeleteRows = false;
            this.AppoinmentsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AppoinmentsDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Appointment_ID_Column,
            this.Customer_ID_Column,
            this.Customer_Name_Column,
            this.Title_Column,
            this.Description_Column,
            this.Location_Column,
            this.Contact_Column,
            this.Type_Column,
            this.URL,
            this.Start_Column,
            this.End_Column,
            this.CreateDate_Column,
            this.Created_By_Column,
            this.Last_Update_Column,
            this.Last_Update_By_Column});
            this.AppoinmentsDGV.Location = new System.Drawing.Point(30, 55);
            this.AppoinmentsDGV.Margin = new System.Windows.Forms.Padding(4);
            this.AppoinmentsDGV.MultiSelect = false;
            this.AppoinmentsDGV.Name = "AppoinmentsDGV";
            this.AppoinmentsDGV.ReadOnly = true;
            this.AppoinmentsDGV.RowHeadersVisible = false;
            this.AppoinmentsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AppoinmentsDGV.Size = new System.Drawing.Size(975, 360);
            this.AppoinmentsDGV.TabIndex = 0;
            // 
            // Appointment_ID_Column
            // 
            this.Appointment_ID_Column.DataPropertyName = "Appointment_ID_Column";
            this.Appointment_ID_Column.HeaderText = "Appt ID";
            this.Appointment_ID_Column.Name = "Appointment_ID_Column";
            this.Appointment_ID_Column.ReadOnly = true;
            this.Appointment_ID_Column.Visible = false;
            this.Appointment_ID_Column.Width = 85;
            // 
            // Customer_ID_Column
            // 
            this.Customer_ID_Column.DataPropertyName = "Customer_ID_Column";
            this.Customer_ID_Column.HeaderText = "Customer ID";
            this.Customer_ID_Column.Name = "Customer_ID_Column";
            this.Customer_ID_Column.ReadOnly = true;
            // 
            // Customer_Name_Column
            // 
            this.Customer_Name_Column.DataPropertyName = "Customer_Name_Column";
            this.Customer_Name_Column.HeaderText = "Customer Name";
            this.Customer_Name_Column.Name = "Customer_Name_Column";
            this.Customer_Name_Column.ReadOnly = true;
            this.Customer_Name_Column.Width = 250;
            // 
            // Title_Column
            // 
            this.Title_Column.DataPropertyName = "Title_Column";
            this.Title_Column.HeaderText = "Title";
            this.Title_Column.Name = "Title_Column";
            this.Title_Column.ReadOnly = true;
            this.Title_Column.Visible = false;
            // 
            // Description_Column
            // 
            this.Description_Column.DataPropertyName = "Description_Column";
            this.Description_Column.HeaderText = "Description";
            this.Description_Column.Name = "Description_Column";
            this.Description_Column.ReadOnly = true;
            this.Description_Column.Visible = false;
            // 
            // Location_Column
            // 
            this.Location_Column.DataPropertyName = "Location_Column";
            this.Location_Column.HeaderText = "Location";
            this.Location_Column.Name = "Location_Column";
            this.Location_Column.ReadOnly = true;
            this.Location_Column.Visible = false;
            // 
            // Contact_Column
            // 
            this.Contact_Column.DataPropertyName = "Contact_Column";
            this.Contact_Column.HeaderText = "Contact";
            this.Contact_Column.Name = "Contact_Column";
            this.Contact_Column.ReadOnly = true;
            this.Contact_Column.Visible = false;
            // 
            // Type_Column
            // 
            this.Type_Column.DataPropertyName = "Type_Column";
            this.Type_Column.HeaderText = "Type";
            this.Type_Column.Name = "Type_Column";
            this.Type_Column.ReadOnly = true;
            this.Type_Column.Width = 200;
            // 
            // URL
            // 
            this.URL.DataPropertyName = "URL";
            this.URL.HeaderText = "URL_Column";
            this.URL.Name = "URL";
            this.URL.ReadOnly = true;
            this.URL.Visible = false;
            // 
            // Start_Column
            // 
            this.Start_Column.DataPropertyName = "Start_Column";
            this.Start_Column.HeaderText = "Start";
            this.Start_Column.Name = "Start_Column";
            this.Start_Column.ReadOnly = true;
            this.Start_Column.Width = 200;
            // 
            // End_Column
            // 
            this.End_Column.DataPropertyName = "End_Column";
            this.End_Column.HeaderText = "End";
            this.End_Column.Name = "End_Column";
            this.End_Column.ReadOnly = true;
            this.End_Column.Width = 200;
            // 
            // CreateDate_Column
            // 
            this.CreateDate_Column.DataPropertyName = "CreateDate_Column";
            this.CreateDate_Column.HeaderText = "Create Date";
            this.CreateDate_Column.Name = "CreateDate_Column";
            this.CreateDate_Column.ReadOnly = true;
            this.CreateDate_Column.Visible = false;
            // 
            // Created_By_Column
            // 
            this.Created_By_Column.DataPropertyName = "Created_By_Column";
            this.Created_By_Column.HeaderText = "Created By";
            this.Created_By_Column.Name = "Created_By_Column";
            this.Created_By_Column.ReadOnly = true;
            this.Created_By_Column.Visible = false;
            // 
            // Last_Update_Column
            // 
            this.Last_Update_Column.DataPropertyName = "Last_Update_Column";
            this.Last_Update_Column.HeaderText = "Last Update";
            this.Last_Update_Column.Name = "Last_Update_Column";
            this.Last_Update_Column.ReadOnly = true;
            this.Last_Update_Column.Visible = false;
            // 
            // Last_Update_By_Column
            // 
            this.Last_Update_By_Column.DataPropertyName = "Last_Update_By_Column";
            this.Last_Update_By_Column.HeaderText = "Last Update By";
            this.Last_Update_By_Column.Name = "Last_Update_By_Column";
            this.Last_Update_By_Column.ReadOnly = true;
            this.Last_Update_By_Column.Visible = false;
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
            // CalendarView
            // 
            this.CalendarView.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CalendarView.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalendarView.Items.AddRange(new object[] {
            "All",
            "30 Days",
            "7 Days"});
            this.CalendarView.Location = new System.Drawing.Point(884, 21);
            this.CalendarView.Name = "CalendarView";
            this.CalendarView.Size = new System.Drawing.Size(121, 24);
            this.CalendarView.TabIndex = 5;
            this.CalendarView.SelectedIndexChanged += new System.EventHandler(this.CalendarView_SelectedIndexChanged);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(785, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 14);
            this.label1.TabIndex = 10;
            this.label1.Text = "Calendar View";
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
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 461);
            this.ControlBox = false;
            this.Controls.Add(this.ReportsButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MainScreenCloseButton);
            this.Controls.Add(this.CalendarView);
            this.Controls.Add(this.CustomerDBButton);
            this.Controls.Add(this.ApptCount);
            this.Controls.Add(this.ApptCountLabel);
            this.Controls.Add(this.AddUpdateDeleteApptButton);
            this.Controls.Add(this.AppoinmentsDGV);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainScreen";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Appointment Scheduler";
            ((System.ComponentModel.ISupportInitialize)(this.AppoinmentsDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView AppoinmentsDGV;
        private System.Windows.Forms.Button AddUpdateDeleteApptButton;
        private System.Windows.Forms.Label ApptCountLabel;
        private System.Windows.Forms.Label ApptCount;
        private System.Windows.Forms.ToolTip AddUpdateDeleteApptToolTip;
        private System.Windows.Forms.Button CustomerDBButton;
        private System.Windows.Forms.ToolTip CustomerDBToolTip;
        private System.Windows.Forms.ComboBox CalendarView;
        private System.Windows.Forms.Button MainScreenCloseButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Appointment_ID_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer_ID_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer_Name_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Location_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contact_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn URL;
        private System.Windows.Forms.DataGridViewTextBoxColumn Start_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn End_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateDate_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Created_By_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Last_Update_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Last_Update_By_Column;
        private System.Windows.Forms.Button ReportsButton;
        private System.Windows.Forms.ToolTip ReportsToolTip;
    }
}