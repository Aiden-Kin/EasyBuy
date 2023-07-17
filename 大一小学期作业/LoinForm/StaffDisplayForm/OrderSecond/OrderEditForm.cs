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
using EasyBuy_Model;
using EasyBuy;
using Sunny.UI;
using DevExpress.XtraSpreadsheet.Import.Xls;


namespace CampusTradingSystemofNEPU.AdminForms.OrderFormEditForm
{
    public partial class OrderEditForm : UIEditForm
    {
        OrderList orderFormList = new OrderList();
        GoodsInfom goodsList = new GoodsInfom();
        DataTable dataTable = new GoodsInfomManager().GetGoodsTable();

        private float GoodsPrice;//仅用于本类总价计算方法
        private int GoodsCount = 0;//仅用于本类限制商品库存
        private string GoodsNumber;//仅用于本类库存更新
        EasyBuy.Control CForm;

        public void ShowAll()
        {
            dgvcmbInfo.DataGridView.Init();
            dgvcmbInfo.ItemSize = new System.Drawing.Size(600, 240);

            dgvcmbInfo.DataGridView.AddColumn("编号", "ID");
            dgvcmbInfo.DataGridView.AddColumn("名称", "Name");
            dgvcmbInfo.DataGridView.AddColumn("类别", "Class");

            dgvcmbInfo.DataGridView.AddColumn("产地", "Location");
            dgvcmbInfo.DataGridView.AddColumn("日期", "ProductDate");
            dgvcmbInfo.DataGridView.AddColumn("库存", "Repertory");
            dgvcmbInfo.DataGridView.AddColumn("提供商", "Supplier");
            dgvcmbInfo.DataGridView.AddColumn("原价", "Price");
            dgvcmbInfo.DataGridView.AddColumn("现价", "DPrice");



            dgvcmbInfo.DataGridView.ReadOnly = true;
            this.dgvcmbInfo.DataGridView.DataSource = dataTable;

            dgvcmbInfo.SelectIndexChange += dgvcmbInfo_SelectIndexChange;
            dgvcmbInfo.ShowFilter = true;
            dgvcmbInfo.FilterColumnName = "GName";
        }

        public void ColorChange()//ui色调统一，用于修改窗口
        {
            uiSymbolLabel3.ForeColor = System.Drawing.ColorTranslator.FromHtml("#E3AF53");
            uiSymbolLabel4.ForeColor = System.Drawing.ColorTranslator.FromHtml("#E3AF53");
            uiSymbolLabel5.ForeColor = System.Drawing.ColorTranslator.FromHtml("#E3AF53");
            uiSymbolLabel11.ForeColor = System.Drawing.ColorTranslator.FromHtml("#E3AF53");
            uiSymbolLabel3.SymbolColor = System.Drawing.ColorTranslator.FromHtml("#E3AF53");
            uiSymbolLabel4.SymbolColor = System.Drawing.ColorTranslator.FromHtml("#E3AF53");
            uiSymbolLabel5.SymbolColor = System.Drawing.ColorTranslator.FromHtml("#E3AF53");
            uiSymbolLabel11.SymbolColor = System.Drawing.ColorTranslator.FromHtml("#E3AF53");
        }

        public void tbEnableFalse()//控件不可用,仅供确定退出窗口;详情框用
        {
            tbName.Enabled = false;
            tbPhone.Enabled = false;
            tbAddress.Enabled = false;
            dgvcmbInfo.Enabled = false;
            tbCount.Enabled = false;
     
            dpPayTime.Enabled = false;
            tbTotailPrice.Enabled = false;
            cmbPayWay.Enabled = false;

            btnOK.Visible = false;
         
            btnCancel.Text = "确定";
            btnCancel.Symbol = 61452;
        }

        private void dgvcmbInfo_SelectIndexChange(object sender, int index)
        {
            dgvcmbInfo.Text = dataTable.Rows[index]["GName"].ToString();
            GoodsPrice = float.Parse(dataTable.Rows[index]["GNowPrice"].ToString());
            tbTotailPrice.Text = new OrderListManager().GetTotailPrice(GoodsPrice, tbCount.Value).ToString();//调用bll层总价计算
        }

