using DevExpress.XtraBars;
using DevExpress.XtraSplashScreen;
using EasyBuy_Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EasyBuy_BLL;
using DevExpress.CodeParser;

namespace EasyBuy
{
    public partial class Login : DevExpress.XtraEditors.XtraForm
    {
   
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #region  窗口移动
        private Point mouseOffset;

        private void sidePanel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseOffset = new Point(-e.X, -e.Y);
            }
        }

        private void sidePanel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = System.Windows.Forms.Control.MousePosition;
                mousePos.Offset(mouseOffset.X, mouseOffset.Y);
                this.Location = mousePos;
            }
        }

        private void sidePanel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseOffset = Point.Empty;
        }
        #endregion

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbUser.Text.Length <= 0 || tbPassword.Text.Length <= 0)
            {
                MessageBox.Show( "请检查用户名称与密码", "登录提示", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                return;
            }

            User UserInform = new UserListManager().GetUser(tbUser.Text.Trim(), tbPassword.Text.Trim());

            if (UserInform.UserGroup == "SuperUser")
            {
                UserInform.UserPassword = null;
                this.Hide();
                Control controlform = new Control(UserInform);
                controlform.Show();
            }
        }

        private void skinDropDownButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btnRegist_Click(object sender, EventArgs e)
        {
            Regist register = new Regist(this);
            register.Show();
            this.Hide();

        }

        //调用显示函数
        public void LoginShow()
        {
            this.Show();
        }


        private void btnForgetPass_Click(object sender, EventArgs e)
        {

        }
    }
}
