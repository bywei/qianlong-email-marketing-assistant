using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using dao.common;
using System.Data;
using System.Data.OleDb;

namespace dao
{
   public class AddConfigDao
    {
        private DBUtil dbUtil = new DBUtil();
        public Boolean saveCreate(String no,string fromAddress,string account, string password,int sendCount, string domain, string smtp, string smtpPort,String ssl,String state)
        {
            Boolean result = true;

            String sql = String.Format("insert into efrom(type,account,pwd,state,sendCount,lastDate,createDate,domainName,smtp,smtpPort,ssl,fromAddress) values('{0}','{1}','{2}','{3}',{4},'{5}','{6}','{7}','{8}','{9}','{10}','{11}')", no, account, password, state, sendCount, DateTime.Now, DateTime.Now, domain, smtp, smtpPort, ssl, fromAddress);
            dbUtil.saveData(sql);
            return result;
        }
        public DataSet loadFrom()
        {
            String sql = String.Format("select id,type,fromAddress,account,pwd,state,sendCount,lastDate,createDate,domainName,smtp,smtpPort,ssl from efrom ");
            DataSet fromDs = new DataSet();
            OleDbDataAdapter fromAdapter = new OleDbDataAdapter(sql, DbHelper.dataConn);
            fromAdapter.Fill(fromDs, "efrom");
            return fromDs;
        }


        public Boolean deleteFromById(int emailFromId)
        {
            Boolean result = true;
            String sql = String.Format("delete from efrom where id = {0}",emailFromId);
            dbUtil.saveData(sql);
            return result;
        }

        public Boolean deleteAllFrom( )
        {
            Boolean result = true;
            String sql = String.Format("delete from efrom ");
            dbUtil.saveData(sql);
            return result;
        }

        public DataSet loadFromSend(string type)
        {
            String sql = String.Format("select id,type,fromAddress,account,pwd,state,sendCount,lastDate,createDate,domainName,smtp,smtpPort,ssl from efrom where type='{0}' ",type);
            DataSet fromDs = new DataSet();
            OleDbDataAdapter fromAdapter = new OleDbDataAdapter(sql, DbHelper.dataConn);
            fromAdapter.Fill(fromDs, "efrom");
            return fromDs;
        }

        public Boolean updateFromSend(int id,int sendCount)
        {
            Boolean result = true;
            String sql = String.Format("update efrom set sendCount=sendCount+{0},lastDate='{1}' where id={2} ", sendCount,DateTime.Now, id);
            dbUtil.updateData(sql);
            return result;
        }
    }
}
