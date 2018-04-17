using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using dao;
using dao.common;
using dao.modle;

namespace common.sendConfig
{
    public partial class SendConfigFrm : Form
    {
        public SendConfigFrm()
        {
            InitializeComponent();
        }
        public MainForm mainForm;
        SendConfigDao sendConfigDao = new SendConfigDao();
        private void SendConfigFrm_Load(object sender, EventArgs e)
        {
            this.comboBoxSendType.DataSource = sendConfigDao.loadFromType().Tables["fromType"];
            this.comboBoxSendType.DisplayMember = "type";
            this.comboBoxSendType.ValueMember = "type";

            this.comboBoxInboxType.DataSource = sendConfigDao.loadInboxType().Tables["inboxType"];
            this.comboBoxInboxType.DisplayMember = "type";
            this.comboBoxInboxType.ValueMember = "type";

            Config config = sendConfigDao.loadConfig();

            if (!"".Equals(config.Proxy))
            {
                this.checkBoxProxy.Checked = true;
                this.textBoxProxy.ReadOnly = false;
                this.textBoxProxy.Text = config.Proxy;
            }
            this.comboBoxSendType.Text = config.SendType;
            this.textBoxNickName.Text = config.NickName;
            this.domainUpDownforwardCount.Text = config.ForwardCount.ToString();
            this.textBoxReplayAddress.Text = config.Replay;
            this.comboBoxInboxType.Text = config.InboxType;
            this.domainUpDownCycle.Text = config.SendCycle.ToString();
            for (int i = 0; i <= 31;i++ ) {
                this.domainUpDownCycle.Items.Add(i);
            }
            this.textBoxForward.Text = config.Forward;

            this.domainUpDownStartTime.Text = config.StartTime.Hour.ToString();
            for (int i = 0; i < 24; i++)
            {
                this.domainUpDownStartTime.Items.Add(i);
            }
            this.domainUpDownEndTime.Text = config.EndTime.Hour.ToString();
            for (int i = 0; i < 24; i++)
            {
                this.domainUpDownEndTime.Items.Add(i);
            }

            this.domainUpDownThread.Text = config.SendThreadNum.ToString();
            for (int i = 0; i < 10; i++)
            {
                this.domainUpDownThread.Items.Add(i);
            }
            this.textBoxThreadMillisecond.Text = config.ThreadMillisecond.ToString();
            this.textBoxDiySendNum.Text = config.DiySendNum.ToString();
            this.textBoxFailedNum.Text = config.FailedNum.ToString();
            this.textBoxFromSendNum.Text = config.FromSendNum.ToString();
            this.checkBoxFromSendNumContinue.Checked = config.FromSendNumContinue;

        }
        //保存配置
        private void buttonSave_Click(object sender, EventArgs e)
        {
            Config config = new Config();
            Boolean checkBoxProxy = this.checkBoxProxy.Checked;
            config.Proxy = this.textBoxProxy.Text.Trim();
            config.SendType = this.comboBoxSendType.Text.Trim();
            config.NickName = this.textBoxNickName.Text.Trim();
            config.Replay = this.textBoxReplayAddress.Text.Trim();
            config.InboxType = this.comboBoxInboxType.Text.Trim();
            
            String SendCycle =this.domainUpDownCycle.Text.Trim();
            String ForwardCount =this.domainUpDownforwardCount.Text.Trim();

            config.Forward = this.textBoxForward.Text.Trim();
            String startTime = this.domainUpDownStartTime.Text.Trim();
            String endTime = this.domainUpDownEndTime.Text.Trim();
            String date = DateTime.Now.Date.ToString();
            String rep=date.Substring(0, date.IndexOf(" "));
            startTime = rep +" "+startTime + ":00:00";
            endTime = rep + " " + endTime + ":00:00";
            config.StartTime = DateTime.Parse(startTime);
            config.EndTime = DateTime.Parse(endTime);

            String SendThreadNum =this.domainUpDownThread.Text.Trim();
            String ThreadMillisecond=this.textBoxThreadMillisecond.Text.Trim();
            String DiySendNum=this.textBoxDiySendNum.Text.Trim();
            String FromSendNum=this.textBoxFromSendNum.Text.Trim();

            config.FromSendNumContinue=this.checkBoxFromSendNumContinue.Checked;

            String FailedNum =this.textBoxFailedNum.Text.Trim();
            Boolean isCheck = check(config, checkBoxProxy, SendCycle, ForwardCount, SendThreadNum, ThreadMillisecond, DiySendNum, FromSendNum,FailedNum);
            if (isCheck)
            {
                config.SendCycle = int.Parse(SendCycle);
                config.ForwardCount = int.Parse(ForwardCount);
                config.SendThreadNum = int.Parse(SendThreadNum);
                config.ThreadMillisecond = int.Parse(ThreadMillisecond);
                config.DiySendNum = int.Parse(DiySendNum);
                config.FromSendNum = int.Parse(FromSendNum);
                //保存操作
                sendConfigDao.saveSendConfig(config);
                mainForm.loadSendConfig();
                this.Close();
            }
        }

