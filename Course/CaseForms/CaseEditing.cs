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
    public partial class CaseEditing : Form
    {
        private CaseEditing()
        {
            InitializeComponent();
        }

        private  Case @case = new Case();
        public static CaseEditing caseEditing;

        public static CaseEditing GetCaseEditing()
        {
            if (caseEditing == null)
                caseEditing = new CaseEditing();
            return caseEditing;
        }

    
        private void button1_Click(object sender, EventArgs e)
        {
            Connection.Connector(@case.Update(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, checkBox1.Checked, checkBox2.Checked, textBox9.Text));
        }
    }
}
