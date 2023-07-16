using EasyBuy_DAL;
using EasyBuy_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBuy_BLL
{
    public class GoodsInfomManager
    {
        public GoodsInfom Get(string id)
        {
            int n;
            if (!Int32.TryParse(id, out n))
            {
                throw new Exception("编号不正确!");
            }
            return new GoodsInfomServer().Get(n);
        }

        public List<GoodsInfom> GetList(string condition = "", string find = "")
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
            return new GoodsInfomServer().GetList(condition, find);
        }

        private void ValidateInfo(string name, string className, string location, string productDate, int repertory, string supplier, float price)
        {
            if (String.IsNullOrEmpty(name))
            {
                throw new Exception("请填写名称!");
            }
            if (name.Length > 20)
            {
                throw new Exception("名称填写太长!");
            }
            if (className.Length > 10)
            {
                throw new Exception("类别填写太长!");
            }
            if (location.Length > 100)
            {
                throw new Exception("位置填写太长!");
            }
            if (productDate.Length > 10)
            {
                throw new Exception("生产日期填写太长!");
            }
            if (repertory < 0)
            {
                throw new Exception("库存不能为负数!");
            }
            if (supplier.Length > 20)
            {
                throw new Exception("供货商填写太长!");
            }
            if (price < 0)
            {
                throw new Exception("价格不能为负数!");
            }
        }

        private GoodsInfom GetModel(int id, string name, string className, string location, string productDate, int repertory, string supplier,float discount, float price, string remark, string addTime)
        {
            GoodsInfom goods = new GoodsInfom();
            goods.ID = id;
            goods.Name = name;
            goods.Class = className;
            goods.Location = location;
            goods.ProductDate = productDate;
            goods.Repertory = repertory;
            goods.Supplier = supplier;
            goods.Discount = discount;
            goods.Price = price;
            goods.Remark = remark;
            goods.AddTime = addTime;
            return goods;
        }

        public void ChangeInfo(int id, string name, string className, string location, string productDate, int repertory, string supplier,float discount, float price, string remark, string addTime)
        {
            ValidateInfo(name, className, location, productDate, repertory, supplier, price);

            new GoodsInfomServer().ChangeInfo(GetModel(id, name, className, location, productDate, repertory, supplier,discount, price, remark, addTime));
        }

        public void Add(string name, string className, string location, string productDate, int repertory, string supplier,float discount, float price, string remark, string addTime)
        {
            ValidateInfo(name, className, location, productDate, repertory, supplier, price);
            int id = 0;
            new GoodsInfomServer().Add(GetModel(id, name, className, location, productDate, repertory, supplier,discount, price, remark, addTime));
        }

        public int Delete(string id)
        {
            int idInt;
            if (!Int32.TryParse(id, out idInt))
            {
                throw new Exception("编号不正确!");
            }
            return new GoodsInfomServer().Delete(idInt);
        }

        public void UpRepodate(string id,string repo)
        {
            new GoodsInfomServer().UpRepodate(id, repo);
        }

        public void UpPrice(string id,string discount)
        {
            new GoodsInfomServer().UpPrice(id, discount);
        }
    }

}
