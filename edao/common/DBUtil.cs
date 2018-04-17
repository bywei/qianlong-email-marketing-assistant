using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;

namespace dao.common
{
  public  class DBUtil
    {
      private OleDbConnection conn = null;
        /// <summary>
        /// 保存到数据库
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public Boolean saveData(String sql) {
            Boolean result = false;
            conn = DbHelper.conn();
            OleDbCommand cmd = new OleDbCommand(sql,conn);
            int insertCount=cmd.ExecuteNonQuery();
            if (insertCount>0)
            {
                result = true;
            }
            DbHelper.closeConn(conn);
            return result;
        }

        public OleDbDataReader selectData(String sql) {
            conn = DbHelper.conn();
            String isInsql = String.Format(sql);
            OleDbCommand isIncmd = new OleDbCommand(isInsql, DbHelper.conn());
            OleDbDataReader reader = isIncmd.ExecuteReader();
            reader.Close();
            DbHelper.closeConn(conn);
            return reader;
        }

        public Boolean updateData(String sql)
        {
            Boolean result = false;
            conn = DbHelper.conn();
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            int insertCount = cmd.ExecuteNonQuery();
            if (insertCount > 0)
            {
                result = true;
            }
            DbHelper.closeConn(conn);
            return result;
        }
    }
}
