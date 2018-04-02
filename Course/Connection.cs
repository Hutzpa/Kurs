using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course
{
    public static class Connection
    {
        public static string connStr = "datasource=localhost;port=3306;username=root;password=";

        /// <summary>
        /// Метод подключения с выводом в DGV
        /// </summary>
        public static void Connector(DataGridView dataGridView1, string query, string exceptionText)
        {
            using (var conn = new MySqlConnection(connStr))
            {
                MySqlCommand com = new MySqlCommand(query, conn);
                try
                {
                    conn.Open();
                    //заполнение через источник данных
                    DataTable dataTable = new DataTable();
                    MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(com);
                    mySqlDataAdapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(exceptionText);
                    MessageBox.Show(ex.Message);
                }
                conn.Close();
            }
        }

        /// <summary>
        /// Метод для изменения данных в таблицах без вывода
        /// </summary>
        public static void Connector(string query, string exceptionText)
        {
            using (var conn = new MySqlConnection(Connection.connStr))
            {
                MySqlCommand com = new MySqlCommand(query, conn);
                try
                {
                    conn.Open();
                    //заполнение через источник данных
                    DataTable dataTable = new DataTable();
                    MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(com);
                    mySqlDataAdapter.Fill(dataTable);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(exceptionText);
                    MessageBox.Show(ex.Message);
                }
                conn.Close();
            }
        }
        
        /// <summary>
        /// Метод заполнения кейсбоксов 
        /// </summary>
        public static void FillCB(string query, ComboBox comboBox,WhichForm whichForm)
        {
            using (var conn = new MySqlConnection(connStr))
            {
                MySqlCommand com = new MySqlCommand(query, conn);
                try
                {
                    conn.Open();
                    MySqlDataReader reader = com.ExecuteReader();
                    switch (whichForm)
                    {
                        case WhichForm.Defendant:
                            {
                                while (reader.Read())
                                {
                                    comboBox.Items.Add(reader["DefendantNumber"]);
                                }
                                break;
                            }
                        case WhichForm.Judge:
                            {
                                while (reader.Read())
                                {
                                    comboBox.Items.Add(reader["JudgeNumber"]);
                                }
                                break;
                            }
                        case WhichForm.Plaintiff:
                            {
                                while (reader.Read())
                                {
                                    comboBox.Items.Add(reader["PlaintiffNumber"]);
                                }
                                break;
                            }
                        case WhichForm.Case:
                            {
                                while (reader.Read())
                                {
                                    comboBox.Items.Add(reader["Id"]);
                                }
                                break;
                            }
                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                conn.Close();
            }
        }

    }
}
