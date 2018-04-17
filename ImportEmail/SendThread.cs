using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace common
{
    public partial class SendThread : Form
    {
        public SendThread()
        {
            InitializeComponent();
        }
        //从inbox中计算
        public static int sendNum = 60;  //发件总数

        //系统变量
        public static int sendCount = 0;  //总共发了多少封邮件
        public static int fromSendCount = 0;//用来统计单个邮箱已发送的邮件数量，超过fromSendNum 之后重置为零
        public static int fromIndex = 0;  //发件人的索引
        public static int inboxIndex = 0;  //收件人的索引

        //用户设置变量
        public static int diySendNum = 3; //用户自定义的单次发送数量
        public static int fromSendNum = 20; //用户定义的每个邮箱最多可以发送的邮件数量，如果为0采用平均分配
        public static int sendThreadNum=9; //用户自定义的发送线程数量，如果为0 则创建inbox个线程

        Thread sendStartThread; //主线程
        private void button1_Click(object sender, EventArgs e)
        {
            //开始发送  创建主线程
            sendStartThread = new Thread(new ThreadStart(sendStartThreadMethod));
            sendStartThread.IsBackground = true;
            sendStartThread.Start();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //暂停线程
            if (sendStartThread.IsAlive)
            {
                sendStartThread.Suspend();
            }
            MessageBox.Show(sendStartThread.ThreadState.ToString());
        }
        public void sendStartThreadMethod() {
 
            Thread[] sendThread=new Thread[sendThreadNum];
            //生成sendThreadNum 个子线程
            for (int i = 0; i <sendThread.Length ;i++ )
            {
                //新线程
                sendThread[i] = new Thread(new ThreadStart(sendMainThreadMethod));
                sendThread[i].Name = "th"+i;
                sendThread[i].IsBackground = true;
                sendThread[i].Start();
            }
        
        }

        public void sendMainThreadMethod() {
          while(true){
               //如果发送了的邮件大于发送总数就退出
               if (sendCount >= sendNum)
               {
                   break;
               }
            lock (this)
            {
                //超过用户自定义的发送邮件数量之后就更换发件人邮箱
                //如果用户没有自定义邮件发送邮件数量=>采用平均分配
                if (fromSendCount>=fromSendNum)
                {
                    fromIndex += 1;//收件人索引
                    fromSendCount = 0;
                }
              
                inboxIndex += 3; //收件人索引

                sendCount++;//总共发了多少封邮件
                fromSendCount++;//单个邮箱发了多少封邮件
            }
            MessageBox.Show(sendStartThread.ThreadState.ToString());
            MessageBox.Show(Thread.CurrentThread.Name + "中 " + fromIndex + " 发送了：" + sendCount + "封邮件 -:" + (inboxIndex - 3) + ":" + (inboxIndex - 2) + ":" + (inboxIndex - 1));
            Thread.Sleep(1000);

             // if(inboxIndex>=10){
                //  if (sendStartThread.IsAlive)
                //  {
                ///      sendStartThread.Suspend();
                //  }
           //   }
           }
        }

     
    }
}
