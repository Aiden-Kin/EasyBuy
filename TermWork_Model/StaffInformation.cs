using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBuy_Model
{
    public class StaffInformation
    {
        private int stfID;
        private string stfName;
        private string stfSex;
        private int stfAge;
        private string stfPhoneNumber;
        private string stfState;
        private string stfPost;
        private string stfAddTime;

        public int StfID { get { return stfID; } set { stfID = value; } }
        public string StfName { get {  return stfName; } set { stfName = value; } }
        public string StfSex { get {  return stfSex; } set { stfSex = value; } }
        public int StfAge { get {  return stfAge; } set { stfAge =  value; } }
        public string StfPhoneNumber { get {  return stfPhoneNumber; } set { stfPhoneNumber = value; } }
        public string StfState { get { return stfState; }set { stfState = value; } }
        public string StfPost { get {  return stfPost; } set { stfPost = value; } }
        public string StfAddTime { get {  return stfAddTime; } set { stfAddTime = value; } }

    }
}
