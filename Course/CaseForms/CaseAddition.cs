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
        private string cantDisp = "UNKNOWN ID";


        private Case @case = new Case();
        private Judge judge = new Judge();
        private Defendant defendant = new Defendant();
        private Plaintiff plaintiff = new Plaintiff();

        public static CaseAddition caseAddition;

        public static CaseAddition GetCaseAddition()
        {
            if (caseAddition == null)
                caseAddition = new CaseAddition();
            return caseAddition;
        }

        public static CaseAddition caseAdditionParam;
        private CaseDisplay caseDisplay;

        private Regex idValidation = new Regex(@"\D");

        private ToolTip tip = new ToolTip() { InitialDelay = 1 };

        private void CaseAddition_Load(object sender, EventArgs e)
        {
            tip.SetToolTip(IdTB, "Allows to enter only numbers, enter case id");
            tip.SetToolTip(DefendantCB, "If defendant is not created yet, left this field empty");
            tip.SetToolTip(PlaintiffCB, "If plaintiff is not created yet, left this field empty");
            tip.SetToolTip(JudgeCB, "If judge is not created yet, left this field empty");
            tip.SetToolTip(DescriptionTB, "Description of case");
            tip.SetToolTip(ArticleTB, "Article of case");
            tip.SetToolTip(VerdictTB, "Verdict of case");
        }

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
            if(idValidation.IsMatch(IdTB.Text) || IdTB.Text == "")
            {
                MessageBox.Show("Id allow only numbers");
            }
            else
            {
            Connection.Connector(@case.Insert(int.Parse(IdTB.Text), DefendantCB.Text, PlaintiffCB.Text, JudgeCB.Text, DescriptionTB.Text, ArticleTB.Text, StartDate.Value, EndDate.Value, isEnd, isLegal, VerdictTB.Text), cantDisp);
            UpdateCaseNumber();
            Clean();
            }
        }

        private void CaseAddition_FormClosing(object sender, FormClosingEventArgs e)
        {
            caseDisplay.dataGridView1.Columns.Clear();
            Connection.Connector(caseDisplay.dataGridView1, @case.Display(), cantDisp);
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
            IdTB.Text = null;
            DefendantCB.SelectedItem = null;
            PlaintiffCB.SelectedItem = null;
            JudgeCB.SelectedItem = null;
            DescriptionTB.Text = null;
            ArticleTB.Text = null;
            VerdictTB.Text = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CaseAddition_Activated(object sender, EventArgs e)
        {
            JudgeCB.Items.Clear();
            DefendantCB.Items.Clear();
            PlaintiffCB.Items.Clear();
            Connection.FillCB(judge.Display(), JudgeCB, WhichForm.Judge);
            Connection.FillCB(defendant.Display(), DefendantCB, WhichForm.Defendant);
            Connection.FillCB(plaintiff.Display(), PlaintiffCB, WhichForm.Plaintiff);
        }

        private void UpdateCaseNumber()
        {
            Connection.Connector(judge.UpdateCaseNmb(JudgeCB.Text, IdTB.Text), cantDisp);
            Connection.Connector(defendant.UpdateCaseNmb(DefendantCB.Text, IdTB.Text), cantDisp);
            Connection.Connector(plaintiff.UpdateCaseNmb(PlaintiffCB.Text, IdTB.Text), cantDisp);
        }

    }
}
