using DevExpress.XtraEditors;
using EasyBuy_BLL;
using EasyBuy_Model;
using OtpNet;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing.QrCode;
using ZXing;

namespace EasyBuy.SecondPage.S_GoodsInfom
{
    public partial class MfaCreateForm : DevExpress.XtraEditors.XtraForm
    {

        bool passwdflag = false;
        Control mainControl;
        string username;


        public MfaCreateForm(string username)
        {
            this.username = username;
        }

        #region 窗口移动


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
        private void btnAddConfirm_Click(object sender, EventArgs e)
        {
            // 生成密钥
            var otpKey = KeyGeneration.GenerateRandomKey(20);
            string base32Key = Base32Encoding.ToString(otpKey);
            // 创建二维码内容
            var otpIssuer = "NepuEasyBuy";
            var otpAccount = username;
            var otpUri = $"otpauth://totp/{otpIssuer}:{otpAccount}?secret={base32Key}&issuer={otpIssuer}";

            // 生成二维码图像
            var qrCodeWriter = new BarcodeWriter
            {
                Format = BarcodeFormat.QR_CODE,
                Options = new QrCodeEncodingOptions
                {
                    DisableECI = true,
                    CharacterSet = "UTF-8",
                    Margin = 0,
                    Width = 200,
                    Height = 200
                }
            };
            Bitmap qrCodeBitmap = qrCodeWriter.Write(otpUri);
            //图片绑定
            pictureBox1.Image = qrCodeBitmap;

            //模型绑定
            MfaModel model = new MfaModel();
            model.CreateTime = DateTime.Now.ToString();
            model.UserName = username;
            model.Base32Key = base32Key;
            int res = new MfaManager().SetMfa(model);
            if (res > 0)
            {
                UIMessageBox.ShowSuccess("秘钥二维码生成成功,请使用最新秘钥.");
            }
            else
            {
                UIMessageBox.ShowError("生成失败");
            }


        }


        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}