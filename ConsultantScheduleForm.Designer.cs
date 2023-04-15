namespace BOP3_Task_1_DB_and_File_Server_App
{
    partial class ConsultantScheduleForm
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
            this.ConsultantScheduleCloseButton = new System.Windows.Forms.Button();
            this.CustomerDBToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.AddUpdateDeleteApptToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.Last_Update_By_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Last_Update_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Created_By_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateDate_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.End_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Start_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.URL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contact_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Location_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer_Name_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer_ID_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Appointment_ID_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConsultantScheduleDGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultantScheduleDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // ConsultantScheduleCloseButton
            // 
            this.ConsultantScheduleCloseButton.BackColor = System.Drawing.SystemColors.Control;
            this.ConsultantScheduleCloseButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.ConsultantScheduleCloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConsultantScheduleCloseButton.Font = new System.Drawing.Font("Tahoma", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsultantScheduleCloseButton.Location = new System.Drawing.Point(989, -5);
            this.ConsultantScheduleCloseButton.Margin = new System.Windows.Forms.Padding(0);
            this.ConsultantScheduleCloseButton.Name = "ConsultantScheduleCloseButton";
            this.ConsultantScheduleCloseButton.Size = new System.Drawing.Size(52, 23);
            this.ConsultantScheduleCloseButton.TabIndex = 18;
            this.ConsultantScheduleCloseButton.Text = "Close";
            this.ConsultantScheduleCloseButton.UseVisualStyleBackColor = false;
            this.ConsultantScheduleCloseButton.Click += new System.EventHandler(this.ConsultantScheduleCloseButton_Click);
            // 
            // CustomerDBToolTip
            // 
            this.CustomerDBToolTip.AutoPopDelay = 10000;
            this.CustomerDBToolTip.InitialDelay = 100;
            this.CustomerDBToolTip.IsBalloon = true;
            this.CustomerDBToolTip.ReshowDelay = 100;
            // 
            // AddUpdateDeleteApptToolTip
            // 
            this.AddUpdateDeleteApptToolTip.AutoPopDelay = 10000;
            this.AddUpdateDeleteApptToolTip.InitialDelay = 100;
            this.AddUpdateDeleteApptToolTip.IsBalloon = true;
            this.AddUpdateDeleteApptToolTip.ReshowDelay = 100;
            // 
            // Last_Update_By_Column
            // 
            this.Last_Update_By_Column.DataPropertyName = "Last_Update_By_Column";
            this.Last_Update_By_Column.HeaderText = "Last Update By";
            this.Last_Update_By_Column.Name = "Last_Update_By_Column";
            this.Last_Update_By_Column.ReadOnly = true;
            this.Last_Update_By_Column.Visible = false;
            // 
            // Last_Update_Column
            // 
            this.Last_Update_Column.DataPropertyName = "Last_Update_Column";
            this.Last_Update_Column.HeaderText = "Last Update";
            this.Last_Update_Column.Name = "Last_Update_Column";
            this.Last_Update_Column.ReadOnly = true;
            this.Last_Update_Column.Visible = false;
            // 
            // Created_By_Column
            // 
            this.Created_By_Column.DataPropertyName = "Created_By_Column";
            this.Created_By_Column.HeaderText = "Created By";
            this.Created_By_Column.Name = "Created_By_Column";
            this.Created_By_Column.ReadOnly = true;
            this.Created_By_Column.Visible = false;
            // 
            // CreateDate_Column
            // 
            this.CreateDate_Column.DataPropertyName = "CreateDate_Column";
            this.CreateDate_Column.HeaderText = "Create Date";
            this.CreateDate_Column.Name = "CreateDate_Column";
            this.CreateDate_Column.ReadOnly = true;
            this.CreateDate_Column.Visible = false;
            // 
            // End_Column
            // 
            this.End_Column.DataPropertyName = "End_Column";
            this.End_Column.HeaderText = "End";
            this.End_Column.Name = "End_Column";
            this.End_Column.ReadOnly = true;
            this.End_Column.Width = 200;
            // 
            // Start_Column
            // 
            this.Start_Column.DataPropertyName = "Start_Column";
            this.Start_Column.HeaderText = "Start";
            this.Start_Column.Name = "Start_Column";
            this.Start_Column.ReadOnly = true;
            this.Start_Column.Width = 200;
            // 
            // URL
            // 
            this.URL.DataPropertyName = "URL";
            this.URL.HeaderText = "URL_Column";
            this.URL.Name = "URL";
            this.URL.ReadOnly = true;
            this.URL.Visible = false;
            // 
            // Type_Column
            // 
            this.Type_Column.DataPropertyName = "Type_Column";
            this.Type_Column.HeaderText = "Type";
            this.Type_Column.Name = "Type_Column";
            this.Type_Column.ReadOnly = true;
            this.Type_Column.Width = 200;
            // 
            // Contact_Column
            // 
            this.Contact_Column.DataPropertyName = "Contact_Column";
            this.Contact_Column.HeaderText = "Contact";
            this.Contact_Column.Name = "Contact_Column";
            this.Contact_Column.ReadOnly = true;
            this.Contact_Column.Visible = false;
            // 
            // Location_Column
            // 
            this.Location_Column.DataPropertyName = "Location_Column";
            this.Location_Column.HeaderText = "Location";
            this.Location_Column.Name = "Location_Column";
            this.Location_Column.ReadOnly = true;
            this.Location_Column.Visible = false;
            // 
            // Description_Column
            // 
            this.Description_Column.DataPropertyName = "Description_Column";
            this.Description_Column.HeaderText = "Description";
            this.Description_Column.Name = "Description_Column";
            this.Description_Column.ReadOnly = true;
            this.Description_Column.Visible = false;
            // 
            // Title_Column
            // 
            this.Title_Column.DataPropertyName = "Title_Column";
            this.Title_Column.HeaderText = "Title";
            this.Title_Column.Name = "Title_Column";
            this.Title_Column.ReadOnly = true;
            this.Title_Column.Visible = false;
            // 
            // Customer_Name_Column
            // 
            this.Customer_Name_Column.DataPropertyName = "Customer_Name_Column";
            this.Customer_Name_Column.HeaderText = "Customer Name";
            this.Customer_Name_Column.Name = "Customer_Name_Column";
            this.Customer_Name_Column.ReadOnly = true;
            this.Customer_Name_Column.Width = 250;
            // 
            // Customer_ID_Column
            // 
            this.Customer_ID_Column.DataPropertyName = "Customer_ID_Column";
            this.Customer_ID_Column.HeaderText = "Customer ID";
            this.Customer_ID_Column.Name = "Customer_ID_Column";
            this.Customer_ID_Column.ReadOnly = true;
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
            // ConsultantScheduleDGV
            // 
            this.ConsultantScheduleDGV.AllowUserToAddRows = false;
            this.ConsultantScheduleDGV.AllowUserToDeleteRows = false;
            this.ConsultantScheduleDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConsultantScheduleDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.ConsultantScheduleDGV.Location = new System.Drawing.Point(30, 29);
            this.ConsultantScheduleDGV.Margin = new System.Windows.Forms.Padding(4);
            this.ConsultantScheduleDGV.MultiSelect = false;
            this.ConsultantScheduleDGV.Name = "ConsultantScheduleDGV";
            this.ConsultantScheduleDGV.ReadOnly = true;
            this.ConsultantScheduleDGV.RowHeadersVisible = false;
            this.ConsultantScheduleDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ConsultantScheduleDGV.Size = new System.Drawing.Size(975, 360);
            this.ConsultantScheduleDGV.TabIndex = 12;
            // 
            // ConsultantScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 421);
            this.ControlBox = false;
            this.Controls.Add(this.ConsultantScheduleCloseButton);
            this.Controls.Add(this.ConsultantScheduleDGV);
            this.Name = "ConsultantScheduleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            //this.Text = "Consultant Schedule";
            ((System.ComponentModel.ISupportInitialize)(this.ConsultantScheduleDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button ConsultantScheduleCloseButton;
        private System.Windows.Forms.ToolTip CustomerDBToolTip;
        private System.Windows.Forms.ToolTip AddUpdateDeleteApptToolTip;
        private System.Windows.Forms.DataGridViewTextBoxColumn Last_Update_By_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Last_Update_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Created_By_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateDate_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn End_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Start_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn URL;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contact_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Location_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer_Name_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer_ID_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Appointment_ID_Column;
        private System.Windows.Forms.DataGridView ConsultantScheduleDGV;
    }
}