using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;
using System.Collections;
using importEmail;
using dao.user;

namespace common
{
    public partial class EmailFrm : Form
    {
        public EmailFrm()
        {
            InitializeComponent();
            try
            {
                //skinEngine.SkinFile = "ByweiEmail.dll";
            }
            catch { }
        }



        private void btnImport_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == this.ofdEmail.ShowDialog())
            {
                String path = ofdEmail.FileName;
                this.txtEmailPath.Text = path;

                    //导入邮件地址
                    FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                    StreamReader reader = new StreamReader(fs);
                    String str = "";
                    while ((str = reader.ReadLine()) != null)
                    {
                        this.listBoxEmail.Items.Add(str);
                    }
                    fs.Close();
            }
        }
        private void btnDataBase_Click(object sender, EventArgs e)
        {
            try
            {
                //从数据库中导入数据
                String isInsql = String.Format("select Email from AllAddress ");
                OleDbCommand isIncmd = new OleDbCommand(isInsql, DbHelper.conn());
                OleDbDataReader reader = isIncmd.ExecuteReader();
                while (reader.Read())
                {
                    this.listBoxEmail.Items.Add(reader["Email"].ToString().Trim());
                }

                reader.Close();
            }
            catch {
                if (DialogResult.Yes == MessageBox.Show("初始化失败！是否联系技术人员？", "百味提示", MessageBoxButtons.YesNo, MessageBoxIcon.Error))
                {
                    System.Diagnostics.Process.Start("http://www.bywei.cn/blog");

                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (chkTxt.Checked == true)
                {
                    ////保存为Txt文件
                    if (DialogResult.OK == sfdTxt.ShowDialog())
                    {
                        FileStream fs = new FileStream(sfdTxt.FileName, FileMode.Append, FileAccess.Write);
                        StreamWriter sw = new StreamWriter(fs);
                        for (int i = 0; i < this.listBoxEmail.Items.Count; i++)
                        {
                            sw.WriteLine(this.listBoxEmail.Items[i].ToString().Trim());
                        }
                        fs.Close();
                        MessageBox.Show("已经成功保存到记事本中！");
                    }
                }




                if (chkMdb.Checked == true)
                {
                    //保存到数据库中
                    int number = 0; //导入失败数量
                    bool result = false;
                    for (int i = 0; i < this.listBoxEmail.Items.Count; i++)
                    {
                        String EmailAddress = this.listBoxEmail.Items[i].ToString().Trim();
                        String isInsql = String.Format("select count(*) from AllAddress where Email='{0}'", EmailAddress);
                        OleDbCommand isIncmd = new OleDbCommand(isInsql, DbHelper.conn());
                        int count = Convert.ToInt32(isIncmd.ExecuteScalar());
                        if (count >= 1)
                        {
                            number++;
                            continue;
                        }
                        String sql = String.Format("insert into AllAddress(Email)  values('{0}')", EmailAddress);
                        OleDbCommand cmd = new OleDbCommand(sql, DbHelper.conn());
                        cmd.ExecuteNonQuery();
                        result = true;

                    }
                    DbHelper.conn().Close();
                    if (result)
                    {
                        MessageBox.Show("成功导入到数据库！");
                    }
                }

                if (chkExcel.Checked == true)
                {
                    //保存到Excel

                }
            }
            catch {
                if (DialogResult.Yes == MessageBox.Show("数据导入失败！是否查看帮助？", "百味提示", MessageBoxButtons.YesNo, MessageBoxIcon.Error))
                {
                    System.Diagnostics.Process.Start("http://www.bywei.cn/blog");

                }
            }

        }

        private void EmailFrm_Load(object sender, EventArgs e)
        {
            try
            {
                LoginFrm lf = new LoginFrm();
                lf.ShowDialog();
                if (DbHelper.islogin)
                {
               
                    DbHelper.conn().Open();
                    DataColumn dc = new DataColumn();
                    dc.ColumnName = "Email";
                    dt.Columns.Add(dc);

                    DataColumn dc2 = new DataColumn("Passward");
                    dt.Columns.Add(dc2);


                    LoadSendAddress();
                    this.Opacity = 1;

                }
                else {
                    Application.Exit();
                }
            }
            catch {
               if(DialogResult.Yes== MessageBox.Show("你的配置错误！是否联系技术人员？","百味提示",MessageBoxButtons.YesNo,MessageBoxIcon.Error))
               {
                 System.Diagnostics.Process.Start("http://www.bywei.cn/blog");
               
               }
            }
        }

        private void LoadSendAddress()
        {
            //加载发件人
            String isInsql = String.Format("select Email,Passward from SendAddress ");
            OleDbCommand isIncmd = new OleDbCommand(isInsql, DbHelper.conn());
            OleDbDataReader reader = isIncmd.ExecuteReader();
            while (reader.Read())
            {
                DataRow dr = dt.NewRow();
                String one = reader["Email"].ToString();
                dr["Email"] = reader["Email"].ToString();
                dr["Passward"] = reader["Passward"].ToString();
                dt.Rows.Add(dr);
            }
            reader.Close();
            this.dgvEmailConfig.DataSource = dt;
        }



        public static int sendNum = 0; //一次发送的数量
       public static int sendScore = 0;//一次发送或得的积分

       public static SortedList dicEmail = new SortedList();//保存所有发件人
        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(this.txtSendTitle.Text.Trim()))
                {
                    MessageBox.Show("请填写邮件标题");
                    return;
                }
                else if (String.IsNullOrEmpty(this.txtSendContent.Text.Trim()))
                {
                    MessageBox.Show("请填写邮件内容");
                    return;
                }
               

                //获取所有发件人
                String allSql = String.Format("select Email,Passward from SendAddress");
                OleDbCommand cmd = new OleDbCommand(allSql, DbHelper.conn());
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    String key = reader["Email"].ToString();
                    String value = reader["Passward"].ToString();
                    dicEmail.Clear();
                    dicEmail.Add(key, value);
                }
                reader.Close();
               
                
                //使用Timer开始发送邮件
                if (this.timerSend.Enabled == true)
                {
                    this.btnSend.Text = "发送邮件";
                    this.timerSend.Enabled = false;
                }
                else {
                    this.btnSend.Text = "正在发送...";
                    this.timerSend.Interval = Convert.ToInt32(this.txtTime.Text.Trim())*1000;
                    this.timerSend.Enabled = true;
                }
              
            }
            catch {
                if (DialogResult.Yes == MessageBox.Show("邮件服务器配置错误！是否查看帮助？", "百味提示", MessageBoxButtons.YesNo, MessageBoxIcon.Error))
                {
                    System.Diagnostics.Process.Start("http://www.bywei.cn/blog");

                }
            }
        }

        private void timerSend_Tick(object sender, EventArgs e)
        {
            //使用Timer控件控制发送邮件
            if (InfoHelper.isVip)
            {
                //开始发送邮件
                SendEmailStart(dicEmail);
            }
            else
            {
                //发送邮件规则  发送一封无广告邮件必须发送一封有广告的邮件
                if (Convert.ToInt32(InfoHelper.userScore) < Convert.ToInt32(InfoHelper.userSendNum))
                {
                    MessageBox.Show("您的积分不够了，请选择赚分模式！或者购买VIP，将无此限制！", "百味提示");
                    timerSend.Enabled = false;
                    return;
                }
                else
                {
                    //开始发送邮件
                    SendEmailStart(dicEmail);
                }
            }

        }

        int sendPerIndex = 0;//发件人索引
        int sendNumIndex = 0;//单个发件数量索引
        private void SendEmailStart(SortedList dicEmail)
        {
            try
            {
                //发送邮件
                //满足一定数量了之后修改发件人（平均分配发件地址到发件邮箱中）
                if (sendNumIndex >= (this.listBoxEmail.Items.Count / dicEmail.Count))
                {
                    sendPerIndex++;
                    sendNumIndex = 0;
                }
                String sendEmailAddress = dicEmail.GetKey(sendPerIndex).ToString(); ;//发件人地址
                String sendEmailPassward = dicEmail.GetByIndex(sendPerIndex).ToString();//发件人密码


                if (sendNum < this.listBoxEmail.Items.Count)
                {
                    String to = this.listBoxEmail.Items[sendNum].ToString();//收件人地址
                    String from = sendEmailAddress;//发件人地址
                    String body = this.txtSendContent.Text.Trim().ToString();
                    if (chkMackMoney.Checked == true)
                    {
                        body += "<br/><br/><br> 本邮件由'百味邮件群发系统发送'本系统适合网络营销使用，强大的邮件服务器支持，海量的邮件地址发送系统！  欢迎光临：程序员百味（http://www.bywei.cn/blog）<br/><a href=\"http://www.35so.bywei.cn/EmailUsers/index.asp?action=ad\"><img src=\"http://www.35so.bywei.cn/EmailUsers/bannerad.jpg\"/></a><br><iframe id=\"baiduSpFrame\" border=\"0\" vspace=\"0\" hspace=\"0\" marginwidth=\"0\" marginheight=\"0\" framespacing=\"0\" frameborder=\"0\" scrolling=\"no\" width=\"940\" height=\"90\" src=\"http://www.35so.bywei.cn/EmailUsers/Emailad.html\"></iframe>";//邮件内容
                        sendScore++;
                    }
                    String title = this.txtSendTitle.Text.Trim().ToString();//邮件标题
                    String password = sendEmailPassward;//发件人密码
                    if (to == "" || from == "" || password == "")
                    {
                    }
                    else
                    {
                        SendMail sendm = new SendMail(to, from, body, title, password);
                        if (this.txtFj.Text.Trim() != "")
                        {
                            sendm.Attachments(this.txtFj.Text);//添加附件
                        }
                        sendm.Send();//执行发送
                        this.listBoxAccess.Items.Add(this.listBoxEmail.Items[sendNum].ToString());//发送成功记录
                    }
                    if (sendNum >= this.listBoxEmail.Items.Count)
                    {
                        this.timerSend.Enabled = false;//发送完所有邮件地址
                        MessageBox.Show("已经发送" + sendNum + "封邮件");
                    }
                    sendNum++;
                    sendNumIndex++;
                }
            }
            catch { }
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            //添加邮件服务器
            this.groupBoxAdd.Visible = true;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            //隐藏邮件增加
            this.groupBoxAdd.Visible = false;
        }

        DataTable dt = new DataTable("EmailConfig");
        private void btnSaveEmail_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtAddEmail.Text.Trim() == "" || this.txtAddPassward.Text.Trim() == "")
                {
                    MessageBox.Show("请输入正确的用户名和密码！");
                }
                else
                {
                    //查询发件人
                    String showEmail = this.txtAddEmail.Text.Trim();
                         //this.dgvEmailConfig.SelectedRows[0].Cells["Email"].Value.ToString();
                     String showSql = String.Format("select count(*) from SendAddress where Email='{0}'",showEmail);
                    OleDbCommand showcmd = new OleDbCommand(showSql, DbHelper.conn());

                    int  hasEmail=Convert.ToInt32(showcmd.ExecuteScalar());
                    if (Convert.ToInt32(showcmd.ExecuteScalar()) > 0 && showEmail != "")
                    {
                        //修改发件人
                        String updateSql = String.Format("update SendAddress set Email='{0}',Passward='{1}' where Email='{2}'", this.txtAddEmail.Text.Trim(), this.txtAddPassward.Text.Trim(), showEmail);
                        OleDbCommand updatecmd = new OleDbCommand(updateSql, DbHelper.conn());
                        updatecmd.ExecuteNonQuery();
                    }
                    else
                    {
                        //保存发件人到数据库中
                        String saveSql = String.Format("insert into SendAddress(Email,Passward) values('{0}','{1}')", this.txtAddEmail.Text.Trim(), this.txtAddPassward.Text.Trim());
                        OleDbCommand cmd = new OleDbCommand(saveSql, DbHelper.conn());
                        cmd.ExecuteNonQuery();

                        //保存发件人（邮件服务器)
                        DataRow dr = dt.NewRow();
                        dr["Email"] = this.txtAddEmail.Text.Trim();
                        dr["Passward"] = this.txtAddPassward.Text.Trim();
                        dt.Rows.Add(dr);
                    }
                    this.groupBoxAdd.Visible = false;
                }
            }
            catch {
                if (DialogResult.Yes == MessageBox.Show("保存数据失败！是否查看帮助？", "百味提示", MessageBoxButtons.YesNo, MessageBoxIcon.Error))
                {
                    System.Diagnostics.Process.Start("http://www.bywei.cn/blog");

                }
            }
        }

        private void btnFj_Click(object sender, EventArgs e)
        {
            //添加附件
            if (DialogResult.OK == ofdEmail.ShowDialog()) {
              this.txtFj.Text=ofdEmail.FileName;
            }

        }

        private void chkTxt_CheckedChanged(object sender, EventArgs e)
        {
            //选中保存方式
            if (chkTxt.Checked == true || chkMdb.Checked == true || chkExcel.Checked == true)
            {
                this.btnSave.Enabled = true;
            }
            else {
                this.btnSave.Enabled = false;
            }
        }

        private void toolsDel_Click(object sender, EventArgs e)
        {
            //删除邮件服务器
            if(this.dgvEmailConfig.SelectedRows.Count>=0){
               String delEmail= this.dgvEmailConfig.SelectedRows[0].Cells["Email"].Value.ToString();
               String delSql = String.Format("delete from SendAddress where Email='{0}'", delEmail);
               OleDbCommand cmd = new OleDbCommand(delSql, DbHelper.conn());
               cmd.ExecuteNonQuery();
               MessageBox.Show("删除成功！");
               dt.Clear();
               LoadSendAddress();
            }
        }


        String userScore = sendScore+"";
        String userSendNum = sendNum+"";
        String userLevel = Convert.ToString(Convert.ToUInt32(InfoHelper.userScore) % 1000);
        private void linkScore_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //查看积分
            LoginFrm loginfrm = new LoginFrm();
            String userName = InfoHelper.userName;
            String userPwd = InfoHelper.userPwd;
            String isVip = "";
            if (InfoHelper.isVip)
            {
                isVip = "true";
            }
            else {
                isVip = "false";
            }
            //传输积分等信息
            //String loginUrl = String.Format("http://www.35so.bywei.cn/emailusers/index.asp?action=update&userScore={0}&userLevel={1}&userSendNum={2}&userIsVip={3}&userName={4}&userPwd={5}", userScore, userLevel, userSendNum, isVip,userName,userPwd);
           // loginfrm.webBrowserReg.Navigate(loginUrl);

            loginfrm.panelLogin.Visible = false;
            loginfrm.Show();

        }

        private void linkLabelHelper_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //查看帮助
            System.Diagnostics.Process.Start("http://www.bywei.cn/blog");
        }
    }
}
