using RYM2_Capstone_Scheduling_App.Database;
using System;
using System.Data;
using System.Windows.Forms;

namespace RYM2_Capstone_Scheduling_App
{
    public partial class EmployeeScheduleForm : Form
    {
        public ReportForm appReportScreen;
        private readonly string query;
        private readonly string EmployeeUserName;
        private readonly int employeeUserId;

        public EmployeeScheduleForm(ReportForm ReportScreen, string Employee)
        {
            InitializeComponent();
            Show();
            appReportScreen = ReportScreen;
            EmployeeUserName = Employee;
            EmployeeScheduleForm.ActiveForm.Text = "Schedule for Employee with UserName " + EmployeeUserName;

            employeeUserId = int.Parse(DBConnection.GetSQLTableValue($"Select user.userId From client_schedule.user Where employeeName = '{EmployeeUserName}'"));

            query = "Select " +
                    "client_schedule.customer.customerId, " +
                    "client_schedule.customer.customerName, " +
                    "client_schedule.appointment.type, " +
                    "client_schedule.appointment.start, " +
                    "client_schedule.appointment.end " +
                    "from client_schedule.appointment " +
                    "Left Join client_schedule.customer on appointment.customerId = customer.customerId " +
                    $"Where appointment.userId = {employeeUserId} " +
                    $"And appointment.start > '{DateTime.UtcNow:yyyy-MM-dd hh:mm:00}' ";

            DataTable consultantSchedule = DBConnection.GetSQLTable(query);
            for (int index = 0; index < consultantSchedule.Rows.Count; index++)
            {
                consultantSchedule.Rows[index]["start"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)consultantSchedule.Rows[index]["start"], TimeZoneInfo.Local).ToString();
                consultantSchedule.Rows[index]["end"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)consultantSchedule.Rows[index]["end"], TimeZoneInfo.Local).ToString();
            }

            EmployeeScheduleDGV.DataSource = consultantSchedule;
            EmployeeScheduleDGV.ClearSelection();
        }

        private void ConsultantScheduleCloseButton_Click(object sender, EventArgs e)
        {
            Close();
            appReportScreen.Show();
        }
    }
}