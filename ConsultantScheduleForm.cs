using BOP3_Task_1_DB_and_File_Server_App.Database;
using System;
using System.Data;
using System.Windows.Forms;

namespace BOP3_Task_1_DB_and_File_Server_App
{
    public partial class ConsultantScheduleForm : Form
    {
        public ReportForm appReportScreen;
        private readonly string query;

        public ConsultantScheduleForm(ReportForm ReportScreen, string Consultant)
        {
            InitializeComponent();
            Show();
            appReportScreen = ReportScreen;
            ConsultantScheduleForm.ActiveForm.Text = "Schedule for Consultant " + Consultant;

            query = "Select " +
                    "client_schedule.customer.customerId, " +
                    "client_schedule.customer.customerName, " +
                    "client_schedule.appointment.type, " +
                    "client_schedule.appointment.start, " +
                    "client_schedule.appointment.end " +
                    "from client_schedule.appointment " +
                    "Left Join client_schedule.customer on appointment.customerId = customer.customerId " +
                    "Where appointment.userId = '" + Consultant.ToString() + "'";

            DataTable consultantSchedule = DBConnection.GetSQLTable(query);

            ConsultantScheduleDGV.DataSource = consultantSchedule;
            ConsultantScheduleDGV.ClearSelection();
        }

        private void ConsultantScheduleCloseButton_Click(object sender, EventArgs e)
        {
            Close();
            appReportScreen.Show();
        }
    }
}
