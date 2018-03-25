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
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
            //Greeting();
        }

        private CaseDisplay caseDisplay;
        private Displayer displayer;

        private void Greeting()
        {
            MessageBox.Show(@"............/´¯/)...............(\¯`\
.........../...//....БАЗА...\\...\
........../...//....ДАННЫХ...\\...\
...../´¯/..../´¯\.СУДА..../¯` \....\¯`\
.././.../..../..../.| _......._ |.\....\....\...\.\
(.(....(....(..../..)..)…...(..(.\....)....)....).)
.\................\/.../......\...\/................/
..\.................. /.........\................../ ");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            caseDisplay = CaseDisplay.GetCaseDisplay();
            caseDisplay.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            displayer = new Displayer(WhichForm.Judge);
            displayer.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            displayer = new Displayer(WhichForm.Plaintiff);
            displayer.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            displayer = new Displayer(WhichForm.Defendant);
            displayer.ShowDialog();
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            label1.Text = "Case";
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            label1.Text = null;
        }

        private void button5_MouseMove(object sender, MouseEventArgs e)
        {
            label1.Text = "Defendant";
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            label1.Text = null;
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            label1.Text = "Close";
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            label1.Text = null;
        }

        private void button4_MouseMove(object sender, MouseEventArgs e)
        {
            label1.Text = "Plaintiff";
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            label1.Text = null;
        }

        private void button3_MouseMove(object sender, MouseEventArgs e)
        {
            label1.Text = "Judge";
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            label1.Text = null;
        }
    }
}
