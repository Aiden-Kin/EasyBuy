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
    public partial class AdminMainForm : UIHeaderAsideMainFrame
    {
        string username;

        public AdminMainForm(string username)
        {
            InitializeComponent();
            this.ControlBox = false;
            this.username = username;

            //设置关联
            Aside.TabControl = MainTabControl;

            //增加页面到Main
            AddPage(new AdminSelfWorkPage(username), 1001);
            AddPage(new AdminCommodityInfoPage(), 1002);
            AddPage(new AdminOrderPage(), 1003);


            //设置Header节点索引
            Aside.CreateNode("快捷工作台", 62139, 24, 1001);
            Aside.CreateNode("商品信息管理", 61562, 24, 1002);
            Aside.CreateNode("订单管理服务", 61788, 24, 1003);


            //显示默认界面
            Aside.SelectFirst();
        }


        private void AdminMainForm_Load(object sender, EventArgs e)
        {
            //this.Text = admin.AdminName + "-" + admin.AdminRank;
        }

        private void notifyIcon_DoubleClick(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.Show();
        }

        private void Header_MenuItemClick(string itemText, int menuIndex, int pageIndex)
        {

        }
    }
}
