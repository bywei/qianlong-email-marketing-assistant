using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using dao.common;
using dao;
using dao.core;
using System.Net.Mail;
using System.Collections.Specialized;

namespace common.sendConfig
{
    public partial class SendTestFrm : Form
    {
        public SendTestFrm()
        {
            InitializeComponent();
        }
        //测试发送
        private void buttonSend_Click(object sender, EventArgs e)
        {
            String testTo = this.textBoxEmailAddress.Text.Trim();
            string from = "";
            string account = "";
            string password = "";
            string smtp = "";
            string To = testTo;
            string replyTo = "";

            string Body = "";
            string Title = "";
            string sendMsg = "";
            string nickName = "";

            ChkUtil chkUtil = new ChkUtil();
            AddConfigDao addConfigDao = new AddConfigDao();
            SendMail sendMail;
            if (chkUtil.validateEmail(testTo))
            {
               DataTable fromDt=addConfigDao.loadFrom().Tables["efrom"];
                int testCount= fromDt.Rows.Count;
                if(testCount>20){
                    testCount=20;
                }
                for (int i = 0; i < testCount; i++)
                {
                   //发送邮件
                   from = fromDt.Rows[i]["fromAddress"].ToString();
                   account = fromDt.Rows[i]["account"].ToString();
                   password = fromDt.Rows[i]["pwd"].ToString();
                   smtp = fromDt.Rows[i]["smtp"].ToString(); ;
                   replyTo = fromDt.Rows[i]["fromAddress"].ToString();

                   nickName = from.Substring(0,from.IndexOf("@"));
                   Title = "恭喜您，" + nickName + " 用户使用 邮件营销系统 测试成功";
                   Body = "<br/>您好！<br/>&hbsp;&nbsp;感谢您使用‘钱龙邮件营销系统’您收到来自" + nickName + "的邮件，表示本系统运行良好~！<br/>如果您希望使用我们更加优秀的服务，请登录官方网站 http://www.qianlongsoft.com/ 。";

                   sendMail = new SendMail(from, account, password, smtp, To, Body, Title, replyTo);
                   sendMsg +="使用 "+from+" -> "+ sendMail.Send()+"\r\n";
                  
               }
                if(sendMsg.Equals("")){
                    sendMsg = "请确认您已经填写了发件人";
                }
               MessageBox.Show(sendMsg, "提示:只会测试前20个发件人的发件箱", MessageBoxButtons.OK, MessageBoxIcon.Information);
               this.Close();
            }
            else {
                MessageBox.Show("请输入正确的邮件地址","提示信息",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
        //取消
        private void buttonCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
