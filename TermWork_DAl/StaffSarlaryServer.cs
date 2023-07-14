using EasyBuy_Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBuy_DAL
{
    public class StaffSalaryServer
    {
        private List<StaffSalary> ToModel(DataTable dt)
        {
            List<StaffSalary> userlist = new List<StaffSalary>();
            StaffSalary information;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                information = new StaffSalary();
                information.ID = Convert.ToInt32(dt.Rows[i]["ID"]);
                information.Name = dt.Rows[i]["Name"].ToString();
                information.Position = dt.Rows[i]["Position"].ToString();
                information.OverMoney = Convert.ToSingle(dt.Rows[i]["OverMoney"]);
                information.BasicSalary = Convert.ToSingle(dt.Rows[i]["BasicSalary"]);
                information.PerformanceMoney = Convert.ToSingle(dt.Rows[i]["PerformanceMoney"]);
                information.Tax = Convert.ToSingle(dt.Rows[i]["Tax"]);
                information.RealSalary = Convert.ToSingle(dt.Rows[i]["RealSalary"]);

                userlist.Add(information);
            }

            return userlist;
        }

        public List<StaffSalary> GetStaffInformationList(string condition = null, string searchData = null)
        {
            List<StaffSalary> stfinformationList = new List<StaffSalary>();
            string sqlstr = "SELECT * FROM tblStaffSalary ";
            if (condition != null)
            {
                sqlstr += string.Format("WHERE {0} = '{1}'", condition, searchData);
            }
            DataTable dt = SqlHelper.ExecuteDataTable(sqlstr);
            stfinformationList = ToModel(dt);
            return stfinformationList;
        }

        public int SetStaffInfo(StaffSalary staff)
        {
            string setUserSqlstr = string.Format("INSERT INTO tblStaffSalary VALUES ('{0}', '{1}', {2}, {3}, {4}, {5}, {6})", staff.Name, staff.Position, staff.OverMoney, staff.BasicSalary, staff.PerformanceMoney, staff.Tax, staff.RealSalary);
            return SqlHelper.ExecuteNonQuery(setUserSqlstr);
        }

        public int UpdateStaffInfo(StaffSalary staff)
        {
            string updateSqlstr = string.Format("UPDATE tblStaffSalary SET Name = '{0}', Position = '{1}', OverMoney = {2}, BasicSalary = {3}, PerformanceMoney = {4}, Tax = {5} WHERE ID = {6}", staff.Name, staff.Position, staff.OverMoney, staff.BasicSalary, staff.PerformanceMoney, staff.Tax, staff.ID);
            return SqlHelper.ExecuteNonQuery(updateSqlstr);
        }

        public int DeleteUser(int staffID)
        {
            string deleteUserSqlstr = string.Format("DELETE FROM tblStaffSalary WHERE ID = {0}", staffID);
            return SqlHelper.ExecuteNonQuery(deleteUserSqlstr);
        }
    }
}