        //检查配置
        private Boolean check(Config config, Boolean checkBoxProxy, String SendCycle, String ForwardCount, String SendThreadNum, String ThreadMillisecond, String DiySendNum, String FromSendNum,String FailedNum)
        {
            Boolean result = false;
            String msg = "";
            ChkUtil chkUtil = new ChkUtil();
            if (checkBoxProxy)
            {
                if ("".Equals(config.Proxy))
                {
                    msg = "如果您使用了代发邮件，请填写代发邮件地址";
                }
                else if (!chkUtil.validateEmail(config.Proxy))
                {
                    msg = "请输入正确的回复邮箱地址";
                }
            }
            if ("".Equals(config.SendType))
            {
                msg = "请填写发送类型";
            }
            if ("".Equals(config.NickName))
            {
                msg = "请填写昵称";
            }
            if ("".Equals(config.Replay))
            {
                msg = "请填写回复地址";
            }
            else if (!chkUtil.validateEmail(config.Replay))
            {
                msg = "请输入正确的回复邮箱地址";
            }
            if ("".Equals(config.InboxType))
            {
                msg = "请填写收件邮箱";
            }
            if ("".Equals(SendCycle))
            {
                msg = "请输入发件周期";
                if (!chkUtil.validateNum(SendCycle))
                {
                    msg = "输入的發件周期必须为数字";
                }
            }

            if (!"".Equals(config.Forward))
            {
                if ("".Equals(ForwardCount))
                {
                    msg = "请输入转发邮件周期";
                }
                else if (!chkUtil.validateNum(ForwardCount))
                {
                    msg = "输入的线程转发邮件周期必须为数字";
                }
                if (!chkUtil.validateEmail(config.Forward))
                {
                    msg = "请输入正确的转发邮件地址";
                }
            }

            if ("".Equals(SendThreadNum))
            {
                msg = "请输入线程数量";
            }
            if (!chkUtil.validateNum(SendThreadNum))
            {
                msg = "输入的线程数量必须为0-9的数字";
            }
            if ("".Equals(config.StartTime.ToString()))
            {
                msg = "开始时间不能为空";
            }
            if ("".Equals(config.EndTime.ToString()))
            {
                msg = "结束时间不能为空";
            }
            if ("".Equals(ThreadMillisecond))
            {
                msg = "线程间隔时间不能为空";
            }
            if ("".Equals(DiySendNum))
            {
                msg = "单次发送数量不能为空";
            }
            if ("".Equals(FromSendNum))
            {
                msg = "邮箱发送上限不能为空";
            }
            if ("".Equals(FailedNum)) {
                msg = "失败后更换发件人数量不能为空";
            }


            if (msg == "")
            {
                result = true;
            }
            else
            {
                MessageBox.Show(msg, "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return result;
        }
        //关闭
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBoxProxy_CheckedChanged(object sender, EventArgs e)
        {
            Boolean isChecked = this.checkBoxProxy.Checked;
            if (!isChecked)
            {
                this.textBoxProxy.Text = "";
                this.textBoxProxy.ReadOnly = true;
            }
            else {
                this.textBoxProxy.ReadOnly = false;
            }
        }

        private void inputNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsNumber(e.KeyChar) || e.KeyChar == (char)8 || e.KeyChar == '.');
            if (!e.Handled) { this.Tag = this.Text; }//记录最后一次正确输入   
            base.OnKeyPress(e);
        }

        private void inputNumber_TextChanged(object sender, EventArgs e)
        {
            if ("".Equals((sender as TextBox).Text.Trim()))
            {
                MessageBox.Show("此选项不能为空","提示");
            }
        }
    }
}
