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

        public ConsultantScheduleForm(ReportForm ReportScreen, string Consultant)
        {
            InitializeComponent();
            Show();
            Activate();
            appReportScreen = ReportScreen;

            //Todo Populate the ConsultantScheduleDGV for the provided Consultant.
        }

        private void ConsultantScheduleCloseButton_Click(object sender, EventArgs e)
        {
            Close();
            appReportScreen.Show();
        }
    }
}
