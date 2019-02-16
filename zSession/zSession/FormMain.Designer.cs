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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbDeviceManagement = new System.Windows.Forms.ToolStripButton();
            this.tsbApplicationCenter = new System.Windows.Forms.ToolStripButton();
            this.tsbGameCenter = new System.Windows.Forms.ToolStripButton();
            this.tsbWareMarket = new System.Windows.Forms.ToolStripButton();
            this.tpTop = new System.Windows.Forms.TableLayoutPanel();
            this.tpTitle = new System.Windows.Forms.TableLayoutPanel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.picConnectStatus = new System.Windows.Forms.PictureBox();
            this.ctMSConnectStatus = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiConnect = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDisconnect = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnMail = new System.Windows.Forms.Button();
            this.btnSetup = new System.Windows.Forms.Button();
            this.tpHeader = new System.Windows.Forms.TableLayoutPanel();
            this.picPerson = new System.Windows.Forms.PictureBox();
            this.picWeatherStatus = new System.Windows.Forms.PictureBox();
            this.picWorkStatus = new System.Windows.Forms.PictureBox();
            this.ctMSWorkStatus = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiFree = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBusyness = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNoDisturb = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLeave = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tpAutograph = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.flpVIP = new System.Windows.Forms.FlowLayoutPanel();
            this.tpBody = new System.Windows.Forms.TableLayoutPanel();
            this.btnChat = new System.Windows.Forms.Button();
            this.btnAssistant = new System.Windows.Forms.Button();
            this.btnSocialNet = new System.Windows.Forms.Button();
            this.panelBody = new System.Windows.Forms.Panel();
            this.btnMarket = new System.Windows.Forms.Button();
            this.btnNews = new System.Windows.Forms.Button();
            this.bgkInit = new System.ComponentModel.BackgroundWorker();
            this.tpMain.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tpTop.SuspendLayout();
            this.tpTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picConnectStatus)).BeginInit();
            this.ctMSConnectStatus.SuspendLayout();
            this.tpHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPerson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWeatherStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWorkStatus)).BeginInit();
            this.ctMSWorkStatus.SuspendLayout();
            this.tpAutograph.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tpBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // tpMain
            // 
            this.tpMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tpMain.BackgroundImage")));
            this.tpMain.ColumnCount = 1;
            this.tpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpMain.Controls.Add(this.toolStrip1, 0, 2);
            this.tpMain.Controls.Add(this.tpTop, 0, 0);
            this.tpMain.Controls.Add(this.tpBody, 0, 1);
            this.tpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpMain.Location = new System.Drawing.Point(0, 0);
            this.tpMain.Name = "tpMain";
            this.tpMain.RowCount = 3;
            this.tpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tpMain.Size = new System.Drawing.Size(464, 815);
            this.tpMain.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbDeviceManagement,
            this.tsbApplicationCenter,
            this.tsbGameCenter,
            this.tsbWareMarket});
            this.toolStrip1.Location = new System.Drawing.Point(0, 775);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(464, 40);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbDeviceManagement
            // 
            this.tsbDeviceManagement.Image = global::zSession.Properties.Resources.access_alt;
            this.tsbDeviceManagement.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDeviceManagement.Name = "tsbDeviceManagement";
            this.tsbDeviceManagement.Size = new System.Drawing.Size(60, 37);
            this.tsbDeviceManagement.Text = "设备管理";
            this.tsbDeviceManagement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbDeviceManagement.Click += new System.EventHandler(this.tsbDeviceManagement_Click);
            // 
            // tsbApplicationCenter
            // 
            this.tsbApplicationCenter.Image = global::zSession.Properties.Resources.app_comment;
            this.tsbApplicationCenter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbApplicationCenter.Name = "tsbApplicationCenter";
            this.tsbApplicationCenter.Size = new System.Drawing.Size(60, 37);
            this.tsbApplicationCenter.Text = "应用管理";
            this.tsbApplicationCenter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbApplicationCenter.Click += new System.EventHandler(this.tsbApplicationCenter_Click);
            // 
            // tsbGameCenter
            // 
            this.tsbGameCenter.Image = global::zSession.Properties.Resources.CD_burn;
            this.tsbGameCenter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGameCenter.Name = "tsbGameCenter";
            this.tsbGameCenter.Size = new System.Drawing.Size(60, 37);
            this.tsbGameCenter.Text = "游戏中心";
            this.tsbGameCenter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbGameCenter.Click += new System.EventHandler(this.tsbGameCenter_Click);
            // 
            // tsbWareMarket
            // 
            this.tsbWareMarket.Image = global::zSession.Properties.Resources.App_Lib;
            this.tsbWareMarket.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbWareMarket.Name = "tsbWareMarket";
            this.tsbWareMarket.Size = new System.Drawing.Size(60, 37);
            this.tsbWareMarket.Text = "软件市场";
            this.tsbWareMarket.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbWareMarket.Click += new System.EventHandler(this.tsbWareMarket_Click);
            // 
            // tpTop
            // 
            this.tpTop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tpTop.BackgroundImage")));
            this.tpTop.ColumnCount = 1;
            this.tpTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tpTop.Controls.Add(this.tpTitle, 0, 0);
            this.tpTop.Controls.Add(this.tpHeader, 0, 1);
            this.tpTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpTop.Location = new System.Drawing.Point(0, 0);
            this.tpTop.Margin = new System.Windows.Forms.Padding(0);
            this.tpTop.Name = "tpTop";
            this.tpTop.RowCount = 2;
            this.tpTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tpTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpTop.Size = new System.Drawing.Size(464, 150);
            this.tpTop.TabIndex = 4;
            // 
            // tpTitle
            // 
            this.tpTitle.BackColor = System.Drawing.Color.Transparent;
            this.tpTitle.ColumnCount = 9;
            this.tpTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tpTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tpTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tpTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tpTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tpTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tpTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tpTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tpTitle.Controls.Add(this.btnExit, 8, 0);
            this.tpTitle.Controls.Add(this.btnMin, 7, 0);
            this.tpTitle.Controls.Add(this.picConnectStatus, 0, 0);
            this.tpTitle.Controls.Add(this.lblTitle, 1, 0);
            this.tpTitle.Controls.Add(this.btnMail, 5, 0);
            this.tpTitle.Controls.Add(this.btnSetup, 6, 0);
            this.tpTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpTitle.Location = new System.Drawing.Point(0, 0);
            this.tpTitle.Margin = new System.Windows.Forms.Padding(0);
            this.tpTitle.Name = "tpTitle";
            this.tpTitle.RowCount = 1;
            this.tpTitle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpTitle.Size = new System.Drawing.Size(464, 30);
            this.tpTitle.TabIndex = 3;
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExit.Image = global::zSession.Properties.Resources.close;
            this.btnExit.Location = new System.Drawing.Point(435, 1);
            this.btnExit.Margin = new System.Windows.Forms.Padding(1);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(28, 28);
            this.btnExit.TabIndex = 0;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMin
            // 
            this.btnMin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMin.Image = global::zSession.Properties.Resources.Min;
            this.btnMin.Location = new System.Drawing.Point(405, 1);
            this.btnMin.Margin = new System.Windows.Forms.Padding(1);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(28, 28);
            this.btnMin.TabIndex = 1;
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // picConnectStatus
            // 
            this.picConnectStatus.ContextMenuStrip = this.ctMSConnectStatus;
            this.picConnectStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picConnectStatus.Image = global::zSession.Properties.Resources.wireless_blue;
            this.picConnectStatus.Location = new System.Drawing.Point(1, 1);
            this.picConnectStatus.Margin = new System.Windows.Forms.Padding(1);
            this.picConnectStatus.Name = "picConnectStatus";
            this.picConnectStatus.Size = new System.Drawing.Size(28, 28);
            this.picConnectStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picConnectStatus.TabIndex = 2;
            this.picConnectStatus.TabStop = false;
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
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Location = new System.Drawing.Point(33, 3);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(3);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(218, 24);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "标题";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblTitle_MouseDown);
            // 
            // btnMail
            // 
            this.btnMail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMail.Image = global::zSession.Properties.Resources.mail;
            this.btnMail.Location = new System.Drawing.Point(345, 1);
            this.btnMail.Margin = new System.Windows.Forms.Padding(1);
            this.btnMail.Name = "btnMail";
            this.btnMail.Size = new System.Drawing.Size(28, 28);
            this.btnMail.TabIndex = 4;
            this.btnMail.UseVisualStyleBackColor = true;
            this.btnMail.Click += new System.EventHandler(this.btnMail_Click);
            // 
            // btnSetup
            // 
            this.btnSetup.BackColor = System.Drawing.Color.Transparent;
            this.btnSetup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSetup.Image = global::zSession.Properties.Resources.setup;
            this.btnSetup.Location = new System.Drawing.Point(375, 1);
            this.btnSetup.Margin = new System.Windows.Forms.Padding(1);
            this.btnSetup.Name = "btnSetup";
            this.btnSetup.Size = new System.Drawing.Size(28, 28);
            this.btnSetup.TabIndex = 5;
            this.btnSetup.UseVisualStyleBackColor = true;
            this.btnSetup.Click += new System.EventHandler(this.btnSetup_Click);
            // 
            // tpHeader
            // 
            this.tpHeader.BackColor = System.Drawing.Color.Transparent;
            this.tpHeader.ColumnCount = 4;
            this.tpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tpHeader.Controls.Add(this.picPerson, 2, 0);
            this.tpHeader.Controls.Add(this.picWeatherStatus, 0, 0);
            this.tpHeader.Controls.Add(this.picWorkStatus, 2, 2);
            this.tpHeader.Controls.Add(this.label1, 3, 2);
            this.tpHeader.Controls.Add(this.label2, 0, 1);
            this.tpHeader.Controls.Add(this.label3, 0, 2);
            this.tpHeader.Controls.Add(this.tpAutograph, 1, 1);
            this.tpHeader.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tpHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpHeader.Location = new System.Drawing.Point(1, 31);
            this.tpHeader.Margin = new System.Windows.Forms.Padding(1);
            this.tpHeader.Name = "tpHeader";
            this.tpHeader.RowCount = 3;
            this.tpHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tpHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tpHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tpHeader.Size = new System.Drawing.Size(462, 118);
            this.tpHeader.TabIndex = 4;
            // 
            // picPerson
            // 
            this.picPerson.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpHeader.SetColumnSpan(this.picPerson, 2);
            this.picPerson.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picPerson.Location = new System.Drawing.Point(366, 0);
            this.picPerson.Margin = new System.Windows.Forms.Padding(0);
            this.picPerson.Name = "picPerson";
            this.tpHeader.SetRowSpan(this.picPerson, 2);
            this.picPerson.Size = new System.Drawing.Size(96, 92);
            this.picPerson.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPerson.TabIndex = 0;
            this.picPerson.TabStop = false;
            // 
            // picWeatherStatus
            // 
            this.picWeatherStatus.Image = global::zSession.Properties.Resources.web;
            this.picWeatherStatus.Location = new System.Drawing.Point(3, 3);
            this.picWeatherStatus.Name = "picWeatherStatus";
            this.picWeatherStatus.Size = new System.Drawing.Size(54, 40);
            this.picWeatherStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picWeatherStatus.TabIndex = 2;
            this.picWeatherStatus.TabStop = false;
            // 
            // picWorkStatus
            // 
            this.picWorkStatus.ContextMenuStrip = this.ctMSWorkStatus;
            this.picWorkStatus.Image = global::zSession.Properties.Resources.phone_blue;
            this.picWorkStatus.Location = new System.Drawing.Point(368, 94);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ContextMenuStrip = this.ctMSWorkStatus;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("仿宋", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(395, 95);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "空闲";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("宋体", 10F);
            this.label2.Location = new System.Drawing.Point(3, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 40);
            this.label2.TabIndex = 5;
            this.label2.Text = "2/10℃";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 95);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "多云转晴";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tpAutograph
            // 
            this.tpAutograph.ColumnCount = 1;
            this.tpAutograph.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpAutograph.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tpAutograph.Controls.Add(this.label4, 0, 0);
            this.tpAutograph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpAutograph.Location = new System.Drawing.Point(60, 46);
            this.tpAutograph.Margin = new System.Windows.Forms.Padding(0);
            this.tpAutograph.Name = "tpAutograph";
            this.tpAutograph.RowCount = 2;
            this.tpHeader.SetRowSpan(this.tpAutograph, 2);
            this.tpAutograph.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tpAutograph.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpAutograph.Size = new System.Drawing.Size(306, 72);
            this.tpAutograph.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Enabled = false;
            this.label4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(3, 3);
            this.label4.Margin = new System.Windows.Forms.Padding(3);
            this.label4.Name = "label4";
            this.tpAutograph.SetRowSpan(this.label4, 2);
            this.label4.Size = new System.Drawing.Size(300, 66);
            this.label4.TabIndex = 0;
            this.label4.Text = "个性签名";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 114F));
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.flpVIP, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(60, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(306, 46);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("仿宋", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(3, 3);
            this.label5.Margin = new System.Windows.Forms.Padding(3);
            this.label5.Name = "label5";
            this.tableLayoutPanel2.SetRowSpan(this.label5, 3);
            this.label5.Size = new System.Drawing.Size(186, 40);
            this.label5.TabIndex = 0;
            this.label5.Text = "账号名称";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flpVIP
            // 
            this.flpVIP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpVIP.Location = new System.Drawing.Point(192, 10);
            this.flpVIP.Margin = new System.Windows.Forms.Padding(0);
            this.flpVIP.Name = "flpVIP";
            this.flpVIP.Size = new System.Drawing.Size(114, 26);
            this.flpVIP.TabIndex = 1;
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
            this.tpBody.Location = new System.Drawing.Point(1, 151);
            this.tpBody.Margin = new System.Windows.Forms.Padding(1);
            this.tpBody.Name = "tpBody";
            this.tpBody.RowCount = 2;
            this.tpBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tpBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tpBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tpBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tpBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tpBody.Size = new System.Drawing.Size(462, 623);
            this.tpBody.TabIndex = 5;
            // 
            // btnChat
            // 
            this.btnChat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnChat.Location = new System.Drawing.Point(1, 584);
            this.btnChat.Margin = new System.Windows.Forms.Padding(1);
            this.btnChat.Name = "btnChat";
            this.btnChat.Size = new System.Drawing.Size(78, 38);
            this.btnChat.TabIndex = 0;
            this.btnChat.Text = "会话";
            this.btnChat.UseVisualStyleBackColor = true;
            this.btnChat.Click += new System.EventHandler(this.btnChat_Click);
            // 
            // btnAssistant
            // 
            this.btnAssistant.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAssistant.Location = new System.Drawing.Point(81, 584);
            this.btnAssistant.Margin = new System.Windows.Forms.Padding(1);
            this.btnAssistant.Name = "btnAssistant";
            this.btnAssistant.Size = new System.Drawing.Size(78, 38);
            this.btnAssistant.TabIndex = 1;
            this.btnAssistant.Text = "个人秘书";
            this.btnAssistant.UseVisualStyleBackColor = true;
            this.btnAssistant.Click += new System.EventHandler(this.btnAssistant_Click);
            // 
            // btnSocialNet
            // 
            this.btnSocialNet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSocialNet.Location = new System.Drawing.Point(161, 584);
            this.btnSocialNet.Margin = new System.Windows.Forms.Padding(1);
            this.btnSocialNet.Name = "btnSocialNet";
            this.btnSocialNet.Size = new System.Drawing.Size(78, 38);
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
            this.panelBody.Size = new System.Drawing.Size(458, 579);
            this.panelBody.TabIndex = 2;
            // 
            // btnMarket
            // 
            this.btnMarket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMarket.Location = new System.Drawing.Point(241, 584);
            this.btnMarket.Margin = new System.Windows.Forms.Padding(1);
            this.btnMarket.Name = "btnMarket";
            this.btnMarket.Size = new System.Drawing.Size(78, 38);
            this.btnMarket.TabIndex = 3;
            this.btnMarket.Text = "电子商城";
            this.btnMarket.UseVisualStyleBackColor = true;
            this.btnMarket.Click += new System.EventHandler(this.btnMarket_Click);
            // 
            // btnNews
            // 
            this.btnNews.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNews.Location = new System.Drawing.Point(321, 584);
            this.btnNews.Margin = new System.Windows.Forms.Padding(1);
            this.btnNews.Name = "btnNews";
            this.btnNews.Size = new System.Drawing.Size(78, 38);
            this.btnNews.TabIndex = 4;
            this.btnNews.Text = "新闻";
            this.btnNews.UseVisualStyleBackColor = true;
            this.btnNews.Click += new System.EventHandler(this.btnNews_Click);
            // 
            // bgkInit
            // 
            this.bgkInit.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgkInit_DoWork);
            this.bgkInit.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgkInit_RunWorkerCompleted);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 815);
            this.Controls.Add(this.tpMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "a";
            this.Shown += new System.EventHandler(this.FormMain_Shown);
            this.tpMain.ResumeLayout(false);
            this.tpMain.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tpTop.ResumeLayout(false);
            this.tpTitle.ResumeLayout(false);
            this.tpTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picConnectStatus)).EndInit();
            this.ctMSConnectStatus.ResumeLayout(false);
            this.tpHeader.ResumeLayout(false);
            this.tpHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPerson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWeatherStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWorkStatus)).EndInit();
            this.ctMSWorkStatus.ResumeLayout(false);
            this.tpAutograph.ResumeLayout(false);
            this.tpAutograph.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tpBody.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tpMain;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.ToolStripButton tsbWareMarket;
        private System.Windows.Forms.ToolStripButton tsbGameCenter;
        private System.Windows.Forms.ToolStripButton tsbApplicationCenter;
        private System.Windows.Forms.TableLayoutPanel tpTitle;
        private System.Windows.Forms.TableLayoutPanel tpTop;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.TableLayoutPanel tpHeader;
        private System.Windows.Forms.PictureBox picPerson;
        private System.Windows.Forms.TableLayoutPanel tpBody;
        private System.Windows.Forms.Button btnChat;
        private System.Windows.Forms.Button btnAssistant;
        private System.Windows.Forms.Button btnSocialNet;
        private System.Windows.Forms.Button btnMarket;
        private System.Windows.Forms.Button btnNews;
        private System.Windows.Forms.PictureBox picWeatherStatus;
        private System.Windows.Forms.PictureBox picConnectStatus;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnMail;
        private System.Windows.Forms.ToolStripButton tsbDeviceManagement;
        private System.Windows.Forms.PictureBox picWorkStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSetup;
        private System.Windows.Forms.TableLayoutPanel tpAutograph;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label5;
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
    }
}

