using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Net;
using System.Collections.Specialized;

namespace dao.user
{
  public  class InfoHelper
    {
      public static String permissions = "";
      public static bool islogin = false;
      public static bool isVip = false;
      public static String userId = "";
      public static String userName = "0";
      public static String userPwd = "0";
      public static String userScore = "0";
      public static String userLevel = "0";
      public static String userSendNum = "0";
      public static String userState = "1";
      public static String userType = "1";
      public static String createTime = "";
      public static String useOfTime = "";

      public static void userDomain() { 
          
      }

      public static void uploadSendNum() {
          //上传发送数据
          //if (dao.common.Constant.sendTotal>0)
          //{
          WebClient regWebClient = new WebClient();
          NameValueCollection regValue = new NameValueCollection();
          regValue.Add("action", "update");
          regValue.Add("userId", InfoHelper.userId);
          regValue.Add("UserSendNum", (dao.common.Constant.sendTotal).ToString());
          byte[] regValueResultByte = regWebClient.UploadValues(InfoHelper.permissions, "POST", regValue);
          string regValueResult = System.Text.Encoding.UTF8.GetString(regValueResultByte);
       //   }
      }
    }
}
