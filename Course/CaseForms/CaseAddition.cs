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

        private CaseAddition(CaseDisplay caseDisplay)
        {
            InitializeComponent();
            this.caseDisplay = caseDisplay;
        }

        private Case @case = new Case();
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

        public static CaseAddition caseAdditionParam;
        private CaseDisplay caseDisplay;

        public static CaseAddition GetCaseAddition(CaseDisplay caseDisplay)
        {
            if (caseAdditionParam == null)
                caseAdditionParam = new CaseAddition(caseDisplay);
            return caseAdditionParam;
        }
        private short isEnd = 0;
        private short isLegal = 0;


        private void button1_Click(object sender, EventArgs e)
        {
            if (EndDate.Visible == true)
            {
                if (StartDate.Value < EndDate.Value)
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
            if (defendantIdValid.IsMatch(DefendantIdTB.Text) || DefendantIdTB.Text == "" || plaintiffIdValid.IsMatch(PlaintiffIdTB.Text) || PlaintiffIdTB.Text == "" || judgeIdValid.IsMatch(JudgeIdTB.Text) || JudgeIdTB.Text == "")
            {
                MessageBox.Show("Id allows only numbers");
            }
            else
            {
                Connection.Connector(@case.Insert(DefendantIdTB.Text, PlaintiffIdTB.Text, JudgeIdTB.Text, DescriptionTB.Text, ArticleTB.Text, StartDate.Value, EndDate.Value, isEnd, isLegal, VerdictTB.Text));
                Clean();
            }
        }

        private void CaseAddition_FormClosing(object sender, FormClosingEventArgs e)
        {
            caseDisplay.dataGridView1.Columns.Clear();
            Connection.Connector(caseDisplay.dataGridView1, @case.Display());
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (isEnd == 0)
                isEnd = -1;
            else
                isEnd = 0;
            if (EndDate.Visible == true)
            {
                label9.Visible = false;
                EndDate.Visible = false;
                label7.Visible = false;
                VerdictTB.Visible = false;
            }
            else
            {
                label9.Visible = true;
                EndDate.Visible = true;
                label7.Visible = true;
                VerdictTB.Visible = true;
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
            DefendantIdTB.Text = null;
            PlaintiffIdTB.Text = null;
            JudgeIdTB.Text = null;
            DescriptionTB.Text = null;
            ArticleTB.Text = null;
            VerdictTB.Text = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
