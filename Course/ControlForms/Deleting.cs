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

        public Deleting(WhichForm whichForm,CaseDisplay caseDisplay)
        {
            InitializeComponent();
            this.whichForm = whichForm;
            this.caseDisplay = caseDisplay;
            Design();
        }

        public Deleting(WhichForm whichForm, Displayer displayer)
        {
            InitializeComponent();
            this.whichForm = whichForm;
            this.displayer = displayer;
            Design();
        }
        private string exception = "CAN'T DELETE RELATED VALUES OR NO DATA SELECTED";
        private CaseDisplay caseDisplay;
        private Displayer displayer;
        private WhichForm whichForm;
        private Defendant defendant;
        private Judge judge;
        private Plaintiff plaintiff;
        private Case @case;
        private Regex idValidation = new Regex(@"\D");

        private ToolTip tipITB = new ToolTip() { InitialDelay = 1 };

        private void Deleting_Load(object sender, EventArgs e)
        {
            tipITB.SetToolTip(IdCB, "Allows to enter only numbers, enter id of " + whichForm.ToString().ToLower() + "what are you want to delete");
        }

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
                        if (idValidation.IsMatch(IdCB.Text))
                        {
                            MessageBox.Show("Id writed incorrect. Only numbers.");
                        }
                        else
                        {
                            Connection.Connector(defendant.Delete(IdCB.Text),exception);
                        }
                        break;
                    }
                case WhichForm.Judge:
                    {
                        if (idValidation.IsMatch(IdCB.Text))
                        {
                            MessageBox.Show("Id writed incorrect. Only numbers.");
                        }
                        else
                        {
                            Connection.Connector(judge.Delete(IdCB.Text),exception);
                        }
                        break;
                    }
                case WhichForm.Plaintiff:
                    {
                        if (idValidation.IsMatch(IdCB.Text))
                        {
                            MessageBox.Show("Id writed incorrect. Only numbers.");
                        }
                        else
                        {
                            Connection.Connector(plaintiff.Delete(IdCB.Text),exception);
                        }
                        break;
                    }
                case WhichForm.Case:
                    {
                        if (idValidation.IsMatch(IdCB.Text))
                        {
                            MessageBox.Show("Id writed incorrect. Only numbers.");
                        }
                        else
                        {
                            Connection.Connector(@case.Delete(IdCB.Text),exception);
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

            IdCB.Text = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
          Close();
        }

        private void Deleting_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (whichForm)
            {
                case WhichForm.Defendant:
                    {
                        Connection.Connector(displayer.dataGridView1, defendant.Display(),exception);
                        break;
                    }
                case WhichForm.Judge:
                    {
                        Connection.Connector(displayer.dataGridView1, judge.Display(), exception);
                        break;
                    }
                case WhichForm.Plaintiff:
                    {
                        Connection.Connector(displayer.dataGridView1, plaintiff.Display(), exception);
                        break;
                    }
                case WhichForm.Case:
                    {
                        caseDisplay.dataGridView1.Columns.Clear();
                        Connection.Connector(caseDisplay.dataGridView1, @case.Display(), exception);
                        break;
                    }
            }
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }

        private void Deleting_Activated(object sender, EventArgs e)
        {
            switch (whichForm)
            {
                case WhichForm.Defendant:
                    {
                        IdCB.Items.Clear();
                        Connection.FillCB(defendant.Display(), IdCB, WhichForm.Defendant);
                        break;
                    }
                case WhichForm.Judge:
                    {
                        IdCB.Items.Clear();
                        Connection.FillCB(judge.Display(), IdCB, WhichForm.Judge);
                        break;
                    }
                case WhichForm.Plaintiff:
                    {
                        IdCB.Items.Clear();
                        Connection.FillCB(plaintiff.Display(), IdCB, WhichForm.Plaintiff);
                        break;
                    }
                case WhichForm.Case:
                    {
                        IdCB.Items.Clear();
                        Connection.FillCB(@case.Display(), IdCB, WhichForm.Case);
                        break;
                    }
            }
        }
    }
}
