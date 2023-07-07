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
        public  User GetUser(string userName,string userPassword)  
        {
            User userInfom = new User();
            string sqlstr = string.Format("select * from tblUserList where UserName ='{0}' and UserPassword = '{1}'", userName,userPassword);
            using (DataTable dt = SqlHelper.ExecuteDataTable(sqlstr))
            {
                userInfom = ToModel(dt);
            }
                
            return userInfom;
        }

        private User ToModel(DataTable dt)
        {
            User user = new User();
            user.UserName = dt.Rows[0]["UserName"].ToString();
            user.UserPassword = dt.Rows[0]["UserPassword"].ToString();
            user.UserGroup = dt.Rows[0]["UserGroup"].ToString();
            return user;
        }

    }

    
}
