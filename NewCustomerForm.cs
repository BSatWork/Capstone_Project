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
        private string query;

        public NewCustomerForm(CustomerDatabaseForm customerDBForm)
        {
            InitializeComponent();
            Show();
            Activate();
            this.customerDBForm = customerDBForm;

            int maxID = Int32.Parse(DBConnection.GetSQLTableValue("Select max(customerId) as 'Max ID' from client_schedule.customer")) + 1;
            Customer_ID.Text = maxID.ToString();
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
                    addressId = Int32.Parse(DBConnection.GetSQLTableValue("Select Max(address.addressId) From client_schedule.address")) + 1,
                };

                Address address = new Address
                {
                    addressId = customer.addressId,
                    addressLine1 = Customer_Address1.Text,
                    addressLine2 = Customer_Address2.Text,
                    cityId = Int32.Parse(DBConnection.GetSQLTableValue("Select Max(city.cityId) From client_schedule.city")) + 1,
                    phone = Customer_Phone.Text
                };

                City city = new City
                {
                    cityId = address.cityId,
                    city = Customer_City.Text,
                    countryId = Int32.Parse(DBConnection.GetSQLTableValue("Select Max(country.countryId) From client_schedule.country")) + 1
                };

                Country country = new Country
                {
                    countryId = city.countryId,
                    country = Customer_Country.Text
                };

                string maxCustomerIDCheck = DBConnection.GetSQLTableValue("Select customer.customerId From client_schedule.customer " +
                                                                  $"Where customer.customerId = {customer.customerId} ");
                if (string.IsNullOrEmpty(maxCustomerIDCheck))
                {
                    //Save to the country table
                    query = "Insert Into client_schedule.country " +
                            "Values(" +
                            "'" + country.countryId + "', " +
                            "'" + country.country + "', " +
                            "'" + country.createDate.ToString("yyyy-MM-dd HH:mm:ss") + "', " +
                            "'" + country.createdBy + "', " +
                            "'" + country.lastUpdate.ToString("yyyy-MM-dd HH:mm:ss") + "', " +
                            "'" + country.lastUpdateBy + "') ";
                    DBConnection.SaveToSQLTable(query);

                    //Save to the city table
                    query = "Insert Into client_schedule.city " +
                            "Values(" +
                            "'" + city.cityId + "', " +
                            "'" + city.city + "', " +
                            "'" + city.countryId + "', " +
                            "'" + city.createDate.ToString("yyyy-MM-dd HH:mm:ss") + "', " +
                            "'" + city.createdBy + "', " +
                            "'" + city.lastUpdate.ToString("yyyy-MM-dd HH:mm:ss") + "', " +
                            "'" + city.lastUpdateBy + "') ";
                    DBConnection.SaveToSQLTable(query);

                    //Save to the address table
                    query = "Insert Into client_schedule.address " +
                            "Values(" +
                            "'" + address.addressId + "', " +
                            "'" + address.addressLine1 + "', " +
                            "'" + address.addressLine2 + "', " +
                            "'" + address.cityId + "', " +
                            "'" + address.postalCode + "', " +
                            "'" + address.phone + "', " +
                            "'" + address.createDate.ToString("yyyy-MM-dd HH:mm:ss") + "', " +
                            "'" + address.createdBy + "', " +
                            "'" + address.lastUpdate.ToString("yyyy-MM-dd HH:mm:ss") + "', " +
                            "'" + address.lastUpdateBy + "') ";
                    DBConnection.SaveToSQLTable(query);

                    //Save to the customer table
                    query = "Insert Into client_schedule.customer " +
                            "Values(" +
                            "'" + customer.customerId + "', " +
                            "'" + customer.customerName + "', " +
                            "'" + customer.addressId + "', " +
                            "'" + customer.active + "', " +
                            "'" + customer.createDate.ToString("yyyy-MM-dd HH:mm:ss") + "', " +
                            "'" + customer.createdBy + "', " +
                            "'" + customer.lastUpdate.ToString("yyyy-MM-dd HH:mm:ss") + "', " +
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
                MessageBox.Show("Please verify all required fields are populated.\n\n" +
                                "(Fields will turn green when populated and are an acceptable length.)", "Input Validation");
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
            // Validate the first Address field is populated and is the max length or less.
            if (!string.IsNullOrEmpty(Customer_Address1.Text) && Customer_Address1.TextLength <= 50)
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
            // Validate if the second Address field is populated and is the max length or less.
            if (string.IsNullOrEmpty(Customer_Address2.Text))
            {
                //Empty is acceptable, move on.
            }
            else if (!string.IsNullOrEmpty(Customer_Address2.Text) && Customer_Address2.TextLength <= 50)
            {
                Customer_Address1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            }
            else
            {
                Customer_Address1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            }
        }

        private void Customer_City_TextChanged(object sender, EventArgs e)
        {
            // Validate the City field is populated and is the max length or less.
            if (!string.IsNullOrEmpty(Customer_City.Text) && Customer_City.TextLength <= 50)
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
            // Validate the Country field is populated and is the max length or less.
            if (!string.IsNullOrEmpty(Customer_Country.Text) && Customer_Country.TextLength <= 50)
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
            // Validate the Phone field is populated and is the max length or less.
            if (!string.IsNullOrEmpty(Customer_Phone.Text) && Customer_Phone.TextLength <= 20)
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
