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
            Greeting();
        }
        private Addition addition;
        private Deleting deleting;
        private Editing editing;
        private Search search;
        private Displayer displayer;

        private CaseDisplay caseDisplay;

        #region Judge
        private void addNewJudgeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addition = new Addition(WhichForm.Judge);
            addition.ShowDialog();
        }

        private void findJudgeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            search = new Search(WhichForm.Judge);
            search.ShowDialog();
        }

        private void deleteJudgeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deleting = new Deleting(WhichForm.Judge);
            deleting.ShowDialog();
        }

        private void editJudgeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editing = new Editing(WhichForm.Judge);
            editing.ShowDialog();
        }

        private void displayJudgesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            displayer = new Displayer(WhichForm.Judge);
            displayer.ShowDialog();
        }

        #endregion

        #region Plaintiff
        private void addNewPlaintiffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addition = new Addition(WhichForm.Plaintiff);
            addition.ShowDialog();
        }

        private void findPlaintiffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            search = new Search(WhichForm.Plaintiff);
            search.ShowDialog();
        }

        private void editPlaintiffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editing = new Editing(WhichForm.Plaintiff);
            editing.ShowDialog();
        }

        private void deletePlaintiffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deleting = new Deleting(WhichForm.Plaintiff);
            deleting.ShowDialog();
        }

        private void displayPlaintiffsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            displayer = new Displayer(WhichForm.Plaintiff);
            displayer.ShowDialog();
        }

        #endregion

        #region Defendant
        private void addNewDefendantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addition = new Addition(WhichForm.Defendant);
            addition.ShowDialog();
        }

        private void findDefendantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            search = new Search(WhichForm.Defendant);
            search.ShowDialog();
        }

        private void editDefendantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editing = new Editing(WhichForm.Defendant);
            editing.ShowDialog();
        }

        private void deleteDefendantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deleting = new Deleting(WhichForm.Defendant);
            deleting.ShowDialog();
        }

        private void displayDefendantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            displayer = new Displayer(WhichForm.Defendant);
            displayer.ShowDialog();
        }

        #endregion

     

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
    }
}
