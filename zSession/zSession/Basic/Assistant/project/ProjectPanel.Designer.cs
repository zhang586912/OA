namespace zSession.Assistant.project
{
    partial class ProjectPanel
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
            this.lklProjectName = new System.Windows.Forms.LinkLabel();
            this.picFlag = new System.Windows.Forms.PictureBox();
            this.tpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFlag)).BeginInit();
            this.SuspendLayout();
            // 
            // tpMain
            // 
            this.tpMain.ColumnCount = 2;
            this.tpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpMain.Controls.Add(this.lklProjectName, 1, 0);
            this.tpMain.Controls.Add(this.picFlag, 0, 0);
            this.tpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpMain.Location = new System.Drawing.Point(0, 0);
            this.tpMain.Name = "tpMain";
            this.tpMain.RowCount = 1;
            this.tpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpMain.Size = new System.Drawing.Size(240, 24);
            this.tpMain.TabIndex = 0;
            // 
            // lklProjectName
            // 
            this.lklProjectName.AutoSize = true;
            this.lklProjectName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lklProjectName.Location = new System.Drawing.Point(43, 0);
            this.lklProjectName.Name = "lklProjectName";
            this.lklProjectName.Size = new System.Drawing.Size(194, 24);
            this.lklProjectName.TabIndex = 1;
            this.lklProjectName.TabStop = true;
            this.lklProjectName.Text = "到期项目及日程安排内容摘要";
            this.lklProjectName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picFlag
            // 
            this.picFlag.Image = global::zSession.Properties.Resources.flag_blue;
            this.picFlag.Location = new System.Drawing.Point(3, 3);
            this.picFlag.Name = "picFlag";
            this.picFlag.Size = new System.Drawing.Size(34, 18);
            this.picFlag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFlag.TabIndex = 2;
            this.picFlag.TabStop = false;
            // 
            // ProjectPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tpMain);
            this.Name = "ProjectPanel";
            this.Size = new System.Drawing.Size(240, 24);
            this.tpMain.ResumeLayout(false);
            this.tpMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFlag)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tpMain;
        private System.Windows.Forms.LinkLabel lklProjectName;
        private System.Windows.Forms.PictureBox picFlag;
    }
}
