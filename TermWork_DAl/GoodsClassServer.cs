using EasyBuy_Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBuy_DAL
{
    public class GoodsClassServer
    {
        public class GoodTypeService
        {
            //由DataTable获取Model
            public List<GoodsClass> ToModel(DataTable dt)
            {
                var list = new List<GoodsClass>();
                GoodsClass gt;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    gt = new GoodsClass();
                    gt.ClassID = (int)dt.Rows[i]["ClassID"];
                    gt.ClassName = dt.Rows[i]["ClassName"].ToString();
                    gt.ParentID = (int)dt.Rows[i]["ParentID"];
                    gt.Descreption = dt.Rows[i]["Descreption"].ToString();
                    gt.AddTime = dt.Rows[i]["AddTime"].ToString();


                    list.Add(gt);
                }
                return list;
            }

            public List<GoodsClass> Get()
            {
                string sqlStr = String.Format("SELECT * FROM tblGoodsClass");
                DataSet ds = SqlHelper.ExecuteDataSet(sqlStr);
                return ToModel(ds.Tables[0]);
            }

            public void Add(int parentId, string name, string descreption, string addTime)
            {
                string sqlStr = String.Format("INSERT INTO tblGoodsClass VALUES ('{0}', '{1}','{2}','{3}')", name, parentId, descreption, addTime);
                SqlHelper.ExecuteNonQuery(sqlStr);
            }

            public void Delete(int id)
            {
                string sqlStr = String.Format("DELETE FROM tblGoodsClass WHERE ClassID = '{0}' OR ParentID = '{1}'", id, id);
                SqlHelper.ExecuteNonQuery(sqlStr);
            }

            public void Update(GoodsClass gt)
            {
                string sqlStr = String.Format("UPDATE tblGoodsClass SET ClassName = '{0}', ParentID = '{1}', Descreption = '{2}', AddTime = '{3}' WHERE ClassID = '{4}'", gt.ClassName, gt.ParentID,gt.Descreption,gt.AddTime, gt.ClassID);
                SqlHelper.ExecuteNonQuery(sqlStr);
            }
        }
    }
}
