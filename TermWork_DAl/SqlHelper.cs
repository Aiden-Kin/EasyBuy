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

        #region 执行查询语句，返回SqlDataReader
        /// <summary>
        /// 执行查询语句，返回SqlDataReader
        /// </summary>
        /// <param name="sqlstr">要执行的SQL查询语句</param>
        /// <returns>返回SqlDataReader，需手工关闭连接</returns>
        public static SqlDataReader ExecuteReader(string sqlstr)
        {
            #region 注释部分的代码为什么不可以？
            //using (SqlConnection sqlCon = new SqlConnection(constr))
            //{                
            //    using (SqlCommand sqlCmd = new SqlCommand(sqlstr, sqlCon))
            //    {
            //        sqlCon.Open();
            //        SqlDataReader sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection);
            //        return sqlReader;
            //        //return sqlCmd.ExecuteReader();
            //    }
            //}
            #endregion
            SqlConnection sqlCon = new SqlConnection(constr);
            sqlCon.Open();
            using (SqlCommand sqlCmd = new SqlCommand(sqlstr, sqlCon))
            {
                return sqlCmd.ExecuteReader(CommandBehavior.CloseConnection);  //创建了 DataReader 并将 CommandBehavior 设置为 CloseConnection，则关闭 DataReader 会自动关闭此连接。
            }
            #region
            //如果想要返回对象前不关闭数据库连接，须要用CommandBehavior.CloseConnection；
            //CommandBehavior.CloseConnection的功能恰好就是为了避免类似的尴尬境地，它能够保证当SqlDataReader对象被关闭时，其依赖的连接也会被自动关闭CommandBehavior.
            #endregion
        }        
        #endregion

        //SqlDataAdapter:   查询---返回DataSet
        //                  添加（Insert）、修改（Update）、删除（Delete）---返回影响的行数

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

        #region ExecuteScalar方法
        /// <summary>
        /// ExecuteScalar方法返回的类型是object类型，这个方法返回sql语句执行后的第一行第一列的值
        /// </summary>
        /// <param name="sqlstr"></param>
        /// <returns>无记录返回时，ExecuteScalar()返回NULL值，
        /// 无法再将null值赋给任何对象或者变量，否则出现异常</returns>
        public static object ExecuteScalar(string sqlstr)
        {
            using (SqlConnection sqlCon = new SqlConnection(constr))
            {
                using (SqlCommand sqlCmd = new SqlCommand(sqlstr, sqlCon))
                {
                    sqlCon.Open();
                    return sqlCmd.ExecuteScalar();
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


        //注意下面2条语句的区别
        //SELECT  *
        //FROM tblStudent
        //where Sage>=20

        //SELECT COUNT(*)
        //FROM tblStudent
        //where Sage>=20
        //结论：ExecuteSQL也适合于最后的情况

    }
}
