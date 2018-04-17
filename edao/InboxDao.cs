using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using dao.common;
using System.Data;
using System.Data.OleDb;

namespace dao
{
   public class InboxDao
    {
        private DBUtil dbUtil = new DBUtil();
        public Boolean saveInbox(String type,String address,String nickName,String state)
        {
            Boolean result = true;
            String sql = String.Format("insert into inbox(type,address,nickName,state,sendCount,lastDate,createDate)  values('{0}','{1}','{2}','{3}',{4},'{5}','{6}')", type, address, nickName,state,0,DateTime.Now,DateTime.Now);
            dbUtil.saveData(sql);
            return result;
        }
        public DataSet loadInbox()
        {
            String sql = String.Format("select id,type,address,nickName,state,sendCount,lastDate,createDate from inbox ");
            DataSet inboxDs = new DataSet();
            OleDbDataAdapter inboxAdapter = new OleDbDataAdapter(sql, DbHelper.dataConn);
            inboxAdapter.Fill(inboxDs, "inbox");
            return inboxDs;
        }

        public Boolean deleteInboxById(int inboxId)
        {
            Boolean result = true;
            String sql = String.Format("delete from inbox where id = {0}",inboxId);
            dbUtil.saveData(sql);
            return result;
        }

        public Boolean deleteAllInbox( )
        {
            Boolean result = true;
            String sql = String.Format("delete from inbox ");
            dbUtil.saveData(sql);
            return result;
        }

        public Boolean deleteInboxByFailed()
        {
            Boolean result = true;
            String sql = String.Format("delete from inbox where state='false' ");
            dbUtil.saveData(sql);
            return result;
        }

        public Boolean deleteInboxByAccess() {
            Boolean result = true;
            String sql = String.Format("delete from inbox where state='true' ");
            dbUtil.saveData(sql);
            return result;
        }

        public DataSet loadInboxSend(string type)
        {
            String sql = String.Format("select id,type,address,nickName,state,sendCount,lastDate,createDate from inbox where type='{0}' ",type);
            DataSet inboxDs = new DataSet();
            OleDbDataAdapter inboxAdapter = new OleDbDataAdapter(sql, DbHelper.dataConn);
            inboxAdapter.Fill(inboxDs, "inbox");
            return inboxDs;
        }

        public Boolean updateInboxSend(int id, int sendCount)
        {
            Boolean result = true;
            String sql = String.Format("update inbox set state='true',sendCount=sendCount+{0},lastDate='{1}' where id={2} ", sendCount, DateTime.Now, id);
            dbUtil.updateData(sql);
            return result;
        }

        public Boolean updateInboxFailed(int id)
        {
            Boolean result = true;
            String sql = String.Format("update inbox set state='false',lastDate='{0}' where id={1} ", DateTime.Now, id);
            dbUtil.updateData(sql);
            return result;
        }
    }
}
