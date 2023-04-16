using BOP3_Task_1_DB_and_File_Server_App.Database;
using MySql.Data;
using MySql.Data.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BOP3_Task_1_DB_and_File_Server_App
{
    public partial class NewCustomerForm : Form
    {
        public CustomerDatabaseForm customerDBForm;
        private readonly string sqlCmd;
        public int maxCustomerID;

        public NewCustomerForm(CustomerDatabaseForm customerDBForm)
        {
            InitializeComponent();
            Show();
            Activate();
            this.customerDBForm = customerDBForm;

            /*const string DB_CONN_STR = "Server=127.0.0.1;Uid=sqlUser;Pwd=Passw0rd!;Database=client_schedule;";
            MySqlConnection cn = new MySqlConnection(DB_CONN_STR);*/

            sqlCmd = "Select max(customerId) from customer";
            MySqlDataAdapter adapter = new MySqlDataAdapter(sqlCmd, Database.DBConnection.ConnectToDB);
            adapter.SelectCommand.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            maxCustomerID = adapter.Fill(dt);
            maxCustomerID = maxCustomerID++;
            Customer_ID.Text = maxCustomerID.ToString();

        }

        private void Customer_Save_Button_Click(object sender, EventArgs e)
        {
            // If all fields have been validated, then continue processing.  Otherwise, inform the user.
            if (Customer_Name.BackColor == System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192))))) &&
                Customer_Address1.BackColor == System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192))))) &&
                Customer_City.BackColor == System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192))))) &&
                Customer_Country.BackColor == System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192))))) &&
                Customer_Phone.BackColor == System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))))
                )
            {
                //Todo Save the Customer data to the DB

                Close();
                customerDBForm.Show();
            }
            else
            {
                MessageBox.Show("Please verify all required fields are populated." + Environment.NewLine +
                                "(Fields will turn green when populated.)", "Input Validation");
            }
        }

        private void Customer_Cancel_Button_Click(object sender, EventArgs e)
        {
            Close();
            customerDBForm.Show();
        }

        // Form field validation...
        // Fields will turn green, indicating the input is acceptable, or they will stay red.

        private void Customer_Name_TextChanged(object sender, EventArgs e)
        {
            // Validate the Name field is populated.
            if (!string.IsNullOrEmpty(Customer_Name.Text))// && Customer_Name.Text != "")
            {
                Customer_Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            }
            else
            {
                Customer_Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            }
        }

        private void Customer_Address1_TextChanged(object sender, EventArgs e)
        {
            // Validate the first Address field is populated.
            if (!string.IsNullOrEmpty(Customer_Address1.Text))
            {
                Customer_Address1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            }
            else
            {
                Customer_Address1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            }
        }

        private void Customer_Address2_TextChanged(object sender, EventArgs e)
        {
            //No validation required for the 2nd Address field.  It's optional
        }

        private void Customer_City_TextChanged(object sender, EventArgs e)
        {
            // Validate the City field is populated.
            if (!string.IsNullOrEmpty(Customer_City.Text))
            {
                Customer_City.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            }
            else
            {
                Customer_City.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            }
        }

        private void Customer_Country_TextChanged(object sender, EventArgs e)
        {
            // Validate the Country field is populated.
            if (!string.IsNullOrEmpty(Customer_Country.Text))
            {
                Customer_Country.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            }
            else
            {
                Customer_Country.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            }
        }

        private void Customer_Phone_TextChanged(object sender, EventArgs e)
        {
            // Validate the Phone field is populated.
            if (!string.IsNullOrEmpty(Customer_Phone.Text))
            {
                Customer_Phone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            }
            else
            {
                Customer_Phone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            }
        }
    }
}
