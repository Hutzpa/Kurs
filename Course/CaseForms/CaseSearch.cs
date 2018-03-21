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
            Design();
        }


        private WhichInquiry whichInquiry;
        private Case @case = new Case();
        private Regex idValidation = new Regex(@"\D");

        private CaseEditing caseEditing;
        private Deleting deleting;

        private void Design()
        {
            switch (whichInquiry)
            {
                case WhichInquiry.First:
                    {
                        label1.Hide();
                        textBox1.Hide();
                        button1.Hide();
                        Connection.Connector(dataGridView1,@case.First("-1"));
                        break;
                    }
                case WhichInquiry.Fourth:
                    {
                        label1.Hide();
                        textBox1.Hide();
                        button1.Hide();
                        Connection.Connector(dataGridView1, @case.Fourth("-1"));
                        break;
                    }             
            }
        }

        private void Action()
        {
            switch (whichInquiry)
            {
                case WhichInquiry.Zeroth:
                    {
                        Connection.Connector(dataGridView1, @case.Zero(textBox1.Text));
                        break;
                    }
                case WhichInquiry.Second:
                    {
                        Connection.Connector(dataGridView1,@case.Second(textBox1.Text));
                        break;
                    }
                case WhichInquiry.Third:
                    {
                        Connection.Connector(dataGridView1,@case.Third(textBox1.Text));
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
                            Connection.Connector(dataGridView1,@case.Fifth(textBox1.Text));
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
                            Connection.Connector(dataGridView1,@case.Sixth(textBox1.Text));
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
                            Connection.Connector(dataGridView1,@case.Seventh(textBox1.Text));
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

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
