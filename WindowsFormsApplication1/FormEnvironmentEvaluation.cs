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

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WordForm wf = new WordForm();
            wf.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.ShowDialog();
            txtPath1.Text = of.FileName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            edoUserControl1.Open(txtPath1.Text);
        }
    }
}
