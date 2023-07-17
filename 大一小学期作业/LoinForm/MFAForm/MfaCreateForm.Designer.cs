namespace EasyBuy.SecondPage.S_GoodsInfom
{
    partial class MfaCreateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MfaCreateForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.Exit = new DevExpress.XtraEditors.SimpleButton();
            this.txtTetle = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddConfirm = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(98, 122);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(230, 207);
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
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
            this.panelControl1.Location = new System.Drawing.Point(7, 5);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(427, 58);
            this.panelControl1.TabIndex = 36;
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
            this.Exit.Location = new System.Drawing.Point(383, 14);
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
            this.txtTetle.Size = new System.Drawing.Size(247, 29);
            this.txtTetle.TabIndex = 14;
            this.txtTetle.Text = "生成二次验证MFA二维码";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("小米兰亭", 12F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(109, 401);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(208, 22);
            this.labelControl1.TabIndex = 35;
            this.labelControl1.Text = "请用Mfa 管理工具扫描二维码";
            // 
            // btnCancel
            // 
            this.btnCancel.Appearance.Font = new System.Drawing.Font("小米兰亭", 10F);
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.Location = new System.Drawing.Point(235, 517);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(131, 42);
            this.btnCancel.TabIndex = 34;
            this.btnCancel.Text = "取消";
            this.btnCancel.Click += new System.EventHandler(this.Exit_Click);
            // 
            // btnAddConfirm
            // 
            this.btnAddConfirm.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(178)))), ((int)(((byte)(201)))));
            this.btnAddConfirm.Appearance.Font = new System.Drawing.Font("小米兰亭", 10F);
            this.btnAddConfirm.Appearance.Options.UseBackColor = true;
            this.btnAddConfirm.Appearance.Options.UseFont = true;
            this.btnAddConfirm.Location = new System.Drawing.Point(41, 517);
            this.btnAddConfirm.Name = "btnAddConfirm";
            this.btnAddConfirm.Size = new System.Drawing.Size(123, 42);
            this.btnAddConfirm.TabIndex = 33;
            this.btnAddConfirm.Text = "生成MFA二维码";
            this.btnAddConfirm.Click += new System.EventHandler(this.btnAddConfirm_Click);
            // 
            // MfaCreateForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 583);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddConfirm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MfaCreateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XtraForm1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton Exit;
        private DevExpress.XtraEditors.LabelControl txtTetle;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnAddConfirm;
    }
}