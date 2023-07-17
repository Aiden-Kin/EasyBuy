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
using EasyBuy.SecondPage;
using EasyBuy_BLL;
using EasyBuy_Model;
using Sunny.UI;



namespace CampusTradingSystemofNEPU.AdminForms
{
    public partial class AdminSelfWorkPage : UIPage
    {
        //public AdminInfoList admin = new AdminInfoList();
        string username;
        public AdminSelfWorkPage()
        {
            InitializeComponent();
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
        }

        public AdminSelfWorkPage(string adminList)
        {
            InitializeComponent();
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;//用于避免时间控件有关异常
            this.username = adminList;
            ShowAll();
            tbName.Text = "管理员名称："+adminList;

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
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void AdminSelfWorkPage_Initialize(object sender, EventArgs e)
        {
            //打卡时间框设置                       
            dpCardDate.ReadOnly = true;
            System.Timers.Timer timer = new System.Timers.Timer(1000);
            timer.Elapsed += new System.Timers.ElapsedEventHandler(refreshTime);
            timer.AutoReset = true;
            timer.Enabled = true;

            tbTimeCode.ReadOnly = true;

            //若今日已打卡



        }

        public void refreshTime(object source, System.Timers.ElapsedEventArgs e)//刷新时间
        {
            dpCardDate.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            tbTimeCode.Text = "时间代码:"+ DateTime.Now.ToString("yyyyMMddHHmmss");          
        }

        private void btnCard_Click(object sender, EventArgs e)
        {
            //获得用户最新打卡数据

            string newestTime = new StaffMarkListManager().GetStaffMarkTime(username);
            if (Convert.ToInt64(newestTime) + 1000000 > Convert.ToInt64(DateTime.Now.ToString("yyyyMMddHHmmss")))
            {
                UIMessageBox.Show(" 今日已打卡", "工作台提示", UIStyle.Green);
                btnCardSure();
                return;
            }



                StaffMarkList smark = new StaffMarkList();
            smark.StaffUserID = username;
            smark.StaffMarkTime = DateTime.Now.ToString("yyyyMMddHHmmss");
            int code = new StaffMarkListManager().SetStaffMarkList(smark);
            if (code == 1)
            {
                UIMessageBox.Show(" 今日打卡成功!", "工作台提示", UIStyle.Green);
               
            }
            else
            {
                UIMessageBox.ShowError("打卡失败!");
            }
        }

     

        public void ShowAll()
        {
            
        }


    

        private void btnOrder_Click(object sender, EventArgs e)
        {
            OrderEditForm orderEditForm = new OrderEditForm();
            orderEditForm.ShowDialog();
        }

        private void btnGoods_Click(object sender, EventArgs e)
        {
            GoodsInfom_AddGods goodsAddForm = new GoodsInfom_AddGods();
            goodsAddForm.ShowDialog();
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
