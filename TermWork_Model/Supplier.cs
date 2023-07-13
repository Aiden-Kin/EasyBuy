using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBuy_Model
{
    public class Supplier
    {
        private int id;
        private string name;
        private string legalPerson;
        private string linkman;
        private string linkPhone;
        private string linkAddress;
        private string recordDate;
        private string remark;

        public int ID { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string LegalPerson { get => legalPerson; set => legalPerson = value; }
        public string Linkman { get => linkman; set => linkman = value; }
        public string LinkPhone { get => linkPhone; set => linkPhone = value; }
        public string LinkAddress { get => linkAddress; set => linkAddress = value; }
        public string RecordDate { get => recordDate; set => recordDate = value; }
        public string Remark { get => remark; set => remark = value; }
    }
}
