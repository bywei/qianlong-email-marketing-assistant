using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dao
{
  public  class SendMailDao
    {
        SendConfigDao sendConfigDao = new SendConfigDao();
        AddConfigDao addConfigDao = new AddConfigDao();
        EmailInfoDao emailInfoDao = new EmailInfoDao();
        InboxDao inboxDao = new InboxDao();

      public void updateSend(){
          addConfigDao.updateFromSend(1,1);
      }
    }
}
