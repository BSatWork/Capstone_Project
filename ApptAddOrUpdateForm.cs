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
    public partial class ApptAddOrUpdateForm : Form
    {
        public ApptAddOrUpdateForm()
        {
            InitializeComponent();
            Show();
            Activate();

            


        }

        public void CreateMyDateTimePicker()
        {
            // Create a new DateTimePicker control and initialize it.
            DateTimePicker dateTimePicker1 = new DateTimePicker();

            // Set the MinDate and MaxDate.
            dateTimePicker1.MinDate = DateTime.Today;
            dateTimePicker1.MaxDate = new DateTime(9999, 12, 31);

            // Set the CustomFormat string.
            dateTimePicker1.CustomFormat = "MMMM dd, yyyy - dddd";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;

            // Show the CheckBox and display the control as an up-down control.
            dateTimePicker1.ShowCheckBox = true;
            dateTimePicker1.ShowUpDown = true;
        }

        private void ApptDelete_Click(object sender, EventArgs e)
        {

        }

        private void ApptSave_Click(object sender, EventArgs e)
        {

        }
    }
}
