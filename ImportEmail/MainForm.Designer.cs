namespace common
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.skinEngine = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.listViewResult = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStripListView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripListViewClear = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemDelByAccess = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemDelByFailed = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemDelFrom = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemDelInbox = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSendStart = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonStartService = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSendConfig = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonTest = new System.Windows.Forms.ToolStripButton();
            this.tsbStartSend = new System.Windows.Forms.ToolStripButton();
            this.tsbStopSendBtn = new System.Windows.Forms.ToolStripButton();
            this.textBoxProxy = new System.Windows.Forms.TextBox();
            this.comboBoxInboxType = new System.Windows.Forms.ComboBox();
            this.textBoxSendCount = new System.Windows.Forms.TextBox();
            this.textBoxSendFail = new System.Windows.Forms.TextBox();
            this.textBoxVariable = new System.Windows.Forms.TextBox();
            this.textBoxThread = new System.Windows.Forms.TextBox();
            this.textBoxSendTime = new System.Windows.Forms.TextBox();
            this.textBoxForward = new System.Windows.Forms.TextBox();
            this.textBoxCycle = new System.Windows.Forms.TextBox();
            this.comboBoxSendType = new System.Windows.Forms.ComboBox();
            this.textBoxStartTime = new System.Windows.Forms.TextBox();
            this.textBoxState = new System.Windows.Forms.TextBox();
            this.comboBoxEmailTitle = new System.Windows.Forms.ComboBox();
            this.groupBoxEditEmail = new System.Windows.Forms.GroupBox();
            this.dataGridViewEmailInfo = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.content = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sendCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tsbEditEmailAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbEditEmailEdit = new System.Windows.Forms.ToolStripButton();
            this.tsbEditEmailDelete = new System.Windows.Forms.ToolStripButton();
            this.groupBoxEmailConfig = new System.Windows.Forms.GroupBox();
            this.dataGridViewFrom = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FromType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FromAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FromPwd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FromAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FromDomainName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FromSmtp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FromSmtpPort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FromSsl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FrSendCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FrLastDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FrCreateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.tsbEmailConfigAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbEmailConfigImport = new System.Windows.Forms.ToolStripButton();
            this.tsbEmailConfigExport = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbEmailConfigDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.groupBoxAddresConfig = new System.Windows.Forms.GroupBox();
            this.dataGridViewInbox = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InboxAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InboxNickName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISendCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IlastDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ICreateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip4 = new System.Windows.Forms.ToolStrip();
            this.tsbAddressImport = new System.Windows.Forms.ToolStripButton();
            this.tsbAddressExport = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsbAddressExportAndAddress = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbAddressExportAndNick = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbAddressDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.tsbSendEmail = new System.Windows.Forms.ToolStripButton();
            this.tsbEditEmail = new System.Windows.Forms.ToolStripButton();
            this.tsbEmailConfig = new System.Windows.Forms.ToolStripButton();
            this.tsbAddressConfig = new System.Windows.Forms.ToolStripButton();
            this.tsbReg = new System.Windows.Forms.ToolStripButton();
            this.tsbBuy = new System.Windows.Forms.ToolStripButton();
            this.toolStripBannerAd = new System.Windows.Forms.ToolStripLabel();
            this.textBoxIpAddress = new System.Windows.Forms.TextBox();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelRight = new System.Windows.Forms.Panel();
            this.panelSendTool = new System.Windows.Forms.Panel();
            this.picMin = new System.Windows.Forms.PictureBox();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.panelUsers = new System.Windows.Forms.Panel();
            this.userInfoControl = new common.UserInfoFrm();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblBottomAd1 = new System.Windows.Forms.Label();
            this.lblBottomAd2 = new System.Windows.Forms.Label();
            this.contextMenuStripListView.SuspendLayout();
            this.toolStripSendStart.SuspendLayout();
            this.groupBoxEditEmail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmailInfo)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.groupBoxEmailConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFrom)).BeginInit();
            this.toolStrip3.SuspendLayout();
            this.groupBoxAddresConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInbox)).BeginInit();
            this.toolStrip4.SuspendLayout();
            this.toolStripMenu.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.panelSendTool.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            this.panelUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // skinEngine
            // 
            this.skinEngine.SerialNumber = "";
            this.skinEngine.SkinFile = null;
            // 
            // listViewResult
            // 
            this.listViewResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewResult.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader2,
            this.columnHeader1,
            this.columnHeader7,
            this.columnHeader4});
            this.listViewResult.ContextMenuStrip = this.contextMenuStripListView;
            this.listViewResult.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.listViewResult.FullRowSelect = true;
            this.listViewResult.GridLines = true;
            this.listViewResult.Location = new System.Drawing.Point(6, 44);
            this.listViewResult.MultiSelect = false;
            this.listViewResult.Name = "listViewResult";
            this.listViewResult.ShowItemToolTips = true;
            this.listViewResult.Size = new System.Drawing.Size(603, 425);
            this.listViewResult.TabIndex = 1;
            this.listViewResult.UseCompatibleStateImageBehavior = false;
            this.listViewResult.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "序号";
            this.columnHeader5.Width = 75;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "发件ID";
            this.columnHeader6.Width = 85;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "发件账号";
            this.columnHeader2.Width = 113;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "收件账号";
            this.columnHeader1.Width = 109;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "发送耗时";
            this.columnHeader7.Width = 87;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "发送结果";
            this.columnHeader4.Width = 162;
            // 
            // contextMenuStripListView
            // 
            this.contextMenuStripListView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripListViewClear,
            this.ToolStripMenuItemDelByAccess,
            this.ToolStripMenuItemDelByFailed,
            this.ToolStripMenuItemDelFrom,
            this.ToolStripMenuItemDelInbox});
            this.contextMenuStripListView.Name = "contextMenuStripListView";
            this.contextMenuStripListView.Size = new System.Drawing.Size(179, 114);
            // 
            // ToolStripListViewClear
            // 
            this.ToolStripListViewClear.Name = "ToolStripListViewClear";
            this.ToolStripListViewClear.Size = new System.Drawing.Size(178, 22);
            this.ToolStripListViewClear.Text = "清空发送日志";
            this.ToolStripListViewClear.Click += new System.EventHandler(this.ToolStripListViewClear_Click);
            // 
            // ToolStripMenuItemDelByAccess
            // 
            this.ToolStripMenuItemDelByAccess.Name = "ToolStripMenuItemDelByAccess";
            this.ToolStripMenuItemDelByAccess.Size = new System.Drawing.Size(178, 22);
            this.ToolStripMenuItemDelByAccess.Text = "删除发送成功收件人";
            this.ToolStripMenuItemDelByAccess.Click += new System.EventHandler(this.ToolStripMenuItemDelByAccess_Click);
            // 
            // ToolStripMenuItemDelByFailed
            // 
            this.ToolStripMenuItemDelByFailed.Name = "ToolStripMenuItemDelByFailed";
            this.ToolStripMenuItemDelByFailed.Size = new System.Drawing.Size(178, 22);
            this.ToolStripMenuItemDelByFailed.Text = "删除发送失败收件人";
            this.ToolStripMenuItemDelByFailed.Click += new System.EventHandler(this.ToolStripMenuItemDelByFailed_Click);
            // 
            // ToolStripMenuItemDelFrom
            // 
            this.ToolStripMenuItemDelFrom.Enabled = false;
            this.ToolStripMenuItemDelFrom.Name = "ToolStripMenuItemDelFrom";
            this.ToolStripMenuItemDelFrom.Size = new System.Drawing.Size(178, 22);
            this.ToolStripMenuItemDelFrom.Text = "删除所有发件人";
            this.ToolStripMenuItemDelFrom.Click += new System.EventHandler(this.ToolStripMenuItemDelFrom_Click);
            // 
            // ToolStripMenuItemDelInbox
            // 
            this.ToolStripMenuItemDelInbox.Enabled = false;
            this.ToolStripMenuItemDelInbox.Name = "ToolStripMenuItemDelInbox";
            this.ToolStripMenuItemDelInbox.Size = new System.Drawing.Size(178, 22);
            this.ToolStripMenuItemDelInbox.Text = "删除所有收件人";
            this.ToolStripMenuItemDelInbox.Click += new System.EventHandler(this.ToolStripMenuItemDelInbox_Click);
            // 
            // toolStripSendStart
            // 
            this.toolStripSendStart.BackColor = System.Drawing.Color.Transparent;
            this.toolStripSendStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.toolStripSendStart.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripSendStart.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonStartService,
            this.toolStripButtonSendConfig,
            this.toolStripButtonTest,
            this.tsbStartSend,
            this.tsbStopSendBtn});
            this.toolStripSendStart.Location = new System.Drawing.Point(0, 0);
            this.toolStripSendStart.Name = "toolStripSendStart";
            this.toolStripSendStart.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStripSendStart.Size = new System.Drawing.Size(603, 29);
            this.toolStripSendStart.TabIndex = 0;
            this.toolStripSendStart.Paint += new System.Windows.Forms.PaintEventHandler(this.toolStripMenu_Paint);
            // 
            // toolStripButtonStartService
            // 
            this.toolStripButtonStartService.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonStartService.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripButtonStartService.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.toolStripButtonStartService.Image = global::common.Properties.Resources.startService;
            this.toolStripButtonStartService.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonStartService.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonStartService.Name = "toolStripButtonStartService";
            this.toolStripButtonStartService.Size = new System.Drawing.Size(84, 26);
            this.toolStripButtonStartService.Text = "手动启动服务";
            this.toolStripButtonStartService.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.toolStripButtonStartService.Click += new System.EventHandler(this.toolStripButtonStartService_Click);
            // 
            // toolStripButtonSendConfig
            // 
            this.toolStripButtonSendConfig.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSendConfig.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripButtonSendConfig.ForeColor = System.Drawing.Color.DimGray;
            this.toolStripButtonSendConfig.Image = global::common.Properties.Resources.setting;
            this.toolStripButtonSendConfig.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonSendConfig.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSendConfig.Name = "toolStripButtonSendConfig";
            this.toolStripButtonSendConfig.Size = new System.Drawing.Size(84, 26);
            this.toolStripButtonSendConfig.Text = "邮件配置";
            this.toolStripButtonSendConfig.Click += new System.EventHandler(this.toolStripButtonSendConfig_Click);
            // 
            // toolStripButtonTest
            // 
            this.toolStripButtonTest.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonTest.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripButtonTest.ForeColor = System.Drawing.Color.Gray;
            this.toolStripButtonTest.Image = global::common.Properties.Resources.sendTest;
            this.toolStripButtonTest.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonTest.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonTest.Name = "toolStripButtonTest";
            this.toolStripButtonTest.Size = new System.Drawing.Size(84, 26);
            this.toolStripButtonTest.Text = "测试一封";
            this.toolStripButtonTest.Click += new System.EventHandler(this.toolStripButtonTest_Click);
            // 
            // tsbStartSend
            // 
            this.tsbStartSend.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbStartSend.Image = global::common.Properties.Resources.startSend;
            this.tsbStartSend.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbStartSend.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbStartSend.Name = "tsbStartSend";
            this.tsbStartSend.Size = new System.Drawing.Size(84, 26);
            this.tsbStartSend.Tag = "pause";
            this.tsbStartSend.Text = "开始发送";
            this.tsbStartSend.Click += new System.EventHandler(this.tsbStartSend_Click);
            // 
            // tsbStopSendBtn
            // 
            this.tsbStopSendBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbStopSendBtn.Enabled = false;
            this.tsbStopSendBtn.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsbStopSendBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tsbStopSendBtn.Image = global::common.Properties.Resources.stopSend;
            this.tsbStopSendBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbStopSendBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbStopSendBtn.Name = "tsbStopSendBtn";
            this.tsbStopSendBtn.Size = new System.Drawing.Size(84, 26);
            this.tsbStopSendBtn.Tag = "over";
            this.tsbStopSendBtn.Text = "停止";
            this.tsbStopSendBtn.Click += new System.EventHandler(this.tsbOverSendBtn_Click);
            // 
            // textBoxProxy
            // 
            this.textBoxProxy.BackColor = System.Drawing.Color.White;
            this.textBoxProxy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxProxy.Location = new System.Drawing.Point(93, 107);
            this.textBoxProxy.Name = "textBoxProxy";
            this.textBoxProxy.ReadOnly = true;
            this.textBoxProxy.Size = new System.Drawing.Size(120, 14);
            this.textBoxProxy.TabIndex = 33;
            // 
            // comboBoxInboxType
            // 
            this.comboBoxInboxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxInboxType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxInboxType.FormattingEnabled = true;
            this.comboBoxInboxType.Location = new System.Drawing.Point(93, 164);
            this.comboBoxInboxType.Name = "comboBoxInboxType";
            this.comboBoxInboxType.Size = new System.Drawing.Size(120, 20);
            this.comboBoxInboxType.TabIndex = 32;
            // 
            // textBoxSendCount
            // 
            this.textBoxSendCount.BackColor = System.Drawing.Color.White;
            this.textBoxSendCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSendCount.Location = new System.Drawing.Point(93, 378);
            this.textBoxSendCount.Name = "textBoxSendCount";
            this.textBoxSendCount.ReadOnly = true;
            this.textBoxSendCount.Size = new System.Drawing.Size(120, 14);
            this.textBoxSendCount.TabIndex = 31;
            // 
            // textBoxSendFail
            // 
            this.textBoxSendFail.BackColor = System.Drawing.Color.White;
            this.textBoxSendFail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSendFail.Location = new System.Drawing.Point(93, 349);
            this.textBoxSendFail.Name = "textBoxSendFail";
            this.textBoxSendFail.ReadOnly = true;
            this.textBoxSendFail.Size = new System.Drawing.Size(120, 14);
            this.textBoxSendFail.TabIndex = 30;
            // 
            // textBoxVariable
            // 
            this.textBoxVariable.BackColor = System.Drawing.Color.White;
            this.textBoxVariable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxVariable.Location = new System.Drawing.Point(93, 319);
            this.textBoxVariable.Name = "textBoxVariable";
            this.textBoxVariable.ReadOnly = true;
            this.textBoxVariable.Size = new System.Drawing.Size(120, 14);
            this.textBoxVariable.TabIndex = 27;
            // 
            // textBoxThread
            // 
            this.textBoxThread.BackColor = System.Drawing.Color.White;
            this.textBoxThread.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxThread.Location = new System.Drawing.Point(93, 289);
            this.textBoxThread.Name = "textBoxThread";
            this.textBoxThread.ReadOnly = true;
            this.textBoxThread.Size = new System.Drawing.Size(120, 14);
            this.textBoxThread.TabIndex = 26;
            // 
            // textBoxSendTime
            // 
            this.textBoxSendTime.BackColor = System.Drawing.Color.White;
            this.textBoxSendTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSendTime.Location = new System.Drawing.Point(93, 259);
            this.textBoxSendTime.Name = "textBoxSendTime";
            this.textBoxSendTime.ReadOnly = true;
            this.textBoxSendTime.Size = new System.Drawing.Size(120, 14);
            this.textBoxSendTime.TabIndex = 25;
            // 
            // textBoxForward
            // 
            this.textBoxForward.BackColor = System.Drawing.Color.White;
            this.textBoxForward.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxForward.Location = new System.Drawing.Point(93, 228);
            this.textBoxForward.Name = "textBoxForward";
            this.textBoxForward.ReadOnly = true;
            this.textBoxForward.Size = new System.Drawing.Size(120, 14);
            this.textBoxForward.TabIndex = 24;
            // 
            // textBoxCycle
            // 
            this.textBoxCycle.BackColor = System.Drawing.Color.White;
            this.textBoxCycle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCycle.Location = new System.Drawing.Point(93, 198);
            this.textBoxCycle.Name = "textBoxCycle";
            this.textBoxCycle.ReadOnly = true;
            this.textBoxCycle.Size = new System.Drawing.Size(120, 14);
            this.textBoxCycle.TabIndex = 23;
            // 
            // comboBoxSendType
            // 
            this.comboBoxSendType.BackColor = System.Drawing.Color.White;
            this.comboBoxSendType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSendType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxSendType.FormattingEnabled = true;
            this.comboBoxSendType.Location = new System.Drawing.Point(93, 134);
            this.comboBoxSendType.Name = "comboBoxSendType";
            this.comboBoxSendType.Size = new System.Drawing.Size(120, 20);
            this.comboBoxSendType.TabIndex = 21;
            // 
            // textBoxStartTime
            // 
            this.textBoxStartTime.BackColor = System.Drawing.Color.White;
            this.textBoxStartTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxStartTime.Location = new System.Drawing.Point(93, 77);
            this.textBoxStartTime.Name = "textBoxStartTime";
            this.textBoxStartTime.ReadOnly = true;
            this.textBoxStartTime.Size = new System.Drawing.Size(120, 14);
            this.textBoxStartTime.TabIndex = 19;
            // 
            // textBoxState
            // 
            this.textBoxState.BackColor = System.Drawing.Color.White;
            this.textBoxState.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxState.Location = new System.Drawing.Point(93, 18);
            this.textBoxState.Name = "textBoxState";
            this.textBoxState.ReadOnly = true;
            this.textBoxState.Size = new System.Drawing.Size(120, 14);
            this.textBoxState.TabIndex = 3;
            // 
            // comboBoxEmailTitle
            // 
            this.comboBoxEmailTitle.BackColor = System.Drawing.Color.White;
            this.comboBoxEmailTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEmailTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxEmailTitle.FormattingEnabled = true;
            this.comboBoxEmailTitle.Location = new System.Drawing.Point(92, 44);
            this.comboBoxEmailTitle.Name = "comboBoxEmailTitle";
            this.comboBoxEmailTitle.Size = new System.Drawing.Size(120, 20);
            this.comboBoxEmailTitle.TabIndex = 3;
            // 
            // groupBoxEditEmail
            // 
            this.groupBoxEditEmail.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxEditEmail.Controls.Add(this.dataGridViewEmailInfo);
            this.groupBoxEditEmail.Controls.Add(this.toolStrip2);
            this.groupBoxEditEmail.Location = new System.Drawing.Point(874, 117);
            this.groupBoxEditEmail.Name = "groupBoxEditEmail";
            this.groupBoxEditEmail.Size = new System.Drawing.Size(314, 112);
            this.groupBoxEditEmail.TabIndex = 1;
            this.groupBoxEditEmail.TabStop = false;
            this.groupBoxEditEmail.Text = "编辑邮件";
            this.groupBoxEditEmail.Visible = false;
            // 
            // dataGridViewEmailInfo
            // 
            this.dataGridViewEmailInfo.AllowUserToAddRows = false;
            this.dataGridViewEmailInfo.AllowUserToDeleteRows = false;
            this.dataGridViewEmailInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEmailInfo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.dataGridViewEmailInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewEmailInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmailInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.EmailTitle,
            this.content,
            this.sendCount,
            this.lastDate,
            this.createDate});
            this.dataGridViewEmailInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewEmailInfo.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewEmailInfo.Location = new System.Drawing.Point(3, 46);
            this.dataGridViewEmailInfo.MultiSelect = false;
            this.dataGridViewEmailInfo.Name = "dataGridViewEmailInfo";
            this.dataGridViewEmailInfo.ReadOnly = true;
            this.dataGridViewEmailInfo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewEmailInfo.RowTemplate.Height = 23;
            this.dataGridViewEmailInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEmailInfo.Size = new System.Drawing.Size(308, 63);
            this.dataGridViewEmailInfo.TabIndex = 1;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "序号";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // EmailTitle
            // 
            this.EmailTitle.DataPropertyName = "title";
            this.EmailTitle.HeaderText = "标题";
            this.EmailTitle.Name = "EmailTitle";
            this.EmailTitle.ReadOnly = true;
            // 
            // content
            // 
            this.content.DataPropertyName = "content";
            this.content.HeaderText = "内容";
            this.content.Name = "content";
            this.content.ReadOnly = true;
            // 
            // sendCount
            // 
            this.sendCount.DataPropertyName = "sendCount";
            this.sendCount.HeaderText = "已发";
            this.sendCount.Name = "sendCount";
            this.sendCount.ReadOnly = true;
            // 
            // lastDate
            // 
            this.lastDate.DataPropertyName = "lastDate";
            this.lastDate.HeaderText = "最后时间";
            this.lastDate.Name = "lastDate";
            this.lastDate.ReadOnly = true;
            // 
            // createDate
            // 
            this.createDate.DataPropertyName = "createDate";
            this.createDate.HeaderText = "创建时间";
            this.createDate.Name = "createDate";
            this.createDate.ReadOnly = true;
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbEditEmailAdd,
            this.tsbEditEmailEdit,
            this.tsbEditEmailDelete});
            this.toolStrip2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip2.Location = new System.Drawing.Point(3, 17);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip2.Size = new System.Drawing.Size(308, 29);
            this.toolStrip2.TabIndex = 0;
            // 
            // tsbEditEmailAdd
            // 
            this.tsbEditEmailAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEditEmailAdd.Image = global::common.Properties.Resources.create;
            this.tsbEditEmailAdd.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbEditEmailAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditEmailAdd.Name = "tsbEditEmailAdd";
            this.tsbEditEmailAdd.Size = new System.Drawing.Size(84, 26);
            this.tsbEditEmailAdd.Text = "编辑";
            this.tsbEditEmailAdd.Click += new System.EventHandler(this.tsbEditEmailAdd_Click);
            // 
            // tsbEditEmailEdit
            // 
            this.tsbEditEmailEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEditEmailEdit.Image = global::common.Properties.Resources.update;
            this.tsbEditEmailEdit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbEditEmailEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditEmailEdit.Name = "tsbEditEmailEdit";
            this.tsbEditEmailEdit.Size = new System.Drawing.Size(84, 26);
            this.tsbEditEmailEdit.Text = "修改";
            this.tsbEditEmailEdit.Click += new System.EventHandler(this.tsbEditEmailUpdate_Click);
            // 
            // tsbEditEmailDelete
            // 
            this.tsbEditEmailDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEditEmailDelete.Image = global::common.Properties.Resources.remove;
            this.tsbEditEmailDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbEditEmailDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditEmailDelete.Name = "tsbEditEmailDelete";
            this.tsbEditEmailDelete.Size = new System.Drawing.Size(84, 26);
            this.tsbEditEmailDelete.Text = "删除";
            this.tsbEditEmailDelete.Click += new System.EventHandler(this.tsbEditEmailDelete_Click);
            // 
            // groupBoxEmailConfig
            // 
            this.groupBoxEmailConfig.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxEmailConfig.Controls.Add(this.dataGridViewFrom);
            this.groupBoxEmailConfig.Controls.Add(this.toolStrip3);
            this.groupBoxEmailConfig.Location = new System.Drawing.Point(880, 340);
            this.groupBoxEmailConfig.Name = "groupBoxEmailConfig";
            this.groupBoxEmailConfig.Size = new System.Drawing.Size(390, 114);
            this.groupBoxEmailConfig.TabIndex = 2;
            this.groupBoxEmailConfig.TabStop = false;
            this.groupBoxEmailConfig.Text = "发件配置";
            this.groupBoxEmailConfig.Visible = false;
            // 
            // dataGridViewFrom
            // 
            this.dataGridViewFrom.AllowUserToAddRows = false;
            this.dataGridViewFrom.AllowUserToDeleteRows = false;
            this.dataGridViewFrom.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewFrom.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.dataGridViewFrom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewFrom.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewFrom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFrom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.FromType,
            this.FromAccount,
            this.FromPwd,
            this.FromAddress,
            this.FState,
            this.FromDomainName,
            this.FromSmtp,
            this.FromSmtpPort,
            this.FromSsl,
            this.FrSendCount,
            this.FrLastDate,
            this.FrCreateDate});
            this.dataGridViewFrom.ContextMenuStrip = this.contextMenuStripListView;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewFrom.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewFrom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewFrom.Location = new System.Drawing.Point(3, 47);
            this.dataGridViewFrom.MultiSelect = false;
            this.dataGridViewFrom.Name = "dataGridViewFrom";
            this.dataGridViewFrom.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewFrom.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewFrom.RowTemplate.Height = 23;
            this.dataGridViewFrom.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewFrom.Size = new System.Drawing.Size(384, 64);
            this.dataGridViewFrom.TabIndex = 1;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "id";
            this.Column2.HeaderText = "序号";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // FromType
            // 
            this.FromType.DataPropertyName = "type";
            this.FromType.HeaderText = "类型";
            this.FromType.Name = "FromType";
            this.FromType.ReadOnly = true;
            // 
            // FromAccount
            // 
            this.FromAccount.DataPropertyName = "account";
            this.FromAccount.HeaderText = "用户";
            this.FromAccount.Name = "FromAccount";
            this.FromAccount.ReadOnly = true;
            // 
            // FromPwd
            // 
            this.FromPwd.DataPropertyName = "pwd";
            this.FromPwd.HeaderText = "密码";
            this.FromPwd.Name = "FromPwd";
            this.FromPwd.ReadOnly = true;
            // 
            // FromAddress
            // 
            this.FromAddress.DataPropertyName = "fromAddress";
            this.FromAddress.HeaderText = "地址";
            this.FromAddress.Name = "FromAddress";
            this.FromAddress.ReadOnly = true;
            // 
            // FState
            // 
            this.FState.DataPropertyName = "state";
            this.FState.HeaderText = "状态";
            this.FState.Name = "FState";
            this.FState.ReadOnly = true;
            // 
            // FromDomainName
            // 
            this.FromDomainName.DataPropertyName = "domainName";
            this.FromDomainName.HeaderText = "域名后缀";
            this.FromDomainName.Name = "FromDomainName";
            this.FromDomainName.ReadOnly = true;
            // 
            // FromSmtp
            // 
            this.FromSmtp.DataPropertyName = "smtp";
            this.FromSmtp.HeaderText = "SMTP";
            this.FromSmtp.Name = "FromSmtp";
            this.FromSmtp.ReadOnly = true;
            // 
            // FromSmtpPort
            // 
            this.FromSmtpPort.DataPropertyName = "smtpPort";
            this.FromSmtpPort.HeaderText = "端口";
            this.FromSmtpPort.Name = "FromSmtpPort";
            this.FromSmtpPort.ReadOnly = true;
            // 
            // FromSsl
            // 
            this.FromSsl.DataPropertyName = "ssl";
            this.FromSsl.HeaderText = "SSL";
            this.FromSsl.Name = "FromSsl";
            this.FromSsl.ReadOnly = true;
            // 
            // FrSendCount
            // 
            this.FrSendCount.DataPropertyName = "sendCount";
            this.FrSendCount.HeaderText = "已发";
            this.FrSendCount.Name = "FrSendCount";
            this.FrSendCount.ReadOnly = true;
            // 
            // FrLastDate
            // 
            this.FrLastDate.DataPropertyName = "lastDate";
            this.FrLastDate.HeaderText = "最后发送";
            this.FrLastDate.Name = "FrLastDate";
            this.FrLastDate.ReadOnly = true;
            // 
            // FrCreateDate
            // 
            this.FrCreateDate.DataPropertyName = "createDate";
            this.FrCreateDate.HeaderText = "创建时间";
            this.FrCreateDate.Name = "FrCreateDate";
            this.FrCreateDate.ReadOnly = true;
            // 
            // toolStrip3
            // 
            this.toolStrip3.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbEmailConfigAdd,
            this.tsbEmailConfigImport,
            this.tsbEmailConfigExport,
            this.toolStripSeparator1,
            this.tsbEmailConfigDelete,
            this.toolStripComboBox1});
            this.toolStrip3.Location = new System.Drawing.Point(3, 17);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip3.Size = new System.Drawing.Size(384, 30);
            this.toolStrip3.TabIndex = 0;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // tsbEmailConfigAdd
            // 
            this.tsbEmailConfigAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEmailConfigAdd.Image = global::common.Properties.Resources.createUserMailIcon;
            this.tsbEmailConfigAdd.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbEmailConfigAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEmailConfigAdd.Name = "tsbEmailConfigAdd";
            this.tsbEmailConfigAdd.Size = new System.Drawing.Size(90, 27);
            this.tsbEmailConfigAdd.Text = "添加发件人";
            this.tsbEmailConfigAdd.Click += new System.EventHandler(this.tsbEmailConfigAdd_Click);
            // 
            // tsbEmailConfigImport
            // 
            this.tsbEmailConfigImport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEmailConfigImport.Image = global::common.Properties.Resources.import;
            this.tsbEmailConfigImport.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbEmailConfigImport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEmailConfigImport.Name = "tsbEmailConfigImport";
            this.tsbEmailConfigImport.Size = new System.Drawing.Size(64, 27);
            this.tsbEmailConfigImport.Text = "导入";
            this.tsbEmailConfigImport.Click += new System.EventHandler(this.tsbEmailConfigImport_Click);
            // 
            // tsbEmailConfigExport
            // 
            this.tsbEmailConfigExport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEmailConfigExport.Image = global::common.Properties.Resources.export;
            this.tsbEmailConfigExport.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbEmailConfigExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEmailConfigExport.Name = "tsbEmailConfigExport";
            this.tsbEmailConfigExport.Size = new System.Drawing.Size(64, 27);
            this.tsbEmailConfigExport.Text = "导出";
            this.tsbEmailConfigExport.Click += new System.EventHandler(this.tsbEmailConfigExport_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 30);
            // 
            // tsbEmailConfigDelete
            // 
            this.tsbEmailConfigDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEmailConfigDelete.Image = global::common.Properties.Resources.removeAll;
            this.tsbEmailConfigDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbEmailConfigDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEmailConfigDelete.Name = "tsbEmailConfigDelete";
            this.tsbEmailConfigDelete.Size = new System.Drawing.Size(90, 27);
            this.tsbEmailConfigDelete.Text = "删除选中";
            this.tsbEmailConfigDelete.Click += new System.EventHandler(this.tsbEmailConfigDelete_Click);
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 26);
            // 
            // groupBoxAddresConfig
            // 
            this.groupBoxAddresConfig.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxAddresConfig.Controls.Add(this.dataGridViewInbox);
            this.groupBoxAddresConfig.Controls.Add(this.toolStrip4);
            this.groupBoxAddresConfig.Location = new System.Drawing.Point(877, 235);
            this.groupBoxAddresConfig.Name = "groupBoxAddresConfig";
            this.groupBoxAddresConfig.Size = new System.Drawing.Size(471, 99);
            this.groupBoxAddresConfig.TabIndex = 3;
            this.groupBoxAddresConfig.TabStop = false;
            this.groupBoxAddresConfig.Text = "管理收件人";
            this.groupBoxAddresConfig.Visible = false;
            // 
            // dataGridViewInbox
            // 
            this.dataGridViewInbox.AllowUserToAddRows = false;
            this.dataGridViewInbox.AllowUserToDeleteRows = false;
            this.dataGridViewInbox.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewInbox.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.dataGridViewInbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewInbox.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewInbox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInbox.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.IType,
            this.InboxAddress,
            this.InboxNickName,
            this.IState,
            this.ISendCount,
            this.IlastDate,
            this.ICreateDate});
            this.dataGridViewInbox.ContextMenuStrip = this.contextMenuStripListView;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewInbox.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewInbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewInbox.Location = new System.Drawing.Point(3, 46);
            this.dataGridViewInbox.MultiSelect = false;
            this.dataGridViewInbox.Name = "dataGridViewInbox";
            this.dataGridViewInbox.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewInbox.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewInbox.RowTemplate.Height = 23;
            this.dataGridViewInbox.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewInbox.Size = new System.Drawing.Size(465, 50);
            this.dataGridViewInbox.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id";
            this.Column1.HeaderText = "序号";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // IType
            // 
            this.IType.DataPropertyName = "type";
            this.IType.HeaderText = "类型";
            this.IType.Name = "IType";
            this.IType.ReadOnly = true;
            // 
            // InboxAddress
            // 
            this.InboxAddress.DataPropertyName = "address";
            this.InboxAddress.HeaderText = "地址";
            this.InboxAddress.Name = "InboxAddress";
            this.InboxAddress.ReadOnly = true;
            // 
            // InboxNickName
            // 
            this.InboxNickName.DataPropertyName = "nickName";
            this.InboxNickName.HeaderText = "昵称";
            this.InboxNickName.Name = "InboxNickName";
            this.InboxNickName.ReadOnly = true;
            // 
            // IState
            // 
            this.IState.DataPropertyName = "state";
            this.IState.HeaderText = "状态";
            this.IState.Name = "IState";
            this.IState.ReadOnly = true;
            // 
            // ISendCount
            // 
            this.ISendCount.DataPropertyName = "sendCount";
            this.ISendCount.HeaderText = "已发";
            this.ISendCount.Name = "ISendCount";
            this.ISendCount.ReadOnly = true;
            // 
            // IlastDate
            // 
            this.IlastDate.DataPropertyName = "lastDate";
            this.IlastDate.HeaderText = "最后发送";
            this.IlastDate.Name = "IlastDate";
            this.IlastDate.ReadOnly = true;
            // 
            // ICreateDate
            // 
            this.ICreateDate.DataPropertyName = "createDate";
            this.ICreateDate.HeaderText = "创建时间";
            this.ICreateDate.Name = "ICreateDate";
            this.ICreateDate.ReadOnly = true;
            // 
            // toolStrip4
            // 
            this.toolStrip4.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip4.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAddressImport,
            this.tsbAddressExport,
            this.toolStripSeparator2,
            this.tsbAddressDelete});
            this.toolStrip4.Location = new System.Drawing.Point(3, 17);
            this.toolStrip4.Name = "toolStrip4";
            this.toolStrip4.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip4.Size = new System.Drawing.Size(465, 29);
            this.toolStrip4.TabIndex = 0;
            this.toolStrip4.Text = "toolStrip4";
            // 
            // tsbAddressImport
            // 
            this.tsbAddressImport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAddressImport.Image = global::common.Properties.Resources.import;
            this.tsbAddressImport.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbAddressImport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAddressImport.Name = "tsbAddressImport";
            this.tsbAddressImport.Size = new System.Drawing.Size(64, 26);
            this.tsbAddressImport.Text = "导入";
            this.tsbAddressImport.Click += new System.EventHandler(this.tsbAddressImport_Click);
            // 
            // tsbAddressExport
            // 
            this.tsbAddressExport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAddressExport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAddressExportAndAddress,
            this.tsbAddressExportAndNick});
            this.tsbAddressExport.Image = global::common.Properties.Resources.export;
            this.tsbAddressExport.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbAddressExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAddressExport.Name = "tsbAddressExport";
            this.tsbAddressExport.Size = new System.Drawing.Size(73, 26);
            this.tsbAddressExport.Text = "导出";
            // 
            // tsbAddressExportAndAddress
            // 
            this.tsbAddressExportAndAddress.Name = "tsbAddressExportAndAddress";
            this.tsbAddressExportAndAddress.Size = new System.Drawing.Size(136, 22);
            this.tsbAddressExportAndAddress.Text = "仅有地址";
            this.tsbAddressExportAndAddress.Click += new System.EventHandler(this.tsbAddressExport_Click);
            // 
            // tsbAddressExportAndNick
            // 
            this.tsbAddressExportAndNick.Name = "tsbAddressExportAndNick";
            this.tsbAddressExportAndNick.Size = new System.Drawing.Size(136, 22);
            this.tsbAddressExportAndNick.Text = "包含昵称";
            this.tsbAddressExportAndNick.Click += new System.EventHandler(this.tsbAddressExport_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 29);
            // 
            // tsbAddressDelete
            // 
            this.tsbAddressDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAddressDelete.Image = global::common.Properties.Resources.removeAll;
            this.tsbAddressDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbAddressDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAddressDelete.Name = "tsbAddressDelete";
            this.tsbAddressDelete.Size = new System.Drawing.Size(90, 26);
            this.tsbAddressDelete.Text = "删除选中";
            this.tsbAddressDelete.Click += new System.EventHandler(this.tsbAddressDelete_Click);
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.BackColor = System.Drawing.Color.Transparent;
            this.toolStripMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStripMenu.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSendEmail,
            this.tsbEditEmail,
            this.tsbEmailConfig,
            this.tsbAddressConfig,
            this.tsbReg,
            this.tsbBuy,
            this.toolStripBannerAd});
            this.toolStripMenu.Location = new System.Drawing.Point(27, 23);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStripMenu.Size = new System.Drawing.Size(471, 91);
            this.toolStripMenu.TabIndex = 7;
            this.toolStripMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.toolStripMenu_Paint);
            // 
            // tsbSendEmail
            // 
            this.tsbSendEmail.AutoToolTip = false;
            this.tsbSendEmail.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSendEmail.Image = global::common.Properties.Resources.sendOn;
            this.tsbSendEmail.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbSendEmail.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSendEmail.Name = "tsbSendEmail";
            this.tsbSendEmail.Size = new System.Drawing.Size(78, 88);
            this.tsbSendEmail.Text = "发送邮件";
            this.tsbSendEmail.Click += new System.EventHandler(this.showPanel_Click);
            this.tsbSendEmail.MouseLeave += new System.EventHandler(this.tsbMenu_MouseLeave);
            this.tsbSendEmail.MouseHover += new System.EventHandler(this.tsbMenu_MouseHover);
            // 
            // tsbEditEmail
            // 
            this.tsbEditEmail.AutoToolTip = false;
            this.tsbEditEmail.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEditEmail.Image = ((System.Drawing.Image)(resources.GetObject("tsbEditEmail.Image")));
            this.tsbEditEmail.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbEditEmail.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditEmail.Name = "tsbEditEmail";
            this.tsbEditEmail.Size = new System.Drawing.Size(78, 88);
            this.tsbEditEmail.Text = "编辑邮件";
            this.tsbEditEmail.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbEditEmail.Click += new System.EventHandler(this.showPanel_Click);
            this.tsbEditEmail.MouseLeave += new System.EventHandler(this.tsbMenu_MouseLeave);
            this.tsbEditEmail.MouseHover += new System.EventHandler(this.tsbMenu_MouseHover);
            // 
            // tsbEmailConfig
            // 
            this.tsbEmailConfig.AutoToolTip = false;
            this.tsbEmailConfig.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEmailConfig.Image = ((System.Drawing.Image)(resources.GetObject("tsbEmailConfig.Image")));
            this.tsbEmailConfig.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbEmailConfig.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEmailConfig.Name = "tsbEmailConfig";
            this.tsbEmailConfig.Size = new System.Drawing.Size(78, 88);
            this.tsbEmailConfig.Text = "发件配置";
            this.tsbEmailConfig.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbEmailConfig.Click += new System.EventHandler(this.showPanel_Click);
            this.tsbEmailConfig.MouseLeave += new System.EventHandler(this.tsbMenu_MouseLeave);
            this.tsbEmailConfig.MouseHover += new System.EventHandler(this.tsbMenu_MouseHover);
            // 
            // tsbAddressConfig
            // 
            this.tsbAddressConfig.AutoToolTip = false;
            this.tsbAddressConfig.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAddressConfig.Image = ((System.Drawing.Image)(resources.GetObject("tsbAddressConfig.Image")));
            this.tsbAddressConfig.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbAddressConfig.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAddressConfig.Name = "tsbAddressConfig";
            this.tsbAddressConfig.Size = new System.Drawing.Size(78, 88);
            this.tsbAddressConfig.Text = "添加地址";
            this.tsbAddressConfig.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbAddressConfig.Click += new System.EventHandler(this.showPanel_Click);
            this.tsbAddressConfig.MouseLeave += new System.EventHandler(this.tsbMenu_MouseLeave);
            this.tsbAddressConfig.MouseHover += new System.EventHandler(this.tsbMenu_MouseHover);
            // 
            // tsbReg
            // 
            this.tsbReg.AutoToolTip = false;
            this.tsbReg.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbReg.Image = ((System.Drawing.Image)(resources.GetObject("tsbReg.Image")));
            this.tsbReg.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbReg.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbReg.Name = "tsbReg";
            this.tsbReg.Size = new System.Drawing.Size(78, 88);
            this.tsbReg.Text = "注册地址";
            this.tsbReg.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbReg.Click += new System.EventHandler(this.showPanel_Click);
            this.tsbReg.MouseLeave += new System.EventHandler(this.tsbMenu_MouseLeave);
            this.tsbReg.MouseHover += new System.EventHandler(this.tsbMenu_MouseHover);
            // 
            // tsbBuy
            // 
            this.tsbBuy.AutoToolTip = false;
            this.tsbBuy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbBuy.Image = global::common.Properties.Resources.service;
            this.tsbBuy.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbBuy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBuy.Name = "tsbBuy";
            this.tsbBuy.Size = new System.Drawing.Size(78, 88);
            this.tsbBuy.Text = "联系我们";
            this.tsbBuy.Click += new System.EventHandler(this.showPanel_Click);
            this.tsbBuy.MouseLeave += new System.EventHandler(this.tsbMenu_MouseLeave);
            this.tsbBuy.MouseHover += new System.EventHandler(this.tsbMenu_MouseHover);
            // 
            // toolStripBannerAd
            // 
            this.toolStripBannerAd.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripBannerAd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStripBannerAd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBannerAd.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBannerAd.Name = "toolStripBannerAd";
            this.toolStripBannerAd.Size = new System.Drawing.Size(0, 88);
            this.toolStripBannerAd.Text = "请联系投放广告";
            this.toolStripBannerAd.Click += new System.EventHandler(this.toolStripBannerAd_Click);
            // 
            // textBoxIpAddress
            // 
            this.textBoxIpAddress.BackColor = System.Drawing.Color.White;
            this.textBoxIpAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxIpAddress.Location = new System.Drawing.Point(93, 407);
            this.textBoxIpAddress.Name = "textBoxIpAddress";
            this.textBoxIpAddress.ReadOnly = true;
            this.textBoxIpAddress.Size = new System.Drawing.Size(120, 14);
            this.textBoxIpAddress.TabIndex = 35;
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "钱龙邮件群发系统";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseClick);
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.Transparent;
            this.panelLeft.BackgroundImage = global::common.Properties.Resources.panelLeft;
            this.panelLeft.Controls.Add(this.textBoxIpAddress);
            this.panelLeft.Controls.Add(this.comboBoxEmailTitle);
            this.panelLeft.Controls.Add(this.textBoxProxy);
            this.panelLeft.Controls.Add(this.textBoxStartTime);
            this.panelLeft.Controls.Add(this.textBoxState);
            this.panelLeft.Controls.Add(this.comboBoxInboxType);
            this.panelLeft.Controls.Add(this.comboBoxSendType);
            this.panelLeft.Controls.Add(this.textBoxSendCount);
            this.panelLeft.Controls.Add(this.textBoxCycle);
            this.panelLeft.Controls.Add(this.textBoxSendFail);
            this.panelLeft.Controls.Add(this.textBoxForward);
            this.panelLeft.Controls.Add(this.textBoxVariable);
            this.panelLeft.Controls.Add(this.textBoxSendTime);
            this.panelLeft.Controls.Add(this.textBoxThread);
            this.panelLeft.Location = new System.Drawing.Point(10, 126);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(229, 472);
            this.panelLeft.TabIndex = 9;
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.Transparent;
            this.panelRight.BackgroundImage = global::common.Properties.Resources.panelRight;
            this.panelRight.Controls.Add(this.listViewResult);
            this.panelRight.Controls.Add(this.panelSendTool);
            this.panelRight.Location = new System.Drawing.Point(246, 126);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(614, 472);
            this.panelRight.TabIndex = 10;
            // 
            // panelSendTool
            // 
            this.panelSendTool.Controls.Add(this.toolStripSendStart);
            this.panelSendTool.Location = new System.Drawing.Point(6, 8);
            this.panelSendTool.Name = "panelSendTool";
            this.panelSendTool.Size = new System.Drawing.Size(603, 34);
            this.panelSendTool.TabIndex = 2;
            // 
            // picMin
            // 
            this.picMin.BackColor = System.Drawing.Color.Transparent;
            this.picMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picMin.Image = global::common.Properties.Resources.minForm;
            this.picMin.Location = new System.Drawing.Point(816, 4);
            this.picMin.Name = "picMin";
            this.picMin.Size = new System.Drawing.Size(24, 20);
            this.picMin.TabIndex = 11;
            this.picMin.TabStop = false;
            this.picMin.Click += new System.EventHandler(this.picMin_MouseClick);
            this.picMin.MouseLeave += new System.EventHandler(this.picControlMin_MouseLeave);
            this.picMin.MouseHover += new System.EventHandler(this.picControlMin_MouseHover);
            // 
            // picClose
            // 
            this.picClose.BackColor = System.Drawing.Color.Transparent;
            this.picClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picClose.Image = global::common.Properties.Resources.closeForm;
            this.picClose.Location = new System.Drawing.Point(840, 4);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(24, 20);
            this.picClose.TabIndex = 12;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            this.picClose.MouseLeave += new System.EventHandler(this.picControlMin_MouseLeave);
            this.picClose.MouseHover += new System.EventHandler(this.picControlMin_MouseHover);
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblFormTitle.ForeColor = System.Drawing.Color.White;
            this.lblFormTitle.Location = new System.Drawing.Point(25, 4);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(161, 12);
            this.lblFormTitle.TabIndex = 36;
            this.lblFormTitle.Text = "钱龙邮件群发系统 -- 正式版";
            // 
            // panelUsers
            // 
            this.panelUsers.Controls.Add(this.userInfoControl);
            this.panelUsers.Location = new System.Drawing.Point(880, 460);
            this.panelUsers.Name = "panelUsers";
            this.panelUsers.Size = new System.Drawing.Size(365, 139);
            this.panelUsers.TabIndex = 37;
            // 
            // userInfoControl
            // 
            this.userInfoControl.BackColor = System.Drawing.Color.Transparent;
            this.userInfoControl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("userInfoControl.BackgroundImage")));
            this.userInfoControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userInfoControl.Location = new System.Drawing.Point(0, 0);
            this.userInfoControl.Name = "userInfoControl";
            this.userInfoControl.Size = new System.Drawing.Size(365, 139);
            this.userInfoControl.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::common.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(8, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(17, 17);
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.BackColor = System.Drawing.Color.Transparent;
            this.lblVersion.ForeColor = System.Drawing.Color.White;
            this.lblVersion.Location = new System.Drawing.Point(18, 627);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(41, 12);
            this.lblVersion.TabIndex = 39;
            this.lblVersion.Text = "V3.0.0";
            // 
            // lblBottomAd1
            // 
            this.lblBottomAd1.AutoSize = true;
            this.lblBottomAd1.BackColor = System.Drawing.Color.Transparent;
            this.lblBottomAd1.ForeColor = System.Drawing.Color.White;
            this.lblBottomAd1.Location = new System.Drawing.Point(211, 627);
            this.lblBottomAd1.Name = "lblBottomAd1";
            this.lblBottomAd1.Size = new System.Drawing.Size(149, 12);
            this.lblBottomAd1.TabIndex = 41;
            this.lblBottomAd1.Text = "欢迎使用钱龙邮件群发系统";
            // 
            // lblBottomAd2
            // 
            this.lblBottomAd2.AutoSize = true;
            this.lblBottomAd2.BackColor = System.Drawing.Color.Transparent;
            this.lblBottomAd2.ForeColor = System.Drawing.Color.White;
            this.lblBottomAd2.Location = new System.Drawing.Point(443, 627);
            this.lblBottomAd2.Name = "lblBottomAd2";
            this.lblBottomAd2.Size = new System.Drawing.Size(137, 12);
            this.lblBottomAd2.TabIndex = 42;
            this.lblBottomAd2.Text = "网络实效营销第一品牌！";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::common.Properties.Resources.backgroundImage;
            this.ClientSize = new System.Drawing.Size(1257, 650);
            this.Controls.Add(this.lblBottomAd2);
            this.Controls.Add(this.lblBottomAd1);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblFormTitle);
            this.Controls.Add(this.panelUsers);
            this.Controls.Add(this.toolStripMenu);
            this.Controls.Add(this.picClose);
            this.Controls.Add(this.picMin);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.groupBoxAddresConfig);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.groupBoxEditEmail);
            this.Controls.Add(this.groupBoxEmailConfig);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TransparencyKey = System.Drawing.Color.Purple;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.contextMenuStripListView.ResumeLayout(false);
            this.toolStripSendStart.ResumeLayout(false);
            this.toolStripSendStart.PerformLayout();
            this.groupBoxEditEmail.ResumeLayout(false);
            this.groupBoxEditEmail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmailInfo)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.groupBoxEmailConfig.ResumeLayout(false);
            this.groupBoxEmailConfig.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFrom)).EndInit();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.groupBoxAddresConfig.ResumeLayout(false);
            this.groupBoxAddresConfig.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInbox)).EndInit();
            this.toolStrip4.ResumeLayout(false);
            this.toolStrip4.PerformLayout();
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.panelRight.ResumeLayout(false);
            this.panelSendTool.ResumeLayout(false);
            this.panelSendTool.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            this.panelUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sunisoft.IrisSkin.SkinEngine skinEngine;
        private System.Windows.Forms.ToolStrip toolStripSendStart;
        private System.Windows.Forms.ToolStripButton toolStripButtonSendConfig;
        private System.Windows.Forms.ToolStripButton tsbStartSend;
        private System.Windows.Forms.ListView listViewResult;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox textBoxState;
        private System.Windows.Forms.ComboBox comboBoxEmailTitle;
        private System.Windows.Forms.TextBox textBoxStartTime;
        private System.Windows.Forms.TextBox textBoxSendCount;
        private System.Windows.Forms.TextBox textBoxSendFail;
        private System.Windows.Forms.TextBox textBoxVariable;
        private System.Windows.Forms.TextBox textBoxThread;
        private System.Windows.Forms.TextBox textBoxSendTime;
        private System.Windows.Forms.TextBox textBoxForward;
        private System.Windows.Forms.TextBox textBoxCycle;
        private System.Windows.Forms.ComboBox comboBoxSendType;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ToolStripButton toolStripButtonTest;
        private System.Windows.Forms.GroupBox groupBoxEditEmail;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton tsbEditEmailAdd;
        private System.Windows.Forms.ToolStripButton tsbEditEmailEdit;
        private System.Windows.Forms.ToolStripButton tsbEditEmailDelete;
        private System.Windows.Forms.GroupBox groupBoxEmailConfig;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripButton tsbEmailConfigImport;
        private System.Windows.Forms.ToolStripButton tsbEmailConfigExport;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbEmailConfigDelete;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.GroupBox groupBoxAddresConfig;
        private System.Windows.Forms.ToolStrip toolStrip4;
        private System.Windows.Forms.ToolStripButton tsbAddressImport;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbAddressDelete;
        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripButton tsbEditEmail;
        private System.Windows.Forms.ToolStripButton tsbEmailConfig;
        private System.Windows.Forms.ToolStripButton tsbAddressConfig;
        private System.Windows.Forms.ToolStripButton tsbReg;
        private System.Windows.Forms.ToolStripButton tsbSendEmail;
        private System.Windows.Forms.ToolStripButton tsbBuy;
        private System.Windows.Forms.ToolStripButton tsbEmailConfigAdd;
        private System.Windows.Forms.DataGridView dataGridViewEmailInfo;
        private System.Windows.Forms.DataGridView dataGridViewInbox;
        private System.Windows.Forms.DataGridView dataGridViewFrom;
        private System.Windows.Forms.ComboBox comboBoxInboxType;
        private System.Windows.Forms.TextBox textBoxProxy;
        private System.Windows.Forms.ToolStripDropDownButton tsbAddressExport;
        private System.Windows.Forms.ToolStripMenuItem tsbAddressExportAndNick;
        private System.Windows.Forms.ToolStripMenuItem tsbAddressExportAndAddress;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripListView;
        private System.Windows.Forms.ToolStripMenuItem ToolStripListViewClear;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn content;
        private System.Windows.Forms.DataGridViewTextBoxColumn sendCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn createDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IType;
        private System.Windows.Forms.DataGridViewTextBoxColumn InboxAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn InboxNickName;
        private System.Windows.Forms.DataGridViewTextBoxColumn IState;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISendCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn IlastDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ICreateDate;
        private System.Windows.Forms.ToolStripButton toolStripButtonStartService;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn FromType;
        private System.Windows.Forms.DataGridViewTextBoxColumn FromAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn FromPwd;
        private System.Windows.Forms.DataGridViewTextBoxColumn FromAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn FState;
        private System.Windows.Forms.DataGridViewTextBoxColumn FromDomainName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FromSmtp;
        private System.Windows.Forms.DataGridViewTextBoxColumn FromSmtpPort;
        private System.Windows.Forms.DataGridViewTextBoxColumn FromSsl;
        private System.Windows.Forms.DataGridViewTextBoxColumn FrSendCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn FrLastDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn FrCreateDate;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemDelFrom;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemDelInbox;
        private System.Windows.Forms.ToolStripLabel toolStripBannerAd;
        private System.Windows.Forms.ToolStripButton tsbStopSendBtn;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemDelByFailed;
        private System.Windows.Forms.TextBox textBoxIpAddress;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemDelByAccess;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Panel panelSendTool;
        private System.Windows.Forms.PictureBox picMin;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.Panel panelUsers;
        private UserInfoFrm userInfoControl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblBottomAd1;
        private System.Windows.Forms.Label lblBottomAd2;

    }
}