using DevExpress.XtraEditors;
using EasyBuy_BLL;
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
    public partial class csu_AddUser : DevExpress.XtraEditors.DirectXForm
    {
        bool passwdflag = false;
        
        public csu_AddUser()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddConfirm_Click(object sender, EventArgs e)
        {
            try
            {
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
                    new UserListManager().SetUser(username, userpasswd, userGroup, userDescribe, thisTime);
                }
            }
            catch (Exception)
            {

                throw;
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
    }
}