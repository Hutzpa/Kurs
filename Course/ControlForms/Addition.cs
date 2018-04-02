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

        private string cantDisp = "CHECK TABLE EXISTENCE";


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

        private ToolTip tip = new ToolTip() { InitialDelay = 1 };
      
        private void Addition_Load(object sender, EventArgs e)
        {
            tip.SetToolTip(IdCB, "Allows to enter only numbers, if case is not created yet, left this field empty");
            tip.SetToolTip(NameTB, "Allows to enter only letters,write name here");
            tip.SetToolTip(SurnameTB, "Allows to enter only letters, write surname here");
            tip.SetToolTip(PatronymicTB, "Allows to enter only letters, write patronymic here");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (whichForm)
            {
                case WhichForm.Defendant:
                    {
                        if( numberValid.IsMatch(IdCB.Text) || nameValid.IsMatch(NameTB.Text) || NameTB.Text == "" || nameValid.IsMatch(SurnameTB.Text) || SurnameTB.Text == "" ||  nameValid.IsMatch(PatronymicTB.Text) || PatronymicTB.Text == "")
                        {
                            MessageBox.Show("Id writed incorrect. Only numbers.");
                        }
                        else
                        {
                            Connection.Connector(defendant.Insert(IdCB.Text, NameTB.Text, SurnameTB.Text, PatronymicTB.Text), cantDisp);
                        }
                        break;
                    }
                case WhichForm.Judge:
                    {
                        if ( numberValid.IsMatch(IdCB.Text) || nameValid.IsMatch(NameTB.Text) || NameTB.Text == "" || nameValid.IsMatch(SurnameTB.Text) || SurnameTB.Text == "" || nameValid.IsMatch(PatronymicTB.Text) || PatronymicTB.Text == "")
                        {
                            MessageBox.Show("Id writed incorrect. Only numbers.");
                        }
                        else
                        {
                            Connection.Connector(judge.Insert(IdCB.Text, NameTB.Text, SurnameTB.Text,PatronymicTB.Text), cantDisp);
                        }
                        break;
                    }
                case WhichForm.Plaintiff:
                    {
                        if (numberValid.IsMatch(IdCB.Text) || nameValid.IsMatch(NameTB.Text) || NameTB.Text == "" || nameValid.IsMatch(SurnameTB.Text) || SurnameTB.Text == "" || nameValid.IsMatch(PatronymicTB.Text) || PatronymicTB.Text == "")
                        {
                            MessageBox.Show("Id writed incorrect. Only numbers.");
                        }
                        else
                        {
                            Connection.Connector(plaintiff.Insert(IdCB.Text, NameTB.Text, SurnameTB.Text, PatronymicTB.Text), cantDisp);
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
                        Connection.Connector(displayer.dataGridView1, defendant.Display(), cantDisp);
                        break;
                    }
                case WhichForm.Judge:
                    {
                        Connection.Connector(displayer.dataGridView1, judge.Display(), cantDisp);
                        break;
                    }
                case WhichForm.Plaintiff:
                    {
                        Connection.Connector(displayer.dataGridView1, plaintiff.Display(), cantDisp);
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

        private void Addition_Activated(object sender, EventArgs e)
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
            }
        }
    }
}
