using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Collections.Specialized;
using System.Collections;
using System.Configuration;
using common.editEmail;
using common.emailConfig;
using common.sendConfig;
using dao.common;
using dao.user;
using dao.modle;
using dao.core;
using dao;
using System.Net;


namespace common
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.DoubleBuffered = true; 
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true); // 禁止擦除背景.
            SetStyle(ControlStyles.DoubleBuffer, true); // 双缓冲 
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer |
                    ControlStyles.ResizeRedraw |
                    ControlStyles.AllPaintingInWmPaint, true);

            ////skinEngine.SkinFile = @"skin\MacOSSkin.dll";
            //ProfessionalColorTable colorTable = new ProfessionalColorTable();
            //colorTable.UseSystemColors = true;
            //toolStripMenu.Renderer = new ToolStripProfessionalRenderer(colorTable);
            //toolStripMenu.Renderer = new Toolstrip();
            //this.tsbBuy.Image = new Bitmap(@"skin/registOn.png");
            //this.tsbSendEmail.Image = global::common.Properties.Resources.service; 
        }

        #region 全局变量
        private Point m_MousePoint;
        #endregion

        public LoginFrm loginFrm;
        SendConfigDao sendConfigDao = new SendConfigDao();
        AddConfigDao addConfigDao = new AddConfigDao();
        EmailInfoDao emailInfoDao = new EmailInfoDao();
        InboxDao inboxDao = new InboxDao();
        object sendType;
        object inboxType;
        object replay;
        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Size = new Size(870, 650);
            //panelBg.Location = new Point(0,0);
            //panelBg.Width = this.Width + 14;
            //panelBg.Height = this.Height + 14;
            //初始化数据
            loadSendConfig();
            //设置广告
            this.toolStripBannerAd.Image = Image.FromFile("skin/banner_343X84.png");
        }
        public void loadSendConfig()
        {
            this.panelLeft.Visible = false;
            this.panelRight.Visible = false;
            this.comboBoxSendType.DataSource = sendConfigDao.loadFromType().Tables["fromType"];
            this.comboBoxSendType.DisplayMember = "type";
            this.comboBoxSendType.ValueMember = "type";

            this.comboBoxInboxType.DataSource = sendConfigDao.loadInboxType().Tables["inboxType"];
            this.comboBoxInboxType.DisplayMember = "type";
            this.comboBoxInboxType.ValueMember = "type";

            Config config = sendConfigDao.loadConfig();
            sendType = config.SendType;
            inboxType = config.InboxType;
            replay = config.Replay;

            this.comboBoxSendType.Text = config.SendType.ToString();
            this.comboBoxInboxType.Text = config.InboxType.ToString();

            this.textBoxState.Text = "未发送";
            this.comboBoxEmailTitle.Text = "未配置";
            this.comboBoxEmailTitle.DataSource = emailInfoDao.loadEmailInfo().Tables["info"];
            this.comboBoxEmailTitle.DisplayMember = "title";
            this.comboBoxEmailTitle.ValueMember = "id";

            this.textBoxStartTime.Text = config.StartTime.ToString();
            this.textBoxProxy.Text = config.Proxy.ToString();
            this.textBoxCycle.Text = config.SendCycle.ToString() + "天";
            this.textBoxForward.Text = config.Forward.ToString();

            this.textBoxSendTime.Text = ((DateTime)config.StartTime).Hour + "点 - " + ((DateTime)config.EndTime).Hour + "点";
            this.textBoxThread.Text = config.SendThreadNum.ToString() + "个";
            this.textBoxVariable.Text = "启用";
            this.textBoxSendFail.Text = Constant.sendFail+ "封";
            this.textBoxSendCount.Text = Constant.sendTotal+"封";
            this.textBoxIpAddress.Text = Constant.getIpAddress();

            this.lblVersion.Text = "当前版本号：" + MailAssembly.AssemblyVersion;

            this.panelLeft.Visible = true;
            this.panelRight.Visible = true;
        }

        private void showPanel_Click(object sender, EventArgs e)
        {
            panelShow(((ToolStripButton)sender).Name);
        }

        private void panelShow(String showName)
        {
            if (showName.Equals("tsbSendEmail"))
            {
                this.groupBoxEditEmail.Visible = false;
                this.groupBoxEmailConfig.Visible = false;
                this.groupBoxAddresConfig.Visible = false;
                this.panelUsers.Visible = false;

                //this.panelLeft.Location = new System.Drawing.Point(3, 126);
                //this.panelLeft.Size = new System.Drawing.Size(857, 481);

                //设置快捷菜单
                this.ToolStripListViewClear.Enabled = true;
                this.ToolStripMenuItemDelFrom.Enabled = false;
                this.ToolStripMenuItemDelInbox.Enabled = false;

                //加载开始发件数据
                loadSendConfig();
            }
            else if (showName.Equals("tsbEditEmail"))
            {
                this.panelLeft.Visible = false;
                this.panelRight.Visible = false;
                this.groupBoxEmailConfig.Visible = false;
                this.groupBoxAddresConfig.Visible = false;
                this.panelUsers.Visible = false;

                this.groupBoxEditEmail.Visible = true;
                this.groupBoxEditEmail.Location = new System.Drawing.Point(7, 126);
                this.groupBoxEditEmail.Size = new System.Drawing.Size(857, 481);

                //加载邮件信息数据
                loadEmailInfo();
            }
            else if (showName.Equals("tsbEmailConfig"))
            {
                this.panelLeft.Visible = false;
                this.panelRight.Visible = false;
                this.groupBoxEditEmail.Visible = false;
                this.groupBoxAddresConfig.Visible = false;
                this.panelUsers.Visible = false;

                this.groupBoxEmailConfig.Visible = true;
                this.groupBoxEmailConfig.Location = new System.Drawing.Point(7, 126);
                this.groupBoxEmailConfig.Size = new System.Drawing.Size(857, 481);

                //设置快捷菜单
                this.ToolStripListViewClear.Enabled = false;
                this.ToolStripMenuItemDelFrom.Enabled = true;
                this.ToolStripMenuItemDelInbox.Enabled = false;

                //加载发件人数据
                loadFrom();
            }
            else if (showName.Equals("tsbAddressConfig"))
            {
                this.panelLeft.Visible = false;
                this.panelRight.Visible = false;
                this.groupBoxEditEmail.Visible = false;
                this.groupBoxEmailConfig.Visible = false;
                this.panelUsers.Visible = false;

                this.groupBoxAddresConfig.Visible = true;
                this.groupBoxAddresConfig.Location = new System.Drawing.Point(7, 126);
                this.groupBoxAddresConfig.Size = new System.Drawing.Size(857, 481);

                //设置快捷菜单
                this.ToolStripListViewClear.Enabled = false;
                this.ToolStripMenuItemDelFrom.Enabled = false;
                this.ToolStripMenuItemDelInbox.Enabled = true;
                //加载收件人数据
                loadInbox();
            }
            else if (showName.Equals("tsbReg"))
            {
                this.panelLeft.Visible = false;
                this.panelRight.Visible = false;
                this.groupBoxEditEmail.Visible = false;
                this.groupBoxEmailConfig.Visible = false;
                this.groupBoxAddresConfig.Visible = false;

                this.panelUsers.Visible = true;
                this.panelUsers.Location = new System.Drawing.Point(7, 126);
                this.panelUsers.Size = new System.Drawing.Size(857, 481);
                
            }
            else if (showName.Equals("tsbBuy"))
            {
                this.panelLeft.Visible = false;
                this.panelRight.Visible = false;
                this.groupBoxEditEmail.Visible = false;
                this.groupBoxEmailConfig.Visible = false;
                this.groupBoxAddresConfig.Visible = false;
                this.panelUsers.Visible = false;
                //设置登陆交互网页地址
                IDictionary contactUs = (IDictionary)ConfigurationSettings.GetConfig("contactUs");
                System.Diagnostics.Process.Start((string)contactUs["url"]);
            }
            else
            {

            }
        }
        //邮件列表
        public void loadEmailInfo()
        {
            dataGridViewEmailInfo.DataSource = emailInfoDao.loadEmailInfo().Tables["info"];
        }

        //发件人列表
        public void loadFrom()
        {
            dataGridViewFrom.DataSource = addConfigDao.loadFrom().Tables["efrom"];
        }

        //收件人列表
        public void loadInbox()
        {
            dataGridViewInbox.DataSource = inboxDao.loadInbox().Tables["inbox"];
        }

        //新建邮件
        private void tsbEditEmailAdd_Click(object sender, EventArgs e)
        {
            EditFrm editForm = new EditFrm();
            editForm.mainForm = this;
            editForm.ShowDialog();
        }

        //修改邮件
        private void tsbEditEmailUpdate_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewEmailInfo.RowCount > 0)
            {
                int emailInfoId = int.Parse(this.dataGridViewEmailInfo.CurrentRow.Cells[0].Value.ToString());
                EditFrm editForm = new EditFrm();
                editForm.mainForm = this;
                editForm.id = emailInfoId;
                editForm.ShowDialog();
            }
        }

        //删除邮件
        private void tsbEditEmailDelete_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewEmailInfo.RowCount > 0)
            {
                int emailInfoId = int.Parse(this.dataGridViewEmailInfo.CurrentRow.Cells[0].Value.ToString());
                emailInfoDao.deleteEmailInfoById(emailInfoId);
                loadEmailInfo();
            }
        }


        //添加发件人
        private void tsbEmailConfigAdd_Click(object sender, EventArgs e)
        {
            AddConfigFrm addConfig = new AddConfigFrm();
            addConfig.mainForm = this;
            addConfig.ShowDialog();
        }
        //导入发件人
        private void tsbEmailConfigImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog importFile = new OpenFileDialog();
            importFile.Filter = "txt文件|*.txt";
            if (importFile.ShowDialog() == DialogResult.OK)
            {
                //导入发件人配置信息
                FileStream importfs = new FileStream(importFile.FileName, FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(importfs);
                String importLine = "";
                ChkUtil chkUtil = new ChkUtil();
                while ((importLine = reader.ReadLine()) != null)
                {
                    if ("".Equals(importLine))
                    {
                        continue;
                    }
                    String[] importArray = importLine.Split(':');
                    for (int i = 0; i < importArray.Length; i++)
                    {
                        importArray[i] = importArray[i].Trim();
                    }
                    if (importArray.Length == 6 && chkUtil.validateEmail(importArray[2]))
                    {
                        addConfigDao.saveCreate("线上服务器",importArray[2], importArray[0], importArray[1], 0, "", importArray[3], importArray[4], importArray[5], "正常");
                    }
                    else if (importArray.Length == 7 && chkUtil.validateEmail(importArray[2]))
                    {
                        addConfigDao.saveCreate("本地服务器",importArray[2], importArray[0], importArray[1], 0, importArray[5], importArray[3], importArray[4], importArray[5], "正常");
                    }
                }
                importfs.Close();
                loadFrom();
            }
        }
        //导出发件人
        private void tsbEmailConfigExport_Click(object sender, EventArgs e)
        {
            ////保存为Txt文件
            SaveFileDialog exportFile = new SaveFileDialog();
            exportFile.Filter = "txt文件|*.txt";
            if (DialogResult.OK == exportFile.ShowDialog())
            {
                FileStream fs = new FileStream(exportFile.FileName, FileMode.Create, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                String writeLine = "";
                for (int i = 0; i < this.dataGridViewFrom.RowCount; i++)
                {
                    writeLine = this.dataGridViewFrom.Rows[i].Cells["FromAccount"].Value.ToString().Trim() + ":";
                    writeLine += this.dataGridViewFrom.Rows[i].Cells["FromPwd"].Value.ToString().Trim() + ":";
                    writeLine += this.dataGridViewFrom.Rows[i].Cells["FromAddress"].Value.ToString().Trim() + ":";
                    writeLine += this.dataGridViewFrom.Rows[i].Cells["FromSmtp"].Value.ToString().Trim() + ":";
                    writeLine += this.dataGridViewFrom.Rows[i].Cells["FromSmtpPort"].Value.ToString().Trim() + ":";
                    writeLine += this.dataGridViewFrom.Rows[i].Cells["FromSsl"].Value.ToString().Trim();
                    String domainNameStr = this.dataGridViewFrom.Rows[i].Cells["FromDomainName"].Value.ToString().Trim();
                    if (!domainNameStr.Equals(""))
                    {
                        writeLine += ":" + domainNameStr;
                    }
                    sw.WriteLine(writeLine);
                }
                sw.Flush();
                fs.Close();
                MessageBox.Show("已经成功保存到记事本中！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        //删除发件人
        private void tsbEmailConfigDelete_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewFrom.RowCount > 0)
            {
                int emailFromId = int.Parse(this.dataGridViewFrom.CurrentRow.Cells[0].Value.ToString());
                addConfigDao.deleteFromById(emailFromId);
                loadFrom();
            }
        }

        //删除收件人
        private void tsbAddressDelete_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewInbox.RowCount > 0)
            {
                int inboxId = int.Parse(this.dataGridViewInbox.CurrentRow.Cells[0].Value.ToString());
                inboxDao.deleteInboxById(inboxId);
                loadInbox();
            }
        }

        //邮件配置
        private void toolStripButtonSendConfig_Click(object sender, EventArgs e)
        {
            SendConfigFrm sendConfigFrm = new SendConfigFrm();
            sendConfigFrm.mainForm = this;
            sendConfigFrm.ShowDialog();
        }
        //发送测试邮件
        private void toolStripButtonTest_Click(object sender, EventArgs e)
        {
            SendTestFrm sendTestFrm = new SendTestFrm();
            sendTestFrm.ShowDialog();
        }

        /// <summary>
        /// 导入收件人地址
        /// </summary>
        public OpenFileDialog importFile;
        public delegate void importDelegate();
        private void tsbAddressImport_Click(object sender, EventArgs e)
        {
            importFile = new OpenFileDialog();
            importFile.Filter = "txt文件|*.txt";
            if (importFile.ShowDialog() == DialogResult.OK)
            {
                Thread importThread = new Thread(new ThreadStart(AddressImportThreadMethod));
                importThread.IsBackground = true;
                importThread.Start();
            }
        }
        //导入的线程
        private void AddressImportThreadMethod()
        {
            ChkUtil chkUtil = new ChkUtil();
            String path = importFile.FileName;
            String type = "群发地址";
            String address = "";
            String nickName = "";
            String state = "正常";

            //导入邮件地址
            FileStream importfs = new FileStream(path, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(importfs);
            String importLine = "";
            while ((importLine = reader.ReadLine()) != null)
            {
                if ("".Equals(importLine))
                {
                    continue;
                }
                if (importLine.IndexOf(":") != -1)
                {
                    //包含昵称
                    if (chkUtil.validateEmail(importLine))
                    {
                        address = importLine.Substring(0, importLine.IndexOf(":"));
                        nickName = importLine.Substring(importLine.IndexOf(":") + 1);
                        if ("".Equals(nickName))
                        {
                            nickName = importLine.Substring(0, importLine.IndexOf("@"));
                        }
                        inboxDao.saveInbox(type, address, nickName, state);
                    }
                }
                else
                {
                    //不包含昵称
                    if (chkUtil.validateEmail(importLine))
                    {
                        address = importLine;
                        nickName = importLine.Substring(0, importLine.IndexOf("@"));
                        inboxDao.saveInbox(type, address, nickName, state);
                    }
                }
                System.Threading.Thread.Sleep(110);//线程休眠200 
                dataGridViewInbox.BeginInvoke(new importDelegate(loadInbox));
            }
            MessageBox.Show("恭喜您，收件人导入完成！", "温馨提示");
            importfs.Close();

        }
        /// <summary>
        /// 导出收件人
        /// </summary>
        public String exportType;
        public SaveFileDialog exportFile;
        public delegate void exportDelegate();
        private void tsbAddressExport_Click(object sender, EventArgs e)
        {
            exportType = ((ToolStripMenuItem)sender).Name;

            ////保存为Txt文件
            exportFile = new SaveFileDialog();
            exportFile.Filter = "txt文件|*.txt";
            if (DialogResult.OK == exportFile.ShowDialog())
            {
                Thread exportThread = new Thread(new ThreadStart(AddressExportThreadMethod));
                exportThread.IsBackground = true;
                exportThread.Start();
                MessageBox.Show("已经成功保存到记事本中！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        //导出线程
        private void AddressExportThreadMethod()
        {
            FileStream fs = new FileStream(exportFile.FileName, FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            for (int i = 0; i < this.dataGridViewInbox.RowCount; i++)
            {
                if (exportType.Equals("tsbAddressExportAndAddress"))
                {
                    sw.WriteLine(this.dataGridViewInbox.Rows[i].Cells[2].Value.ToString().Trim());
                }
                else if (exportType.Equals("tsbAddressExportAndNick"))
                {
                    sw.WriteLine(this.dataGridViewInbox.Rows[i].Cells[2].Value.ToString().Trim() + ":" + this.dataGridViewInbox.Rows[i].Cells[3].Value.ToString().Trim());
                }
            }
            sw.Flush();
            fs.Close();
        }

        /// <summary>
        /// 清空listView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolStripListViewClear_Click(object sender, EventArgs e)
        {
            this.listViewResult.Items.Clear();
        }
        /// <summary>
        /// 清空发件人
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolStripMenuItemDelFrom_Click(object sender, EventArgs e)
        {
            addConfigDao.deleteAllFrom();
            loadFrom();
        }
        /// <summary>
        /// 清空收件人
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolStripMenuItemDelInbox_Click(object sender, EventArgs e)
        {
            inboxDao.deleteAllInbox();
            loadInbox();
        }

        private void ToolStripMenuItemDelByFailed_Click(object sender, EventArgs e)
        {
            //删除发送失败的收件人
            inboxDao.deleteInboxByFailed();
            MessageBox.Show("发送失败的收件箱已经删除！", "提示");
        }
        private void ToolStripMenuItemDelByAccess_Click(object sender, EventArgs e)
        {
            //删除发送成功的收件人
            inboxDao.deleteInboxByAccess();
            MessageBox.Show("发送成功的收件箱已经删除！", "提示");
        }

        #region 第一版发送邮件参数
        /*
        //发送邮件参数
        DataTable fromSend;
        DataTable inboxSend;
        Dictionary<String, Object> emailInfo;
        int threadCount;
        int fromCount;
        int inboxCount;


        string from = "";
        string account = "";
        string password = "";
        string fromState = "";
        int fromSendCount = 0;
        DateTime fromLastDate;
        string domainName;
        string smtp = "";
        string smtpPort = "";
        string ssl = "";

        string address = "";
        string nickNameSend = "";
        string inboxState = "";
        int inboxSendCount = 0;
        DateTime inboxLastDate;

        object title = "";
        object body = "";
        object infoSendCount = 0;

        Thread sendStartThread;
         */
        #endregion

        #region  第一版开始发送按钮
        /*
        private void tsbStartSend_Click(object sender, EventArgs e)
        {
            if (isChangeSendStartImg())
            {
                //发送邮件
                emailInfo = emailInfoDao.loadEmailInfoById(int.Parse(this.comboBoxEmailTitle.SelectedValue.ToString()));
                emailInfo.TryGetValue("title", out title);
                emailInfo.TryGetValue("content", out body);
                emailInfo.TryGetValue("infoSendCount", out infoSendCount);

                //加载发件人
                fromSend = addConfigDao.loadFromSend(sendType.ToString()).Tables["efrom"];
                inboxSend = inboxDao.loadInboxSend(inboxType.ToString()).Tables["inbox"];

                threadCount = int.Parse(thread.ToString());
                inboxCount = inboxSend.Rows.Count;
                fromCount = fromSend.Rows.Count;

                MainFormChk mainFormChk = new MainFormChk();
                string isStartSendChk = mainFormChk.startSendChk(threadCount, inboxCount, fromCount);
                if ("".Equals(isStartSendChk))
                {
                    sendStartThread = new Thread(new ThreadStart(sendStartThreadMethod));
                    sendStartThread.IsBackground = true;
                    sendStartThread.Start();
                }
                else
                {
                    MessageBox.Show(isStartSendChk, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
         
        } * */
        #endregion

        #region  第一版发送规则
        /*
        int fromMaxCount = 0;
        bool sendOver=false;
        public delegate void delegateSendStartImage();
        public void sendStartThreadMethod()
        {
          
            for (int i = 0; i < inboxSend.Rows.Count; i++)
            {
                for (int j = 0; j < threadCount; j++)
                {
                    
                    //新线程
                    Thread sendThread = new Thread(new ThreadStart(sendThreadMethod));
                    sendThread.IsBackground = true;
                    sendThread.Start();
                    Thread.Sleep(1100);

                    lock (this)
                    {
                        if (inboxCount > 1)
                        {
                            inboxCount--;
                        }
                        else
                        {
                            sendOver = true;
                            this.toolStripSendStart.BeginInvoke(new delegateSendStartImage(changeSendStartImg));
                            break;
                        }

                        if (fromMaxCount >= (int)(inboxSend.Rows.Count / fromSend.Rows.Count))
                        {
                            fromMaxCount = 0;
                            if (fromCount > 1)
                            {
                                fromCount--;
                            }
                        }
                        fromMaxCount++;
                    }
 
                }
                if (sendOver)
                {
                    break;
                }
            }

        }

        public void changeSendStartImg() {
            isChangeSendStartImg();
        }
        string sendStartButton = "start";
        public bool isChangeSendStartImg() {
            bool result = false;
            if (sendOver)
            {
                this.textBoxState.Text = "未发送";
                this.tsbStartSend.Image = Properties.Resources.startSend;
                sendStartButton = "start";
                sendStartThread.Abort();
                sendOver = false;
            }
            else {
                if (sendStartButton.Equals("start"))
                {
                    this.textBoxState.Text = "正在发送中...";
                    this.tsbStartSend.Image = Properties.Resources.pause;
                    sendStartButton = "pause";
                    result = true;
                }else if (sendStartButton.Equals("pause"))
                {
                    this.textBoxState.Text = "已暂停";
                    this.tsbStartSend.Image = Properties.Resources._continue;
                    sendStartButton = "_continue";
                    if (sendStartThread.IsAlive)
                    {
                        sendStartThread.Suspend();
                    }
                }else if (sendStartButton.Equals("_continue"))
                {
                    this.textBoxState.Text = "正在发送中...";
                    this.tsbStartSend.Image = Properties.Resources.pause;
                    sendStartButton = "pause";
                    sendStartThread.Resume();
                }
            }
            return result;
        }

        int sendFailed = 0;
        string fromId;
        string inboxId;
        string sendMsg;
        DateTime startSendTime;
        DateTime endSendTime;
        public delegate void delegateResult();
        public void sendThreadMethod()
        {
            startSendTime = DateTime.Now;
            //发件人信息
            fromId = fromSend.Rows[fromCount - 1]["id"].ToString();
            from = fromSend.Rows[fromCount - 1]["fromAddress"].ToString();
            account = fromSend.Rows[fromCount - 1]["account"].ToString();
            password = fromSend.Rows[fromCount - 1]["pwd"].ToString();
            fromState = fromSend.Rows[fromCount - 1]["state"].ToString();
            fromSendCount = int.Parse(fromSend.Rows[fromCount - 1]["sendCount"].ToString());
            fromLastDate = DateTime.Parse(fromSend.Rows[fromCount - 1]["lastDate"].ToString());
            domainName = fromSend.Rows[fromCount - 1]["domainName"].ToString();
            smtp = fromSend.Rows[fromCount - 1]["smtp"].ToString();
            smtpPort = fromSend.Rows[fromCount - 1]["smtpPort"].ToString();
            ssl = fromSend.Rows[fromCount - 1]["ssl"].ToString();

            //收件人信息
            inboxId = inboxSend.Rows[inboxCount - 1]["id"].ToString();
            address = inboxSend.Rows[inboxCount - 1]["address"].ToString();
            nickNameSend = inboxSend.Rows[inboxCount - 1]["nickName"].ToString();
            inboxState = inboxSend.Rows[inboxCount - 1]["state"].ToString();
            inboxSendCount = int.Parse(inboxSend.Rows[inboxCount - 1]["sendCount"].ToString());
            inboxLastDate = DateTime.Parse(inboxSend.Rows[inboxCount - 1]["lastDate"].ToString());

            IDictionary IDPermissions = (IDictionary)ConfigurationSettings.GetConfig("product");
            String isVipBody = body.ToString();
            if(!InfoHelper.isVip){
                isVipBody += "本邮件由‘<a href='" + (string)IDPermissions["url"] + "'>钱龙邮件群发软件</a>’发送。但不涉及内容的选择，由内容产生的问题概不负责！<br/>"+
                    "<a href='" + (string)IDPermissions["url"] + "'><img src='" + (string)IDPermissions["img"] + "'/></a>";
            }

            SendMail sendMail = new SendMail(from, account, password, smtp, address, isVipBody, title.ToString(), replay.ToString());
            sendMsg = sendMail.Send();

            Thread.Sleep(1000);
            endSendTime = DateTime.Now;
            listViewResult.BeginInvoke(new delegateResult(listViewResultShow));
        }

         
        /// <summary>
        /// 发送完成后处理数据
        /// </summary>
        private void listViewResultShow()
        {
            ListViewItem listViewItem = new ListViewItem(inboxCount.ToString());
            listViewItem.Tag = 0;
            int sendMilliseconds = (endSendTime - startSendTime).Milliseconds;
            if (sendMilliseconds <= 0) { sendMilliseconds = 1; }
            listViewItem.SubItems.AddRange(new string[] { fromId, from, address, sendMilliseconds+"ms", sendMsg });
            listViewResult.Items.Add(listViewItem);
            listViewResult.Items[listViewResult.Items.Count - 1].EnsureVisible(); 
            listViewResult.Items[listViewResult.Items.Count-1].Selected = true;

            if (sendMsg.Equals("发送成功"))
            {
                addConfigDao.updateFromSend(int.Parse(fromId), 1);
                inboxDao.updateInboxSend(int.Parse(inboxId), 1);
                emailInfoDao.updateEmailInfoSend(int.Parse(this.comboBoxEmailTitle.SelectedValue.ToString()), 1);

                this.textBoxSendCount.Text = (Constant.sendTotal += 1) + "封";
            }
            else {
                this.textBoxSendFail.Text = (Constant.sendFail += 1) + "封";
            }
        } */
      
        #endregion

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            InfoHelper.uploadSendNum();
            InfoHelper.islogin = false;
            Application.Exit();
        }

        private void toolStripButtonStartService_Click(object sender, EventArgs e)
        {
            System.Threading.Thread sendServiceThread = new System.Threading.Thread(new System.Threading.ThreadStart(dao.core.SendService.start));
            sendServiceThread.IsBackground = true;
            sendServiceThread.Start();
            MessageBox.Show("服务已经启动", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void toolStripBannerAd_Click(object sender, EventArgs e)
        {
            IDictionary IDPermissions = (IDictionary)ConfigurationSettings.GetConfig("mainBannerAd");
            System.Diagnostics.Process.Start((string)IDPermissions["url"]);
        }

        /// <summary>
        /// 第二套发送线程解决方案
        /// </summary>
        #region 第二版发送邮件参数
        // 第二套 系统发送解决方案 变量
        /// <summary>
        /// //从inbox中计算 收件人总数
        /// </summary>
        public static int sendNum = 10;
        /// <summary>
        /// 从数据库计算 发件人总数
        /// </summary>
        public static int fromNum = 5;

        //系统变量
        /// <summary>
        /// //总共发了多少封邮件
        /// </summary>
        public static int sendTotalCount = 0;  
        /// <summary>
        /// 用来统计单个邮箱已发送的邮件数量，超过fromSendNum 之后重置为零
        /// </summary>
        public static int fromSendCount = 0;
        /// <summary>
        /// //发件人的索引
        /// </summary>
        public static int fromIndex = 0;  
        /// <summary>
        ///  //收件人的索引
        /// </summary>
        public static int inboxIndex = 0;
        /// <summary>
        /// 发送停止
        /// </summary>
        public static bool sendStop = false;
        /// <summary>
        /// 发送失败N封后更换发件人的标识
        /// </summary>
        public static int failedCount = 0;
        /// <summary>
        /// 发送失败总数
        /// </summary>
        public static int failedTotalCount = 0;
        /// <summary>
        /// 线程状态控制按钮，分为三个状态：运行中(running) 暂停(pause)  完成(over)
        /// </summary>
        public static String threadState = "over";
        /// <summary>
        /// 完成结束控制按钮
        /// </summary>
        public delegate void delegateOver();


        //用户设置变量
        /// <summary>
        /// 用户自定义的单次发送数量 默认为1
        /// </summary>
        public static int diySendNum = 1;
        /// <summary>
        /// 用户定义的每个邮箱最多可以发送的邮件数量，如果为0采用平均分配
        /// </summary>
        public static int fromSendNum = 500;
        /// <summary>
        /// 如果设置了fromSendNum，而需要发送的邮件大于（fromSendNum×fromNum）标识是否继续循环发送（fromSendNumContinue=true）
        /// </summary>
        public static Boolean fromSendNumContinue = true;
        /// <summary>
        /// 用户自定义的发送线程数量，如果为0 则创建inbox个线程
        /// </summary>
        public static int sendThreadNum = 9;
        /// <summary>
        /// 用户自定义的线程睡眠时间 单次发送后睡眠的毫秒数，默认1000
        /// </summary>
        public static int threadMillisecond = 1000;
        /// <summary>
        /// 用户自定义 连续发送失败5封后 就更换发件人
        /// </summary>
        public static int failedNum =5;


        /// <summary>
        /// //发送主线程
        /// </summary>
        Thread sendStartThread;
        /// <summary>
        /// 发送子线程，属于主线程下
        /// </summary>
        Thread[] sendThread;
        /// <summary>
        /// 发送线程的状态提示
        /// </summary>
        String[] sendThreadTip;
        #endregion

        /// <summary>
        /// 发送邮件准备数据
        /// </summary>
        #region

        DataTable fromSend;
        DataTable inboxSend;
        Dictionary<String, Object> emailInfo;

        Email mainEmail = new Email();
        #endregion

        #region 第二版 开始发送按钮
        /// <summary>
        /// 开始发送按钮 （第二套发送法案）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbStartSend_Click(object sender, EventArgs e)
        {
            threadState = ((ToolStripButton)sender).Tag.ToString();
            if (sendThread != null)
            {
                chkSendThreadState(sender);
                return;
            }
            this.tsbStopSendBtn.Enabled = true;
            this.tsbStartSend.Image = Properties.Resources.pause;
            this.textBoxState.Text = "正在发送....";
            //准备数据
            object title;
            object body;
            object infoSendCount;
            //发件信息
            emailInfo = emailInfoDao.loadEmailInfoById(int.Parse(this.comboBoxEmailTitle.SelectedValue.ToString()));
            emailInfo.TryGetValue("title", out title);
            emailInfo.TryGetValue("content", out body);
            emailInfo.TryGetValue("infoSendCount", out infoSendCount);
            mainEmail.Title = title;
            mainEmail.Body = body;
            mainEmail.InfoSendCount = infoSendCount;

            //加载发件人
            fromSend = addConfigDao.loadFromSend(sendType.ToString()).Tables["efrom"];
            //加载收件人
            inboxSend = inboxDao.loadInboxSend(inboxType.ToString()).Tables["inbox"];

            fromNum = fromSend.Rows.Count;//发件人总数
            sendNum = inboxSend.Rows.Count;//收件人总数
            if(fromNum<=0||sendNum<=0){
                MessageBox.Show("发送前，请先添加发件人和收件人，并确认邮件配置信息～！","提示");
                return;
            }

            //发送配置
            Config config = sendConfigDao.loadConfig();
            diySendNum = config.DiySendNum;
            fromSendNum = config.FromSendNum;
            fromSendNumContinue = config.FromSendNumContinue;
            sendThreadNum = config.SendThreadNum;
            threadMillisecond = config.ThreadMillisecond;
            failedNum = config.FailedNum;

            //发件人昵称
            mainEmail.FromNickName = config.NickName;

            //开始发送  创建主线程
            sendStartThread = new Thread(new ThreadStart(startThreadMethod));
            //  sendStartThread.IsBackground = true;
            sendStartThread.Start();
        }
        /// <summary>
        /// 停止按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbOverSendBtn_Click(object sender, EventArgs e)
        {
            threadState = ((ToolStripButton)sender).Tag.ToString();
            if (sendThread != null)
            {
                chkSendThreadState(sender);
            }
        }
       #endregion

        #region 第二套发送子线程

        public void startThreadMethod()
        {
            if (sendThreadNum==0)
            {
                sendThreadNum = sendNum;
            }
            sendThread = new Thread[sendThreadNum];
            sendThreadTip=new String[sendThreadNum];
            //生成sendThreadNum 个子线程
            for (int i = 0; i < sendThread.Length; i++)
            {
                //每个线程的状态标识
                sendThreadTip[i] = "sendThread" + i;
                //新线程
                sendThread[i] = new Thread(new ThreadStart(sendMainThreadMethod));
                sendThread[i].Name = "sendThread" + i;
                sendThread[i].IsBackground = true;
                sendThread[i].Start();
            }

        }

        public void sendMainThreadMethod()
        {
            while (true)
            {
                int innerInboxIndex = 0;
                int diySendCount = 0;
                lock (this)
                {
                    //fromSendNum如果为0采用平均分配
                    if (fromSendNum == 0)
                    {
                        if ((fromSendCount >= (int)(sendNum / fromNum)) ||( failedCount > failedNum))
                        {
                                fromSendCount = 0;
                                fromIndex += 1;//收件人索引
                                if (fromIndex >= fromNum)
                                {
                                    fromIndex = 0;
                                }
                        }
                    }
                    else
                    {
                        //超过用户自定义的发送邮件数量之后就更换发件人邮箱
                        //如果设置了fromSendNum，而需要发送的邮件大于（fromSendNum×fromNum）标识是否继续循环发送（fromSendNumContinue）
                        //连续发送failedNum后就更换发件人，如果 fromSendNum（单个邮箱可以发送的数量）< failedNum 则就不会设置此条件，因为单个邮箱可以发送数量不足时已经执行了更换 ,以上平均分配不出现此情况
                        if (fromSendCount >= fromSendNum || (failedCount >= failedNum && fromSendNum > failedNum))
                        {
                            fromIndex += 1;//收件人索引
                            fromSendCount = 0;
                            if (fromIndex >= fromNum)
                            {
                                if (fromSendNumContinue)
                                {
                                    fromIndex = 0;
                                }
                                else
                                {
                                    sendStop = true;
                                }
                            }
                        }
                    }
                    
                    inboxIndex += diySendNum; //收件人索引
                    innerInboxIndex = inboxIndex;

                    diySendCount = diySendNum; //处理发件人索引 加上自定义单次发送数量之后超出 收件人总数问题
                    //如果发送了的邮件大于发送总数就退出  第一次大于 第二次大于就break
                    if (innerInboxIndex < (sendNum + diySendNum) && innerInboxIndex >= sendNum)
                    {
                        // diySendCount = sendNum - (inboxIndex - diySendNum)-1;
                        diySendCount = sendNum % diySendNum;
                        if (diySendCount == 0)
                        {
                            diySendCount = 1;
                        }
                    }
                    if (innerInboxIndex >= sendNum + diySendNum)
                    {
                        sendStop = true;
                    }

                }//锁结束

                //发送前检查总标识是否继续
                if (sendStop)
                {
                    //执行停止操作
                    break;
                }
                else
                {
                    Thread.Sleep(threadMillisecond);
                    //继续发送
                    for (int i = diySendCount; i >= 1; i--)
                    {
                        DateTime startSendTime = DateTime.Now;
                        fromSendCount++;//单个邮箱发了多少封邮件
                        int inboxIndexNum;
                        inboxIndexNum = (innerInboxIndex - i);
                        //如果是最后一次循环发送，则使用sendNum
                        if (innerInboxIndex > sendNum)
                        {
                            inboxIndexNum = (sendNum - i);
                        }
                        //准备数据
                        Email email = readyData(fromIndex, inboxIndexNum, mainEmail);


                        SendMail sendMail = new SendMail(email.From, email.Account, email.Password, email.Smtp, email.Address, email.Body.ToString(), email.Title.ToString(), email.From);
                        email.SendMsg = sendMail.Send();//replay.ToString()
                       // MessageBox.Show(Thread.CurrentThread.Name + "中 " + fromIndex + " 发送了 " + fromSendCount + "  封邮件 :" + inboxIndexNum +"  "
                         //   + email.From + "  " + email.Account + "  " + email.Password + "  " + email.Smtp + "  " + email.Address + "    " + mainEmail.Title.ToString());
                        //email.SendMsg = "发送成功";//发送之后的消息

                        sendTotalCount = inboxIndexNum;//总共发了多少封邮件
                        DateTime endSendTime = DateTime.Now;
                        email.SendMilliseconds = (endSendTime - startSendTime).Milliseconds;
                        listViewResult.BeginInvoke(new delegateDataProcessing(dataProcessing), email);

                        //发送一定数量后进行断网重连
                        Thread.Sleep(30);
                        //RASDisplay ras = new RASDisplay();
                        //ras.Disconnect();//断开连接
                        //ras.Connect("ADSL");//重新拨号
                    }

                    
                 }
            }

           //设置当前线程状态是否已经运行完毕
            //Thread.CurrentThread.Abort();
            for (int tip = 0; tip < sendThreadTip.Length;tip++ )
            {
                if(Thread.CurrentThread.Name.Equals(sendThreadTip[tip])){
                    sendThreadTip[tip] = "true";
                }
            }
            String exitTip = "true";
            //查看所有的线程状态，如果全部都为true就退出
            for (int exit = 0; exit < sendThreadTip.Length; exit++)
            {
                if (!"true".Equals(sendThreadTip[exit]))
                {
                    exitTip = "false";
                }
            }
            if (exitTip.Equals("true"))
            {
                toolStripSendStart.BeginInvoke(new delegateOver(overButton));
                sendThread = null;
                fromSendCount = 0;
                fromIndex = 0;
                inboxIndex = 0;
                sendStop = false;
                failedCount = 0;
                MessageBox.Show("邮件群发完成～！", "消息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sendStartThread.Abort();
            }
           
        }

        public void overButton(){
            this.tsbStopSendBtn.Enabled = false;
            this.tsbStartSend.Image = Properties.Resources.startSend;
            this.tsbStartSend.Tag = "pause";
        }

        public Email readyData(int fromIndex, int inboxIndexNum, Email mainEmail)
        {
            Email email = new Email();
            

            //发件人信息
            email.FromId= fromSend.Rows[fromIndex]["id"].ToString();
            email.From = fromSend.Rows[fromIndex]["fromAddress"].ToString();
            email.Account = fromSend.Rows[fromIndex]["account"].ToString();
            email.Password = fromSend.Rows[fromIndex]["pwd"].ToString();
            email.FromState = fromSend.Rows[fromIndex]["state"].ToString();
            email.FromSendCountData = int.Parse(fromSend.Rows[fromIndex]["sendCount"].ToString());
            email.FromLastDate = DateTime.Parse(fromSend.Rows[fromIndex]["lastDate"].ToString());
            email.DomainName = fromSend.Rows[fromIndex]["domainName"].ToString();
            email.Smtp = fromSend.Rows[fromIndex]["smtp"].ToString();
            if (email.Smtp.Equals("smtp.qianlongsoft.com"))
            {
                email.Smtp = "smtp.exmail.qq.com";
            }
            else if(email.Smtp.Equals("smtp1.qianlongsoft.com")){
                email.Smtp="smtp.exmail.qq.com";
            }
            else if (email.Smtp.Equals("smtp2.qianlongsoft.com"))
            {
                email.Smtp = "smtp.exmail.sina.com";
            }
            else if (email.Smtp.Equals("smtp3.qianlongsoft.com"))
            {
                email.Smtp = "smtp.ym.163.com";
            }
            else if (email.Smtp.Equals("smtp4.qianlongsoft.com"))
            {
                email.Smtp = "smtp.live.com";
            }
            else if (email.Smtp.Equals("smtp5.qianlongsoft.com"))
            {
                email.Smtp = "mail.sohu.net";
            }
            else if (email.Smtp.Equals("smtp6.qianlongsoft.com"))
            {
                email.Smtp = "smtp.gmail.com";
            }else{
                email.Smtp = fromSend.Rows[fromIndex]["smtp"].ToString();
            }
            email.SmtpPort = fromSend.Rows[fromIndex]["smtpPort"].ToString();
            email.Ssl = fromSend.Rows[fromIndex]["ssl"].ToString();

            //收件人信息
            email.InboxId = inboxSend.Rows[inboxIndexNum]["id"].ToString();
            email.Address = inboxSend.Rows[inboxIndexNum]["address"].ToString();
            email.NickNameSend = inboxSend.Rows[inboxIndexNum]["nickName"].ToString();
            email.InboxState = inboxSend.Rows[inboxIndexNum]["state"].ToString();
            email.InboxSendCount = int.Parse(inboxSend.Rows[inboxIndexNum]["sendCount"].ToString());
            email.InboxLastDate = DateTime.Parse(inboxSend.Rows[inboxIndexNum]["lastDate"].ToString());

            //邮件内容
            IDictionary isVipBodyAd = (IDictionary)ConfigurationSettings.GetConfig("isVipBodyAd");
            String isVipBody = mainEmail.Body.ToString();
            isVipBody = isVipBody.Replace("$A#", mainEmail.FromNickName).Replace("$B#", email.NickNameSend).Replace("$C#", Constant.GenerateRandomSymbol());
            isVipBody = isVipBody.Replace("CF_url.asp?", "CF_url.asp?m="+email.Address+"&");
            isVipBody += "<br/><font style='background-color:#ffffff' color=#ffffff>Email Number:" + Constant.GenerateRandomNumber(12) + "</font>";
            if (!InfoHelper.isVip)
            {
                isVipBody += "<br/><br/>本信息由‘<a href='" + (string)isVipBodyAd["url"] + "'>钱龙邮件营销系统</a>’发送。但不涉及内容的选择，由内容产生的问题概不负责！<br/>";
                    //"<a href='" + (string)isVipBodyAd["url"] + "'><img src='" + (string)isVipBodyAd["img"] + "'/></a>";
            }
            //IDictionary emailBodyAd = (IDictionary)ConfigurationSettings.GetConfig("emailBodyAd");
            //isVipBody += "<br/><a href='" + (string)emailBodyAd["url"] + "'><img src='" + (string)emailBodyAd["img"] + "'/></a><br/>";
            isVipBody += "<br/><img src='http://ema.qianlongsoft.com/cf.asp?c="+InfoHelper.userName+"' border='0' /><br/>";
            String title = mainEmail.Title.ToString();
            title = title.Replace("$A#", mainEmail.FromNickName).Replace("$B#", email.NickNameSend).Replace("$C#", Constant.GenerateRandomSymbol()).Replace("$D#", DateTime.Now.ToString());
            String[] titleSplit = title.Split('|');
            if (titleSplit.Length > 0)
            {
                title = titleSplit[new Random().Next(titleSplit.Length)];
            }
            email.Body = isVipBody;
            email.Title = title;

            return email;
        }

        /// <summary>
        /// 检查发送线程的状态
        /// </summary>
        public bool chkSendThreadState(object sender) {
            bool result = false;
            
            if (threadState.Equals("running"))
            {
                //如果为running 继续运行所有线程
                for (int t = 0; t < sendThread.Length; t++)
                {
                        sendThread[t].Resume();
                        ((ToolStripButton)sender).Tag = "pause";
                        this.tsbStartSend.Image = Properties.Resources.pause;
                        this.textBoxState.Text = "正在发送...";
                        result= true;
                }
            }
            else if (threadState.Equals("pause"))
            {
                //如果为pause 暂停所有线程
                for (int t = 0; t < sendThread.Length; t++)
                {
                    if (sendThread[t].IsAlive)
                    {
                        sendThread[t].Suspend();
                        ((ToolStripButton)sender).Tag = "running";
                        this.tsbStartSend.Image = Properties.Resources.continueSend;
                        this.textBoxState.Text = "已经暂停";
                        result= false;
                    }
                }
            }
            else if (threadState.Equals("over"))
            {
                
                //如果为over 结束所有线程
                for (int t = 0; t < sendThread.Length; t++)
                {
                    try
                    {
                        if (this.tsbStartSend.Tag.Equals("running"))
                        {
                            sendThread[t].Resume();
                        }
                        sendThread[t].Abort();
                        
                    }
                    catch { }
                    
                }
                sendThread = null;
                fromSendCount = 0;
                fromIndex = 0;
                inboxIndex = 0;
                sendStop = false;
                failedCount = 0;
                this.tsbStopSendBtn.Enabled = false;
                this.tsbStartSend.Image = Properties.Resources.startSend;
                this.tsbStartSend.Tag = "pause";
                this.textBoxState.Text = "已经停止";
            }
            return result;
        }

        /// <summary>
        /// 处理数据的线程托管
        /// </summary>
        public delegate void delegateDataProcessing(Email email );
        /// <summary>
        /// 发送完成后处理数据
        /// </summary>
        private void dataProcessing(Email email )
        {
             //显示到listview上面
            ListViewItem listViewItem = new ListViewItem(sendTotalCount.ToString());
            listViewItem.Tag = 0;
            int sendMilliseconds = email.SendMilliseconds;
            if (sendMilliseconds <= 0) { sendMilliseconds = 1; }
            listViewItem.SubItems.AddRange(new string[] { email.FromId, email.From, email.Address, sendMilliseconds + "ms", email.SendMsg });
            listViewResult.Items.Add(listViewItem);
            listViewResult.Items[listViewResult.Items.Count - 1].EnsureVisible();
            listViewResult.Items[listViewResult.Items.Count - 1].Selected = true;
            

            if (email.SendMsg.Equals("发送成功"))
            {
               //更新数据库信息
               addConfigDao.updateFromSend(int.Parse(email.FromId), 1);
               inboxDao.updateInboxSend(int.Parse(email.InboxId), 1);
               emailInfoDao.updateEmailInfoSend(int.Parse(this.comboBoxEmailTitle.SelectedValue.ToString()), 1);

                failedCount=0;

               this.textBoxSendCount.Text = (Constant.sendTotal += 1) + "封";
            }
            else
            {
                failedCount++;
                //一封邮件发送失败后，临时保存
                inboxDao.updateInboxFailed(int.Parse(email.InboxId));
                this.textBoxSendFail.Text = (Constant.sendFail += 1) + "封";
            }
        }
        #endregion

        private void toolStripMenu_Paint(object sender, PaintEventArgs e)
        {
            String toolStripName = ((ToolStrip)sender).Name;
            if (toolStripName.Equals("toolStripMenu"))
            {
                if ((sender as ToolStrip).RenderMode == ToolStripRenderMode.System)
                {
                    Rectangle rect = new Rectangle(0, 0, this.toolStripMenu.Width, this.toolStripMenu.Height - 2);
                    e.Graphics.SetClip(rect);
                }
            }
            else {
                if ((sender as ToolStrip).RenderMode == ToolStripRenderMode.System)
                {
                    Rectangle rect = new Rectangle(0, 0, this.toolStripSendStart.Width, this.toolStripSendStart.Height - 2);
                    e.Graphics.SetClip(rect);
                }
            }
            
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Top = Control.MousePosition.Y - m_MousePoint.Y;
                this.Left = Control.MousePosition.X - m_MousePoint.X;
            }
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                m_MousePoint.X = e.X;
                m_MousePoint.Y = e.Y;
            }
        }

        private void tsbMenu_MouseHover(object sender, EventArgs e)
        {
            String tsbName = ((ToolStripButton)sender).Name;
            if (tsbName.Equals("tsbSendEmail"))
            {
                this.tsbSendEmail.Image = global::common.Properties.Resources.sendOver;
            }
            else if (tsbName.Equals("tsbEditEmail"))
            {
            this.tsbEditEmail.Image = global::common.Properties.Resources.emailOver;
            }
            else if (tsbName.Equals("tsbEmailConfig"))
            {
            this.tsbEmailConfig.Image = global::common.Properties.Resources.senderOver;
            }
            else if (tsbName.Equals("tsbAddressConfig"))
            {
            this.tsbAddressConfig.Image = global::common.Properties.Resources.userMailOver;
            }
            else if (tsbName.Equals("tsbReg"))
            {
            this.tsbReg.Image = global::common.Properties.Resources.registOver;
            }
            else if (tsbName.Equals("tsbBuy"))
            {
            this.tsbBuy.Image = global::common.Properties.Resources.serviceOver;
             }
        }

        private void tsbMenu_MouseLeave(object sender, EventArgs e)
        {
            String tsbName = ((ToolStripButton)sender).Name;
            if (tsbName.Equals("tsbSendEmail"))
            {
                this.tsbSendEmail.Image = global::common.Properties.Resources.sendOn;
            }
            else if (tsbName.Equals("tsbEditEmail"))
            {
                this.tsbEditEmail.Image = global::common.Properties.Resources.emailOn;
            }
            else if (tsbName.Equals("tsbEmailConfig"))
            {
                this.tsbEmailConfig.Image = global::common.Properties.Resources.senderOn;
            }
            else if (tsbName.Equals("tsbAddressConfig"))
            {
                this.tsbAddressConfig.Image = global::common.Properties.Resources.userMailOn;
            }
            else if (tsbName.Equals("tsbReg"))
            {
                this.tsbReg.Image = global::common.Properties.Resources.registOn;
            }
            else if (tsbName.Equals("tsbBuy"))
            {
                this.tsbBuy.Image = global::common.Properties.Resources.service;
            }
        }

        private void notifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (this.Visible)
                {
                    this.WindowState = FormWindowState.Minimized;
                    this.Hide();
                }
                else
                {
                    this.Visible = true;
                    this.WindowState = FormWindowState.Normal;
                }
            }
        }

        private void picMin_MouseClick(object sender, EventArgs e)
        {
                if (this.Visible)
                {
                    this.WindowState = FormWindowState.Minimized;
                    this.Hide();
                }
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picControlMin_MouseHover(object sender, EventArgs e)
        {
            String controlName = ((PictureBox)sender).Name;
            if (controlName.Equals("picMin"))
            {
               this.picMin.Image=common.Properties.Resources.minFormOver;
            }
            else if (controlName.Equals("picClose"))
            {
                this.picClose.Image = common.Properties.Resources.closeFormOver;
            }
        }

        private void picControlMin_MouseLeave(object sender, EventArgs e)
        {
            String controlName = ((PictureBox)sender).Name;
            if (controlName.Equals("picMin"))
            {
                this.picMin.Image = common.Properties.Resources.minForm;
            }
            else if (controlName.Equals("picClose"))
            {
                this.picClose.Image = common.Properties.Resources.closeForm;
            }
        }

    }
}
