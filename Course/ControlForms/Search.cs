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
    public partial class Search : Form
    {
        public Search(WhichForm whichForm)
        {
            InitializeComponent();
            this.whichForm = whichForm;
            Design();
        }

        WhichForm whichForm;
        Defendant defendant;
        Judge judge;
        Plaintiff plaintiff;

        private void Design()
        {
            switch(whichForm)
            {
                case WhichForm.Defendant:
                    {
                        Text = "Defendant search";
                        defendant = new Defendant();
                        break;
                    }
                case WhichForm.Judge:
                    {
                        Text = "Judge search";
                        judge = new Judge();
                        break;
                    }
                case WhichForm.Plaintiff:
                    {
                        Text = "Plaintiff search";
                        plaintiff = new Plaintiff();
                        break;
                    }
                default:
                    {
                        MessageBox.Show("NO FORM SELECTED");
                        this.Close();
                        break;
                    }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (whichForm)
            {
                case WhichForm.Defendant:
                    {
                        Connection.Connector(dataGridView1,defendant.Search(textBox1.Text));
                        break;
                    }
                case WhichForm.Judge:
                    {
                        Connection.Connector(dataGridView1,judge.Search(textBox1.Text));
                        break;
                    }
                case WhichForm.Plaintiff:
                    {
                        Connection.Connector(dataGridView1,plaintiff.Search(textBox1.Text));
                        break;
                    }
                default:
                    {
                        MessageBox.Show("NO FORM SELECTED");
                        this.Close();
                        break;
                    }
            }

            textBox1.Text = null;
        }
    }
}
