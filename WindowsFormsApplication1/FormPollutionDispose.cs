using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EnvironmentSystem.DataAccess;

namespace SimpleForm
{
    public partial class FormPollutionDispose:Form
    {
        public FormPollutionDispose()
        {
            InitializeComponent();
        }

        private void FormPollutionControl_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            D_PollutionDisposeInfo d_PollutionDisposeInfo = new D_PollutionDisposeInfo();

            DataTable dataTable = d_PollutionDisposeInfo.queryAll();
            dataGridView1.DataSource = dataTable;
        }
    }
}
