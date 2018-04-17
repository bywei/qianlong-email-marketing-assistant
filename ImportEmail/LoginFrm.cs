using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Net;
using System.Collections.Specialized;
using System.Collections;
using System.Configuration;
using System.Net.Json;
using dao.common;
using dao.user;
using dao.core;
using System.Xml;
using System.IO;

namespace common
{
    public partial class LoginFrm : Form
    {
        public LoginFrm()
        {

            InitializeComponent();
            try
            {
               // skinEngine.SkinFile = @"skin\MacOSSkin.dll";
            }
            catch { }
        }

        #region 全局变量
        private Point m_MousePoint;
        #endregion
        String msg = "";
        String userName = "";
        String userPwd = "";
        String userEmail = "";
        String userScore = "";
        String userLevel = "";
        String userSendNum = "";
        bool userIsVip = false;
        private string permissions;
        private String userInfoConfig = Directory.GetCurrentDirectory() + "/userInfo.config";
        private JsonTextParser parser = new JsonTextParser();
        private JsonObject jsonValue;
        private  MainForm mainForm = new MainForm();
        private void LoginFrm_Load(object sender, EventArgs e)
        {
            this.Size =new System.Drawing.Size(366,272);
            //设置登录界面广告
          //  this.pictureBoxLoginAd.Image = Image.FromFile("skin/loginbannerad.gif");

            //设置登陆交互网页地址
            IDictionary IDPermissions = (IDictionary)ConfigurationSettings.GetConfig("permissions");
            permissions = (string)IDPermissions["url"];
            InfoHelper.permissions = permissions;

            //设置界面样式
            this.panelLogin.Location = new System.Drawing.Point(58, 119);
            this.panelReg.Location = new System.Drawing.Point(58, 109);

            String[] infoLines = File.ReadAllLines(userInfoConfig);
            if (infoLines.Length == 2)
            {
                this.txtLoginUserName.Text =dao.common.Encoder.decode( infoLines[0]);
                this.txtLoginPwd.Text = dao.common.Encoder.decode(infoLines[1]);
            }
        }



        public delegate void panelsDelegate();
        private void btnRegOk_Click(object sender, EventArgs e)
        {
            //注册群发
             userName = this.txtRegName.Text.Trim().ToLower();
             userPwd = this.txtRegPwd.Text.Trim().ToLower();
             userEmail = this.txtRegEmail.Text.Trim().ToLower();

            if (!chkUserInfo(userName, userPwd, userEmail)) { return; }

          System.Threading.Thread regThread=  new System.Threading.Thread(new System.Threading.ThreadStart(regThreadMethod));
          regThread.IsBackground = true;
          regThread.Start();

        }

        public void regThreadMethod() {
            WebClient regWebClient = new WebClient();
            NameValueCollection regValue = new NameValueCollection();
            regValue.Add("action", "insert");
            regValue.Add("userName", userName);
            regValue.Add("userPwd", userPwd);
            regValue.Add("userEmail", userEmail);
            byte[] regValueResultByte = regWebClient.UploadValues(permissions, "POST", regValue);
            string regValueResult = System.Text.Encoding.UTF8.GetString(regValueResultByte);

            if (regValueResult.Equals("true"))
            {
                msg = "恭喜您，注册成功，请联系管理员审核开通！";
            }
            else
            {
                msg = "用户无效，请重新选择用户名";
            }
            this.panelReg.BeginInvoke(new panelsDelegate(panelsReg));
        }

