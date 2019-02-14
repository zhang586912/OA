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
            this.tpMain = new System.Windows.Forms.TableLayoutPanel();
            this.journalAndSchedule1 = new zSession.Assistant.Journal.JournalAndSchedule();
            this.projectManagement1 = new zSession.Assistant.project.ProjectManagement();
            this.tpMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tpMain
            // 
            this.tpMain.ColumnCount = 1;
            this.tpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpMain.Controls.Add(this.journalAndSchedule1, 0, 1);
            this.tpMain.Controls.Add(this.projectManagement1, 0, 0);
            this.tpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpMain.Location = new System.Drawing.Point(0, 0);
            this.tpMain.Name = "tpMain";
            this.tpMain.RowCount = 2;
            this.tpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tpMain.Size = new System.Drawing.Size(386, 629);
            this.tpMain.TabIndex = 0;
            // 
            // journalAndSchedule1
            // 
            this.journalAndSchedule1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.journalAndSchedule1.Location = new System.Drawing.Point(3, 380);
            this.journalAndSchedule1.Name = "journalAndSchedule1";
            this.journalAndSchedule1.Size = new System.Drawing.Size(380, 246);
            this.journalAndSchedule1.TabIndex = 6;
            // 
            // projectManagement1
            // 
            this.projectManagement1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.projectManagement1.Location = new System.Drawing.Point(3, 3);
            this.projectManagement1.Name = "projectManagement1";
            this.projectManagement1.Size = new System.Drawing.Size(380, 371);
            this.projectManagement1.TabIndex = 8;
            // 
            // AssistantPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tpMain);
            this.Name = "AssistantPanel";
            this.Size = new System.Drawing.Size(386, 629);
            this.tpMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tpMain;
        private JournalAndSchedule journalAndSchedule1;
        private project.ProjectManagement projectManagement1;
    }
}
