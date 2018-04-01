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
        public CaseEditing(CaseDisplay caseDisplay, string id)
        {
            InitializeComponent();
            caseDisplayParam = caseDisplay;
            IdTB.Text = id;
            IdTB.ReadOnly = true;
        }

        private CaseEditing(CaseDisplay caseDisplay)
        {
            InitializeComponent();
            caseDisplayNoparam = caseDisplay;
        }

        private  Case @case = new Case();
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

        private ToolTip tipCTB = new ToolTip() { InitialDelay = 1 };
        private ToolTip tipDTB = new ToolTip() { InitialDelay = 1 };
        private ToolTip tipPTB = new ToolTip() { InitialDelay = 1 };
        private ToolTip tipJTB = new ToolTip() { InitialDelay = 1 };
        private ToolTip tipDescTB = new ToolTip() { InitialDelay = 1 };
        private ToolTip tipArtTB = new ToolTip() { InitialDelay = 1 };
        private ToolTip tipVerdTB = new ToolTip() { InitialDelay = 1 };

        private void CaseEditing_Load(object sender, EventArgs e)
        {
            tipDTB.SetToolTip(DefendantIdTB, "Allows to enter only numbers, if defendant is not created yet, left this field empty");
            tipPTB.SetToolTip(PlaintiffIdTB, "Allows to enter only numbers, if plaintiff is not created yet, left this field empty");
            tipJTB.SetToolTip(JudgeIdTB, "Allows to enter only numbers, if judge is not created yet, left this field empty");
            tipDescTB.SetToolTip(DescriptionTB, "Description of case");
            tipArtTB.SetToolTip(ArticleTB, "Article of case");
            tipVerdTB.SetToolTip(VerdictTB, "Verdict of case");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (EndDate.Visible == true)
            {
                if (StartDate.Value < EndDate.Value)
                {
                    Editing();
                }
                else
                {
                    MessageBox.Show("Дата окончания дела указана неккоректно");
                }
            }
            else
                Editing();
        }

        private void CaseEditing_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (caseDisplayNoparam == null)
            {
                Connection.Connector(caseDisplayParam.dataGridView1, @case.Display());
            }
            else
            {
                Connection.Connector(caseDisplayNoparam.dataGridView1, @case.Display());
            }
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Visible = false;
            }
        }

        private void Editing()
        {
            if (idValidation.IsMatch(IdTB.Text) || IdTB.Text == "" || defendantIdValid.IsMatch(DefendantIdTB.Text) || plaintiffIdValid.IsMatch(PlaintiffIdTB.Text) || judgeIdValid.IsMatch(JudgeIdTB.Text))
            {
                MessageBox.Show("Id allows only numbers");
            }
            else
            {
                Connection.Connector(@case.Update(IdTB.Text, DefendantIdTB.Text, PlaintiffIdTB.Text, JudgeIdTB.Text, DescriptionTB.Text, ArticleTB.Text, StartDate.Value, EndDate.Value, isEnd, isLegal, VerdictTB.Text));
                Clean();
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
            DefendantIdTB.Text = null;
            PlaintiffIdTB.Text = null;
            JudgeIdTB.Text = null;
            DescriptionTB.Text = null;
            ArticleTB.Text = null;
            VerdictTB.Text = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(caseDisplayNoparam == null)
            {
                caseDisplayParam.dataGridView1.Columns.Clear();
                Connection.Connector(caseDisplayParam.dataGridView1, @case.Display());
            }
            else
            {
                caseDisplayNoparam.dataGridView1.Columns.Clear();
                Connection.Connector(caseDisplayNoparam.dataGridView1, @case.Display());
            }
            Close();
        }

        
    }
}
