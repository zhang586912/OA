using zSession.Assistant.Intelligent;
using zSession.Assistant.Journal;

namespace zSession.Assistant
{
    partial class AssistantPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssistantPanel));
            this.tpMain = new System.Windows.Forms.TableLayoutPanel();
            this.journalAndSchedule1 = new zSession.Assistant.Journal.JournalAndSchedule();
            this.projectManagement1 = new zSession.Assistant.project.ProjectManagement();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.tpMain.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tpMain
            // 
            this.tpMain.ColumnCount = 1;
            this.tpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpMain.Controls.Add(this.journalAndSchedule1, 0, 3);
            this.tpMain.Controls.Add(this.projectManagement1, 0, 1);
            this.tpMain.Controls.Add(this.toolStrip1, 0, 0);
            this.tpMain.Controls.Add(this.toolStrip2, 0, 2);
            this.tpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpMain.Location = new System.Drawing.Point(0, 0);
            this.tpMain.Name = "tpMain";
            this.tpMain.RowCount = 4;
            this.tpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tpMain.Size = new System.Drawing.Size(386, 629);
            this.tpMain.TabIndex = 0;
            // 
            // journalAndSchedule1
            // 
            this.journalAndSchedule1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.journalAndSchedule1.Location = new System.Drawing.Point(3, 401);
            this.journalAndSchedule1.Name = "journalAndSchedule1";
            this.journalAndSchedule1.Size = new System.Drawing.Size(380, 225);
            this.journalAndSchedule1.TabIndex = 6;
            // 
            // projectManagement1
            // 
            this.projectManagement1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.projectManagement1.Location = new System.Drawing.Point(3, 29);
            this.projectManagement1.Name = "projectManagement1";
            this.projectManagement1.Size = new System.Drawing.Size(380, 340);
            this.projectManagement1.TabIndex = 8;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(386, 26);
            this.toolStrip1.TabIndex = 9;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton2,
            this.toolStripButton4});
            this.toolStrip2.Location = new System.Drawing.Point(0, 372);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(386, 26);
            this.toolStrip2.TabIndex = 10;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(76, 23);
            this.toolStripButton1.Text = "项目管理";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(76, 23);
            this.toolStripButton2.Text = "日程安排";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::zSession.Properties.Resources.sign_fixed;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 23);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = global::zSession.Properties.Resources.sign_fixed;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 23);
            this.toolStripButton4.Text = "toolStripButton4";
            // 
            // AssistantPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tpMain);
            this.Name = "AssistantPanel";
            this.Size = new System.Drawing.Size(386, 629);
            this.tpMain.ResumeLayout(false);
            this.tpMain.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tpMain;
        private JournalAndSchedule journalAndSchedule1;
        private project.ProjectManagement projectManagement1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
    }
}
