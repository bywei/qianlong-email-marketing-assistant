namespace common.sendConfig
{
    partial class SendConfigFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SendConfigFrm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxProxy = new System.Windows.Forms.TextBox();
            this.checkBoxProxy = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxReplayAddress = new System.Windows.Forms.TextBox();
            this.textBoxNickName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxSendType = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.domainUpDownCycle = new System.Windows.Forms.DomainUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxInboxType = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBoxThreadMillisecond = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.checkBoxFromSendNumContinue = new System.Windows.Forms.CheckBox();
            this.textBoxFromSendNum = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.textBoxDiySendNum = new System.Windows.Forms.TextBox();
            this.labelDiySendNum = new System.Windows.Forms.Label();
            this.textBoxFailedNum = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.domainUpDownThread = new System.Windows.Forms.DomainUpDown();
            this.label19 = new System.Windows.Forms.Label();
            this.domainUpDownEndTime = new System.Windows.Forms.DomainUpDown();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.textBoxForward = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.domainUpDownforwardCount = new System.Windows.Forms.DomainUpDown();
            this.domainUpDownStartTime = new System.Windows.Forms.DomainUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxProxy);
            this.groupBox1.Controls.Add(this.checkBoxProxy);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(401, 53);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "邮件代发配置";
            // 
            // textBoxProxy
            // 
            this.textBoxProxy.Location = new System.Drawing.Point(117, 20);
            this.textBoxProxy.Name = "textBoxProxy";
            this.textBoxProxy.ReadOnly = true;
            this.textBoxProxy.Size = new System.Drawing.Size(217, 21);
            this.textBoxProxy.TabIndex = 1;
            // 
            // checkBoxProxy
            // 
            this.checkBoxProxy.AutoSize = true;
            this.checkBoxProxy.Location = new System.Drawing.Point(28, 22);
            this.checkBoxProxy.Name = "checkBoxProxy";
            this.checkBoxProxy.Size = new System.Drawing.Size(72, 16);
            this.checkBoxProxy.TabIndex = 0;
            this.checkBoxProxy.Text = "代发地址";
            this.checkBoxProxy.UseVisualStyleBackColor = true;
            this.checkBoxProxy.CheckedChanged += new System.EventHandler(this.checkBoxProxy_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBoxReplayAddress);
            this.groupBox2.Controls.Add(this.textBoxNickName);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.comboBoxSendType);
            this.groupBox2.Location = new System.Drawing.Point(12, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(401, 104);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "发件账号配置";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(257, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "（回复邮件到此账号）";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(257, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "（显示给收件人的名字）";
            // 
            // textBoxReplayAddress
            // 
            this.textBoxReplayAddress.Location = new System.Drawing.Point(117, 74);
            this.textBoxReplayAddress.Name = "textBoxReplayAddress";
            this.textBoxReplayAddress.Size = new System.Drawing.Size(121, 21);
            this.textBoxReplayAddress.TabIndex = 4;
            // 
            // textBoxNickName
            // 
            this.textBoxNickName.Location = new System.Drawing.Point(117, 47);
            this.textBoxNickName.Name = "textBoxNickName";
            this.textBoxNickName.Size = new System.Drawing.Size(121, 21);
            this.textBoxNickName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "回复邮箱账号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "发件账号昵称";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "发件账号类型";
            // 
            // comboBoxSendType
            // 
            this.comboBoxSendType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSendType.FormattingEnabled = true;
            this.comboBoxSendType.Location = new System.Drawing.Point(117, 20);
            this.comboBoxSendType.Name = "comboBoxSendType";
            this.comboBoxSendType.Size = new System.Drawing.Size(121, 20);
            this.comboBoxSendType.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.domainUpDownCycle);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.textBox4);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.comboBoxInboxType);
            this.groupBox3.Location = new System.Drawing.Point(12, 181);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(401, 104);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "收件账号配置";
            // 
            // domainUpDownCycle
            // 
            this.domainUpDownCycle.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.domainUpDownCycle.Location = new System.Drawing.Point(117, 46);
            this.domainUpDownCycle.Name = "domainUpDownCycle";
            this.domainUpDownCycle.Size = new System.Drawing.Size(52, 23);
            this.domainUpDownCycle.TabIndex = 7;
            this.domainUpDownCycle.Text = "31";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(175, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(173, 12);
            this.label7.TabIndex = 5;
            this.label7.Text = "天内不想同一账号重复发送邮件";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(117, 74);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(121, 21);
            this.textBox4.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 12);
            this.label8.TabIndex = 3;
            this.label8.Text = "收件账号数量";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 12);
            this.label9.TabIndex = 2;
            this.label9.Text = "发送周期设置";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 12);
            this.label10.TabIndex = 1;
            this.label10.Text = "收件账号分类";
            // 
            // comboBoxInboxType
            // 
            this.comboBoxInboxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxInboxType.FormattingEnabled = true;
            this.comboBoxInboxType.Location = new System.Drawing.Point(117, 20);
            this.comboBoxInboxType.Name = "comboBoxInboxType";
            this.comboBoxInboxType.Size = new System.Drawing.Size(121, 20);
            this.comboBoxInboxType.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBoxThreadMillisecond);
            this.groupBox4.Controls.Add(this.label23);
            this.groupBox4.Controls.Add(this.label22);
            this.groupBox4.Controls.Add(this.checkBoxFromSendNumContinue);
            this.groupBox4.Controls.Add(this.textBoxFromSendNum);
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Controls.Add(this.textBoxDiySendNum);
            this.groupBox4.Controls.Add(this.labelDiySendNum);
            this.groupBox4.Controls.Add(this.textBoxFailedNum);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Controls.Add(this.domainUpDownThread);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.domainUpDownEndTime);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.textBoxForward);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.domainUpDownforwardCount);
            this.groupBox4.Controls.Add(this.domainUpDownStartTime);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Location = new System.Drawing.Point(12, 291);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(401, 160);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "其他辅助配置";
            // 
            // textBoxThreadMillisecond
            // 
            this.textBoxThreadMillisecond.Location = new System.Drawing.Point(235, 73);
            this.textBoxThreadMillisecond.Name = "textBoxThreadMillisecond";
            this.textBoxThreadMillisecond.Size = new System.Drawing.Size(68, 21);
            this.textBoxThreadMillisecond.TabIndex = 26;
            this.textBoxThreadMillisecond.Text = "1000";
            this.textBoxThreadMillisecond.TextChanged += new System.EventHandler(this.inputNumber_TextChanged);
            this.textBoxThreadMillisecond.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputNumber_KeyPress);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(305, 104);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(77, 12);
            this.label23.TabIndex = 25;
            this.label23.Text = "封更换发件人";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(204, 103);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(29, 12);
            this.label22.TabIndex = 24;
            this.label22.Text = "失败";
            // 
            // checkBoxFromSendNumContinue
            // 
            this.checkBoxFromSendNumContinue.AutoSize = true;
            this.checkBoxFromSendNumContinue.Location = new System.Drawing.Point(203, 129);
            this.checkBoxFromSendNumContinue.Name = "checkBoxFromSendNumContinue";
            this.checkBoxFromSendNumContinue.Size = new System.Drawing.Size(168, 16);
            this.checkBoxFromSendNumContinue.TabIndex = 23;
            this.checkBoxFromSendNumContinue.Text = "超过限制是否继续循环发送";
            this.checkBoxFromSendNumContinue.UseVisualStyleBackColor = true;
            // 
            // textBoxFromSendNum
            // 
            this.textBoxFromSendNum.Location = new System.Drawing.Point(116, 126);
            this.textBoxFromSendNum.Name = "textBoxFromSendNum";
            this.textBoxFromSendNum.Size = new System.Drawing.Size(74, 21);
            this.textBoxFromSendNum.TabIndex = 22;
            this.textBoxFromSendNum.Text = "50";
            this.textBoxFromSendNum.TextChanged += new System.EventHandler(this.inputNumber_TextChanged);
            this.textBoxFromSendNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputNumber_KeyPress);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(26, 129);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(77, 12);
            this.label21.TabIndex = 21;
            this.label21.Text = "邮箱发送上限";
            // 
            // textBoxDiySendNum
            // 
            this.textBoxDiySendNum.Location = new System.Drawing.Point(117, 100);
            this.textBoxDiySendNum.Name = "textBoxDiySendNum";
            this.textBoxDiySendNum.Size = new System.Drawing.Size(74, 21);
            this.textBoxDiySendNum.TabIndex = 20;
            this.textBoxDiySendNum.Text = "1";
            this.textBoxDiySendNum.TextChanged += new System.EventHandler(this.inputNumber_TextChanged);
            this.textBoxDiySendNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputNumber_KeyPress);
            // 
            // labelDiySendNum
            // 
            this.labelDiySendNum.AutoSize = true;
            this.labelDiySendNum.Location = new System.Drawing.Point(26, 103);
            this.labelDiySendNum.Name = "labelDiySendNum";
            this.labelDiySendNum.Size = new System.Drawing.Size(77, 12);
            this.labelDiySendNum.TabIndex = 19;
            this.labelDiySendNum.Text = "单次发送数量";
            // 
            // textBoxFailedNum
            // 
            this.textBoxFailedNum.Location = new System.Drawing.Point(235, 100);
            this.textBoxFailedNum.Name = "textBoxFailedNum";
            this.textBoxFailedNum.Size = new System.Drawing.Size(68, 21);
            this.textBoxFailedNum.TabIndex = 18;
            this.textBoxFailedNum.Text = "5";
            this.textBoxFailedNum.TextChanged += new System.EventHandler(this.inputNumber_TextChanged);
            this.textBoxFailedNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputNumber_KeyPress);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(156, 77);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(77, 12);
            this.label20.TabIndex = 17;
            this.label20.Text = "发送间隔时间";
            // 
            // domainUpDownThread
            // 
            this.domainUpDownThread.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.domainUpDownThread.Items.Add("1");
            this.domainUpDownThread.Items.Add("2");
            this.domainUpDownThread.Items.Add("3");
            this.domainUpDownThread.Items.Add("4");
            this.domainUpDownThread.Items.Add("5");
            this.domainUpDownThread.Items.Add("6");
            this.domainUpDownThread.Items.Add("7");
            this.domainUpDownThread.Items.Add("8");
            this.domainUpDownThread.Items.Add("9");
            this.domainUpDownThread.Location = new System.Drawing.Point(116, 72);
            this.domainUpDownThread.Name = "domainUpDownThread";
            this.domainUpDownThread.ReadOnly = true;
            this.domainUpDownThread.Size = new System.Drawing.Size(34, 23);
            this.domainUpDownThread.TabIndex = 16;
            this.domainUpDownThread.Text = "1";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(311, 51);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(17, 12);
            this.label19.TabIndex = 15;
            this.label19.Text = "点";
            // 
            // domainUpDownEndTime
            // 
            this.domainUpDownEndTime.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.domainUpDownEndTime.Location = new System.Drawing.Point(239, 46);
            this.domainUpDownEndTime.Name = "domainUpDownEndTime";
            this.domainUpDownEndTime.ReadOnly = true;
            this.domainUpDownEndTime.Size = new System.Drawing.Size(56, 23);
            this.domainUpDownEndTime.TabIndex = 14;
            this.domainUpDownEndTime.Text = "21";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(197, 51);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(35, 12);
            this.label18.TabIndex = 13;
            this.label18.Text = "点 到";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(115, 50);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(17, 12);
            this.label17.TabIndex = 12;
            this.label17.Text = "从";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(364, 23);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(29, 12);
            this.label16.TabIndex = 11;
            this.label16.Text = "发送";
            // 
            // textBoxForward
            // 
            this.textBoxForward.Location = new System.Drawing.Point(237, 17);
            this.textBoxForward.Name = "textBoxForward";
            this.textBoxForward.Size = new System.Drawing.Size(121, 21);
            this.textBoxForward.TabIndex = 7;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(204, 23);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(29, 12);
            this.label15.TabIndex = 10;
            this.label15.Text = "封向";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(115, 23);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 12);
            this.label14.TabIndex = 9;
            this.label14.Text = "每隔";
            // 
            // domainUpDownforwardCount
            // 
            this.domainUpDownforwardCount.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.domainUpDownforwardCount.Location = new System.Drawing.Point(150, 17);
            this.domainUpDownforwardCount.Name = "domainUpDownforwardCount";
            this.domainUpDownforwardCount.Size = new System.Drawing.Size(48, 23);
            this.domainUpDownforwardCount.TabIndex = 8;
            this.domainUpDownforwardCount.Text = "3000";
            // 
            // domainUpDownStartTime
            // 
            this.domainUpDownStartTime.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.domainUpDownStartTime.Location = new System.Drawing.Point(138, 46);
            this.domainUpDownStartTime.Name = "domainUpDownStartTime";
            this.domainUpDownStartTime.ReadOnly = true;
            this.domainUpDownStartTime.Size = new System.Drawing.Size(53, 23);
            this.domainUpDownStartTime.TabIndex = 7;
            this.domainUpDownStartTime.Text = "8";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(308, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "ms (提升速度)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(26, 77);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 12);
            this.label11.TabIndex = 3;
            this.label11.Text = "发送线程设置";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(26, 50);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 12);
            this.label12.TabIndex = 2;
            this.label12.Text = "发送时段设置";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(26, 23);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 12);
            this.label13.TabIndex = 1;
            this.label13.Text = "监控邮箱设置";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(129, 461);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 9;
            this.buttonSave.Text = "确定";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(218, 461);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 10;
            this.buttonClose.Text = "关闭";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // SendConfigFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 497);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(433, 534);
            this.MinimizeBox = false;
            this.Name = "SendConfigFrm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "发件配置";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.SendConfigFrm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxProxy;
        private System.Windows.Forms.CheckBox checkBoxProxy;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxSendType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxReplayAddress;
        private System.Windows.Forms.TextBox textBoxNickName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DomainUpDown domainUpDownCycle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBoxInboxType;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DomainUpDown domainUpDownThread;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DomainUpDown domainUpDownEndTime;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBoxForward;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DomainUpDown domainUpDownforwardCount;
        private System.Windows.Forms.DomainUpDown domainUpDownStartTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.TextBox textBoxFailedNum;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label labelDiySendNum;
        private System.Windows.Forms.TextBox textBoxDiySendNum;
        private System.Windows.Forms.TextBox textBoxFromSendNum;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.CheckBox checkBoxFromSendNumContinue;
        private System.Windows.Forms.TextBox textBoxThreadMillisecond;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
    }
}