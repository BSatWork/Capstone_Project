using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
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
            try
            {
                string constr = "Server=127.0.0.1;Uid=sqlUser;Pwd=Passw0rd!;Database=client_schedule;"; // Get the connection string.
                ConnectToDB = new MySqlConnection(constr);
                ConnectToDB.Open(); // Open the connection.
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

        public static DataTable GetSQLTable(string query)
        {
            DataTable datatable = new DataTable();

            try
            {
                MySqlCommand cmd = new MySqlCommand(query, DBConnection.ConnectToDB);

                using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                {
                    da.Fill(datatable);
                }
                return datatable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("An error occurred {0}", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public string GetSQLTableValue(string table, string column, string datafilter)
        {
            string query = "Select " + column + " from client_schedule." + table + " where " + column + " = '" + datafilter + "'";

            try
            {
                var cmd = new MySqlCommand(query, DBConnection.ConnectToDB);
                string value = cmd.ExecuteScalar().ToString();
                return value;
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("An error occurred {0}", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        /*public DataTable SelectRows(DataTable dataTable, string query)
        {
            dataTable = new DataTable();
            
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, ConnectToDB);

                using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                {
                    da.Fill(outDataTable);
                }

                //AppointmentsDGV.DataSource = dataTable;
                //AppointmentsDGV.DataMember = dataTable.TableName;
                return outDataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("An error occurred {0}", ex.Message), "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }*/


        /*public SelectRows(DataTable datatable, string connection, string query)
        {
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter
            {
                SelectCommand = new MySqlCommand(query, conn)
            };
            adapter.Fill(datatable);
            return datatable;
        }*/
    }
}