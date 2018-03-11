using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        private WhichForm whichForm;
        private Defendant defendant;
        private Judge judge;
        private Plaintiff plaintiff;
        private Case @case;
        private Regex idValidation = new Regex(@"\D");

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
                        if (idValidation.IsMatch(textBox1.Text))
                        {
                            MessageBox.Show("Id writed incorrect. Only numbers.");
                        }
                        else
                        {
                            Connection.Connector(defendant.Delete(textBox1.Text));
                        }
                        break;
                    }
                case WhichForm.Judge:
                    {
                        if (idValidation.IsMatch(textBox1.Text))
                        {
                            MessageBox.Show("Id writed incorrect. Only numbers.");
                        }
                        else
                        {
                            Connection.Connector(judge.Delete(textBox1.Text));
                        }
                        break;
                    }
                case WhichForm.Plaintiff:
                    {
                        if (idValidation.IsMatch(textBox1.Text))
                        {
                            MessageBox.Show("Id writed incorrect. Only numbers.");
                        }
                        else
                        {
                            Connection.Connector(plaintiff.Delete(textBox1.Text));
                        }
                        break;
                    }
                case WhichForm.Case:
                    {
                        if (idValidation.IsMatch(textBox1.Text))
                        {
                            MessageBox.Show("Id writed incorrect. Only numbers.");
                        }
                        else
                        {
                            Connection.Connector(@case.Delete(textBox1.Text));
                        }
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
