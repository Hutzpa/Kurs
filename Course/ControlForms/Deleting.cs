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

        private void button1_Click(object sender, EventArgs e)
        {
            switch (whichForm)
            {
                case WhichForm.Defendant:
                    {
                        Connection.Connector(defendant.Delete(textBox1.Text));
                        break;
                    }
                case WhichForm.Judge:
                    {
                        Connection.Connector(judge.Delete(textBox1.Text));
                        break;
                    }
                case WhichForm.Plaintiff:
                    {
                        Connection.Connector(plaintiff.Delete(textBox1.Text));
                        break;
                    }
                case WhichForm.Case:
                    {
                        Connection.Connector(@case.Delete(textBox1.Text));
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
        }
    }
}
