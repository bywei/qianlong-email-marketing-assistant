using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Data.Sql;
using dao.common;
using System.Data.SqlClient;

namespace dao
{
 public class EmailInfoDao
    {
        private DBUtil dbUtil = new DBUtil();
        public Boolean saveCreate_old(String title,String content) {
            Boolean result=true;
            String sql = String.Format("insert into info(title,content,sendCount,lastDate,createDate)  values('{0}','{1}',0,'{2}','{3}')", title, content, DateTime.Now, DateTime.Now);
            dbUtil.saveData(sql);
            return result;
        }
        public Boolean saveCreate(String title, String content)
        {
            Boolean result = false;
            OleDbConnection conn = DbHelper.dataConn;
            conn.Open();
            OleDbCommand cmd = new OleDbCommand("insert into info(title,content,sendCount,lastDate,createDate)  values(@title,@content,0,'" + DateTime.Now + "','" + DateTime.Now + "')", conn);
            cmd.Parameters.Add("@title", title);
            cmd.Parameters.Add("@content", content);
           // cmd.Parameters.Add("@sendCount", 0);
            //cmd.Parameters.Add("@lastDate",DateTime.Now.ToString());
            //cmd.Parameters.Add("@createDate", DateTime.Now.ToString());
            int insertCount = cmd.ExecuteNonQuery();
            if (insertCount > 0)
            {
                result = true;
            }
            DbHelper.closeConn(conn);
            return result;
        }
        public DataSet loadEmailInfo()
        {
         String sql = String.Format("select id,title,content,sendCount,lastDate,createDate from info ");
         DataSet emailInfoDs = new DataSet();
         OleDbDataAdapter emailInfoAdapter = new OleDbDataAdapter(sql, DbHelper.dataConn);
         emailInfoAdapter.Fill(emailInfoDs, "info");
         return emailInfoDs;
     }
        public Dictionary<String,Object> loadEmailInfoById(int id)
        {
            Dictionary<String, Object> emailInfo = new Dictionary<string, object>();
            OleDbConnection conn = DbHelper.dataConn;
            conn.Open();
            String sql = String.Format("select title,content,sendCount,lastDate,createDate from info where id={0}",id);
            OleDbCommand cmd = new OleDbCommand(sql,conn);
            OleDbDataReader reader = cmd.ExecuteReader();
            while(reader.Read()){
                emailInfo.Add("title",reader["title"]);
                emailInfo.Add("content", reader["content"]);
                emailInfo.Add("sendCount",reader["sendCount"]);
                emailInfo.Add("lastDate",reader["lastDate"]);
                emailInfo.Add("createDate",reader["createDate"]);
            }
            reader.Close();
            DbHelper.closeConn(conn);
            return emailInfo;
        }

        public int loadInfoSendCountById(int id)
        {
            int sendCount=0;
            OleDbConnection conn = DbHelper.dataConn;
            conn.Open();
            String sql = String.Format("select title,content,sendCount,lastDate,createDate from info where id={0}", id);
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                sendCount = int.Parse(reader["sendCount"].ToString());
            }
            reader.Close();
            DbHelper.closeConn(conn);
            return sendCount;
        }

        public Boolean updateEmailInfo_old(string title, string content,int id)
        {
            Boolean result = true;
            String sql = String.Format("update info set title='{0}',content='{1}',lastDate='{2}' where id={3}", title, content, DateTime.Now,id);
            dbUtil.saveData(sql);
            return result;
        }

        public Boolean updateEmailInfo(string title, string content, int id)
        {
            Boolean result = false;
            OleDbConnection conn = DbHelper.dataConn;
            conn.Open();
            OleDbCommand cmd = new OleDbCommand(String.Format("update info set title=@title,content=@content,lastDate='" + DateTime.Now + "' where id=@id"), conn);
            cmd.Parameters.Add("@title", title);
            cmd.Parameters.Add("@content", content);
            cmd.Parameters.Add("@id", id);
            int insertCount = cmd.ExecuteNonQuery();
            if (insertCount > 0)
            {
                result = true;
            }
            DbHelper.closeConn(conn);
            return result;
        }

        public Boolean deleteEmailInfoById(int id)
        {
            Boolean result = true;
            String sql = String.Format("delete from info where id = {0} ", id);
            dbUtil.saveData(sql);
            return result;
        }

        public Boolean updateEmailInfoSend(int id, int sendCount)
        {
            Boolean result = true;
            String sql = String.Format("update info set sendCount=sendCount+{0},lastDate='{1}' where id={2} ", sendCount, DateTime.Now, id);
            dbUtil.updateData(sql);
            return result;
        }

    }
}
