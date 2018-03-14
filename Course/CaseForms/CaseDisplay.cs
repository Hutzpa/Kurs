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
        public CaseDisplay()
        {
            InitializeComponent();
            Connection.Connector(dataGridView1, @case.Display());
        }

        public CaseDisplay(string query)
        {
            InitializeComponent();
            Connection.Connector(dataGridView1, query);
        }


        private Case @case = new Case();
        private CaseDisplay caseDisplay;


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
            caseDisplay = new CaseDisplay(@case.First(0 + ""));
            caseDisplay.Show();
        }

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
            caseDisplay = new CaseDisplay(@case.Third(dataGridView1.CurrentRow.Cells[6].Value.ToString()));
            caseDisplay.Show();
        }

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
            caseDisplay = new CaseDisplay(@case.Fifth(dataGridView1.CurrentRow.Cells[4].Value.ToString()));
            caseDisplay.Show();
        }

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
            caseDisplay = new CaseDisplay(@case.Sixth(dataGridView1.CurrentRow.Cells[3].Value.ToString()));
            caseDisplay.Show();
        }

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
            caseDisplay = new CaseDisplay(@case.Seventh(dataGridView1.CurrentRow.Cells[2].Value.ToString()));
            caseDisplay.Show();
        }
    }
}
