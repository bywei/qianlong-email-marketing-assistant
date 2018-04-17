namespace common.emailConfig
{
    partial class AddConfigFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddConfigFrm));
            this.textBoxDomain = new System.Windows.Forms.TextBox();
            this.groupBoxDomain = new System.Windows.Forms.GroupBox();
            this.linkDomain = new System.Windows.Forms.LinkLabel();
            this.comboBoxDomain = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonOnline = new System.Windows.Forms.RadioButton();
            this.radioButtonLocal = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.textBoxPwd = new System.Windows.Forms.TextBox();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBoxSmtpPort = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkBoxSSL = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxSmtp = new System.Windows.Forms.TextBox();
            this.groupBoxDomain.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxDomain
            // 
            this.textBoxDomain.Location = new System.Drawing.Point(39, 20);
            this.textBoxDomain.Name = "textBoxDomain";
            this.textBoxDomain.Size = new System.Drawing.Size(174, 21);
            this.textBoxDomain.TabIndex = 3;
            this.textBoxDomain.Visible = false;
            // 
            // groupBoxDomain
            // 
            this.groupBoxDomain.Controls.Add(this.linkDomain);
            this.groupBoxDomain.Controls.Add(this.comboBoxDomain);
            this.groupBoxDomain.Controls.Add(this.textBoxDomain);
            this.groupBoxDomain.Location = new System.Drawing.Point(3, 69);
            this.groupBoxDomain.Name = "groupBoxDomain";
            this.groupBoxDomain.Size = new System.Drawing.Size(389, 53);
            this.groupBoxDomain.TabIndex = 2;
            this.groupBoxDomain.TabStop = false;
            this.groupBoxDomain.Text = "邮箱域名后缀";
            // 
            // linkDomain
            // 
            this.linkDomain.AutoSize = true;
            this.linkDomain.Location = new System.Drawing.Point(248, 25);
            this.linkDomain.Name = "linkDomain";
            this.linkDomain.Size = new System.Drawing.Size(113, 12);
            this.linkDomain.TabIndex = 3;
            this.linkDomain.TabStop = true;
            this.linkDomain.Text = "购买企业版发件邮箱";
            this.linkDomain.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkDomain_LinkClicked);
            // 
            // comboBoxDomain
            // 
            this.comboBoxDomain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDomain.FormattingEnabled = true;
            this.comboBoxDomain.Location = new System.Drawing.Point(40, 21);
            this.comboBoxDomain.Name = "comboBoxDomain";
            this.comboBoxDomain.Size = new System.Drawing.Size(174, 20);
            this.comboBoxDomain.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonOnline);
            this.groupBox2.Controls.Add(this.radioButtonLocal);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(400, 58);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "选择邮箱类型";
            // 
            // radioButtonOnline
            // 
            this.radioButtonOnline.AutoSize = true;
            this.radioButtonOnline.Location = new System.Drawing.Point(222, 20);
            this.radioButtonOnline.Name = "radioButtonOnline";
            this.radioButtonOnline.Size = new System.Drawing.Size(107, 16);
            this.radioButtonOnline.TabIndex = 1;
            this.radioButtonOnline.TabStop = true;
            this.radioButtonOnline.Text = "外网邮箱服务器";
            this.radioButtonOnline.UseVisualStyleBackColor = true;
            this.radioButtonOnline.Click += new System.EventHandler(this.radioButtonOnline_Click);
            // 
            // radioButtonLocal
            // 
            this.radioButtonLocal.AutoSize = true;
            this.radioButtonLocal.Checked = true;
            this.radioButtonLocal.Location = new System.Drawing.Point(42, 20);
            this.radioButtonLocal.Name = "radioButtonLocal";
            this.radioButtonLocal.Size = new System.Drawing.Size(107, 16);
            this.radioButtonLocal.TabIndex = 0;
            this.radioButtonLocal.TabStop = true;
            this.radioButtonLocal.Text = "默认邮箱服务器";
            this.radioButtonLocal.UseVisualStyleBackColor = true;
            this.radioButtonLocal.Click += new System.EventHandler(this.radioButtonOnline_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonClose);
            this.panel1.Controls.Add(this.buttonSave);
            this.panel1.Controls.Add(this.groupBox6);
            this.panel1.Controls.Add(this.groupBox5);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBoxDomain);
            this.panel1.Location = new System.Drawing.Point(11, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(401, 337);
            this.panel1.TabIndex = 4;
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(189, 296);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 7;
            this.buttonClose.Text = "关闭";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(108, 296);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "保存";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.textBoxPwd);
            this.groupBox6.Controls.Add(this.textBoxUser);
            this.groupBox6.Location = new System.Drawing.Point(3, 10);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(389, 53);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "用户名:密码";
            // 
            // textBoxPwd
            // 
            this.textBoxPwd.Location = new System.Drawing.Point(186, 20);
            this.textBoxPwd.Name = "textBoxPwd";
            this.textBoxPwd.Size = new System.Drawing.Size(140, 21);
            this.textBoxPwd.TabIndex = 2;
            // 
            // textBoxUser
            // 
            this.textBoxUser.Location = new System.Drawing.Point(39, 20);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(141, 21);
            this.textBoxUser.TabIndex = 1;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBoxSmtpPort);
            this.groupBox5.Location = new System.Drawing.Point(3, 236);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(389, 52);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "SMTP服务器端口";
            // 
            // textBoxSmtpPort
            // 
            this.textBoxSmtpPort.Location = new System.Drawing.Point(39, 20);
            this.textBoxSmtpPort.Name = "textBoxSmtpPort";
            this.textBoxSmtpPort.Size = new System.Drawing.Size(287, 21);
            this.textBoxSmtpPort.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.checkBoxSSL);
            this.groupBox4.Location = new System.Drawing.Point(3, 184);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(389, 46);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "SSL";
            // 
            // checkBoxSSL
            // 
            this.checkBoxSSL.AutoSize = true;
            this.checkBoxSSL.Location = new System.Drawing.Point(39, 20);
            this.checkBoxSSL.Name = "checkBoxSSL";
            this.checkBoxSSL.Size = new System.Drawing.Size(42, 16);
            this.checkBoxSSL.TabIndex = 0;
            this.checkBoxSSL.Text = "SSL";
            this.checkBoxSSL.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxSmtp);
            this.groupBox3.Location = new System.Drawing.Point(3, 128);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(389, 50);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "SMTP服务器地址";
            // 
            // textBoxSmtp
            // 
            this.textBoxSmtp.Location = new System.Drawing.Point(39, 19);
            this.textBoxSmtp.Name = "textBoxSmtp";
            this.textBoxSmtp.Size = new System.Drawing.Size(287, 21);
            this.textBoxSmtp.TabIndex = 4;
            // 
            // AddConfigFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 425);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(432, 462);
            this.MinimizeBox = false;
            this.Name = "AddConfigFrm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "发件配置";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.AddConfigFrm_Load);
            this.groupBoxDomain.ResumeLayout(false);
            this.groupBoxDomain.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDomain;
        private System.Windows.Forms.GroupBox groupBoxDomain;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButtonOnline;
        private System.Windows.Forms.RadioButton radioButtonLocal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox textBoxSmtpPort;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxSmtp;
        private System.Windows.Forms.CheckBox checkBoxSSL;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox textBoxPwd;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.ComboBox comboBoxDomain;
        private System.Windows.Forms.LinkLabel linkDomain;
    }
}