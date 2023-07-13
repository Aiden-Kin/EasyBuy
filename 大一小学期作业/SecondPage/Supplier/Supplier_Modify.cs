using DevExpress.CodeParser;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Mask;
using DevExpress.XtraMap;
using DevExpress.XtraScheduler.Native;
using DevExpress.XtraSpreadsheet.Import.OpenXml;
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
    public partial class Supplier_Modify : DevExpress.XtraEditors.DirectXForm
    {
        bool passwdflag = false;
        Control mainControl;


        public Supplier_Modify(Control mainControl, Supplier sp)
        {
            InitializeComponent();
            this.mainControl = mainControl;
            tbID.Text = sp.ID.ToString();
            tbName.Text = sp.Name;
            tbLeaglePerson.Text = sp.LegalPerson;
            tbLinkMan.Text = sp.Linkman;
            tbPhone.Text = sp.LinkPhone;
            tbAddress.Text = sp.LinkAddress;
            tbRemark.Text = sp.Remark;



        }


        private void btnAddConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                new SupplierManager().ChangeInfo(tbID.Text, tbName.Text, tbLeaglePerson.Text, tbLinkMan.Text, tbPhone.Text, tbAddress.Text, DateTime.Now.ToString(), tbRemark.Text);
                Common.ShowInfo("修改成功");
                this.Close();
                mainControl.SInfo_RefreshData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        private void TextClear()
        {


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