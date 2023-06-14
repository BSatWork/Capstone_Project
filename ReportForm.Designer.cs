namespace RYM2_Capstone_Scheduling_App
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
            this.EmployeeScheduleButton = new System.Windows.Forms.Button();
            this.ConsultantScheduleToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.TotalApptsThisYearButton = new System.Windows.Forms.Button();
            this.TotalApptsThisYearToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.EmployeeUserNameComboBox = new System.Windows.Forms.ComboBox();
            this.MonthsComboBox = new System.Windows.Forms.ComboBox();
            this.ApptTypeComboBox = new System.Windows.Forms.ComboBox();
            this.ReportMonthLabel = new System.Windows.Forms.Label();
            this.ReportApptTypeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ReportFormCloseButton
            // 
            this.ReportFormCloseButton.BackColor = System.Drawing.SystemColors.Control;
            this.ReportFormCloseButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.ReportFormCloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReportFormCloseButton.Font = new System.Drawing.Font("Tahoma", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportFormCloseButton.Location = new System.Drawing.Point(407, -5);
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
            // EmployeeScheduleButton
            // 
            this.EmployeeScheduleButton.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeScheduleButton.Location = new System.Drawing.Point(246, 28);
            this.EmployeeScheduleButton.Margin = new System.Windows.Forms.Padding(4);
            this.EmployeeScheduleButton.Name = "EmployeeScheduleButton";
            this.EmployeeScheduleButton.Size = new System.Drawing.Size(175, 62);
            this.EmployeeScheduleButton.TabIndex = 30;
            this.EmployeeScheduleButton.Text = "Employee Schedule";
            this.EmployeeScheduleButton.UseVisualStyleBackColor = true;
            this.EmployeeScheduleButton.Click += new System.EventHandler(this.ConsultantScheduleButton_Click);
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
            this.TotalApptsThisYearButton.Text = "Total Remaining Appointments this Year";
            this.TotalApptsThisYearButton.UseVisualStyleBackColor = true;
            this.TotalApptsThisYearButton.Click += new System.EventHandler(this.TotalApptsThisYearButton_Click);
            // 
            // TotalApptsThisYearToolTip
            // 
            this.TotalApptsThisYearToolTip.IsBalloon = true;
            // 
            // EmployeeUserNameComboBox
            // 
            this.EmployeeUserNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EmployeeUserNameComboBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeUserNameComboBox.FormattingEnabled = true;
            this.EmployeeUserNameComboBox.Location = new System.Drawing.Point(246, 122);
            this.EmployeeUserNameComboBox.Name = "EmployeeUserNameComboBox";
            this.EmployeeUserNameComboBox.Size = new System.Drawing.Size(175, 27);
            this.EmployeeUserNameComboBox.TabIndex = 33;
            // 
            // MonthsComboBox
            // 
            this.MonthsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MonthsComboBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonthsComboBox.FormattingEnabled = true;
            this.MonthsComboBox.Items.AddRange(new object[] {
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
            this.MonthsComboBox.Location = new System.Drawing.Point(28, 177);
            this.MonthsComboBox.Name = "MonthsComboBox";
            this.MonthsComboBox.Size = new System.Drawing.Size(175, 27);
            this.MonthsComboBox.TabIndex = 34;
            this.MonthsComboBox.SelectedIndexChanged += new System.EventHandler(this.MonthsComboBox_SelectedIndexChanged);
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
            this.ApptTypeComboBox.Location = new System.Drawing.Point(28, 122);
            this.ApptTypeComboBox.Name = "ApptTypeComboBox";
            this.ApptTypeComboBox.Size = new System.Drawing.Size(175, 27);
            this.ApptTypeComboBox.TabIndex = 35;
            this.ApptTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.ApptTypeComboBox_SelectedIndexChanged);
            // 
            // ReportMonthLabel
            // 
            this.ReportMonthLabel.AutoSize = true;
            this.ReportMonthLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ReportMonthLabel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportMonthLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.ReportMonthLabel.Location = new System.Drawing.Point(91, 181);
            this.ReportMonthLabel.Name = "ReportMonthLabel";
            this.ReportMonthLabel.Size = new System.Drawing.Size(54, 18);
            this.ReportMonthLabel.TabIndex = 37;
            this.ReportMonthLabel.Text = "Month";
            // 
            // ReportApptTypeLabel
            // 
            this.ReportApptTypeLabel.AutoSize = true;
            this.ReportApptTypeLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ReportApptTypeLabel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportApptTypeLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.ReportApptTypeLabel.Location = new System.Drawing.Point(40, 126);
            this.ReportApptTypeLabel.Name = "ReportApptTypeLabel";
            this.ReportApptTypeLabel.Size = new System.Drawing.Size(142, 18);
            this.ReportApptTypeLabel.TabIndex = 36;
            this.ReportApptTypeLabel.Text = "Appointment Type";
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 355);
            this.ControlBox = false;
            this.Controls.Add(this.ReportMonthLabel);
            this.Controls.Add(this.ReportApptTypeLabel);
            this.Controls.Add(this.ApptTypeComboBox);
            this.Controls.Add(this.MonthsComboBox);
            this.Controls.Add(this.EmployeeUserNameComboBox);
            this.Controls.Add(this.TotalApptsThisYearButton);
            this.Controls.Add(this.EmployeeScheduleButton);
            this.Controls.Add(this.NumberApptTypesByMonthButton);
            this.Controls.Add(this.ReportFormCloseButton);
            this.Name = "ReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reports";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ReportFormCloseButton;
        private System.Windows.Forms.Button NumberApptTypesByMonthButton;
        private System.Windows.Forms.ToolTip NumberApptTypesByMonth;
        private System.Windows.Forms.Button EmployeeScheduleButton;
        private System.Windows.Forms.ToolTip ConsultantScheduleToolTip;
        private System.Windows.Forms.Button TotalApptsThisYearButton;
        private System.Windows.Forms.ToolTip TotalApptsThisYearToolTip;
        private System.Windows.Forms.ComboBox EmployeeUserNameComboBox;
        private System.Windows.Forms.ComboBox MonthsComboBox;
        private System.Windows.Forms.ComboBox ApptTypeComboBox;
        private System.Windows.Forms.Label ReportMonthLabel;
        private System.Windows.Forms.Label ReportApptTypeLabel;
    }
}