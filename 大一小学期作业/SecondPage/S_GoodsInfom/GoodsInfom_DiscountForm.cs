﻿using DevExpress.XtraEditors;
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

namespace EasyBuy.SecondPage.S_GoodsInfom
{
    public partial class GoodsInfom_DiscountForm : DevExpress.XtraEditors.XtraForm
    {
   
        Control mainControl;
        float Oprice;
        public GoodsInfom_DiscountForm(Control mainControl, string uid, string name, string price,string discount)
        {
            InitializeComponent();
            tbname.Text = name;
            tbid.Text = uid;
            tbTotal.Text = price;
            this.mainControl = mainControl;
            Oprice = Convert.ToSingle(price);
            tbdiscount.Value = double.Parse(discount);
        }

        private void Clear()
        {

        }

        private void btnAddConfirm_Click(object sender, EventArgs e)
        {
            string disc = tbdiscount.Value.ToString("0.00");
            new GoodsInfomManager().UpPrice(tbid.Text, disc);
            Common.ShowInfo("打折成功");
            mainControl.GInform_RefreshData();
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

        private void GoodsInfom_DiscountForm_Load(object sender, EventArgs e)
        {

        }

        private void tbdiscount_ValueChanged(object sender, double value)
        {
            Double Nprice;
            Nprice = Oprice * tbdiscount.Value;
            tbTotal.Text = Nprice.ToString("0.00");
        }
    }
}