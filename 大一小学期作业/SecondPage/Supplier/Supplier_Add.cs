using DevExpress.CodeParser;
using DevExpress.Utils.Drawing.Helpers;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Mask;
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
    public partial class Supplier_Add : DevExpress.XtraEditors.DirectXForm
    {
        bool passwdflag = false;
        Control mainControl;



        public Supplier_Add(Control mainControl)
        {
            InitializeComponent();
            this.mainControl = mainControl;
        }

        private void Clear()
        {
            tbName.Text = string.Empty;
            tbLeaglePerson.Text = string.Empty;
            tbLinkMan.Text = string.Empty;
            tbPhone.Text = string.Empty;
            tbAddress.Text = string.Empty;
            tbRemark.Text = string.Empty;
        }

        private void btnAddConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                new SupplierManager().Add(tbName.Text, tbLeaglePerson.Text, tbLinkMan.Text, tbPhone.Text, tbAddress.Text, DateTime.Now.ToString(), tbRemark.Text);
                Common.ShowInfo("添加成功");
                Clear();
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