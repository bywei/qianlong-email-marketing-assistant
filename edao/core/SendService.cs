using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.IO;

namespace dao.core
{
   public class SendService
    {
       public static void start() {
           Process[] ps = Process.GetProcesses();
           foreach (Process item in ps)
           {
               if (item.ProcessName == "cmd")
               {
                   item.Kill();
               }
           }
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
                   process.StandardOutput.ReadToEnd();//读取进程的输出
               }
           }
           catch (Exception e)
           {
               // WriteLog("Dos命令" + dosCommand + "执行失败，时间" + DateTime.Now.ToString());
           }
           finally
           {
               if (process != null)
                   process.Close();
           }
       }
    }
}
