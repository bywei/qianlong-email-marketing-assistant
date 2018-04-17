using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace dao
{
    public class Log
    {
        string LogPath;
        string logs;
        public Log(string logs)
        {
           // DateTime dateTime = new DateTime();
           // dateTime.Millisecond;
            this.LogPath = "log/";
            this.logs = logs;
        }

        public void writeLog()
        {
            //输出日志文件
            if (this.LogPath != null)
            {
                FileStream fs = null;
                if (File.Exists(this.LogPath))
                {
                    fs = new FileStream(this.LogPath, FileMode.Append, FileAccess.Write);
                }
                else
                {
                    fs = new FileStream(this.LogPath, FileMode.Create, FileAccess.Write);
                }
                byte[] logPath_b = System.Text.Encoding.GetEncoding("gb2312").GetBytes(this.logs);
                fs.Write(logPath_b, 0, logPath_b.Length);
                fs.Close();
            }
        }
    }
}
