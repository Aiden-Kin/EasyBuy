using DevExpress.CodeParser;
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
    public partial class GoodsClass_Modify : DevExpress.XtraEditors.DirectXForm
    {
        bool passwdflag = false;
        Control mainControl;
        string ClassID;


        public GoodsClass_Modify(Control mainControl, string parentID, string parentName,string ClassID,string ClassName,string describe)
        {
            InitializeComponent();
            this.mainControl = mainControl;
            tbParentID.Text = parentID;
            tbParentName.Text = parentName;
            tbClassName.Text = ClassName;
            this.ClassID = ClassID;
            tbDescribe.Text = describe;
        }


        private void btnAddConfirm_Click(object sender, EventArgs e)
        {

            if (tbParentID.Text == string.Empty)
            {
                tbParentID.Text = "0";
                tbParentName.Text = "商品分类";
            }
            if (tbClassName.Text.Trim() == string.Empty)
            {
                Common.ShowError("请输入分类名称!");
                return;
            }

            //try
            //{
                new GoodsClassManagers().Update(tbParentID.Text, ClassID,tbClassName.Text.Trim(), tbDescribe.Text,DateTime.Now.ToString());
                Common.ShowInfo("修改成功");
                mainControl.gClass_Refresh();
                this.Close();
        //}
        //catch (Exception exp)
        //{
        //    Common.ShowError("修改失败: " + exp.Message);
        //}

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