using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBuy_Model
{
    public class GoodsClass
    {
        private int classID;
        private string className;
        private int parentID;
        private string descreption;
        private string addTime;

        public int ClassID { get => classID; set => classID = value; }
        public string ClassName { get => className; set => className = value; }
        public int ParentID { get => parentID; set => parentID = value; }
        public string Descreption { get => descreption; set => descreption = value; }
        public string AddTime { get => addTime; set => addTime = value; }


    }
}