        private void dgvcmbInfo_ValueChanged(object sender, object value)
        {
            dgvcmbInfo.Text = "";
            if(value !=null && value is DataGridViewRow)
            {
                DataGridViewRow row = (DataGridViewRow)value;
                dgvcmbInfo.Text = row.Cells["名称"].Value.ToString();
                GoodsPrice = float.Parse(row.Cells["现价"].Value.ToString());
                GoodsCount = int.Parse(row.Cells["库存"].Value.ToString());
                GoodsNumber = row.Cells["编号"].Value.ToString();
                tbCount.Enabled = true;
            }
        }
        public OrderEditForm()//增加窗口
        {
            InitializeComponent();
            cmbPayWay.SelectedIndex = 0;

            tbCount.Enabled = false;
        }
        public OrderEditForm(OrderList ol)//增加窗口
        {
            InitializeComponent();

            this.orderFormList = ol;
            GoodsCount = orderFormList.OGoodsNum;

            //窗体和按钮切换
            this.Text = "修改订单信息";
            this.Style = UIStyle.Orange;
            btnAlter.Visible = true;
            btnOK.Visible = false;
            ColorChange();

            tbName.Text = orderFormList.OCustom.ToString();
            tbPhone.Text = orderFormList.OCPhone.ToString();
            tbAddress.Text = orderFormList.OCAddress.ToString();
            dgvcmbInfo.Text = orderFormList.OGoodsName.ToString();
            tbCount.Value = orderFormList.OGoodsNum;

            dpPayTime.Text = orderFormList.OTime.ToString();
            tbTotailPrice.Text = orderFormList.OGoodsPrice.ToString();
            cmbPayWay.Text = orderFormList.OPayWay.ToString();
        }


        public OrderEditForm(AdminOrderPage main)//增加窗口
        {
            InitializeComponent();
            cmbPayWay.SelectedIndex = 0;
    
            tbCount.Enabled = false;
        }
        public OrderEditForm(EasyBuy.Control main)//增加窗口
        {
            InitializeComponent();
            cmbPayWay.SelectedIndex = 0;
            this.CForm = main;
            tbCount.Enabled = false;
        }

        public OrderEditForm(OrderList list,EasyBuy.Control main)//修改窗口
        {
            InitializeComponent();

            this.CForm = main;
            this.orderFormList = list;
            GoodsCount = orderFormList.OGoodsNum;

            //窗体和按钮切换
            this.Text = "修改订单信息";
            this.Style = UIStyle.Orange;
            btnAlter.Visible = true;
            btnOK.Visible = false;
            ColorChange();

            tbName.Text = orderFormList.OCustom.ToString();
            tbPhone.Text = orderFormList.OCPhone.ToString();
            tbAddress.Text = orderFormList.OCAddress.ToString();
            dgvcmbInfo.Text = orderFormList.OGoodsName.ToString();
            tbCount.Value = orderFormList.OGoodsNum;

            dpPayTime.Text = orderFormList.OTime.ToString();
            tbTotailPrice.Text = orderFormList.OGoodsPrice.ToString();
            cmbPayWay.Text = orderFormList.OPayWay.ToString();
        }

        public OrderEditForm(OrderList list, string textString)//详情查找窗口，用textString区分重载
        {
            InitializeComponent();
            this.orderFormList = list;
            this.Text = textString;
            uiMarkLabel1.Visible = false;
            tbEnableFalse();

            GoodsCount = orderFormList.OGoodsNum;

     
            tbName.Text = orderFormList.OCustom.ToString();
            tbPhone.Text = orderFormList.OCPhone.ToString();
            tbAddress.Text = orderFormList.OCAddress.ToString();
            dgvcmbInfo.Text = orderFormList.OGoodsName.ToString();
            tbCount.Value = orderFormList.OGoodsNum;
         
            dpPayTime.Text = orderFormList.OTime.ToString();
            tbTotailPrice.Text = orderFormList.OGoodsPrice.ToString();
            cmbPayWay.Text = orderFormList.OPayWay.ToString();

        }

