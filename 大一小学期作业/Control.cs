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

        private void pcbtnSearchAll_Click(object sender, EventArgs e)
        {

        }

        private void bbtnGoodsInform_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            xtb_ControlPanel.SelectedTabPage = xtp_GoodsInfom;
        }


        private void cbs_tbSearch_EditValueChanged(object sender, EventArgs e)
        {
            cbs_tbSearch.Text = string.Empty;
            cbs_tbSearch.ForeColor = Color.Black;
        }

    
        private void cbs_tbSearch_MouseEnter(object sender, EventArgs e)
        {

        }

        private void cbs_tbSearch_MouseLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbs_tbSearch.Text))
            {
                cbs_tbSearch.Text = "搜索用户";
                cbs_tbSearch.ForeColor = Color.Gray;
            }
        }

        private void cbs_tbSearch_MouseClick(object sender, MouseEventArgs e)
        {
            if (cbs_tbSearch.Text == "搜索用户")
            {
                cbs_tbSearch.Text = "";
                cbs_tbSearch.ForeColor = Color.Black;
            }
        }

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
            cbs_SuperUserDataGrid.DataSource = superUser;
        }
    }
}