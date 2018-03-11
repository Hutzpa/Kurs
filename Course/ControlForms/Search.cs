using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Course
{
    public partial class Search : Form
    {
        public Search(WhichForm whichForm)
        {
            InitializeComponent();
            this.whichForm = whichForm;
            Design();
        }

        private WhichForm whichForm;
        private Defendant defendant;
        private Plaintiff plaintiff;
        private Judge judge;
        private Regex idValidation = new Regex(@"\D");

        private void Design()
        {
            switch(whichForm)
            {
                case WhichForm.Defendant:
                    {
                        Text = "Defendant search";
                        defendant = new Defendant();
                        break;
                    }
                case WhichForm.Judge:
                    {
                        Text = "Judge search";
                        judge = new Judge();
                        break;
                    }
                case WhichForm.Plaintiff:
                    {
                        Text = "Plaintiff search";
                        plaintiff = new Plaintiff();
                        break;
                    }
                default:
                    {
                        MessageBox.Show("NO FORM SELECTED");
                        this.Close();
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
                        if (idValidation.IsMatch(textBox1.Text))
                        {
                            MessageBox.Show("Id writed incorrect. Only numbers.");
                        }
                        else
                        {
                            Connection.Connector(dataGridView1, defendant.Search(textBox1.Text));
                        }
                        break;
                    }
                case WhichForm.Judge:
                    {
                        if (idValidation.IsMatch(textBox1.Text))
                        {
                            MessageBox.Show("Id writed incorrect. Only numbers.");
                        }
                        else
                        {
                            Connection.Connector(dataGridView1, judge.Search(textBox1.Text));
                        }
                        break;
                    }
                case WhichForm.Plaintiff:
                    {
                        if (idValidation.IsMatch(textBox1.Text))
                        {
                            MessageBox.Show("Id writed incorrect. Only numbers.");
                        }
                        else
                        {
                            Connection.Connector(dataGridView1, plaintiff.Search(textBox1.Text));
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

            textBox1.Text = null;
        }
    }
}
