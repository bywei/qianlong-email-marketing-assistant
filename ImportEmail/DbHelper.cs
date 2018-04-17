using System;
using System.Collections.Generic;
using System.Text;
using System.Data.OleDb;

namespace common
{
    public class DbHelper
    {
        public static bool islogin = false;
       
        public static String dbpath = System.IO.Directory.GetCurrentDirectory();
        private static readonly String connStr = String.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbpath + "\\data.mdb");
        public static OleDbConnection conn() {
            OleDbConnection conn=null;
            try { 
              conn= new OleDbConnection(connStr);
              conn.Open();
            }catch(Exception ex){
                System.Windows.Forms.MessageBox.Show("请检查数据库是否正确安装 ："+ex.Message,"提示");
            }
            return conn;
        }
       
    }
}
