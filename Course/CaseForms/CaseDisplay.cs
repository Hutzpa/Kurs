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
        /// <summary>
        /// Синглтон
        /// </summary>
        public static CaseDisplay GetCaseDisplay()
        {
            if (caseDisplayNopar == null)
                caseDisplayNopar = new CaseDisplay();
            return caseDisplayNopar;
        }

        private Case @case = new Case();
        private CaseAddition caseAddition;
        private CaseEditing caseEditing;
        private Deleting deleting = new Deleting(WhichForm.Case,caseDisplayNopar);

        #region Zeroth inqurie

        private void button15_Click(object sender, EventArgs e)
        {
            if(textBox2.Text == "")
            {
                MessageBox.Show("Enter fullname first");
            }
            else
            {
                Connection.Connector(dataGridView1, @case.Zero(textBox2.Text));
                Clipboard.SetText(textBox2.Text);
                textBox2.Text = null;
            }
        }

        private void button15_MouseMove(object sender, MouseEventArgs e)
        {
            label8.Text = "Find all cases of defendant ordering by his fullname";
            button15.Height = 55;
            button15.Width = 155;
        }

        private void button15_MouseLeave(object sender, EventArgs e)
        {
            label8.Text = null;
            button15.Height = 50;
            button15.Width = 150;
        }

        #endregion

        #region First inqurie

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            label1.Text = "Find all legal cases";
            button1.Height = 55;
            button1.Width = 155;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            label1.Text = null;
            button1.Height = 50;
            button1.Width = 150;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Connection.Connector(dataGridView1,@case.First("-1"));
        }

        #endregion

        #region Second inqurie

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            label2.Text = "Find cases which contains keyword";
            button2.Height = 55;
            button2.Width = 155;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            label2.Text = null;
            button2.Height = 50;
            button2.Width = 150;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                MessageBox.Show("Enter keyword first");
            }
            else
            {
                Connection.Connector(dataGridView1, @case.Second(textBox1.Text));
                Clipboard.SetText(textBox1.Text);
                textBox1.Text = null;
            }
        }
        #endregion

        #region Third inqurie 

        private void button3_MouseMove(object sender, MouseEventArgs e)
        {
            label3.Text = "Find all cases of article that you select";
            button3.Height = 55;
            button3.Width = 155;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            label3.Text = null;
            button3.Height = 50;
            button3.Width = 150;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
            Connection.Connector(dataGridView1,@case.Third(dataGridView1.CurrentRow.Cells[5].Value.ToString()));
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
            label4.Text = "Find all unfinished cases";
            button4.Height = 55;
            button4.Width = 155;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            label4.Text = null;
            button4.Height = 50;
            button4.Width = 150;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Connection.Connector(dataGridView1,@case.Fourth("-1"));
        }
        #endregion

        #region Fifth inqurie

        private void button5_MouseMove(object sender, MouseEventArgs e)
        {
            label5.Text = "Find all cases of selected judge";
            button5.Height = 55;
            button5.Width = 155;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            label5.Text = null;
            button5.Height = 50;
            button5.Width = 150;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
            Connection.Connector(dataGridView1,@case.Fifth(dataGridView1.CurrentRow.Cells[3].Value.ToString()));
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("NO  DATA SELECTED");
            }
        }
        #endregion

        #region Sixt inqurie

        private void button6_MouseMove(object sender, MouseEventArgs e)
        {
            label6.Text = "Find all cases of selected plaintiff";
            button6.Height = 55;
            button6.Width = 155;
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            label6.Text = null;
            button6.Height = 50;
            button6.Width = 150;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                Connection.Connector(dataGridView1, @case.Sixth(dataGridView1.CurrentRow.Cells[2].Value.ToString()));
            }
            catch(NullReferenceException ex)
            {
                MessageBox.Show("NO  DATA SELECTED");
            }
        }
        #endregion

        #region Seventh inqurie

        private void button7_MouseMove(object sender, MouseEventArgs e)
        {
            label7.Text = "Find all cases of selected defendant";
            button7.Height = 55;
            button7.Width = 155;
        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {
            label7.Text = null;
            button7.Height = 50;
            button7.Width = 150;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
            Connection.Connector(dataGridView1,@case.Seventh(dataGridView1.CurrentRow.Cells[1].Value.ToString()));
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("NO  DATA SELECTED");
            }

        }
        #endregion

        #region Delete Edit Display

        /// <summary>
        /// Обновление
        /// </summary>
        private void button11_Click(object sender, EventArgs e)
        {
            Connection.Connector(dataGridView1, @case.Display());
        }

        /// <summary>
        /// Редактирование выбранного дела
        /// </summary>
        private void button8_Click(object sender, EventArgs e)
        {
           try
            {
                caseEditing = CaseEditing.GetCaseEditing(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                caseEditing.Show();
            }
            catch(NullReferenceException ex)
            {
                MessageBox.Show("NO  DATA SELECTED");
            }
        }

        /// <summary>
        /// Удаление выбраного дела
        /// </summary>
         private void button9_Click(object sender, EventArgs e)
        {
            try
            {
            Connection.Connector(@case.Delete(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
            Connection.Connector(dataGridView1,@case.Display());
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("NO  DATA SELECTED");
            }
        }

        private void button9_MouseMove(object sender, MouseEventArgs e)
        {
            button9.Height = 105;
            button9.Width = 405;
        }

        private void button9_MouseLeave(object sender, EventArgs e)
        {
            button9.Height = 100;
            button9.Width = 400;
        }

        private void button8_MouseMove(object sender, MouseEventArgs e)
        {
            button8.Height = 105;
            button8.Width = 405;
        }

        private void button8_MouseLeave(object sender, EventArgs e)
        {
            button8.Height = 100;
            button8.Width = 400;
        }

        private void button11_MouseMove(object sender, MouseEventArgs e)
        {
            button11.Height = 105;
            button11.Width = 405;
        }

        private void button11_MouseLeave(object sender, EventArgs e)
        {
            button11.Height = 100;
            button11.Width = 400;
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
            caseAddition.Show();
        }

        private void button12_MouseMove(object sender, MouseEventArgs e)
        {
            button12.Height = 115;
            button12.Width = 305;
        }

        private void button12_MouseLeave(object sender, EventArgs e)
        {
            button12.Height = 110;
            button12.Width = 300;
        }

        /// <summary>
        /// Редактирование
        /// </summary>
        private void button13_Click(object sender, EventArgs e)
        {
            caseEditing = CaseEditing.GetCaseEditing();
            caseEditing.Show();
        }

        private void button13_MouseMove(object sender, MouseEventArgs e)
        {
            button13.Height = 115;
            button13.Width = 305;
        }

        private void button13_MouseLeave(object sender, EventArgs e)
        {
            button13.Height = 110;
            button13.Width = 300;
        }

        /// <summary>
        /// Удаление 
        /// </summary>
        private void button14_Click(object sender, EventArgs e)
        {
            deleting.Show();
        }

        private void button14_MouseMove(object sender, MouseEventArgs e)
        {
            button14.Height = 115;
            button14.Width = 305;
        }

        private void button14_MouseLeave(object sender, EventArgs e)
        {
            button14.Height = 110;
            button14.Width = 300;
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
            button10.Height = 115;
            button10.Width = 305;
        }

        private void button10_MouseLeave(object sender, EventArgs e)
        {
            button10.Height = 110;
            button10.Width = 300;
        }
        #endregion

    }
}
