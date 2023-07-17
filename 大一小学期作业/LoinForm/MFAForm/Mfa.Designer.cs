namespace EasyBuy
{
    partial class Mfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mfa));
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.Exit = new DevExpress.XtraEditors.SimpleButton();
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barManager2 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl3 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
            this.barManager3 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControl5 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl6 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl7 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl8 = new DevExpress.XtraBars.BarDockControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.tbKey = new DevExpress.XtraEditors.TextEdit();
            this.Conofirm = new DevExpress.XtraEditors.SimpleButton();
            this.label = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.sidePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbKey.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Exit.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.BottomCenter;
            this.Exit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Exit.ImageOptions.SvgImage")));
            this.Exit.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.Exit.Location = new System.Drawing.Point(774, 6);
            this.Exit.Margin = new System.Windows.Forms.Padding(5);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(37, 38);
            this.Exit.TabIndex = 3;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // sidePanel1
            // 
            this.sidePanel1.AllowResize = false;
            this.sidePanel1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.sidePanel1.Appearance.BorderColor = System.Drawing.Color.Tomato;
            this.sidePanel1.Appearance.ForeColor = System.Drawing.Color.White;
            this.sidePanel1.Appearance.Options.UseBackColor = true;
            this.sidePanel1.Appearance.Options.UseBorderColor = true;
            this.sidePanel1.Appearance.Options.UseForeColor = true;
            this.sidePanel1.Controls.Add(this.labelControl3);
            this.sidePanel1.Controls.Add(this.Exit);
            this.sidePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.sidePanel1.Location = new System.Drawing.Point(0, 0);
            this.sidePanel1.Margin = new System.Windows.Forms.Padding(5);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(816, 50);
            this.sidePanel1.TabIndex = 4;
            this.sidePanel1.Text = "sidePanel1";
            this.sidePanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.sidePanel1_MouseDown);
            this.sidePanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.sidePanel1_MouseMove);
            this.sidePanel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.sidePanel1_MouseUp);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(15, 16);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(5);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(157, 20);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "东油易购统系统MFA认证";
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(5);
            this.barDockControlTop.Size = new System.Drawing.Size(816, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 523);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(5);
            this.barDockControlBottom.Size = new System.Drawing.Size(816, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(5);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 523);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(816, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(5);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 523);
            // 
            // barManager2
            // 
            this.barManager2.DockControls.Add(this.barDockControl1);
            this.barManager2.DockControls.Add(this.barDockControl2);
            this.barManager2.DockControls.Add(this.barDockControl3);
            this.barManager2.DockControls.Add(this.barDockControl4);
            this.barManager2.Form = this;
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl1.Location = new System.Drawing.Point(0, 0);
            this.barDockControl1.Manager = this.barManager2;
            this.barDockControl1.Margin = new System.Windows.Forms.Padding(5);
            this.barDockControl1.Size = new System.Drawing.Size(816, 0);
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl2.Location = new System.Drawing.Point(0, 523);
            this.barDockControl2.Manager = this.barManager2;
            this.barDockControl2.Margin = new System.Windows.Forms.Padding(5);
            this.barDockControl2.Size = new System.Drawing.Size(816, 0);
            // 
            // barDockControl3
            // 
            this.barDockControl3.CausesValidation = false;
            this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl3.Location = new System.Drawing.Point(0, 0);
            this.barDockControl3.Manager = this.barManager2;
            this.barDockControl3.Margin = new System.Windows.Forms.Padding(5);
            this.barDockControl3.Size = new System.Drawing.Size(0, 523);
            // 
            // barDockControl4
            // 
            this.barDockControl4.CausesValidation = false;
            this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl4.Location = new System.Drawing.Point(816, 0);
            this.barDockControl4.Manager = this.barManager2;
            this.barDockControl4.Margin = new System.Windows.Forms.Padding(5);
            this.barDockControl4.Size = new System.Drawing.Size(0, 523);
            // 
            // barManager3
            // 
            this.barManager3.DockControls.Add(this.barDockControl5);
            this.barManager3.DockControls.Add(this.barDockControl6);
            this.barManager3.DockControls.Add(this.barDockControl7);
            this.barManager3.DockControls.Add(this.barDockControl8);
            this.barManager3.Form = this;
            // 
            // barDockControl5
            // 
            this.barDockControl5.CausesValidation = false;
            this.barDockControl5.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl5.Location = new System.Drawing.Point(0, 0);
            this.barDockControl5.Manager = this.barManager3;
            this.barDockControl5.Margin = new System.Windows.Forms.Padding(5);
            this.barDockControl5.Size = new System.Drawing.Size(816, 0);
            // 
            // barDockControl6
            // 
            this.barDockControl6.CausesValidation = false;
            this.barDockControl6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl6.Location = new System.Drawing.Point(0, 523);
            this.barDockControl6.Manager = this.barManager3;
            this.barDockControl6.Margin = new System.Windows.Forms.Padding(5);
            this.barDockControl6.Size = new System.Drawing.Size(816, 0);
            // 
            // barDockControl7
            // 
            this.barDockControl7.CausesValidation = false;
            this.barDockControl7.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl7.Location = new System.Drawing.Point(0, 0);
            this.barDockControl7.Manager = this.barManager3;
            this.barDockControl7.Margin = new System.Windows.Forms.Padding(5);
            this.barDockControl7.Size = new System.Drawing.Size(0, 523);
            // 
            // barDockControl8
            // 
            this.barDockControl8.CausesValidation = false;
            this.barDockControl8.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl8.Location = new System.Drawing.Point(816, 0);
            this.barDockControl8.Manager = this.barManager3;
            this.barDockControl8.Margin = new System.Windows.Forms.Padding(5);
            this.barDockControl8.Size = new System.Drawing.Size(0, 523);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("小米兰亭", 13F);
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Location = new System.Drawing.Point(584, 402);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(125, 50);
            this.simpleButton1.TabIndex = 17;
            this.simpleButton1.Text = "退出";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // tbKey
            // 
            this.tbKey.Location = new System.Drawing.Point(446, 286);
            this.tbKey.MenuManager = this.barManager1;
            this.tbKey.Name = "tbKey";
            this.tbKey.Size = new System.Drawing.Size(204, 28);
            this.tbKey.TabIndex = 18;
            // 
            // Conofirm
            // 
            this.Conofirm.Appearance.Font = new System.Drawing.Font("小米兰亭", 13F);
            this.Conofirm.Appearance.Options.UseFont = true;
            this.Conofirm.Location = new System.Drawing.Point(386, 402);
            this.Conofirm.Name = "Conofirm";
            this.Conofirm.Size = new System.Drawing.Size(130, 50);
            this.Conofirm.TabIndex = 17;
            this.Conofirm.Text = "验证";
            this.Conofirm.Click += new System.EventHandler(this.Conofirm_Click);
            // 
            // label
            // 
            this.label.Appearance.Font = new System.Drawing.Font("小米兰亭", 14F);
            this.label.Appearance.Options.UseFont = true;
            this.label.Location = new System.Drawing.Point(470, 320);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(152, 25);
            this.label.TabIndex = 44;
            this.label.Text = "请输入动态验证码";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = global::EasyBuy.Properties.Resources.MFA验证1;
            this.pictureEdit1.Location = new System.Drawing.Point(477, 86);
            this.pictureEdit1.MenuManager = this.barManager1;
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Size = new System.Drawing.Size(155, 156);
            this.pictureEdit1.TabIndex = 70;
            // 
            // Mfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundImageStore = global::EasyBuy.Properties.Resources.LoinImg;
            this.ClientSize = new System.Drawing.Size(816, 523);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.label);
            this.Controls.Add(this.tbKey);
            this.Controls.Add(this.Conofirm);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.sidePanel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Controls.Add(this.barDockControl3);
            this.Controls.Add(this.barDockControl4);
            this.Controls.Add(this.barDockControl2);
            this.Controls.Add(this.barDockControl1);
            this.Controls.Add(this.barDockControl7);
            this.Controls.Add(this.barDockControl8);
            this.Controls.Add(this.barDockControl6);
            this.Controls.Add(this.barDockControl5);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IconOptions.Image = global::EasyBuy.Properties.Resources.icon;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Mfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "用户密码";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.sidePanel1.ResumeLayout(false);
            this.sidePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbKey.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraEditors.SimpleButton Exit;
        private DevExpress.XtraEditors.SidePanel sidePanel1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarDockControl barDockControl3;
        private DevExpress.XtraBars.BarManager barManager2;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarDockControl barDockControl2;
        private DevExpress.XtraBars.BarDockControl barDockControl4;
        private DevExpress.XtraBars.BarDockControl barDockControl7;
        private DevExpress.XtraBars.BarManager barManager3;
        private DevExpress.XtraBars.BarDockControl barDockControl5;
        private DevExpress.XtraBars.BarDockControl barDockControl6;
        private DevExpress.XtraBars.BarDockControl barDockControl8;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.TextEdit tbKey;
        private DevExpress.XtraEditors.SimpleButton Conofirm;
        private DevExpress.XtraEditors.LabelControl label;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
    }
}

