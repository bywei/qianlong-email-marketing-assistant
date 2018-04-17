using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dao.modle
{
   public class Config
    {
        int id = 0;
        string proxy = "";
        string sendType;
        string nickName = "";
        string replay = "";
        string inboxType = "";
        int sendCycle;
        int forwardCount;
        string forward;
        DateTime startTime;
        DateTime endTime;
        int sendThreadNum = 9;
        int threadMillisecond = 1000;
        int diySendNum = 1;
        int fromSendNum = 500;
        bool fromSendNumContinue = true;
        int failedNum = 5;

       public int Id
       {
           get { return id; }
           set { id = value; }
       }
       public string Proxy
       {
           get { return proxy; }
           set { proxy = value; }
       }
       public string SendType
       {
           get { return sendType; }
           set { sendType = value; }
       }
       public string NickName
       {
           get { return nickName; }
           set { nickName = value; }
       }
       public string Replay
       {
           get { return replay; }
           set { replay = value; }
       }

       public string InboxType
       {
           get { return inboxType; }
           set { inboxType = value; }
       }
       public int SendCycle
       {
           get { return sendCycle; }
           set { sendCycle = value; }
       }
       public int ForwardCount
       {
           get { return forwardCount; }
           set { forwardCount = value; }
       }
       public string Forward
       {
           get { return forward; }
           set { forward = value; }
       }
       public DateTime StartTime
       {
           get { return startTime; }
           set { startTime = value; }
       }

       public DateTime EndTime
       {
           get { return endTime; }
           set { endTime = value; }
       }
       public int SendThreadNum
       {
           get { return sendThreadNum; }
           set { sendThreadNum = value; }
       }
       public int ThreadMillisecond
       {
           get { return threadMillisecond; }
           set { threadMillisecond = value; }
       }
       public int DiySendNum
       {
           get { return diySendNum; }
           set { diySendNum = value; }
       }

       public int FromSendNum
       {
           get { return fromSendNum; }
           set { fromSendNum = value; }
       }
       public bool FromSendNumContinue
       {
           get { return fromSendNumContinue; }
           set { fromSendNumContinue = value; }
       }

       public int FailedNum
       {
           get { return failedNum; }
           set { failedNum = value; }
       }
    }
}
