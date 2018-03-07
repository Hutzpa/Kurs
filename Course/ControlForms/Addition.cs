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
    public partial class Addition : Form
    {
        public Addition(WhichForm whichForm)
        {
            InitializeComponent();
            this.whichForm = whichForm;
            Design();
        }

        WhichForm whichForm;
        Defendant defendant;
        Judge judge;
        Plaintiff plaintiff;

        private string connStr = "datasource=localhost;port=3306;username=root;password=";

        private void Design()
        {
            switch (whichForm)
            {
                case WhichForm.Defendant:
                    {
                        Text = "Defendant addition";
                        defendant = new Defendant();
                        break;
                    }
                case WhichForm.Judge:
                    {
                        Text = "Judge addition";
                        judge = new Judge();
                        break;
                    }
                case WhichForm.Plaintiff:
                    {
                        Text = "Plaintiff addition";
                        plaintiff = new Plaintiff();
                        break;
                    }
                default:
                    {
                        MessageBox.Show("NO FORM SELECTED");
                        Close();
                        break;
                    }
            }
        }

        private void Moution(string query)
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
            switch (whichForm)
            {
                case WhichForm.Defendant:
                    {
                        Moution(defendant.Insert(textBox1.Text, textBox2.Text, textBox3.Text));
                        break;
                    }
                case WhichForm.Judge:
                    {
                        Moution(judge.Insert(textBox1.Text, textBox2.Text, textBox3.Text));
                        break;
                    }
                case WhichForm.Plaintiff:
                    {
                        Moution(plaintiff.Insert(textBox1.Text, textBox2.Text, textBox3.Text));
                        break;
                    }
                default:
                    {
                        MessageBox.Show("NO FORM SELECTED");
                        Close();
                        break;
                    }
            }
        }
    }
}
