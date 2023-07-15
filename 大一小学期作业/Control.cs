using DevExpress.Charts.Native;
using DevExpress.Persistent.Base;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Mask;
using DevExpress.XtraRichEdit.Model;
using EasyBuy.SecondPage;
using EasyBuy.SecondPage.S_GoodsInfom;
using EasyBuy_BLL;
using EasyBuy_Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace EasyBuy
{
    public partial class Control : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        User userInform = new User();
        public Control(User user)
        {

            InitializeComponent();
            this.userInform = user;
        }
        public Control()
        {

            InitializeComponent();
        }

        private void Control_Load(object sender, EventArgs e)
        {
            Nowtimer.Start();

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void xtraTabPage4_Paint(object sender, PaintEventArgs e)
        {

        }


        private void FrmMain_FormClosing(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }



        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            xtb_ControlPanel.SelectedTabPage = xtp_GoodsClass;
        }


        private void bbtnGoodsInform_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            xtb_ControlPanel.SelectedTabPage = xtp_GoodsInfom;
        }


        #region 通用代码

        //搜索框通用显示设定



        #endregion


        private void bbtn_GoodsStock_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
        }

        private void bbtn_EmploerInfomation_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            xtb_ControlPanel.SelectedTabPage = xtp_StaffInformation;
        }

        private void bbtn_EmploerMoney_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            xtb_ControlPanel.SelectedTabPage = xtp_StaffSalary;
        }

        private void bbtn_Supplyer_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
        }

        private void bbtn_SuperUser_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            xtb_ControlPanel.SelectedTabPage = xtp_ControlUserSuper;
        }

        private void bbtn_StafUser_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            xtb_ControlPanel.SelectedTabPage = xtp_ControlUserStaff;
        }

        private void bbtn_CustomerUser_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            xtb_ControlPanel.SelectedTabPage = xtp_ControlUserCustmer; ;
        }

        private void ace_GoodsClass_Click(object sender, EventArgs e)
        {
            xtb_ControlPanel.SelectedTabPage = xtp_GoodsClass;
        }

        private void ace_GoodsInformation_Click(object sender, EventArgs e)
        {
            xtb_ControlPanel.SelectedTabPage = xtp_GoodsInfom;
        }

        private void ace_GoodsStock_Click(object sender, EventArgs e)
        {
        }

        private void ace_StafInformation_Click(object sender, EventArgs e)
        {
            xtb_ControlPanel.SelectedTabPage = xtp_StaffInformation;
        }

        private void ace_StafMoney_Click(object sender, EventArgs e)
        {
            xtb_ControlPanel.SelectedTabPage = xtp_StaffSalary;
        }

        private void ace_SupplierInformation_Click(object sender, EventArgs e)
        {
        }

        private void ace_SuperUser_Click(object sender, EventArgs e)
        {
            xtb_ControlPanel.SelectedTabPage = xtp_ControlUserSuper;
        }

        private void ace_StaffUser_Click(object sender, EventArgs e)
        {
            xtb_ControlPanel.SelectedTabPage = xtp_ControlUserStaff;
        }

        private void ace_Customer_Click(object sender, EventArgs e)
        {
            xtb_ControlPanel.SelectedTabPage = xtp_ControlUserCustmer; ;
        }

        private void accordionControlElement6_Click(object sender, EventArgs e)
        {

        }
        private void Nowtimer_Tick(object sender, EventArgs e)
        {
            TimeSpan currentTime = DateTime.Now.TimeOfDay;
            currentTime = new TimeSpan(currentTime.Hours, currentTime.Minutes, currentTime.Seconds);
            NowTime.EditValue = currentTime;
        }

        //账户管理公用函数区
        #region 账户管理公用函数

        //删除函数
        private delegate void VoidDelegate();

        private void common_Delete(DataGridView dgv, VoidDelegate refresh)
        {
            int deleteNum = 0;
            //提取选中用户
            string deletUserName = dgv.SelectedCells[0].Value.ToString();
            string deletinfom = string.Format("是否确认要删除用户【{0}】", deletUserName);

            DialogResult confirmResult = MessageBox.Show(deletinfom, "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            try
            {
                if (confirmResult == DialogResult.OK)
                {
                    deleteNum = new UserListManager().DeleteUser(deletUserName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (deleteNum > 0)
            {
                MessageBox.Show("删除成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            refresh();
        }

        private void common_Search(string userGroup, DataGridView dgv)
        {
            List<User> superUser = new List<User>();
            try
            {
                superUser = new UserListManager().GetUserList(userGroup, "UserName", cbs_tbSearcht.Text.Trim());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dgv.AutoGenerateColumns = false;
            dgv.DataSource = superUser;
        }


        #endregion


        #region 管理员用户控件区
        //公共函数

        //刷新函数
        public void cus_DataRefresh()
        {
            List<User> superUser = new List<User>();
            try
            {
                superUser = new UserListManager().GetUserList("SuperUser");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            cbs_SuperUserDataGrid.AutoGenerateColumns = false;
            cbs_SuperUserDataGrid.DataSource = superUser;
        }


        private void cbs_btnSearchAll_Click(object sender, EventArgs e)
        {
            List<User> superUser = new List<User>();
            try
            {
                superUser = new UserListManager().GetUserList("SuperUser");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            cbs_SuperUserDataGrid.AutoGenerateColumns = false;
            cbs_SuperUserDataGrid.DataSource = superUser;
        }
        private void cbs_tbSearch_MouseLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbs_tbSearcht.Text))
            {
                cbs_tbSearcht.Text = "搜索用户";
                cbs_tbSearcht.ForeColor = Color.Gray;
            }
        }

        private void cbs_tbSearch_MouseClick(object sender, MouseEventArgs e)
        {
            if (cbs_tbSearcht.Text == "搜索用户")
            {
                cbs_tbSearcht.Text = "";
                cbs_tbSearcht.ForeColor = Color.Black;
            }
        }



        private void cbs_btnAddUser_Click(object sender, EventArgs e)
        {
            csu_AddUser addUser = new csu_AddUser(this, "SuperUser");
            addUser.Show();
        }

        private void cbs_btnDleteUser_Click(object sender, EventArgs e)
        {
            common_Delete(cbs_SuperUserDataGrid, cus_DataRefresh);

        }



        private void cbs_SuperUserDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (e.ColumnIndex == 4)
            {
                cus_Modify modify = new cus_Modify(this, cbs_SuperUserDataGrid.Rows[row].Cells[0].Value.ToString(), cbs_SuperUserDataGrid.Rows[row].Cells[2].Value.ToString(), "SuperUser");
                modify.Show();

            }
        }

        private void xtp_ControlUserSuper_VisibleChanged(object sender, EventArgs e)
        {
            if (xtp_ControlUserSuper.Visible)
            {
                cbs_btnSearchAll.PerformClick();
            }
        }

        private void cus_btSearch_Click(object sender, EventArgs e)
        {
            //List<User> superUser = new List<User>();
            //try
            //{
            //    superUser = new UserListManager().GetUserList("SuperUser", "UserName", cbs_tbSearcht.Text.Trim());

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            //cbs_SuperUserDataGrid.AutoGenerateColumns = false;
            //cbs_SuperUserDataGrid.DataSource = superUser;
            common_Search("SuperUser", cbs_SuperUserDataGrid);
        }
        #endregion


        #region 员工账户控件区
        //公用函数区
        public void cStf_DataRefresh()
        {
            List<User> superUser = new List<User>();
            try
            {
                superUser = new UserListManager().GetUserList("Staff");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            cStaf_dataGridView.AutoGenerateColumns = false;
            cStaf_dataGridView.DataSource = superUser;
        }




        //控件区
        private void cStf_btnSearchAll_Click(object sender, EventArgs e)
        {
            cStf_DataRefresh();
        }

        private void cStf_btnAdd_Click(object sender, EventArgs e)
        {
            csu_AddUser addUser = new csu_AddUser(this, "Staff");
            addUser.Show();
        }

        private void cStf_btnDelete_Click(object sender, EventArgs e)
        {
            common_Delete(cStaf_dataGridView, cStf_DataRefresh);
        }

        private void cStf_btnSearch_Click(object sender, EventArgs e)
        {
            common_Search("Staff", cStaf_dataGridView);
        }
        private void cStf_tbSearchUser_MouseLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cStf_tbSearchUser.Text))
            {
                cStf_tbSearchUser.Text = "搜索用户";
                cStf_tbSearchUser.ForeColor = Color.Gray;
            }
        }

        private void cStf_tbSearchUser_MouseClick(object sender, MouseEventArgs e)
        {
            if (cStf_tbSearchUser.Text == "搜索用户")
            {
                cStf_tbSearchUser.Text = "";
                cStf_tbSearchUser.ForeColor = Color.Black;
            }
        }
        private void xtp_ControlUserStaff_VisibleChanged(object sender, EventArgs e)
        {
            if (xtp_ControlUserStaff.Visible)
            {
                cStf_DataRefresh();
            }
        }

        #endregion



        #region 客户账户控件区
        //公用函数
        public void cCtm_RefreshData()
        {
            List<User> superUser = new List<User>();
            try
            {
                superUser = new UserListManager().GetUserList("Customer");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            cCtm_dataGridView.AutoGenerateColumns = false;
            cCtm_dataGridView.DataSource = superUser;

        }

        //函数区域
        private void cCtm_btnSearchAll_Click(object sender, EventArgs e)
        {
            cCtm_RefreshData();
        }
        private void cCtm_tbSearch_MouseClick(object sender, MouseEventArgs e)
        {
            if (cCtm_tbSearch.Text == "搜索用户")
            {
                cCtm_tbSearch.Text = "";
                cCtm_tbSearch.ForeColor = Color.Black;
            }
        }

        private void cCtm_tbSearch_MouseLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cCtm_tbSearch.Text))
            {
                cCtm_tbSearch.Text = "搜索用户";
                cCtm_tbSearch.ForeColor = Color.Gray;
            }
        }
        private void cCtm_btnAdd_Click(object sender, EventArgs e)
        {
            csu_AddUser addUser = new csu_AddUser(this, "Customer");
            addUser.Show();
        }

        private void xtp_ControlUserCustmer_VisibleChanged(object sender, EventArgs e)
        {
            if (xtp_ControlUserCustmer.Visible)
            {
                cCtm_RefreshData();
            }
        }


        #endregion

        private void cStaf_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (e.ColumnIndex == 4)
            {
                cus_Modify modify = new cus_Modify(this, cStaf_dataGridView.Rows[row].Cells[0].Value.ToString(), cStaf_dataGridView.Rows[row].Cells[2].Value.ToString(), "Staff");
                modify.Show();

            }
        }

        private void cCtm_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (e.ColumnIndex == 4)
            {
                cus_Modify modify = new cus_Modify(this, cCtm_dataGridView.Rows[row].Cells[0].Value.ToString(), cCtm_dataGridView.Rows[row].Cells[2].Value.ToString(), "Customer");
                modify.Show();

            }
        }


        #region 员工信息控件区
        //公共函数
        public void stfInfo_RefreshData()
        {
            List<StaffInformation> staffInformation = new List<StaffInformation>();
            try
            {
                staffInformation = new StfInformationManager().GetStaffInformationList();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            stfInfo_dataGridView.AutoGenerateColumns = false;
            stfInfo_dataGridView.DataSource = staffInformation;
        }


        //控件
        private void stfIfo_btSearchAll_Click(object sender, EventArgs e)
        {
            stfInfo_RefreshData();
        }

        private void xtp_StaffInformation_VisibleChanged(object sender, EventArgs e)
        {
            if (xtp_StaffInformation.Visible)
            {
                stfInfo_RefreshData();
            }
        }

        private void stfInfo_btAdd_Click(object sender, EventArgs e)
        {
            StfInfom_Add addUser = new StfInfom_Add(this);
            addUser.Show();
        }

        private void stfInfo_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (e.ColumnIndex == 8)
            {
                StfInfom_Modify modify = new StfInfom_Modify(this, stfInfo_dataGridView.Rows[row]);
                modify.Show();

            }
        }

        private void stfInfo_btDelete_Click(object sender, EventArgs e)
        {

            int deleteNum = 0;
            //提取选中用户
            string deletStaffID = stfInfo_dataGridView.SelectedCells[0].Value.ToString();
            string deleteStaffName = stfInfo_dataGridView.SelectedCells[1].Value.ToString();
            string deletinfom = string.Format("是否确认要删除ID为【{0}】的员工【{1}】", deletStaffID, deleteStaffName);

            DialogResult confirmResult = MessageBox.Show(deletinfom, "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            try
            {
                if (confirmResult == DialogResult.OK)
                {
                    deleteNum = new StfInformationManager().DeleteUser(deletStaffID);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (deleteNum > 0)
            {
                MessageBox.Show("删除成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            stfInfo_RefreshData();

        }



        #endregion

        #region 商品类控件

        //公用函数与变量
        bool gClass_ifChange = false;
        bool gClass_ifAdd = false;

        private void gClass_ClearControls()
        {
            gClass_tbParentID.Text = "";
            gClass_tbParentName.Text = "";
            gClass_tbClassID.Text = "";
            gClass_tbClassName.Text = "";
        }



        public void gClass_Refresh()
        {
            gClass_TreeView.Nodes.Clear();
            try
            {
                gClass_TreeView.Nodes.Add(new GoodsClassManagers().GetListTreeNode(new GoodsClassManagers().Get()));
            }
            catch (Exception exp)
            {
                Common.ShowError("错误: " + exp.Message);
                return;
            }
            gClass_TreeView.ExpandAll(); //展开全部


            //DataGridView绑定
            gClass_datagridview.DataSource = new GoodsClassManagers().Get();



        }



        //控件区

        private void gClass_btAdd_Click(object sender, EventArgs e)
        {
            GoodsClass_Add goodsClass_Add = new GoodsClass_Add(this, gClass_tbClassID.Text, gClass_tbClassName.Text);
            goodsClass_Add.Show();
        }

        string gClass_describe;

        private void gClass_Modify_Click(object sender, EventArgs e)
        {
            if (gClass_tbClassID.Text == "0" || gClass_tbClassName.Text == string.Empty)
            {
                Common.ShowError("禁止修改根节点或空节点!");
                return;
            }

            int ClassID = Convert.ToInt32(gClass_tbClassID.Text);
            foreach (DataGridViewRow row in gClass_datagridview.Rows)
            {
                int currentID = Convert.ToInt32(row.Cells[0].Value);

                if (currentID == ClassID)
                {
                    gClass_describe = row.Cells[3].Value.ToString();
                    break;

                }

            }
            GoodsClass_Modify goodsClass_modify = new GoodsClass_Modify(this, gClass_tbParentID.Text, gClass_tbParentName.Text, gClass_tbClassID.Text, gClass_tbClassName.Text, gClass_describe);
            goodsClass_modify.Show();
        }

        private void gClass_btDlete_Click(object sender, EventArgs e)
        {
            if (Common.ShowAsk("删除该类别将会导致下属类别和所属商品全部被删除!是否继续?"))
            {
                //继续
                try
                {
                    new GoodsClassManagers().Delete(gClass_tbClassID.Text);
                }
                catch (Exception exp)
                {
                    Common.ShowError("删除失败! 原因: " + exp.Message);
                    return;
                }
                Common.ShowInfo("删除成功!");
            }
            gClass_Refresh();
            gClass_ClearControls();
        }

        private void gClass_TreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {

            TreeNode node = gClass_TreeView.SelectedNode;
            string str = node.Tag.ToString();
            string id = str.Split()[0];
            string parentId = str.Split()[1];
            string parentName = str.Split()[2];


            gClass_tbParentID.Text = parentId;
            gClass_tbParentName.Text = parentName;
            gClass_tbClassID.Text = id;
            gClass_tbClassName.Text = node.Text;


        }

        private void xtp_GoodsClass_VisibleChanged(object sender, EventArgs e)
        {
            if (xtp_GoodsClass.Visible)
            {
                gClass_Refresh();
            }
        }

        private void gClass_datagridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = gClass_datagridview.CurrentRow.Index;//选择行的索引
            //将选中行数据存储到对象student中
            gClass_tbClassID.Text = gClass_datagridview.Rows[rowindex].Cells[0].Value.ToString();
            gClass_tbClassName.Text = gClass_datagridview.Rows[rowindex].Cells[1].Value.ToString();
            gClass_tbParentID.Text = gClass_datagridview.Rows[rowindex].Cells[2].Value.ToString();

            //通过编号索引父类
            int parentID = Convert.ToInt32(gClass_datagridview.Rows[rowindex].Cells[2].Value);
            foreach (DataGridViewRow row in gClass_datagridview.Rows)
            {
                int currentID = Convert.ToInt32(row.Cells[0].Value);

                if (currentID == parentID)
                {
                    gClass_tbParentName.Text = row.Cells[1].Value.ToString();

                }
                else if (parentID == 0)
                {
                    gClass_tbParentName.Text = "商品类型";
                    break;
                }
            }
        }


        private void gClass_btSearchAll_Click(object sender, EventArgs e)
        {
            gClass_Refresh();
        }
        #endregion






        #region 供货商信息区
        //公用函数与变量


        public void SInfo_RefreshData(string condition = "", string find = "")
        {
            List<Supplier> superUser = new List<Supplier>();
            try
            {
                superUser = new SupplierManager().GetList(condition, find);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            SInfo_dategridview.AutoGenerateColumns = false;
            SInfo_dategridview.DataSource = superUser;

        }



        //控件区

        private void SInfo_btSearchAll_Click(object sender, EventArgs e)
        {
            SInfo_RefreshData();
        }

        private void SInfo_btAdd_Click(object sender, EventArgs e)
        {
            Supplier_Add add = new Supplier_Add(this);
            add.Show();
        }

        private void SInfo_btModify_Click(object sender, EventArgs e)
        {
            Supplier sp = new Supplier();
            sp.ID = Convert.ToInt32(SInfo_dategridview.SelectedCells[0].Value);
            sp.Name = SInfo_dategridview.SelectedCells[1].Value.ToString();
            sp.LegalPerson = SInfo_dategridview.SelectedCells[2].Value.ToString();
            sp.Linkman = SInfo_dategridview.SelectedCells[3].Value.ToString();
            sp.LinkPhone = SInfo_dategridview.SelectedCells[4].Value.ToString();
            sp.LinkAddress = SInfo_dategridview.SelectedCells[5].Value.ToString();
            sp.RecordDate = SInfo_dategridview.SelectedCells[6].Value.ToString();
            sp.Remark = SInfo_dategridview.SelectedCells[7].Value.ToString();


            Supplier_Modify add = new Supplier_Modify(this, sp);
            add.Show();
        }

        private void SInfo_btDelete_Click(object sender, EventArgs e)
        {
            try
            {
                new SupplierManager().Delete(SInfo_dategridview.SelectedCells[0].Value.ToString());
                Common.ShowInfo("删除成功");
                SInfo_RefreshData();
            }
            catch (Exception ex)
            {
                Common.ShowError(ex.Message);
            }
        }

        private void SInfo_tbSearch_Click(object sender, EventArgs e)
        {
            List<Supplier> sp = new SupplierManager().GetList(SInfo_cbCelect.Text, SInfo_tbSelectInfom.Text);
            SInfo_dategridview.DataSource = sp;
        }

        private void xtp_Supplier_VisibleChanged(object sender, EventArgs e)
        {
            if (xtp_Supplier.Visible)
            {
                SInfo_RefreshData();
            }
        }

        #endregion

        #region 商品信息区域
        //公共函数与变量
        public void GInform_RefreshData()
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

            gInfom_dategridview.AutoGenerateColumns = false;
            gInfom_dategridview.DataSource = goodsInfom;
        }

        //控件区


        private void xtp_GoodsInfom_VisibleChanged(object sender, EventArgs e)
        {
            if (xtp_GoodsInfom.Visible)
            {
                GInform_RefreshData();
            }
        }

        private void gInfom_btChangeInfom_Click(object sender, EventArgs e)
        {
            GoodsInfom sp = new GoodsInfom();

            sp.ID = Convert.ToInt32(gInfom_dategridview.SelectedCells[0].Value);
            sp.Name = gInfom_dategridview.SelectedCells[1].Value.ToString();
            sp.Class = gInfom_dategridview.SelectedCells[2].Value.ToString();
            sp.Location = gInfom_dategridview.SelectedCells[3].Value.ToString();
            sp.ProductDate = gInfom_dategridview.SelectedCells[4].Value.ToString();
            sp.Repertory = Convert.ToInt32(gInfom_dategridview.SelectedCells[5].Value);
            sp.Supplier = gInfom_dategridview.SelectedCells[6].Value.ToString();
            sp.Price = Convert.ToSingle(gInfom_dategridview.SelectedCells[7].Value);
            sp.Remark = gInfom_dategridview.SelectedCells[8].Value.ToString();
            sp.AddTime = gInfom_dategridview.SelectedCells[9].Value.ToString();


            GoodsInfom_ChangeGoods add = new GoodsInfom_ChangeGoods(this, sp);
            add.Show();
        }



        private void gInfom_btNewGood_Click(object sender, EventArgs e)
        {
            GoodsInfom_AddGods add = new GoodsInfom_AddGods(this);
            add.ShowDialog();
        }

        private void gInfom_btDelete_Click(object sender, EventArgs e)
        {
            try
            {
                new GoodsInfomManager().Delete(gInfom_dategridview.SelectedCells[0].Value.ToString());
                Common.ShowInfo("删除成功");
                GInform_RefreshData();
            }
            catch (Exception ex)
            {
                Common.ShowError(ex.Message);
            }
        }

        private void gInfom_btrepetoryManage_Click(object sender, EventArgs e)
        {
            string gInfom_ID = gInfom_dategridview.SelectedCells[0].Value.ToString();
            string gInfom_Name = gInfom_dategridview.SelectedCells[1].Value.ToString();
            string gInfom_Repor = gInfom_dategridview.SelectedCells[5].Value.ToString();

            GoodsInfom_RepertoryForm gp = new GoodsInfom_RepertoryForm(this, gInfom_ID, gInfom_Name, gInfom_Repor);
            gp.Show();
        }

        private void gInfom_btrDiscount_Click(object sender, EventArgs e)
        {

            string gInfom_ID = gInfom_dategridview.SelectedCells[0].Value.ToString();
            string gInfom_Name = gInfom_dategridview.SelectedCells[1].Value.ToString();
            string gInfom_Repor = gInfom_dategridview.SelectedCells[8].Value.ToString();

            GoodsInfom_DiscountForm ds = new GoodsInfom_DiscountForm(this, gInfom_ID, gInfom_Name, gInfom_Repor);
            ds.Show();
        }


        #endregion

        #region 员工工资区域
        //公共函数
        public void StaffM_Refresh()
        {
            List<StaffSalary> staffSalary = new List<StaffSalary>();
            try
            {
                staffSalary = new StaffSalaryManager().GetStaffInformationList();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            StaffS_datagrid.DataSource = staffSalary;
        }





        //控件区
        private void xtp_StafMoney_VisibleChanged(object sender, EventArgs e)
        {
            if (xtp_StaffSalary.Visible)
            {
                StaffM_Refresh();
            }
        }



        private void StaffS_datagrid_VisibleChanged(object sender, EventArgs e)
        {

        }

        private void StaffS_datagrid_Leave(object sender, EventArgs e)
        {
            List<StaffSalary> dataSource = StaffS_datagrid.DataSource as List<StaffSalary>;
            foreach (StaffSalary staff in dataSource)
            {
                new StaffSalaryManager().UpdateStaffInfo(staff);
            }
        }
        #endregion

        #region 订单管理区域
        //公共函数
        public void OrderL_RefreshData()
        {
            List<OrderList> oL = new List<OrderList>();
            try
            {
                oL = new OrderListManager().GetList();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            OrderL_dataGridView.AutoGenerateColumns = false;
            OrderL_dataGridView.DataSource = oL;
        }





        //控件区


        private void OrderL_AddOrder_Click(object sender, EventArgs e)
        {

        }







    }
     #endregion
}