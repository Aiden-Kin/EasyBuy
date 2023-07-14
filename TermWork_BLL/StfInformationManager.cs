using DevExpress.CodeParser;
using EasyBuy_DAL;
using EasyBuy_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EasyBuy_BLL
{
    public class StfInformationManager
    {
        public User GetUser(string userName,string userPassword)
        {
            return new UserListServer().GetSingleUser(userName, userPassword);
        }

        public List<StaffInformation> GetStaffInformationList( string condition = null, string searchData = null)
        {
            List<StaffInformation> stafflist = new List<StaffInformation>();
            stafflist = new StfInformationServer().GetUserList(condition,searchData);

            return stafflist;
        }

        public int SetStaffInfo(StaffInformation staff)
        {
            return new StfInformationServer().SetUser(staff);
        }

        public bool SearchUser(string userName)
        {
            return new UserListServer().SearchUser(userName);
        }

        public int DeleteUser(string deletStaffID)
        {
            int flag1,flag2;
            int id = Convert.ToInt32(deletStaffID);
            flag2 = new StaffSalaryManager().DeleteUser(id);
            flag1 = new StfInformationServer().DeletUser(deletStaffID);
            if (flag1 + flag2 > 0)
            {
                return 1;
            }
            return 0;
        }
        public int UpdataStaffInfo(StaffInformation staff)
        {
            return new StfInformationServer().UpdataStaffInfo(staff);
        }
    }
}   
