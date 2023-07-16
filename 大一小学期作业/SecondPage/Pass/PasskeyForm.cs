using DevExpress.XtraEditors;
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
    public partial class PasskeyForm : DevExpress.XtraEditors.XtraForm
    {
        bool passwdflag = false;
        Control mainControl;

        public PasskeyForm()
        {
            InitializeComponent();
            RefreshData();


        }

        private void RefreshData()
        {
            List<PassKey> list = new List<PassKey>();
            list = new PassKeyManager().GetPassKeyList();
            dategridview.DataSource = list;
        }

        private void btnAddConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                string deletekey = dategridview.SelectedCells[0].Value.ToString();
                int flag = new PassKeyManager().DeletePassKey(deletekey);

                if (flag > 0)
                {
                    Common.ShowInfo("删除成功");
                }

            }
            catch (Exception ex)
            {

                Common.ShowError(ex.Message);
            }

           
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