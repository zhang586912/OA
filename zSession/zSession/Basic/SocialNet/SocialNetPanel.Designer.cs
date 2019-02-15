namespace zSession.SocialNet
{
    partial class SocialNetPanel
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
            this.btnPrivate = new System.Windows.Forms.Button();
            this.btnPublic = new System.Windows.Forms.Button();
            this.btnCustomized = new System.Windows.Forms.Button();
            this.panelBody = new System.Windows.Forms.Panel();
            this.tpMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tpMain
            // 
            this.tpMain.ColumnCount = 2;
            this.tpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpMain.Controls.Add(this.btnPrivate, 0, 0);
            this.tpMain.Controls.Add(this.btnPublic, 0, 1);
            this.tpMain.Controls.Add(this.btnCustomized, 0, 2);
            this.tpMain.Controls.Add(this.panelBody, 1, 0);
            this.tpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpMain.Location = new System.Drawing.Point(0, 0);
            this.tpMain.Name = "tpMain";
            this.tpMain.RowCount = 4;
            this.tpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpMain.Size = new System.Drawing.Size(374, 605);
            this.tpMain.TabIndex = 0;
            // 
            // btnPrivate
            // 
            this.btnPrivate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPrivate.Location = new System.Drawing.Point(1, 1);
            this.btnPrivate.Margin = new System.Windows.Forms.Padding(1);
            this.btnPrivate.Name = "btnPrivate";
            this.btnPrivate.Size = new System.Drawing.Size(28, 78);
            this.btnPrivate.TabIndex = 0;
            this.btnPrivate.Text = "私人领地";
            this.btnPrivate.UseVisualStyleBackColor = true;
            // 
            // btnPublic
            // 
            this.btnPublic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPublic.Location = new System.Drawing.Point(1, 81);
            this.btnPublic.Margin = new System.Windows.Forms.Padding(1);
            this.btnPublic.Name = "btnPublic";
            this.btnPublic.Size = new System.Drawing.Size(28, 78);
            this.btnPublic.TabIndex = 1;
            this.btnPublic.Text = "公共领域";
            this.btnPublic.UseVisualStyleBackColor = true;
            // 
            // btnCustomized
            // 
            this.btnCustomized.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCustomized.Location = new System.Drawing.Point(1, 161);
            this.btnCustomized.Margin = new System.Windows.Forms.Padding(1);
            this.btnCustomized.Name = "btnCustomized";
            this.btnCustomized.Size = new System.Drawing.Size(28, 78);
            this.btnCustomized.TabIndex = 2;
            this.btnCustomized.Text = "定制天地";
            this.btnCustomized.UseVisualStyleBackColor = true;
            // 
            // panelBody
            // 
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(33, 3);
            this.panelBody.Name = "panelBody";
            this.tpMain.SetRowSpan(this.panelBody, 4);
            this.panelBody.Size = new System.Drawing.Size(338, 599);
            this.panelBody.TabIndex = 3;
            // 
            // SocialNetPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tpMain);
            this.Name = "SocialNetPanel";
            this.Size = new System.Drawing.Size(374, 605);
            this.tpMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tpMain;
        private System.Windows.Forms.Button btnPrivate;
        private System.Windows.Forms.Button btnPublic;
        private System.Windows.Forms.Button btnCustomized;
        private System.Windows.Forms.Panel panelBody;
    }
}
