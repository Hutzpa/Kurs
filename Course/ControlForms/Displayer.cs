using System.Windows.Forms;

namespace Course
{
    public partial class Displayer : Form
    {
        public Displayer(WhichForm whichForm)
        {
            InitializeComponent();
            this.whichForm = whichForm;
            Design();
        }


        WhichForm whichForm;
        Defendant defendant;
        Plaintiff plaintiff;
        Judge judge;
        Case @case;

        private void Design()
        {
            switch (whichForm)
            {
                case WhichForm.Defendant:
                    {
                        label1.Text = "Defendants";
                        defendant = new Defendant();
                        Connection.Connector(dataGridView1, defendant.Display());
                        break;
                    }
                case WhichForm.Judge:
                    {
                        label1.Text = "Judges";
                        judge = new Judge();
                        Connection.Connector(dataGridView1, judge.Display());
                        break;
                    }
                case WhichForm.Plaintiff:
                    {
                        label1.Text = "Plaintiffs";
                        plaintiff = new Plaintiff();
                        Connection.Connector(dataGridView1, plaintiff.Display());
                        break;
                    }
                case WhichForm.Case:
                    {
                        label1.Text = "Casaes";
                        @case = new Case();
                        dataGridView1.Width = 943;
                        Width = 980;
                        Connection.Connector(dataGridView1, @case.Display());
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
