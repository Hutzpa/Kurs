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
    public partial class Stats : Form
    {
        public Stats()
        {
            InitializeComponent();
             defendant = new Defendant();
             judge = new Judge();
             plaintiff = new Plaintiff();
             @case = new Case();
            Connection.FillCB(defendant.Display(), comboBox2, WhichForm.Defendant);
            Connection.FillCB(judge.Display(), comboBox3, WhichForm.Judge);
            Connection.FillCB(plaintiff.Display(), comboBox1, WhichForm.Plaintiff);
        }

        private Defendant defendant;
        private Judge judge;
        private Plaintiff plaintiff;
        private Case @case;

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                label1.Text = "Кількість справ вибраного позивача - " + Connection.PrintStat(@case.AmountOfPlaintiffCases(int.Parse(comboBox1.Text)));
            }
            catch (Exception ex)
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                label1.Text = "Кількість справ вибраного відповідача - " + Connection.PrintStat(@case.AmountOfDefendantCases(int.Parse(comboBox2.Text)));
            }
            catch (Exception ex)
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                label1.Text = "Кількість справ вибраного судді - " + Connection.PrintStat(@case.AmountOfJudgeCases(int.Parse(comboBox3.Text)));
            }
            catch (Exception ex)
            {

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                label1.Text = "Кількість закритих справ - " + Connection.PrintStat(@case.AmountOfClosedCases());
            }
            catch (Exception ex)
            {

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                label1.Text = "Кількість відкритих справ - " + Connection.PrintStat(@case.AmountOfOpenCases());
            }
            catch (Exception ex)
            {

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                label1.Text = "Кількість справ відкритих " + dateTimePicker1.Value.ToShortDateString() + " - " + Connection.PrintStat(@case.AmountOfOpenedInSpecDateCases(dateTimePicker1.Value));
            }
            catch (Exception ex)
            {

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                label1.Text = "Кількість справ закритих " + dateTimePicker1.Value.ToShortDateString() + " - " + Connection.PrintStat(@case.AmountOfClosedInSpecDateCases(dateTimePicker1.Value));
            }
            catch (Exception ex)
            {

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                Connection.Connector(dataGridView1, richTextBox1.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Перевірте запит на валідність.");
            }
            
        }
    }
}
