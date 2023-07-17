using DevExpress.XtraBars;
using DevExpress.XtraSplashScreen;
using EasyBuy_BLL;
using EasyBuy_Model;
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
    public partial class UserForm : DevExpress.XtraEditors.XtraForm
    {


        public UserForm()
        {
            InitializeComponent();
        }


        public UserForm(Login login)
        {
            InitializeComponent();
       

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void Exit_Click(object sender, EventArgs e)
        {

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


        void RefreshData()
        {
            List<GoodsInfom> gL = new List<GoodsInfom>();
            try
            {
                gL = new GoodsInfomManager().GetList();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            gInfom_dategridview.AutoGenerateColumns = false;
            gInfom_dategridview.DataSource = gL;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Control controlPanel = new Control();
            controlPanel.Show();
        }

        private void skinDropDownButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {


        }
    
    


    

        private void btnRefresh_Click(object sender, EventArgs e)
        {
 
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
           RefreshData();
        }

        private void gInfom_Search_Click(object sender, EventArgs e)
        {
            string ts = gInfom_tbSelectInfom.Text;
            List<OrderList> list = new List<OrderList>();
            list = new OrderListManager().GetList(gInfom_cbSelect.Text, ts);
            gInfom_dategridview.DataSource = list;
        }
    }
}
