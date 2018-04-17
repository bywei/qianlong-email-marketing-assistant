using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dao.modle
{
   public class Email
    {
        object title = "";
        object body = "";
        object infoSendCount = 0;

        string fromId;
        string from = "";
        string account = "";
        string password = "";
        string fromState = "";
        int fromSendCountData = 0;
        DateTime fromLastDate;
        string domainName;
        string smtp = "";
        string smtpPort = "";
        string ssl = "";

        string inboxId;
        string address = "";
        string nickNameSend = "";
        string inboxState = "";
        int inboxSendCount = 0;
        DateTime inboxLastDate;
        int sendMilliseconds;

       //发件人昵称，从配置文件中读取
        string fromNickName;

        public string FromNickName
        {
            get { return fromNickName; }
            set { fromNickName = value; }
        }

        public int SendMilliseconds
        {
            get { return sendMilliseconds; }
            set { sendMilliseconds = value; }
        }

        /// <summary>
        /// 发送之后的消息
        /// </summary>
       string sendMsg = "发送成功";

        public string SendMsg
        {
            get { return sendMsg; }
            set { sendMsg = value; }
        }

        public object Body
        {
            get { return body; }
            set { body = value; }
        }
        public object InfoSendCount
        {
            get { return infoSendCount; }
            set { infoSendCount = value; }
        }
        public string FromId
        {
            get { return fromId; }
            set { fromId = value; }
        }
        
        public string From
        {
            get { return from; }
            set { from = value; }
        }
        public string Account
        {
            get { return account; }
            set { account = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string FromState
        {
            get { return fromState; }
            set { fromState = value; }
        }

        public int FromSendCountData
        {
            get { return fromSendCountData; }
            set { fromSendCountData = value; }
        }

        public DateTime FromLastDate
        {
            get { return fromLastDate; }
            set { fromLastDate = value; }
        }
        public string DomainName
        {
            get { return domainName; }
            set { domainName = value; }
        }

        public string Smtp
        {
            get { return smtp; }
            set { smtp = value; }
        }

        public string SmtpPort
        {
            get { return smtpPort; }
            set { smtpPort = value; }
        }

        public string Ssl
        {
            get { return ssl; }
            set { ssl = value; }
        }


        public string InboxId
        {
            get { return inboxId; }
            set { inboxId = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string NickNameSend
        {
            get { return nickNameSend; }
            set { nickNameSend = value; }
        }
        public string InboxState
        {
            get { return inboxState; }
            set { inboxState = value; }
        }

        public int InboxSendCount
        {
            get { return inboxSendCount; }
            set { inboxSendCount = value; }
        }

        public DateTime InboxLastDate
        {
            get { return inboxLastDate; }
            set { inboxLastDate = value; }
        }

        public object Title
        {
            get { return title; }
            set { title = value; }
        }
    }
}
