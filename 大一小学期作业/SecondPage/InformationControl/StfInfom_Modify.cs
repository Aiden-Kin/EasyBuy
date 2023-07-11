using DevExpress.CodeParser;
using DevExpress.DashboardCommon.DataProcessing;
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
    public partial class StfInfom_Modify : DevExpress.XtraEditors.DirectXForm
    {
        bool passwdflag = false;
        Control mainControl;
        int stfID;

        public StfInfom_Modify(Control mainControl, DataGridViewRow dataRow)
        {
            InitializeComponent();
            this.mainControl = mainControl;
            tbName.Text = dataRow.Cells[1].Value.ToString();
            cbSex.Text = dataRow.Cells[2].Value.ToString();
            tbAge.Text = dataRow.Cells[3].Value.ToString();
            tbPhone.Text = dataRow.Cells[4].Value.ToString();
            cbState.Text = dataRow.Cells[5].Value.ToString();
            tbPositon.Text = dataRow.Cells[6].Value.ToString();
            cbDate.Text = dataRow.Cells[7].Value.ToString();
            stfID = Convert.ToInt32(dataRow.Cells[0].Value);
        }

        #region 窗口属性
        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        ////窗口移动
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnAddConfirm_Click(object sender, EventArgs e)
        {

            try
            {
                StaffInformation staff = new StaffInformation();
                staff.StfName = tbName.Text.Trim();
                staff.StfSex = cbSex.Text.Trim();
                staff.StfPhoneNumber = tbPhone.Text.Trim();
                staff.StfState = cbState.Text.Trim();
                staff.StfPost = tbPositon.Text.Trim();
                staff.StfAddTime = cbDate.Text.Trim();
                staff.StfAge = Convert.ToInt32(tbAge.Text.Trim());
                staff.StfID = stfID;


                int num = new StfInformationManager().UpdataStaffInfo(staff);
                if (num > 0)
                {
                    MessageBox.Show("修改成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                mainControl.stfInfo_RefreshData();
                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            //}
            //private void TextClear()
            //{
            //    this.tbUserName.Clear();
            //    this.tbpasswd.Clear();
            //    this.tbUserDescribe.Clear();
            //    this.tbConfirmPasswd.Clear();
            //}

            //private void tbConfirmPasswd_EditValueChanged(object sender, EventArgs e)
            //{
            //    //密码重复判断并设置flag和提示词
            //    if(tbpasswd.Text!=tbConfirmPasswd.Text)
            //    {
            //        passwdflag = true;
            //        txtPasswdError.Visible = true;
            //    }
            //    else
            //    {
            //        passwdflag = false;
            //        txtPasswdError.Visible = false;
            //    }
            //}

            //private void tbpasswd_EditValueChanged(object sender, EventArgs e)
            //{
            //    tbConfirmPasswd.Text = null;
            //    txtPasswdError.Visible = false;
            //}



        }
    }
}