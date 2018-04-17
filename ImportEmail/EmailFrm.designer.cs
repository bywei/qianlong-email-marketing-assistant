namespace common
{
    partial class EmailFrm
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmailFrm));
            this.btnImport = new System.Windows.Forms.Button();
            this.txtEmailPath = new System.Windows.Forms.TextBox();
            this.listBoxEmail = new System.Windows.Forms.ListBox();
            this.ofdEmail = new System.Windows.Forms.OpenFileDialog();
            this.chkTxt = new System.Windows.Forms.CheckBox();
            this.chkMdb = new System.Windows.Forms.CheckBox();
            this.chkExcel = new System.Windows.Forms.CheckBox();
            this.txtSendContent = new System.Windows.Forms.RichTextBox();
            this.txtSendEmail = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtSendName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSendTitle = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnFj = new System.Windows.Forms.Button();
            this.txtFj = new System.Windows.Forms.TextBox();
            this.btnConfig = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listBoxAccess = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.linkLabelHelper = new System.Windows.Forms.LinkLabel();
            this.linkScore = new System.Windows.Forms.LinkLabel();
            this.chkMackMoney = new System.Windows.Forms.CheckBox();
            this.groupBoxAdd = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSaveEmail = new System.Windows.Forms.Button();
            this.txtAddPassward = new System.Windows.Forms.TextBox();
            this.txtAddEmail = new System.Windows.Forms.TextBox();
            this.dgvEmailConfig = new System.Windows.Forms.DataGridView();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Passward = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conMenuSAdd = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsDel = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.sfdTxt = new System.Windows.Forms.SaveFileDialog();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnDataBase = new System.Windows.Forms.Button();
            this.notifyIconEmail = new System.Windows.Forms.NotifyIcon(this.components);
            this.toolTipInfo = new System.Windows.Forms.ToolTip(this.components);
            this.timerSend = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBoxAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmailConfig)).BeginInit();
            this.conMenuSAdd.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(136, 14);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(75, 23);
            this.btnImport.TabIndex = 1;
            this.btnImport.Text = "导入...";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // txtEmailPath
            // 
            this.txtEmailPath.Location = new System.Drawing.Point(22, 18);
            this.txtEmailPath.Name = "txtEmailPath";
            this.txtEmailPath.Size = new System.Drawing.Size(120, 21);
            this.txtEmailPath.TabIndex = 2;
            // 
            // listBoxEmail
            // 
            this.listBoxEmail.FormattingEnabled = true;
            this.listBoxEmail.ItemHeight = 12;
            this.listBoxEmail.Location = new System.Drawing.Point(12, 124);
            this.listBoxEmail.Name = "listBoxEmail";
            this.listBoxEmail.Size = new System.Drawing.Size(211, 352);
            this.listBoxEmail.TabIndex = 3;
            this.toolTipInfo.SetToolTip(this.listBoxEmail, "导入的邮件列表");
            // 
            // chkTxt
            // 
            this.chkTxt.AutoSize = true;
            this.chkTxt.Location = new System.Drawing.Point(22, 46);
            this.chkTxt.Name = "chkTxt";
            this.chkTxt.Size = new System.Drawing.Size(96, 16);
            this.chkTxt.TabIndex = 5;
            this.chkTxt.Text = "保存到记事本";
            this.chkTxt.UseVisualStyleBackColor = true;
            this.chkTxt.CheckedChanged += new System.EventHandler(this.chkTxt_CheckedChanged);
            // 
            // chkMdb
            // 
            this.chkMdb.AutoSize = true;
            this.chkMdb.Location = new System.Drawing.Point(22, 68);
            this.chkMdb.Name = "chkMdb";
            this.chkMdb.Size = new System.Drawing.Size(96, 16);
            this.chkMdb.TabIndex = 6;
            this.chkMdb.Text = "保存到数据库";
            this.chkMdb.UseVisualStyleBackColor = true;
            this.chkMdb.CheckedChanged += new System.EventHandler(this.chkTxt_CheckedChanged);
            // 
            // chkExcel
            // 
            this.chkExcel.AutoSize = true;
            this.chkExcel.Location = new System.Drawing.Point(22, 90);
            this.chkExcel.Name = "chkExcel";
            this.chkExcel.Size = new System.Drawing.Size(90, 16);
            this.chkExcel.TabIndex = 7;
            this.chkExcel.Text = "保存到EXCEL";
            this.chkExcel.UseVisualStyleBackColor = true;
            this.chkExcel.CheckedChanged += new System.EventHandler(this.chkTxt_CheckedChanged);
            // 
            // txtSendContent
            // 
            this.txtSendContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSendContent.Location = new System.Drawing.Point(7, 20);
            this.txtSendContent.Name = "txtSendContent";
            this.txtSendContent.Size = new System.Drawing.Size(318, 287);
            this.txtSendContent.TabIndex = 8;
            this.txtSendContent.Text = "";
            this.toolTipInfo.SetToolTip(this.txtSendContent, "此处填写邮件内容，支持HTML邮件格式源代码，\r\nVip特权账号支持可视化编辑！");
            // 
            // txtSendEmail
            // 
            this.txtSendEmail.Location = new System.Drawing.Point(299, 14);
            this.txtSendEmail.Name = "txtSendEmail";
            this.txtSendEmail.Size = new System.Drawing.Size(164, 21);
            this.txtSendEmail.TabIndex = 9;
            this.txtSendEmail.Text = "bywei@bywei.cn";
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(136, 80);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "导出...";
            this.toolTipInfo.SetToolTip(this.btnSave, "保存数据到指定位置");
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(476, 12);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 10;
            this.btnSend.Text = "发送邮件";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtSendName
            // 
            this.txtSendName.Location = new System.Drawing.Point(299, 48);
            this.txtSendName.Name = "txtSendName";
            this.txtSendName.Size = new System.Drawing.Size(164, 21);
            this.txtSendName.TabIndex = 11;
            this.txtSendName.Text = "百味";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(240, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "回复地址";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 13;
            this.label2.Text = "发件人名";
            // 
            // txtSendTitle
            // 
            this.txtSendTitle.Location = new System.Drawing.Point(6, 17);
            this.txtSendTitle.Name = "txtSendTitle";
            this.txtSendTitle.Size = new System.Drawing.Size(319, 21);
            this.txtSendTitle.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSendTitle);
            this.groupBox1.Location = new System.Drawing.Point(231, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 44);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "邮件标题";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnFj);
            this.groupBox2.Controls.Add(this.txtFj);
            this.groupBox2.Controls.Add(this.txtSendContent);
            this.groupBox2.Location = new System.Drawing.Point(231, 135);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(331, 342);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "邮件内容";
            this.toolTipInfo.SetToolTip(this.groupBox2, "此处填写邮件内容，支持HTML邮件格式源代码，\r\nVip特权账号支持可视化编辑！");
            // 
            // btnFj
            // 
            this.btnFj.Location = new System.Drawing.Point(250, 313);
            this.btnFj.Name = "btnFj";
            this.btnFj.Size = new System.Drawing.Size(75, 23);
            this.btnFj.TabIndex = 17;
            this.btnFj.Text = "附件";
            this.btnFj.UseVisualStyleBackColor = true;
            this.btnFj.Click += new System.EventHandler(this.btnFj_Click);
            // 
            // txtFj
            // 
            this.txtFj.Location = new System.Drawing.Point(6, 315);
            this.txtFj.Name = "txtFj";
            this.txtFj.Size = new System.Drawing.Size(238, 21);
            this.txtFj.TabIndex = 15;
            // 
            // btnConfig
            // 
            this.btnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfig.Location = new System.Drawing.Point(568, 12);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(181, 23);
            this.btnConfig.TabIndex = 17;
            this.btnConfig.Text = "配置邮件服务器";
            this.toolTipInfo.SetToolTip(this.btnConfig, "此处设置您的邮件发件人地址");
            this.btnConfig.UseVisualStyleBackColor = true;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(568, 135);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(181, 341);
            this.tabControl1.TabIndex = 18;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listBoxAccess);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(173, 316);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "成功";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listBoxAccess
            // 
            this.listBoxAccess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxAccess.FormattingEnabled = true;
            this.listBoxAccess.ItemHeight = 12;
            this.listBoxAccess.Location = new System.Drawing.Point(3, 3);
            this.listBoxAccess.Name = "listBoxAccess";
            this.listBoxAccess.Size = new System.Drawing.Size(167, 310);
            this.listBoxAccess.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 21);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(173, 316);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "失败";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(692, 132);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(52, 23);
            this.button4.TabIndex = 19;
            this.button4.Text = "sLog";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtTime);
            this.groupBox3.Controls.Add(this.linkLabelHelper);
            this.groupBox3.Controls.Add(this.linkScore);
            this.groupBox3.Controls.Add(this.chkMackMoney);
            this.groupBox3.Location = new System.Drawing.Point(231, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(331, 81);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(295, 35);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(25, 21);
            this.txtTime.TabIndex = 3;
            this.txtTime.Text = "2";
            this.toolTipInfo.SetToolTip(this.txtTime, "设置发送间隔，单位为“秒”");
            // 
            // linkLabelHelper
            // 
            this.linkLabelHelper.AutoSize = true;
            this.linkLabelHelper.Location = new System.Drawing.Point(305, 57);
            this.linkLabelHelper.Name = "linkLabelHelper";
            this.linkLabelHelper.Size = new System.Drawing.Size(17, 12);
            this.linkLabelHelper.TabIndex = 2;
            this.linkLabelHelper.TabStop = true;
            this.linkLabelHelper.Text = "？";
            this.toolTipInfo.SetToolTip(this.linkLabelHelper, "点击查看帮助，及时提交您的咨询！");
            this.linkLabelHelper.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelHelper_LinkClicked);
            // 
            // linkScore
            // 
            this.linkScore.AutoSize = true;
            this.linkScore.Location = new System.Drawing.Point(246, 57);
            this.linkScore.Name = "linkScore";
            this.linkScore.Size = new System.Drawing.Size(53, 12);
            this.linkScore.TabIndex = 1;
            this.linkScore.TabStop = true;
            this.linkScore.Text = "查看积分";
            this.toolTipInfo.SetToolTip(this.linkScore, "点击查看您所拥有的积分，积分越高能够群发的邮件数量就越大！\r\n您也可以购买vip特权，将不限制邮件发送量！");
            this.linkScore.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkScore_LinkClicked);
            // 
            // chkMackMoney
            // 
            this.chkMackMoney.AutoSize = true;
            this.chkMackMoney.Checked = true;
            this.chkMackMoney.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMackMoney.Location = new System.Drawing.Point(248, 38);
            this.chkMackMoney.Name = "chkMackMoney";
            this.chkMackMoney.Size = new System.Drawing.Size(48, 16);
            this.chkMackMoney.TabIndex = 0;
            this.chkMackMoney.Text = "赚分";
            this.toolTipInfo.SetToolTip(this.chkMackMoney, "你使用赚分时将会在您的邮件后面添加上我们\r\n的广告，赚分越多，发送无广告的邮件就越多！\r\n您也可以购买Vip特权账号，将无限制！");
            this.chkMackMoney.UseVisualStyleBackColor = true;
            // 
            // groupBoxAdd
            // 
            this.groupBoxAdd.Controls.Add(this.btnClose);
            this.groupBoxAdd.Controls.Add(this.btnSaveEmail);
            this.groupBoxAdd.Controls.Add(this.txtAddPassward);
            this.groupBoxAdd.Controls.Add(this.txtAddEmail);
            this.groupBoxAdd.Location = new System.Drawing.Point(568, 32);
            this.groupBoxAdd.Name = "groupBoxAdd";
            this.groupBoxAdd.Size = new System.Drawing.Size(181, 98);
            this.groupBoxAdd.TabIndex = 21;
            this.groupBoxAdd.TabStop = false;
            this.groupBoxAdd.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(115, 44);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(46, 23);
            this.btnClose.TabIndex = 23;
            this.btnClose.Text = "Exit";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSaveEmail
            // 
            this.btnSaveEmail.Location = new System.Drawing.Point(115, 15);
            this.btnSaveEmail.Name = "btnSaveEmail";
            this.btnSaveEmail.Size = new System.Drawing.Size(46, 23);
            this.btnSaveEmail.TabIndex = 22;
            this.btnSaveEmail.Text = "Save";
            this.btnSaveEmail.UseVisualStyleBackColor = true;
            this.btnSaveEmail.Click += new System.EventHandler(this.btnSaveEmail_Click);
            // 
            // txtAddPassward
            // 
            this.txtAddPassward.Location = new System.Drawing.Point(16, 46);
            this.txtAddPassward.Name = "txtAddPassward";
            this.txtAddPassward.PasswordChar = '*';
            this.txtAddPassward.Size = new System.Drawing.Size(97, 21);
            this.txtAddPassward.TabIndex = 1;
            // 
            // txtAddEmail
            // 
            this.txtAddEmail.Location = new System.Drawing.Point(16, 17);
            this.txtAddEmail.Name = "txtAddEmail";
            this.txtAddEmail.Size = new System.Drawing.Size(97, 21);
            this.txtAddEmail.TabIndex = 0;
            // 
            // dgvEmailConfig
            // 
            this.dgvEmailConfig.AllowUserToAddRows = false;
            this.dgvEmailConfig.AllowUserToDeleteRows = false;
            this.dgvEmailConfig.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmailConfig.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmailConfig.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEmailConfig.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmailConfig.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Email,
            this.Passward});
            this.dgvEmailConfig.ContextMenuStrip = this.conMenuSAdd;
            this.dgvEmailConfig.GridColor = System.Drawing.Color.LightSeaGreen;
            this.dgvEmailConfig.Location = new System.Drawing.Point(568, 32);
            this.dgvEmailConfig.MultiSelect = false;
            this.dgvEmailConfig.Name = "dgvEmailConfig";
            this.dgvEmailConfig.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmailConfig.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEmailConfig.RowHeadersVisible = false;
            this.dgvEmailConfig.RowTemplate.Height = 23;
            this.dgvEmailConfig.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmailConfig.Size = new System.Drawing.Size(181, 98);
            this.dgvEmailConfig.TabIndex = 21;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.FillWeight = 121.8274F;
            this.Email.HeaderText = "发件人";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Passward
            // 
            this.Passward.DataPropertyName = "Passward";
            this.Passward.FillWeight = 78.17259F;
            this.Passward.HeaderText = "密码";
            this.Passward.Name = "Passward";
            this.Passward.ReadOnly = true;
            // 
            // conMenuSAdd
            // 
            this.conMenuSAdd.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolAdd,
            this.toolsDel,
            this.toolsUpdate});
            this.conMenuSAdd.Name = "conMenuSAdd";
            this.conMenuSAdd.Size = new System.Drawing.Size(131, 70);
            // 
            // toolAdd
            // 
            this.toolAdd.Name = "toolAdd";
            this.toolAdd.Size = new System.Drawing.Size(130, 22);
            this.toolAdd.Text = "增加服务器";
            this.toolAdd.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // toolsDel
            // 
            this.toolsDel.Name = "toolsDel";
            this.toolsDel.Size = new System.Drawing.Size(130, 22);
            this.toolsDel.Text = "删除服务器";
            this.toolsDel.Click += new System.EventHandler(this.toolsDel_Click);
            // 
            // toolsUpdate
            // 
            this.toolsUpdate.Name = "toolsUpdate";
            this.toolsUpdate.Size = new System.Drawing.Size(130, 22);
            this.toolsUpdate.Text = "修改服务器";
            this.toolsUpdate.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // sfdTxt
            // 
            this.sfdTxt.DefaultExt = "txt";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnDataBase);
            this.groupBox4.Controls.Add(this.btnSave);
            this.groupBox4.Controls.Add(this.btnImport);
            this.groupBox4.Location = new System.Drawing.Point(12, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(213, 115);
            this.groupBox4.TabIndex = 22;
            this.groupBox4.TabStop = false;
            // 
            // btnDataBase
            // 
            this.btnDataBase.Location = new System.Drawing.Point(136, 46);
            this.btnDataBase.Name = "btnDataBase";
            this.btnDataBase.Size = new System.Drawing.Size(75, 23);
            this.btnDataBase.TabIndex = 23;
            this.btnDataBase.Text = "加载数据库";
            this.toolTipInfo.SetToolTip(this.btnDataBase, "将从数据库中加载一亿五千万的\r\n海量EMAIL地址，普通账号有数\r\n量限制！");
            this.btnDataBase.UseVisualStyleBackColor = true;
            this.btnDataBase.Click += new System.EventHandler(this.btnDataBase_Click);
            // 
            // notifyIconEmail
            // 
            this.notifyIconEmail.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconEmail.Icon")));
            this.notifyIconEmail.Text = "百味邮件群发系统正在运行...";
            this.notifyIconEmail.Visible = true;
            // 
            // timerSend
            // 
            this.timerSend.Interval = 2000;
            this.timerSend.Tick += new System.EventHandler(this.timerSend_Tick);
            // 
            // EmailFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 489);
            this.Controls.Add(this.groupBoxAdd);
            this.Controls.Add(this.dgvEmailConfig);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnConfig);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSendName);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtSendEmail);
            this.Controls.Add(this.chkExcel);
            this.Controls.Add(this.chkMdb);
            this.Controls.Add(this.chkTxt);
            this.Controls.Add(this.listBoxEmail);
            this.Controls.Add(this.txtEmailPath);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(766, 523);
            this.Name = "EmailFrm";
            this.Opacity = 0D;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "百味邮件群发系统";
            this.Load += new System.EventHandler(this.EmailFrm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBoxAdd.ResumeLayout(false);
            this.groupBoxAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmailConfig)).EndInit();
            this.conMenuSAdd.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.TextBox txtEmailPath;
        private System.Windows.Forms.ListBox listBoxEmail;
        private System.Windows.Forms.OpenFileDialog ofdEmail;
        private System.Windows.Forms.CheckBox chkTxt;
        private System.Windows.Forms.CheckBox chkMdb;
        private System.Windows.Forms.CheckBox chkExcel;
        private System.Windows.Forms.RichTextBox txtSendContent;
        private System.Windows.Forms.TextBox txtSendEmail;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtSendName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSendTitle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnFj;
        private System.Windows.Forms.TextBox txtFj;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox listBoxAccess;
        private System.Windows.Forms.GroupBox groupBoxAdd;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSaveEmail;
        private System.Windows.Forms.TextBox txtAddPassward;
        private System.Windows.Forms.TextBox txtAddEmail;
        private System.Windows.Forms.DataGridView dgvEmailConfig;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Passward;
        private System.Windows.Forms.SaveFileDialog sfdTxt;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnDataBase;
        private System.Windows.Forms.ContextMenuStrip conMenuSAdd;
        private System.Windows.Forms.ToolStripMenuItem toolAdd;
        private System.Windows.Forms.ToolStripMenuItem toolsDel;
        private System.Windows.Forms.ToolStripMenuItem toolsUpdate;
        private System.Windows.Forms.CheckBox chkMackMoney;
        private System.Windows.Forms.LinkLabel linkScore;
        private System.Windows.Forms.NotifyIcon notifyIconEmail;
        private System.Windows.Forms.ToolTip toolTipInfo;
        private System.Windows.Forms.LinkLabel linkLabelHelper;
        private System.Windows.Forms.Timer timerSend;
        private System.Windows.Forms.TextBox txtTime;
    }
}

