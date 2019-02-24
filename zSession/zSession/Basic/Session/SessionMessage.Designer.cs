namespace zSession.Basic.Session
{
    partial class SessionMessage
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tpMain = new System.Windows.Forms.TableLayoutPanel();
            this.picPhoto = new System.Windows.Forms.PictureBox();
            this.linkMessage = new System.Windows.Forms.LinkLabel();
            this.lbSessionTime = new System.Windows.Forms.Label();
            this.tpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // tpMain
            // 
            this.tpMain.BackColor = System.Drawing.Color.Transparent;
            this.tpMain.ColumnCount = 3;
            this.tpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 126F));
            this.tpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpMain.Controls.Add(this.picPhoto, 0, 0);
            this.tpMain.Controls.Add(this.linkMessage, 2, 0);
            this.tpMain.Controls.Add(this.lbSessionTime, 1, 0);
            this.tpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpMain.Location = new System.Drawing.Point(0, 0);
            this.tpMain.Name = "tpMain";
            this.tpMain.RowCount = 1;
            this.tpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpMain.Size = new System.Drawing.Size(298, 24);
            this.tpMain.TabIndex = 0;
            // 
            // picPhoto
            // 
            this.picPhoto.BackColor = System.Drawing.Color.Transparent;
            this.picPhoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picPhoto.Image = global::zSession.Properties.Resources.PhotoImages;
            this.picPhoto.Location = new System.Drawing.Point(0, 0);
            this.picPhoto.Margin = new System.Windows.Forms.Padding(0);
            this.picPhoto.Name = "picPhoto";
            this.picPhoto.Size = new System.Drawing.Size(20, 24);
            this.picPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPhoto.TabIndex = 0;
            this.picPhoto.TabStop = false;
            // 
            // linkMessage
            // 
            this.linkMessage.AutoSize = true;
            this.linkMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.linkMessage.Location = new System.Drawing.Point(149, 3);
            this.linkMessage.Margin = new System.Windows.Forms.Padding(3);
            this.linkMessage.Name = "linkMessage";
            this.linkMessage.Size = new System.Drawing.Size(146, 18);
            this.linkMessage.TabIndex = 1;
            this.linkMessage.TabStop = true;
            this.linkMessage.Text = "会话信息";
            this.linkMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbSessionTime
            // 
            this.lbSessionTime.AutoSize = true;
            this.lbSessionTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbSessionTime.Location = new System.Drawing.Point(23, 3);
            this.lbSessionTime.Margin = new System.Windows.Forms.Padding(3);
            this.lbSessionTime.Name = "lbSessionTime";
            this.lbSessionTime.Size = new System.Drawing.Size(120, 18);
            this.lbSessionTime.TabIndex = 2;
            this.lbSessionTime.Text = "2019/12/01 23:00:24";
            this.lbSessionTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SessionMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tpMain);
            this.Name = "SessionMessage";
            this.Size = new System.Drawing.Size(298, 24);
            this.tpMain.ResumeLayout(false);
            this.tpMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tpMain;
        private System.Windows.Forms.PictureBox picPhoto;
        private System.Windows.Forms.LinkLabel linkMessage;
        private System.Windows.Forms.Label lbSessionTime;
    }
}
