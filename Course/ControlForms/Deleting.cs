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
    public partial class Deleting : Form
    {
        public Deleting(WhichForm whichForm)
        {
            InitializeComponent();
            this.whichForm = whichForm;
            Design();
        }

        WhichForm whichForm;
        Defendant defendant;
        Judge judge;
        Plaintiff plaintiff;
        Case @case;

        private string connStr = "datasource=localhost;port=3306;username=root;password=";

        private void Design()
        {
            switch (whichForm)
            {
                case WhichForm.Defendant:
                    {
                        Text = "Defendant delete";
                        defendant = new Defendant();
                        break;
                    }
                case WhichForm.Judge:
                    {
                        Text = "Judge delete";
                        judge = new Judge();
                        break;
                    }
                case WhichForm.Plaintiff:
                    {
                        Text = "Plaintiff delete";
                        plaintiff = new Plaintiff();
                        break;
                    }
                case WhichForm.Case:
                    {
                        Text = "Case delete";
                        @case = new Case();
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
            MessageBox.Show("DELETING SUCCESSFUL");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (whichForm)
            {
                case WhichForm.Defendant:
                    {
                        Moution(defendant.Delete(textBox1.Text));
                        break;
                    }
                case WhichForm.Judge:
                    {
                        Moution(judge.Delete(textBox1.Text));
                        break;
                    }
                case WhichForm.Plaintiff:
                    {
                        Moution(plaintiff.Delete(textBox1.Text));
                        break;
                    }
                case WhichForm.Case:
                    {
                        Moution(@case.Delete(textBox1.Text));
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
