using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

namespace EasyBuy_DAL
{
    public class SqlHelper
    {
        private static string constr = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=EesyBuy;Data Source=Air\\MYSQL";




        #region 执行SQL查询语句，返回DataSet
        /// <summary>
        /// 执行SQL查询语句，返回DataSet
        /// </summary>
        /// <param name="sqlstr">要执行的SQL查询语句</param>
        /// <param name="tablename">DataSet中要填充的表名</param>
        /// <returns>返回dataSet类型的执行结果</returns>
        public static DataSet ExecuteDataSet(string sqlstr, string tablename)
        {
            using (SqlConnection sqlCon = new SqlConnection(constr))
            {
                using (SqlDataAdapter sqlAdapter = new SqlDataAdapter(sqlstr, sqlCon))
                {
                    sqlCon.Open();
                    DataSet dataSet = new DataSet();
                    sqlAdapter.Fill(dataSet, tablename);
                    return dataSet;
                }
            }
        }
        public static DataSet ExecuteDataSet(string sqlstr)
        {
            using (SqlConnection sqlCon = new SqlConnection(constr))
            {
                using (SqlDataAdapter sqlAdapter = new SqlDataAdapter(sqlstr, sqlCon))
                {
                    sqlCon.Open();
                    DataSet dataSet = new DataSet();
                    sqlAdapter.Fill(dataSet);
                    return dataSet;
                }
            }
        }
        #endregion

        #region 执行SQL查询语句，返回DataTable 返回第一个表格
        public static DataTable ExecuteDataTable(string sqlstr)
        {
            using (SqlConnection sqlCon = new SqlConnection(constr))
            {
                using (SqlDataAdapter sqlAdapter = new SqlDataAdapter(sqlstr, sqlCon))
                {
                    sqlCon.Open();
                    DataSet dataSet = new DataSet();
                    sqlAdapter.Fill(dataSet);
                    return dataSet.Tables[0];
                }
            }            
        }

        #endregion
        

        #region 执行SQL语句（Insert、Update、Delete）并返回受影响的行数
        /// <summary>
        /// 执行SQL语句并返回受影响的行数.
        /// </summary>
        /// <param name="sqlstr">要执行的SQL语句</param>
        /// <returns>返回int类型的受影响的行数</returns>
        public static int ExecuteNonQuery(string sqlstr)
        {
           
                using (SqlConnection sqlCon = new SqlConnection(constr))
                {
                    using (SqlCommand sqlCmd = new SqlCommand(sqlstr, sqlCon))
                    {
                        sqlCon.Open();
                        return sqlCmd.ExecuteNonQuery();
                    }
                }
           
        }
        #endregion



        #region 输入SQL查询命令，检查数据表中是否有该数据信息，返回bool值
        /// <summary>
        /// 输入SQL命令，检查数据表中是否有该数据信息
        /// </summary>
        /// <param name="sqlstr">要执行的SQL语句</param>
        /// <returns>true:有，false：不存在</returns>
        public static bool Exist(string sqlstr)
        {
            using (SqlConnection sqlCon = new SqlConnection(constr))
            {
                using (SqlCommand sqlCmd = new SqlCommand(sqlstr, sqlCon))
                {
                    sqlCon.Open();
                    if (sqlCmd.ExecuteScalar() == null) return false;
                    else return true;
                }
            }
        }
        #endregion

        #region 输入SQL查询命令，检查数据表中是否有该数据信息，返回满足条件的记录个数
        /// <summary>
        /// 输入SQL命令，检查数据表中是否有该数据信息
        /// </summary>
        /// <param name="sqlstr">要执行的SQL语句</param>
        /// <returns>返回数据表中记录总数</returns>
        public static int GetDataRow(string sqlstr)
        {
            using (SqlConnection sqlCon = new SqlConnection(constr))
            {
                using (SqlDataAdapter sqlAdapter = new SqlDataAdapter(sqlstr, sqlCon))
                {
                    sqlCon.Open();
                    DataSet dataSet = new DataSet();
                    sqlAdapter.Fill(dataSet);
                    return dataSet.Tables[0].Rows.Count; ;
                }
            }
        }
        #endregion

    }
}
