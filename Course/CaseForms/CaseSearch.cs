using MySql.Data.MySqlClient;
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
    public partial class CaseSearch : Form
    {
        private CaseSearch()
        {
            InitializeComponent();
        }

        private static CaseSearch caseSearch;

        public static CaseSearch GetCaseSearch(WhichInquiry whichInquiry)
        {
            if (caseSearch == null)
            {
                CaseSearch.whichInquiry = whichInquiry;
                caseSearch = new CaseSearch();
            }
            return caseSearch;
        }

        public static WhichInquiry whichInquiry;
        private Case @case = new Case();

        private void Action()
        {
            switch (whichInquiry)
            {
                case WhichInquiry.First:
                    {
                        Connection.Connector(@case.First(textBox1.Text));
                        break;
                    }
                case WhichInquiry.Second:
                    {
                        Connection.Connector(@case.Second(textBox1.Text));
                        break;
                    }
                case WhichInquiry.Third:
                    {
                        Connection.Connector(@case.Third(textBox1.Text));
                        break;
                    }
                case WhichInquiry.Fourth:
                    {
                        Connection.Connector(@case.Fourth(textBox1.Text));
                        break;
                    }
                case WhichInquiry.Fifth:
                    {
                        Connection.Connector(@case.Fifth(textBox1.Text));
                        break;
                    }
                case WhichInquiry.Sixth:
                    {
                        Connection.Connector(@case.Sixth(textBox1.Text));
                        break;
                    }
                case WhichInquiry.Seventh:
                    {
                        Connection.Connector(@case.Seventh(textBox1.Text));
                        break;
                    }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Action();
        }

        private void CaseSearch_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Visible = false;
            }
        }
    }
}
