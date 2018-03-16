using System.Windows.Forms;

namespace Course
{
    public partial class Displayer : Form
    {
        /// <summary>
        /// Обычный вывод
        /// </summary>
        public Displayer(WhichForm whichForm)
        {
            InitializeComponent();
            this.whichForm = whichForm;
            Design();
        }

        /// <summary>
        /// Конструктор для вывода с запросом
        /// </summary>
        public Displayer(WhichForm whichForm,string query)
        {
            InitializeComponent();
            this.whichForm = whichForm;
            Off();
            Design();
            Connection.Connector(dataGridView1, query);

        }

        /// <summary>
        /// Скрытие элементов управления для формы вывода
        /// </summary>
        private void Off()
        {
            button1.Hide();
            statusStrip1.Hide();
            label2.Hide();
            dataGridView1.Location = new System.Drawing.Point(12, 25);
            Height = 220;
        }

        private WhichForm whichForm;
        private Defendant defendant;
        private Plaintiff plaintiff;
        private Judge judge;
        private Case @case = new Case();
        private Displayer displayer;


        /// <summary>
        /// Дизайн формы
        /// </summary>
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
                default:
                    {
                        MessageBox.Show("NO FORM SELECTED");
                        Close();
                        break;
                    }
            }
        }

        private void label2_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripStatusLabel1.Text = "Find all "+whichForm.ToString().ToLower()+" cases of his id";
        }

        private void label2_MouseLeave(object sender, System.EventArgs e)
        {
            toolStripStatusLabel1.Text = null;
        }


        private void button1_Click(object sender, System.EventArgs e)
        {
            switch(whichForm)
            {
                case WhichForm.Judge:
                    {
                        displayer = new Displayer(whichForm, @case.Fifth(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
                        displayer.ShowDialog();
                        break;
                    }
                case WhichForm.Plaintiff:
                    {
                        displayer = new Displayer(whichForm, @case.Sixth(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
                        displayer.ShowDialog();
                        break;
                    }
                case WhichForm.Defendant:
                    {
                        displayer = new Displayer(whichForm, @case.Seventh(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
                        displayer.ShowDialog();
                        break;
                    }
            }
        }
    }
}
