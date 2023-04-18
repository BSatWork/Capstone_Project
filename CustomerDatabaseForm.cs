using BOP3_Task_1_DB_and_File_Server_App.Database;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BOP3_Task_1_DB_and_File_Server_App
{
    public partial class CustomerDatabaseForm : Form
    {
        public MainScreen appMainScreen;
        private string query;

        public CustomerDatabaseForm(MainScreen mainScreen)
        {
            InitializeComponent();
            Show();
            Activate();
            appMainScreen = mainScreen;

            DataTable dataTable = new DataTable();

            try
            {
                string query = "Select
client_schedule.customer.customerId as Customer,
client_schedule.customer.customerName as Name,
client_schedule.address.address as Address,
client_schedule.address.address2 as Address,
client_schedule.city.city as City,
client_schedule.country.country as Country,
client_schedule.address.phone
From client_schedule.customer
Left Join client_schedule.address on customer.addressId = address.addressId
Left Join client_schedule.city on address.cityId = city.cityId
Left Join client_schedule.country on city.countryId = country.countryId ";

                MySqlCommand cmd = new MySqlCommand(query, DBConnection.ConnectToDB);

                using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                {
                    da.Fill(dataTable);
                }

                CustomerDBDGV.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("An error occurred {0}", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void CustomerDBCloseButton_Click(object sender, EventArgs e)
        {
            /*DialogResult delete = MessageBox.Show("Closing this window will go back to the Main Screen with no updates."
                    + "  Is this intended?", "Close Confirmation", MessageBoxButtons.YesNo);

            switch (delete)
            {
                case DialogResult.Yes:*/
                    Close();
                    appMainScreen.Show();
                    /*break;
                case DialogResult.No:
                    break;
            }*/
        }

        private void NewCustomerButton_Click(object sender, EventArgs e)
        {
            _ = new NewCustomerForm(this);
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

                    DialogResult delete = MessageBox.Show("This will delete Customer ID... " //Todo + customer.customerID + " which cannot be undone."
                        + "  Are you sure?", "Delete Confirmation", MessageBoxButtons.YesNo);

                    switch (delete)
                    {
                        case DialogResult.Yes:
                            //CustomerDBDGV.RemoveAt(index);    //Todo Delete the customer row.
                            break;
                        case DialogResult.No:
                            break;
                    }
                }
            } 
        }
    }
}
