namespace zSession.Session
{
    partial class SessionPanel
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SessionPanel));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("节点0", 1, 1);
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("节点3", 2, 2);
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("节点4");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("节点1", 3, 3, new System.Windows.Forms.TreeNode[] {
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("节点5");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("节点2", 4, 4, new System.Windows.Forms.TreeNode[] {
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("节点0", 3, 3);
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("节点0", 0, 0, new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode4,
            treeNode6,
            treeNode7});
            this.tpMain = new System.Windows.Forms.TableLayoutPanel();
            this.tpHeader = new System.Windows.Forms.TableLayoutPanel();
            this.btnCorporation = new System.Windows.Forms.Button();
            this.btnPersonal = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tpBody = new System.Windows.Forms.TableLayoutPanel();
            this.flpGroup = new System.Windows.Forms.FlowLayoutPanel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panelBody = new System.Windows.Forms.Panel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.ctMSTools = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiSend = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiView = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDel = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiStop = new System.Windows.Forms.ToolStripMenuItem();
            this.tpMain.SuspendLayout();
            this.tpHeader.SuspendLayout();
            this.tpBody.SuspendLayout();
            this.panelBody.SuspendLayout();
            this.ctMSTools.SuspendLayout();
            this.SuspendLayout();
            // 
            // tpMain
            // 
            this.tpMain.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tpMain.ColumnCount = 1;
            this.tpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpMain.Controls.Add(this.tpHeader, 0, 0);
            this.tpMain.Controls.Add(this.tpBody, 0, 1);
            this.tpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpMain.Location = new System.Drawing.Point(0, 0);
            this.tpMain.Name = "tpMain";
            this.tpMain.RowCount = 2;
            this.tpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tpMain.Size = new System.Drawing.Size(449, 545);
            this.tpMain.TabIndex = 0;
            // 
            // tpHeader
            // 
            this.tpHeader.BackColor = System.Drawing.Color.Transparent;
            this.tpHeader.ColumnCount = 3;
            this.tpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1F));
            this.tpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tpHeader.Controls.Add(this.btnCorporation, 2, 0);
            this.tpHeader.Controls.Add(this.btnPersonal, 0, 0);
            this.tpHeader.Controls.Add(this.label2, 1, 0);
            this.tpHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpHeader.Location = new System.Drawing.Point(3, 3);
            this.tpHeader.Margin = new System.Windows.Forms.Padding(0);
            this.tpHeader.Name = "tpHeader";
            this.tpHeader.RowCount = 1;
            this.tpHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpHeader.Size = new System.Drawing.Size(443, 24);
            this.tpHeader.TabIndex = 5;
            // 
            // btnCorporation
            // 
            this.btnCorporation.BackColor = System.Drawing.Color.Transparent;
            this.btnCorporation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCorporation.FlatAppearance.BorderSize = 0;
            this.btnCorporation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCorporation.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCorporation.ForeColor = System.Drawing.Color.DarkRed;
            this.btnCorporation.Location = new System.Drawing.Point(222, 0);
            this.btnCorporation.Margin = new System.Windows.Forms.Padding(0);
            this.btnCorporation.Name = "btnCorporation";
            this.btnCorporation.Size = new System.Drawing.Size(221, 24);
            this.btnCorporation.TabIndex = 1;
            this.btnCorporation.Tag = "Corporation";
            this.btnCorporation.Text = "团体";
            this.btnCorporation.UseVisualStyleBackColor = false;
            this.btnCorporation.Click += new System.EventHandler(this.btnCorporation_Click);
            // 
            // btnPersonal
            // 
            this.btnPersonal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPersonal.FlatAppearance.BorderSize = 0;
            this.btnPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPersonal.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPersonal.ForeColor = System.Drawing.Color.DarkRed;
            this.btnPersonal.Location = new System.Drawing.Point(0, 0);
            this.btnPersonal.Margin = new System.Windows.Forms.Padding(0);
            this.btnPersonal.Name = "btnPersonal";
            this.btnPersonal.Size = new System.Drawing.Size(221, 24);
            this.btnPersonal.TabIndex = 2;
            this.btnPersonal.Tag = "Personal";
            this.btnPersonal.Text = "个人";
            this.btnPersonal.UseVisualStyleBackColor = true;
            this.btnPersonal.Click += new System.EventHandler(this.btnPersonal_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(221, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1, 24);
            this.label2.TabIndex = 3;
            // 
            // tpBody
            // 
            this.tpBody.BackColor = System.Drawing.Color.Transparent;
            this.tpBody.ColumnCount = 1;
            this.tpBody.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpBody.Controls.Add(this.flpGroup, 0, 0);
            this.tpBody.Controls.Add(this.panelBody, 0, 1);
            this.tpBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpBody.Location = new System.Drawing.Point(6, 33);
            this.tpBody.Name = "tpBody";
            this.tpBody.RowCount = 2;
            this.tpBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tpBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpBody.Size = new System.Drawing.Size(437, 506);
            this.tpBody.TabIndex = 9;
            // 
            // flpGroup
            // 
            this.flpGroup.BackColor = System.Drawing.Color.Transparent;
            this.flpGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpGroup.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Bold);
            this.flpGroup.Location = new System.Drawing.Point(0, 0);
            this.flpGroup.Margin = new System.Windows.Forms.Padding(0);
            this.flpGroup.Name = "flpGroup";
            this.flpGroup.Size = new System.Drawing.Size(437, 24);
            this.flpGroup.TabIndex = 10;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "home.ico");
            this.imageList1.Images.SetKeyName(1, "Academic.ico");
            this.imageList1.Images.SetKeyName(2, "Company.ico");
            this.imageList1.Images.SetKeyName(3, "non-profit.ico");
            this.imageList1.Images.SetKeyName(4, "Party.ico");
            // 
            // panelBody
            // 
            this.panelBody.Controls.Add(this.treeView1);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(0, 24);
            this.panelBody.Margin = new System.Windows.Forms.Padding(0);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(437, 482);
            this.panelBody.TabIndex = 11;
            // 
            // treeView1
            // 
            this.treeView1.ContextMenuStrip = this.ctMSTools;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Font = new System.Drawing.Font("华文楷体", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode1.ContextMenuStrip = this.ctMSTools;
            treeNode1.ImageIndex = 1;
            treeNode1.Name = "节点0";
            treeNode1.SelectedImageIndex = 1;
            treeNode1.Text = "节点0";
            treeNode2.ImageIndex = 2;
            treeNode2.Name = "节点3";
            treeNode2.SelectedImageIndex = 2;
            treeNode2.Text = "节点3";
            treeNode3.Name = "节点4";
            treeNode3.Text = "节点4";
            treeNode4.ImageIndex = 3;
            treeNode4.Name = "节点1";
            treeNode4.SelectedImageIndex = 3;
            treeNode4.Text = "节点1";
            treeNode5.Name = "节点5";
            treeNode5.Text = "节点5";
            treeNode6.ImageIndex = 4;
            treeNode6.Name = "节点2";
            treeNode6.SelectedImageIndex = 4;
            treeNode6.Text = "节点2";
            treeNode7.ImageIndex = 3;
            treeNode7.Name = "节点0";
            treeNode7.SelectedImageIndex = 3;
            treeNode7.Text = "节点0";
            treeNode8.ContextMenuStrip = this.ctMSTools;
            treeNode8.ImageIndex = 0;
            treeNode8.Name = "节点0";
            treeNode8.SelectedImageIndex = 0;
            treeNode8.Text = "节点0";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode8});
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(437, 482);
            this.treeView1.TabIndex = 12;
            // 
            // ctMSTools
            // 
            this.ctMSTools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSearch,
            this.tsmiView,
            this.tsmiSend,
            this.toolStripSeparator1,
            this.tsmiAdd,
            this.tsmiDel,
            this.tsmiStop});
            this.ctMSTools.Name = "ctMSTools";
            this.ctMSTools.Size = new System.Drawing.Size(125, 142);
            // 
            // tsmiSend
            // 
            this.tsmiSend.Image = global::zSession.Properties.Resources.SendMessage;
            this.tsmiSend.Name = "tsmiSend";
            this.tsmiSend.Size = new System.Drawing.Size(124, 22);
            this.tsmiSend.Text = "发送消息";
            // 
            // tsmiSearch
            // 
            this.tsmiSearch.Image = global::zSession.Properties.Resources.search2;
            this.tsmiSearch.Name = "tsmiSearch";
            this.tsmiSearch.Size = new System.Drawing.Size(124, 22);
            this.tsmiSearch.Text = "查找";
            // 
            // tsmiView
            // 
            this.tsmiView.Image = global::zSession.Properties.Resources.chat_info;
            this.tsmiView.Name = "tsmiView";
            this.tsmiView.Size = new System.Drawing.Size(124, 22);
            this.tsmiView.Text = "查看消息";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(121, 6);
            // 
            // tsmiAdd
            // 
            this.tsmiAdd.Image = global::zSession.Properties.Resources.add;
            this.tsmiAdd.Name = "tsmiAdd";
            this.tsmiAdd.Size = new System.Drawing.Size(124, 22);
            this.tsmiAdd.Text = "增加";
            // 
            // tsmiDel
            // 
            this.tsmiDel.Image = global::zSession.Properties.Resources.delete;
            this.tsmiDel.Name = "tsmiDel";
            this.tsmiDel.Size = new System.Drawing.Size(124, 22);
            this.tsmiDel.Text = "删除";
            // 
            // tsmiStop
            // 
            this.tsmiStop.Image = global::zSession.Properties.Resources.delete_alt;
            this.tsmiStop.Name = "tsmiStop";
            this.tsmiStop.Size = new System.Drawing.Size(124, 22);
            this.tsmiStop.Text = "静音";
            // 
            // SessionPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tpMain);
            this.Name = "SessionPanel";
            this.Size = new System.Drawing.Size(449, 545);
            this.tpMain.ResumeLayout(false);
            this.tpHeader.ResumeLayout(false);
            this.tpHeader.PerformLayout();
            this.tpBody.ResumeLayout(false);
            this.panelBody.ResumeLayout(false);
            this.ctMSTools.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tpMain;
        private System.Windows.Forms.Button btnCorporation;
        private System.Windows.Forms.Button btnPersonal;
        private System.Windows.Forms.TableLayoutPanel tpBody;
        private System.Windows.Forms.FlowLayoutPanel flpGroup;
        private System.Windows.Forms.TableLayoutPanel tpHeader;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ContextMenuStrip ctMSTools;
        private System.Windows.Forms.ToolStripMenuItem tsmiSearch;
        private System.Windows.Forms.ToolStripMenuItem tsmiView;
        private System.Windows.Forms.ToolStripMenuItem tsmiSend;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiAdd;
        private System.Windows.Forms.ToolStripMenuItem tsmiDel;
        private System.Windows.Forms.ToolStripMenuItem tsmiStop;
    }
}
