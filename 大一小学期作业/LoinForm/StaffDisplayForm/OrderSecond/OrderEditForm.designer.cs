namespace CampusTradingSystemofNEPU.AdminForms.OrderFormEditForm
{
    partial class OrderEditForm
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
            this.dgvcmbInfo = new Sunny.UI.UIComboDataGridView();
            this.uiSymbolLabel4 = new Sunny.UI.UISymbolLabel();
            this.tbName = new Sunny.UI.UITextBox();
            this.uiSymbolLabel7 = new Sunny.UI.UISymbolLabel();
            this.uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            this.tbPhone = new Sunny.UI.UITextBox();
            this.uiSymbolLabel2 = new Sunny.UI.UISymbolLabel();
            this.tbAddress = new Sunny.UI.UITextBox();
            this.uiSymbolLabel3 = new Sunny.UI.UISymbolLabel();
            this.uiSymbolLabel5 = new Sunny.UI.UISymbolLabel();
            this.cmbPayWay = new Sunny.UI.UIComboBox();
            this.uiSymbolLabel6 = new Sunny.UI.UISymbolLabel();
            this.tbCount = new Sunny.UI.UIIntegerUpDown();
            this.uiSymbolLabel10 = new Sunny.UI.UISymbolLabel();
            this.uiSymbolLabel11 = new Sunny.UI.UISymbolLabel();
            this.uiSymbolLabel12 = new Sunny.UI.UISymbolLabel();
            this.tbTotailPrice = new Sunny.UI.UITextBox();
            this.uiMarkLabel1 = new Sunny.UI.UIMarkLabel();
            this.uiSymbolLabel8 = new Sunny.UI.UISymbolLabel();
            this.dpPayTime = new Sunny.UI.UIDatetimePicker();
            this.btnAlter = new Sunny.UI.UISymbolButton();
            this.pnlBtm.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBtm
            // 
            this.pnlBtm.Controls.Add(this.btnAlter);
            this.pnlBtm.Location = new System.Drawing.Point(1, 418);
            this.pnlBtm.Size = new System.Drawing.Size(752, 55);
            this.pnlBtm.Controls.SetChildIndex(this.btnOK, 0);
            this.pnlBtm.Controls.SetChildIndex(this.btnCancel, 0);
            this.pnlBtm.Controls.SetChildIndex(this.btnAlter, 0);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(624, 12);
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(512, 12);
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // dgvcmbInfo
            // 
            this.dgvcmbInfo.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.dgvcmbInfo.FillColor = System.Drawing.Color.White;
            this.dgvcmbInfo.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dgvcmbInfo.Location = new System.Drawing.Point(45, 296);
            this.dgvcmbInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvcmbInfo.MinimumSize = new System.Drawing.Size(63, 0);
            this.dgvcmbInfo.Name = "dgvcmbInfo";
            this.dgvcmbInfo.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.dgvcmbInfo.Size = new System.Drawing.Size(275, 30);
            this.dgvcmbInfo.TabIndex = 10;
            this.dgvcmbInfo.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.dgvcmbInfo.Watermark = "选择商品";
            this.dgvcmbInfo.SelectIndexChange += new Sunny.UI.UIDataGridView.OnSelectIndexChange(this.dgvcmbInfo_SelectIndexChange);
            this.dgvcmbInfo.ValueChanged += new Sunny.UI.UIComboDataGridView.OnValueChanged(this.dgvcmbInfo_ValueChanged);
            // 
            // uiSymbolLabel4
            // 
            this.uiSymbolLabel4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.uiSymbolLabel4.Location = new System.Drawing.Point(45, 65);
            this.uiSymbolLabel4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel4.Name = "uiSymbolLabel4";
            this.uiSymbolLabel4.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel4.Size = new System.Drawing.Size(98, 29);
            this.uiSymbolLabel4.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolLabel4.StyleCustomMode = true;
            this.uiSymbolLabel4.Symbol = 62141;
            this.uiSymbolLabel4.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.uiSymbolLabel4.TabIndex = 30;
            this.uiSymbolLabel4.Text = "顾客信息";
            // 
            // tbName
            // 
            this.tbName.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbName.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbName.Location = new System.Drawing.Point(126, 100);
            this.tbName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbName.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbName.Name = "tbName";
            this.tbName.Padding = new System.Windows.Forms.Padding(5);
            this.tbName.ShowText = false;
            this.tbName.Size = new System.Drawing.Size(194, 29);
            this.tbName.TabIndex = 31;
            this.tbName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbName.Watermark = "";
            // 
            // uiSymbolLabel7
            // 
            this.uiSymbolLabel7.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolLabel7.Location = new System.Drawing.Point(34, 100);
            this.uiSymbolLabel7.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel7.Name = "uiSymbolLabel7";
            this.uiSymbolLabel7.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel7.Size = new System.Drawing.Size(76, 29);
            this.uiSymbolLabel7.Symbol = 362720;
            this.uiSymbolLabel7.TabIndex = 32;
            this.uiSymbolLabel7.Text = "姓名";
            // 
            // uiSymbolLabel1
            // 
            this.uiSymbolLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolLabel1.Location = new System.Drawing.Point(30, 139);
            this.uiSymbolLabel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel1.Name = "uiSymbolLabel1";
            this.uiSymbolLabel1.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel1.Size = new System.Drawing.Size(80, 29);
            this.uiSymbolLabel1.Symbol = 61707;
            this.uiSymbolLabel1.TabIndex = 33;
            this.uiSymbolLabel1.Text = "手机";
            // 
            // tbPhone
            // 
            this.tbPhone.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPhone.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbPhone.Location = new System.Drawing.Point(126, 139);
            this.tbPhone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbPhone.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Padding = new System.Windows.Forms.Padding(5);
            this.tbPhone.ShowText = false;
            this.tbPhone.Size = new System.Drawing.Size(194, 29);
            this.tbPhone.TabIndex = 34;
            this.tbPhone.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbPhone.Watermark = "11位中国大陆手机号";
            // 
            // uiSymbolLabel2
            // 
            this.uiSymbolLabel2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolLabel2.Location = new System.Drawing.Point(34, 178);
            this.uiSymbolLabel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel2.Name = "uiSymbolLabel2";
            this.uiSymbolLabel2.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel2.Size = new System.Drawing.Size(76, 29);
            this.uiSymbolLabel2.Symbol = 361461;
            this.uiSymbolLabel2.TabIndex = 35;
            this.uiSymbolLabel2.Text = "地址";
            // 
            // tbAddress
            // 
            this.tbAddress.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbAddress.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbAddress.Location = new System.Drawing.Point(126, 178);
            this.tbAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbAddress.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbAddress.Multiline = true;
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Padding = new System.Windows.Forms.Padding(5);
            this.tbAddress.ShowText = false;
            this.tbAddress.Size = new System.Drawing.Size(194, 61);
            this.tbAddress.TabIndex = 36;
            this.tbAddress.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.tbAddress.Watermark = "";
            // 
            // uiSymbolLabel3
            // 
            this.uiSymbolLabel3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.uiSymbolLabel3.Location = new System.Drawing.Point(45, 259);
            this.uiSymbolLabel3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel3.Name = "uiSymbolLabel3";
            this.uiSymbolLabel3.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel3.Size = new System.Drawing.Size(98, 29);
            this.uiSymbolLabel3.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolLabel3.StyleCustomMode = true;
            this.uiSymbolLabel3.Symbol = 61484;
            this.uiSymbolLabel3.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.uiSymbolLabel3.TabIndex = 37;
            this.uiSymbolLabel3.Text = "商品信息";
            // 
            // uiSymbolLabel5
            // 
            this.uiSymbolLabel5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.uiSymbolLabel5.Location = new System.Drawing.Point(402, 68);
            this.uiSymbolLabel5.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel5.Name = "uiSymbolLabel5";
            this.uiSymbolLabel5.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel5.Size = new System.Drawing.Size(98, 29);
            this.uiSymbolLabel5.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolLabel5.StyleCustomMode = true;
            this.uiSymbolLabel5.Symbol = 61788;
            this.uiSymbolLabel5.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.uiSymbolLabel5.TabIndex = 38;
            this.uiSymbolLabel5.Text = "订单状态";
            // 
            // cmbPayWay
            // 
            this.cmbPayWay.DataSource = null;
            this.cmbPayWay.FillColor = System.Drawing.Color.White;
            this.cmbPayWay.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbPayWay.Items.AddRange(new object[] {
            "现金",
            "数字人民币",
            "云闪付",
            "支付宝",
            "微信支付"});
            this.cmbPayWay.Location = new System.Drawing.Point(525, 166);
            this.cmbPayWay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbPayWay.MinimumSize = new System.Drawing.Size(63, 0);
            this.cmbPayWay.Name = "cmbPayWay";
            this.cmbPayWay.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cmbPayWay.Size = new System.Drawing.Size(164, 29);
            this.cmbPayWay.TabIndex = 39;
            this.cmbPayWay.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmbPayWay.Watermark = "选择支付方式";
            // 
            // uiSymbolLabel6
            // 
            this.uiSymbolLabel6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolLabel6.Location = new System.Drawing.Point(378, 166);
            this.uiSymbolLabel6.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel6.Name = "uiSymbolLabel6";
            this.uiSymbolLabel6.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel6.Size = new System.Drawing.Size(140, 29);
            this.uiSymbolLabel6.Symbol = 61597;
            this.uiSymbolLabel6.TabIndex = 40;
            this.uiSymbolLabel6.Text = "订单支付方式";
            // 
            // tbCount
            // 
            this.tbCount.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbCount.Location = new System.Drawing.Point(182, 352);
            this.tbCount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbCount.MinimumSize = new System.Drawing.Size(100, 0);
            this.tbCount.Name = "tbCount";
            this.tbCount.ShowText = false;
            this.tbCount.Size = new System.Drawing.Size(138, 29);
            this.tbCount.TabIndex = 45;
            this.tbCount.Text = "uiIntegerUpDown1";
            this.tbCount.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.tbCount.ValueChanged += new Sunny.UI.UIIntegerUpDown.OnValueChanged(this.tbCount_ValueChanged);
            // 
            // uiSymbolLabel10
            // 
            this.uiSymbolLabel10.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolLabel10.Location = new System.Drawing.Point(45, 352);
            this.uiSymbolLabel10.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel10.Name = "uiSymbolLabel10";
            this.uiSymbolLabel10.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel10.Size = new System.Drawing.Size(98, 29);
            this.uiSymbolLabel10.Symbol = 61449;
            this.uiSymbolLabel10.TabIndex = 46;
            this.uiSymbolLabel10.Text = "商品数量";
            // 
            // uiSymbolLabel11
            // 
            this.uiSymbolLabel11.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.uiSymbolLabel11.Location = new System.Drawing.Point(402, 240);
            this.uiSymbolLabel11.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel11.Name = "uiSymbolLabel11";
            this.uiSymbolLabel11.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel11.Size = new System.Drawing.Size(98, 29);
            this.uiSymbolLabel11.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolLabel11.StyleCustomMode = true;
            this.uiSymbolLabel11.Symbol = 61546;
            this.uiSymbolLabel11.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.uiSymbolLabel11.TabIndex = 47;
            this.uiSymbolLabel11.Text = "结算确认";
            // 
            // uiSymbolLabel12
            // 
            this.uiSymbolLabel12.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolLabel12.Location = new System.Drawing.Point(401, 275);
            this.uiSymbolLabel12.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel12.Name = "uiSymbolLabel12";
            this.uiSymbolLabel12.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel12.Size = new System.Drawing.Size(129, 29);
            this.uiSymbolLabel12.Symbol = 361783;
            this.uiSymbolLabel12.TabIndex = 48;
            this.uiSymbolLabel12.Text = "本单总价(元)";
            // 
            // tbTotailPrice
            // 
            this.tbTotailPrice.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbTotailPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbTotailPrice.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbTotailPrice.Location = new System.Drawing.Point(550, 275);
            this.tbTotailPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbTotailPrice.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbTotailPrice.Name = "tbTotailPrice";
            this.tbTotailPrice.Padding = new System.Windows.Forms.Padding(5);
            this.tbTotailPrice.ReadOnly = true;
            this.tbTotailPrice.ShowText = false;
            this.tbTotailPrice.Size = new System.Drawing.Size(126, 29);
            this.tbTotailPrice.TabIndex = 49;
            this.tbTotailPrice.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbTotailPrice.Watermark = "";
            // 
            // uiMarkLabel1
            // 
            this.uiMarkLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiMarkLabel1.Location = new System.Drawing.Point(400, 335);
            this.uiMarkLabel1.Name = "uiMarkLabel1";
            this.uiMarkLabel1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.uiMarkLabel1.Size = new System.Drawing.Size(276, 53);
            this.uiMarkLabel1.TabIndex = 50;
            this.uiMarkLabel1.Text = "订单信息确认无误后,点击下方\"确定\"按钮生成销售订单.";
            this.uiMarkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiSymbolLabel8
            // 
            this.uiSymbolLabel8.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolLabel8.Location = new System.Drawing.Point(383, 115);
            this.uiSymbolLabel8.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel8.Name = "uiSymbolLabel8";
            this.uiSymbolLabel8.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel8.Size = new System.Drawing.Size(130, 29);
            this.uiSymbolLabel8.Symbol = 361463;
            this.uiSymbolLabel8.TabIndex = 41;
            this.uiSymbolLabel8.Text = "订单交易时间";
            // 
            // dpPayTime
            // 
            this.dpPayTime.FillColor = System.Drawing.Color.White;
            this.dpPayTime.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dpPayTime.Location = new System.Drawing.Point(525, 115);
            this.dpPayTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dpPayTime.MaxLength = 19;
            this.dpPayTime.MinimumSize = new System.Drawing.Size(63, 0);
            this.dpPayTime.Name = "dpPayTime";
            this.dpPayTime.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.dpPayTime.Size = new System.Drawing.Size(200, 29);
            this.dpPayTime.SymbolDropDown = 61555;
            this.dpPayTime.SymbolNormal = 61555;
            this.dpPayTime.TabIndex = 44;
            this.dpPayTime.Text = "2022-07-05 01:35:01";
            this.dpPayTime.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.dpPayTime.Value = new System.DateTime(2022, 7, 5, 1, 35, 1, 0);
            this.dpPayTime.Watermark = "";
            // 
            // btnAlter
            // 
            this.btnAlter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlter.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAlter.Location = new System.Drawing.Point(512, 12);
            this.btnAlter.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnAlter.Name = "btnAlter";
            this.btnAlter.Size = new System.Drawing.Size(100, 35);
            this.btnAlter.TabIndex = 52;
            this.btnAlter.Text = "确定";
            this.btnAlter.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAlter.Visible = false;
            this.btnAlter.Click += new System.EventHandler(this.btnAlter_Click);
            // 
            // OrderEditForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(754, 476);
            this.Controls.Add(this.uiMarkLabel1);
            this.Controls.Add(this.tbTotailPrice);
            this.Controls.Add(this.uiSymbolLabel12);
            this.Controls.Add(this.uiSymbolLabel11);
            this.Controls.Add(this.uiSymbolLabel10);
            this.Controls.Add(this.tbCount);
            this.Controls.Add(this.dpPayTime);
            this.Controls.Add(this.uiSymbolLabel8);
            this.Controls.Add(this.uiSymbolLabel6);
            this.Controls.Add(this.cmbPayWay);
            this.Controls.Add(this.uiSymbolLabel5);
            this.Controls.Add(this.uiSymbolLabel3);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.uiSymbolLabel2);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.uiSymbolLabel1);
            this.Controls.Add(this.uiSymbolLabel7);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.uiSymbolLabel4);
            this.Controls.Add(this.dgvcmbInfo);
            this.Name = "OrderEditForm";
            this.Text = "销售订单";
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 800, 450);
            this.Load += new System.EventHandler(this.OrderEditForm_Load);
            this.Controls.SetChildIndex(this.dgvcmbInfo, 0);
            this.Controls.SetChildIndex(this.uiSymbolLabel4, 0);
            this.Controls.SetChildIndex(this.tbName, 0);
            this.Controls.SetChildIndex(this.uiSymbolLabel7, 0);
            this.Controls.SetChildIndex(this.uiSymbolLabel1, 0);
            this.Controls.SetChildIndex(this.tbPhone, 0);
            this.Controls.SetChildIndex(this.uiSymbolLabel2, 0);
            this.Controls.SetChildIndex(this.tbAddress, 0);
            this.Controls.SetChildIndex(this.uiSymbolLabel3, 0);
            this.Controls.SetChildIndex(this.uiSymbolLabel5, 0);
            this.Controls.SetChildIndex(this.cmbPayWay, 0);
            this.Controls.SetChildIndex(this.uiSymbolLabel6, 0);
            this.Controls.SetChildIndex(this.uiSymbolLabel8, 0);
            this.Controls.SetChildIndex(this.dpPayTime, 0);
            this.Controls.SetChildIndex(this.tbCount, 0);
            this.Controls.SetChildIndex(this.uiSymbolLabel10, 0);
            this.Controls.SetChildIndex(this.uiSymbolLabel11, 0);
            this.Controls.SetChildIndex(this.uiSymbolLabel12, 0);
            this.Controls.SetChildIndex(this.tbTotailPrice, 0);
            this.Controls.SetChildIndex(this.uiMarkLabel1, 0);
            this.Controls.SetChildIndex(this.pnlBtm, 0);
            this.pnlBtm.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UIComboDataGridView dgvcmbInfo;
        private Sunny.UI.UISymbolLabel uiSymbolLabel4;
        private Sunny.UI.UITextBox tbName;
        private Sunny.UI.UISymbolLabel uiSymbolLabel7;
        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
        private Sunny.UI.UITextBox tbPhone;
        private Sunny.UI.UISymbolLabel uiSymbolLabel2;
        private Sunny.UI.UITextBox tbAddress;
        private Sunny.UI.UISymbolLabel uiSymbolLabel3;
        private Sunny.UI.UISymbolLabel uiSymbolLabel5;
        private Sunny.UI.UIComboBox cmbPayWay;
        private Sunny.UI.UISymbolLabel uiSymbolLabel6;
        private Sunny.UI.UIIntegerUpDown tbCount;
        private Sunny.UI.UISymbolLabel uiSymbolLabel10;
        private Sunny.UI.UISymbolLabel uiSymbolLabel11;
        private Sunny.UI.UISymbolLabel uiSymbolLabel12;
        private Sunny.UI.UITextBox tbTotailPrice;
        private Sunny.UI.UIMarkLabel uiMarkLabel1;
        private Sunny.UI.UISymbolLabel uiSymbolLabel8;
        private Sunny.UI.UIDatetimePicker dpPayTime;
        private Sunny.UI.UISymbolButton btnAlter;
    }
}