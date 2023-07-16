using DevExpress.XtraBars;
using DevExpress.XtraSplashScreen;
using EasyBuy_BLL;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;



namespace EasyBuy
{
    public partial class ForgetPasswd : DevExpress.XtraEditors.XtraForm
    {
        private Login login;

        private Random random = new Random();
        bool passwdflag = false;

        public ForgetPasswd()
        {
            InitializeComponent();      
        }


        public ForgetPasswd(Login login)
        {
            InitializeComponent();
            this.login = login;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
      
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            login.LoginShow();
            this.Close();
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

        private void tbConfirmPasswd_EditValueChanged(object sender, EventArgs e)
        {
            //密码重复判断并设置flag和提示词
            if (tbPassword.Text != tbConfirmPasswd.Text)
            {
                passwdflag = true;
                txtPasswdError.Visible = true;
            }
            else
            {
                passwdflag = false;
                txtPasswdError.Visible = false;
            }
        }

        private void tbpasswd_EditValueChanged(object sender, EventArgs e)
        {
            tbConfirmPasswd.Text = null;
            txtPasswdError.Visible = false;
        }


        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                string restKey = tbResetKey.Text;
                string keyTime = new PassKeyManager().GetKeyTime(restKey);
                DateTime Generatedate = Convert.ToDateTime(keyTime);
                if (Generatedate > DateTime.Now.AddHours(-24))
                {
                    int flag = new UserListManager().UpdateUser(tbUser.Text, tbPassword.Text);
                    if (flag > 0)
                    {
                        UIMessageBox.ShowSuccess("密码修改成功.");
                    }
                    else
                    {
                        UIMessageBox.ShowError("密码修改失败.");
                    }

                }
                else
                {
                    UIMessageBox.ShowError("秘钥不正确或者已过期，请重新向管理员申请秘钥.");
                }
            }
            catch (Exception ex)
            {

                UIMessageBox.ShowError(ex.Message);
            }

            
        }
    }
}
