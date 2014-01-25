using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestWF
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WordForm wf = new WordForm();
            wf.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
