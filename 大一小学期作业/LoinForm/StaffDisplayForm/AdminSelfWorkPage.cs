using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyBuy_Model;
using Sunny.UI;



namespace CampusTradingSystemofNEPU.AdminForms
{
    public partial class AdminSelfWorkPage : UIPage
    {
        //public AdminInfoList admin = new AdminInfoList();

        public AdminSelfWorkPage()
        {
            InitializeComponent();
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
        }

        public AdminSelfWorkPage(User adminList)
        {
            InitializeComponent();
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;//用于避免时间控件有关异常
            //this.admin = adminList;
            ShowAll();
        }

        public void btnCardSure()//"已打卡"信息封装
        {
            dpCardDate.Enabled = false;
            btnCard.Text = "今日已打卡";
            btnCard.Enabled = false;
            btnCard.FillDisableColor = Color.LightGreen;
            btnCard.ForeDisableColor = Color.White;
            btnCard.SymbolDisableColor = Color.White;
        }

        public void RefreshData()
        {
            //dgvcmbAdminInfo.DataGridView.DataSource = new AdminInfoListManager().GetTable();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void AdminSelfWorkPage_Initialize(object sender, EventArgs e)
        {
            ////权限设置
            //if(admin.AdminRank == "系统管理员")
            //{
            //    groupSystemAdmin.Enabled = true;
            //}
            //else if(admin.AdminRank == "信息操作员")
            //{
            //    groupSystemAdmin.Enabled = false;
            //}

            //打卡时间框设置                       
            dpCardDate.ReadOnly = true;
            System.Timers.Timer timer = new System.Timers.Timer(1000);
            timer.Elapsed += new System.Timers.ElapsedEventHandler(refreshTime);
            timer.AutoReset = true;
            timer.Enabled = true;

            tbTimeCode.ReadOnly = true;

            //若今日已打卡
            //if (admin.AdminWorkCard != null&& admin.AdminWorkCard != string.Empty && admin.AdminWorkCard.Substring(0, 8)==DateTime.Now.ToString("yyyyMMdd"))
            //{
            //    btnCardSure();
            //}

            ////基本信息显示
            //tbName.Text = admin.AdminName;
            //tbRank.Text = admin.AdminRank;
            //tbContact.Text = admin.AdminContactWay + " " + admin.AdminContactDetail;
        }

        public void refreshTime(object source, System.Timers.ElapsedEventArgs e)//刷新时间
        {
            dpCardDate.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            tbTimeCode.Text = "时间代码:"+ DateTime.Now.ToString("yyyyMMddHHmmss");          
        }

        private void btnCard_Click(object sender, EventArgs e)
        {
            //int code = new AdminInfoListManager().ClockIn(DateTime.Now.ToString("yyyyMMddHHmmss"),admin.AdminName);
            //if (code == 1)
            //{
            //    UIMessageBox.Show("管理员 "+ admin.AdminName +" 今日打卡成功!","工作台提示",UIStyle.Green);
            //    btnCardSure();
            //}
            //else
            //{
            //    UIMessageBox.ShowError("打卡失败!");
            //}
        }

        //DataTable dataTable = new AdminInfoListManager().GetTable();

        public void ShowAll()
        {
            
        }

        private void dgvcmbAdminInfo_SelectIndexChange(object sender, int index)
        {
            //dgvcmbAdminInfo.Text = dataTable.Rows[index]["AName"].ToString();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            //AdminEditForm editForm = new AdminEditForm();
            //editForm.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

    

        private void btnDelete_Click(object sender, EventArgs e)
        {
        //    if(dgvcmbAdminInfo.Text == admin.AdminName)
        //    {
        //        UIMessageBox.ShowWarning("禁止删除当前登录账户！");
        //        return;
        //    }
        //    else if(dgvcmbAdminInfo.Text == string.Empty)
        //    {
        //        UIMessageBox.ShowWarning("没有选中操作员！");
        //        return;
        //    }
        //    else if(dgvcmbAdminInfo.Text == "Administor")
        //    {
        //        UIMessageBox.ShowError("这是系统保留管理员，不可删除！");
        //        ShowInfoNotifier("您可以修改此管理员密码以确保最高权限安全");
        //        return;
        //    }
        //    else
        //    {
        //        if (ShowAskDialog("确定要删除管理员 “" + dgvcmbAdminInfo.Text + "” 吗") == false)
        //        {
        //            ShowErrorTip("您取消了删除");
        //            return;
        //        }
        //    }

        //    int result = new AdminInfoListManager().Delete(dgvcmbAdminInfo.Text);
        //        if (result > 0)
        //        {
        //            UIMessageBox.Show("删除操作员成功！", "工作台提示");
        //        }
        //        else
        //        {
        //            UIMessageBox.Show("删除操作员失败.", "工作台提示");
        //        }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            //OrderEditForm orderEditForm = new OrderEditForm();
            //orderEditForm.ShowDialog();
        }

        private void btnGoods_Click(object sender, EventArgs e)
        {
            //GoodsAddForm goodsAddForm = new GoodsAddForm();
            //goodsAddForm.ShowDialog();
        }
    }
}
