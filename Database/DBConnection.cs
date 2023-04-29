//All SQL connections and database activity will happen through use of this class.
using MySql.Data.MySqlClient;
using System;
using System.Data;
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
                string constr = "Server=127.0.0.1;Uid=sqlUser;Pwd=Passw0rd!;Database=client_schedule;";
                ConnectToDB = new MySqlConnection(constr);
                ConnectToDB.Open();
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

        public static string GetSQLTableValue(string query)
        {
           try
            {
                var cmd = new MySqlCommand(query, DBConnection.ConnectToDB);

                try
                {
                    string value = (string)cmd.ExecuteScalar();
                    return value;
                }
                catch
                {
                    string value = cmd.ExecuteScalar().ToString();
                    return value;
                }
                            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("An error occurred {0}", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public static void SaveToSQLTable(string query)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, DBConnection.ConnectToDB);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("An error occurred {0}", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void DeleteSQLTableRow(string query)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, DBConnection.ConnectToDB);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("An error occurred {0}", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}