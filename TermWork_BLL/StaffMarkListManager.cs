using EasyBuy_DAL;
using EasyBuy_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBuy_BLL
{
    public class StaffMarkListManager
    {
        public List<StaffMarkList> GetStaffMarkList()
        {
            return new StaffMarkListServer().GetStaffMarkList();
        }

        public int SetStaffMarkList(StaffMarkList staffMarkList)
        {
            return new StaffMarkListServer().SetStaffMarkList(staffMarkList);
        }

        public string GetStaffMarkTime(string staffUserID)
        {
            List<StaffMarkList> markList = new StaffMarkListServer().GetStaffMarkTime(staffUserID);
            if (markList.Count > 0)
            {
                return markList[0].StaffMarkTime;
            }
            return null;
        }

        public int DeleteStaffMarkList(string staffUserID)
        {
            return new StaffMarkListServer().DeleteStaffMarkList(staffUserID);
        }
    }
}

