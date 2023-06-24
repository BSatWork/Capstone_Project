using RYM2_Capstone_Scheduling_App.Database;
using System;
using System.Data;
using System.Windows.Forms;

namespace RYM2_Capstone_Scheduling_App
{
    public partial class NewCustomerForm : Form
    {
        public CustomerDatabaseForm customerDBForm;
        public string query;
        public int existingCustomerId;
        public string existingName;
        public string existingAddress;
        public string existingAddress2;
        public string existingCity;
        public string existingCountry;
        public string existingPhone;
        public bool newCustomer;
        public int maxID;

        public NewCustomerForm(CustomerDatabaseForm customerDBForm, int customerId)
        {
            InitializeComponent();
            Show();
            Activate();
            this.customerDBForm = customerDBForm;

            if (customerId == 0)
            {
                newCustomer = true;
                try
                {
                    maxID = int.Parse(DBConnection.GetSQLTableValue("Select max(customerId) as 'Max ID' from client_schedule.customer")) + 1;
                }
                catch
                {
                    maxID = 1;
                }
                Customer_ID.Text = maxID.ToString();
            }
            else
            {
                query = "Select " +
                        "customer.customerName, " +
                        "address.address, address.address2, " +
                        "city.city, country.country, " +
                        "address.phone " +
                        "From client_schedule.customer " +
                        "Left Join client_schedule.address on customer.addressId = address.addressId " +
                        "Left Join client_schedule.city on address.cityId = city.cityId " +
                        "Left Join client_schedule.country on city.countryId = country.countryId " +
                        $"Where customer.customerId = {customerId} " ;
                DataTable customerData = DBConnection.GetSQLTable(query);

                existingCustomerId = customerId;
                existingName = customerData.Rows[0]["customerName"].ToString();
                existingAddress = customerData.Rows[0]["address"].ToString();
                existingAddress2 = customerData.Rows[0]["address2"].ToString();
                existingCity = customerData.Rows[0]["city"].ToString();
                existingCountry = customerData.Rows[0]["country"].ToString();
                existingPhone = customerData.Rows[0]["phone"].ToString();

                Customer_ID.Text = existingCustomerId.ToString();
                Customer_Name.Text = existingName;
                Customer_Address1.Text = existingAddress;
                Customer_Address2.Text = existingAddress2;
                Customer_City.Text = existingCity;
                Customer_Country.Text = existingCountry;
                Customer_Phone.Text = existingPhone;
            }
            
            Customer_Name.Focus();
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
                if (newCustomer)
                {
                    Customer customer = new Customer
                    {
                        customerId = int.Parse(Customer_ID.Text),
                        customerName = Customer_Name.Text,
                        addressId = int.Parse(DBConnection.GetSQLTableValue("Select Max(address.addressId) From client_schedule.address")) + 1,
                    };

                    Address address = new Address
                    {
                        addressId = customer.addressId,
                        addressLine1 = Customer_Address1.Text,
                        addressLine2 = Customer_Address2.Text,
                        cityId = int.Parse(DBConnection.GetSQLTableValue("Select Max(city.cityId) From client_schedule.city")) + 1,
                        phone = Customer_Phone.Text
                    };

                    City city = new City
                    {
                        cityId = address.cityId,
                        city = Customer_City.Text,
                        countryId = int.Parse(DBConnection.GetSQLTableValue("Select Max(country.countryId) From client_schedule.country")) + 1
                    };

                    Country country = new Country
                    {
                        countryId = city.countryId,
                        country = Customer_Country.Text
                    };

                    //Save to the country table
                    query = "Insert Into client_schedule.country " +
                            "Values(" +
                            $"{country.countryId}, " +
                            $"'{country.country}', " +
                            $"'{address.createDate:yyyy-MM-dd HH:mm:00}', " +
                            $"'{address.createdBy}', " +
                            $"'{address.lastUpdate:yyyy-MM-dd HH:mm:00}', " +
                            $"'{address.lastUpdateBy}') ";
                    DBConnection.SaveToSQLTable(query);

                    //Save to the city table
                    query = "Insert Into client_schedule.city " +
                            "Values(" +
                            $"{city.cityId}, " +
                            $"'{city.city}', " +
                            $"{city.countryId}, " +
                            $"'{address.createDate:yyyy-MM-dd HH:mm:00}', " +
                            $"'{address.createdBy}', " +
                            $"'{address.lastUpdate:yyyy-MM-dd HH:mm:00}', " +
                            $"'{address.lastUpdateBy}') ";
                    DBConnection.SaveToSQLTable(query);

                    //Save to the address table
                    query = "Insert Into client_schedule.address " +
                            "Values(" +
                            $"{address.addressId}, " +
                            $"'{address.addressLine1}', " +
                            $"'{address.addressLine2}', " +
                            $"{address.cityId}, " +
                            $"'{address.phone }', " +
                            $"'{address.createDate:yyyy-MM-dd HH:mm:00}', " +
                            $"'{address.createdBy}', " +
                            $"'{address.lastUpdate:yyyy-MM-dd HH:mm:00}', " +
                            $"'{address.lastUpdateBy}') ";
                    DBConnection.SaveToSQLTable(query);

                    //Save to the customer table
                    query = "Insert Into client_schedule.customer " +
                            "Values(" +
                            $"{customer.customerId}, " +
                            $"'{customer.customerName}', " +
                            $"{customer.addressId}, " +
                            $"'{customer.active}', " +
                            $"'{address.createDate:yyyy-MM-dd HH:mm:00}', " +
                            $"'{address.createdBy}', " +
                            $"'{address.lastUpdate:yyyy-MM-dd HH:mm:00}', " +
                            $"'{address.lastUpdateBy}') ";
                    DBConnection.SaveToSQLTable(query);
                }
                else //Update the Customer's data.
                {
                    Customer customer = new Customer
                    {
                        customerId = int.Parse(Customer_ID.Text),
                        customerName = Customer_Name.Text,
                    };
                    customer.addressId = int.Parse(DBConnection.GetSQLTableValue("Select customer.addressId From client_schedule.customer Where customer.customerId = " + customer.customerId));

                    Address address = new Address
                    {
                        addressId = customer.addressId,
                        addressLine1 = Customer_Address1.Text,
                        addressLine2 = Customer_Address2.Text,
                        phone = Customer_Phone.Text
                    };
                    address.cityId = int.Parse(DBConnection.GetSQLTableValue("Select address.cityId From client_schedule.address Where address.addressId = " + address.addressId));

                    City city = new City
                    {
                        cityId = address.cityId,
                        city = Customer_City.Text
                    };
                    city.countryId = int.Parse(DBConnection.GetSQLTableValue("Select city.countryId From client_schedule.city Where city.cityId = " + city.cityId));


                    Country country = new Country
                    {
                        countryId = city.countryId,
                        country = Customer_Country.Text
                    };

                    if (Customer_Country.Text != existingCountry)
                    {
                        //Update the country table
                        query = "Update client_schedule.country " +
                                $"Set country.country = '{country.country}' " +
                                $"Where country.countryId = {country.countryId} ";
                        DBConnection.SaveToSQLTable(query);
                    }


                    if (Customer_City.Text != existingCity)
                    {
                        //Update the city table
                        query = "Update client_schedule.city " +
                                $"Set city.city = '{city.city}' " +
                                $"Where city.cityId = {city.cityId} ";
                        DBConnection.SaveToSQLTable(query);
                    }

                    if (Customer_Address1.Text != existingAddress || Customer_Address2.Text != existingAddress2 || Customer_Phone.Text != existingPhone)
                    {
                        //Update the address table
                        query = "Update client_schedule.address " +
                                $"Set address.address = '{address.addressLine1}', " +
                                $"address.address2 = '{address.addressLine2}', " +
                                $"address.phone = '{address.phone}' " +
                                $"Where address.addressId = {address.addressId} ";
                        DBConnection.SaveToSQLTable(query);
                    }

                    if (Customer_Name.Text != existingName)
                    {
                        //Update the customer table
                        query = "Update client_schedule.customer " +
                                $"Set customer.customerName = '{customer.customerName}' " +
                                $"Where customer.customerId = {existingCustomerId} ";
                        DBConnection.SaveToSQLTable(query);
                    }
                }
                Close();
                customerDBForm.Show();
                customerDBForm.GetCustomerData(customerDBForm.customerDataQuery);
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
            customerDBForm.GetCustomerData(customerDBForm.customerDataQuery);
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