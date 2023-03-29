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
        public static MySqlConnection connectToDB { get; set; }

        public static void startConnection()
        {
            
            // Make the connection.
            //MySqlConnection connectToDB = null;

            try
            {
                // Get the connection string.
                string constr = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
                connectToDB = new MySqlConnection(constr);

                // Open the connection.
                connectToDB.Open();

                MessageBox.Show("Connection is open");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void closeConnection()
        {
            try
            {
                // Close the connection
                if (connectToDB != null)
                {
                    connectToDB.Close();
                }
                connectToDB = null;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}