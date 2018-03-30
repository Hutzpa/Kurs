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
        public static void Connector(DataGridView dataGridView1, string query)
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
                    MessageBox.Show(ex.ToString());
                }
                conn.Close();
            }
        }

        /// <summary>
        /// Метод для изменения данных в таблицах без вывода
        /// </summary>
        public static void Connector(string query)
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
                    MessageBox.Show(ex.ToString());
                }
                conn.Close();
            }
        }

        public static List<object> GetFio(string query,string fio)
        {
            using (var conn = new MySqlConnection(connStr))
            {
                List<object> list = new List<object>();
                MySqlCommand com = new MySqlCommand(query, conn);
                try
                {
                    conn.Open();
                    MySqlDataReader reader = com.ExecuteReader();
                    while (reader.Read())
                    {
                        if(reader["Fio"].ToString() == fio)
                        {
                            list.Add(reader["CaseNumber"]);
                        }
                    }
                    conn.Close();
                    return list;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    return new List<object>();
                }
            }
        }

        public static void FillDgv(DataGridView dataGridView1, string query, List<object> list)
        {
            using (var conn = new MySqlConnection(connStr))
            {
                MySqlCommand com = new MySqlCommand(query, conn);
                try
                {
                    conn.Open();
                    MySqlDataReader reader = com.ExecuteReader();
                    DataTable dataTable = new DataTable();
                    dataGridView1.DataSource = null;
                    while (reader.Read())
                    {
                       for(int i = 0; i<list.Count; i++)
                        {
                            if(reader["Id"].ToString() == list[i].ToString())
                            {
                                dataGridView1.Rows.Add(Convert.ToInt32(reader["Id"]), Convert.ToUInt32(reader["NumberDefendant"]), Convert.ToUInt32(reader["PlaintiffNumber"]), Convert.ToUInt32(reader["JudgeNumber"]), reader["Description"].ToString(), reader["Article"].ToString(),Convert.ToDateTime(reader["DateOfStart"]).ToShortDateString(),Convert.ToDateTime(reader["DateOfEnd"]).ToShortDateString(),Convert.ToBoolean(reader["IsEnd"]), Convert.ToBoolean(reader["IsUr"]), reader["Verdict"].ToString());
                                
                            }
                        }
                    }
                    conn.Close();
                   

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    
                }
            }
        }
    }
}
