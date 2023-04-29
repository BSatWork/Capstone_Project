using BOP3_Task_1_DB_and_File_Server_App.Database;
using System;
using System.Data;
using System.Windows.Forms;

namespace BOP3_Task_1_DB_and_File_Server_App
{
    public partial class CustomerDatabaseForm : Form
    {
        public MainScreen appMainScreen;
        public string query;
        public int customerId = 0;

        public CustomerDatabaseForm(MainScreen mainScreen)
        {
            InitializeComponent();
            Show();
            Activate();
            appMainScreen = mainScreen;

            query = "Select " +
                    "client_schedule.customer.customerId, " +
                    "client_schedule.customer.customerName as Name, " +
                    "client_schedule.address.address as Address, " +
                    "client_schedule.address.address2 as Address, " +
                    "client_schedule.city.city as City, " +
                    "client_schedule.country.country as Country, " +
                    "client_schedule.address.phone " +
                    "From client_schedule.customer " +
                    "Left Join client_schedule.address on customer.addressId = address.addressId " +
                    "Left Join client_schedule.city on address.cityId = city.cityId " +
                    "Left Join client_schedule.country on city.countryId = country.countryId ";
            GetCustomerData(query);
        }

        private void CustomerDBCloseButton_Click(object sender, EventArgs e)
        {
            Close();
            appMainScreen.Show();
        }

        private void NewCustomerButton_Click(object sender, EventArgs e)
        {
            _ = new NewCustomerForm(this, customerId);
            this.Hide();
        }

        private void UpdateCustomerButton_Click(object sender, EventArgs e)
        {
            if (CustomerDBDGV.Rows.Count == 0)
            {
                MessageBox.Show("There are no customers to Update.", "Update Customer Validation");
            }
            else
            {
                if (!CustomerDBDGV.CurrentRow.Selected)
                {
                    MessageBox.Show("Please select a customer to Update.", "Update Customer Validation");
                }
                else
                {
                    customerId = (int)CustomerDBDGV.CurrentRow.Cells[0].Value;
                    _ = new NewCustomerForm(this, customerId);
                    this.Hide();
                }
            }
        }

        private void DeleteCustomerButton_Click(object sender, EventArgs e)
        {
            if (CustomerDBDGV.Rows.Count == 0)
            {
                MessageBox.Show("There are no customers to delete.", "Delete Customer Validation");
            }
            else
            {
                if (!CustomerDBDGV.CurrentRow.Selected)
                {
                    MessageBox.Show("Please select a customer to delete.", "Delete Customer Validation");
                }
                else
                {
                    //Customer customer = CustomerDBDGV.CurrentRow.DataBoundItem;   //Todo Define the Customer DB DGV

                    DialogResult delete = MessageBox.Show("This will delete the selected customer, which cannot be undone.\n\n" +
                                                          "Are you sure?", "Delete Confirmation", MessageBoxButtons.YesNo);

                    switch (delete)
                    {
                        case DialogResult.Yes:
                            //Todo Delete the customer row.
                            /*query = "Delete from client_schedule.customer Where customerId = '';" + customerId + "' " +
                                    "Delete from client_schedule.address Where addressId = '';" + addressId + "' " +
                                    "Delete from client_schedule.city Where cityId = '';" + cityId + "' " +
                                    "Delete from client_schedule.country Where countryId = '" + countryId + "' ";*/
                            DBConnection.DeleteSQLTableRow(query);
                            break;
                        case DialogResult.No:
                            break;
                    }
                }
            } 
        }

        public string GetCustomerData(string query)
        {
            DataTable dataTable = DBConnection.GetSQLTable(query);
            CustomerDBDGV.DataSource = dataTable;
            CustomerDBDGV.ClearSelection();

            string customerCount = DBConnection.GetSQLTableValue("Select Count(customerID) from client_schedule.customer ");
            CustomerCount.Text = customerCount;
            return query;
        }
    }
}
