using DevExpress.XtraEditors;
using EasyBuy_BLL;
using EasyBuy_Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyBuy.SecondPage.S_GoodsInfom
{
    public partial class GoodsInfom_TypeSelect_Form : DevExpress.XtraEditors.XtraForm
    {
        bool passwdflag = false;
        Control mainControl;
        string userGroup;
        int typeId;

        public GoodsInfom_TypeSelect_Form()
        {
            InitializeComponent();
            LoadTree();

        }
        private void LoadTree()
        {
            typeTree.Nodes.Clear();
            try
            {
                typeTree.Nodes.Add(new GoodsClassManagers().GetListTreeNode(new GoodsClassManagers().Get()));
            }
            catch (Exception exp)
            {
                Common.ShowError("错误: " + exp.Message);
                return;
            }
            typeTree.ExpandAll(); //展开全部
        }




        private void btnAddConfirm_Click(object sender, EventArgs e)
        {

            if (tbSelected.Text == string.Empty)
            {
                Common.ShowError("请在左侧选择商品类别!");
                return;
            }
            Common.gInfom_SelectedType = tbSelected.Text;
            this.Close();

        }



        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //窗口移动
        private Point mouseOffset;
        private void panelControl1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseOffset = new Point(-e.X, -e.Y);
            }
        }

        private void panelControl1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = System.Windows.Forms.Control.MousePosition;
                mousePos.Offset(mouseOffset.X, mouseOffset.Y);
                this.Location = mousePos;
            }
        }

        private void panelControl1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseOffset = Point.Empty;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            List<GoodsInfom> goodsInfom = new List<GoodsInfom>();
            try
            {
                goodsInfom = new GoodsInfomManager().GetList();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }



        private void treeView1_AfterSelect_1(object sender, TreeViewEventArgs e)
        {
            TreeNode node = typeTree.SelectedNode;
            string str = node.Tag.ToString();
            string id = str.Split()[0];
            string parentId = str.Split()[1];
            string parentName = str.Split()[2];



            tbSelected.Text = node.Text;
        }
    }
}