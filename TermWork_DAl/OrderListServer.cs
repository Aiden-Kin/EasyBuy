using EasyBuy_Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBuy_DAL
{
    public class OrderListServer
    {
        public List<OrderList> ToModel(DataTable dt)
        {
            List<OrderList> list = new List<OrderList>();
            foreach (DataRow row in dt.Rows)
            {
                OrderList order = new OrderList();
                order.ONum = Convert.ToInt32(row["ONum"]);
                order.OCustom = row["OCustom"].ToString();
                order.OCPhone = row["OCPhone"].ToString();
                order.OCAddress = row["OCAddress"].ToString();
                order.OGoodsID = Convert.ToInt32(row["OGoodsID"]);
                order.OGoodsName = row["OGoodsName"].ToString();
                order.OGoodsPrice = Convert.ToSingle(row["OGoodsPrice"]);
                order.OGoodsNum = Convert.ToInt32(row["OGoodsNum"]);
                order.OPayWay = row["OPayWay"].ToString();
                order.OTotallyMoney = Convert.ToSingle(row["OTotallyMoney"]);
                order.OTime = row["OTime"].ToString();
                list.Add(order);
            }
            return list;
        }

        public OrderList Get(int oNum)
        {
            string sqlStr = "SELECT * FROM tblOrderList WHERE ONum = " + oNum;
            DataTable dt = SqlHelper.ExecuteDataTable(sqlStr);
            if (dt.Rows.Count == 0)
            {
                throw new Exception("订单信息不存在");
            }
            return ToModel(dt)[0];
        }

        public List<OrderList> GetList(string condition, string find)
        {
            string sqlStr = "SELECT * FROM tblOrderList";
            if (!String.IsNullOrEmpty(condition))
            {
                sqlStr += String.Format(" WHERE {0} = '{1}' ", condition, find);
            }
            DataTable dt = SqlHelper.ExecuteDataTable(sqlStr);
            return ToModel(dt);
        }

        public void Add(OrderList order)
        {
            string sqlStr = string.Format("INSERT INTO tblOrderList (ONum, OCustom, OCPhone, OCAddress, OGoodsID, OGoodsName, OGoodsPrice, OGoodsNum, OPayWay, OTotallyMoney, OTime) VALUES ({0}, '{1}', '{2}', '{3}', {4}, '{5}', {6}, {7}, '{8}', {9}, '{10}') ",
                order.ONum, order.OCustom, order.OCPhone, order.OCAddress, order.OGoodsID, order.OGoodsName, order.OGoodsPrice, order.OGoodsNum, order.OPayWay, order.OTotallyMoney, order.OTime);
            SqlHelper.ExecuteNonQuery(sqlStr);
        }

        public void Delete(int oNum)
        {
            string sqlStr = String.Format("DELETE FROM tblOrderList WHERE ONum = {0}", oNum);
            SqlHelper.ExecuteNonQuery(sqlStr);
        }

        public void ChangeInfo(OrderList order)
        {
            string sqlStr = String.Format("UPDATE tblOrderList SET OCustom = '{0}', OCPhone = '{1}', OCAddress = '{2}', OGoodsID = {3}, OGoodsName = '{4}', OGoodsPrice = {5}, OGoodsNum = {6}, OPayWay = '{7}', OTotallyMoney = {8}, OTime = '{9}' WHERE ONum = {10} ",
                order.OCustom, order.OCPhone, order.OCAddress, order.OGoodsID, order.OGoodsName, order.OGoodsPrice, order.OGoodsNum, order.OPayWay, order.OTotallyMoney, order.OTime, order.ONum);
            SqlHelper.ExecuteNonQuery(sqlStr);
        }
    }
}

