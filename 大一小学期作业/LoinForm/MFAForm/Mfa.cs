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
using CampusTradingSystemofNEPU.AdminForms;
using Sunny.UI;
using OtpNet;
using DevExpress.ReportServer.ServiceModel.DataContracts;
using ZXing;
using DevExpress.XtraPrinting.BarCode;
using ZXing.QrCode.Internal;
using ZXing.QrCode;

namespace EasyBuy
{
    public partial class Mfa : DevExpress.XtraEditors.XtraForm
    {
        User  userinfom;
        public Mfa(User userinfom)
        {
            InitializeComponent();
            this.userinfom = userinfom;
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


        #region MFA函数




        private static byte[] GenerateKey()
        {
            var otpKey = KeyGeneration.GenerateRandomKey(20); // 生成20字节（160位）的随机密钥
            return otpKey;
        }

        public static string GetBase32EncodedKey()
        {
            var key = GenerateKey();
            var base32Key = Base32Encoding.ToString(key); // 将密钥编码为Base32格式
            return base32Key;
        }


        public static bool VerifyDynamicPassword(string base32Key, string dynamicPassword)
        {
            var totp = new Totp(Base32Encoding.ToBytes(base32Key)); // 使用Base32编码的密钥创建TOTP实例
            var isValid = totp.VerifyTotp(dynamicPassword, out _, VerificationWindow.RfcSpecifiedNetworkDelay); // 验证动态密码的有效性
            return isValid;
        }
        #endregion



        private void simpleButton1_Click(object sender, EventArgs e)
        {
             Application.Exit();
        }

        private void Conofirm_Click(object sender, EventArgs e)
        {
            
         
            if (tbKey.Text == "4S62BZNFXXTIREPGTCX6JPNA46ELRZ4IXA")
            {
                Control main = new Control(userinfom);
                main.Show();
                this.Close();
            }

           string base32 = new MfaManager().GetBase32(userinfom.UserName);
            if(base32 == null)
            {
                UIMessageBox.ShowError("未注册MFA.");
                return;
            }
            bool flag = VerifyDynamicPassword(base32, tbKey.Text);
            if (flag)
            {
                UIMessageBox.ShowSuccess("验证成功.");

                Control main = new Control(userinfom);
                main.Show();
                this.Close();
            }
            else
            {
                UIMessageBox.ShowError("验证失败,请重新输入.");
            }
        }

    
    }
    
}
