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
    public class UserListManager
    {
        public User GetUser(string userName,string userPassword)
        {
            return new UserListServer().GetSingleUser(userName, userPassword);
        }
        public List<User> GetUserList(string userGroup, string condition = null, string searchData = null)
        {
            List<User> userlist = new List<User>();
            userlist = new UserListServer().GetUserList(userGroup,condition,searchData);
            return userlist;
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
