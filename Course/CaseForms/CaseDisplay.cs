using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course
{
    public partial class CaseDisplay : Form
    {
        /// <summary>
        /// Обычный конструктор
        /// </summary>
        private CaseDisplay()
        {
            InitializeComponent();
            Connection.Connector(dataGridView1, @case.Display());
        }

        private static CaseDisplay caseDisplayNopar;

        public static CaseDisplay GetCaseDisplay()
        {
            if (caseDisplayNopar == null)
                caseDisplayNopar = new CaseDisplay();
            return caseDisplayNopar;
        }
        /// <summary>
        /// Конструктор для вывода по запросу
        /// </summary>
        private CaseDisplay(string query)
        {
            InitializeComponent();
            Off();
            Connection.Connector(dataGridView1, query);
        }

        private static CaseDisplay caseDisplayParam;

        public static CaseDisplay GetCaseDisplay(string query)
        {
            if (caseDisplayParam == null)
                caseDisplayParam = new CaseDisplay(query);
            return caseDisplayParam;
        }

        private Case @case = new Case();
        private CaseDisplay caseDisplay;

        private CaseEditing caseEditing;
        private Deleting deleting;

        private void Off()
        {
            textBox1.Hide();
            label1.Hide();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            label7.Hide();
            button1.Hide();
            button2.Hide();
            button3.Hide();
            button4.Hide();
            button5.Hide();
            button6.Hide();
            button7.Hide();
            statusStrip1.Hide();
            dataGridView1.Location = new Point(12, 25);
            Height = 220;
        }

        #region First inqurie
        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripStatusLabel1.Text = "Find all legal cases";
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            caseDisplay = new CaseDisplay(@case.First("-1"));
            caseDisplay.Show();
        }
        #endregion

        #region Second inqurie
        private void label2_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripStatusLabel1.Text = "Find cases which contains keyword";
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            caseDisplay = new CaseDisplay(@case.Second(textBox1.Text));
            caseDisplay.Show();
        }
        #endregion

        #region Third inqurie 
        private void label3_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripStatusLabel1.Text = "Find all cases of this article that you select";
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            caseDisplay = new CaseDisplay(@case.Third(dataGridView1.CurrentRow.Cells[5].Value.ToString()));
            caseDisplay.Show();
        }
        #endregion

        #region Fourth inqurie 
        private void label4_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripStatusLabel1.Text = "Find all unfinished cases";
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = null;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            caseDisplay = new CaseDisplay(@case.Fourth("-1"));
            caseDisplay.Show();
        }
        #endregion

        #region Fifth inqurie
        private void label5_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripStatusLabel1.Text = "Find all cases of selected judge";
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = null;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            caseDisplay = new CaseDisplay(@case.Fifth(dataGridView1.CurrentRow.Cells[3].Value.ToString()));
            caseDisplay.Show();
        }
        #endregion

        #region Sixt inqurie

        private void label6_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripStatusLabel1.Text = "Find all cases of selected plaintiff";
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = null;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            caseDisplay = new CaseDisplay(@case.Sixth(dataGridView1.CurrentRow.Cells[2].Value.ToString()));
            caseDisplay.Show();
        }
        #endregion

        #region Seventh inqurie
        private void label7_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripStatusLabel1.Text = "Find all cases of selected defendant";
        }

        private void label7_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = null;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            caseDisplay = new CaseDisplay(@case.Seventh(dataGridView1.CurrentRow.Cells[1].Value.ToString()));
            caseDisplay.Show();
        }
        #endregion

        private void CaseDisplay_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                e.Cancel = true;
            Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            caseEditing = CaseEditing.GetCaseEditing(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            caseEditing.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            deleting = new Deleting(WhichForm.Case, dataGridView1.CurrentRow.Cells[0].Value.ToString());
            deleting.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Connection.Connector(dataGridView1, @case.Display());
        }
    }
}
