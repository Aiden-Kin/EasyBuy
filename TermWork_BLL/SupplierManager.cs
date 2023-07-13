using EasyBuy_DAL;
using EasyBuy_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EasyBuy_BLL
{
    public class SupplierManager
    {
        public Supplier Get(string no)
        {
            int n;
            if (!Int32.TryParse(no, out n))
            {
                throw new Exception("编号不正确!");
            }
            return new SupplierServer().Get(n);
        }

        public List<Supplier> GetList( string condition = "", string find = "")
        {

            switch (condition)
            {
                case "名称":
                    condition = "Name";
                    break;
                case "法人":
                    condition = "LegalPerson";
                    break;
                case "联系人":
                    condition = "Linkman";
                    break;
                case "供货商编号":
                    condition = "ID";
                    break;
                case "不筛选":
                default:
                    condition = "";
                    break;
            }
            return new SupplierServer().GetList( condition, find);
        }

        private void ValidateInfo(string name, string address, string contactName, string phone)
        {
            if (String.IsNullOrEmpty(name))
            {
                throw new Exception("请填写名称!");
            }
            if (name.Length > 20)
            {
                throw new Exception("名称填写太长!");
            }

            if (address.Length > 100)
            {
                throw new Exception("地址太长!");
            }
            if (contactName.Length > 10)
            {
                throw new Exception("联系人姓名太长!");
            }
            if (phone.Length > 11)
            {
                throw new Exception("联系电话太长");
            }

        }

        private Supplier GetModel(int id, string name, string legalperson, string contactName, string phone, string address, string time, string remark)
        {
            Supplier bu = new Supplier();
            bu.ID = id;
            bu.Name = name;
            bu.LegalPerson = legalperson;
            bu.LinkAddress = address;
            bu.Linkman = contactName;
            bu.LinkPhone = phone;
            bu.RecordDate = time;
            bu.Remark = remark;
            return bu;
        }

        public void ChangeInfo(string id, string name, string legalperson, string contactName, string phone, string address, string time, string remark)
        {
            // 更改时无需类别信息
            ValidateInfo(name,  address, contactName, phone);
            int noInt;
            if (!Int32.TryParse(id, out noInt))
            {
                throw new Exception("编号不正确!");
            }
            new SupplierServer().ChangeInfo(GetModel(noInt, name, legalperson, contactName, phone, address, time, remark));
        }

        public void Add(string name, string legalperson,string contactName,string phone, string address,string time, string remark)
        {
            ValidateInfo(name,  address, contactName, phone);
            int id = 0;
            new SupplierServer().Add(GetModel(id, name, legalperson,  contactName, phone, address,time,remark));
        }

        public void Delete(string no)
        {
            int noInt;
            if (!Int32.TryParse(no, out noInt))
            {
                throw new Exception("编号不正确!");
            }
            new SupplierServer().Delete(noInt);
        }
    }
}
