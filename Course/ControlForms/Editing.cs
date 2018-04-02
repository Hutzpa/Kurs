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
      
        public Editing(WhichForm whichForm,Displayer displayer)
        {
            InitializeComponent();
            this.whichForm = whichForm;
            this.displayer = displayer;
            Design();
        }

        public Editing(WhichForm whichForm, string id,Displayer displayer)
        {
            InitializeComponent();
            this.whichForm = whichForm;
            this.displayer = displayer;
            Design();
            IdCB.DropDownStyle = ComboBoxStyle.Simple;
            IdCB.Text = id;
            IdCB.Enabled = false;
        }
        private string exception = "";

        private Displayer displayer;
        private Case @case = new Case();
        private WhichForm whichForm;
        private Defendant defendant;
        private Judge judge;
        private Plaintiff plaintiff;
        private Regex idValidation = new Regex(@"\D");
        private Regex numberValid = new Regex(@"\D");
        private Regex nameValid = new Regex(@"\d");


        private ToolTip tip = new ToolTip() { InitialDelay = 1 };
     
        private void Editing_Load(object sender, EventArgs e)
        {
            tip.SetToolTip(IdCB, "Allows to enter only numbers, enter id of " + whichForm.ToString().ToLower() + "what are you want to edit");
            tip.SetToolTip(CaseNumberСB, "Allows to enter only numbers, if case is not created yet, left this field empty");
            tip.SetToolTip(NameTB, "Allows to enter only letters,write name here");
            tip.SetToolTip(SurnameTB, "Allows to enter only letters, write surname here");
            tip.SetToolTip(PatronymicTB, "Allows to enter only letters, write patronymic here");
        }

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
                        if (numberValid.IsMatch(CaseNumberСB.Text) ||  numberValid.IsMatch(CaseNumberСB.Text) || nameValid.IsMatch(NameTB.Text) || NameTB.Text == "" || nameValid.IsMatch(SurnameTB.Text) || SurnameTB.Text == "" || nameValid.IsMatch(PatronymicTB.Text) || PatronymicTB.Text == "")
                        {
                            MessageBox.Show("Id writed incorrect. Only numbers.");
                        }
                        else
                        {
                            Connection.Connector(defendant.Update(IdCB.Text,CaseNumberСB.Text, NameTB.Text, SurnameTB.Text, PatronymicTB.Text), exception);
                        }
                        break;
                    }
                case WhichForm.Judge:
                    {
                        if (idValidation.IsMatch(IdCB.Text) || numberValid.IsMatch(CaseNumberСB.Text) ||  numberValid.IsMatch(CaseNumberСB.Text) || nameValid.IsMatch(NameTB.Text) || NameTB.Text == "" || nameValid.IsMatch(SurnameTB.Text) || SurnameTB.Text == "" || nameValid.IsMatch(PatronymicTB.Text) || PatronymicTB.Text == "")
                        {
                            MessageBox.Show("Id writed incorrect. Only numbers.");
                        }
                        else
                        {
                            Connection.Connector(judge.Update(IdCB.Text, CaseNumberСB.Text, NameTB.Text, SurnameTB.Text,PatronymicTB.Text), exception);
                        }
                        break;
                    }
                case WhichForm.Plaintiff:
                    {
                        if (idValidation.IsMatch(IdCB.Text) || numberValid.IsMatch(CaseNumberСB.Text) || numberValid.IsMatch(CaseNumberСB.Text) || nameValid.IsMatch(NameTB.Text) || NameTB.Text == "" || nameValid.IsMatch(SurnameTB.Text) || SurnameTB.Text == "" || nameValid.IsMatch(PatronymicTB.Text) || PatronymicTB.Text == "")
                        {
                            MessageBox.Show("Id writed incorrect. Only numbers.");
                        }
                        else
                        {
                            Connection.Connector(plaintiff.Update(IdCB.Text, CaseNumberСB.Text, NameTB.Text, SurnameTB.Text,PatronymicTB.Text), exception);
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
            NameTB.Text = null;
            SurnameTB.Text = null;
            CaseNumberСB.Text = null;
            PatronymicTB.Text = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            Close();
        }

        private void Editing_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (whichForm)
            {
                case WhichForm.Defendant:
                    {
                        Connection.Connector(displayer.dataGridView1, defendant.Display(), exception);
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
            }
        }

        private void Editing_Activated(object sender, EventArgs e)
        {
            switch (whichForm)
            {
                case WhichForm.Defendant:
                    {
                      //  IdCB.Items.Clear();
                        CaseNumberСB.Items.Clear();
                        Connection.FillCB(defendant.Display(), IdCB, WhichForm.Defendant);
                        Connection.FillCB(@case.Display(), CaseNumberСB, WhichForm.Case);

                        break;
                    }
                case WhichForm.Judge:
                    {
                     //   IdCB.Items.Clear();
                        CaseNumberСB.Items.Clear();
                        Connection.FillCB(judge.Display(), IdCB, WhichForm.Judge);
                        Connection.FillCB(@case.Display(), CaseNumberСB, WhichForm.Case);
                        break;
                    }
                case WhichForm.Plaintiff:
                    {
                      //  IdCB.Items.Clear();
                        CaseNumberСB.Items.Clear();
                        Connection.FillCB(plaintiff.Display(), IdCB, WhichForm.Plaintiff);
                        Connection.FillCB(@case.Display(), CaseNumberСB, WhichForm.Case);
                        break;
                    }
            }
        }
    }
}
