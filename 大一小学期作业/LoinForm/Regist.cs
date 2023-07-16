using DevExpress.XtraBars;
using DevExpress.XtraMap;
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
    public partial class Regist : DevExpress.XtraEditors.XtraForm
    {
        private Login login;

        private Random random = new Random();

        string identify;
        bool passwdflag = false;

        public Regist()
        {
            InitializeComponent();      
        }


        public Regist(Login login)
        {
            InitializeComponent();
            this.login = login;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshIdentify();
        }
        void RefreshIdentify()
        {
            identify = GenerateCaptcha();      //调用验证码
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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Control controlPanel = new Control();
            controlPanel.Show();
        }

        private void skinDropDownButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {


        }
        #region 注册验证码
        private string GeneraterandomText()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            char[] captchaChars = new char[6];
            for (int i = 0; i < captchaChars.Length; i++)
            {
                captchaChars[i] = chars[random.Next(chars.Length)];
            }
            return new string(captchaChars);
        }
        private string GenerateCaptcha()
        {
            // 生成验证码文本
            string captchaText = GeneraterandomText();

            // 创建位图对象
            Bitmap bitmap = new Bitmap(pbVerification.Width, pbVerification.Height);

            // 使用 Graphics 绘制验证码
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                // 绘制背景
                graphics.Clear(Color.White);

                // 绘制验证码文本
                Font font = new Font("Arial", 18, FontStyle.Bold);
                graphics.DrawString(captchaText, font, Brushes.Black, 10, 10);

                // 绘制噪点
                for (int i = 0; i < 100; i++)
                {
                    int x = random.Next(bitmap.Width);
                    int y = random.Next(bitmap.Height);
                    bitmap.SetPixel(x, y, Color.FromArgb(random.Next(256), random.Next(256), random.Next(256)));
                }
            }

            // 设置 PictureBox 的图像
            pbVerification.Image = bitmap;

            return captchaText;
        }

        void TextClear()
        {
            tbUser.Text = string.Empty;
            tbPassword.Text = string.Empty;
            tbidentify.Text = string.Empty;
            tbConfirmPasswd.Text = string.Empty;
        }

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

        #endregion

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            GenerateCaptcha();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if(tbidentify.Text == identify)
            {


                try
                {
                    //校验用户名重复
                    if (new UserListManager().SearchUser(tbUser.Text))
                    {
                        MessageBox.Show("已存在此用户名请重新输入", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    //添加用户密码正确校验
                    if (passwdflag == true)
                    {
                        MessageBox.Show("密码不一致请重新输入", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        string username = tbUser.Text.Trim();
                        string userpasswd = tbPassword.Text.Trim();
                        string thisTime = DateTime.Now.ToString();
                        new UserListManager().SetUser(username, userpasswd, "Customer","注册界面注册用户", thisTime);
                        MessageBox.Show("添加成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        TextClear();


                    }

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }


            }
            else
            {
                UIMessageBox.ShowError("验证码错误请重新输入");
                tbidentify.Text = null;
                RefreshIdentify();
            }
        }
    }
}
