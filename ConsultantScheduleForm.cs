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
        private readonly int consultantId;

        public ConsultantScheduleForm(ReportForm ReportScreen, string Consultant)
        {
            InitializeComponent();
            Show();
            appReportScreen = ReportScreen;
            consultantId = int.Parse(Consultant);
            ConsultantScheduleForm.ActiveForm.Text = "Schedule for Consultant " + consultantId;

            query = "Select " +
                    "client_schedule.customer.customerId, " +
                    "client_schedule.customer.customerName, " +
                    "client_schedule.appointment.type, " +
                    "client_schedule.appointment.start, " +
                    "client_schedule.appointment.end " +
                    "from client_schedule.appointment " +
                    "Left Join client_schedule.customer on appointment.customerId = customer.customerId " +
                    $"Where appointment.userId = {consultantId} " +
                    $"And appointment.start > '{DateTime.UtcNow:yyyy-MM-dd hh:mm:00}' ";

            DataTable consultantSchedule = DBConnection.GetSQLTable(query);
            for (int index = 0; index < consultantSchedule.Rows.Count; index++)
            {
                consultantSchedule.Rows[index]["start"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)consultantSchedule.Rows[index]["start"], TimeZoneInfo.Local).ToString();
                consultantSchedule.Rows[index]["end"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)consultantSchedule.Rows[index]["end"], TimeZoneInfo.Local).ToString();
            }

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