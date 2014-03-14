using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TestWF;

namespace EnvironmentSystem
{
    public partial class FormEnvironmentEvaluation : Form
    {

        public FormEnvironmentEvaluation()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            edoUserControl1.Open("D:\\projects\\2014_baojigis\\wordfiles\\huanping.docx");
            //current_file = "D:\\workspaces\\huanping.docx";
        }

        private void tabPage1_Enter(object sender, EventArgs e)
        {
            edoUserControl1.Open("D:\\projects\\2014_baojigis\\wordfiles\\huanping.docx");
        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            edoUserControl2.Open("D:\\projects\\2014_baojigis\\wordfiles\\pifu.docx");
            //current_file = "D:\\workspaces\\pifu.docx";
        }

        private void tabPage3_Enter(object sender, EventArgs e)
        {
            edoUserControl3.Open("D:\\projects\\2014_baojigis\\wordfiles\\yanshou.docx");
            //current_file = "D:\\workspaces\\yanshou.docx";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            edoUserControl1.Print();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            edoUserControl2.Print();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            edoUserControl3.Print();
        }

        private void tabPage1_Leave(object sender, EventArgs e)
        {
            //edoUserControl1.Close();
        }

        private void tabPage2_Leave(object sender, EventArgs e)
        {
            //edoUserControl2.Close();
        }

        private void tabPage3_Leave(object sender, EventArgs e)
        {
            //edoUserControl3.Close();
        }

        private void FormEnvironmentEvaluation_Load(object sender, EventArgs e)
        {

        }
       
    }
}
