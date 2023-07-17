using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CampusTradingSystemofNEPU.AdminForms.OrderFormEditForm;
using EasyBuy_BLL;
using EasyBuy_Model;
using Sunny.UI;



namespace CampusTradingSystemofNEPU.AdminForms
{
    public partial class AdminOrderPage : UIPage
    {
        OrderList orderFormList = new OrderList();

        //DataTable dataTable = new OrderFormListManager().GetOrder();

        public AdminOrderPage()
        {
            InitializeComponent();
            ShowAll();
            cmbClassify.SelectedIndex = 0;
            RefreshData();
        }

        public void ShowAll()
        {


            dgvInfo.ReadOnly = true;
            //this.dgvInfo.DataSource = dataTable;

        }

        public void SelectedItem()//选中封装（含选中信息）
        {
            int rowIndex = -1;
            rowIndex = dgvInfo.CurrentRow.Index;
            if (rowIndex < 0)
            {
                UIMessageBox.ShowWarning("没有选中订单！");
            }

            orderFormList.ONum = Convert.ToInt32(dgvInfo.Rows[rowIndex].Cells[0].Value);
            orderFormList.OCustom = dgvInfo.Rows[rowIndex].Cells[1].Value.ToString();
            orderFormList.OCPhone = dgvInfo.Rows[rowIndex].Cells[2].Value.ToString();
            orderFormList.OCAddress = dgvInfo.Rows[rowIndex].Cells[3].Value.ToString();
            orderFormList.OGoodsNum = Convert.ToInt32(dgvInfo.Rows[rowIndex].Cells[4].Value.ToString());
            orderFormList.OGoodsName = dgvInfo.Rows[rowIndex].Cells[5].Value.ToString();
            orderFormList.OGoodsPrice = float.Parse(dgvInfo.Rows[rowIndex].Cells[6].Value.ToString());
            orderFormList.OGoodsNum = int.Parse(dgvInfo.Rows[rowIndex].Cells[7].Value.ToString());
            orderFormList.OPayWay = dgvInfo.Rows[rowIndex].Cells[8].Value.ToString();
            orderFormList.OTotallyMoney = float.Parse(dgvInfo.Rows[rowIndex].Cells[9].Value.ToString());
            orderFormList.OTime = dgvInfo.Rows[rowIndex].Cells[10].Value.ToString();
      
        }

        public void RefreshData()
        {
            dgvInfo.DataSource = new OrderListManager().GetList();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string item = null;
            switch (cmbClassify.SelectedIndex)
            {
                case 0:
                    item = "ONum";
                    break;
                case 1:
                    item = "OCustomerName";
                    break;
                case 2:
                    item = "OCustomerPhone";
                    break;
                case 3:
                    item = "OCustomerAddress";
                    break;
                case 4:
                    item = "OGNum";
                    break;
                case 5:
                    item = "OGName";
                    break;
                case 6:
                    item = "OPayWay";
                    break;
                case 7:
                    item = "OPayStatus";
                    break;
                case 8:
                    item = "OPayTime";
                    break;
                default:
                    break;
            }

            List<OrderList> table = new List<OrderList>();
            table = new OrderListManager().GetList(item, tbSearch.Text);
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
            tbSelectedName.Text = dgvInfo.Rows[rowIndex].Cells[0].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OrderEditForm orderEditForm = new OrderEditForm(this);
            orderEditForm.ShowDialog();
        }

        private void btnAlter_Click(object sender, EventArgs e)
        {
            SelectedItem();

            if (orderFormList.OGoodsName == null)
            {
                UIMessageBox.ShowError("请选择正确数据.");
                return;
            }

            OrderEditForm orderEditForm = new OrderEditForm(orderFormList);
            orderEditForm.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int rowIndex = -1;
            rowIndex = dgvInfo.CurrentRow.Index;
            if (rowIndex < 0)
            {
                UIMessageBox.ShowWarning("没有选中订单！");
            }
            if (dgvInfo.Rows[rowIndex].Cells[0].Value.ToString() == "OF0")
            {
                UIMessageBox.ShowError("请选择正确订单.");
                return;
            }
            else
            {
                DialogResult res = MessageBox.Show("确定要取消订单 “" + dgvInfo.Rows[rowIndex].Cells[0].Value.ToString() + "” 吗", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (res == DialogResult.Cancel)
                {

                    return;
                }
                GoodsInfom good = new GoodsInfomManager().Get(dgvInfo.Rows[rowIndex].Cells[4].Value.ToString());
                int Nowreper = good.Repertory + Convert.ToInt32(dgvInfo.Rows[rowIndex].Cells[7].Value);
                int result = new OrderListManager().Delete(dgvInfo.Rows[rowIndex].Cells[0].Value.ToString());

                new GoodsInfomManager().UpRepodate(dgvInfo.Rows[rowIndex].Cells[4].Value.ToString(), Nowreper.ToString());

                if (result > 0)
                {
                    UIMessageBox.Show("取消成功！", "信息提示");
                }
                else
                {
                    UIMessageBox.Show("取消失败.", "信息提示");
                }
                RefreshData();

            }
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            SelectedItem();

            OrderEditForm orderEditForm = new OrderEditForm(orderFormList, "订单详情");
            orderEditForm.ShowDialog();
        }
    }
}
