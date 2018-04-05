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
        public CaseEditing(CaseDisplay caseDisplay, string id, string description, string article, string verdict)
        {
            InitializeComponent();
            caseDisplayParam = caseDisplay;
            IdCB.DropDownStyle = ComboBoxStyle.Simple;
            IdCB.Text = id;
            IdCB.Enabled = false;
            DescriptionTB.Text = description;
            ArticleTB.Text = article;
            VerdictTB.Text = verdict;
        }

        private CaseEditing(CaseDisplay caseDisplay)
        {
            InitializeComponent();
            caseDisplayNoparam = caseDisplay;
        }

        private string cantDisp = "UNKNOWN ID";

        private  Case @case = new Case();
        private Judge judge = new Judge();
        private Defendant defendant = new Defendant();
        private Plaintiff plaintiff = new Plaintiff();
        private Regex idValidation = new Regex(@"\D");
        private Regex defendantIdValid = new Regex(@"\D");
        private Regex plaintiffIdValid = new Regex(@"\D");
        private Regex judgeIdValid = new Regex(@"\D");

        private short isEnd = 0;
        private short isLegal = 0;

        public static CaseEditing caseEditingNoparam;

        private CaseDisplay caseDisplayParam;
        private CaseDisplay caseDisplayNoparam;

        public static CaseEditing GetCaseEditingNoparam(CaseDisplay caseDisplay)
        {
            if (caseEditingNoparam == null)
                caseEditingNoparam = new CaseEditing(caseDisplay);
            return caseEditingNoparam;
        }

        private ToolTip tip = new ToolTip() { InitialDelay = 1 };

        private void CaseEditing_Load(object sender, EventArgs e)
        {
            tip.SetToolTip(IdCB, "Allows to enter only numbers, enter case id");
            tip.SetToolTip(DefendantCB, "Allows to enter only numbers, if defendant is not created yet, left this field empty");
            tip.SetToolTip(PlaintiffCB, "Allows to enter only numbers, if plaintiff is not created yet, left this field empty");
            tip.SetToolTip(JudgeCB, "Allows to enter only numbers, if judge is not created yet, left this field empty");
            tip.SetToolTip(DescriptionTB, "Description of case");
            tip.SetToolTip(ArticleTB, "Article of case");
            tip.SetToolTip(VerdictTB, "Verdict of case");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (EndDate.Visible == true)
            {
                if (StartDate.Value < EndDate.Value)
                {
                    Editing();
                    Clean();
                }
                else
                {
                    MessageBox.Show("Дата окончания дела указана неккоректно");
                }
            }
            else
            {
                Editing();
                Connection.Connector(@case.ClearVerdict(IdCB.Text), cantDisp);
                Clean();
            }
        }

        private void CaseEditing_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (caseDisplayNoparam == null)
            {
                Connection.Connector(caseDisplayParam.dataGridView1, @case.Display(), cantDisp);
            }
            else
            {
                Connection.Connector(caseDisplayNoparam.dataGridView1, @case.Display(), cantDisp);
            }
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Visible = false;
            }
        }

        private void Editing()
        {
            if (idValidation.IsMatch(IdCB.Text) ||defendantIdValid.IsMatch(DefendantCB.Text) || plaintiffIdValid.IsMatch(PlaintiffCB.Text) || judgeIdValid.IsMatch(JudgeCB.Text))
            {
                MessageBox.Show("Id allows only numbers");
            }
            else
            {
                Connection.Connector(@case.Update(IdCB.Text, DefendantCB.Text, PlaintiffCB.Text, JudgeCB.Text, DescriptionTB.Text, ArticleTB.Text, StartDate.Value, EndDate.Value, isEnd, isLegal, VerdictTB.Text), cantDisp);
                UpdateCaseNumber();
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
            IdCB.SelectedItem = null;
            DefendantCB.SelectedItem = null;
            PlaintiffCB.SelectedItem = null;
            JudgeCB.SelectedItem = null;
            DescriptionTB.Text = null;
            ArticleTB.Text = null;
            VerdictTB.Text = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(caseDisplayNoparam == null)
            {
                caseDisplayParam.dataGridView1.Columns.Clear();
                Connection.Connector(caseDisplayParam.dataGridView1, @case.Display(), cantDisp);
            }
            else
            {
                caseDisplayNoparam.dataGridView1.Columns.Clear();
                Connection.Connector(caseDisplayNoparam.dataGridView1, @case.Display(), cantDisp);
            }
            Close();
        }

        private void CaseEditing_Activated(object sender, EventArgs e)
        {
            JudgeCB.Items.Clear();
            DefendantCB.Items.Clear();
            PlaintiffCB.Items.Clear();
            IdCB.Items.Clear();
            Connection.FillCB(@case.Display(), IdCB, WhichForm.Case);
            Connection.FillCB(judge.Display(), JudgeCB, WhichForm.Judge);
            Connection.FillCB(defendant.Display(), DefendantCB, WhichForm.Defendant);
            Connection.FillCB(plaintiff.Display(), PlaintiffCB, WhichForm.Plaintiff);
        }

        private void UpdateCaseNumber()
        {
            Connection.Connector(judge.UpdateCaseNmb(JudgeCB.Text, IdCB.Text), cantDisp);
            Connection.Connector(defendant.UpdateCaseNmb(DefendantCB.Text, IdCB.Text), cantDisp);
            Connection.Connector(plaintiff.UpdateCaseNmb(PlaintiffCB.Text, IdCB.Text), cantDisp);
        }
    }
}
