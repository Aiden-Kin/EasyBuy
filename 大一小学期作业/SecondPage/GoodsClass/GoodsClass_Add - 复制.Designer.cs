namespace EasyBuy.SecondPage
{
    partial class GoodsClass_Add
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GoodsClass_Add));
            this.directXFormContainerControl1 = new DevExpress.XtraEditors.DirectXFormContainerControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.Exit = new DevExpress.XtraEditors.SimpleButton();
            this.txtTetle = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddConfirm = new DevExpress.XtraEditors.SimpleButton();
            this.tbParentID = new DevExpress.XtraEditors.TextEdit();
            this.ClassName = new DevExpress.XtraEditors.TextEdit();
            this.tbParentName = new DevExpress.XtraEditors.TextEdit();
            this.tbUserDescribe = new DevExpress.XtraEditors.MemoEdit();
            this.directXFormContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbParentID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClassName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbParentName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbUserDescribe.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // directXFormContainerControl1
            // 
            this.directXFormContainerControl1.BackColor = System.Drawing.Color.White;
            this.directXFormContainerControl1.Controls.Add(this.panelControl1);
            this.directXFormContainerControl1.Controls.Add(this.labelControl3);
            this.directXFormContainerControl1.Controls.Add(this.labelControl5);
            this.directXFormContainerControl1.Controls.Add(this.labelControl2);
            this.directXFormContainerControl1.Controls.Add(this.labelControl1);
            this.directXFormContainerControl1.Controls.Add(this.btnCancel);
            this.directXFormContainerControl1.Controls.Add(this.btnAddConfirm);
            this.directXFormContainerControl1.Controls.Add(this.tbParentID);
            this.directXFormContainerControl1.Controls.Add(this.ClassName);
            this.directXFormContainerControl1.Controls.Add(this.tbParentName);
            this.directXFormContainerControl1.Controls.Add(this.tbUserDescribe);
            this.directXFormContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.directXFormContainerControl1.Name = "directXFormContainerControl1";
            this.directXFormContainerControl1.Size = new System.Drawing.Size(484, 585);
            this.directXFormContainerControl1.TabIndex = 0;
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(178)))), ((int)(((byte)(201)))));
            this.panelControl1.Appearance.BorderColor = System.Drawing.Color.White;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.Appearance.Options.UseBorderColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.Exit);
            this.panelControl1.Controls.Add(this.txtTetle);
            this.panelControl1.Location = new System.Drawing.Point(6, 6);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(471, 58);
            this.panelControl1.TabIndex = 15;
            this.panelControl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelControl1_MouseDown);
            this.panelControl1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelControl1_MouseMove);
            this.panelControl1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelControl1_MouseUp);
            // 
            // Exit
            // 
            this.Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Exit.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.Exit.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.BottomCenter;
            this.Exit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Exit.ImageOptions.SvgImage")));
            this.Exit.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.Exit.Location = new System.Drawing.Point(427, 14);
            this.Exit.Margin = new System.Windows.Forms.Padding(4);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(29, 30);
            this.Exit.TabIndex = 7;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // txtTetle
            // 
            this.txtTetle.Appearance.Font = new System.Drawing.Font("小米兰亭", 16F);
            this.txtTetle.Appearance.Options.UseFont = true;
            this.txtTetle.Location = new System.Drawing.Point(24, 15);
            this.txtTetle.Name = "txtTetle";
            this.txtTetle.Size = new System.Drawing.Size(132, 29);
            this.txtTetle.TabIndex = 14;
            this.txtTetle.Text = "添加商品类别";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("小米兰亭", 12F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(56, 308);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(64, 22);
            this.labelControl3.TabIndex = 12;
            this.labelControl3.Text = "类别描述";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("小米兰亭", 12F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(56, 229);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(64, 22);
            this.labelControl5.TabIndex = 12;
            this.labelControl5.Text = "类别名称";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("小米兰亭", 12F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(56, 165);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(64, 22);
            this.labelControl2.TabIndex = 12;
            this.labelControl2.Text = "父类名称";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("小米兰亭", 12F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(56, 106);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(64, 22);
            this.labelControl1.TabIndex = 11;
            this.labelControl1.Text = "父类编号";
            // 
            // btnCancel
            // 
            this.btnCancel.Appearance.Font = new System.Drawing.Font("小米兰亭", 10F);
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.Location = new System.Drawing.Point(282, 498);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(131, 42);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "取消";
            this.btnCancel.Click += new System.EventHandler(this.Exit_Click);
            // 
            // btnAddConfirm
            // 
            this.btnAddConfirm.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(178)))), ((int)(((byte)(201)))));
            this.btnAddConfirm.Appearance.Font = new System.Drawing.Font("小米兰亭", 10F);
            this.btnAddConfirm.Appearance.Options.UseBackColor = true;
            this.btnAddConfirm.Appearance.Options.UseFont = true;
            this.btnAddConfirm.Location = new System.Drawing.Point(71, 498);
            this.btnAddConfirm.Name = "btnAddConfirm";
            this.btnAddConfirm.Size = new System.Drawing.Size(123, 42);
            this.btnAddConfirm.TabIndex = 5;
            this.btnAddConfirm.Text = "添加";
            this.btnAddConfirm.Click += new System.EventHandler(this.btnAddConfirm_Click);
            // 
            // tbParentID
            // 
            this.tbParentID.Location = new System.Drawing.Point(178, 105);
            this.tbParentID.Name = "tbParentID";
            this.tbParentID.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.tbParentID.Properties.Appearance.Font = new System.Drawing.Font("小米兰亭", 10F);
            this.tbParentID.Properties.Appearance.Options.UseBackColor = true;
            this.tbParentID.Properties.Appearance.Options.UseFont = true;
            this.tbParentID.Properties.ReadOnly = true;
            this.tbParentID.Size = new System.Drawing.Size(74, 26);
            this.tbParentID.TabIndex = 1;
            // 
            // ClassName
            // 
            this.ClassName.Location = new System.Drawing.Point(178, 228);
            this.ClassName.Name = "ClassName";
            this.ClassName.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.ClassName.Properties.Appearance.Font = new System.Drawing.Font("小米兰亭", 10F);
            this.ClassName.Properties.Appearance.Options.UseBackColor = true;
            this.ClassName.Properties.Appearance.Options.UseFont = true;
            this.ClassName.Size = new System.Drawing.Size(172, 26);
            this.ClassName.TabIndex = 2;
            // 
            // tbParentName
            // 
            this.tbParentName.Location = new System.Drawing.Point(178, 164);
            this.tbParentName.Name = "tbParentName";
            this.tbParentName.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.tbParentName.Properties.Appearance.Font = new System.Drawing.Font("小米兰亭", 10F);
            this.tbParentName.Properties.Appearance.Options.UseBackColor = true;
            this.tbParentName.Properties.Appearance.Options.UseFont = true;
            this.tbParentName.Properties.ReadOnly = true;
            this.tbParentName.Size = new System.Drawing.Size(172, 26);
            this.tbParentName.TabIndex = 2;
            // 
            // tbUserDescribe
            // 
            this.tbUserDescribe.EditValue = "";
            this.tbUserDescribe.Location = new System.Drawing.Point(153, 308);
            this.tbUserDescribe.Name = "tbUserDescribe";
            this.tbUserDescribe.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.tbUserDescribe.Properties.Appearance.Font = new System.Drawing.Font("小米兰亭", 10F);
            this.tbUserDescribe.Properties.Appearance.Options.UseBackColor = true;
            this.tbUserDescribe.Properties.Appearance.Options.UseFont = true;
            this.tbUserDescribe.Size = new System.Drawing.Size(273, 148);
            this.tbUserDescribe.TabIndex = 4;
            // 
            // GoodsClass_Add
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ChildControls.Add(this.directXFormContainerControl1);
            this.ClientSize = new System.Drawing.Size(484, 585);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IconOptions.Image = global::EasyBuy.Properties.Resources.icon;
            this.Name = "GoodsClass_Add";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "管理员用户添加";
            this.directXFormContainerControl1.ResumeLayout(false);
            this.directXFormContainerControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbParentID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClassName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbParentName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbUserDescribe.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.DirectXFormContainerControl directXFormContainerControl1;
        private DevExpress.XtraEditors.SimpleButton btnAddConfirm;
        private DevExpress.XtraEditors.TextEdit tbParentID;
        private DevExpress.XtraEditors.TextEdit tbParentName;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.MemoEdit tbUserDescribe;
        private DevExpress.XtraEditors.LabelControl txtTetle;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton Exit;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit ClassName;
    }
}