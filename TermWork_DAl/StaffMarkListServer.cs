using EasyBuy_Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBuy_DAL
{
    public class StaffMarkListServer
    {
        private List<StaffMarkList> ToModel(DataTable dt)
        {
            List<StaffMarkList> markList = new List<StaffMarkList>();
            foreach (DataRow row in dt.Rows)
            {
                StaffMarkList staffMark = new StaffMarkList();
                staffMark.StaffUserID = row["StaffUserID"].ToString();
                staffMark.StaffMarkTime = row["StaffMarkTime"].ToString();
                markList.Add(staffMark);
            }
            return markList;
        }

        public List<StaffMarkList> GetStaffMarkList()
        {
            string sqlStr = "SELECT * FROM tblStaffMarkList";
            DataTable dt = SqlHelper.ExecuteDataTable(sqlStr);
            return ToModel(dt);
        }

        public int SetStaffMarkList(StaffMarkList staffMarkList)
        {
            string setMarkListSqlStr = string.Format("INSERT INTO tblStaffMarkList VALUES ('{0}', '{1}')", staffMarkList.StaffUserID, staffMarkList.StaffMarkTime);
            return SqlHelper.ExecuteNonQuery(setMarkListSqlStr);
        }

        public int DeleteStaffMarkList(string staffUserID)
        {
            string deleteMarkListSqlStr = string.Format("DELETE FROM tblStaffMarkList WHERE StaffUserID = '{0}'", staffUserID);
            return SqlHelper.ExecuteNonQuery(deleteMarkListSqlStr);
        }

        public List<StaffMarkList> GetStaffMarkTime(string staffUserID)
        {
            string sqlStr = string.Format("SELECT * FROM tblStaffMarkList WHERE StaffUserID = '{0}'", staffUserID);
            DataTable dt = SqlHelper.ExecuteDataTable(sqlStr);
            return ToModel(dt);
        }



    }
}

