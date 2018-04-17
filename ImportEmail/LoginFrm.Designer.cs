namespace common
{
    partial class LoginFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginFrm));
            this.panelLogin = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnLOgin = new System.Windows.Forms.Button();
            this.txtLoginPwd = new System.Windows.Forms.TextBox();
            this.txtLoginUserName = new System.Windows.Forms.TextBox();
            this.panelReg = new System.Windows.Forms.Panel();
            this.txtRegEmail = new System.Windows.Forms.TextBox();
            this.btnRegExit = new System.Windows.Forms.Button();
            this.txtRegPwd = new System.Windows.Forms.TextBox();
            this.txtRegName = new System.Windows.Forms.TextBox();
            this.btnRegOk = new System.Windows.Forms.Button();
            this.skinEngine = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.timerStyle = new System.Windows.Forms.Timer(this.components);
            this.picClose = new System.Windows.Forms.PictureBox();
            this.picLoading = new System.Windows.Forms.PictureBox();
            this.panelLogin.SuspendLayout();
            this.panelReg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLoading)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLogin
            // 
            this.panelLogin.BackColor = System.Drawing.Color.Transparent;
            this.panelLogin.BackgroundImage = global::common.Properties.Resources.login;
            this.panelLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelLogin.Controls.Add(this.linkLabel1);
            this.panelLogin.Controls.Add(this.btnLOgin);
            this.panelLogin.Controls.Add(this.txtLoginPwd);
            this.panelLogin.Controls.Add(this.txtLoginUserName);
            this.panelLogin.Location = new System.Drawing.Point(69, 115);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(254, 104);
            this.panelLogin.TabIndex = 0;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(127, 81);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(89, 12);
            this.linkLabel1.TabIndex = 10;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "注册群发账号？";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btnLOgin
            // 
            this.btnLOgin.BackgroundImage = global::common.Properties.Resources.loginBtn;
            this.btnLOgin.Location = new System.Drawing.Point(34, 76);
            this.btnLOgin.Name = "btnLOgin";
            this.btnLOgin.Size = new System.Drawing.Size(75, 23);
            this.btnLOgin.TabIndex = 0;
            this.btnLOgin.UseVisualStyleBackColor = true;
            this.btnLOgin.Click += new System.EventHandler(this.btnLOgin_Click);
            // 
            // txtLoginPwd
            // 
            this.txtLoginPwd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLoginPwd.Location = new System.Drawing.Point(68, 39);
            this.txtLoginPwd.Name = "txtLoginPwd";
            this.txtLoginPwd.PasswordChar = '*';
            this.txtLoginPwd.Size = new System.Drawing.Size(172, 14);
            this.txtLoginPwd.TabIndex = 2;
            // 
            // txtLoginUserName
            // 
            this.txtLoginUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLoginUserName.Location = new System.Drawing.Point(67, 9);
            this.txtLoginUserName.Name = "txtLoginUserName";
            this.txtLoginUserName.Size = new System.Drawing.Size(173, 14);
            this.txtLoginUserName.TabIndex = 1;
            // 
            // panelReg
            // 
            this.panelReg.BackColor = System.Drawing.Color.Transparent;
            this.panelReg.BackgroundImage = global::common.Properties.Resources.reg;
            this.panelReg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelReg.Controls.Add(this.txtRegEmail);
            this.panelReg.Controls.Add(this.btnRegExit);
            this.panelReg.Controls.Add(this.txtRegPwd);
            this.panelReg.Controls.Add(this.txtRegName);
            this.panelReg.Controls.Add(this.btnRegOk);
            this.panelReg.Location = new System.Drawing.Point(390, 12);
            this.panelReg.Name = "panelReg";
            this.panelReg.Size = new System.Drawing.Size(252, 123);
            this.panelReg.TabIndex = 6;
            this.panelReg.Visible = false;
            // 
            // txtRegEmail
            // 
            this.txtRegEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRegEmail.Location = new System.Drawing.Point(67, 68);
            this.txtRegEmail.Name = "txtRegEmail";
            this.txtRegEmail.Size = new System.Drawing.Size(173, 14);
            this.txtRegEmail.TabIndex = 3;
            // 
            // btnRegExit
            // 
            this.btnRegExit.BackgroundImage = global::common.Properties.Resources.regCancleBtn;
            this.btnRegExit.Location = new System.Drawing.Point(120, 94);
            this.btnRegExit.Name = "btnRegExit";
            this.btnRegExit.Size = new System.Drawing.Size(75, 23);
            this.btnRegExit.TabIndex = 5;
            this.btnRegExit.UseVisualStyleBackColor = true;
            this.btnRegExit.Click += new System.EventHandler(this.btnRegExit_Click);
            // 
            // txtRegPwd
            // 
            this.txtRegPwd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRegPwd.Location = new System.Drawing.Point(66, 38);
            this.txtRegPwd.Name = "txtRegPwd";
            this.txtRegPwd.PasswordChar = '*';
            this.txtRegPwd.Size = new System.Drawing.Size(174, 14);
            this.txtRegPwd.TabIndex = 2;
            // 
            // txtRegName
            // 
            this.txtRegName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRegName.Location = new System.Drawing.Point(67, 8);
            this.txtRegName.Name = "txtRegName";
            this.txtRegName.Size = new System.Drawing.Size(174, 14);
            this.txtRegName.TabIndex = 1;
            // 
            // btnRegOk
            // 
            this.btnRegOk.BackgroundImage = global::common.Properties.Resources.regBtn;
            this.btnRegOk.Location = new System.Drawing.Point(39, 94);
            this.btnRegOk.Name = "btnRegOk";
            this.btnRegOk.Size = new System.Drawing.Size(75, 23);
            this.btnRegOk.TabIndex = 4;
            this.btnRegOk.UseVisualStyleBackColor = true;
            this.btnRegOk.Click += new System.EventHandler(this.btnRegOk_Click);
            // 
            // skinEngine
            // 
            this.skinEngine.SerialNumber = "";
            this.skinEngine.SkinFile = null;
            // 
            // timerStyle
            // 
            this.timerStyle.Tick += new System.EventHandler(this.timerStyle_Tick);
            // 
            // picClose
            // 
            this.picClose.BackColor = System.Drawing.Color.Transparent;
            this.picClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picClose.Image = global::common.Properties.Resources.closeForm;
            this.picClose.Location = new System.Drawing.Point(339, 3);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(24, 20);
            this.picClose.TabIndex = 13;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            this.picClose.MouseLeave += new System.EventHandler(this.picClose_MouseLeave);
            this.picClose.MouseHover += new System.EventHandler(this.picClose_MouseHover);
            // 
            // picLoading
            // 
            this.picLoading.BackColor = System.Drawing.Color.Transparent;
            this.picLoading.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picLoading.Image = global::common.Properties.Resources.loader;
            this.picLoading.Location = new System.Drawing.Point(390, 154);
            this.picLoading.Name = "picLoading";
            this.picLoading.Size = new System.Drawing.Size(150, 31);
            this.picLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picLoading.TabIndex = 14;
            this.picLoading.TabStop = false;
            // 
            // LoginFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::common.Properties.Resources.loginBg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(774, 467);
            this.Controls.Add(this.picLoading);
            this.Controls.Add(this.panelLogin);
            this.Controls.Add(this.picClose);
            this.Controls.Add(this.panelReg);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LoginFrm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "钱龙邮件群发系统";
            this.Load += new System.EventHandler(this.LoginFrm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LoginFrm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LoginFrm_MouseMove);
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.panelReg.ResumeLayout(false);
            this.panelReg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLoading)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btnLOgin;
        private System.Windows.Forms.TextBox txtLoginPwd;
        private System.Windows.Forms.TextBox txtLoginUserName;
        private System.Windows.Forms.Panel panelReg;
        private System.Windows.Forms.Button btnRegExit;
        private System.Windows.Forms.TextBox txtRegEmail;
        private System.Windows.Forms.Button btnRegOk;
        private System.Windows.Forms.TextBox txtRegPwd;
        private System.Windows.Forms.TextBox txtRegName;
        private Sunisoft.IrisSkin.SkinEngine skinEngine;
        private System.Windows.Forms.Timer timerStyle;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.PictureBox picLoading;
    }
}