using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using EnvironmentSystem.Entity;

namespace EnvironmentSystem.DataAccess
{
    /// <summary>
    /// 企业基本信息表的数据操作类
    /// </summary>
    class D_CorpBaseInfo
    {
        public static string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\workspaces\\vs\\WindowsFormsApplication1\\EnvironmentDB.accdb";

        /// <summary>
        /// 增加一行
        /// </summary>
        /// <param name="cs"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        public int insert(E_CorpBaseInfo e)
        {
            try
            {
                OleDbConnection conn = new OleDbConnection();
                conn.ConnectionString = connectionString;

                OleDbCommand insertCmd = new OleDbCommand();
                insertCmd.CommandType = CommandType.Text;
                insertCmd.CommandText = string.Format("insert into CorpBaseInfo(StatisticDate,FaRenID,Tag,CorpDetailName,OldName,FaRenName,FaRenTel,FaRenFax,"+
                    "PostalCode,EnvironName,EnvironTel,EnvironFax,CorpAddress,AdminRegionID,RegisterTypeID,IndustryTypeID,CorpSizeID,CorpOpenDate) "+
                    "values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}','{16}','{17}')",
                e.StatisticDate, e.FaRenID, e.Tag, e.CorpDetailName, e.OldName, e.FaRenName, e.FaRenTel, e.FaRenFax,e.PostalCode, e.EnvironName, 
                e.EnvironTel, e.EnvironFax, e.CorpAddress, e.AdminRegionID, e.RegisterTypeID,e.IndustryTypeID, e.CorpSizeID, e.CorpOpenDate);
                insertCmd.Connection = conn;

                conn.Open();
                int result = insertCmd.ExecuteNonQuery();

                if (result > 0)
                {
                    OleDbCommand selectCmd = new OleDbCommand("select @@identity", conn);
                    int identity = (int)selectCmd.ExecuteScalar();
                    conn.Close();
                    return identity;
                }
                else
                {
                    conn.Close();
                    return result;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public DataTable query(int corpID)
        {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = connectionString;

            OleDbCommand command = new OleDbCommand(@"select * from corpbaseinfo where id="+ corpID, conn);

            conn.Open();
            //OleDbDataReader reader = command.ExecuteReader();
            //while(reader.Read())
            //{
            //    Console.WriteLine(reader["CorpDetailName"]);
            //}
            //reader.Close();
            OleDbDataAdapter da = new OleDbDataAdapter(command);
            DataTable corps = new DataTable();
            da.Fill(corps);
            conn.Close();
            
            return corps;
        }
    }
}
