using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Course
{
    public partial class Addition : Form
    {

        public Addition(WhichForm whichForm,Displayer displayer)
        {
            InitializeComponent();
            this.whichForm = whichForm;
            this.displayer = displayer;
            Design();
        }
        private Displayer displayer;

        private WhichForm whichForm;
        private Defendant defendant;
        private Judge judge;
        private Plaintiff plaintiff;
        private Regex numberValid = new Regex(@"\D");
        private Regex nameValid = new Regex(@"\d");


        private void Design()
        {
            switch (whichForm)
            {
                case WhichForm.Defendant:
                    {
                        Text = "Defendant addition";
                        defendant = new Defendant();
                        break;
                    }
                case WhichForm.Judge:
                    {
                        Text = "Judge addition";
                        judge = new Judge();
                        break;
                    }
                case WhichForm.Plaintiff:
                    {
                        Text = "Plaintiff addition";
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

        private ToolTip tipCTB = new ToolTip() { InitialDelay = 1 };
        private ToolTip tipNTB = new ToolTip() { InitialDelay = 1 };
        private ToolTip tipSTB = new ToolTip() { InitialDelay = 1 };
        private ToolTip tipPTB = new ToolTip() { InitialDelay = 1 };

        private void Addition_Load(object sender, EventArgs e)
        {
            tipCTB.SetToolTip(CaseNumberTB, "Allows to enter only numbers, if case is not created yet, left this field empty");
            tipNTB.SetToolTip(NameTB, "Allows to enter only letters,write name here");
            tipSTB.SetToolTip(SurnameTB, "Allows to enter only letters, write surname here");
            tipPTB.SetToolTip(PatronymicTB, "Allows to enter only letters, write patronymic here");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (whichForm)
            {
                case WhichForm.Defendant:
                    {
                        if( numberValid.IsMatch(CaseNumberTB.Text) || nameValid.IsMatch(NameTB.Text) || NameTB.Text == "" || nameValid.IsMatch(SurnameTB.Text) || SurnameTB.Text == "" ||  nameValid.IsMatch(PatronymicTB.Text) || PatronymicTB.Text == "")
                        {
                            MessageBox.Show("Id writed incorrect. Only numbers.");
                        }
                        else
                        {
                            Connection.Connector(defendant.Insert(CaseNumberTB.Text, NameTB.Text, SurnameTB.Text, PatronymicTB.Text));
                        }
                        break;
                    }
                case WhichForm.Judge:
                    {
                        if (CaseNumberTB.Text == "" || numberValid.IsMatch(CaseNumberTB.Text) || nameValid.IsMatch(NameTB.Text) || NameTB.Text == "" || nameValid.IsMatch(SurnameTB.Text) || SurnameTB.Text == "" || nameValid.IsMatch(PatronymicTB.Text) || PatronymicTB.Text == "")
                        {
                            MessageBox.Show("Id writed incorrect. Only numbers.");
                        }
                        else
                        {
                            Connection.Connector(judge.Insert(CaseNumberTB.Text, NameTB.Text, SurnameTB.Text,PatronymicTB.Text));
                        }
                        break;
                    }
                case WhichForm.Plaintiff:
                    {
                        if (CaseNumberTB.Text == "" || numberValid.IsMatch(CaseNumberTB.Text) || nameValid.IsMatch(NameTB.Text) || NameTB.Text == "" || nameValid.IsMatch(SurnameTB.Text) || SurnameTB.Text == "" || nameValid.IsMatch(PatronymicTB.Text) || PatronymicTB.Text == "")
                        {
                            MessageBox.Show("Id writed incorrect. Only numbers.");
                        }
                        else
                        {
                            Connection.Connector(plaintiff.Insert(CaseNumberTB.Text, NameTB.Text, SurnameTB.Text, PatronymicTB.Text));
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
            CaseNumberTB.Text = null;
            PatronymicTB.Text = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
            Close();
        }

        private void Addition_FormClosing(object sender, FormClosingEventArgs e)
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
                default:
                    {
                        MessageBox.Show("NO FORM SELECTED");
                        Close();
                        break;
                    }
            }
        }

       
    }
}
