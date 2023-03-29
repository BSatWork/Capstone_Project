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
            this.AddUpdateDeleteApptButton = new System.Windows.Forms.Button();
            this.TotalApptCntLabel = new System.Windows.Forms.Label();
            this.TotalApptCnt = new System.Windows.Forms.Label();
            this.AddUpdateDeleteApptToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.CustomerDBButton = new System.Windows.Forms.Button();
            this.CustomerDBToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.CalendarView = new System.Windows.Forms.ComboBox();
            this.Appointment_ID_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer_Name_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.AppoinmentsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // AppoinmentsDGV
            // 
            this.AppoinmentsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AppoinmentsDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Appointment_ID_Column,
            this.Customer_Name_Column});
            this.AppoinmentsDGV.Location = new System.Drawing.Point(31, 55);
            this.AppoinmentsDGV.Margin = new System.Windows.Forms.Padding(4);
            this.AppoinmentsDGV.Name = "AppoinmentsDGV";
            this.AppoinmentsDGV.Size = new System.Drawing.Size(873, 360);
            this.AppoinmentsDGV.TabIndex = 0;
            // 
            // AddUpdateDeleteApptButton
            // 
            this.AddUpdateDeleteApptButton.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddUpdateDeleteApptButton.Location = new System.Drawing.Point(31, 13);
            this.AddUpdateDeleteApptButton.Margin = new System.Windows.Forms.Padding(4);
            this.AddUpdateDeleteApptButton.Name = "AddUpdateDeleteApptButton";
            this.AddUpdateDeleteApptButton.Size = new System.Drawing.Size(243, 36);
            this.AddUpdateDeleteApptButton.TabIndex = 1;
            this.AddUpdateDeleteApptButton.Text = "Add/Update/Delete Appt";
            this.AddUpdateDeleteApptButton.UseVisualStyleBackColor = true;
            this.AddUpdateDeleteApptButton.Click += new System.EventHandler(this.AddUpdateDeleteApptButton_Click);
            // 
            // TotalApptCntLabel
            // 
            this.TotalApptCntLabel.AutoSize = true;
            this.TotalApptCntLabel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalApptCntLabel.Location = new System.Drawing.Point(35, 419);
            this.TotalApptCntLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TotalApptCntLabel.Name = "TotalApptCntLabel";
            this.TotalApptCntLabel.Size = new System.Drawing.Size(196, 18);
            this.TotalApptCntLabel.TabIndex = 2;
            this.TotalApptCntLabel.Text = "Total Appointment Count:";
            // 
            // TotalApptCnt
            // 
            this.TotalApptCnt.AutoSize = true;
            this.TotalApptCnt.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalApptCnt.Location = new System.Drawing.Point(239, 419);
            this.TotalApptCnt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TotalApptCnt.Name = "TotalApptCnt";
            this.TotalApptCnt.Size = new System.Drawing.Size(18, 18);
            this.TotalApptCnt.TabIndex = 3;
            this.TotalApptCnt.Text = "0";
            // 
            // AddUpdateDeleteApptToolTip
            // 
            this.AddUpdateDeleteApptToolTip.AutoPopDelay = 10000;
            this.AddUpdateDeleteApptToolTip.InitialDelay = 100;
            this.AddUpdateDeleteApptToolTip.IsBalloon = true;
            this.AddUpdateDeleteApptToolTip.ReshowDelay = 100;
            // 
            // CustomerDBButton
            // 
            this.CustomerDBButton.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerDBButton.Location = new System.Drawing.Point(729, 419);
            this.CustomerDBButton.Margin = new System.Windows.Forms.Padding(4);
            this.CustomerDBButton.Name = "CustomerDBButton";
            this.CustomerDBButton.Size = new System.Drawing.Size(175, 36);
            this.CustomerDBButton.TabIndex = 4;
            this.CustomerDBButton.Text = "Customer Database";
            this.CustomerDBButton.UseVisualStyleBackColor = true;
            this.CustomerDBButton.Click += new System.EventHandler(this.CustomerDBButton_Click);
            // 
            // CustomerDBToolTip
            // 
            this.CustomerDBToolTip.AutoPopDelay = 10000;
            this.CustomerDBToolTip.InitialDelay = 100;
            this.CustomerDBToolTip.IsBalloon = true;
            this.CustomerDBToolTip.ReshowDelay = 100;
            // 
            // CalendarView
            // 
            this.CalendarView.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalendarView.FormattingEnabled = true;
            this.CalendarView.Location = new System.Drawing.Point(783, 19);
            this.CalendarView.Name = "CalendarView";
            this.CalendarView.Size = new System.Drawing.Size(121, 26);
            this.CalendarView.TabIndex = 5;
            // 
            // Appointment_ID_Column
            // 
            this.Appointment_ID_Column.DataPropertyName = "Appointment_ID_Column";
            this.Appointment_ID_Column.HeaderText = "Appt ID";
            this.Appointment_ID_Column.Name = "Appointment_ID_Column";
            this.Appointment_ID_Column.Width = 85;
            // 
            // Customer_Name_Column
            // 
            this.Customer_Name_Column.DataPropertyName = "Customer_Name_Column";
            this.Customer_Name_Column.HeaderText = "Customer Name";
            this.Customer_Name_Column.Name = "Customer_Name_Column";
            this.Customer_Name_Column.Width = 200;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 467);
            this.Controls.Add(this.CalendarView);
            this.Controls.Add(this.CustomerDBButton);
            this.Controls.Add(this.TotalApptCnt);
            this.Controls.Add(this.TotalApptCntLabel);
            this.Controls.Add(this.AddUpdateDeleteApptButton);
            this.Controls.Add(this.AppoinmentsDGV);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainScreen";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Appointment Scheduler App";
            ((System.ComponentModel.ISupportInitialize)(this.AppoinmentsDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView AppoinmentsDGV;
        private System.Windows.Forms.Button AddUpdateDeleteApptButton;
        private System.Windows.Forms.Label TotalApptCntLabel;
        private System.Windows.Forms.Label TotalApptCnt;
        private System.Windows.Forms.ToolTip AddUpdateDeleteApptToolTip;
        private System.Windows.Forms.Button CustomerDBButton;
        private System.Windows.Forms.ToolTip CustomerDBToolTip;
        private System.Windows.Forms.ComboBox CalendarView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Appointment_ID_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer_Name_Column;
    }
}