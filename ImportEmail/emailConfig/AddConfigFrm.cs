using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using dao.user;
using dao.common;
using dao;
using System.Net;
using System.Collections.Specialized;
using System.Net.Json;
using System.Collections;
using System.Configuration;

namespace common.emailConfig
{
    public partial class AddConfigFrm : Form
    {
        public AddConfigFrm()
        {
            InitializeComponent();
        }
        private AddConfigDao addConfigDao = new AddConfigDao();
        private String no = "线上服务器";
        private String state = "正常";
        private String domain = "false";
        private String fromAddress;
        public MainForm mainForm;

        private void AddConfigFrm_Load(object sender, EventArgs e)
        {
            JsonTextParser parser = new JsonTextParser();
            JsonObject jsonValue;
            //加载用户购买的域名后缀
            WebClient webClient = new WebClient();
            NameValueCollection userDomainValue = new NameValueCollection();
            userDomainValue.Add("action", "getUserDomain");
            userDomainValue.Add("userId", InfoHelper.userId);
            byte[] userDomainValueResultByte = webClient.UploadValues(InfoHelper.permissions, "POST", userDomainValue);
            string userDomainValueResult = System.Text.Encoding.UTF8.GetString(userDomainValueResultByte).Trim();
            
            jsonValue = parser.Parse(userDomainValueResult);
            String selectedItem = "";
            foreach (JsonObject field in jsonValue as JsonObjectCollection)
            {
                if("0".Equals(field.Name)){
                    selectedItem =(String)field.GetValue();
                }
                this.comboBoxDomain.Items.Add(field.GetValue());
            }
            this.comboBoxDomain.SelectedItem = selectedItem;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //保存
        private void buttonSave_Click(object sender, EventArgs e)
        {
            String account = this.textBoxUser.Text.Trim();
            String password = this.textBoxPwd.Text.Trim();
            String onlineDomain = this.textBoxDomain.Text.Trim();
            String  localDomain = this.comboBoxDomain.Text.Trim();
            String smtp = this.textBoxSmtp.Text.Trim();
            String smtpPort = this.textBoxSmtpPort.Text.Trim();
            Boolean sslChecked=this.checkBoxSSL.Checked;
            String ssl = "false";
            if(sslChecked){
                ssl = "true";
            }
            int sendCount = 0;

            Boolean isCheck = check(account, password, localDomain, onlineDomain, smtp, smtpPort);
            if(isCheck){
                addConfigDao.saveCreate(no, fromAddress, account, password, sendCount, domain, smtp, smtpPort, ssl, state);
                mainForm.loadFrom();
                this.Close();
            }
        }
        /// <summary>
        /// 检查
        /// </summary>
        /// <returns></returns>
        private Boolean check(string account, string password,string localDomain,string onlineDomain, string smtp, string smtpPort)
        {
            Boolean result = false;
            String msg = "";

            if ("".Equals(account) || account == null) {
                msg = "账号不能为空，请填写登陆邮箱的账号";
            }
            else if ("".Equals(password) || password == null)
            {
                msg = "邮箱密码不能为空,请填写邮箱的登陆密码";
            }
            else if ("".Equals(smtp) || smtp == null)
            {
                msg = "邮箱服务器不能为空，如：smtp.bywei.cn";
            }
            else if ("".Equals(smtpPort) || smtpPort == null)
            {
                msg = "邮箱服务器端口号不能为空,默认端口号为25";
            }
            else
            {

                Boolean local = this.radioButtonLocal.Checked;
                Boolean online = this.radioButtonOnline.Checked;
                if (local)
                {
                    //本地邮件服务器
                    if ("".Equals(localDomain) || localDomain == null)
                    {
                        msg = "邮箱后缀名不能为空";
                    }
                    fromAddress = account + "@" + localDomain;
                    ChkUtil chkUtil = new ChkUtil();
                    if (!chkUtil.validateEmail(fromAddress))
                    {
                        msg = "邮箱后缀名或者用户名有误";
                    }

                    no = "本地服务器";
                    domain = localDomain;
                    //验证链接是否成功
                    state = "正常";
                    result = true;

                }
                else if (online)
                {
                    //线上邮件服务器
                    fromAddress = onlineDomain;
                    ChkUtil chkUtil = new ChkUtil();
                    if (!chkUtil.validateEmail(onlineDomain))
                    {
                        msg = "邮箱填写有误";
                    }
                    if ("localhost".Equals(smtp)||"127.0.0.1".Equals(smtp))
                    {
                        msg = "邮件服务器填写错误";
                    }
                    domain = "false";
                    //验证链接是否成功
                    state = "正常";
                    result = true;
                }
            }

            if (!msg.Equals(""))
            {
                MessageBox.Show(msg, "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return result;
        }

        //选择服务器类型
        private void radioButtonOnline_Click(object sender, EventArgs e)
        {
            String hostType=((RadioButton)sender).Name;
            if (hostType.Equals("radioButtonLocal"))
            {
                this.textBoxUser.Text = "service";
                this.textBoxPwd.Text = "service";
                this.textBoxSmtp.Text = "localhost";
                this.textBoxSmtp.ReadOnly = true;
                this.groupBoxDomain.Text="邮箱域名后缀";
                this.textBoxDomain.Visible = false;
                this.comboBoxDomain.Visible = true;
                this.textBoxSmtpPort.Text = "25";
                this.textBoxSmtpPort.ReadOnly = true;

                this.linkDomain.Text = "购买企业版发件邮箱";
            }
            else if (hostType.Equals("radioButtonOnline"))
            {
                this.textBoxUser.Text = "";
                this.textBoxPwd.Text = "";
                this.textBoxSmtp.Text = "";
                this.textBoxSmtp.ReadOnly = false;
                this.textBoxDomain.Visible = true;
                this.comboBoxDomain.Visible = false;
                this.groupBoxDomain.Text="邮箱发送地址";
                this.textBoxSmtpPort.Text = "25";
                this.textBoxSmtpPort.ReadOnly = false;

                this.linkDomain.Text = "购买企业域名邮箱";
            }
        }

        private void linkDomain_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            IDictionary IDHelperLink = (IDictionary)ConfigurationSettings.GetConfig("userDomain");
            System.Diagnostics.Process.Start((string)IDHelperLink["url"]);
        }


    }
}
