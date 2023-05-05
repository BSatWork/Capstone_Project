using BOP3_Task_1_DB_and_File_Server_App.Database;
using System;
using System.Data;
using System.Windows.Forms;

namespace BOP3_Task_1_DB_and_File_Server_App
{
    public partial class CustomerDatabaseForm : Form
    {
        public MainScreen appMainScreen;
        public string customerDataQuery;
        public string query;
        public int customerId;

        public CustomerDatabaseForm(MainScreen mainScreen)
        {
            InitializeComponent();
            Show();
            Activate();
            appMainScreen = mainScreen;

            customerDataQuery = "Select " +
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
                                "Left Join client_schedule.country on city.countryId = country.countryId " +
                                "Order by Name Asc ";
            GetCustomerData(customerDataQuery);
        }

        private void CustomerDBCloseButton_Click(object sender, EventArgs e)
        {
            Close();
            appMainScreen.Show();
            // Refresh the Appointments table with all appointments.
            query = "Select appointment.appointmentId, appointment.userId, customer.customerName, appointment.type, appointment.start, appointment.end " +
                    "from client_schedule.appointment " +
                    "Left Join client_schedule.customer on appointment.customerId = customer.customerId " +
                    $"Where appointment.start > '{DateTime.UtcNow:yyyy-MM-dd hh:mm:00}' " +
                    "Order by start asc ";
            appMainScreen.GetAppointmentData(query);
        }

        private void NewCustomerButton_Click(object sender, EventArgs e)
        {
            customerId = 0;
            _ = new NewCustomerForm(this, customerId);
            this.Hide();
        }

        private void UpdateCustomerButton_Click(object sender, EventArgs e)
        {
            if (CustomerDBDGV.Rows.Count == 0)
            {
                MessageBox.Show("There are no customers to Update.", "Update Customer Validation", MessageBoxButtons.OK);
            }
            else
            {
                if (!CustomerDBDGV.CurrentRow.Selected)
                {
                    MessageBox.Show("Please select a customer to Update.", "Update Customer Validation", MessageBoxButtons.OK);
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
            customerId = (int)CustomerDBDGV.CurrentRow.Cells[0].Value;
            int customerApptCount = int.Parse(DBConnection.GetSQLTableValue("Select Count(customerId) From client_schedule.appointment " +
                                    $"Where customerId = {customerId} " +
                                    $"And appointment.start > '{DateTime.UtcNow:yyyy-MM-dd hh:mm:00}' "));

            if (customerApptCount > 0)
            {
                MessageBox.Show("This customer has an active appt and cannot be deleted from the database.", "Customer Appt Check", MessageBoxButtons.OK);
            }
            else
            {
                if (CustomerDBDGV.Rows.Count == 0)
                {
                    MessageBox.Show("There are no customers to delete.", "Delete Customer Validation", MessageBoxButtons.OK);
                }
                else
                {
                    if (!CustomerDBDGV.CurrentRow.Selected)
                    {
                        MessageBox.Show("Please select a customer to delete.", "Delete Customer Validation", MessageBoxButtons.OK);
                    }
                    else
                    {
                        DialogResult delete = MessageBox.Show("This will delete the selected customer, which cannot be undone.\n\n" +
                                                              "Are you sure?", "Delete Confirmation", MessageBoxButtons.YesNo);

                        switch (delete)
                        {
                            case DialogResult.Yes:
                                int addressId = int.Parse(DBConnection.GetSQLTableValue("Select address.addressId From client_schedule.address " +
                                    $"Left Join client_schedule.customer on customer.addressId = address.addressId " +
                                    $"Where customer.customerId = {customerId} "));
                                int cityId = int.Parse(DBConnection.GetSQLTableValue("Select city.cityId From client_schedule.city " +
                                    $"Left Join client_schedule.address on address.cityId = city.cityId " +
                                    $"Where address.addressId = {addressId} "));
                                int countryId = int.Parse(DBConnection.GetSQLTableValue("Select country.countryId From client_schedule.country " +
                                    $"Left Join client_schedule.city on city.countryId = country.countryId " +
                                    $"Where city.cityId = {cityId} "));

                                //Todo Delete the customer row.
                                query = $"Delete from client_schedule.customer Where customerId = {customerId}; " +
                                        $"Delete from client_schedule.address Where addressId = {addressId}; " +
                                        $"Delete from client_schedule.city Where cityId = {cityId}; " +
                                        $"Delete from client_schedule.country Where countryId = {countryId}; ";
                                DBConnection.DeleteSQLTableRow(query);
                                GetCustomerData(customerDataQuery);
                                break;
                            case DialogResult.No:
                                break;
                        }
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