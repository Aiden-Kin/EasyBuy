namespace EasyBuy.SecondPage
{
    partial class cus_Modify
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cus_Modify));
            this.directXFormContainerControl1 = new DevExpress.XtraEditors.DirectXFormContainerControl();
            this.txtPasswdError = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.Exit = new DevExpress.XtraEditors.SimpleButton();
            this.txtTitle = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddConfirm = new DevExpress.XtraEditors.SimpleButton();
            this.tbConfirmPasswd = new DevExpress.XtraEditors.TextEdit();
            this.tbUserName = new DevExpress.XtraEditors.TextEdit();
            this.tbpasswd = new DevExpress.XtraEditors.TextEdit();
            this.tbUserDescribe = new DevExpress.XtraEditors.MemoEdit();
            this.directXFormContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbConfirmPasswd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbUserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbpasswd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbUserDescribe.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // directXFormContainerControl1
            // 
            this.directXFormContainerControl1.BackColor = System.Drawing.Color.White;
            this.directXFormContainerControl1.Controls.Add(this.txtPasswdError);
            this.directXFormContainerControl1.Controls.Add(this.panelControl1);
            this.directXFormContainerControl1.Controls.Add(this.labelControl3);
            this.directXFormContainerControl1.Controls.Add(this.labelControl4);
            this.directXFormContainerControl1.Controls.Add(this.labelControl2);
            this.directXFormContainerControl1.Controls.Add(this.labelControl1);
            this.directXFormContainerControl1.Controls.Add(this.btnCancel);
            this.directXFormContainerControl1.Controls.Add(this.btnAddConfirm);
            this.directXFormContainerControl1.Controls.Add(this.tbConfirmPasswd);
            this.directXFormContainerControl1.Controls.Add(this.tbUserName);
            this.directXFormContainerControl1.Controls.Add(this.tbpasswd);
            this.directXFormContainerControl1.Controls.Add(this.tbUserDescribe);
            this.directXFormContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.directXFormContainerControl1.Name = "directXFormContainerControl1";
            this.directXFormContainerControl1.Size = new System.Drawing.Size(504, 650);
            this.directXFormContainerControl1.TabIndex = 0;
            // 
            // txtPasswdError
            // 
            this.txtPasswdError.Appearance.Font = new System.Drawing.Font("小米兰亭", 10F);
            this.txtPasswdError.Appearance.ForeColor = System.Drawing.Color.Brown;
            this.txtPasswdError.Appearance.Options.UseFont = true;
            this.txtPasswdError.Appearance.Options.UseForeColor = true;
            this.txtPasswdError.Location = new System.Drawing.Point(281, 297);
            this.txtPasswdError.Name = "txtPasswdError";
            this.txtPasswdError.Size = new System.Drawing.Size(140, 19);
            this.txtPasswdError.TabIndex = 16;
            this.txtPasswdError.Text = "密码不一致请重新输入";
            this.txtPasswdError.Visible = false;
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(178)))), ((int)(((byte)(201)))));
            this.panelControl1.Appearance.BorderColor = System.Drawing.Color.White;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.Appearance.Options.UseBorderColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.Exit);
            this.panelControl1.Controls.Add(this.txtTitle);
            this.panelControl1.Location = new System.Drawing.Point(6, 6);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(490, 63);
            this.panelControl1.TabIndex = 15;
            this.panelControl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelControl1_MouseDown);
            this.panelControl1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelControl1_MouseMove);
            this.panelControl1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelControl1_MouseUp);
            // 
            // Exit
            // 
            this.Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Exit.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.Exit.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.BottomCenter;
            this.Exit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Exit.ImageOptions.SvgImage")));
            this.Exit.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.Exit.Location = new System.Drawing.Point(456, 7);
            this.Exit.Margin = new System.Windows.Forms.Padding(4);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(29, 30);
            this.Exit.TabIndex = 7;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // txtTitle
            // 
            this.txtTitle.Appearance.Font = new System.Drawing.Font("小米兰亭", 16F);
            this.txtTitle.Appearance.Options.UseFont = true;
            this.txtTitle.Location = new System.Drawing.Point(24, 15);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(154, 29);
            this.txtTitle.TabIndex = 14;
            this.txtTitle.Text = "修改管理员用户";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("小米兰亭", 12F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(47, 389);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(64, 22);
            this.labelControl3.TabIndex = 12;
            this.labelControl3.Text = "用户描述";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("小米兰亭", 12F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(60, 257);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(96, 22);
            this.labelControl4.TabIndex = 12;
            this.labelControl4.Text = "再次输入密码";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("小米兰亭", 12F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(79, 199);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(64, 22);
            this.labelControl2.TabIndex = 12;
            this.labelControl2.Text = "修改密码";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("小米兰亭", 12F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(90, 143);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 22);
            this.labelControl1.TabIndex = 11;
            this.labelControl1.Text = "用户名";
            // 
            // btnCancel
            // 
            this.btnCancel.Appearance.Font = new System.Drawing.Font("小米兰亭", 10F);
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.Location = new System.Drawing.Point(290, 570);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(131, 42);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "取消";
            this.btnCancel.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btnAddConfirm
            // 
            this.btnAddConfirm.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(178)))), ((int)(((byte)(201)))));
            this.btnAddConfirm.Appearance.Font = new System.Drawing.Font("小米兰亭", 10F);
            this.btnAddConfirm.Appearance.Options.UseBackColor = true;
            this.btnAddConfirm.Appearance.Options.UseFont = true;
            this.btnAddConfirm.Location = new System.Drawing.Point(79, 570);
            this.btnAddConfirm.Name = "btnAddConfirm";
            this.btnAddConfirm.Size = new System.Drawing.Size(123, 42);
            this.btnAddConfirm.TabIndex = 5;
            this.btnAddConfirm.Text = "修改";
            this.btnAddConfirm.Click += new System.EventHandler(this.btnAddConfirm_Click);
            // 
            // tbConfirmPasswd
            // 
            this.tbConfirmPasswd.Location = new System.Drawing.Point(210, 254);
            this.tbConfirmPasswd.Name = "tbConfirmPasswd";
            this.tbConfirmPasswd.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.tbConfirmPasswd.Properties.Appearance.Font = new System.Drawing.Font("小米兰亭", 10F);
            this.tbConfirmPasswd.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.tbConfirmPasswd.Properties.Appearance.Options.UseBackColor = true;
            this.tbConfirmPasswd.Properties.Appearance.Options.UseFont = true;
            this.tbConfirmPasswd.Properties.Appearance.Options.UseForeColor = true;
            this.tbConfirmPasswd.Properties.PasswordChar = '*';
            this.tbConfirmPasswd.Size = new System.Drawing.Size(219, 26);
            this.tbConfirmPasswd.TabIndex = 3;
            this.tbConfirmPasswd.EditValueChanged += new System.EventHandler(this.tbConfirmPasswd_EditValueChanged);
            // 
            // tbUserName
            // 
            this.tbUserName.Enabled = false;
            this.tbUserName.Location = new System.Drawing.Point(210, 143);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.tbUserName.Properties.Appearance.Font = new System.Drawing.Font("小米兰亭", 10F);
            this.tbUserName.Properties.Appearance.Options.UseBackColor = true;
            this.tbUserName.Properties.Appearance.Options.UseFont = true;
            this.tbUserName.Size = new System.Drawing.Size(219, 26);
            this.tbUserName.TabIndex = 1;
            // 
            // tbpasswd
            // 
            this.tbpasswd.EditValue = "使用原密码";
            this.tbpasswd.Location = new System.Drawing.Point(210, 199);
            this.tbpasswd.Name = "tbpasswd";
            this.tbpasswd.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.tbpasswd.Properties.Appearance.Font = new System.Drawing.Font("小米兰亭", 10F);
            this.tbpasswd.Properties.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.tbpasswd.Properties.Appearance.Options.UseBackColor = true;
            this.tbpasswd.Properties.Appearance.Options.UseFont = true;
            this.tbpasswd.Properties.Appearance.Options.UseForeColor = true;
            this.tbpasswd.Size = new System.Drawing.Size(219, 26);
            this.tbpasswd.TabIndex = 2;
            this.tbpasswd.EditValueChanged += new System.EventHandler(this.tbpasswd_EditValueChanged);
            this.tbpasswd.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbpasswd_MouseClick);
            // 
            // tbUserDescribe
            // 
            this.tbUserDescribe.EditValue = "";
            this.tbUserDescribe.Location = new System.Drawing.Point(156, 387);
            this.tbUserDescribe.Name = "tbUserDescribe";
            this.tbUserDescribe.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.tbUserDescribe.Properties.Appearance.Font = new System.Drawing.Font("小米兰亭", 10F);
            this.tbUserDescribe.Properties.Appearance.Options.UseBackColor = true;
            this.tbUserDescribe.Properties.Appearance.Options.UseFont = true;
            this.tbUserDescribe.Size = new System.Drawing.Size(273, 148);
            this.tbUserDescribe.TabIndex = 4;
            // 
            // cus_Modify
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ChildControls.Add(this.directXFormContainerControl1);
            this.ClientSize = new System.Drawing.Size(504, 650);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IconOptions.Image = global::EasyBuy.Properties.Resources.icon;
            this.Name = "cus_Modify";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "管理员用户添加";
            this.directXFormContainerControl1.ResumeLayout(false);
            this.directXFormContainerControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbConfirmPasswd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbUserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbpasswd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbUserDescribe.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.DirectXFormContainerControl directXFormContainerControl1;
        private DevExpress.XtraEditors.SimpleButton btnAddConfirm;
        private DevExpress.XtraEditors.TextEdit tbUserName;
        private DevExpress.XtraEditors.TextEdit tbpasswd;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.MemoEdit tbUserDescribe;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit tbConfirmPasswd;
        private DevExpress.XtraEditors.LabelControl txtTitle;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton Exit;
        private DevExpress.XtraEditors.LabelControl txtPasswdError;
    }
}