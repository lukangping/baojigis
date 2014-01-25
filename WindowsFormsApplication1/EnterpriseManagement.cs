using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using EnvironmentSystem.Entity;
using EnvironmentSystem.DataAccess;

namespace SimpleForm
{
    public partial class EnterpriseManagement:Form
    {
        public EnterpriseManagement()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\workspaces\vs\WindowsFormsApplication1\EnvironmentDB.accdb";

            OleDbCommand command = new OleDbCommand(@"select * from corpbaseinfo", conn);

            conn.Open();
            //OleDbDataReader reader = command.ExecuteReader();
            //while(reader.Read())
            //{
            //    Console.WriteLine(reader["CorpDetailName"]);
            //}
            OleDbDataAdapter da = new OleDbDataAdapter(command);
            DataTable corps = new DataTable();
            da.Fill(corps);
            dataGridView1.DataSource = corps;


            //reader.Close();
            conn.Close();

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            E_CorpBaseInfo corpBaseInfo = new E_CorpBaseInfo();

            corpBaseInfo.StatisticDate = this.CombStatisticDate.Text;
            corpBaseInfo.FaRenID = this.TxtFaRenID.Text.Trim();
            corpBaseInfo.Tag = this.TxtTag.Text.Trim();
            corpBaseInfo.CorpDetailName = this.TxtCorpDetailName.Text.Trim();
            corpBaseInfo.OldName = this.TxtOldName.Text.Trim();

            corpBaseInfo.FaRenName = this.TxtFaRenName.Text.Trim();
            corpBaseInfo.FaRenTel = this.TxtFaRenTel.Text.Trim();
            corpBaseInfo.FaRenFax = this.TxtFaRenFax.Text.Trim();
            corpBaseInfo.PostalCode = this.TxtPostalCode.Text.Trim();
            corpBaseInfo.EnvironName = this.TxtEnvironName.Text.Trim();

            corpBaseInfo.EnvironTel = this.TxtEnvironTel.Text.Trim();
            corpBaseInfo.EnvironFax = this.TxtEnvironFax.Text.Trim();
            corpBaseInfo.CorpAddress = this.TxtCorpAddress.Text.Trim();
            corpBaseInfo.AdminRegionID = this.TxtAdminRegionID.Text.Trim();
            corpBaseInfo.RegisterTypeID = this.TxtRegisterTypeID.Text.Trim();

            corpBaseInfo.IndustryTypeID = this.TxtIndustryTypeID.Text.Trim();
            corpBaseInfo.CorpSizeID = this.TxtCorpSizeID.Text.Trim();
            corpBaseInfo.CorpOpenDate = this.dateTimePicker1.Text;

            D_CorpBaseInfo d_corpBaseInfo = new D_CorpBaseInfo();
            int corpID = d_corpBaseInfo.insert(corpBaseInfo);

            if (corpID>0)
            {
                MessageBox.Show("添加成功！");
                DataTable dataTable = d_corpBaseInfo.query(corpID);
                dataGridView1.DataSource = dataTable;
            }
            else
            {
                MessageBox.Show("添加失败！");
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
