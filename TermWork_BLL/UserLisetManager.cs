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
            return new UserListServer().GetUser(userName, userPassword);
        }
    }
}
