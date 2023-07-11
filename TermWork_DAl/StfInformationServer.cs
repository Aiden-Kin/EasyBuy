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
    public class StfInformationServer
    {

        //public  User GetSingleUser(string userName,string userPassword)  
        //{
        //    StaffInformation stfInfom = new StaffInformation();
        //    string sqlstr = string.Format("select * from tblUserList where UserName ='{0}' and UserPassword = '{1}'", userName,userPassword);
        //    using (DataTable dt = SqlHelper.ExecuteDataTable(sqlstr))
        //    {
        //        stfInfom = ToModel(dt)[0];
        //    }
                
        //    return stfInfom;
        //}


        //将数据表转换为用户列
        private List<StaffInformation> ToModel(DataTable dt)
        {
            List<StaffInformation> userlist = new List<StaffInformation>();
            StaffInformation information;
            for (int i = 0; i < dt.Rows.Count; i++)
            {

                information = new StaffInformation();
                information.StfID = Convert.ToInt32(dt.Rows[i]["StfID"]);
                information.StfName = dt.Rows[i]["StfName"].ToString();
                information.StfSex = dt.Rows[i]["StfSex"].ToString();
                information.StfAge = Convert.ToInt32(dt.Rows[i]["StfAge"]);
                information.StfPhoneNumber = dt.Rows[i]["StfPhoneNumber"].ToString();
                information.StfState = dt.Rows[i]["StfState"].ToString();
                information.StfPost = dt.Rows[i]["StfPost"].ToString();
                information.StfAddTime = dt.Rows[i]["StfAddTime"].ToString();

                userlist.Add(information);
            }


            return userlist;
        }
        //获取一列用户
        public List<StaffInformation> GetUserList (string condition = null ,string searchData = null )
        {
            List<StaffInformation> stfinformationList = new List<StaffInformation>();
            string sqlstr = string.Format("select * from tblStaffInformation ");
            if(condition != null)
            {
                sqlstr += string.Format("where {0} = '{1}'", condition, searchData);
            }
            DataTable dt = SqlHelper.ExecuteDataTable(sqlstr);
            stfinformationList = ToModel(dt);
            return stfinformationList;
        }
        //添加
        public int SetUser(StaffInformation staff)
        {
            
            string setUserSqlstr = string.Format("insert into tblStaffINformation values ('{0}','{1}',{2},'{3}','{4}','{5}','{6}')", staff.StfName, staff.StfSex,staff.StfAge,staff.StfPhoneNumber,staff.StfState,staff.StfPost,staff.StfAddTime);
            return SqlHelper.ExecuteNonQuery(setUserSqlstr);
        }

        public int UpdataStaffInfo(StaffInformation staff)
        {
            int updatedNum = 0;
            string updateSqlstr = string.Format("update tblStaffINformation set  StfName = '{0}', StfSex = '{1}',StfAge = {2},StfPhoneNumber = '{3}',StfState = '{4}',StfPost = '{5}',StfAddTime = '{6}'  where StfID = {7}", staff.StfName, staff.StfSex, staff.StfAge, staff.StfPhoneNumber, staff.StfState, staff.StfPost, staff.StfAddTime,staff.StfID);

           updatedNum = SqlHelper.ExecuteNonQuery(updateSqlstr);
            return updatedNum;
        }

        public int DeletUser(string deletStaffID)
        {
            string deletUserSqlstr = string.Format("delete from tblStaffINformation where StfID = '{0}'", deletStaffID);
            return SqlHelper.ExecuteNonQuery(deletUserSqlstr);
;
        }

        public bool SearchUser(string userName)
        {
            string searchSqlstr = string.Format("select * from tblUserList where UserName = '{0}'", userName);
            bool mark = SqlHelper.Exist(searchSqlstr);
            return mark;
        }










    }

    
}
