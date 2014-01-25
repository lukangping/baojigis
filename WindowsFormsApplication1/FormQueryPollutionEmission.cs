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
    public partial class FormQueryPollutionEmission : Form
    {
        public FormQueryPollutionEmission()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            D_CorpBaseInfo d_CorpBaseInfo = new D_CorpBaseInfo();
            DataTable dataTable = d_CorpBaseInfo.queryAll();

            int collums = dataTable.Columns.Count;
            int j = 0;
            for (int i = 0; i < CboxList1.Items.Count;i++ )
            {
                if (CboxList1.GetItemChecked(i) == true)
                {
                    dataTable.Columns[j].ColumnName = CboxList1.Items[i].ToString();
                    j++;
                }
            }

            int checkedCount = j;
            for (; j < collums; j++)
            {
                dataTable.Columns.Remove(dataTable.Columns[checkedCount]);
            }

            dataGridView1.DataSource = dataTable;
        }
    }
}
