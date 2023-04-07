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

        public CustomerDatabaseForm(MainScreen mainScreen)
        {
            InitializeComponent();
            Show();
            Activate();
            appMainScreen = mainScreen;



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
