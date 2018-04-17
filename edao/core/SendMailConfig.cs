using System;
using System.IO;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Collections;
using System.Collections.Specialized;
namespace dao.core
{
    /// <summary>
    /// 邮件内容
    /// </summary>
    public class SendMailConfig
    {
        private string sender = null;
        private StringCollection receivers = new StringCollection();
        private string subject = "";
        private string xMailer = "";
        private StringCollection attachments = new StringCollection();
        private MailEncodings mailEncoding = MailEncodings.GB2312;
        private MailTypes mailType = MailTypes.Html;
        private byte[] mailBody = null;
        /// <summary>
        /// 获取或设置发件人
        /// </summary>
        public string Sender
        {
            get { return this.sender; }
            set { this.sender = value; }
        }
        /// <summary>
        /// 获取收件人地址集合
        /// </summary>
        public StringCollection Receivers
        {
            get { return this.receivers; }
        }
        /// <summary>
        /// 获取或设置邮件主题
        /// </summary>
        public string Subject
        {
            get { return this.subject; }
            set { this.subject = value; }
        }
        /// <summary>
        /// 获取或设置邮件传送者
        /// </summary>
        public string XMailer
        {
            get { return this.xMailer; }
            set { this.xMailer = value; }
        }
        /// <summary>
        /// 获取附件列表
        /// </summary>
        public StringCollection Attachments
        {
            get { return this.attachments; }
        }
        /// <summary>
        /// 获取或设置邮件的编码方式
        /// </summary>
        public MailEncodings MailEncoding
        {
            get { return this.mailEncoding; }
            set { this.mailEncoding = value; }
        }
        /// <summary>
        /// 获取或设置邮件格式
        /// </summary>
        public MailTypes MailType
        {
            get { return this.mailType; }
            set { this.mailType = value; }
        }
        /// <summary>
        /// 获取或设置邮件正文
        /// </summary>
        public byte[] MailBody
        {
            get { return this.mailBody; }
            set { this.mailBody = value; }
        }
    }
    /// <summary>
    /// 邮件编码
    /// </summary>
    public enum MailEncodings
    {
        GB2312,
        ASCII,
        Unicode,
        UTF8
    }
    /// <summary>
    /// 邮件格式
    /// </summary>
    public enum MailTypes
    {
        Html,
        Text
    }
    /// <summary>
    /// smtp服务器的验证方式
    /// </summary>
    public enum SmtpValidateTypes
    {
        /// <summary>
        /// 不需要验证
        /// </summary>
        None,
        /// <summary>
        /// 通用的auth login验证
        /// </summary>
        Login,
        /// <summary>
        /// 通用的auth plain验证
        /// </summary>
        Plain,
        /// <summary>
        /// CRAM-MD5验证
        /// </summary>
        CRAMMD5
    }
}