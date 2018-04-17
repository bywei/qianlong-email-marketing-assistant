using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using dao.user;
using dao.common;


namespace common
{
    public partial class UserInfoFrm : UserControl
    {
        public UserInfoFrm()
        {
            InitializeComponent();
        }

        #region
        LoginFrm loginFrm = null;
        UserInfoFrm userInfoFrm = null;
        #endregion

        private void UserInfo_Load(object sender, EventArgs e)
        {
            refresh_userInfo();
        }

        public void refresh_userInfo() {
            this.lblusername.Text = InfoHelper.userName;
            this.lblLevel.Text = InfoHelper.userLevel;
            this.lblScore.Text = InfoHelper.userScore;
            if (InfoHelper.isVip)
            {
                this.lblIsvip.Text = "VIP用户";
            }
            else
            {
                this.lblIsvip.Text = "普通用户";
            }
            this.lblCreateDate.Text = InfoHelper.createTime;
            this.lblDeadline.Text = InfoHelper.useOfTime;
            this.lblSendNum.Text = InfoHelper.userSendNum;
            this.lblSendTotal.Text = Constant.sendTotal.ToString();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            InfoHelper.uploadSendNum();
            InfoHelper.islogin = false;
            Application.Exit();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //刷新信息
            InfoHelper.uploadSendNum();
            Constant.sendTotal = 0;
             loginFrm = new LoginFrm();
            loginFrm.getUserInfo();
            refresh_userInfo();
        }
    }
}
