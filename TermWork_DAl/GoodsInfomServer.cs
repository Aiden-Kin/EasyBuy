using EasyBuy_Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBuy_DAL
{
    public class GoodsInfomServer
    {
        public List<GoodsInfom> ToModel(DataTable dt)
        {
            List<GoodsInfom> list = new List<GoodsInfom>();
            foreach (DataRow row in dt.Rows)
            {
                GoodsInfom goods = new GoodsInfom();
                goods.ID = Convert.ToInt32(row["ID"].ToString());
                goods.Name = row["Name"].ToString();
                goods.Class = row["Class"].ToString();
                goods.Location = row["Location"].ToString();
                goods.ProductDate = row["ProductDate"].ToString();
                goods.Repertory = Convert.ToInt32(row["Repertory"]);
                goods.Supplier = row["Supplier"].ToString();
                goods.Discount = Convert.ToSingle(row["Discount"]);
                goods.Price = Convert.ToSingle(row["Price"]);
                goods.Remark = row["Remark"].ToString();
                goods.AddTime = row["AddTime"].ToString();
                goods.DPrice = Convert.ToSingle(row["DPrice"]);
                list.Add(goods);
            }
            return list;
        }

        public GoodsInfom Get(int id)
        {
            string sqlStr = "SELECT * FROM tblGoodsInfom WHERE ID = " + id;
            DataTable dt = SqlHelper.ExecuteDataTable(sqlStr);
            if (dt.Rows.Count == 0)
            {
                throw new Exception("商品信息不存在");
            }
            return ToModel(dt)[0];
        }

        public List<GoodsInfom> GetList(string condition, string find)
        {
            string sqlStr = "SELECT * FROM tblGoodsInfom";
            if (!String.IsNullOrEmpty(condition))
            {
                sqlStr += String.Format(" WHERE {0} = '{1}' ", condition, find);
            }
            DataTable dt = SqlHelper.ExecuteDataTable(sqlStr);
            return ToModel(dt);
        }

        public void Add(GoodsInfom goods)
        {
            string sqlStr = string.Format("INSERT INTO tblGoodsInfom (Name, Class, Location, ProductDate, Repertory, Supplier, Price, Remark, AddTime) VALUES ('{0}', '{1}', '{2}', '{3}', {4}, '{5}', {6}, {7}, '{8}','{9}') ",
                goods.Name, goods.Class, goods.Location, goods.ProductDate, goods.Repertory, goods.Supplier,goods.Discount, goods.Price, goods.Remark, goods.AddTime);
            SqlHelper.ExecuteNonQuery(sqlStr);
        }

        public void Delete(int id)
        {
            string sqlStr = String.Format("DELETE FROM tblGoodsInfom WHERE ID = {0}", id);
            SqlHelper.ExecuteNonQuery(sqlStr);
        }

        public void ChangeInfo(GoodsInfom goods)
        {
            string sqlStr = String.Format("UPDATE tblGoodsInfom SET Name = '{0}', Class = '{1}', Location = '{2}', ProductDate = '{3}', Repertory = {4}, Supplier = '{5}', Price = {6}, Remark = '{7}', AddTime = '{8}',Discount = {9} WHERE ID = '{10}' ",
                goods.Name, goods.Class, goods.Location, goods.ProductDate, goods.Repertory, goods.Supplier, goods.Price, goods.Remark, goods.AddTime,goods.Discount, goods.ID);
            SqlHelper.ExecuteNonQuery(sqlStr);
        }

        public void UpRepodate(string id, string repo)
        {
            string sql = String.Format("UPDATE tblGoodsInfom set Repertory ={0} WHERE ID ={1} ", repo, id);
            SqlHelper.ExecuteNonQuery(sql);
        }


        public void UpPrice(string id,  string discount)
        {
            string sql = String.Format("UPDATE tblGoodsInfom set Discount ={0} WHERE ID ={1} ", discount, id);
            SqlHelper.ExecuteNonQuery(sql);
        }
    }
}
