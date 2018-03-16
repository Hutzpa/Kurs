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
    public partial class CaseSearch : Form
    {
        public CaseSearch(WhichInquiry whichInquiry)
        {
            InitializeComponent();
            this.whichInquiry = whichInquiry;
        }


        private WhichInquiry whichInquiry;
        private Case @case = new Case();
        private Regex idValidation = new Regex(@"\D");

        private CaseEditing caseEditing;
        private Deleting deleting;

        private void Action()
        {
            switch (whichInquiry)
            {
                case WhichInquiry.First:
                    {
                        if(idValidation.IsMatch(textBox1.Text))
                        {
                            MessageBox.Show("Incorrect id format");
                        }
                        else
                        {
                            Connection.Connector(@case.First(textBox1.Text));
                        }
                        break;
                    }
                case WhichInquiry.Second:
                    {
                        if (idValidation.IsMatch(textBox1.Text))
                        {
                            MessageBox.Show("Incorrect id format");
                        }
                        else
                        {
                            Connection.Connector(@case.Second(textBox1.Text));
                        }
                        break;
                    }
                case WhichInquiry.Third:
                    {
                        if (idValidation.IsMatch(textBox1.Text))
                        {
                            MessageBox.Show("Incorrect id format");
                        }
                        else
                        {
                            Connection.Connector(@case.Third(textBox1.Text));
                        }
                        break;
                    }
                case WhichInquiry.Fourth:
                    {
                        if (idValidation.IsMatch(textBox1.Text))
                        {
                            MessageBox.Show("Incorrect id format");
                        }
                        else
                        {
                            Connection.Connector(@case.Fourth(textBox1.Text));
                        }
                        break;
                    }
                case WhichInquiry.Fifth:
                    {
                        if (idValidation.IsMatch(textBox1.Text))
                        {
                            MessageBox.Show("Incorrect id format");
                        }
                        else
                        {
                            Connection.Connector(@case.Fifth(textBox1.Text));
                        }
                        break;
                    }
                case WhichInquiry.Sixth:
                    {
                        if (idValidation.IsMatch(textBox1.Text))
                        {
                            MessageBox.Show("Incorrect id format");
                        }
                        else
                        {
                            Connection.Connector(@case.Sixth(textBox1.Text));
                        }
                        break;
                    }
                case WhichInquiry.Seventh:
                    {
                        if (idValidation.IsMatch(textBox1.Text))
                        {
                            MessageBox.Show("Incorrect id format");
                        }
                        else
                        {
                            Connection.Connector(@case.Seventh(textBox1.Text));
                        }
                        break;
                    }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Action();
        }

        private void CaseSearch_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Visible = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            caseEditing = CaseEditing.GetCaseEditing(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            caseEditing.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            deleting = new Deleting(WhichForm.Case,dataGridView1.CurrentRow.Cells[0].Value.ToString());
            deleting.Show();
        }
    }
}
