namespace BOP3_Task_1_DB_and_File_Server_App
{
    partial class ReportForm
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
            this.ReportFormCloseButton = new System.Windows.Forms.Button();
            this.NumberApptTypesByMonthButton = new System.Windows.Forms.Button();
            this.NumberApptTypesByMonth = new System.Windows.Forms.ToolTip(this.components);
            this.ApptTypeListBox = new System.Windows.Forms.ListBox();
            this.MonthsListBox = new System.Windows.Forms.ListBox();
            this.ConsultantListBox = new System.Windows.Forms.ListBox();
            this.ConsultantScheduleButton = new System.Windows.Forms.Button();
            this.ConsultantScheduleToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.TotalApptsThisYearButton = new System.Windows.Forms.Button();
            this.TotalApptsThisYearToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // ReportFormCloseButton
            // 
            this.ReportFormCloseButton.BackColor = System.Drawing.SystemColors.Control;
            this.ReportFormCloseButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.ReportFormCloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReportFormCloseButton.Font = new System.Drawing.Font("Tahoma", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportFormCloseButton.Location = new System.Drawing.Point(416, -5);
            this.ReportFormCloseButton.Margin = new System.Windows.Forms.Padding(0);
            this.ReportFormCloseButton.Name = "ReportFormCloseButton";
            this.ReportFormCloseButton.Size = new System.Drawing.Size(52, 23);
            this.ReportFormCloseButton.TabIndex = 10;
            this.ReportFormCloseButton.Text = "Close";
            this.ReportFormCloseButton.UseVisualStyleBackColor = false;
            this.ReportFormCloseButton.Click += new System.EventHandler(this.ReportFormCloseButton_Click);
            // 
            // NumberApptTypesByMonthButton
            // 
            this.NumberApptTypesByMonthButton.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberApptTypesByMonthButton.Location = new System.Drawing.Point(28, 28);
            this.NumberApptTypesByMonthButton.Margin = new System.Windows.Forms.Padding(4);
            this.NumberApptTypesByMonthButton.Name = "NumberApptTypesByMonthButton";
            this.NumberApptTypesByMonthButton.Size = new System.Drawing.Size(175, 62);
            this.NumberApptTypesByMonthButton.TabIndex = 11;
            this.NumberApptTypesByMonthButton.Text = "Number of Appointment Types by Month";
            this.NumberApptTypesByMonthButton.UseVisualStyleBackColor = true;
            this.NumberApptTypesByMonthButton.Click += new System.EventHandler(this.NumberApptTypesByMonthButton_Click);
            // 
            // NumberApptTypesByMonth
            // 
            this.NumberApptTypesByMonth.IsBalloon = true;
            // 
            // ApptTypeListBox
            // 
            this.ApptTypeListBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApptTypeListBox.FormattingEnabled = true;
            this.ApptTypeListBox.ItemHeight = 19;
            this.ApptTypeListBox.Location = new System.Drawing.Point(28, 122);
            this.ApptTypeListBox.Name = "ApptTypeListBox";
            this.ApptTypeListBox.Size = new System.Drawing.Size(175, 23);
            this.ApptTypeListBox.TabIndex = 28;
            // 
            // MonthsListBox
            // 
            this.MonthsListBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonthsListBox.FormattingEnabled = true;
            this.MonthsListBox.ItemHeight = 19;
            this.MonthsListBox.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.MonthsListBox.Location = new System.Drawing.Point(28, 177);
            this.MonthsListBox.Name = "MonthsListBox";
            this.MonthsListBox.Size = new System.Drawing.Size(175, 23);
            this.MonthsListBox.TabIndex = 29;
            // 
            // ConsultantListBox
            // 
            this.ConsultantListBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsultantListBox.FormattingEnabled = true;
            this.ConsultantListBox.ItemHeight = 19;
            this.ConsultantListBox.Location = new System.Drawing.Point(255, 122);
            this.ConsultantListBox.Name = "ConsultantListBox";
            this.ConsultantListBox.Size = new System.Drawing.Size(175, 23);
            this.ConsultantListBox.TabIndex = 31;
            // 
            // ConsultantScheduleButton
            // 
            this.ConsultantScheduleButton.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsultantScheduleButton.Location = new System.Drawing.Point(255, 28);
            this.ConsultantScheduleButton.Margin = new System.Windows.Forms.Padding(4);
            this.ConsultantScheduleButton.Name = "ConsultantScheduleButton";
            this.ConsultantScheduleButton.Size = new System.Drawing.Size(175, 62);
            this.ConsultantScheduleButton.TabIndex = 30;
            this.ConsultantScheduleButton.Text = "Consultant Schedule";
            this.ConsultantScheduleButton.UseVisualStyleBackColor = true;
            this.ConsultantScheduleButton.Click += new System.EventHandler(this.ConsultantScheduleButton_Click);
            // 
            // ConsultantScheduleToolTip
            // 
            this.ConsultantScheduleToolTip.IsBalloon = true;
            // 
            // TotalApptsThisYearButton
            // 
            this.TotalApptsThisYearButton.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalApptsThisYearButton.Location = new System.Drawing.Point(28, 256);
            this.TotalApptsThisYearButton.Margin = new System.Windows.Forms.Padding(4);
            this.TotalApptsThisYearButton.Name = "TotalApptsThisYearButton";
            this.TotalApptsThisYearButton.Size = new System.Drawing.Size(175, 62);
            this.TotalApptsThisYearButton.TabIndex = 32;
            this.TotalApptsThisYearButton.Text = "Total Appointments this Year";
            this.TotalApptsThisYearButton.UseVisualStyleBackColor = true;
            this.TotalApptsThisYearButton.Click += new System.EventHandler(this.TotalApptsThisYearButton_Click);
            // 
            // TotalApptsThisYearToolTip
            // 
            this.TotalApptsThisYearToolTip.IsBalloon = true;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 355);
            this.ControlBox = false;
            this.Controls.Add(this.TotalApptsThisYearButton);
            this.Controls.Add(this.ConsultantListBox);
            this.Controls.Add(this.ConsultantScheduleButton);
            this.Controls.Add(this.MonthsListBox);
            this.Controls.Add(this.ApptTypeListBox);
            this.Controls.Add(this.NumberApptTypesByMonthButton);
            this.Controls.Add(this.ReportFormCloseButton);
            this.Name = "ReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reports";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ReportFormCloseButton;
        private System.Windows.Forms.Button NumberApptTypesByMonthButton;
        private System.Windows.Forms.ToolTip NumberApptTypesByMonth;
        private System.Windows.Forms.ListBox ApptTypeListBox;
        private System.Windows.Forms.ListBox MonthsListBox;
        private System.Windows.Forms.ListBox ConsultantListBox;
        private System.Windows.Forms.Button ConsultantScheduleButton;
        private System.Windows.Forms.ToolTip ConsultantScheduleToolTip;
        private System.Windows.Forms.Button TotalApptsThisYearButton;
        private System.Windows.Forms.ToolTip TotalApptsThisYearToolTip;
    }
}