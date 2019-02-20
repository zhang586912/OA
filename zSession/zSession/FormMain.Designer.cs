namespace zSession
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.tpMain = new System.Windows.Forms.TableLayoutPanel();
            this.tpTop = new System.Windows.Forms.TableLayoutPanel();
            this.tpHeader = new System.Windows.Forms.TableLayoutPanel();
            this.picPerson = new System.Windows.Forms.PictureBox();
            this.flpVIP = new System.Windows.Forms.FlowLayoutPanel();
            this.picWorkStatus = new System.Windows.Forms.PictureBox();
            this.ctMSWorkStatus = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiFree = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBusyness = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNoDisturb = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLeave = new System.Windows.Forms.ToolStripMenuItem();
            this.lblWorkStatus = new System.Windows.Forms.Label();
            this.flpMessage = new System.Windows.Forms.FlowLayoutPanel();
            this.ctMSMessage = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiProject = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiJournal = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSession = new System.Windows.Forms.ToolStripMenuItem();
            this.projectPanel1 = new zSession.Assistant.project.ProjectPanel();
            this.picWeatherStatus = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tsTitle = new System.Windows.Forms.ToolStrip();
            this.tslAccount = new System.Windows.Forms.ToolStripLabel();
            this.tsbExit = new System.Windows.Forms.ToolStripButton();
            this.tsbMin = new System.Windows.Forms.ToolStripButton();
            this.tsbSetup = new System.Windows.Forms.ToolStripButton();
            this.tsbMail = new System.Windows.Forms.ToolStripButton();
            this.tsbJournal = new System.Windows.Forms.ToolStripButton();
            this.tsbProject = new System.Windows.Forms.ToolStripButton();
            this.tsbTools = new System.Windows.Forms.ToolStripButton();
            this.picNetStatus = new System.Windows.Forms.PictureBox();
            this.ctMSConnectStatus = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiConnect = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDisconnect = new System.Windows.Forms.ToolStripMenuItem();
            this.tpBody = new System.Windows.Forms.TableLayoutPanel();
            this.btnChat = new System.Windows.Forms.Button();
            this.btnAssistant = new System.Windows.Forms.Button();
            this.btnSocialNet = new System.Windows.Forms.Button();
            this.panelBody = new System.Windows.Forms.Panel();
            this.btnMarket = new System.Windows.Forms.Button();
            this.btnNews = new System.Windows.Forms.Button();
            this.tsMain = new System.Windows.Forms.ToolStrip();
            this.tsbDeviceManagement = new System.Windows.Forms.ToolStripButton();
            this.tsbApplicationCenter = new System.Windows.Forms.ToolStripButton();
            this.tsbGameCenter = new System.Windows.Forms.ToolStripButton();
            this.tsbWareMarket = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.bgkInit = new System.ComponentModel.BackgroundWorker();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.ctMStray = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiShow = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tpMain.SuspendLayout();
            this.tpTop.SuspendLayout();
            this.tpHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPerson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWorkStatus)).BeginInit();
            this.ctMSWorkStatus.SuspendLayout();
            this.flpMessage.SuspendLayout();
            this.ctMSMessage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picWeatherStatus)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tsTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNetStatus)).BeginInit();
            this.ctMSConnectStatus.SuspendLayout();
            this.tpBody.SuspendLayout();
            this.tsMain.SuspendLayout();
            this.ctMStray.SuspendLayout();
            this.SuspendLayout();
            // 
            // tpMain
            // 
            this.tpMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tpMain.BackgroundImage")));
            this.tpMain.ColumnCount = 1;
            this.tpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpMain.Controls.Add(this.tpTop, 0, 0);
            this.tpMain.Controls.Add(this.tpBody, 0, 1);
            this.tpMain.Controls.Add(this.tsMain, 0, 2);
            this.tpMain.Location = new System.Drawing.Point(0, 0);
            this.tpMain.Name = "tpMain";
            this.tpMain.RowCount = 3;
            this.tpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tpMain.Size = new System.Drawing.Size(464, 815);
            this.tpMain.TabIndex = 1;
            // 
            // tpTop
            // 
            this.tpTop.BackColor = System.Drawing.Color.Transparent;
            this.tpTop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tpTop.BackgroundImage")));
            this.tpTop.ColumnCount = 1;
            this.tpTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpTop.Controls.Add(this.tpHeader, 0, 1);
            this.tpTop.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tpTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpTop.Location = new System.Drawing.Point(0, 0);
            this.tpTop.Margin = new System.Windows.Forms.Padding(0);
            this.tpTop.Name = "tpTop";
            this.tpTop.RowCount = 2;
            this.tpTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tpTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tpTop.Size = new System.Drawing.Size(464, 200);
            this.tpTop.TabIndex = 4;
            // 
            // tpHeader
            // 
            this.tpHeader.BackColor = System.Drawing.Color.Transparent;
            this.tpHeader.ColumnCount = 4;
            this.tpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tpHeader.Controls.Add(this.picPerson, 2, 1);
            this.tpHeader.Controls.Add(this.flpVIP, 2, 0);
            this.tpHeader.Controls.Add(this.picWorkStatus, 2, 3);
            this.tpHeader.Controls.Add(this.lblWorkStatus, 3, 3);
            this.tpHeader.Controls.Add(this.flpMessage, 1, 0);
            this.tpHeader.Controls.Add(this.picWeatherStatus, 0, 1);
            this.tpHeader.Controls.Add(this.label2, 0, 0);
            this.tpHeader.Controls.Add(this.label3, 0, 2);
            this.tpHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpHeader.Location = new System.Drawing.Point(0, 30);
            this.tpHeader.Margin = new System.Windows.Forms.Padding(0);
            this.tpHeader.Name = "tpHeader";
            this.tpHeader.RowCount = 4;
            this.tpHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tpHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tpHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tpHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tpHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tpHeader.Size = new System.Drawing.Size(464, 170);
            this.tpHeader.TabIndex = 4;
            // 
            // picPerson
            // 
            this.picPerson.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpHeader.SetColumnSpan(this.picPerson, 2);
            this.picPerson.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picPerson.Location = new System.Drawing.Point(368, 30);
            this.picPerson.Margin = new System.Windows.Forms.Padding(0);
            this.picPerson.Name = "picPerson";
            this.tpHeader.SetRowSpan(this.picPerson, 2);
            this.picPerson.Size = new System.Drawing.Size(96, 114);
            this.picPerson.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPerson.TabIndex = 0;
            this.picPerson.TabStop = false;
            // 
            // flpVIP
            // 
            this.tpHeader.SetColumnSpan(this.flpVIP, 2);
            this.flpVIP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpVIP.Location = new System.Drawing.Point(368, 0);
            this.flpVIP.Margin = new System.Windows.Forms.Padding(0);
            this.flpVIP.Name = "flpVIP";
            this.flpVIP.Size = new System.Drawing.Size(96, 30);
            this.flpVIP.TabIndex = 1;
            // 
            // picWorkStatus
            // 
            this.picWorkStatus.ContextMenuStrip = this.ctMSWorkStatus;
            this.picWorkStatus.Image = global::zSession.Properties.Resources.phone_blue;
            this.picWorkStatus.Location = new System.Drawing.Point(370, 146);
            this.picWorkStatus.Margin = new System.Windows.Forms.Padding(2);
            this.picWorkStatus.Name = "picWorkStatus";
            this.picWorkStatus.Size = new System.Drawing.Size(22, 22);
            this.picWorkStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picWorkStatus.TabIndex = 3;
            this.picWorkStatus.TabStop = false;
            // 
            // ctMSWorkStatus
            // 
            this.ctMSWorkStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFree,
            this.tsmiBusyness,
            this.tsmiNoDisturb,
            this.tsmiLeave});
            this.ctMSWorkStatus.Name = "ctMSWorkStatus";
            this.ctMSWorkStatus.Size = new System.Drawing.Size(101, 92);
            // 
            // tsmiFree
            // 
            this.tsmiFree.Name = "tsmiFree";
            this.tsmiFree.Size = new System.Drawing.Size(100, 22);
            this.tsmiFree.Text = "空闲";
            // 
            // tsmiBusyness
            // 
            this.tsmiBusyness.Name = "tsmiBusyness";
            this.tsmiBusyness.Size = new System.Drawing.Size(100, 22);
            this.tsmiBusyness.Text = "忙碌";
            // 
            // tsmiNoDisturb
            // 
            this.tsmiNoDisturb.Name = "tsmiNoDisturb";
            this.tsmiNoDisturb.Size = new System.Drawing.Size(100, 22);
            this.tsmiNoDisturb.Text = "勿扰";
            // 
            // tsmiLeave
            // 
            this.tsmiLeave.Name = "tsmiLeave";
            this.tsmiLeave.Size = new System.Drawing.Size(100, 22);
            this.tsmiLeave.Text = "离开";
            // 
            // lblWorkStatus
            // 
            this.lblWorkStatus.AutoSize = true;
            this.lblWorkStatus.ContextMenuStrip = this.ctMSWorkStatus;
            this.lblWorkStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWorkStatus.Font = new System.Drawing.Font("仿宋", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblWorkStatus.ForeColor = System.Drawing.Color.Black;
            this.lblWorkStatus.Location = new System.Drawing.Point(397, 147);
            this.lblWorkStatus.Margin = new System.Windows.Forms.Padding(3);
            this.lblWorkStatus.Name = "lblWorkStatus";
            this.lblWorkStatus.Size = new System.Drawing.Size(64, 20);
            this.lblWorkStatus.TabIndex = 4;
            this.lblWorkStatus.Text = "空闲";
            this.lblWorkStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flpMessage
            // 
            this.flpMessage.AutoSize = true;
            this.flpMessage.ContextMenuStrip = this.ctMSMessage;
            this.flpMessage.Controls.Add(this.projectPanel1);
            this.flpMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpMessage.Location = new System.Drawing.Point(63, 3);
            this.flpMessage.Name = "flpMessage";
            this.tpHeader.SetRowSpan(this.flpMessage, 4);
            this.flpMessage.Size = new System.Drawing.Size(302, 164);
            this.flpMessage.TabIndex = 7;
            // 
            // ctMSMessage
            // 
            this.ctMSMessage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiProject,
            this.tsmiJournal,
            this.tsmiSession});
            this.ctMSMessage.Name = "ctMSMessage";
            this.ctMSMessage.Size = new System.Drawing.Size(125, 70);
            // 
            // tsmiProject
            // 
            this.tsmiProject.Name = "tsmiProject";
            this.tsmiProject.Size = new System.Drawing.Size(124, 22);
            this.tsmiProject.Text = "到期项目";
            // 
            // tsmiJournal
            // 
            this.tsmiJournal.Image = global::zSession.Properties.Resources.ok;
            this.tsmiJournal.Name = "tsmiJournal";
            this.tsmiJournal.Size = new System.Drawing.Size(124, 22);
            this.tsmiJournal.Text = "到期日程";
            // 
            // tsmiSession
            // 
            this.tsmiSession.Name = "tsmiSession";
            this.tsmiSession.Size = new System.Drawing.Size(124, 22);
            this.tsmiSession.Text = "会话消息";
            // 
            // projectPanel1
            // 
            this.projectPanel1.BackColor = System.Drawing.Color.Transparent;
            this.projectPanel1.Location = new System.Drawing.Point(3, 3);
            this.projectPanel1.Name = "projectPanel1";
            this.projectPanel1.Size = new System.Drawing.Size(224, 28);
            this.projectPanel1.TabIndex = 0;
            // 
            // picWeatherStatus
            // 
            this.picWeatherStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picWeatherStatus.Image = global::zSession.Properties.Resources.web;
            this.picWeatherStatus.Location = new System.Drawing.Point(3, 33);
            this.picWeatherStatus.Name = "picWeatherStatus";
            this.picWeatherStatus.Size = new System.Drawing.Size(54, 51);
            this.picWeatherStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picWeatherStatus.TabIndex = 2;
            this.picWeatherStatus.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("宋体", 10F);
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "2/10℃";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 90);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 51);
            this.label3.TabIndex = 6;
            this.label3.Text = "多云转晴";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tsTitle, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.picNetStatus, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(464, 30);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // tsTitle
            // 
            this.tsTitle.AutoSize = false;
            this.tsTitle.BackColor = System.Drawing.Color.Transparent;
            this.tsTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tsTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.tsTitle.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsTitle.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.tsTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tsTitle.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslAccount,
            this.tsbExit,
            this.tsbMin,
            this.tsbSetup,
            this.tsbMail,
            this.tsbJournal,
            this.tsbProject,
            this.tsbTools});
            this.tsTitle.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.tsTitle.Location = new System.Drawing.Point(30, 0);
            this.tsTitle.Name = "tsTitle";
            this.tsTitle.Size = new System.Drawing.Size(434, 30);
            this.tsTitle.TabIndex = 1;
            this.tsTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tsTitle_MouseDown);
            // 
            // tslAccount
            // 
            this.tslAccount.Font = new System.Drawing.Font("华文仿宋", 12F, System.Drawing.FontStyle.Bold);
            this.tslAccount.Name = "tslAccount";
            this.tslAccount.Size = new System.Drawing.Size(76, 27);
            this.tslAccount.Text = "账号名称";
            // 
            // tsbExit
            // 
            this.tsbExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbExit.Image = global::zSession.Properties.Resources.close;
            this.tsbExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExit.Name = "tsbExit";
            this.tsbExit.Size = new System.Drawing.Size(28, 27);
            this.tsbExit.ToolTipText = "退出程序";
            this.tsbExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // tsbMin
            // 
            this.tsbMin.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbMin.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbMin.Image = global::zSession.Properties.Resources.Min;
            this.tsbMin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbMin.Name = "tsbMin";
            this.tsbMin.Size = new System.Drawing.Size(28, 27);
            this.tsbMin.ToolTipText = "最小化到托盘";
            this.tsbMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // tsbSetup
            // 
            this.tsbSetup.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbSetup.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSetup.Image = global::zSession.Properties.Resources.setup;
            this.tsbSetup.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSetup.Name = "tsbSetup";
            this.tsbSetup.Size = new System.Drawing.Size(28, 27);
            this.tsbSetup.ToolTipText = "系统设置";
            this.tsbSetup.Click += new System.EventHandler(this.btnSetup_Click);
            // 
            // tsbMail
            // 
            this.tsbMail.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbMail.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbMail.Image = global::zSession.Properties.Resources.mail;
            this.tsbMail.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbMail.Name = "tsbMail";
            this.tsbMail.Size = new System.Drawing.Size(28, 27);
            this.tsbMail.ToolTipText = "电子邮件";
            this.tsbMail.Click += new System.EventHandler(this.btnMail_Click);
            // 
            // tsbJournal
            // 
            this.tsbJournal.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbJournal.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbJournal.Image = global::zSession.Properties.Resources.cal;
            this.tsbJournal.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbJournal.Name = "tsbJournal";
            this.tsbJournal.Size = new System.Drawing.Size(28, 27);
            this.tsbJournal.ToolTipText = "日程安排";
            this.tsbJournal.Click += new System.EventHandler(this.tsbJournal_Click);
            // 
            // tsbProject
            // 
            this.tsbProject.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbProject.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbProject.Image = global::zSession.Properties.Resources.project;
            this.tsbProject.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbProject.Name = "tsbProject";
            this.tsbProject.Size = new System.Drawing.Size(28, 27);
            this.tsbProject.ToolTipText = "项目管理";
            this.tsbProject.Click += new System.EventHandler(this.tsbProject_Click);
            // 
            // tsbTools
            // 
            this.tsbTools.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbTools.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbTools.Image = global::zSession.Properties.Resources.tools;
            this.tsbTools.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbTools.Name = "tsbTools";
            this.tsbTools.Size = new System.Drawing.Size(28, 27);
            this.tsbTools.ToolTipText = "常用工具包";
            this.tsbTools.Click += new System.EventHandler(this.tsbTools_Click);
            // 
            // picNetStatus
            // 
            this.picNetStatus.ContextMenuStrip = this.ctMSConnectStatus;
            this.picNetStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picNetStatus.Image = global::zSession.Properties.Resources.wireless_blue;
            this.picNetStatus.Location = new System.Drawing.Point(1, 0);
            this.picNetStatus.Margin = new System.Windows.Forms.Padding(1, 0, 1, 1);
            this.picNetStatus.Name = "picNetStatus";
            this.picNetStatus.Size = new System.Drawing.Size(28, 29);
            this.picNetStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picNetStatus.TabIndex = 2;
            this.picNetStatus.TabStop = false;
            // 
            // ctMSConnectStatus
            // 
            this.ctMSConnectStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiConnect,
            this.tsmiDisconnect});
            this.ctMSConnectStatus.Name = "ctMSConnectStatus";
            this.ctMSConnectStatus.Size = new System.Drawing.Size(101, 48);
            // 
            // tsmiConnect
            // 
            this.tsmiConnect.Name = "tsmiConnect";
            this.tsmiConnect.Size = new System.Drawing.Size(100, 22);
            this.tsmiConnect.Text = "连接";
            // 
            // tsmiDisconnect
            // 
            this.tsmiDisconnect.Name = "tsmiDisconnect";
            this.tsmiDisconnect.Size = new System.Drawing.Size(100, 22);
            this.tsmiDisconnect.Text = "断开";
            // 
            // tpBody
            // 
            this.tpBody.BackColor = System.Drawing.Color.Transparent;
            this.tpBody.ColumnCount = 6;
            this.tpBody.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tpBody.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tpBody.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tpBody.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tpBody.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tpBody.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpBody.Controls.Add(this.btnChat, 0, 1);
            this.tpBody.Controls.Add(this.btnAssistant, 1, 1);
            this.tpBody.Controls.Add(this.btnSocialNet, 2, 1);
            this.tpBody.Controls.Add(this.panelBody, 0, 0);
            this.tpBody.Controls.Add(this.btnMarket, 3, 1);
            this.tpBody.Controls.Add(this.btnNews, 4, 1);
            this.tpBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpBody.Location = new System.Drawing.Point(1, 201);
            this.tpBody.Margin = new System.Windows.Forms.Padding(1);
            this.tpBody.Name = "tpBody";
            this.tpBody.RowCount = 2;
            this.tpBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tpBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tpBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tpBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tpBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tpBody.Size = new System.Drawing.Size(462, 553);
            this.tpBody.TabIndex = 5;
            // 
            // btnChat
            // 
            this.btnChat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnChat.FlatAppearance.BorderSize = 0;
            this.btnChat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChat.Font = new System.Drawing.Font("华文楷体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnChat.ForeColor = System.Drawing.Color.CadetBlue;
            this.btnChat.Location = new System.Drawing.Point(0, 513);
            this.btnChat.Margin = new System.Windows.Forms.Padding(0);
            this.btnChat.Name = "btnChat";
            this.btnChat.Size = new System.Drawing.Size(80, 40);
            this.btnChat.TabIndex = 0;
            this.btnChat.Text = "会话";
            this.btnChat.UseVisualStyleBackColor = true;
            this.btnChat.Click += new System.EventHandler(this.btnChat_Click);
            // 
            // btnAssistant
            // 
            this.btnAssistant.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAssistant.FlatAppearance.BorderSize = 0;
            this.btnAssistant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssistant.Font = new System.Drawing.Font("华文楷体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAssistant.ForeColor = System.Drawing.Color.CadetBlue;
            this.btnAssistant.Location = new System.Drawing.Point(80, 513);
            this.btnAssistant.Margin = new System.Windows.Forms.Padding(0);
            this.btnAssistant.Name = "btnAssistant";
            this.btnAssistant.Size = new System.Drawing.Size(80, 40);
            this.btnAssistant.TabIndex = 1;
            this.btnAssistant.Text = "个人秘书";
            this.btnAssistant.UseVisualStyleBackColor = true;
            this.btnAssistant.Click += new System.EventHandler(this.btnAssistant_Click);
            // 
            // btnSocialNet
            // 
            this.btnSocialNet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSocialNet.FlatAppearance.BorderSize = 0;
            this.btnSocialNet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSocialNet.Font = new System.Drawing.Font("华文楷体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSocialNet.ForeColor = System.Drawing.Color.CadetBlue;
            this.btnSocialNet.Location = new System.Drawing.Point(160, 513);
            this.btnSocialNet.Margin = new System.Windows.Forms.Padding(0);
            this.btnSocialNet.Name = "btnSocialNet";
            this.btnSocialNet.Size = new System.Drawing.Size(80, 40);
            this.btnSocialNet.TabIndex = 2;
            this.btnSocialNet.Text = "社交网络";
            this.btnSocialNet.UseVisualStyleBackColor = true;
            this.btnSocialNet.Click += new System.EventHandler(this.btnSocialNet_Click);
            // 
            // panelBody
            // 
            this.panelBody.BackColor = System.Drawing.Color.Transparent;
            this.tpBody.SetColumnSpan(this.panelBody, 6);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(2, 2);
            this.panelBody.Margin = new System.Windows.Forms.Padding(2);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(458, 509);
            this.panelBody.TabIndex = 2;
            // 
            // btnMarket
            // 
            this.btnMarket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMarket.FlatAppearance.BorderSize = 0;
            this.btnMarket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarket.Font = new System.Drawing.Font("华文楷体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnMarket.ForeColor = System.Drawing.Color.CadetBlue;
            this.btnMarket.Location = new System.Drawing.Point(240, 513);
            this.btnMarket.Margin = new System.Windows.Forms.Padding(0);
            this.btnMarket.Name = "btnMarket";
            this.btnMarket.Size = new System.Drawing.Size(80, 40);
            this.btnMarket.TabIndex = 3;
            this.btnMarket.Text = "电子商城";
            this.btnMarket.UseVisualStyleBackColor = true;
            this.btnMarket.Click += new System.EventHandler(this.btnMarket_Click);
            // 
            // btnNews
            // 
            this.btnNews.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNews.FlatAppearance.BorderSize = 0;
            this.btnNews.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNews.Font = new System.Drawing.Font("华文楷体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnNews.ForeColor = System.Drawing.Color.CadetBlue;
            this.btnNews.Location = new System.Drawing.Point(320, 513);
            this.btnNews.Margin = new System.Windows.Forms.Padding(0);
            this.btnNews.Name = "btnNews";
            this.btnNews.Size = new System.Drawing.Size(80, 40);
            this.btnNews.TabIndex = 4;
            this.btnNews.Text = "新闻";
            this.btnNews.UseVisualStyleBackColor = true;
            this.btnNews.Click += new System.EventHandler(this.btnNews_Click);
            // 
            // tsMain
            // 
            this.tsMain.BackColor = System.Drawing.Color.Transparent;
            this.tsMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tsMain.Font = new System.Drawing.Font("华文楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsMain.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbDeviceManagement,
            this.tsbApplicationCenter,
            this.tsbGameCenter,
            this.tsbWareMarket});
            this.tsMain.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.tsMain.Location = new System.Drawing.Point(0, 755);
            this.tsMain.Name = "tsMain";
            this.tsMain.Size = new System.Drawing.Size(464, 60);
            this.tsMain.TabIndex = 6;
            this.tsMain.Text = "toolStrip1";
            // 
            // tsbDeviceManagement
            // 
            this.tsbDeviceManagement.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbDeviceManagement.Image = global::zSession.Properties.Resources.intelligent;
            this.tsbDeviceManagement.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDeviceManagement.Name = "tsbDeviceManagement";
            this.tsbDeviceManagement.Size = new System.Drawing.Size(76, 54);
            this.tsbDeviceManagement.Text = "设备管理";
            this.tsbDeviceManagement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbDeviceManagement.Click += new System.EventHandler(this.tsbDeviceManagement_Click);
            // 
            // tsbApplicationCenter
            // 
            this.tsbApplicationCenter.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbApplicationCenter.Image = global::zSession.Properties.Resources.app_comment;
            this.tsbApplicationCenter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbApplicationCenter.Name = "tsbApplicationCenter";
            this.tsbApplicationCenter.Size = new System.Drawing.Size(76, 54);
            this.tsbApplicationCenter.Text = "应用管理";
            this.tsbApplicationCenter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbApplicationCenter.Click += new System.EventHandler(this.tsbApplicationCenter_Click);
            // 
            // tsbGameCenter
            // 
            this.tsbGameCenter.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbGameCenter.Image = global::zSession.Properties.Resources.GameControllers;
            this.tsbGameCenter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGameCenter.Name = "tsbGameCenter";
            this.tsbGameCenter.Size = new System.Drawing.Size(76, 54);
            this.tsbGameCenter.Text = "游戏中心";
            this.tsbGameCenter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbGameCenter.Click += new System.EventHandler(this.tsbGameCenter_Click);
            // 
            // tsbWareMarket
            // 
            this.tsbWareMarket.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbWareMarket.Image = global::zSession.Properties.Resources.App_Lib;
            this.tsbWareMarket.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbWareMarket.Name = "tsbWareMarket";
            this.tsbWareMarket.Size = new System.Drawing.Size(76, 54);
            this.tsbWareMarket.Text = "软件市场";
            this.tsbWareMarket.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbWareMarket.Click += new System.EventHandler(this.tsbWareMarket_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 23);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 23);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(23, 23);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(107, 37);
            this.toolStripButton6.Text = "toolStripButton6";
            this.toolStripButton6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // bgkInit
            // 
            this.bgkInit.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgkInit_DoWork);
            this.bgkInit.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgkInit_RunWorkerCompleted);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 23);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 23);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.ctMStray;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "zSession";
            this.notifyIcon1.Click += new System.EventHandler(this.notifyIcon1_Click);
            // 
            // ctMStray
            // 
            this.ctMStray.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiShow,
            this.tsmiExit});
            this.ctMStray.Name = "ctMStray";
            this.ctMStray.Size = new System.Drawing.Size(101, 48);
            // 
            // tsmiShow
            // 
            this.tsmiShow.Name = "tsmiShow";
            this.tsmiShow.Size = new System.Drawing.Size(100, 22);
            this.tsmiShow.Text = "显示";
            this.tsmiShow.Click += new System.EventHandler(this.tsmiShow_Click);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(100, 22);
            this.tsmiExit.Text = "退出";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 815);
            this.Controls.Add(this.tpMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "zSession";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.Shown += new System.EventHandler(this.FormMain_Shown);
            this.LocationChanged += new System.EventHandler(this.FormMain_LocationChanged);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseMove);
            this.Resize += new System.EventHandler(this.FormMain_Resize);
            this.tpMain.ResumeLayout(false);
            this.tpMain.PerformLayout();
            this.tpTop.ResumeLayout(false);
            this.tpHeader.ResumeLayout(false);
            this.tpHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPerson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWorkStatus)).EndInit();
            this.ctMSWorkStatus.ResumeLayout(false);
            this.flpMessage.ResumeLayout(false);
            this.ctMSMessage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picWeatherStatus)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tsTitle.ResumeLayout(false);
            this.tsTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNetStatus)).EndInit();
            this.ctMSConnectStatus.ResumeLayout(false);
            this.tpBody.ResumeLayout(false);
            this.tsMain.ResumeLayout(false);
            this.tsMain.PerformLayout();
            this.ctMStray.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tpMain;
        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.ToolStripButton tsbWareMarket;
        private System.Windows.Forms.ToolStripButton tsbGameCenter;
        private System.Windows.Forms.ToolStripButton tsbApplicationCenter;
        private System.Windows.Forms.TableLayoutPanel tpTop;
        private System.Windows.Forms.TableLayoutPanel tpHeader;
        private System.Windows.Forms.PictureBox picPerson;
        private System.Windows.Forms.TableLayoutPanel tpBody;
        private System.Windows.Forms.Button btnChat;
        private System.Windows.Forms.Button btnAssistant;
        private System.Windows.Forms.Button btnSocialNet;
        private System.Windows.Forms.Button btnMarket;
        private System.Windows.Forms.Button btnNews;
        private System.Windows.Forms.PictureBox picWeatherStatus;
        private System.Windows.Forms.ToolStripButton tsbDeviceManagement;
        private System.Windows.Forms.PictureBox picWorkStatus;
        private System.Windows.Forms.Label lblWorkStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ContextMenuStrip ctMSWorkStatus;
        private System.Windows.Forms.ToolStripMenuItem tsmiFree;
        private System.Windows.Forms.ToolStripMenuItem tsmiBusyness;
        private System.Windows.Forms.ToolStripMenuItem tsmiNoDisturb;
        private System.Windows.Forms.ToolStripMenuItem tsmiLeave;
        private System.Windows.Forms.ContextMenuStrip ctMSConnectStatus;
        private System.Windows.Forms.ToolStripMenuItem tsmiConnect;
        private System.Windows.Forms.ToolStripMenuItem tsmiDisconnect;
        private System.Windows.Forms.FlowLayoutPanel flpVIP;
        private System.ComponentModel.BackgroundWorker bgkInit;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStrip tsMain;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.FlowLayoutPanel flpMessage;
        private Assistant.project.ProjectPanel projectPanel1;
        private System.Windows.Forms.ContextMenuStrip ctMSMessage;
        private System.Windows.Forms.ToolStripMenuItem tsmiProject;
        private System.Windows.Forms.ToolStripMenuItem tsmiJournal;
        private System.Windows.Forms.ToolStripMenuItem tsmiSession;
        private System.Windows.Forms.ToolStrip tsTitle;
        private System.Windows.Forms.ToolStripLabel tslAccount;
        private System.Windows.Forms.ToolStripButton tsbExit;
        private System.Windows.Forms.ToolStripButton tsbMin;
        private System.Windows.Forms.ToolStripButton tsbSetup;
        private System.Windows.Forms.ToolStripButton tsbMail;
        private System.Windows.Forms.ToolStripButton tsbJournal;
        private System.Windows.Forms.ToolStripButton tsbProject;
        private System.Windows.Forms.ToolStripButton tsbTools;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox picNetStatus;
        private System.Windows.Forms.ContextMenuStrip ctMStray;
        private System.Windows.Forms.ToolStripMenuItem tsmiShow;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
    }
}