        private void OrderEditForm_Load(object sender, EventArgs e)//窗口加载：商品信息
        {
            ShowAll();
        }

        private void tbCount_ValueChanged(object sender, int value)
        {
            if (tbCount.Value < 0 || tbCount.Value > GoodsCount)
            {
                UIMessageBox.ShowWarning("数值无效，您仅可在0~" + GoodsCount + "(本商品最大库存)之间选择");
                tbCount.Value = 0;
            }
            tbTotailPrice.Text = new OrderListManager().GetTotailPrice(GoodsPrice, tbCount.Value).ToString();//总价计算    
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if(tbName.Text == string.Empty||tbPhone.Text==string.Empty||tbAddress.Text==string.Empty||dgvcmbInfo.Text==string.Empty)
            {
                UIMessageBox.Show("请填写完整信息！", "信息提示");
                return;
            }
  
            orderFormList.OCustom = tbName.Text;
            orderFormList.OCPhone = tbPhone.Text;
            orderFormList.OCAddress = tbAddress.Text;
            orderFormList.OGoodsID = Convert.ToInt32(dgvcmbInfo.DataGridView.CurrentRow.Cells[0].Value);
            orderFormList.OGoodsName = dgvcmbInfo.DataGridView.CurrentRow.Cells[1].Value.ToString();
            orderFormList.OGoodsPrice = float.Parse(dgvcmbInfo.DataGridView.CurrentRow.Cells[8].Value.ToString());
            orderFormList.OGoodsNum = tbCount.Value;
            orderFormList.OTime = dpPayTime.Text;
            orderFormList.OTotallyMoney = float.Parse(tbTotailPrice.Text);


            orderFormList.OPayWay = cmbPayWay.Text;
            int res = new GoodsInfomManager().UpRepodate( GoodsNumber,Convert.ToString(GoodsCount - tbCount.Value));//库存减少
            int result = new OrderListManager().AddModel(orderFormList);
         

            if (result > 0 || res > 0)
            {
                UIMessageBox.Show("订单添加成功！", "信息提示");
            }
            else
            {
                UIMessageBox.Show("订单添加失败.", "信息提示");
            }
            if (CForm != null)
            {
                CForm.OrderL_RefreshData();
            }
        }

        private void btnAlter_Click(object sender, EventArgs e) 
        {
            int originalCount = orderFormList.OGoodsNum;

            orderFormList.OCustom = tbName.Text;
            orderFormList.OCPhone = tbPhone.Text;
            orderFormList.OCAddress = tbAddress.Text;
            if (dgvcmbInfo.DataGridView.CurrentRow.Cells[0].Value != null)
            {
                orderFormList.OGoodsID = Convert.ToInt32(dgvcmbInfo.DataGridView.CurrentRow.Cells[0].Value);
            }
            orderFormList.OGoodsName = dgvcmbInfo.DataGridView.CurrentRow.Cells[1].Value.ToString();
            orderFormList.OGoodsPrice = float.Parse(dgvcmbInfo.DataGridView.CurrentRow.Cells[8].Value.ToString());
            orderFormList.OGoodsNum = tbCount.Value;
            orderFormList.OTime = dpPayTime.Text;
            orderFormList.OTotallyMoney = float.Parse(tbTotailPrice.Text);
            orderFormList.OPayWay = cmbPayWay.Text.ToString();

            int result = new OrderListManager().ChangeInfo(orderFormList);
            int res = new GoodsInfomManager().UpRepodate(orderFormList.OGoodsID.ToString(), Convert.ToString(GoodsCount - tbCount.Value + originalCount));//库存减少

            if (result > 0)
            {
                UIMessageBox.Show("修改订单信息成功！", "信息提示");
            }
            else
            {
                UIMessageBox.Show("修改订单信息失败或未修改.", "信息提示");
            }
            if (CForm != null)
            {
                CForm.OrderL_RefreshData();
            }
         
            this.Close();
        }

        private void cmbState_SelectedIndexChanged(object sender, EventArgs e)
        {
            dpPayTime.Text = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
