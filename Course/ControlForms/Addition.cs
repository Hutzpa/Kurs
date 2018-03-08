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

        private void button1_Click(object sender, EventArgs e)
        {
            switch (whichForm)
            {
                case WhichForm.Defendant:
                    {
                        Connection.Connector(defendant.Insert(textBox1.Text, textBox2.Text, textBox3.Text));
                        break;
                    }
                case WhichForm.Judge:
                    {
                        Connection.Connector(judge.Insert(textBox1.Text, textBox2.Text, textBox3.Text));
                        break;
                    }
                case WhichForm.Plaintiff:
                    {
                        Connection.Connector(plaintiff.Insert(textBox1.Text, textBox2.Text, textBox3.Text));
                        break;
                    }
                default:
                    {
                        MessageBox.Show("NO FORM SELECTED");
                        Close();
                        break;
                    }
            }

            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
        }
    }
}
