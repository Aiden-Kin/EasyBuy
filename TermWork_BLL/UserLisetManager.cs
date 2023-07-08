﻿using EasyBuy_DAL;
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
    }
}
