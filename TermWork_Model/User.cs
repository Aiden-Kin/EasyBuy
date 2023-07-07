using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBuy_Model
{
    public class User
    {
        private string userName;
        private string userPassword;
        private string userGroup;
        private string userDescribe;
        private string userRemark;

        public string UserGroup { get { return userGroup; } set { userGroup = value; } }
        public string UserName { get { return userName; } set { userName = value; } }
        public string UserPassword { get {  return userPassword; } set {userPassword = value; } }
        public string UserGroupRemark { get { return userDescribe; } set { userDescribe = value; } }
        public string UserRemark { get { return userRemark; } set { userRemark = value; } }
    }
}
