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
        private int maxID;
        private string query;

        public NewCustomerForm(CustomerDatabaseForm customerDBForm)
        {
            InitializeComponent();
            Show();
            Activate();
            this.customerDBForm = customerDBForm;

            //Customer_ID.Text = GetMaxCustomerID().ToString();
            maxID = Int32.Parse(DBConnection.GetSQLTableValue("Select max(customerId) as 'Max ID' from client_schedule.customer")) + 1;
            Customer_ID.Text = maxID.ToString();

            //Todo Handle Updates



        }

        public int GetMaxCustomerID()
        {
            string query = "Select max(customerId) as 'Max ID' from client_schedule.customer";
            var cmd = new MySqlCommand(query, DBConnection.ConnectToDB);
            maxID = (int)cmd.ExecuteScalar();
            return maxID++;
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
                Customer customer = new Customer
                {
                    customerId = Int32.Parse(Customer_ID.Text),
                    customerName = Customer_Name.Text,
                    addressID = Int32.Parse(DBConnection.GetSQLTableValue("Select Max(customer.addressId) from client_schedule.customer")) + 1,
                };

                string maxIDCheck = DBConnection.GetSQLTableValue("Select customer.customerId From client_schedule.customer " +
                                                                  $"Where customer.customerId = {customer.customerId} ");
                if (string.IsNullOrEmpty(maxIDCheck))
                {
                    //Save the Customer ID in the customer table
                    query = "Insert Into client_schedule.customer " +
                            "Values(" +
                            "'" + customer.customerId + "'" +
                            "'" + customer.customerName + "'" +
                            "'" + customer.addressID + "'" +
                            "'" + customer.active + "'" +
                            "'" + customer.createDate + "'" +
                            "'" + customer.createdBy + "'" +
                            "'" + customer.lastUpdate + "'" +
                            "'" + customer.lastUpdateBy + "') ";
                    DBConnection.SaveToSQLTable(query);
                }
                else
                {
                    MessageBox.Show("This customer already exists in the database.");
                }





                

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