        private void panelsReg() {
            this.panelReg.Visible = false;
            this.panelLogin.Visible = true;
            if(!"".Equals(msg)){
                MessageBox.Show(msg, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                msg = "";
            }
        }

        private bool chkUserInfo(string userName, string userPwd, string userEmail)
        {
            bool result = false;
            ChkUtil chkUtil = new ChkUtil();
            if (String.IsNullOrEmpty(userName) || String.IsNullOrEmpty(userPwd) || String.IsNullOrEmpty(userEmail))
            {
                msg = "请确认信息是否填写完整";
            }
            else if (!chkUtil.validateUser(userName))
            {
                msg = "用户名不规范(0-9 a-z 2-18个字符)";
            }
            else if (!chkUtil.validateUser(userPwd))
            {
                msg = "密码不规范(0-9 a-z 2-18个字符)";
            }
            else if (!chkUtil.validateEmail(userEmail))
            {
                msg = "请填写正确的邮件地址";
            }
            else { result = true; }
            if (msg != "")
            {
                MessageBox.Show(msg, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                msg = "";
            }
            return result;
        }

        private delegate void loginDelegate();
        private void btnLOgin_Click(object sender, EventArgs e)
        {
            //登录
             userName = this.txtLoginUserName.Text.Trim().ToLower();
             userPwd = this.txtLoginPwd.Text.Trim().ToLower();
             String[] infoLines=new String[]{dao.common.Encoder.encode(userName),dao.common.Encoder.encode(userPwd)};
             File.WriteAllLines(userInfoConfig, infoLines);

            if (!chkUserInfo(userName, userPwd, "bywei@bywei.cn")) { return; }

            this.picLoading.Location = new Point(104, 149);
            this.picLoading.Visible = true;
            this.btnLOgin.Enabled = false;
            this.panelLogin.Visible = false;

          System.Threading.Thread loginThread= new System.Threading.Thread(new System.Threading.ThreadStart(loginThreadMethod));
          loginThread.IsBackground = true;
          loginThread.Start();

            //本地服务器的启动
          //System.Threading.Thread sendServiceThread = new System.Threading.Thread(new System.Threading.ThreadStart(SendService.start));
          //sendServiceThread.IsBackground = true;
          //sendServiceThread.Start();

        }

        public void loginThreadMethod()  {
           
            WebClient webClient = new WebClient();
            NameValueCollection loginValue = new NameValueCollection();
            loginValue.Add("action", "login");
            loginValue.Add("userName", userName);
            loginValue.Add("userPwd", userPwd);
            byte[] loginValueResultByte = null ;
            try
            {
                loginValueResultByte = webClient.UploadValues(permissions, "POST", loginValue);
            }
            catch(Exception e){
                MessageBox.Show("暂时无法连接服务器，请检查您的网络连接是否正常！","提示");
                this.btnLOgin.BeginInvoke(new loginDelegate(btnLoginShow));
                return;
            }
            string loginValueResult = System.Text.Encoding.UTF8.GetString(loginValueResultByte).Trim();
            
            //获取登陆数据
            jsonValue = parser.Parse(loginValueResult);
            bool jsonIsLogin = false;
            string jsonUserId = "";
            foreach (JsonObject field in jsonValue as JsonObjectCollection)
            {
                if (field.Name.Trim().Equals("islogin") && (bool)field.GetValue())
                {
                    jsonIsLogin = true;
                }
                if (field.Name.Equals("userId"))
                {
                    jsonUserId = field.GetValue().ToString();

                }
            }
            if (jsonIsLogin && !"".Equals(jsonUserId))
            {
                InfoHelper.islogin = true;
                InfoHelper.userId = jsonUserId;
                this.btnLOgin.BeginInvoke(new loginDelegate(getUserInfo));
            }
            else {
                MessageBox.Show("如果您的帐号已通过审核，原因在于帐号已在其他地方登录 或者 软件不正常关闭！\n 请稍等五分钟后再登录 或者 请联系管理员！帐号审核请登录官网查看联系方式！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.btnLOgin.BeginInvoke(new loginDelegate(btnLoginShow));
        }
        private void btnLoginShow()
        {
            this.picLoading.Visible = false;
            this.btnLOgin.Enabled = true;
            this.btnLOgin.Enabled = true;
            this.panelLogin.Visible = true;
        }


        public void getUserInfo()
        {
            WebClient userInfoWebClient = new WebClient();
            NameValueCollection userInfoValue = new NameValueCollection();
            userInfoValue.Add("action", "getUserInfo");
            userInfoValue.Add("userId", InfoHelper.userId.ToString());
            byte[] userInfoValueResutByte = userInfoWebClient.UploadValues(InfoHelper.permissions, "POST", userInfoValue);
            string userInfoValueResult = System.Text.Encoding.UTF8.GetString(userInfoValueResutByte);

                //  string jsonText = "{ \"userScore\": 100,\"userLevel\": 2,\"userSendNum\":10000,\"userIsVip\": true}";
                jsonValue = parser.Parse(userInfoValueResult);
                foreach (JsonObject field in jsonValue as JsonObjectCollection)
                {
                    switch (field.Name)
                    {
                        case "userScore":
                            userScore = field.GetValue().ToString().Trim();
                            break;
                        case "userLevel":
                            userLevel = field.GetValue().ToString().Trim();
                            break;
                        case "userSendNum":
                            userSendNum = field.GetValue().ToString().Trim();
                            break;
                        case "userIsVip":
                            userIsVip = (bool)field.GetValue();
                            break;
                        default:
                            break;
                    }
                }

                //用户信息设置
                InfoHelper.userLevel = userLevel;
                InfoHelper.userScore = userScore;
                InfoHelper.userSendNum = userSendNum;
               
                if (userIsVip)
                {
                    InfoHelper.isVip = true;
                }
                if (!DbHelper.islogin)
                {
                    InfoHelper.userName = this.txtLoginUserName.Text.Trim();
                    InfoHelper.userPwd = this.txtLoginPwd.Text.Trim();
                }
                
                DbHelper.islogin = true;
                mainForm.Opacity = 0.1;
            if(this.Visible){
                mainForm.Show();
            }
                timerStyle.Enabled = true;
                this.Visible = false;
        }

        private void linkLabelShowHelper_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            IDictionary IDHelperLink = (IDictionary)ConfigurationSettings.GetConfig("helperlink");
            System.Diagnostics.Process.Start((string)IDHelperLink["url"]);
        }

        private void btnRegExit_Click(object sender, EventArgs e)
        {
            this.panelReg.Visible = false;
            this.panelLogin.Visible = true;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.panelReg.Visible = true;
            this.panelLogin.Visible = false;
        }


        /// <summary>
        /// 登录后的界面切换样式
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerStyle_Tick(object sender, EventArgs e)
        {
            if (mainForm.Opacity >= 1)
            {
                   mainForm.Opacity = 1;
                timerStyle.Enabled = false;
            }
            else {
                mainForm.Opacity += 0.1;
            }
        }

        private void LoginFrm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                m_MousePoint.X = e.X;
                m_MousePoint.Y = e.Y;
            }
        }

        private void LoginFrm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Top = Control.MousePosition.Y - m_MousePoint.Y;
                this.Left = Control.MousePosition.X - m_MousePoint.X;
            }
        }

        private void picClose_MouseHover(object sender, EventArgs e)
        {
            this.picClose.Image = common.Properties.Resources.closeFormOver;
        }

        private void picClose_MouseLeave(object sender, EventArgs e)
        {
            this.picClose.Image = common.Properties.Resources.closeForm;
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
