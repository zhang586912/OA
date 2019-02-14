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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.tpMain = new System.Windows.Forms.TableLayoutPanel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.panelBody = new System.Windows.Forms.Panel();
            this.tpTop = new System.Windows.Forms.TableLayoutPanel();
            this.tpTitle = new System.Windows.Forms.TableLayoutPanel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.picConnectStatus = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnMail = new System.Windows.Forms.Button();
            this.btnSetup = new System.Windows.Forms.Button();
            this.tpHeader = new System.Windows.Forms.TableLayoutPanel();
            this.picPerson = new System.Windows.Forms.PictureBox();
            this.picWeatherStatus = new System.Windows.Forms.PictureBox();
            this.picWorkStatus = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tpBottom = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.tpMain.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tpTop.SuspendLayout();
            this.tpTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picConnectStatus)).BeginInit();
            this.tpHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPerson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWeatherStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWorkStatus)).BeginInit();
            this.tpBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // tpMain
            // 
            this.tpMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tpMain.BackgroundImage")));
            this.tpMain.ColumnCount = 1;
            this.tpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpMain.Controls.Add(this.toolStrip1, 0, 3);
            this.tpMain.Controls.Add(this.panelBody, 0, 1);
            this.tpMain.Controls.Add(this.tpTop, 0, 0);
            this.tpMain.Controls.Add(this.tpBottom, 0, 2);
            this.tpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpMain.Location = new System.Drawing.Point(0, 0);
            this.tpMain.Name = "tpMain";
            this.tpMain.RowCount = 4;
            this.tpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tpMain.Size = new System.Drawing.Size(464, 698);
            this.tpMain.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton4,
            this.toolStripButton3,
            this.toolStripButton2,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 658);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(464, 40);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Image = global::zSession.Properties.Resources.access_alt;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(60, 37);
            this.toolStripButton4.Text = "设备管理";
            this.toolStripButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = global::zSession.Properties.Resources.app_comment;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(60, 37);
            this.toolStripButton3.Text = "应用管理";
            this.toolStripButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = global::zSession.Properties.Resources.CD_burn;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(60, 37);
            this.toolStripButton2.Text = "游戏中心";
            this.toolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::zSession.Properties.Resources.App_Lib;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(60, 37);
            this.toolStripButton1.Text = "软件市场";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // panelBody
            // 
            this.panelBody.BackColor = System.Drawing.Color.Transparent;
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(2, 152);
            this.panelBody.Margin = new System.Windows.Forms.Padding(2);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(460, 464);
            this.panelBody.TabIndex = 2;
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
            this.tpTitle.ColumnCount = 6;
            this.tpTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tpTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tpTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tpTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tpTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tpTitle.Controls.Add(this.btnExit, 5, 0);
            this.tpTitle.Controls.Add(this.btnMin, 4, 0);
            this.tpTitle.Controls.Add(this.picConnectStatus, 0, 0);
            this.tpTitle.Controls.Add(this.lblTitle, 1, 0);
            this.tpTitle.Controls.Add(this.btnMail, 2, 0);
            this.tpTitle.Controls.Add(this.btnSetup, 3, 0);
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
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Location = new System.Drawing.Point(33, 3);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(3);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(308, 24);
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
            // 
            // btnSetup
            // 
            this.btnSetup.BackColor = System.Drawing.Color.Transparent;
            this.btnSetup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSetup.Image = global::zSession.Properties.Resources.setup16;
            this.btnSetup.Location = new System.Drawing.Point(375, 1);
            this.btnSetup.Margin = new System.Windows.Forms.Padding(1);
            this.btnSetup.Name = "btnSetup";
            this.btnSetup.Size = new System.Drawing.Size(28, 28);
            this.btnSetup.TabIndex = 5;
            this.btnSetup.UseVisualStyleBackColor = true;
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
            this.picWeatherStatus.Image = global::zSession.Properties.Resources.rain;
            this.picWeatherStatus.Location = new System.Drawing.Point(3, 3);
            this.picWeatherStatus.Name = "picWeatherStatus";
            this.picWeatherStatus.Size = new System.Drawing.Size(54, 40);
            this.picWeatherStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picWeatherStatus.TabIndex = 2;
            this.picWeatherStatus.TabStop = false;
            // 
            // picWorkStatus
            // 
            this.picWorkStatus.Image = global::zSession.Properties.Resources.phone_blue;
            this.picWorkStatus.Location = new System.Drawing.Point(368, 94);
            this.picWorkStatus.Margin = new System.Windows.Forms.Padding(2);
            this.picWorkStatus.Name = "picWorkStatus";
            this.picWorkStatus.Size = new System.Drawing.Size(22, 22);
            this.picWorkStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picWorkStatus.TabIndex = 3;
            this.picWorkStatus.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
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
            // tpBottom
            // 
            this.tpBottom.BackColor = System.Drawing.Color.Transparent;
            this.tpBottom.ColumnCount = 6;
            this.tpBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tpBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tpBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tpBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tpBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tpBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tpBottom.Controls.Add(this.button1, 0, 0);
            this.tpBottom.Controls.Add(this.button2, 1, 0);
            this.tpBottom.Controls.Add(this.button3, 2, 0);
            this.tpBottom.Controls.Add(this.button4, 3, 0);
            this.tpBottom.Controls.Add(this.button5, 4, 0);
            this.tpBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpBottom.Location = new System.Drawing.Point(3, 621);
            this.tpBottom.Name = "tpBottom";
            this.tpBottom.RowCount = 1;
            this.tpBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpBottom.Size = new System.Drawing.Size(458, 34);
            this.tpBottom.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(1, 1);
            this.button1.Margin = new System.Windows.Forms.Padding(1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "会话";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Location = new System.Drawing.Point(81, 1);
            this.button2.Margin = new System.Windows.Forms.Padding(1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 32);
            this.button2.TabIndex = 1;
            this.button2.Text = "个人秘书";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.Location = new System.Drawing.Point(161, 1);
            this.button3.Margin = new System.Windows.Forms.Padding(1);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(78, 32);
            this.button3.TabIndex = 2;
            this.button3.Text = "社交网络";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4.Location = new System.Drawing.Point(241, 1);
            this.button4.Margin = new System.Windows.Forms.Padding(1);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(78, 32);
            this.button4.TabIndex = 3;
            this.button4.Text = "电子商城";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button5.Location = new System.Drawing.Point(321, 1);
            this.button5.Margin = new System.Windows.Forms.Padding(1);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(78, 32);
            this.button5.TabIndex = 4;
            this.button5.Text = "新闻";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 698);
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
            this.tpHeader.ResumeLayout(false);
            this.tpHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPerson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWeatherStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWorkStatus)).EndInit();
            this.tpBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tpMain;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.TableLayoutPanel tpTitle;
        private System.Windows.Forms.TableLayoutPanel tpTop;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.TableLayoutPanel tpHeader;
        private System.Windows.Forms.PictureBox picPerson;
        private System.Windows.Forms.TableLayoutPanel tpBottom;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.PictureBox picWeatherStatus;
        private System.Windows.Forms.PictureBox picConnectStatus;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnMail;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.PictureBox picWorkStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSetup;
    }
}

