using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            Connection.Connector(dataGridView1, @case.Display(),cantDisp);
            deleting = new Deleting(WhichForm.Case, this);
        }

        private string deleteException = "CAN'T DELETE RELATED VALUES";
        private string searchException = "WRONG VALUE";
        private string nothingSel = "NOTHING IS SELECTED";
        private string cantDisp = "CHECK TABLE EXISTENCE";
        private string empty = "";

        private static CaseDisplay caseDisplay;
        /// <summary>
        /// Синглтон
        /// </summary>
        public static CaseDisplay GetCaseDisplay()
        {
            if (caseDisplay == null)
                caseDisplay = new CaseDisplay();
            return caseDisplay;
        }

        private Case @case = new Case();
        private Defendant defendant = new Defendant();
        private CaseAddition caseAddition;
        private CaseEditing caseEditing;
        private Deleting deleting;

        #region Zeroth inqurie
        private Regex fullnameValid = new Regex(@"\d");
        private void button15_Click(object sender, EventArgs e)
        {
            if(DbfTB.Text == "" || fullnameValid.IsMatch(DbfTB.Text))
            {
                MessageBox.Show("INCORRECT DATA FORMAT");
            }
            else
            {
                CreateTable();
                @case.FillDgv(dataGridView1, @case.Display(), @case.GetFio(defendant.Display(), DbfTB.Text.ToUpper()));
                DbfTB.Text = null;
            }
        }

        private void button15_MouseMove(object sender, MouseEventArgs e)
        {
            HelpDbf.Text = "Find all cases of defendant ordering by his fullname";
            DefendantByFullname.Height = 55;
            DefendantByFullname.Width = 155;
        }

        private void button15_MouseLeave(object sender, EventArgs e)
        {
            HelpDbf.Text = null;
            DefendantByFullname.Height = 50;
            DefendantByFullname.Width = 150;
        }

        private void CreateTable()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("0", "Id");
            dataGridView1.Columns.Add("1", "NumberDefendant");
            dataGridView1.Columns.Add("2", "PlaintiffNumber");
            dataGridView1.Columns.Add("3", "JudgeNumber");
            dataGridView1.Columns.Add("4", "Description");
            dataGridView1.Columns.Add("5", "Article");
            dataGridView1.Columns.Add("6", "DateOfStart");
            dataGridView1.Columns.Add("7", "DateOfEnd");
            dataGridView1.Columns.Add("8", "IsEnd");
            dataGridView1.Columns.Add("9", "IsUr");
            dataGridView1.Columns.Add("10", "Verdict");
        }
        #endregion

        #region First inqurie

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            HelpFl.Text = "Find all legal cases";
            FindLegal.Height = 55;
            FindLegal.Width = 155;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            HelpFl.Text = null;
            FindLegal.Height = 50;
            FindLegal.Width = 150;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            Connection.Connector(dataGridView1,@case.First("-1"),cantDisp);
        }

        #endregion

        #region Second inqurie

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            HelpFbk.Text = "Find cases which contains keyword";
            FindByKeyword.Height = 55;
            FindByKeyword.Width = 155;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            HelpFbk.Text = null;
            FindByKeyword.Height = 50;
            FindByKeyword.Width = 150;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(FindByKeywordTB.Text == "")
            {
                MessageBox.Show("Enter keyword first");
            }
            else
            {
                dataGridView1.Columns.Clear();
                Connection.Connector(dataGridView1, @case.Second(FindByKeywordTB.Text),cantDisp);
                FindByKeywordTB.Text = null;
            }
        }
        #endregion

        #region Third inqurie 

        private void button3_MouseMove(object sender, MouseEventArgs e)
        {
            HelpFba.Text = "Find all cases of article that you select";
            FindByArticle.Height = 55;
            FindByArticle.Width = 155;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            HelpFba.Text = null;
            FindByArticle.Height = 50;
            FindByArticle.Width = 150;
        }
        string art;
        private void button3_Click(object sender, EventArgs e)
        {
            art = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            try
            {
                dataGridView1.Columns.Clear();
                Connection.Connector(dataGridView1, @case.Display(), cantDisp);
                Connection.Connector(dataGridView1,@case.Third(art),cantDisp);
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("NO  DATA SELECTED");
            }
        }
        #endregion

        #region Fourth inqurie 

        private void button4_MouseMove(object sender, MouseEventArgs e)
        {
            HelpFa.Text = "Find all unfinished cases";
            FindActive.Height = 55;
            FindActive.Width = 155;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            HelpFa.Text = null;
            FindActive.Height = 50;
            FindActive.Width = 150;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Connection.Connector(dataGridView1,@case.Fourth("0"),cantDisp);
        }
        #endregion

        #region Fifth inqurie

        private void button5_MouseMove(object sender, MouseEventArgs e)
        {
            HelpJcl.Text = "Find all cases of selected judge";
            JudgeCaseList.Height = 55;
            JudgeCaseList.Width = 155;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            HelpJcl.Text = null;
            JudgeCaseList.Height = 50;
            JudgeCaseList.Width = 150;
        }
        string idJud;
        private void button5_Click(object sender, EventArgs e)
        {
            idJud = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            try
            {
                dataGridView1.Columns.Clear();
                Connection.Connector(dataGridView1, @case.Display(), cantDisp);
                Connection.Connector(dataGridView1,@case.Fifth(idJud),cantDisp);
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("NO  DATA SELECTED");
                Connection.Connector(@case.Display(), cantDisp);
            }
        }
        #endregion

        #region Sixt inqurie

        private void button6_MouseMove(object sender, MouseEventArgs e)
        {
            HelpPcl.Text = "Find all cases of selected plaintiff";
            PlaintiffCaseList.Height = 55;
            PlaintiffCaseList.Width = 155;
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            HelpPcl.Text = null;
            PlaintiffCaseList.Height = 50;
            PlaintiffCaseList.Width = 150;
        }
        string idPla;
        private void button6_Click(object sender, EventArgs e)
        {
            idPla = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            try
            {
                dataGridView1.Columns.Clear();
                Connection.Connector(dataGridView1, @case.Display(), cantDisp);
                Connection.Connector(dataGridView1, @case.Sixth(idPla),cantDisp);
            }
            catch(NullReferenceException ex)
            {
                MessageBox.Show("NO  DATA SELECTED");
                Connection.Connector(@case.Display(), cantDisp);
            }
        }
        #endregion

        #region Seventh inqurie

        private void button7_MouseMove(object sender, MouseEventArgs e)
        {
            HelpDcl.Text = "Find all cases of selected defendant";
            DefendantCaseList.Height = 55;
            DefendantCaseList.Width = 155;
        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {
            HelpDcl.Text = null;
            DefendantCaseList.Height = 50;
            DefendantCaseList.Width = 150;
        }
        string idDef;
        private void button7_Click(object sender, EventArgs e)
        {
             idDef = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            try
            {
                dataGridView1.Columns.Clear();
                Connection.Connector(dataGridView1, @case.Display(), cantDisp);
                Connection.Connector(dataGridView1,@case.Seventh(idDef),cantDisp);
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("NO  DATA SELECTED");
                Connection.Connector(@case.Display(), cantDisp);
            }

        }
        #endregion

        #region Delete Edit Display

        /// <summary>
        /// Обновление
        /// </summary>
        private void button11_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            Connection.Connector(dataGridView1, @case.Display(),cantDisp);
        }

        /// <summary>
        /// Редактирование выбранного дела
        /// </summary>
        private void button8_Click(object sender, EventArgs e)
        {
           try
            {
                caseEditing = new CaseEditing(this,dataGridView1.CurrentRow.Cells[0].Value.ToString(), dataGridView1.CurrentRow.Cells[4].Value.ToString(), dataGridView1.CurrentRow.Cells[5].Value.ToString(), dataGridView1.CurrentRow.Cells[10].Value.ToString());
                caseEditing.ShowDialog();
            }
            catch(NullReferenceException ex)
            {
                MessageBox.Show("NO  DATA SELECTED");
            }
        }

        /// <summary>
        /// Удаление выбраного дела
        /// </summary>
        string del;
         private void button9_Click(object sender, EventArgs e)
         {
            del = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            try
            {
                dataGridView1.Columns.Clear();
                Connection.Connector(dataGridView1, @case.Display(),cantDisp);
                Connection.Connector(@case.Delete(del),cantDisp);
                Connection.Connector(dataGridView1, @case.Display(),cantDisp);
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("NO  DATA SELECTED");
            }
        }

        private void button9_MouseMove(object sender, MouseEventArgs e)
        {
            DeleteSelectedCase.Height = 105;
            DeleteSelectedCase.Width = 405;
        }

        private void button9_MouseLeave(object sender, EventArgs e)
        {
            DeleteSelectedCase.Height = 100;
            DeleteSelectedCase.Width = 400;
        }

        private void button8_MouseMove(object sender, MouseEventArgs e)
        {
            EditSelected.Height = 105;
            EditSelected.Width = 405;
        }

        private void button8_MouseLeave(object sender, EventArgs e)
        {
            EditSelected.Height = 100;
            EditSelected.Width = 400;
        }

        private void button11_MouseMove(object sender, MouseEventArgs e)
        {
            DisplayAll.Height = 105;
            DisplayAll.Width = 405;
        }

        private void button11_MouseLeave(object sender, EventArgs e)
        {
            DisplayAll.Height = 100;
            DisplayAll.Width = 400;
        }
        #endregion

        /// <summary>
        /// Предотвращение ошибки null reference
        /// </summary>
        private void CaseDisplay_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                e.Cancel = true;
            Hide();
        }

        /// <summary>
        /// Добавление выделенного в Rich TB
        /// </summary>
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
            richTextBox1.Text = dataGridView1[e.ColumnIndex, e.RowIndex].Value.ToString();
            }
            catch(Exception ex)
            { }
        }

        #region Form bottom

        /// <summary>
        /// Добавление
        /// </summary>
        private void button12_Click(object sender, EventArgs e)
        {
            caseAddition = CaseAddition.GetCaseAddition(this);
            caseAddition.ShowDialog();
        }

        private void button12_MouseMove(object sender, MouseEventArgs e)
        {
            AddCase.Height = 115;
            AddCase.Width = 305;
        }

        private void button12_MouseLeave(object sender, EventArgs e)
        {
            AddCase.Height = 110;
            AddCase.Width = 300;
        }

        /// <summary>
        /// Редактирование
        /// </summary>
        private void button13_Click(object sender, EventArgs e)
        {
            caseEditing = CaseEditing.GetCaseEditingNoparam(this);
            caseEditing.ShowDialog();
        }

        private void button13_MouseMove(object sender, MouseEventArgs e)
        {
            EditCase.Height = 115;
            EditCase.Width = 305;
        }

        private void button13_MouseLeave(object sender, EventArgs e)
        {
            EditCase.Height = 110;
            EditCase.Width = 300;
        }

        /// <summary>
        /// Удаление 
        /// </summary>
        private void button14_Click(object sender, EventArgs e)
        {
            deleting.ShowDialog();
        }

        private void button14_MouseMove(object sender, MouseEventArgs e)
        {
            DeleteCase.Height = 115;
            DeleteCase.Width = 305;
        }

        private void button14_MouseLeave(object sender, EventArgs e)
        {
            DeleteCase.Height = 110;
            DeleteCase.Width = 300;
        }

        /// <summary>
        /// Закрытие
        /// </summary>
        private void button10_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button10_MouseMove(object sender, MouseEventArgs e)
        {
            Close.Height = 115;
            Close.Width = 305;
        }

        private void button10_MouseLeave(object sender, EventArgs e)
        {
            Close.Height = 110;
            Close.Width = 300;
        }
        #endregion

    }
}
