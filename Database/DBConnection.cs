using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BOP3_Task_1_DB_and_File_Server_App.Database
{
    public class DBConnection
    {
        public static MySqlConnection ConnectToDB { get; set; }

        public static void StartConnection()
        {

            // Make the connection.
            //MySqlConnection ConnectToDB = null;

            try
            {
                // Get the connection string.
                string constr = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
                ConnectToDB = new MySqlConnection(constr);

                // Open the connection.
                ConnectToDB.Open();

                //MessageBox.Show("Connection is open");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void CloseConnection()
        {
            try
            {
                // Close the connection
                if (ConnectToDB != null)
                {
                    ConnectToDB.Close();
                }
                ConnectToDB = null;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}