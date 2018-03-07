using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course
{
    public partial class CaseEditing : Form
    {
        public CaseEditing()
        {
            InitializeComponent();
        }
        public string connStr = "datasource=localhost;port=3306;username=root;password=";

        Case @case = new Case();

        private void Action(string query)
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
                    // dataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                conn.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Action(@case.Update(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, checkBox1.Checked, checkBox2.Checked, textBox9.Text));
        }
    }
}
