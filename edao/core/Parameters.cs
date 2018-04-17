using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;

namespace dao.core
{
    class Parameters
    {
        public struct EmailParameters
        {
            public static int priority = 3;//邮件优先级
            public static string encoding = "8bit ";
            public static string languageencoding = "GB2312 ";
            public static int port = 25;
            public string username;
            public string password;
            public string from;//发件人地址  
            public string subject;//主题  
            public string content;//文本内容  
            public string to;//收件人
            public string fromname;//发送者称呼
            public string toname;//发送者称呼
            public string server;//邮件服务器MX地址或是smtp
        }

        public void SmtpSend(out   bool _Succeed)
        {
            EmailParameters _EmailParameters = new EmailParameters();
            _Succeed = false;
            //   创建TcpClient对象，   并建立连接
            TcpClient tcp = null;
            try { tcp = new TcpClient(_EmailParameters.server, EmailParameters.port); }
            catch { return; }

            if (ReadString(tcp.GetStream()).Substring(0, 3) != "220 ")//获取连接信息
                return;
            if (!Command(tcp.GetStream(), "EHLO   Localhost ", "250 "))//   开始进行服务器认证
                return;
            if (!Command(tcp.GetStream(), "AUTH   LOGIN ", "334 "))//   需要身份验证
                return;
            if (!Command(tcp.GetStream(), ToBase64(_EmailParameters.username), "334 "))//   此处将username转换为Base64码
                return;
            if (!Command(tcp.GetStream(), ToBase64(_EmailParameters.password), "235 "))//   此处将password转换为Base64码
                return;
            //   准备发送
            WriteString(tcp.GetStream(), "mail   From:   " + _EmailParameters.from);
            WriteString(tcp.GetStream(), "rcpt   to:   " + _EmailParameters.to);
            WriteString(tcp.GetStream(), "data ");
            //   发送邮件头
            WriteString(tcp.GetStream(), "Date:   " + DateTime.Now);   //   时间
            WriteString(tcp.GetStream(), "From:   " + _EmailParameters.fromname + " < " + _EmailParameters.from + "> ");   //   发件人
            WriteString(tcp.GetStream(), "Subject:   " + _EmailParameters.subject);   //   主题
            WriteString(tcp.GetStream(), "To: " + _EmailParameters.toname + " < " + _EmailParameters.to + "> ");   //   收件人
            //邮件格式  
            WriteString(tcp.GetStream(), "Reply-To: " + _EmailParameters.from);   //   回复地址
            WriteString(tcp.GetStream(), "X-Priority: " + EmailParameters.priority);   //   优先级
            WriteString(tcp.GetStream(), "KoEnemy-Version:1.0 ");   //   MIME版本
            //   数据ID,随意
            WriteString(tcp.GetStream(), "Content-Type:   text/html;charset= " + EmailParameters.languageencoding);
            WriteString(tcp.GetStream(), "Content-Transfer-Encoding: " + EmailParameters.encoding);
            WriteString(tcp.GetStream(), " ");
            WriteString(tcp.GetStream(), " ");
            WriteString(tcp.GetStream(), _EmailParameters.content);

            WriteString(tcp.GetStream(), ". ");   //   最后写完了，输入 ". "
            //   关闭连接
            tcp.Close();
            _Succeed = true;
        }
        ///   <summary>
        ///   向流中写入字符
        protected void WriteString(NetworkStream netStream, string str)
        {
            str = str + "\r\n ";   //   加入换行符
            byte[] bWrite = Encoding.Default.GetBytes(str);
            try { netStream.Write(bWrite, 0, bWrite.Length); }
            catch { }
        }

        ///   <summary>
        ///   从流中读取字符
        protected string ReadString(NetworkStream netStream)
        {
            string sp = null;
            byte[] by = new byte[1024];
            int size = netStream.Read(by, 0, by.Length);//   读取数据流
            if (size > 0)
                sp = Encoding.Default.GetString(by);//   转化为String
            return sp;
        }

        ///   <summary>
        ///   发出命令并判断返回信息是否正确
        protected bool Command(NetworkStream netStream, string command, string state)
        {
            string sp = null;
            bool success = false;
            try
            {
                WriteString(netStream, command);//   写入命令
                sp = ReadString(netStream);//   接受返回信息
                if (sp.IndexOf(state) != -1)//   判断状态码是否正确
                    success = true;
            }
            catch { }
            return success;
        }
        ///   <summary>
        ///   字符串编码为Base64
        protected string ToBase64(string str)
        {
            try
            {
                byte[] by = Encoding.Default.GetBytes(str);
                str = Convert.ToBase64String(by);
            }
            catch { }
            return str;
        } 

    }
}
