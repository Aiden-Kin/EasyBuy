using DevExpress.XtraEditors;
using DevExpress.XtraMap;
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

namespace EasyBuy.SecondPage
{
    public partial class cus_Modify : DevExpress.XtraEditors.DirectXForm
    {
        bool passwdflag = false;
        Control mainControl;
        
        public cus_Modify(Control mainControl,string userName, string userDescibe)
        {
            InitializeComponent();
            this.mainControl = mainControl;
            this.tbUserName.Text = userName;
            this.tbUserDescribe.Text = userDescibe;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddConfirm_Click(object sender, EventArgs e)
        {
            
            try
            {
                 //校验用户名重复
                if(!new UserListManager().SearchUser(tbUserName.Text))
                {
                    MessageBox.Show("用户不存在", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                //添加用户密码正确校验
                if (passwdflag == true)
                {
                    MessageBox.Show("密码不一致请重新输入", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string username = tbUserName.Text.Trim();
                    string userpasswd = tbpasswd.Text.Trim();
                    string userGroup = "SuperUser";
                    string userDescribe = tbUserDescribe.Text.Trim();
                    string thisTime = DateTime.Now.ToString();
                    new UserListManager().UpdateUser(username, userpasswd, userDescribe);
                    MessageBox.Show("修改成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    mainControl.cus_DataRefresh();
                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void tbConfirmPasswd_EditValueChanged(object sender, EventArgs e)
        {
            //密码重复判断并设置flag和提示词
            if(tbpasswd.Text!=tbConfirmPasswd.Text)
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

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //窗口移动
        private Point mouseOffset;
        private void panelControl1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseOffset = new Point(-e.X, -e.Y);
            }
        }

        private void panelControl1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = System.Windows.Forms.Control.MousePosition;
                mousePos.Offset(mouseOffset.X, mouseOffset.Y);
                this.Location = mousePos;
            }
        }

        private void panelControl1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseOffset = Point.Empty;
        }
    }
}