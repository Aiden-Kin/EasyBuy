using EasyBuy_Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBuy_DAL
{
    public class SupplierServer
    {
        // 由DataTable获取List
        public List<Supplier> ToModel(DataTable dt)
        {
            List<Supplier> list = new List<Supplier>();
            foreach (DataRow row in dt.Rows)
            {
                Supplier bu = new Supplier();
                bu.ID = Convert.ToInt32(row["ID"]);
                bu.Name = row["Name"].ToString();
                bu.LegalPerson = row["LegalPerson"].ToString();
                bu.LinkAddress = row["LinkAddress"].ToString();
                bu.Linkman = row["Linkman"].ToString();
                bu.LinkPhone = row["LinkPhone"].ToString();
                bu.RecordDate = row["RecordDate"].ToString();
                bu.Remark = row["Remark"].ToString();
                list.Add(bu);
            }
            return list;
        }

        // 获取单个
        public Supplier Get(int no)
        {
            string sqlStr = "SELECT * FROM tblSupplier WHERE ID = " + no;
            DataTable dt = SqlHelper.ExecuteDataTable(sqlStr);
            if (dt.Rows.Count == 0)
            {
                throw new Exception("往来单位不存在");
            }
            return ToModel(dt)[0];
        }

        public List<Supplier> GetList( string condition, string find)
        {
            string sqlStr = "SELECT * FROM tblSupplier";
            if (!String.IsNullOrEmpty(condition))
            {
                sqlStr += String.Format(" WHERE {0} = '{1}' ", condition, find);
            }
            DataTable dt = SqlHelper.ExecuteDataTable(sqlStr);
            return ToModel(dt);
        }

        public void Add(Supplier bu)
        {
            string sqlStr = string.Format("INSERT INTO tblSupplier VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}','{6}') ",
                bu.Name, bu.LegalPerson, bu.Linkman, bu.LinkPhone, bu.LinkAddress,bu.RecordDate, bu.Remark);
            SqlHelper.ExecuteNonQuery(sqlStr);
        }

        public void Delete(int no)
        {
            string sqlStr = String.Format("DELETE FROM tblSupplier WHERE ID = {0}", no);
            SqlHelper.ExecuteNonQuery(sqlStr);
        }

        public void ChangeInfo(Supplier bu)
        {
            // 无需类别信息
            string sqlStr = String.Format("UPDATE tblSupplier SET Name = '{0}', LegalPerson = '{1}', Linkman = '{2}', LinkPhone = '{3}', LinkAddress = '{4}', Remark = '{5}' WHERE ID = '{6}' ",
                bu.Name, bu.LegalPerson, bu.Linkman, bu.LinkPhone,bu.LinkAddress,bu.Remark, bu.ID);
            SqlHelper.ExecuteNonQuery(sqlStr);
        }
    }
}
