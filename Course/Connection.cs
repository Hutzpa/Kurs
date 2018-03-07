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
    class Connection
    {
        private void Shit()
        {
            string connStr = "datasource=localhost;port=3306;username=root;password=";
            string query = " ";
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
                    // dataGridView1.DataSource = dataTable;
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
