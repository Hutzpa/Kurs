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
    public partial class Editing : Form
    {
        public Editing(WhichForm whichForm)
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
                        Text = "Defendant editing";
                        defendant = new Defendant();
                        break;
                    }
                case WhichForm.Judge:
                    {
                        Text = "Judge editing";
                        judge = new Judge();
                        break;
                    }
                case WhichForm.Plaintiff:
                    {
                        Text = "Plaintiff editing";
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
                        Connection.Connector(defendant.Update(textBox1.Text, textBox2.Text, textBox3.Text));
                        break;
                    }
                case WhichForm.Judge:
                    {
                        Connection.Connector(judge.Update(textBox1.Text, textBox2.Text, textBox3.Text));
                        break;
                    }
                case WhichForm.Plaintiff:
                    {
                        Connection.Connector(plaintiff.Update(textBox1.Text, textBox2.Text, textBox3.Text));
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
            textBox2.Text = null;
            textBox3.Text = null;
        }
    }
}
