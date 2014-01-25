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
            edoUserControl1.Open("D:\\test.doc");
        }
    }
}
