namespace common
{
    partial class UserInfoFrm
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.linkLabelShowHelper = new System.Windows.Forms.LinkLabel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnHide = new System.Windows.Forms.Button();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblIsvip = new System.Windows.Forms.LinkLabel();
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblusername = new System.Windows.Forms.Label();
            this.webBrowserUserInfo = new System.Windows.Forms.WebBrowser();
            this.lblCreateDate = new System.Windows.Forms.Label();
            this.lblDeadline = new System.Windows.Forms.Label();
            this.lblSendTotal = new System.Windows.Forms.Label();
            this.lblSendNum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // linkLabelShowHelper
            // 
            this.linkLabelShowHelper.AutoSize = true;
            this.linkLabelShowHelper.Location = new System.Drawing.Point(166, 444);
            this.linkLabelShowHelper.Name = "linkLabelShowHelper";
            this.linkLabelShowHelper.Size = new System.Drawing.Size(53, 12);
            this.linkLabelShowHelper.TabIndex = 37;
            this.linkLabelShowHelper.TabStop = true;
            this.linkLabelShowHelper.Text = "查看帮助";
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Location = new System.Drawing.Point(55, 96);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 36;
            this.btnExit.Text = "退出程序";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefresh.Location = new System.Drawing.Point(55, 67);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 35;
            this.btnRefresh.Text = "刷新信息";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnHide
            // 
            this.btnHide.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHide.Location = new System.Drawing.Point(55, 38);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(75, 23);
            this.btnHide.TabIndex = 34;
            this.btnHide.Text = "隐藏信息";
            this.btnHide.UseVisualStyleBackColor = true;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Location = new System.Drawing.Point(104, 384);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(11, 12);
            this.lblScore.TabIndex = 33;
            this.lblScore.Text = "0";
            // 
            // lblIsvip
            // 
            this.lblIsvip.AutoSize = true;
            this.lblIsvip.BackColor = System.Drawing.Color.Transparent;
            this.lblIsvip.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblIsvip.LinkColor = System.Drawing.Color.Gray;
            this.lblIsvip.Location = new System.Drawing.Point(104, 235);
            this.lblIsvip.Name = "lblIsvip";
            this.lblIsvip.Size = new System.Drawing.Size(57, 12);
            this.lblIsvip.TabIndex = 32;
            this.lblIsvip.TabStop = true;
            this.lblIsvip.Text = "大众用户";
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.BackColor = System.Drawing.Color.Transparent;
            this.lblLevel.Location = new System.Drawing.Point(104, 205);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(11, 12);
            this.lblLevel.TabIndex = 31;
            this.lblLevel.Text = "0";
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.BackColor = System.Drawing.Color.Transparent;
            this.lblusername.Location = new System.Drawing.Point(104, 174);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(41, 12);
            this.lblusername.TabIndex = 30;
            this.lblusername.Text = "MyName";
            // 
            // webBrowserUserInfo
            // 
            this.webBrowserUserInfo.IsWebBrowserContextMenuEnabled = false;
            this.webBrowserUserInfo.Location = new System.Drawing.Point(245, 11);
            this.webBrowserUserInfo.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserUserInfo.Name = "webBrowserUserInfo";
            this.webBrowserUserInfo.ScrollBarsEnabled = false;
            this.webBrowserUserInfo.Size = new System.Drawing.Size(606, 464);
            this.webBrowserUserInfo.TabIndex = 29;
            this.webBrowserUserInfo.Url = new System.Uri("http://ema.qianlongsoft.com/core/users.html", System.UriKind.Absolute);
            this.webBrowserUserInfo.WebBrowserShortcutsEnabled = false;
            // 
            // lblCreateDate
            // 
            this.lblCreateDate.AutoSize = true;
            this.lblCreateDate.BackColor = System.Drawing.Color.Transparent;
            this.lblCreateDate.Location = new System.Drawing.Point(104, 264);
            this.lblCreateDate.Name = "lblCreateDate";
            this.lblCreateDate.Size = new System.Drawing.Size(65, 12);
            this.lblCreateDate.TabIndex = 38;
            this.lblCreateDate.Text = "CreateDate";
            // 
            // lblDeadline
            // 
            this.lblDeadline.AutoSize = true;
            this.lblDeadline.BackColor = System.Drawing.Color.Transparent;
            this.lblDeadline.Location = new System.Drawing.Point(104, 296);
            this.lblDeadline.Name = "lblDeadline";
            this.lblDeadline.Size = new System.Drawing.Size(53, 12);
            this.lblDeadline.TabIndex = 39;
            this.lblDeadline.Text = "Deadline";
            // 
            // lblSendTotal
            // 
            this.lblSendTotal.AutoSize = true;
            this.lblSendTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblSendTotal.Location = new System.Drawing.Point(106, 355);
            this.lblSendTotal.Name = "lblSendTotal";
            this.lblSendTotal.Size = new System.Drawing.Size(59, 12);
            this.lblSendTotal.TabIndex = 40;
            this.lblSendTotal.Text = "SendTotal";
            // 
            // lblSendNum
            // 
            this.lblSendNum.AutoSize = true;
            this.lblSendNum.BackColor = System.Drawing.Color.Transparent;
            this.lblSendNum.Location = new System.Drawing.Point(104, 324);
            this.lblSendNum.Name = "lblSendNum";
            this.lblSendNum.Size = new System.Drawing.Size(47, 12);
            this.lblSendNum.TabIndex = 41;
            this.lblSendNum.Text = "SendNum";
            // 
            // UserInfoFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::common.Properties.Resources.userInfoBg;
            this.Controls.Add(this.lblSendNum);
            this.Controls.Add(this.lblSendTotal);
            this.Controls.Add(this.lblDeadline);
            this.Controls.Add(this.lblCreateDate);
            this.Controls.Add(this.linkLabelShowHelper);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnHide);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblIsvip);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.lblusername);
            this.Controls.Add(this.webBrowserUserInfo);
            this.Name = "UserInfoFrm";
            this.Size = new System.Drawing.Size(861, 484);
            this.Load += new System.EventHandler(this.UserInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabelShowHelper;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.LinkLabel lblIsvip;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.WebBrowser webBrowserUserInfo;
        private System.Windows.Forms.Label lblCreateDate;
        private System.Windows.Forms.Label lblDeadline;
        private System.Windows.Forms.Label lblSendTotal;
        private System.Windows.Forms.Label lblSendNum;

    }
}
