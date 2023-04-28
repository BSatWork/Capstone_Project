namespace BOP3_Task_1_DB_and_File_Server_App
{
    partial class NewCustomerForm
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
            this.Customer_Address2_Label = new System.Windows.Forms.Label();
            this.Customer_Address1_Label = new System.Windows.Forms.Label();
            this.Customer_Name_Label = new System.Windows.Forms.Label();
            this.Customer_ID_Label = new System.Windows.Forms.Label();
            this.Customer_Address2 = new System.Windows.Forms.TextBox();
            this.Customer_Address1 = new System.Windows.Forms.TextBox();
            this.Customer_Name = new System.Windows.Forms.TextBox();
            this.Customer_ID = new System.Windows.Forms.TextBox();
            this.Customer_Save_Button = new System.Windows.Forms.Button();
            this.Customer_Cancel_Button = new System.Windows.Forms.Button();
            this.Customer_Country_Label = new System.Windows.Forms.Label();
            this.Customer_City_Label = new System.Windows.Forms.Label();
            this.Customer_Country = new System.Windows.Forms.TextBox();
            this.Customer_City = new System.Windows.Forms.TextBox();
            this.Customer_Phone = new System.Windows.Forms.TextBox();
            this.Customer_Phone_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Customer_Address2_Label
            // 
            this.Customer_Address2_Label.AutoSize = true;
            this.Customer_Address2_Label.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customer_Address2_Label.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Customer_Address2_Label.Location = new System.Drawing.Point(49, 153);
            this.Customer_Address2_Label.Name = "Customer_Address2_Label";
            this.Customer_Address2_Label.Size = new System.Drawing.Size(60, 18);
            this.Customer_Address2_Label.TabIndex = 23;
            this.Customer_Address2_Label.Text = "Address";
            this.Customer_Address2_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Customer_Address1_Label
            // 
            this.Customer_Address1_Label.AutoSize = true;
            this.Customer_Address1_Label.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customer_Address1_Label.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Customer_Address1_Label.Location = new System.Drawing.Point(49, 113);
            this.Customer_Address1_Label.Name = "Customer_Address1_Label";
            this.Customer_Address1_Label.Size = new System.Drawing.Size(60, 18);
            this.Customer_Address1_Label.TabIndex = 22;
            this.Customer_Address1_Label.Text = "Address";
            this.Customer_Address1_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Customer_Name_Label
            // 
            this.Customer_Name_Label.AutoSize = true;
            this.Customer_Name_Label.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customer_Name_Label.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Customer_Name_Label.Location = new System.Drawing.Point(62, 73);
            this.Customer_Name_Label.Name = "Customer_Name_Label";
            this.Customer_Name_Label.Size = new System.Drawing.Size(47, 18);
            this.Customer_Name_Label.TabIndex = 21;
            this.Customer_Name_Label.Text = "Name";
            this.Customer_Name_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Customer_ID_Label
            // 
            this.Customer_ID_Label.AutoSize = true;
            this.Customer_ID_Label.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customer_ID_Label.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Customer_ID_Label.Location = new System.Drawing.Point(85, 33);
            this.Customer_ID_Label.Name = "Customer_ID_Label";
            this.Customer_ID_Label.Size = new System.Drawing.Size(24, 18);
            this.Customer_ID_Label.TabIndex = 20;
            this.Customer_ID_Label.Text = "ID";
            this.Customer_ID_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Customer_Address2
            // 
            this.Customer_Address2.BackColor = System.Drawing.Color.White;
            this.Customer_Address2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customer_Address2.Location = new System.Drawing.Point(145, 150);
            this.Customer_Address2.Name = "Customer_Address2";
            this.Customer_Address2.Size = new System.Drawing.Size(251, 26);
            this.Customer_Address2.TabIndex = 19;
            this.Customer_Address2.TextChanged += new System.EventHandler(this.Customer_Address2_TextChanged);
            // 
            // Customer_Address1
            // 
            this.Customer_Address1.BackColor = System.Drawing.Color.White;
            this.Customer_Address1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customer_Address1.Location = new System.Drawing.Point(145, 110);
            this.Customer_Address1.Name = "Customer_Address1";
            this.Customer_Address1.Size = new System.Drawing.Size(251, 26);
            this.Customer_Address1.TabIndex = 18;
            this.Customer_Address1.TextChanged += new System.EventHandler(this.Customer_Address1_TextChanged);
            // 
            // Customer_Name
            // 
            this.Customer_Name.BackColor = System.Drawing.Color.White;
            this.Customer_Name.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customer_Name.Location = new System.Drawing.Point(145, 70);
            this.Customer_Name.Name = "Customer_Name";
            this.Customer_Name.Size = new System.Drawing.Size(251, 26);
            this.Customer_Name.TabIndex = 17;
            this.Customer_Name.TextChanged += new System.EventHandler(this.Customer_Name_TextChanged);
            // 
            // Customer_ID
            // 
            this.Customer_ID.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customer_ID.Location = new System.Drawing.Point(145, 30);
            this.Customer_ID.Name = "Customer_ID";
            this.Customer_ID.ReadOnly = true;
            this.Customer_ID.Size = new System.Drawing.Size(251, 26);
            this.Customer_ID.TabIndex = 16;
            // 
            // Customer_Save_Button
            // 
            this.Customer_Save_Button.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customer_Save_Button.Location = new System.Drawing.Point(320, 308);
            this.Customer_Save_Button.Name = "Customer_Save_Button";
            this.Customer_Save_Button.Size = new System.Drawing.Size(75, 41);
            this.Customer_Save_Button.TabIndex = 23;
            this.Customer_Save_Button.Text = "Save";
            this.Customer_Save_Button.UseVisualStyleBackColor = true;
            this.Customer_Save_Button.Click += new System.EventHandler(this.Customer_Save_Button_Click);
            // 
            // Customer_Cancel_Button
            // 
            this.Customer_Cancel_Button.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customer_Cancel_Button.Location = new System.Drawing.Point(220, 308);
            this.Customer_Cancel_Button.Name = "Customer_Cancel_Button";
            this.Customer_Cancel_Button.Size = new System.Drawing.Size(75, 41);
            this.Customer_Cancel_Button.TabIndex = 24;
            this.Customer_Cancel_Button.Text = "Cancel";
            this.Customer_Cancel_Button.UseVisualStyleBackColor = true;
            this.Customer_Cancel_Button.Click += new System.EventHandler(this.Customer_Cancel_Button_Click);
            // 
            // Customer_Country_Label
            // 
            this.Customer_Country_Label.AutoSize = true;
            this.Customer_Country_Label.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customer_Country_Label.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Customer_Country_Label.Location = new System.Drawing.Point(50, 233);
            this.Customer_Country_Label.Name = "Customer_Country_Label";
            this.Customer_Country_Label.Size = new System.Drawing.Size(59, 18);
            this.Customer_Country_Label.TabIndex = 29;
            this.Customer_Country_Label.Text = "Country";
            this.Customer_Country_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Customer_City_Label
            // 
            this.Customer_City_Label.AutoSize = true;
            this.Customer_City_Label.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customer_City_Label.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Customer_City_Label.Location = new System.Drawing.Point(77, 193);
            this.Customer_City_Label.Name = "Customer_City_Label";
            this.Customer_City_Label.Size = new System.Drawing.Size(32, 18);
            this.Customer_City_Label.TabIndex = 28;
            this.Customer_City_Label.Text = "City";
            this.Customer_City_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Customer_Country
            // 
            this.Customer_Country.BackColor = System.Drawing.Color.White;
            this.Customer_Country.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customer_Country.Location = new System.Drawing.Point(145, 230);
            this.Customer_Country.Name = "Customer_Country";
            this.Customer_Country.Size = new System.Drawing.Size(251, 26);
            this.Customer_Country.TabIndex = 21;
            this.Customer_Country.TextChanged += new System.EventHandler(this.Customer_Country_TextChanged);
            // 
            // Customer_City
            // 
            this.Customer_City.BackColor = System.Drawing.Color.White;
            this.Customer_City.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customer_City.Location = new System.Drawing.Point(145, 190);
            this.Customer_City.Name = "Customer_City";
            this.Customer_City.Size = new System.Drawing.Size(251, 26);
            this.Customer_City.TabIndex = 20;
            this.Customer_City.TextChanged += new System.EventHandler(this.Customer_City_TextChanged);
            // 
            // Customer_Phone
            // 
            this.Customer_Phone.BackColor = System.Drawing.Color.White;
            this.Customer_Phone.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customer_Phone.Location = new System.Drawing.Point(145, 270);
            this.Customer_Phone.Name = "Customer_Phone";
            this.Customer_Phone.Size = new System.Drawing.Size(251, 26);
            this.Customer_Phone.TabIndex = 22;
            this.Customer_Phone.TextChanged += new System.EventHandler(this.Customer_Phone_TextChanged);
            // 
            // Customer_Phone_Label
            // 
            this.Customer_Phone_Label.AutoSize = true;
            this.Customer_Phone_Label.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customer_Phone_Label.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Customer_Phone_Label.Location = new System.Drawing.Point(61, 273);
            this.Customer_Phone_Label.Name = "Customer_Phone_Label";
            this.Customer_Phone_Label.Size = new System.Drawing.Size(48, 18);
            this.Customer_Phone_Label.TabIndex = 31;
            this.Customer_Phone_Label.Text = "Phone";
            this.Customer_Phone_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // NewCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 363);
            this.ControlBox = false;
            this.Controls.Add(this.Customer_Phone_Label);
            this.Controls.Add(this.Customer_Phone);
            this.Controls.Add(this.Customer_Country_Label);
            this.Controls.Add(this.Customer_City_Label);
            this.Controls.Add(this.Customer_Country);
            this.Controls.Add(this.Customer_City);
            this.Controls.Add(this.Customer_Save_Button);
            this.Controls.Add(this.Customer_Cancel_Button);
            this.Controls.Add(this.Customer_Address2_Label);
            this.Controls.Add(this.Customer_Address1_Label);
            this.Controls.Add(this.Customer_Name_Label);
            this.Controls.Add(this.Customer_ID_Label);
            this.Controls.Add(this.Customer_Address2);
            this.Controls.Add(this.Customer_Address1);
            this.Controls.Add(this.Customer_Name);
            this.Controls.Add(this.Customer_ID);
            this.Name = "NewCustomerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Customer Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Customer_Address2_Label;
        private System.Windows.Forms.Label Customer_Address1_Label;
        private System.Windows.Forms.Label Customer_Name_Label;
        private System.Windows.Forms.Label Customer_ID_Label;
        private System.Windows.Forms.TextBox Customer_Address2;
        private System.Windows.Forms.TextBox Customer_Address1;
        private System.Windows.Forms.TextBox Customer_Name;
        private System.Windows.Forms.TextBox Customer_ID;
        private System.Windows.Forms.Button Customer_Save_Button;
        private System.Windows.Forms.Button Customer_Cancel_Button;
        private System.Windows.Forms.Label Customer_Country_Label;
        private System.Windows.Forms.Label Customer_City_Label;
        private System.Windows.Forms.TextBox Customer_Country;
        private System.Windows.Forms.TextBox Customer_City;
        private System.Windows.Forms.TextBox Customer_Phone;
        private System.Windows.Forms.Label Customer_Phone_Label;
    }
}