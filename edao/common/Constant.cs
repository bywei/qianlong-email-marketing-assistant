using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Collections.Specialized;
using System.Collections;
using System.Configuration;

namespace dao.common
{
  public  class Constant
    {
      public static int sendTotal = 0;
      public static int sendFail = 0;

      public static Boolean isLogin = true;
      public static Boolean isEmailVer = false;
      public static Boolean isReg = true;
      public static Boolean isSend = true;

      private static char[] constant = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
      public static string GenerateRandomNumber(int Length) { 
          System.Text.StringBuilder newRandom = new System.Text.StringBuilder(62); 
          Random rd = new Random();
          for (int i = 0; i < Length; i++) { 
              newRandom.Append(constant[rd.Next(62)]);
          } 
          return newRandom.ToString();
      }

      public static string GenerateRandomSymbol() {
          String[] symbol = new String[] { "~", "!", "#", "$", "%", "^", "&", "*", "-", "_", "+", "=", ",", ".", "?", ";", ":", "'", "\"", "[]", "/", "@" }; //符号数组
          Random rd = new Random();
          return symbol[rd.Next(symbol.Length)];
      }

      public static string getIpAddress() {
          string ipAddress = "";
          IPHostEntry ipHostEntry = Dns.Resolve(Environment.MachineName);
          string ipString = ipHostEntry.AddressList[0].ToString();
          System.Net.IPAddress[] ips= ipHostEntry.AddressList;
          System.Net.IPAddress[] addressList = Dns.GetHostByName(Dns.GetHostName()).AddressList;
          if (addressList.Length > 1)
          {
              //本地ip nativeIP.Text = addressList[0].ToString();
              ipAddress = addressList[1].ToString();
          }
          //else
          //{
          //    //nativeIP.Text = addressList[0].ToString();
          //    ipAddress = "Break the line...";
          //}
          if ("".Equals(ipAddress))
          {
            WebClient regWebClient = new WebClient();
            NameValueCollection regValue = new NameValueCollection();
            regValue.Add("getIp", "ip");
            IDictionary getIp = (IDictionary)ConfigurationSettings.GetConfig("getIp");
            byte[] regValueResultByte = regWebClient.UploadValues((string)getIp["url"], "POST", regValue);
            ipAddress = System.Text.Encoding.UTF8.GetString(regValueResultByte);
          }
          return ipAddress;
      }
    }
}
