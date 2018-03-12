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
    public partial class CaseEditing : Form
    {
        private CaseEditing(string id)
        {
            InitializeComponent();
            textBox1.Text = id;
            textBox1.ReadOnly = true;
        }

        private CaseEditing()
        {
            InitializeComponent();
        }

        private  Case @case = new Case();
        private Regex idValidation = new Regex(@"\D");
        private Regex defendantIdValid = new Regex(@"\D");
        private Regex plaintiffIdValid = new Regex(@"\D");
        private Regex judgeIdValid = new Regex(@"\D");

        public static CaseEditing caseEditing;

        public static CaseEditing GetCaseEditing()
        {
            if (caseEditing == null)
                caseEditing = new CaseEditing();
            return caseEditing;
        }

        public static CaseEditing GetCaseEditing(string id)
        {
            if (caseEditing == null)
                caseEditing = new CaseEditing(id);
            return caseEditing;
        }

    
        private void button1_Click(object sender, EventArgs e)
        {
            if (idValidation.IsMatch(textBox1.Text) || defendantIdValid.IsMatch(textBox2.Text) || plaintiffIdValid.IsMatch(textBox3.Text) || judgeIdValid.IsMatch(textBox4.Text))
            {
                MessageBox.Show("Id allows only numbers");
            }
            else
            {
                Connection.Connector(@case.Update(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, checkBox1.Checked, checkBox2.Checked, textBox9.Text));
            }
        }

        private void CaseEditing_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Visible = false;
            }
        }
    }
}
