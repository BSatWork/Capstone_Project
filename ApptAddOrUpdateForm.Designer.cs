namespace BOP3_Task_1_DB_and_File_Server_App
{
    partial class ApptAddOrUpdateForm
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
            System.Windows.Forms.DateTimePicker ApptStartDateInput;
            System.Windows.Forms.DateTimePicker ApptEndDateInput;
            this.ApptSave = new System.Windows.Forms.Button();
            this.ApptDelete = new System.Windows.Forms.Button();
            this.ApptTypeLabel = new System.Windows.Forms.Label();
            this.ApptTypeInput = new System.Windows.Forms.TextBox();
            this.ApptEndDateLabel = new System.Windows.Forms.Label();
            this.ApptCustomerLabel = new System.Windows.Forms.Label();
            this.ApptCustomerInput = new System.Windows.Forms.TextBox();
            this.ApptStartDateLabel = new System.Windows.Forms.Label();
            ApptStartDateInput = new System.Windows.Forms.DateTimePicker();
            ApptEndDateInput = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // ApptStartDateInput
            // 
            ApptStartDateInput.AllowDrop = true;
            ApptStartDateInput.CustomFormat = "MM/DD/YYY HH:MM";
            ApptStartDateInput.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ApptStartDateInput.Location = new System.Drawing.Point(205, 138);
            ApptStartDateInput.MinDate = new System.DateTime(2023, 1, 1, 0, 0, 0, 0);
            ApptStartDateInput.Name = "ApptStartDateInput";
            ApptStartDateInput.Size = new System.Drawing.Size(194, 21);
            ApptStartDateInput.TabIndex = 20;
            // 
            // ApptEndDateInput
            // 
            ApptEndDateInput.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ApptEndDateInput.Location = new System.Drawing.Point(205, 188);
            ApptEndDateInput.MinDate = new System.DateTime(2023, 1, 1, 0, 0, 0, 0);
            ApptEndDateInput.Name = "ApptEndDateInput";
            ApptEndDateInput.Size = new System.Drawing.Size(194, 21);
            ApptEndDateInput.TabIndex = 22;
            ApptEndDateInput.Value = new System.DateTime(2023, 3, 10, 0, 0, 0, 0);
            // 
            // ApptSave
            // 
            this.ApptSave.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApptSave.Location = new System.Drawing.Point(280, 240);
            this.ApptSave.Name = "ApptSave";
            this.ApptSave.Size = new System.Drawing.Size(118, 31);
            this.ApptSave.TabIndex = 0;
            this.ApptSave.Text = "Save";
            this.ApptSave.UseVisualStyleBackColor = true;
            this.ApptSave.Click += new System.EventHandler(this.ApptSave_Click);
            // 
            // ApptDelete
            // 
            this.ApptDelete.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApptDelete.Location = new System.Drawing.Point(50, 240);
            this.ApptDelete.Name = "ApptDelete";
            this.ApptDelete.Size = new System.Drawing.Size(118, 31);
            this.ApptDelete.TabIndex = 1;
            this.ApptDelete.Text = "Delete";
            this.ApptDelete.UseVisualStyleBackColor = true;
            this.ApptDelete.Click += new System.EventHandler(this.ApptDelete_Click);
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
            // ApptTypeInput
            // 
            this.ApptTypeInput.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApptTypeInput.Location = new System.Drawing.Point(205, 36);
            this.ApptTypeInput.Name = "ApptTypeInput";
            this.ApptTypeInput.Size = new System.Drawing.Size(194, 27);
            this.ApptTypeInput.TabIndex = 13;
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
            // ApptCustomerInput
            // 
            this.ApptCustomerInput.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApptCustomerInput.Location = new System.Drawing.Point(205, 86);
            this.ApptCustomerInput.Name = "ApptCustomerInput";
            this.ApptCustomerInput.Size = new System.Drawing.Size(194, 27);
            this.ApptCustomerInput.TabIndex = 15;
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
            // ApptAddOrUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 326);
            this.Controls.Add(ApptEndDateInput);
            this.Controls.Add(ApptStartDateInput);
            this.Controls.Add(this.ApptStartDateLabel);
            this.Controls.Add(this.ApptCustomerInput);
            this.Controls.Add(this.ApptCustomerLabel);
            this.Controls.Add(this.ApptTypeInput);
            this.Controls.Add(this.ApptTypeLabel);
            this.Controls.Add(this.ApptEndDateLabel);
            this.Controls.Add(this.ApptDelete);
            this.Controls.Add(this.ApptSave);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ApptAddOrUpdateForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Appointment Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ApptSave;
        private System.Windows.Forms.Button ApptDelete;
        private System.Windows.Forms.Label ApptTypeLabel;
        private System.Windows.Forms.TextBox ApptTypeInput;
        private System.Windows.Forms.Label ApptEndDateLabel;
        private System.Windows.Forms.Label ApptCustomerLabel;
        private System.Windows.Forms.TextBox ApptCustomerInput;
        private System.Windows.Forms.Label ApptStartDateLabel;
    }
}