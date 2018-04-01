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
        //public Editing(WhichForm whichForm)
        //{
        //    InitializeComponent();
        //    this.whichForm = whichForm;
        //    Design();
        //}

        //public Editing(WhichForm whichForm, string id)
        //{
        //    InitializeComponent();
        //    this.whichForm = whichForm;
        //    Design();
        //    textBox1.Text = id;
        //    textBox1.ReadOnly = true;
        //}

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
            IdTB.Text = id;
            IdTB.ReadOnly = true;
        }

        private Displayer displayer;

        private WhichForm whichForm;
        private Defendant defendant;
        private Judge judge;
        private Plaintiff plaintiff;
        private Regex idValidation = new Regex(@"\D");
        private Regex numberValid = new Regex(@"\D");
        private Regex nameValid = new Regex(@"\d");


        private ToolTip tipITB = new ToolTip() { InitialDelay = 1 };
        private ToolTip tipCTB = new ToolTip() { InitialDelay = 1 };
        private ToolTip tipNTB = new ToolTip() { InitialDelay = 1 };
        private ToolTip tipSTB = new ToolTip() { InitialDelay = 1 };
        private ToolTip tipPTB = new ToolTip() { InitialDelay = 1 };

        private void Editing_Load(object sender, EventArgs e)
        {
            tipITB.SetToolTip(IdTB, "Allows to enter only numbers, enter id of " + whichForm.ToString().ToLower() + "what are you want to edit");
            tipCTB.SetToolTip(CaseNumberTB, "Allows to enter only numbers, if case is not created yet, left this field empty");
            tipNTB.SetToolTip(NameTB, "Allows to enter only letters,write name here");
            tipSTB.SetToolTip(SurnameTB, "Allows to enter only letters, write surname here");
            tipPTB.SetToolTip(PatronymicTB, "Allows to enter only letters, write patronymic here");
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
                        if (numberValid.IsMatch(CaseNumberTB.Text) || CaseNumberTB.Text == "" || numberValid.IsMatch(CaseNumberTB.Text) || nameValid.IsMatch(NameTB.Text) || NameTB.Text == "" || nameValid.IsMatch(SurnameTB.Text) || SurnameTB.Text == "" || nameValid.IsMatch(PatronymicTB.Text) || PatronymicTB.Text == "")
                        {
                            MessageBox.Show("Id writed incorrect. Only numbers.");
                        }
                        else
                        {
                            Connection.Connector(defendant.Update(IdTB.Text,CaseNumberTB.Text, NameTB.Text, SurnameTB.Text, PatronymicTB.Text));
                        }
                        break;
                    }
                case WhichForm.Judge:
                    {
                        if (idValidation.IsMatch(IdTB.Text) || numberValid.IsMatch(CaseNumberTB.Text) || CaseNumberTB.Text == "" || numberValid.IsMatch(CaseNumberTB.Text) || nameValid.IsMatch(NameTB.Text) || NameTB.Text == "" || nameValid.IsMatch(SurnameTB.Text) || SurnameTB.Text == "" || nameValid.IsMatch(PatronymicTB.Text) || PatronymicTB.Text == "")
                        {
                            MessageBox.Show("Id writed incorrect. Only numbers.");
                        }
                        else
                        {
                            Connection.Connector(judge.Update(IdTB.Text, CaseNumberTB.Text, NameTB.Text, SurnameTB.Text,PatronymicTB.Text));
                        }
                        break;
                    }
                case WhichForm.Plaintiff:
                    {
                        if (idValidation.IsMatch(IdTB.Text) || numberValid.IsMatch(CaseNumberTB.Text) || CaseNumberTB.Text == "" || numberValid.IsMatch(CaseNumberTB.Text) || nameValid.IsMatch(NameTB.Text) || NameTB.Text == "" || nameValid.IsMatch(SurnameTB.Text) || SurnameTB.Text == "" || nameValid.IsMatch(PatronymicTB.Text) || PatronymicTB.Text == "")
                        {
                            MessageBox.Show("Id writed incorrect. Only numbers.");
                        }
                        else
                        {
                            Connection.Connector(plaintiff.Update(IdTB.Text, CaseNumberTB.Text, NameTB.Text, SurnameTB.Text,PatronymicTB.Text));
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
            IdTB.Text = null;
            NameTB.Text = null;
            SurnameTB.Text = null;
            CaseNumberTB.Text = null;
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
                        Connection.Connector(displayer.dataGridView1, defendant.Display());
                        break;
                    }
                case WhichForm.Judge:
                    {
                        Connection.Connector(displayer.dataGridView1, judge.Display());
                        break;
                    }
                case WhichForm.Plaintiff:
                    {
                        Connection.Connector(displayer.dataGridView1, plaintiff.Display());
                        break;
                    }
            }
        }

       
    }
}
