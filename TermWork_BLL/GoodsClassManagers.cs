using EasyBuy_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static EasyBuy_DAL.GoodsClassServer;

namespace EasyBuy_BLL
{
    public class GoodsClassManagers
    {
        public List<GoodsClass> Get()
        {
            return new GoodTypeService().Get();
        }

        private TreeNode FindNodeByNo(TreeNode tnParent, string No)
        {
            if (tnParent == null) return null;
            if (tnParent.Tag.ToString().Split(' ')[0] == No) return tnParent;
            TreeNode tnRet = null;
            foreach (TreeNode tn in tnParent.Nodes)
            {
                tnRet = FindNodeByNo(tn, No);
                if (tnRet != null) break;
            }
            return tnRet;
        }

        public TreeNode GetListTreeNode(List<GoodsClass> list)
        {
            TreeNode rootNode = new TreeNode();
            rootNode.Text = "商品类型";
            rootNode.Tag = "0    ";
            for (int i = 0; i < list.Count; i++)
            {
                TreeNode thisNode = new TreeNode();
                int id = list[i].ClassID;
                int parentId = list[i].ParentID;
                thisNode.Text = list[i].ClassName.ToString();
                TreeNode parentNode = (parentId != 0) ? FindNodeByNo(rootNode, parentId + "") : rootNode;
                parentNode.Nodes.Add(thisNode);
                thisNode.Tag = id + " " + parentId + " " + parentNode.Text;
            }
            return rootNode;
        }

        public void Add(string parentIdStr, string name, string descreption, string addTime)
        {
            int parentId;
            if (!Int32.TryParse(parentIdStr, out parentId))
            {
                throw new Exception("父类编号非数字!");
            }
            new GoodTypeService().Add(parentId, name, descreption, addTime);
        }

        public void Delete(string idStr)
        {
            int id;
            if (!Int32.TryParse(idStr, out id))
            {
                throw new Exception("所选类别编号非数字!");
            }
            if (id == 0)
            {
                throw new Exception("禁止删除根节点!");
            }
            new GoodTypeService().Delete(id);
        }

        public void Update(string parentIdStr, string idStr, string name,string Describe ,string NowTime)
        {
            GoodsClass gt = new GoodsClass();
            int parentId;
            int id;
            if (!Int32.TryParse(parentIdStr, out parentId))
            {
                throw new Exception("父类编号非数字!");
            }
            if (!Int32.TryParse(idStr, out id))
            {
                throw new Exception("本商品类别编号非数字!");
            }
            gt.ClassID = id;
            gt.ClassName = name;
            gt.ParentID = parentId;
            gt.Descreption = Describe;
            gt.AddTime = NowTime;

            new GoodTypeService().Update(gt);
        }
    }
}
