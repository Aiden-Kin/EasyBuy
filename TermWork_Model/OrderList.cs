using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBuy_Model
{
    public class OrderList
    {
        public int ONum { get; set; }           //订单编号
        public string OCustom { get; set; }     //订单顾客
        public string OCPhone { get; set; }//顾客联系电话
        public string OCAddress { get; set; }// 顾客联系地址
        public int OGoodsID { get; set; }//商品编号
        public string OGoodsName { get; set; }//商品名称
        public float OGoodsPrice { get; set; }//商品价格
        public int OGoodsNum { get; set; }//商品数量
        public string OPayWay { get; set; }//订单支付方式
        public float OTotallyMoney { get; set; }//订单总价
        public string OTime { get; set; }//订单交易时间
    }
}
