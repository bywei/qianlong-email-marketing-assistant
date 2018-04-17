using System;
using System.Collections.Generic;
using System.Text;

namespace common
{
   public class MainFormChk
    {
      public  string startSendChk(int threadCount, int inboxCount, int fromCount)
       {
           string msg = "";
           if (threadCount <= 0)
           {
               msg = "发送邮件之前请先配置邮件发送线程";
           }
           else if (inboxCount <= 0)
           {
               msg = "发送邮件之前请先添加收件人";
           }
           else if (fromCount <= 0)
           {
               msg = "发送邮件之前请先添加发件人";
           }
           return msg;
       }
    }
}
