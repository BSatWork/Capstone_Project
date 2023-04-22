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
            this.ConsultantScheduleCloseButton = new System.Windows.Forms.Button();
            this.ConsultantScheduleDGV = new System.Windows.Forms.DataGridView();
            this.Customer_ID_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer_Name_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Start_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.End_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            // ConsultantScheduleDGV
            // 
            this.ConsultantScheduleDGV.AllowUserToAddRows = false;
            this.ConsultantScheduleDGV.AllowUserToDeleteRows = false;
            this.ConsultantScheduleDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConsultantScheduleDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Customer_ID_Column,
            this.Customer_Name_Column,
            this.Type_Column,
            this.Start_Column,
            this.End_Column});
            this.ConsultantScheduleDGV.Enabled = false;
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
            // Customer_ID_Column
            // 
            this.Customer_ID_Column.DataPropertyName = "customerID";
            this.Customer_ID_Column.HeaderText = "Customer ID";
            this.Customer_ID_Column.Name = "Customer_ID_Column";
            this.Customer_ID_Column.ReadOnly = true;
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
            this.Type_Column.Width = 200;
            // 
            // Start_Column
            // 
            this.Start_Column.DataPropertyName = "start";
            this.Start_Column.HeaderText = "Start";
            this.Start_Column.Name = "Start_Column";
            this.Start_Column.ReadOnly = true;
            this.Start_Column.Width = 200;
            // 
            // End_Column
            // 
            this.End_Column.DataPropertyName = "end";
            this.End_Column.HeaderText = "End";
            this.End_Column.Name = "End_Column";
            this.End_Column.ReadOnly = true;
            this.End_Column.Width = 200;
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
            ((System.ComponentModel.ISupportInitialize)(this.ConsultantScheduleDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button ConsultantScheduleCloseButton;
        private System.Windows.Forms.DataGridView ConsultantScheduleDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer_ID_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer_Name_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Start_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn End_Column;
    }
}