using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using dao.common;
using dao.modle;

namespace dao
{
    public class SendConfigDao
    {
        private DBUtil dbUtil = new DBUtil();
        public DataSet loadFromType()
        {
            String sql = String.Format("select distinct(type) from efrom");
            DataSet fromTypeDs = new DataSet();
            OleDbDataAdapter fromTypeAdapter = new OleDbDataAdapter(sql, DbHelper.dataConn);
            fromTypeAdapter.Fill(fromTypeDs, "fromType");
            return fromTypeDs;
        }

        public DataSet loadInboxType()
        {
            String sql = String.Format("select distinct(type) from inbox");
            DataSet inboxType = new DataSet();
            OleDbDataAdapter inboxTypeAdapter = new OleDbDataAdapter(sql, DbHelper.dataConn);
            inboxTypeAdapter.Fill(inboxType, "inboxType");
            return inboxType;
        }

        public Dictionary<String, Object> loadSendConfig()
        {
            Dictionary<String, Object> sendConfig = new Dictionary<string, object>();
            OleDbConnection conn = DbHelper.dataConn;
            conn.Open();
            String sql = String.Format("select id,proxy,sendType,nickName,replay,forwardCount,inboxType,sendCycle,forward,startTime,endTime,sendThreadNum from config");
            OleDbCommand cmd = new OleDbCommand(sql,conn );
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                sendConfig.Add("id", reader["id"]);
                sendConfig.Add("proxy", reader["proxy"]);
                sendConfig.Add("sendType", reader["sendType"]);
                sendConfig.Add("nickName", reader["nickName"]);
                sendConfig.Add("replay", reader["replay"]);
                sendConfig.Add("inboxType", reader["inboxType"]);
                sendConfig.Add("sendCycle", reader["sendCycle"]);
                sendConfig.Add("forwardCount", reader["forwardCount"]);
                sendConfig.Add("forward", reader["forward"]);
                sendConfig.Add("startTime", reader["startTime"]);
                sendConfig.Add("endTime", reader["endTime"]);
                sendConfig.Add("thread", reader["sendThreadNum"]);
            }
            reader.Close();
            DbHelper.closeConn(conn);
            return sendConfig;
        }

        public Config loadConfig()
        {
            Config config = new Config();
            OleDbConnection conn = DbHelper.dataConn;
            conn.Open();
            String sql = String.Format("select id,proxy,sendType,nickName,replay,forwardCount,inboxType,sendCycle,forward,startTime,endTime,sendThreadNum,threadMillisecond,diySendNum,fromSendNum,fromSendNumContinue,failedNum from config");
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                config.Id = int.Parse(reader["id"].ToString());
                config.Proxy=reader["proxy"].ToString();
                config.SendType= reader["sendType"].ToString();
                config.NickName=reader["nickName"].ToString();
                config.Replay= reader["replay"].ToString();
                config.InboxType=reader["inboxType"].ToString();
                config.SendCycle=int.Parse(reader["sendCycle"].ToString());
                config.ForwardCount=int.Parse(reader["forwardCount"].ToString());
                config.Forward= reader["forward"].ToString();
                config.StartTime=DateTime.Parse(reader["startTime"].ToString());
                config.EndTime=DateTime.Parse(reader["endTime"].ToString());
                config.SendThreadNum=int.Parse(reader["sendThreadNum"].ToString());
                config.ThreadMillisecond = int.Parse(reader["threadMillisecond"].ToString());

                config.DiySendNum = int.Parse(reader["diySendNum"].ToString());
                config.FromSendNum = int.Parse(reader["fromSendNum"].ToString());
                String chkFromSendNumContinue=reader["fromSendNumContinue"].ToString();
                if ("true".Equals(chkFromSendNumContinue.ToLower()))
                {
                    config.FromSendNumContinue = true;
                }
                else {
                    config.FromSendNumContinue = false;
                }
              
                config.FailedNum = int.Parse(reader["failedNum"].ToString());
            }
            reader.Close();
            DbHelper.closeConn(conn);
            return config;
        }

        //保存操作
        public Boolean saveSendConfig(Config config)
        {
            Boolean result = true;

            String sql = String.Format("update config set proxy='{0}',sendType='{1}',nickName='{2}',replay='{3}',inboxType='{4}',sendCycle={5},forwardCount={6},forward='{7}',startTime='{8}',endTime='{9}',sendThreadNum={10},threadMillisecond={11},diySendNum={12},fromSendNum={13},fromSendNumContinue='{14}',failedNum={15}",
                config.Proxy, config.SendType, config.NickName, config.Replay, config.InboxType, config.SendCycle, config.ForwardCount, config.Forward, config.StartTime, config.EndTime, config.SendThreadNum,config.ThreadMillisecond,config.DiySendNum,config.FromSendNum,config.FromSendNumContinue,config.FailedNum);
            dbUtil.saveData(sql);
            return result;
        }
    }
}
