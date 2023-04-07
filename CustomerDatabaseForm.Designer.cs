﻿namespace BOP3_Task_1_DB_and_File_Server_App
{
    partial class CustomerDatabaseForm
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
            this.CustomerDBCloseButton = new System.Windows.Forms.Button();
            this.CustomerDBDGV = new System.Windows.Forms.DataGridView();
            this.NewCustomerButton = new System.Windows.Forms.Button();
            this.DeleteCustomerButton = new System.Windows.Forms.Button();
            this.UpdateCustomerButton = new System.Windows.Forms.Button();
            this.CustomerCount = new System.Windows.Forms.Label();
            this.CustomerCountLabel = new System.Windows.Forms.Label();
            this.DBCustomer_ID_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DBCustomer_Name_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DBCustomer_Address_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DBCustomer_Active = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DBAddress_Address1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DBAddress_Address2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DBAddress_CityID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DBCity_City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DBCity_CountryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DBCountry_Country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerDBDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomerDBCloseButton
            // 
            this.CustomerDBCloseButton.BackColor = System.Drawing.SystemColors.Control;
            this.CustomerDBCloseButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.CustomerDBCloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CustomerDBCloseButton.Font = new System.Drawing.Font("Tahoma", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerDBCloseButton.Location = new System.Drawing.Point(1239, -4);
            this.CustomerDBCloseButton.Margin = new System.Windows.Forms.Padding(0);
            this.CustomerDBCloseButton.Name = "CustomerDBCloseButton";
            this.CustomerDBCloseButton.Size = new System.Drawing.Size(52, 23);
            this.CustomerDBCloseButton.TabIndex = 11;
            this.CustomerDBCloseButton.Text = "Close";
            this.CustomerDBCloseButton.UseVisualStyleBackColor = false;
            this.CustomerDBCloseButton.Click += new System.EventHandler(this.CustomerDBCloseButton_Click);
            // 
            // CustomerDBDGV
            // 
            this.CustomerDBDGV.AllowUserToAddRows = false;
            this.CustomerDBDGV.AllowUserToDeleteRows = false;
            this.CustomerDBDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomerDBDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DBCustomer_ID_Column,
            this.DBCustomer_Name_Column,
            this.DBCustomer_Address_ID,
            this.DBCustomer_Active,
            this.DBAddress_Address1,
            this.DBAddress_Address2,
            this.DBAddress_CityID,
            this.DBCity_City,
            this.DBCity_CountryID,
            this.DBCountry_Country});
            this.CustomerDBDGV.Location = new System.Drawing.Point(30, 55);
            this.CustomerDBDGV.Margin = new System.Windows.Forms.Padding(4);
            this.CustomerDBDGV.MultiSelect = false;
            this.CustomerDBDGV.Name = "CustomerDBDGV";
            this.CustomerDBDGV.ReadOnly = true;
            this.CustomerDBDGV.RowHeadersVisible = false;
            this.CustomerDBDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CustomerDBDGV.Size = new System.Drawing.Size(1225, 360);
            this.CustomerDBDGV.TabIndex = 10;
            // 
            // NewCustomerButton
            // 
            this.NewCustomerButton.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewCustomerButton.Location = new System.Drawing.Point(30, 9);
            this.NewCustomerButton.Margin = new System.Windows.Forms.Padding(4);
            this.NewCustomerButton.Name = "NewCustomerButton";
            this.NewCustomerButton.Size = new System.Drawing.Size(150, 35);
            this.NewCustomerButton.TabIndex = 12;
            this.NewCustomerButton.Text = "New Customer";
            this.NewCustomerButton.UseVisualStyleBackColor = true;
            this.NewCustomerButton.Click += new System.EventHandler(this.NewCustomerButton_Click);
            // 
            // DeleteCustomerButton
            // 
            this.DeleteCustomerButton.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteCustomerButton.Location = new System.Drawing.Point(370, 9);
            this.DeleteCustomerButton.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteCustomerButton.Name = "DeleteCustomerButton";
            this.DeleteCustomerButton.Size = new System.Drawing.Size(150, 35);
            this.DeleteCustomerButton.TabIndex = 13;
            this.DeleteCustomerButton.Text = "Delete Customer";
            this.DeleteCustomerButton.UseVisualStyleBackColor = true;
            this.DeleteCustomerButton.Click += new System.EventHandler(this.DeleteCustomerButton_Click);
            // 
            // UpdateCustomerButton
            // 
            this.UpdateCustomerButton.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateCustomerButton.Location = new System.Drawing.Point(200, 9);
            this.UpdateCustomerButton.Margin = new System.Windows.Forms.Padding(4);
            this.UpdateCustomerButton.Name = "UpdateCustomerButton";
            this.UpdateCustomerButton.Size = new System.Drawing.Size(150, 35);
            this.UpdateCustomerButton.TabIndex = 14;
            this.UpdateCustomerButton.Text = "Update Customer";
            this.UpdateCustomerButton.UseVisualStyleBackColor = true;
            this.UpdateCustomerButton.Click += new System.EventHandler(this.UpdateCustomerButton_Click);
            // 
            // CustomerCount
            // 
            this.CustomerCount.AutoSize = true;
            this.CustomerCount.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerCount.Location = new System.Drawing.Point(164, 419);
            this.CustomerCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CustomerCount.Name = "CustomerCount";
            this.CustomerCount.Size = new System.Drawing.Size(18, 18);
            this.CustomerCount.TabIndex = 16;
            this.CustomerCount.Text = "0";
            // 
            // CustomerCountLabel
            // 
            this.CustomerCountLabel.AutoSize = true;
            this.CustomerCountLabel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerCountLabel.Location = new System.Drawing.Point(33, 419);
            this.CustomerCountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CustomerCountLabel.Name = "CustomerCountLabel";
            this.CustomerCountLabel.Size = new System.Drawing.Size(131, 18);
            this.CustomerCountLabel.TabIndex = 15;
            this.CustomerCountLabel.Text = "Customer Count:";
            // 
            // DBCustomer_ID_Column
            // 
            this.DBCustomer_ID_Column.DataPropertyName = "DBCustomer_ID_Column";
            this.DBCustomer_ID_Column.HeaderText = "Customer ID";
            this.DBCustomer_ID_Column.Name = "DBCustomer_ID_Column";
            this.DBCustomer_ID_Column.ReadOnly = true;
            this.DBCustomer_ID_Column.Width = 90;
            // 
            // DBCustomer_Name_Column
            // 
            this.DBCustomer_Name_Column.DataPropertyName = "DBCustomer_Name_Column";
            this.DBCustomer_Name_Column.HeaderText = "Customer Name";
            this.DBCustomer_Name_Column.Name = "DBCustomer_Name_Column";
            this.DBCustomer_Name_Column.ReadOnly = true;
            this.DBCustomer_Name_Column.Width = 250;
            // 
            // DBCustomer_Address_ID
            // 
            this.DBCustomer_Address_ID.DataPropertyName = "DBCustomer_Address_ID";
            this.DBCustomer_Address_ID.HeaderText = "AddressID";
            this.DBCustomer_Address_ID.Name = "DBCustomer_Address_ID";
            this.DBCustomer_Address_ID.ReadOnly = true;
            this.DBCustomer_Address_ID.Visible = false;
            // 
            // DBCustomer_Active
            // 
            this.DBCustomer_Active.DataPropertyName = "DBCustomer_Active";
            this.DBCustomer_Active.HeaderText = "Active";
            this.DBCustomer_Active.Name = "DBCustomer_Active";
            this.DBCustomer_Active.ReadOnly = true;
            this.DBCustomer_Active.Visible = false;
            // 
            // DBAddress_Address1
            // 
            this.DBAddress_Address1.DataPropertyName = "DBAddress_Address1";
            this.DBAddress_Address1.HeaderText = "Address";
            this.DBAddress_Address1.Name = "DBAddress_Address1";
            this.DBAddress_Address1.ReadOnly = true;
            this.DBAddress_Address1.Width = 250;
            // 
            // DBAddress_Address2
            // 
            this.DBAddress_Address2.DataPropertyName = "DBAddress_Address2";
            this.DBAddress_Address2.HeaderText = "Address";
            this.DBAddress_Address2.Name = "DBAddress_Address2";
            this.DBAddress_Address2.ReadOnly = true;
            this.DBAddress_Address2.Width = 250;
            // 
            // DBAddress_CityID
            // 
            this.DBAddress_CityID.DataPropertyName = "DBAddress_CityID";
            this.DBAddress_CityID.HeaderText = "City ID";
            this.DBAddress_CityID.Name = "DBAddress_CityID";
            this.DBAddress_CityID.ReadOnly = true;
            this.DBAddress_CityID.Visible = false;
            // 
            // DBCity_City
            // 
            this.DBCity_City.DataPropertyName = "DBCity_City";
            this.DBCity_City.HeaderText = "City";
            this.DBCity_City.Name = "DBCity_City";
            this.DBCity_City.ReadOnly = true;
            this.DBCity_City.Width = 150;
            // 
            // DBCity_CountryID
            // 
            this.DBCity_CountryID.DataPropertyName = "DBCity_CountryID";
            this.DBCity_CountryID.HeaderText = "Country ID";
            this.DBCity_CountryID.Name = "DBCity_CountryID";
            this.DBCity_CountryID.ReadOnly = true;
            this.DBCity_CountryID.Visible = false;
            this.DBCity_CountryID.Width = 150;
            // 
            // DBCountry_Country
            // 
            this.DBCountry_Country.DataPropertyName = "DBCountry_Country";
            this.DBCountry_Country.HeaderText = "Country";
            this.DBCountry_Country.Name = "DBCountry_Country";
            this.DBCountry_Country.ReadOnly = true;
            this.DBCountry_Country.Width = 150;
            // 
            // CustomerDatabaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 461);
            this.ControlBox = false;
            this.Controls.Add(this.CustomerCount);
            this.Controls.Add(this.CustomerCountLabel);
            this.Controls.Add(this.UpdateCustomerButton);
            this.Controls.Add(this.DeleteCustomerButton);
            this.Controls.Add(this.NewCustomerButton);
            this.Controls.Add(this.CustomerDBCloseButton);
            this.Controls.Add(this.CustomerDBDGV);
            this.Name = "CustomerDatabaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Database";
            ((System.ComponentModel.ISupportInitialize)(this.CustomerDBDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CustomerDBCloseButton;
        private System.Windows.Forms.DataGridView CustomerDBDGV;
        private System.Windows.Forms.Button NewCustomerButton;
        private System.Windows.Forms.Button DeleteCustomerButton;
        private System.Windows.Forms.Button UpdateCustomerButton;
        private System.Windows.Forms.Label CustomerCount;
        private System.Windows.Forms.Label CustomerCountLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn DBCustomer_ID_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn DBCustomer_Name_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn DBCustomer_Address_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DBCustomer_Active;
        private System.Windows.Forms.DataGridViewTextBoxColumn DBAddress_Address1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DBAddress_Address2;
        private System.Windows.Forms.DataGridViewTextBoxColumn DBAddress_CityID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DBCity_City;
        private System.Windows.Forms.DataGridViewTextBoxColumn DBCity_CountryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DBCountry_Country;
    }
}