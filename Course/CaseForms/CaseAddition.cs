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
    public partial class CaseAddition : Form
    {
        private CaseAddition()
        {
            InitializeComponent();
        }

        private Case @case = new Case();
        private Regex idValidation = new Regex(@"\D");
        private Regex defendantIdValid = new Regex(@"\D");
        private Regex plaintiffIdValid = new Regex(@"\D");
        private Regex judgeIdValid = new Regex(@"\D");

        public static CaseAddition caseAddition;

        public static CaseAddition GetCaseAddition()
        {
            if (caseAddition == null)
                caseAddition = new CaseAddition();
            return caseAddition;
        }

        private short isEnd = 0;
        private short isLegal = 0;


        private void button1_Click(object sender, EventArgs e)
        {
            if (dateTimePicker2.Visible == true)
            {
                if (dateTimePicker1.Value < dateTimePicker2.Value)
                {
                    Addition();
                }
                else
                {
                    MessageBox.Show("Дата окончания дела указана неккоректно");
                }
            }
            else
            {
                Addition();
            }
        }

        private void Addition()
        {
            if (idValidation.IsMatch(textBox1.Text) || defendantIdValid.IsMatch(textBox2.Text) || plaintiffIdValid.IsMatch(textBox3.Text) || judgeIdValid.IsMatch(textBox4.Text))
            {
                MessageBox.Show("Id allows only numbers");
            }
            else
            {
                Connection.Connector(@case.Insert(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, dateTimePicker1.Value, dateTimePicker2.Value, isEnd, isLegal, textBox9.Text));
                Clean();
            }
        }

        private void CaseAddition_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Visible = false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (isEnd == 0)
                isEnd = -1;
            else
                isEnd = 0;
            if (dateTimePicker2.Visible == true)
            {
                label9.Visible = false;
                dateTimePicker2.Visible = false;
                label7.Visible = false;
                textBox9.Visible = false;
            }
            else
            {
                label9.Visible = true;
                dateTimePicker2.Visible = true;
                label7.Visible = true;
                textBox9.Visible = true;
            }

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (isLegal == 0)
                isLegal = -1;
            else
                isLegal = 0;
        }

        private void Clean()
        {
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            textBox4.Text = null;
            textBox5.Text = null;
            textBox6.Text = null;
            textBox9.Text = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
