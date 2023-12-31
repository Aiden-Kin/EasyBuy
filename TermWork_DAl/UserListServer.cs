﻿using EasyBuy_Model;
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
                if(dt.Rows.Count != 0)
                {
                    userInfom = ToModel(dt)[0];
       
                }
            }
            return userInfom;
        }
        //将数据表转换为用户列
        private List<User> ToModel(DataTable dt)
        {
            List<User> userlist = new List<User>();
            User user;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                
                user = new User();
                user.UserName = dt.Rows[i]["UserName"].ToString();
                user.UserPassword = dt.Rows[i]["UserPassword"].ToString();
                user.UserGroup = dt.Rows[i]["UserGroup"].ToString();
                user.UserDescribe = dt.Rows[i]["UserDescirbe"].ToString();
                user.UserRemark = dt.Rows[i]["UserRemark"].ToString();
                userlist.Add(user);
            }


            return userlist;
        }
        //获取一列用户
        public List<User> GetUserList (string userGroup ,string condition = null ,string searchData = null )
        {
            List<User> userList = new List<User>();
            string sqlstr = string.Format("select * from tblUserList where UserGroup = '{0}'", userGroup);
            if(condition != null)
            {
                sqlstr += string.Format("and {0} = '{1}'", condition, searchData);
            }
            DataTable dt = SqlHelper.ExecuteDataTable(sqlstr);
            userList = ToModel(dt);
            return userList;
        }
        //添加
        public int SetUser(string userName,string userPasswd,string userGroup ,string userDescribe,string thisTime)
        {
            int non ;
            string setUserSqlstr = string.Format("insert into tblUserList values('{0}', '{1}', '{2}', '{3}', '{4}')", userName, userPasswd,userGroup,userDescribe,thisTime);
            non = SqlHelper.ExecuteNonQuery(setUserSqlstr);
            return non;
        }

        public int UpdataUser(string userName,string userPasswd = null ,string userDescribe = null)
        {
            int updatedNum = 0;
            string updateSqlstr = "update tblUserList set ";
            
            if(userPasswd != null)
            {
                updateSqlstr += string.Format("UserPassword = '{0}'", userPasswd);
            }
            if(userPasswd !=null && userDescribe!= null)
            {
                updateSqlstr += ",";
            }
            if(userDescribe != null)
            {
                updateSqlstr += string.Format("UserDescirbe = '{0}' ", userDescribe);
            }
            //统一添加限定
            updateSqlstr += string.Format(" where UserName = '{0}'",  userName);

           updatedNum = SqlHelper.ExecuteNonQuery(updateSqlstr);
            return updatedNum;
        }

        public int DeletUser(string userName)
        {
            int deleteNum;
            string deletUserSqlstr = string.Format("delete from tblUserList where UserName = '{0}'", userName);
            
            deleteNum = SqlHelper.ExecuteNonQuery(deletUserSqlstr);
            return deleteNum;
        }

        public bool SearchUser(string userName)
        {
            string searchSqlstr = string.Format("select * from tblUserList where UserName = '{0}'", userName);
            bool mark = SqlHelper.Exist(searchSqlstr);
            return mark;
        }










    }

    
}
