using System.Text.RegularExpressions;
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

        private WhichForm whichForm;
        private Defendant defendant;
        private Plaintiff plaintiff;
        private Judge judge;
        private Case @case = new Case();
        private Regex idValidation = new Regex(@"\D");

        private Addition addition;
        private Editing editing;
        private Deleting deleting;


        /// <summary>
        /// Дизайн формы
        /// </summary>
        private void Design()
        {
            switch (whichForm)
            {
                case WhichForm.Defendant:
                    {
                        defendant = new Defendant();
                        Connection.Connector(dataGridView1, defendant.Display());
                        break;
                    }
                case WhichForm.Judge:
                    {
                        judge = new Judge();
                        Connection.Connector(dataGridView1, judge.Display());
                        break;
                    }
                case WhichForm.Plaintiff:
                    {
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
            label1.Text = whichForm.ToString();
            button2.Text = "Display all " + whichForm.ToString().ToLower();
            button3.Text = "Edit selected " + whichForm.ToString().ToLower();
            button5.Text = "Delete selected " + whichForm.ToString().ToLower();
        }

        private void RefreshData()
        {
            switch (whichForm)
            {
                case WhichForm.Judge:
                    {
                        Connection.Connector(dataGridView1, judge.Display());
                        break;
                    }
                case WhichForm.Plaintiff:
                    {
                        Connection.Connector(dataGridView1, plaintiff.Display());
                        break;
                    }
                case WhichForm.Defendant:
                    {
                        Connection.Connector(dataGridView1, defendant.Display());
                        break;
                    }
            }

            Width = 584;
            dataGridView1.Width = 543;
        }

        #region First inqurie 

        private void button1_Click(object sender, System.EventArgs e)
        {
            switch(whichForm)
            {
                case WhichForm.Judge:
                    {
                        Width = 1190;
                        dataGridView1.Width = 1143;
                        Connection.Connector(dataGridView1,@case.Fifth(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
                        break;
                    }
                case WhichForm.Plaintiff:
                    {
                        Width = 1190;
                        dataGridView1.Width = 1143;
                        Connection.Connector(dataGridView1, @case.Sixth(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
                        break;
                    }
                case WhichForm.Defendant:
                    {
                        Width = 1190;
                        dataGridView1.Width = 1143;
                        Connection.Connector(dataGridView1, @case.Seventh(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
                        break;
                    }
            }
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            button1.Height = 55;
            button1.Width = 155;
            label1.Text = "Find all " + whichForm.ToString().ToLower() + " cases of his id";
        }

        private void button1_MouseLeave(object sender, System.EventArgs e)
        {
            button1.Height = 50;
            button1.Width = 150;
            label1.Text = null;
        }

        #endregion

        #region Second inqurie

        private void button2_Click(object sender, System.EventArgs e)
        {
            RefreshData();
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            button2.Height = 55;
            button2.Width = 155;
            label2.Text = "Display all " + whichForm.ToString().ToLower() +"s";
        }

        private void button2_MouseLeave(object sender, System.EventArgs e)
        {
            button2.Height = 50;
            button2.Width = 150;
            label2.Text = null;
        }

        #endregion

        #region Third inqurie 

        private void button4_Click(object sender, System.EventArgs e)
        {
            if(idValidation.IsMatch(textBox1.Text) || textBox1.Text == "")
            {
                MessageBox.Show("Incorrect id format");
                textBox1.Text = null;
            }
            else
            {
                switch (whichForm)
                {
                    case WhichForm.Judge:
                    {
                        Connection.Connector(dataGridView1, judge.Search(textBox1.Text));
                        break;
                    }
                    case WhichForm.Plaintiff:
                    {
                        Connection.Connector(dataGridView1, plaintiff.Search(textBox1.Text));
                        break;
                    }
                    case WhichForm.Defendant:
                    {
                        Connection.Connector(dataGridView1, defendant.Search(textBox1.Text));
                        break;
                    }
                }
                 Width = 584;
                 dataGridView1.Width = 543;
            }
        }

        private void button4_MouseMove(object sender, MouseEventArgs e)
        {
            button4.Height = 55;
            button4.Width = 155;
            label3.Text = "Find " + whichForm.ToString().ToLower() + " by id";
        }

        private void button4_MouseLeave(object sender, System.EventArgs e)
        {
            button4.Height = 50;
            button4.Width = 150;
            label3.Text = null;
        }

        #endregion

        /// <summary>
        /// Edit selected
        /// </summary>
        private void button3_Click(object sender, System.EventArgs e)
        {
            editing = new Editing(whichForm, dataGridView1.CurrentRow.Cells[0].Value.ToString(),this);
            editing.ShowDialog();
        }

        private void button3_MouseMove(object sender, MouseEventArgs e)
        {
            button3.Height = 55;
            button3.Width = 155;
        }

        private void button3_MouseLeave(object sender, System.EventArgs e)
        {
            button3.Height = 50;
            button3.Width = 150;
        }

        /// <summary>
        /// Delete selected
        /// </summary>
        private void button5_Click(object sender, System.EventArgs e)
        {
            switch (whichForm)
            {
                case WhichForm.Judge:
                    {
                        Connection.Connector(judge.Delete(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
                        Connection.Connector(dataGridView1, judge.Display());
                        break;
                    }
                case WhichForm.Plaintiff:
                    {
                        Connection.Connector(plaintiff.Delete(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
                        Connection.Connector(dataGridView1, plaintiff.Display());
                        break;
                    }
                case WhichForm.Defendant:
                    {
                        Connection.Connector(defendant.Delete(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
                        Connection.Connector(dataGridView1, defendant.Display());
                        break;
                    }
            }
            RefreshData();
        }

        private void button5_MouseMove(object sender, MouseEventArgs e)
        {
            button5.Height = 55;
            button5.Width = 155;
        }

        private void button5_MouseLeave(object sender, System.EventArgs e)
        {
            button5.Height = 50;
            button5.Width = 150;
        }


        #region Form bottom

        /// <summary>
        /// Add
        /// </summary>
        private void button6_Click(object sender, System.EventArgs e)
        {
            addition = new Addition(whichForm,this);
            addition.ShowDialog();
        }

        /// <summary>
        /// Edit
        /// </summary>
        private void button7_Click(object sender, System.EventArgs e)
        {
            editing = new Editing(whichForm,this);
            editing.ShowDialog();
        }

        /// <summary>
        /// Delete
        /// </summary>
        private void button8_Click(object sender, System.EventArgs e)
        {
            deleting = new Deleting(whichForm,this);
            deleting.Show();
        }

        /// <summary>
        /// Close
        /// </summary>
        private void button9_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        #endregion
    }
}
