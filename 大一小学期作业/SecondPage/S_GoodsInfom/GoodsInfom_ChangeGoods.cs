using DevExpress.CodeParser;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Mask;
using DevExpress.XtraMap;
using EasyBuy.SecondPage.S_GoodsInfom;
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
    public partial class GoodsInfom_ChangeGoods : DevExpress.XtraEditors.DirectXForm
    {
        bool passwdflag = false;
        Control mainControl;
        int ID;


        public GoodsInfom_ChangeGoods(Control mainControl,GoodsInfom sp)
        {
            InitializeComponent();
            this.mainControl = mainControl;

            tbName.Text = sp.Name;
            tbType.Text = sp.Class;
            tbLocation.Text = sp.Location;
            cbTime.EditValue = Convert.ToDateTime(sp.ProductDate);
            tbRepoertory.Text = sp.Repertory.ToString();
            cbSupplier.Text = sp.Supplier;
            tbMoney.Text = sp.Price.ToString();
            tbDescribe.Text = sp.Remark;
            ID = sp.ID;


        }


        private void btnAddConfirm_Click(object sender, EventArgs e)
        {


            try
            {
                new GoodsInfomManager().ChangeInfo(ID,tbName.Text, tbType.Text.Trim(), tbLocation.Text, cbTime.Text, Convert.ToInt32(tbRepoertory.Text), cbSupplier.Text,Convert.ToSingle(tbMoney.Text), tbDescribe.Text,DateTime.Now.ToString());
                Common.ShowInfo("修改成功");
                mainControl.GInform_RefreshData();
                this.Close();
            }
            catch (Exception exp)
            {
                Common.ShowError("修改失败: " + exp.Message);
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

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            List<GoodsInfom> goodsInfom = new List<GoodsInfom>();
            try
            {
                goodsInfom = new GoodsInfomManager().GetList();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            

        }

        private void TypeMore_Click(object sender, EventArgs e)
        {
            GoodsInfom_TypeSelect_Form type = new GoodsInfom_TypeSelect_Form();
            type.ShowDialog();
            tbType.Text=Common.gInfom_SelectedType;
        }


    }
}