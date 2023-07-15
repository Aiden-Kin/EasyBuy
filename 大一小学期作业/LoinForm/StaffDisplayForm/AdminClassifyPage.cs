using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sunny.UI;



namespace CampusTradingSystemofNEPU.AdminForms
{
    public partial class AdminClassifyPage : UIPage
    {


        public AdminClassifyPage()
        {
            InitializeComponent();
            ShowAll();
            cmbClassify.SelectedIndex = 0;
        }

        public void ShowAll()
        {
            dgvClassifyInfo.AddColumn("类别编号", "CNum");
            dgvClassifyInfo.AddColumn("类别名称", "CName");
            dgvClassifyInfo.AddColumn("类别详情", "CDetails");
            dgvClassifyInfo.AddColumn("添加时间", "CTime");

            dgvClassifyInfo.ReadOnly = true;
            //this.dgvClassifyInfo.DataSource = dataTable;

        }

        public void SelectedClassify()//选中类别封装（含选中信息）
        {
            int rowIndex = -1;
            rowIndex = dgvClassifyInfo.CurrentRow.Index;
            if (rowIndex < 0)
            {
                UIMessageBox.ShowWarning("没有选中类别！");
         }

        //    classifyList.ClassifyNumber = dgvClassifyInfo.Rows[rowIndex].Cells[0].Value.ToString();
        //    classifyList.ClassifyName = dgvClassifyInfo.Rows[rowIndex].Cells[1].Value.ToString();
        //    classifyList.ClassifyDetails = dgvClassifyInfo.Rows[rowIndex].Cells[2].Value.ToString();
        //    classifyList.ClassifyTime = dgvClassifyInfo.Rows[rowIndex].Cells[3].Value.ToString();
        }

        public void RefreshData()
        {
      


  
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string item = null;

            switch(cmbClassify.SelectedIndex)
            {
                case 0:
                    item = "CNum";
                    break;
                case 1:
                    item = "CName";
                    break;
                case 2:
                    item = "CTime";
                    break;
                default:
                    break;
            }

            DataTable table = new DataTable();
       
            if(table.Rows.Count > 0)
            {
                dgvClassifyInfo.DataSource = table;
            }
            else
            {
                UIMessageBox.Show("未找到符合要求的信息.", "信息提示");
            }
        }

        private void dgvClassifyInfo_Click(object sender, EventArgs e)
        {
            int rowIndex = dgvClassifyInfo.CurrentRow.Index;
            tbSelectedName.Text = dgvClassifyInfo.Rows[rowIndex].Cells[1].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
          
        
        }

        private void btnAlter_Click(object sender, EventArgs e)
        {
            SelectedClassify();

            //if (classifyList.ClassifyNumber == "CL0")
            //{
            //    UIMessageBox.ShowError("这是系统保留默认项目，不可操作.");
            //    return;
            //}
            

            //ClassifyAlterForm classifyAlterForm = new ClassifyAlterForm(classifyList);
            //classifyAlterForm.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int rowIndex = -1;
            rowIndex = dgvClassifyInfo.CurrentRow.Index;
            if (rowIndex < 0)
            {
                UIMessageBox.ShowWarning("没有选中类别！");
            }
            else if(dgvClassifyInfo.Rows[rowIndex].Cells[0].Value.ToString() == "CL0")
            {
                UIMessageBox.ShowError("这是系统保留默认项目，不可操作.");
                return;
            }
            else
            {
                if (ShowAskDialog("确定要删除类别 “" + dgvClassifyInfo.Rows[rowIndex].Cells[1].Value.ToString() + "” 吗") == false)
                {
                    ShowErrorTip("您取消了删除");
                    return;
                }

                //int result = new ClassifyListManager().ClassifyDelete(dgvClassifyInfo.Rows[rowIndex].Cells[0].Value.ToString());
                //if (result > 0)
                //{
                //    UIMessageBox.Show("删除成功！", "信息提示");
                //}
                //else
                //{
                //    UIMessageBox.Show("删除失败.", "信息提示");
                //}
            }
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            SelectedClassify();

            //ClassifyAddForm classifyAddForm = new ClassifyAddForm(classifyList);
            //classifyAddForm.ShowDialog();
        }
    }
}
