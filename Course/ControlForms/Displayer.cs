using System;
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

        private string deleteException = "CAN'T DELETE RELATED VALUES";
        private string searchException = "WRONG VALUE";
        private string nothingSel = "NOTHING IS SELECTED";
        private string cantDisp = "CHECK TABLE EXISTENCE";

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
                        Connection.Connector(dataGridView1, defendant.Display(), cantDisp);
                        break;
                    }
                case WhichForm.Judge:
                    {
                        judge = new Judge();
                        Connection.Connector(dataGridView1, judge.Display(), cantDisp);
                        break;
                    }
                case WhichForm.Plaintiff:
                    {
                        plaintiff = new Plaintiff();
                        Connection.Connector(dataGridView1, plaintiff.Display(), cantDisp);
                        break;
                    }
                default:
                    {
                        MessageBox.Show("NO FORM SELECTED");
                        Close();
                        break;
                    }
            }
            HelpFac.Text = whichForm.ToString();
            DisplayAll.Text = "Display all " + whichForm.ToString().ToLower();
            EditSelected.Text = "Edit selected " + whichForm.ToString().ToLower();
            DeleteSelected.Text = "Delete selected " + whichForm.ToString().ToLower();
        }

        private void RefreshData()
        {
            switch (whichForm)
            {
                case WhichForm.Judge:
                    {
                        Connection.Connector(dataGridView1, judge.Display(), cantDisp);
                        break;
                    }
                case WhichForm.Plaintiff:
                    {
                        Connection.Connector(dataGridView1, plaintiff.Display(), cantDisp);
                        break;
                    }
                case WhichForm.Defendant:
                    {
                        Connection.Connector(dataGridView1, defendant.Display(), cantDisp);
                        break;
                    }
            }

            Width = 679;
            dataGridView1.Width = 643;
        }

        #region First inqurie 

        private void button1_Click(object sender, System.EventArgs e)
        {
            try
            {
            switch(whichForm)
            {
                case WhichForm.Judge:
                    {
                        Width = 1190;
                        dataGridView1.Width = 1143;
                        Connection.Connector(dataGridView1,@case.Fifth(dataGridView1.CurrentRow.Cells[0].Value.ToString()), nothingSel);
                        break;
                    }
                case WhichForm.Plaintiff:
                    {
                        Width = 1190;
                        dataGridView1.Width = 1143;
                        Connection.Connector(dataGridView1, @case.Sixth(dataGridView1.CurrentRow.Cells[0].Value.ToString()), nothingSel);
                        break;
                    }
                case WhichForm.Defendant:
                    {
                        Width = 1190;
                        dataGridView1.Width = 1143;
                        Connection.Connector(dataGridView1, @case.Seventh(dataGridView1.CurrentRow.Cells[0].Value.ToString()), nothingSel);
                        break;
                    }
            }
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("NO  DATA SELECTED");
            }
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            FindAllCases.Height = 55;
            FindAllCases.Width = 155;
            HelpFac.Text = "Find all " + whichForm.ToString().ToLower() + " cases of his id";
        }

        private void button1_MouseLeave(object sender, System.EventArgs e)
        {
            FindAllCases.Height = 50;
            FindAllCases.Width = 150;
            HelpFac.Text = null;
        }

        #endregion

        #region Second inqurie

        private void button2_Click(object sender, System.EventArgs e)
        {
            RefreshData();
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            DisplayAll.Height = 55;
            DisplayAll.Width = 155;
            HelpDa.Text = "Display all " + whichForm.ToString().ToLower() +"s";
        }

        private void button2_MouseLeave(object sender, System.EventArgs e)
        {
            DisplayAll.Height = 50;
            DisplayAll.Width = 150;
            HelpDa.Text = null;
        }

        #endregion

        #region Third inqurie 

        private void button4_Click(object sender, System.EventArgs e)
        {
            if(idValidation.IsMatch(IdTextBox.Text) || IdTextBox.Text == "")
            {
                MessageBox.Show("Incorrect id format");
                IdTextBox.Text = null;
            }
            else
            {
                switch (whichForm)
                {
                    case WhichForm.Judge:
                    {
                        Connection.Connector(dataGridView1, judge.Search(IdTextBox.Text), searchException);
                        break;
                    }
                    case WhichForm.Plaintiff:
                    {
                        Connection.Connector(dataGridView1, plaintiff.Search(IdTextBox.Text), searchException);
                        break;
                    }
                    case WhichForm.Defendant:
                    {
                        Connection.Connector(dataGridView1, defendant.Search(IdTextBox.Text), searchException);
                        break;
                    }
                }
                 Width = 679;
                 dataGridView1.Width = 643;
            }
        }

        private void button4_MouseMove(object sender, MouseEventArgs e)
        {
            FindById.Height = 55;
            FindById.Width = 155;
            HelpFbi.Text = "Find " + whichForm.ToString().ToLower() + " by id";
        }

        private void button4_MouseLeave(object sender, System.EventArgs e)
        {
            FindById.Height = 50;
            FindById.Width = 150;
            HelpFbi.Text = null;
        }

        #endregion

        /// <summary>
        /// Edit selected
        /// </summary>
        private void button3_Click(object sender, System.EventArgs e)
        {
            try
            {
            editing = new Editing(whichForm, dataGridView1.CurrentRow.Cells[1].Value.ToString(),this);
            editing.ShowDialog();
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("NO  DATA SELECTED");
            }
        }

        private void button3_MouseMove(object sender, MouseEventArgs e)
        {
            EditSelected.Height = 55;
            EditSelected.Width = 155;
        }

        private void button3_MouseLeave(object sender, System.EventArgs e)
        {
            EditSelected.Height = 50;
            EditSelected.Width = 150;
        }

        /// <summary>
        /// Delete selected
        /// </summary>
        private void button5_Click(object sender, System.EventArgs e)
        {
            try
            {
            switch (whichForm)
            {
                case WhichForm.Judge:
                    {
                        Connection.Connector(judge.Delete(dataGridView1.CurrentRow.Cells[0].Value.ToString()), deleteException);
                        Connection.Connector(dataGridView1, judge.Display(), deleteException);
                        break;
                    }
                case WhichForm.Plaintiff:
                    {
                        Connection.Connector(plaintiff.Delete(dataGridView1.CurrentRow.Cells[0].Value.ToString()), deleteException);
                        Connection.Connector(dataGridView1, plaintiff.Display(), deleteException);
                        break;
                    }
                case WhichForm.Defendant:
                    {
                        Connection.Connector(defendant.Delete(dataGridView1.CurrentRow.Cells[0].Value.ToString()), deleteException);
                        Connection.Connector(dataGridView1, defendant.Display(), deleteException);
                        break;
                    }
            }
            RefreshData();
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("NO  DATA SELECTED");
            }
        }

        private void button5_MouseMove(object sender, MouseEventArgs e)
        {
            DeleteSelected.Height = 55;
            DeleteSelected.Width = 155;
        }

        private void button5_MouseLeave(object sender, System.EventArgs e)
        {
            DeleteSelected.Height = 50;
            DeleteSelected.Width = 150;
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
