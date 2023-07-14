using EasyBuy_DAL;
using EasyBuy_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBuy_BLL
{
    public class StaffSalaryManager
    {
        public List<StaffSalary> GetStaffInformationList(string condition = null, string searchData = null)
        {
            return new StaffSalaryServer().GetStaffInformationList(condition, searchData);
        }

        public int SetStaffInfo(StaffSalary staff)
        {
            return new StaffSalaryServer().SetStaffInfo(staff);
        }

        public int UpdateStaffInfo(StaffSalary staff)
        {
            return new StaffSalaryServer().UpdateStaffInfo(staff);
        }

        public int DeleteUser(int staffID)
        {
            return new StaffSalaryServer().DeleteUser(staffID);
        }
    }
}
