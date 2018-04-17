using System;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Net.Sockets;
using System.Collections.Specialized;
using System.IO;

namespace dao.core
{
    public class SendMail
    {
        private System.Net.Mail.MailMessage mailMessage;
        private SmtpClient smtpClient;

        private string account;
        private string password;//发件人密码  
        private string smtp;
        /// <summary>
        /// 处审核后类的实例  
        /// </summary>  
        /// <param name="to">收件人地址</param>
        /// <param name="from">发件人地址</param>
        /// <param name="Smtp">邮件服务器</param>
        /// <param name="body">邮件正文</param>
        /// <param name="title">邮件的主题</param>
        /// <param name="password">发件人密码</param>
        public SendMail(string from, string account, string password, string smtp, string to, string body, string title, string replyTo)
        {
            mailMessage = new System.Net.Mail.MailMessage();
            mailMessage.To.Add(to);   //收件人地址集合
            mailMessage.From = new System.Net.Mail.MailAddress(from); //发信人
            mailMessage.Subject = title; //邮件主题
            mailMessage.Body = body; //邮件内容
            mailMessage.IsBodyHtml = true; //是否为html
            mailMessage.BodyEncoding = System.Text.Encoding.UTF8; //邮件内容编码
            mailMessage.Priority = System.Net.Mail.MailPriority.Normal;
            mailMessage.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure; //发送失败时通知
            mailMessage.ReplyTo = new MailAddress(replyTo);
            //mailMessage.Sender = new MailAddress(from);

            this.account = account;
            this.password = password;
            this.smtp = smtp;
        }
        /// <summary>  
        /// 添加附件  
        /// </summary>  
        public void Attachments(string Path)  
        {  
            string[] path = Path.Split(',');  
            Attachment data;  
            ContentDisposition disposition;  
            for (int i = 0; i < path.Length; i++)  
            {  
                data = new Attachment(path[i], MediaTypeNames.Application.Octet);//实例化 附件  
                disposition = data.ContentDisposition;  
                disposition.CreationDate = System.IO.File.GetCreationTime(path[i]);//获取 附件的创建日期  
                disposition.ModificationDate = System.IO.File.GetLastWriteTime(path[i]);// 获取附件的修改日期  
                disposition.ReadDate = System.IO.File.GetLastAccessTime(path[i]);//获取附 件的读取日期  
                mailMessage.Attachments.Add(data);//添加到附件中  
            }  
        }
        /// <summary>  
        /// 异步发送邮件  
        /// </summary>  
        /// <param name="CompletedMethod"></param>  
        public void SendAsync(SendCompletedEventHandler CompletedMethod)
        {
            if (mailMessage != null)
            {
                smtpClient = new SmtpClient();
                smtpClient.Credentials = new System.Net.NetworkCredential(mailMessage.From.Address, password);//设置发件人身份的票据  
                smtpClient.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;
                smtpClient.Host =smtp;
                smtpClient.SendCompleted += new SendCompletedEventHandler(CompletedMethod);//注册异步发送邮件完成时的事件  
                smtpClient.SendAsync(mailMessage, mailMessage.Body);
            }
        }

        /// <summary>
        /// 创建smtpclient对象
        /// </summary>
        /// <param name="smtp"></param>
        public void smtpConfig()
        {
            smtpClient = new SmtpClient();
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = new NetworkCredential(account, password);//设置发件人身份的票据  
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.Host = smtp;
        }
        /// <summary>  
        /// 发送邮件  
        /// </summary>  
        public String Send()
        {
            string sendMsg = "发送成功";
            if (mailMessage != null)
            {
                smtpConfig();
                try
                {
                    smtpClient.Send(mailMessage);
                }
                catch (ArgumentNullException ex)
                {
                    sendMsg = ex.Message;
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    sendMsg = ex.Message;
                } catch (ObjectDisposedException ex) {
                    sendMsg = ex.Message;
                }
                catch (InvalidOperationException ex)
                {
                    sendMsg = ex.Message;
                } catch (SmtpFailedRecipientsException ex) {
                    sendMsg = ex.Message;
                }catch (SmtpException ex) {
                    sendMsg = ex.Message;
                } 
            }
            return sendMsg;
        }

    }
}
