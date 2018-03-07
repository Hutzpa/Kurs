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
    public partial class CaseSearch : Form
    {
        public CaseSearch(WhichInquiry whichInquiry)
        {
            InitializeComponent();
            this.whichInquiry = whichInquiry;
        }


        private string connStr = "datasource=localhost;port=3306;username=root;password=";
        WhichInquiry whichInquiry;
        Case @case = new Case();

        private void Searcher(string query)
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

        private void Action()
        {
            switch (whichInquiry)
            {
                case WhichInquiry.First:
                    {
                        @case.First(textBox1.Text);
                        break;
                    }
                case WhichInquiry.Second:
                    {
                        @case.Second(textBox1.Text);
                        break;
                    }
                case WhichInquiry.Third:
                    {
                        @case.Third(textBox1.Text);
                        break;
                    }
                case WhichInquiry.Fourth:
                    {
                        @case.Fourth(textBox1.Text);
                        break;
                    }
                case WhichInquiry.Fifth:
                    {
                        @case.Fifth(textBox1.Text);
                        break;
                    }
                case WhichInquiry.Sixth:
                    {
                        @case.Sixth(textBox1.Text);
                        break;
                    }
                case WhichInquiry.Seventh:
                    {
                        @case.Seventh(textBox1.Text);
                        break;
                    }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Action();
        }
    }
}
