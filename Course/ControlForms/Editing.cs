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
    public partial class Editing : Form
    {
        public Editing(WhichForm whichForm)
        {
            InitializeComponent();
            this.whichForm = whichForm;
            Design();
        }

        public Editing(WhichForm whichForm, string id)
        {
            InitializeComponent();
            this.whichForm = whichForm;
            Design();
            textBox1.Text = id;
            textBox1.ReadOnly = true;
        }

        private WhichForm whichForm;
        private Defendant defendant;
        private Judge judge;
        private Plaintiff plaintiff;
        private Regex idValidation = new Regex(@"\D");
        private Regex numberValid = new Regex(@"\D");


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
                        if (idValidation.IsMatch(textBox1.Text) || numberValid.IsMatch(textBox4.Text))
                        {
                            MessageBox.Show("Id writed incorrect. Only numbers.");
                        }
                        else
                        {
                            Connection.Connector(defendant.Update(textBox1.Text,textBox4.Text, textBox2.Text, textBox3.Text, textBox5.Text));
                        }
                        break;
                    }
                case WhichForm.Judge:
                    {
                        if (idValidation.IsMatch(textBox1.Text) || numberValid.IsMatch(textBox4.Text))
                        {
                            MessageBox.Show("Id writed incorrect. Only numbers.");
                        }
                        else
                        {
                            Connection.Connector(judge.Update(textBox1.Text, textBox4.Text, textBox2.Text, textBox3.Text,textBox5.Text));
                        }
                        break;
                    }
                case WhichForm.Plaintiff:
                    {
                        if (idValidation.IsMatch(textBox1.Text) || numberValid.IsMatch(textBox4.Text))
                        {
                            MessageBox.Show("Id writed incorrect. Only numbers.");
                        }
                        else
                        {
                            Connection.Connector(plaintiff.Update(textBox1.Text, textBox4.Text, textBox2.Text, textBox3.Text,textBox5.Text));
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
          Cleaning();
        }

        private void Cleaning()
        {
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            textBox4.Text = null;
            textBox5.Text = null;
        }
    }
}
