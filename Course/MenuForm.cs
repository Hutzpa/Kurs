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

        #region Judge
        private void addNewJudgeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addition = new Addition(WhichForm.Judge);
            addition.Show();
        }

        private void findJudgeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            search = new Search(WhichForm.Judge);
            search.Show();
        }

        private void deleteJudgeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deleting = new Deleting(WhichForm.Judge);
            deleting.Show();
        }

        private void editJudgeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editing = new Editing(WhichForm.Judge);
            editing.Show();
        }

        private void displayJudgesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            displayer = new Displayer(WhichForm.Judge);
            displayer.Show();
        }

        #endregion

        #region Plaintiff
        private void addNewPlaintiffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addition = new Addition(WhichForm.Plaintiff);
            addition.Show();
        }

        private void findPlaintiffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            search = new Search(WhichForm.Plaintiff);
            search.Show();
        }

        private void editPlaintiffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editing = new Editing(WhichForm.Plaintiff);
            editing.Show();
        }

        private void deletePlaintiffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deleting = new Deleting(WhichForm.Plaintiff);
            deleting.Show();
        }

        private void displayPlaintiffsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            displayer = new Displayer(WhichForm.Plaintiff);
            displayer.Show();
        }

        #endregion

        #region Defendant
        private void addNewDefendantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addition = new Addition(WhichForm.Defendant);
            addition.Show();
        }

        private void findDefendantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            search = new Search(WhichForm.Defendant);
            search.Show();
        }

        private void editDefendantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editing = new Editing(WhichForm.Defendant);
            editing.Show();
        }

        private void deleteDefendantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deleting = new Deleting(WhichForm.Defendant);
            deleting.Show();
        }

        private void displayDefendantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            displayer = new Displayer(WhichForm.Defendant);
            displayer.Show();
        }

        #endregion

        #region Case 
        private CaseAddition caseAddition;
        private CaseEditing caseEditing;
        private CaseSearch caseSearch;

        private void addNewCaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            caseAddition = CaseAddition.GetCaseAddition();
            caseAddition.Show();
        }

        private void editCaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            caseEditing = CaseEditing.GetCaseEditing();
            caseEditing.Show();
        }

        private void deleteCaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deleting = new Deleting(WhichForm.Case);
            deleting.Show();
        }

        private void displayCasesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            displayer = new Displayer(WhichForm.Case);
            displayer.Show();
        }

        #region Case inquire
        private void listOfLegalCasesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            caseSearch = CaseSearch.GetCaseSearch(WhichInquiry.First);
            caseSearch.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            caseSearch = CaseSearch.GetCaseSearch(WhichInquiry.Second);
            caseSearch.Show();
        }

        private void caseInArticleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            caseSearch = CaseSearch.GetCaseSearch(WhichInquiry.Third);
            caseSearch.Show();
        }

        private void activeCaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            caseSearch = CaseSearch.GetCaseSearch(WhichInquiry.Fourth);
            caseSearch.Show();
        }

        private void judgeCaseListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            caseSearch = CaseSearch.GetCaseSearch(WhichInquiry.Fifth);
            caseSearch.Show();
        }

        private void plaintiffCaseListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            caseSearch = CaseSearch.GetCaseSearch(WhichInquiry.Sixth);
            caseSearch.Show();
        }

        private void defendantCaseListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            caseSearch = CaseSearch.GetCaseSearch(WhichInquiry.Seventh);
            caseSearch.Show();
        }
        #endregion

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
    }
}
