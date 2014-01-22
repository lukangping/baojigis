using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace SimpleForm
{
    public partial class EnterpriseManagement : Form
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
    }
}
