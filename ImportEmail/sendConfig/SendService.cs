using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace common.sendConfig
{
    public partial class SendService : Form
    {
        public SendService()
        {
            InitializeComponent();
        }

        string output = ""; //输出字符串
        private delegate void outPutDelegate();
        /// <returns>返回输出，如果发生异常，返回空字符串</returns>
        public void execute()
        {
           Process process = new Process(); //创建进程对象
           ProcessStartInfo startInfo = new ProcessStartInfo();
           startInfo.FileName = "cmd.exe"; //设定需要执行的命令
           startInfo.Arguments = "/C " + Directory.GetCurrentDirectory()+"\\james\\bin\\start.bat"; //设定参数，其中的“/C”表示执行完命令后马上退出
           startInfo.UseShellExecute = false; //不使用系统外壳程序启动
           startInfo.RedirectStandardInput = false; //不重定向输入
           startInfo.RedirectStandardOutput = true; //重定向输出
           startInfo.CreateNoWindow = true; //不创建窗口
           process.StartInfo = startInfo;


                try
                {
                    if (process.Start()) //开始进程
                    {
                        process.WaitForExit(); //这里无限等待进程结束
                        output = process.StandardOutput.ReadToEnd();//读取进程的输出
                        this.textBoxOutput.BeginInvoke(new outPutDelegate(showOutPut));
                    }
                }
                catch (Exception e)
                {
                }
                finally
                {
                    if (process != null)
                        process.Close();
                }
        }

        private void showOutPut() {
            this.textBoxOutput.Text = output;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            System.Threading.Thread sendServiceThread = new System.Threading.Thread(new System.Threading.ThreadStart(execute));
            sendServiceThread.IsBackground = true;
            sendServiceThread.Start();
            this.Visible = false;

        }
    }
}
