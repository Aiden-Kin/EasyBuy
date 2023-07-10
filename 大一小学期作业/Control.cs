using DevExpress.Persistent.Base;
using DevExpress.XtraEditors;
using EasyBuy.SecondPage;
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

namespace EasyBuy
{
    public partial class Control : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        User userInform = new User();
        public Control (User user)
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
        private void shar_tbSearch_MouseLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbs_tbSearcht.Text))
            {
                cbs_tbSearcht.Text = "搜索用户";
                cbs_tbSearcht.ForeColor = Color.Gray;
            }
        }

        private void shar_tbSearch_MouseClick(object sender, MouseEventArgs e)
        {
            if (cbs_tbSearcht.Text == "搜索用户")
            {
                cbs_tbSearcht.Text = "";
                cbs_tbSearcht.ForeColor = Color.Black;
            }
        }



        #endregion


        private void bbtn_GoodsStock_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            xtb_ControlPanel.SelectedTabPage = xtp_GoodsStock;
        }

        private void bbtn_EmploerInfomation_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            xtb_ControlPanel.SelectedTabPage = xtp_StaffInformation;
        }

        private void bbtn_EmploerMoney_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            xtb_ControlPanel.SelectedTabPage = xtp_StafMoney;
        }

        private void bbtn_Supplyer_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            xtb_ControlPanel.SelectedTabPage = xtp_SupplierInformation;
        }

        private void bbtn_SuperUser_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            xtb_ControlPanel.SelectedTabPage = xtp_ControlUserSuper;
        }

        private void bbtn_StafUser_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            xtb_ControlPanel.SelectedTabPage = xtp_StafMoney;
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
            xtb_ControlPanel.SelectedTabPage = xtp_GoodsStock;
        }

        private void ace_StafInformation_Click(object sender, EventArgs e)
        {
            xtb_ControlPanel.SelectedTabPage = xtp_StaffInformation;
        }

        private void ace_StafMoney_Click(object sender, EventArgs e)
        {
            xtb_ControlPanel.SelectedTabPage = xtp_StafMoney;
        }

        private void ace_SupplierInformation_Click(object sender, EventArgs e)
        {
            xtb_ControlPanel.SelectedTabPage = xtp_SupplierInformation;
        }

        private void ace_SuperUser_Click(object sender, EventArgs e)
        {
            xtb_ControlPanel.SelectedTabPage = xtp_ControlUserSuper;
        }

        private void ace_StaffUser_Click(object sender, EventArgs e)
        {
            xtb_ControlPanel.SelectedTabPage = xtp_StafMoney;
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

       private void common_Search(string userGroup,DataGridView dgv)
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


        private void cbs_btnAddUser_Click(object sender, EventArgs e)
        {
            csu_AddUser addUser = new csu_AddUser(this,"SuperUser");
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
                cus_Modify modify = new cus_Modify(this, cbs_SuperUserDataGrid.Rows[row].Cells[0].Value.ToString(), cbs_SuperUserDataGrid.Rows[row].Cells[2].Value.ToString());
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

        #endregion

        private void xtp_ControlUserStaff_VisibleChanged(object sender, EventArgs e)
        {
            if (xtp_ControlUserStaff.Visible)
            {
                cStf_DataRefresh();
            }
        }
    }
}