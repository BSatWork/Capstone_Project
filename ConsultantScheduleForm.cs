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
    public partial class ConsultantScheduleForm : Form
    {
        public ReportForm appReportScreen;
        private readonly string query;
        private readonly int customers;

        public ConsultantScheduleForm(ReportForm ReportScreen, string Consultant)
        {
            InitializeComponent();
            Show();
            Activate();
            appReportScreen = ReportScreen;
            ConsultantScheduleForm.ActiveForm.Text = "Schedule for " + Consultant;

            DataTable dataTable = new DataTable();

            try
            {
                query = "Select " +
                        "client_schedule.customer.customerId," +
                        "client_schedule.customer.customerName," +
                        "client_schedule.appointment.type," +
                        "client_schedule.appointment.start," +
                        "client_schedule.appointment.end" +
                        "from client_schedule.appointment" +
                        "Left Join client_schedule.customer on appointment.customerId = customer.customerId" +
                        "Where appointment.userId = '" + Consultant.ToString() + "'";

                MySqlCommand cmd = new MySqlCommand(query, DBConnection.ConnectToDB);

                using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                {
                    da.Fill(dataTable);
                }

                ConsultantScheduleDGV.DataSource = dataTable;
                ConsultantScheduleDGV.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("An error occurred {0}", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConsultantScheduleCloseButton_Click(object sender, EventArgs e)
        {
            Close();
            appReportScreen.Show();
        }
    }
}
