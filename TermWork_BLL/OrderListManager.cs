using EasyBuy_DAL;
using EasyBuy_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBuy_BLL
{
    public class OrderListManager
    {
        public OrderList Get(int id)
        {
            return new OrderListServer().Get(id);
        }

        public List<OrderList> GetList(string condition = "", string find = "")
        {
            switch (condition)
            {
                case "名称":
                    condition = "Name";
                    break;
                case "类别":
                    condition = "Class";
                    break;
                case "位置":
                    condition = "Location";
                    break;
                case "不筛选":
                default:
                    condition = "";
                    break;
            }
            return new OrderListServer().GetList(condition, find);
        }

        private void ValidateInfo(string custom, string cPhone, string cAddress, string goodsName, string payWay)
        {
            if (string.IsNullOrEmpty(custom))
            {
                throw new Exception("请填写顾客姓名!");
            }
            if (string.IsNullOrEmpty(cPhone))
            {
                throw new Exception("请填写顾客联系电话!");
            }
            if (string.IsNullOrEmpty(cAddress))
            {
                throw new Exception("请填写顾客联系地址!");
            }
            if (string.IsNullOrEmpty(goodsName))
            {
                throw new Exception("请填写商品名称!");
            }
            if (string.IsNullOrEmpty(payWay))
            {
                throw new Exception("请填写订单支付方式!");
            }
        }

        private OrderList GetModel(int oNum, string oCustom, string oCPhone, string oCAddress, int oGoodsID, string oGoodsName, float oGoodsPrice, int oGoodsNum, string oPayWay, float oTotallyMoney, string oTime)
        {
            OrderList order = new OrderList();
            order.ONum = oNum;
            order.OCustom = oCustom;
            order.OCPhone = oCPhone;
            order.OCAddress = oCAddress;
            order.OGoodsID = oGoodsID;
            order.OGoodsName = oGoodsName;
            order.OGoodsPrice = oGoodsPrice;
            order.OGoodsNum = oGoodsNum;
            order.OPayWay = oPayWay;
            order.OTotallyMoney = oTotallyMoney;
            order.OTime = oTime;
            return order;
        }

        public void ChangeInfo(int oNum, string oCustom, string oCPhone, string oCAddress, int oGoodsID, string oGoodsName, float oGoodsPrice, int oGoodsNum, string oPayWay, float oTotallyMoney, string oTime)
        {
            ValidateInfo(oCustom, oCPhone, oCAddress, oGoodsName, oPayWay);
            new OrderListServer().ChangeInfo(GetModel(oNum, oCustom, oCPhone, oCAddress, oGoodsID, oGoodsName, oGoodsPrice, oGoodsNum, oPayWay, oTotallyMoney, oTime));
        }

        public void Add(string oCustom, string oCPhone, string oCAddress, int oGoodsID, string oGoodsName, float oGoodsPrice, int oGoodsNum, string oPayWay, float oTotallyMoney, string oTime)
        {
            ValidateInfo(oCustom, oCPhone, oCAddress, oGoodsName, oPayWay);
            int oNum = 0; // 生成订单编号的逻辑
            new OrderListServer().Add(GetModel(oNum, oCustom, oCPhone, oCAddress, oGoodsID, oGoodsName, oGoodsPrice, oGoodsNum, oPayWay, oTotallyMoney, oTime));
        }

        public void Delete(int oNum)
        {
            new OrderListServer().Delete(oNum);
        }

        public void UpRepodate(int oGoodsID, int oGoodsNum)
        {
            // 根据需要进行相关操作
        }
    }
}
