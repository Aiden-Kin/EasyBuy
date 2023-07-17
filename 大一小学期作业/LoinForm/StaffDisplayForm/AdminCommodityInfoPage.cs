using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyBuy.SecondPage;
using EasyBuy_BLL;
using EasyBuy_Model;
using Sunny.UI;



namespace CampusTradingSystemofNEPU.AdminForms
{
    public partial class AdminCommodityInfoPage : UIPage
    {
         GoodsInfom goodsList = new GoodsInfom();

        public AdminCommodityInfoPage()
        {
            InitializeComponent();
            cmbClassify.SelectedIndex = 0;
            RefreshData();
        }



        public void SelectedItem()//选中类别封装（含选中信息）
        {
            int rowIndex = -1;
            rowIndex = dgvInfo.CurrentRow.Index;
            if (rowIndex < 0)
            {
                UIMessageBox.ShowWarning("没有选中类别！");
            }

            goodsList.ID = Convert.ToInt32(dgvInfo.Rows[rowIndex].Cells[0].Value);
            goodsList.Name = dgvInfo.Rows[rowIndex].Cells[1].Value.ToString();
            goodsList.Class = dgvInfo.Rows[rowIndex].Cells[2].Value.ToString();
            goodsList.Location = dgvInfo.Rows[rowIndex].Cells[3].Value.ToString();
            goodsList.ProductDate = dgvInfo.Rows[rowIndex].Cells[4].Value.ToString();
            goodsList.Repertory = int.Parse(dgvInfo.Rows[rowIndex].Cells[5].Value.ToString());
            goodsList.Supplier =dgvInfo.Rows[rowIndex].Cells[6].Value.ToString();
            goodsList.Price = float.Parse(dgvInfo.Rows[rowIndex].Cells[7].Value.ToString());
            goodsList.Discount = float.Parse(dgvInfo.Rows[rowIndex].Cells[8].Value.ToString());
            goodsList.DPrice = Convert.ToSingle(dgvInfo.Rows[rowIndex].Cells[11].Value);
            goodsList.Remark = dgvInfo.Rows[rowIndex].Cells[9].Value.ToString();
            goodsList.AddTime = dgvInfo.Rows[rowIndex].Cells[10].Value.ToString();
        }

        public void RefreshData()
        {
            dgvInfo.DataSource = new GoodsInfomManager().GetList();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string item = null;
            switch (cmbClassify.SelectedIndex)
            {
                case 0:
                    item = "ID";
                    break;
                case 1:
                    item = "Name";
                    break;
                case 2:
                    item = "Class";
                    break;
                case 3:
                    break;
                case 4:
                    item = "Repertory";
                    break;
                case 5:
                    item = "Supplier";
                    break;

                default:
                    break;
            }

            List<GoodsInfom> table = new List<GoodsInfom> ();
            table = new GoodsInfomManager().GetList(item, tbSearch.Text);
            if (table.Count > 0)
            {
                dgvInfo.DataSource = table;
            }
            else
            {
                UIMessageBox.Show("未找到符合要求的信息.", "信息提示");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void dgvInfo_Click(object sender, EventArgs e)
        {
            int rowIndex = dgvInfo.CurrentRow.Index;
            tbSelectedName.Text = dgvInfo.Rows[rowIndex].Cells[1].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            GoodsInfom_AddGods goodsAddForm = new GoodsInfom_AddGods(this);
            goodsAddForm.ShowDialog();
            RefreshData();
        }

        private void btnAlter_Click(object sender, EventArgs e)
        {
            SelectedItem();

            if (goodsList.Name == "G0")
            {
                UIMessageBox.ShowError("请选择有效数据.");
                return;
            }


            GoodsInfom_ChangeGoods goodsAlterForm = new GoodsInfom_ChangeGoods(goodsList);
            goodsAlterForm.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int rowIndex = -1;
            rowIndex = dgvInfo.CurrentRow.Index;
            if (rowIndex < 0)
            {
                UIMessageBox.ShowWarning("没有选中商品！");
            }
            else if(dgvInfo.Rows[rowIndex].Cells[0].Value.ToString() == "G0")
            {
                UIMessageBox.ShowError("这是系统保留默认项目，不可操作.");
                return;
            }
            else
            {
                if (ShowAskDialog("确定要删除商品 “" + dgvInfo.Rows[rowIndex].Cells[1].Value.ToString() + "” 吗") == false)
                {
                    ShowErrorTip("您取消了删除");
                    return;
                }

                int result = new GoodsInfomManager().Delete(dgvInfo.Rows[rowIndex].Cells[0].Value.ToString());

                if (result > 0)
                {
                    UIMessageBox.Show("删除成功！", "信息提示");
                }
                else
                {
                    UIMessageBox.Show("删除失败.", "信息提示");
                }
            }
            RefreshData();
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            SelectedItem();

        }

        private void cmbClassify_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
