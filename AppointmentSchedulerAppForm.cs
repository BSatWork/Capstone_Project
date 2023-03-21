using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BOP3_Task_1_DB_and_File_Server_App
{
    public partial class MainScreen : Form
    {
        public AppLoginForm appLogin;

        public MainScreen()//AppLoginForm appLoginForm)
        {
            InitializeComponent();
            Show();
            Activate();
            //appLogin = appLoginForm;
            AddUpdateDeleteApptToolTip.SetToolTip(AddUpdateDeleteApptButton, "To Update or Delete, Select an Appointment First");
            CustomerDBToolTip.SetToolTip(CustomerDBButton, "View or Update the Customer Database");
            TotalApptCnt.Text = "0";

        }

        private void AddUpdateDeleteApptButton_Click(object sender, EventArgs e)
        {
            _ = new ApptAddOrUpdateForm();
            this.Hide();
        }

        private void CustomerDBButton_Click(object sender, EventArgs e)
        {
            
            
            
            //_ = new DatabaseForm();
            this.Hide();
        }
    }
}
