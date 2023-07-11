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

        public int SetUser(string userName, string userPasswd, string userGroup, string userDescribe, string thisTime)
        {
            return new UserListServer().SetUser(userName,userPasswd,userGroup,userDescribe,thisTime);
        }

        public bool SearchUser(string userName)
        {
            return new UserListServer().SearchUser(userName);
        }

        public int DeleteUser(string userName)
        {
            return new UserListServer().DeletUser(userName);
        }
        public int UpdateUser(string userName, string userPasswd = null, string userDescribe = null)
        {
            return new UserListServer().UpdataUser(userName,userPasswd,userDescribe);
        }
    }
}   
