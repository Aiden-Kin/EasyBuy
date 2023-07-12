using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyBuy
{
    public class Common
    {
        //显示错误信息
        public static void ShowError(string msg)
        {
            MessageBox.Show(msg, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //显示提示信息
        public static void ShowInfo(string msg)
        {
            MessageBox.Show(msg, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //显示询问信息
        public static bool ShowAsk(string msg)
        {
            return MessageBox.Show(msg, "询问", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }

    }
}
