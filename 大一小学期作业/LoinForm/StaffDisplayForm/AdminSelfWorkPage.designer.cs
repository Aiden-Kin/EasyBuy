namespace CampusTradingSystemofNEPU.AdminForms
{
    partial class AdminSelfWorkPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.scltWorkWarning = new Sunny.UI.UIScrollingText();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.uiAvatar1 = new Sunny.UI.UIAvatar();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.tbRank = new Sunny.UI.UITextBox();
            this.tbName = new Sunny.UI.UITextBox();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiAvatar2 = new Sunny.UI.UIAvatar();
            this.dpCardDate = new Sunny.UI.UIDatePicker();
            this.btnCard = new Sunny.UI.UISymbolButton();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiAvatar3 = new Sunny.UI.UIAvatar();
            this.btnExit = new Sunny.UI.UISymbolButton();
            this.tbTimeCode = new Sunny.UI.UITextBox();
            this.uiMarkLabel1 = new Sunny.UI.UIMarkLabel();
            this.uiLine1 = new Sunny.UI.UILine();
            this.btnOrder = new Sunny.UI.UISymbolButton();
            this.btnGoods = new Sunny.UI.UISymbolButton();
            this.SuspendLayout();
            // 
            // scltWorkWarning
            // 
            this.scltWorkWarning.Active = true;
            this.scltWorkWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.scltWorkWarning.Interval = 50;
            this.scltWorkWarning.Location = new System.Drawing.Point(15, 10);
            this.scltWorkWarning.MinimumSize = new System.Drawing.Size(1, 1);
            this.scltWorkWarning.Name = "scltWorkWarning";
            this.scltWorkWarning.Offset = 2;
            this.scltWorkWarning.Radius = 15;
            this.scltWorkWarning.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.scltWorkWarning.Size = new System.Drawing.Size(726, 37);
            this.scltWorkWarning.Style = Sunny.UI.UIStyle.Custom;
            this.scltWorkWarning.StyleCustomMode = true;
            this.scltWorkWarning.TabIndex = 0;
            this.scltWorkWarning.Text = "欢迎使用东油易购销售平台，祝您工作愉快！";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 200;
            // 
            // uiAvatar1
            // 
            this.uiAvatar1.FillColor = System.Drawing.Color.LightBlue;
            this.uiAvatar1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiAvatar1.Location = new System.Drawing.Point(46, 82);
            this.uiAvatar1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiAvatar1.Name = "uiAvatar1";
            this.uiAvatar1.Size = new System.Drawing.Size(83, 75);
            this.uiAvatar1.Style = Sunny.UI.UIStyle.Custom;
            this.uiAvatar1.StyleCustomMode = true;
            this.uiAvatar1.TabIndex = 12;
            this.uiAvatar1.Text = "uiAvatar1";
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.uiLabel1.Location = new System.Drawing.Point(52, 160);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(74, 23);
            this.uiLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel1.StyleCustomMode = true;
            this.uiLabel1.TabIndex = 13;
            this.uiLabel1.Text = "基本信息";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbRank
            // 
            this.tbRank.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbRank.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbRank.Enabled = false;
            this.tbRank.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbRank.Location = new System.Drawing.Point(139, 133);
            this.tbRank.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbRank.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbRank.Name = "tbRank";
            this.tbRank.Padding = new System.Windows.Forms.Padding(5);
            this.tbRank.ShowText = false;
            this.tbRank.Size = new System.Drawing.Size(195, 29);
            this.tbRank.Symbol = 362729;
            this.tbRank.TabIndex = 14;
            this.tbRank.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbRank.Watermark = "权限级别";
            // 
            // tbName
            // 
            this.tbName.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbName.Enabled = false;
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbName.Location = new System.Drawing.Point(139, 88);
            this.tbName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbName.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbName.Name = "tbName";
            this.tbName.Padding = new System.Windows.Forms.Padding(5);
            this.tbName.ShowText = false;
            this.tbName.Size = new System.Drawing.Size(195, 29);
            this.tbName.Symbol = 62144;
            this.tbName.TabIndex = 16;
            this.tbName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbName.Watermark = "管理员名称";
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.uiLabel2.Location = new System.Drawing.Point(395, 154);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(74, 23);
            this.uiLabel2.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel2.StyleCustomMode = true;
            this.uiLabel2.TabIndex = 18;
            this.uiLabel2.Text = "工作打卡";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiAvatar2
            // 
            this.uiAvatar2.FillColor = System.Drawing.Color.LightBlue;
            this.uiAvatar2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiAvatar2.Location = new System.Drawing.Point(389, 76);
            this.uiAvatar2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiAvatar2.Name = "uiAvatar2";
            this.uiAvatar2.Size = new System.Drawing.Size(83, 75);
            this.uiAvatar2.Style = Sunny.UI.UIStyle.Custom;
            this.uiAvatar2.StyleCustomMode = true;
            this.uiAvatar2.Symbol = 62139;
            this.uiAvatar2.TabIndex = 17;
            this.uiAvatar2.Text = "uiAvatar2";
            // 
            // dpCardDate
            // 
            this.dpCardDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.dpCardDate.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.dpCardDate.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dpCardDate.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.dpCardDate.Location = new System.Drawing.Point(479, 127);
            this.dpCardDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dpCardDate.MaxLength = 10;
            this.dpCardDate.MinimumSize = new System.Drawing.Size(63, 0);
            this.dpCardDate.Name = "dpCardDate";
            this.dpCardDate.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.dpCardDate.Size = new System.Drawing.Size(254, 29);
            this.dpCardDate.Style = Sunny.UI.UIStyle.Custom;
            this.dpCardDate.StyleCustomMode = true;
            this.dpCardDate.SymbolDropDown = 61555;
            this.dpCardDate.SymbolNormal = 61555;
            this.dpCardDate.TabIndex = 19;
            this.dpCardDate.Text = "2022-07-02";
            this.dpCardDate.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.dpCardDate.Value = new System.DateTime(2022, 7, 2, 11, 8, 1, 0);
            this.dpCardDate.Watermark = "打卡日期";
            // 
            // btnCard
            // 
            this.btnCard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCard.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCard.Location = new System.Drawing.Point(531, 172);
            this.btnCard.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnCard.Name = "btnCard";
            this.btnCard.Size = new System.Drawing.Size(136, 35);
            this.btnCard.TabIndex = 20;
            this.btnCard.Text = "确认打卡";
            this.btnCard.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCard.Click += new System.EventHandler(this.btnCard_Click);
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.uiLabel3.Location = new System.Drawing.Point(169, 335);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(74, 23);
            this.uiLabel3.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel3.StyleCustomMode = true;
            this.uiLabel3.TabIndex = 22;
            this.uiLabel3.Text = "快捷工作";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiAvatar3
            // 
            this.uiAvatar3.FillColor = System.Drawing.Color.LightBlue;
            this.uiAvatar3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiAvatar3.Location = new System.Drawing.Point(161, 243);
            this.uiAvatar3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiAvatar3.Name = "uiAvatar3";
            this.uiAvatar3.Size = new System.Drawing.Size(91, 79);
            this.uiAvatar3.Style = Sunny.UI.UIStyle.Custom;
            this.uiAvatar3.StyleCustomMode = true;
            this.uiAvatar3.Symbol = 61573;
            this.uiAvatar3.TabIndex = 21;
            this.uiAvatar3.Text = "uiAvatar3";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnExit.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnExit.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.btnExit.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExit.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnExit.Location = new System.Drawing.Point(88, 421);
            this.btnExit.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnExit.Name = "btnExit";
            this.btnExit.Radius = 15;
            this.btnExit.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnExit.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.btnExit.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExit.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExit.Size = new System.Drawing.Size(150, 44);
            this.btnExit.Style = Sunny.UI.UIStyle.Red;
            this.btnExit.StyleCustomMode = true;
            this.btnExit.Symbol = 61579;
            this.btnExit.SymbolSize = 30;
            this.btnExit.TabIndex = 27;
            this.btnExit.Text = "退出面板";
            this.btnExit.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // tbTimeCode
            // 
            this.tbTimeCode.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbTimeCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbTimeCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbTimeCode.Location = new System.Drawing.Point(479, 82);
            this.tbTimeCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbTimeCode.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbTimeCode.Name = "tbTimeCode";
            this.tbTimeCode.Padding = new System.Windows.Forms.Padding(5);
            this.tbTimeCode.ShowText = false;
            this.tbTimeCode.Size = new System.Drawing.Size(254, 29);
            this.tbTimeCode.Symbol = 61463;
            this.tbTimeCode.TabIndex = 26;
            this.tbTimeCode.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbTimeCode.Watermark = "同步时间代码";
            // 
            // uiMarkLabel1
            // 
            this.uiMarkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiMarkLabel1.ForeColor = System.Drawing.Color.Red;
            this.uiMarkLabel1.Location = new System.Drawing.Point(308, 421);
            this.uiMarkLabel1.MarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.uiMarkLabel1.Name = "uiMarkLabel1";
            this.uiMarkLabel1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.uiMarkLabel1.Size = new System.Drawing.Size(372, 44);
            this.uiMarkLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiMarkLabel1.StyleCustomMode = true;
            this.uiMarkLabel1.TabIndex = 28;
            this.uiMarkLabel1.Text = "退出员工销售面板";
            this.uiMarkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLine1
            // 
            this.uiLine1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLine1.Location = new System.Drawing.Point(30, 389);
            this.uiLine1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLine1.Name = "uiLine1";
            this.uiLine1.Size = new System.Drawing.Size(695, 29);
            this.uiLine1.TabIndex = 38;
            // 
            // btnOrder
            // 
            this.btnOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrder.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOrder.Location = new System.Drawing.Point(305, 243);
            this.btnOrder.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(294, 59);
            this.btnOrder.Symbol = 61788;
            this.btnOrder.TabIndex = 41;
            this.btnOrder.Text = "快捷生成订单";
            this.btnOrder.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnGoods
            // 
            this.btnGoods.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGoods.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnGoods.Location = new System.Drawing.Point(305, 308);
            this.btnGoods.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnGoods.Name = "btnGoods";
            this.btnGoods.Size = new System.Drawing.Size(294, 50);
            this.btnGoods.Symbol = 361975;
            this.btnGoods.TabIndex = 42;
            this.btnGoods.Text = "快捷上架新品";
            this.btnGoods.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnGoods.Click += new System.EventHandler(this.btnGoods_Click);
            // 
            // AdminSelfWorkPage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(754, 485);
            this.Controls.Add(this.btnGoods);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.uiLine1);
            this.Controls.Add(this.uiMarkLabel1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.tbTimeCode);
            this.Controls.Add(this.uiLabel3);
            this.Controls.Add(this.uiAvatar3);
            this.Controls.Add(this.btnCard);
            this.Controls.Add(this.dpCardDate);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.uiAvatar2);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbRank);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.uiAvatar1);
            this.Controls.Add(this.scltWorkWarning);
            this.Name = "AdminSelfWorkPage";
            this.PageIndex = 1001;
            this.StyleCustomMode = true;
            this.Text = "AdminSelfWorkPage";
            this.Initialize += new System.EventHandler(this.AdminSelfWorkPage_Initialize);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIScrollingText scltWorkWarning;
        private System.Windows.Forms.Timer timer1;
        private Sunny.UI.UIAvatar uiAvatar1;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UITextBox tbRank;
        private Sunny.UI.UITextBox tbName;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UIAvatar uiAvatar2;
        private Sunny.UI.UIDatePicker dpCardDate;
        private Sunny.UI.UISymbolButton btnCard;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UIAvatar uiAvatar3;
        private Sunny.UI.UISymbolButton btnExit;
        private Sunny.UI.UITextBox tbTimeCode;
        private Sunny.UI.UIMarkLabel uiMarkLabel1;
        private Sunny.UI.UILine uiLine1;
        private Sunny.UI.UISymbolButton btnOrder;
        private Sunny.UI.UISymbolButton btnGoods;
    }
}