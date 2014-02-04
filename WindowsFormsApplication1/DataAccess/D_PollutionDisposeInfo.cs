using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace EnvironmentSystem.DataAccess
{
    /// <summary>
    /// 工业企业污染治理项目建设情况 数据操作类
    /// </summary>
    class D_PollutionDisposeInfo
    {

        public static string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=c:\\dbfiles\\EnvironmentDB.accdb";

        public DataTable queryAll()
        {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = connectionString;

            OleDbCommand command = new OleDbCommand(@"select * from pollutionDisposeInfo", conn);

            conn.Open();
            //OleDbDataReader reader = command.ExecuteReader();
            //while(reader.Read())
            //{
            //    Console.WriteLine(reader["CorpDetailName"]);
            //}
            //reader.Close();
            OleDbDataAdapter da = new OleDbDataAdapter(command);
            DataTable result = new DataTable();

            da.Fill(result);
            
            conn.Close();

            return CaptionToCH(result);
        }

        private DataTable CaptionToCH(DataTable dt)
        {
            dt.Columns[0].ColumnName = "企业法人代码";
            dt.Columns[1].ColumnName = "统计年份";
            dt.Columns[2].ColumnName = "治理类型";
            dt.Columns[3].ColumnName = "污染治理项目名称";
            dt.Columns[4].ColumnName = "开工年月";
            dt.Columns[5].ColumnName = "建成投产年月";
            dt.Columns[6].ColumnName = "计划总投资";
            dt.Columns[7].ColumnName = "至本年底累计完成投资";
            dt.Columns[8].ColumnName = "本年度完成投资及资金来源合计";
            dt.Columns[9].ColumnName = "排污费补助";
            dt.Columns[10].ColumnName = "政府其他补助";
            dt.Columns[11].ColumnName = "企业自筹";
            dt.Columns[12].ColumnName = "银行贷款";
            dt.Columns[13].ColumnName = "竣工项目设计及新增处理能力";
            return dt;
        }

    }
}
