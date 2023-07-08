using EasyBuy_Model;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace EasyBuy_DAL
{
    public class UserListServer
    {
        public  User GetSingleUser(string userName,string userPassword)  
        {
            User userInfom = new User();
            string sqlstr = string.Format("select * from tblUserList where UserName ='{0}' and UserPassword = '{1}'", userName,userPassword);
            using (DataTable dt = SqlHelper.ExecuteDataTable(sqlstr))
            {
                userInfom = ToModel(dt)[0];
            }
                
            return userInfom;
        }

        private List<User> ToModel(DataTable dt)
        {
            List<User> userlist = new List<User>();
            User user;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                user = new User();
                user.UserName = dt.Rows[0]["UserName"].ToString();
                user.UserPassword = dt.Rows[0]["UserPassword"].ToString();
                user.UserGroup = dt.Rows[0]["UserGroup"].ToString();
                user.UserDescribe = dt.Rows[0]["UserDescirbe"].ToString();
                user.UserRemark = dt.Rows[0]["UserRemark"].ToString();
                userlist.Add(user);
            }


            return userlist;
        }

        public List<User> GetUserList (string userGroup ,string condition = null ,string searchData = null )
        {
            List<User> userList = new List<User>();
            string sqlstr = string.Format("select * from tblUserList where UserGroup = '{0}'", userGroup);
            if(condition != null)
            {
                sqlstr += string.Format("and {0] = '{1}'", condition, searchData);
            }
            DataTable dt = SqlHelper.ExecuteDataTable(sqlstr);
            userList = ToModel(dt);
            return userList;
        }
    }

    
}
