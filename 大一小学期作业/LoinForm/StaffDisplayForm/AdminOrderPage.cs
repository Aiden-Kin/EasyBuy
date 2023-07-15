using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyBuy_BLL;
using Sunny.UI;



namespace CampusTradingSystemofNEPU.AdminForms
{
    public partial class AdminOrderPage : UIPage
    {
        //OrderFormList orderFormList = new OrderFormList();

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

            //orderFormList.OrderNumber = dgvInfo.Rows[rowIndex].Cells[0].Value.ToString();
            //orderFormList.OrderCustomerName = dgvInfo.Rows[rowIndex].Cells[4].Value.ToString();
            //orderFormList.OrderCustomerPhone = dgvInfo.Rows[rowIndex].Cells[5].Value.ToString();
            //orderFormList.OrderCustomerAddress = dgvInfo.Rows[rowIndex].Cells[6].Value.ToString();
            //orderFormList.OrderGoodsNumber = dgvInfo.Rows[rowIndex].Cells[7].Value.ToString();
            //orderFormList.OrderGoodsName = dgvInfo.Rows[rowIndex].Cells[8].Value.ToString();
            //orderFormList.OrderGoodsPrice = float.Parse(dgvInfo.Rows[rowIndex].Cells[9].Value.ToString());
            //orderFormList.OrderGoodsCount = int.Parse(dgvInfo.Rows[rowIndex].Cells[10].Value.ToString());
            //orderFormList.OrderTotalPrice = float.Parse(dgvInfo.Rows[rowIndex].Cells[11].Value.ToString());
            //orderFormList.OrderPayWay = dgvInfo.Rows[rowIndex].Cells[1].Value.ToString();
            //orderFormList.OrderPayStatus = dgvInfo.Rows[rowIndex].Cells[3].Value.ToString();
            //orderFormList.OrderPayTime = dgvInfo.Rows[rowIndex].Cells[2].Value.ToString();
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

            //DataTable table = new DataTable();
            //table = new OrderFormListManager().GetOrderByItem(item,tbSearch.Text);
            //if (table.Rows.Count > 0)
            //{
            //    dgvInfo.DataSource = table;
            //}
            //else
            //{
            //    UIMessageBox.Show("未找到符合要求的信息.", "信息提示");
            //}
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
            //OrderEditForm orderEditForm = new OrderEditForm();
            //orderEditForm.ShowDialog();
        }

        private void btnAlter_Click(object sender, EventArgs e)
        {
            SelectedItem();

            //if (orderFormList.OrderNumber == "OF0")
            //{
            //    UIMessageBox.ShowError("这是系统保留默认项目，不可操作.");
            //    return;
            //}

            //OrderEditForm orderEditForm = new OrderEditForm(orderFormList);
            //orderEditForm.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int rowIndex = -1;
            rowIndex = dgvInfo.CurrentRow.Index;
            if (rowIndex < 0)
            {
                UIMessageBox.ShowWarning("没有选中订单！");
            }
            if(dgvInfo.Rows[rowIndex].Cells[0].Value.ToString() == "OF0")
            {
                UIMessageBox.ShowError("这是系统保留默认项目，不可操作.");
                return;
            }
            else
            {
                if (ShowAskDialog("确定要删除订单 “" + dgvInfo.Rows[rowIndex].Cells[0].Value.ToString() + "” 吗") == false)
                {
                    ShowErrorTip("您取消了删除");
                    return;
                }

                //int result = new OrderFormListManager().OrderaDelete(dgvInfo.Rows[rowIndex].Cells[0].Value.ToString());
                //if (result > 0)
                //{
                //    UIMessageBox.Show("删除成功！", "信息提示");
                //}
                //else
                //{
                //    UIMessageBox.Show("删除失败.", "信息提示");
                //}
            }
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            SelectedItem();

            //OrderEditForm orderEditForm = new OrderEditForm(orderFormList,"订单详情");
            //orderEditForm.ShowDialog();
        }
    }
}
