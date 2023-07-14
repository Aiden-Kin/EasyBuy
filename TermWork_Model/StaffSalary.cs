using System;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBuy_Model
{
    public class StaffSalary
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public float OverMoney { get; set; }
        public float BasicSalary { get; set; }
        public float PerformanceMoney { get; set; }
        public float Tax { get; set; }
        public float RealSalary { get; set; }
    }
}
