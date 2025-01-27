namespace MyNotePad
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新建CTRLNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存CTRLEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.另存为ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开CTRLOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.撤销ZCTRLZToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.复制CTRLCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.剪切CTRLEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除CTRLDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.粘贴CTRLVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.全选CTRLAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查找ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.替换RCTRLRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.替换使用说明ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.格式SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.字体FCTRLFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.背景颜色BCTRLBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.字体颜色ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.日历CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.statusStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.编辑EToolStripMenuItem,
            this.格式SToolStripMenuItem,
            this.关于ToolStripMenuItem,
            this.帮助HToolStripMenuItem,
            this.日历CToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1140, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建CTRLNToolStripMenuItem,
            this.保存CTRLEToolStripMenuItem,
            this.另存为ToolStripMenuItem,
            this.打开CTRLOToolStripMenuItem,
            this.撤销ZCTRLZToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(91, 24);
            this.文件ToolStripMenuItem.Text = "文件（&F）";
            this.文件ToolStripMenuItem.Click += new System.EventHandler(this.文件ToolStripMenuItem_Click);
            // 
            // 新建CTRLNToolStripMenuItem
            // 
            this.新建CTRLNToolStripMenuItem.BackColor = System.Drawing.SystemColors.Window;
            this.新建CTRLNToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.新建CTRLNToolStripMenuItem.Name = "新建CTRLNToolStripMenuItem";
            this.新建CTRLNToolStripMenuItem.ShowShortcutKeys = false;
            this.新建CTRLNToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.新建CTRLNToolStripMenuItem.Text = "新建(&N） Ctrl+N";
            this.新建CTRLNToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.新建CTRLNToolStripMenuItem.Click += new System.EventHandler(this.新建CTRLNToolStripMenuItem_Click);
            // 
            // 保存CTRLEToolStripMenuItem
            // 
            this.保存CTRLEToolStripMenuItem.Name = "保存CTRLEToolStripMenuItem";
            this.保存CTRLEToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.保存CTRLEToolStripMenuItem.Text = "保存(&S) CTRL+S";
            this.保存CTRLEToolStripMenuItem.Click += new System.EventHandler(this.保存CTRLEToolStripMenuItem_Click);
            // 
            // 另存为ToolStripMenuItem
            // 
            this.另存为ToolStripMenuItem.Name = "另存为ToolStripMenuItem";
            this.另存为ToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.另存为ToolStripMenuItem.Text = "另存为";
            this.另存为ToolStripMenuItem.Click += new System.EventHandler(this.另存为ToolStripMenuItem_Click);
            // 
            // 打开CTRLOToolStripMenuItem
            // 
            this.打开CTRLOToolStripMenuItem.Name = "打开CTRLOToolStripMenuItem";
            this.打开CTRLOToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.打开CTRLOToolStripMenuItem.Text = "打开(&O) CTRL+O";
            this.打开CTRLOToolStripMenuItem.Click += new System.EventHandler(this.打开CTRLOToolStripMenuItem_Click);
            // 
            // 撤销ZCTRLZToolStripMenuItem
            // 
            this.撤销ZCTRLZToolStripMenuItem.Name = "撤销ZCTRLZToolStripMenuItem";
            this.撤销ZCTRLZToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.撤销ZCTRLZToolStripMenuItem.Text = "撤销（&Z）CTRL+Z";
            this.撤销ZCTRLZToolStripMenuItem.Click += new System.EventHandler(this.撤销ZCTRLZToolStripMenuItem_Click);
            // 
            // 编辑EToolStripMenuItem
            // 
            this.编辑EToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.复制CTRLCToolStripMenuItem,
            this.剪切CTRLEToolStripMenuItem,
            this.删除CTRLDToolStripMenuItem,
            this.粘贴CTRLVToolStripMenuItem,
            this.全选CTRLAToolStripMenuItem,
            this.查找ToolStripMenuItem,
            this.替换RCTRLRToolStripMenuItem,
            this.toolStripMenuItem1});
            this.编辑EToolStripMenuItem.Name = "编辑EToolStripMenuItem";
            this.编辑EToolStripMenuItem.Size = new System.Drawing.Size(91, 24);
            this.编辑EToolStripMenuItem.Text = "编辑（&E）";
            // 
            // 复制CTRLCToolStripMenuItem
            // 
            this.复制CTRLCToolStripMenuItem.Name = "复制CTRLCToolStripMenuItem";
            this.复制CTRLCToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.复制CTRLCToolStripMenuItem.Text = "复制(&C) CTRL+C";
            this.复制CTRLCToolStripMenuItem.Click += new System.EventHandler(this.复制CTRLCToolStripMenuItem_Click);
            // 
            // 剪切CTRLEToolStripMenuItem
            // 
            this.剪切CTRLEToolStripMenuItem.Name = "剪切CTRLEToolStripMenuItem";
            this.剪切CTRLEToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.剪切CTRLEToolStripMenuItem.Text = "剪切(&E) CTRL+E";
            this.剪切CTRLEToolStripMenuItem.Click += new System.EventHandler(this.剪切CTRLEToolStripMenuItem_Click);
            // 
            // 删除CTRLDToolStripMenuItem
            // 
            this.删除CTRLDToolStripMenuItem.Name = "删除CTRLDToolStripMenuItem";
            this.删除CTRLDToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.删除CTRLDToolStripMenuItem.Text = "删除(&D) CTRL+D";
            this.删除CTRLDToolStripMenuItem.Click += new System.EventHandler(this.删除CTRLDToolStripMenuItem_Click);
            // 
            // 粘贴CTRLVToolStripMenuItem
            // 
            this.粘贴CTRLVToolStripMenuItem.Name = "粘贴CTRLVToolStripMenuItem";
            this.粘贴CTRLVToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.粘贴CTRLVToolStripMenuItem.Text = "粘贴(&V) CTRL+V";
            this.粘贴CTRLVToolStripMenuItem.Click += new System.EventHandler(this.粘贴CTRLVToolStripMenuItem_Click);
            // 
            // 全选CTRLAToolStripMenuItem
            // 
            this.全选CTRLAToolStripMenuItem.Name = "全选CTRLAToolStripMenuItem";
            this.全选CTRLAToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.全选CTRLAToolStripMenuItem.Text = "全选(&A) CTRL+A";
            this.全选CTRLAToolStripMenuItem.Click += new System.EventHandler(this.全选CTRLAToolStripMenuItem_Click);
            // 
            // 查找ToolStripMenuItem
            // 
            this.查找ToolStripMenuItem.Name = "查找ToolStripMenuItem";
            this.查找ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.查找ToolStripMenuItem.Text = "查找(&F) ctrl+F";
            this.查找ToolStripMenuItem.Click += new System.EventHandler(this.查找ToolStripMenuItem_Click);
            // 
            // 替换RCTRLRToolStripMenuItem
            // 
            this.替换RCTRLRToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.替换使用说明ToolStripMenuItem});
            this.替换RCTRLRToolStripMenuItem.Name = "替换RCTRLRToolStripMenuItem";
            this.替换RCTRLRToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.替换RCTRLRToolStripMenuItem.Text = "替换（&R） CTRL+R";
            this.替换RCTRLRToolStripMenuItem.Click += new System.EventHandler(this.替换RCTRLRToolStripMenuItem_Click);
            // 
            // 替换使用说明ToolStripMenuItem
            // 
            this.替换使用说明ToolStripMenuItem.Name = "替换使用说明ToolStripMenuItem";
            this.替换使用说明ToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.替换使用说明ToolStripMenuItem.Text = "替换使用说明";
            this.替换使用说明ToolStripMenuItem.Click += new System.EventHandler(this.替换使用说明ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.toolStripMenuItem1.Text = "查找下一个";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // 格式SToolStripMenuItem
            // 
            this.格式SToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.字体FCTRLFToolStripMenuItem,
            this.背景颜色BCTRLBToolStripMenuItem,
            this.字体颜色ToolStripMenuItem});
            this.格式SToolStripMenuItem.Name = "格式SToolStripMenuItem";
            this.格式SToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            this.格式SToolStripMenuItem.Text = "格式（&T）";
            // 
            // 字体FCTRLFToolStripMenuItem
            // 
            this.字体FCTRLFToolStripMenuItem.Name = "字体FCTRLFToolStripMenuItem";
            this.字体FCTRLFToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.字体FCTRLFToolStripMenuItem.Text = "字体（&F）CTRL+F";
            this.字体FCTRLFToolStripMenuItem.Click += new System.EventHandler(this.字体FCTRLFToolStripMenuItem_Click);
            // 
            // 背景颜色BCTRLBToolStripMenuItem
            // 
            this.背景颜色BCTRLBToolStripMenuItem.Name = "背景颜色BCTRLBToolStripMenuItem";
            this.背景颜色BCTRLBToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.背景颜色BCTRLBToolStripMenuItem.Text = "背景颜色（&B) CTRL+B";
            this.背景颜色BCTRLBToolStripMenuItem.Click += new System.EventHandler(this.背景颜色BCTRLBToolStripMenuItem_Click);
            // 
            // 字体颜色ToolStripMenuItem
            // 
            this.字体颜色ToolStripMenuItem.Name = "字体颜色ToolStripMenuItem";
            this.字体颜色ToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.字体颜色ToolStripMenuItem.Text = "字体颜色 ";
            this.字体颜色ToolStripMenuItem.Click += new System.EventHandler(this.字体颜色ToolStripMenuItem_Click);
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.关于ToolStripMenuItem.Text = "关于";
            this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
            // 
            // 帮助HToolStripMenuItem
            // 
            this.帮助HToolStripMenuItem.Name = "帮助HToolStripMenuItem";
            this.帮助HToolStripMenuItem.Size = new System.Drawing.Size(95, 24);
            this.帮助HToolStripMenuItem.Text = "帮助（&H）";
            this.帮助HToolStripMenuItem.Click += new System.EventHandler(this.帮助HToolStripMenuItem_Click);
            // 
            // 日历CToolStripMenuItem
            // 
            this.日历CToolStripMenuItem.Name = "日历CToolStripMenuItem";
            this.日历CToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.日历CToolStripMenuItem.Text = "日历（&C）";
            this.日历CToolStripMenuItem.Click += new System.EventHandler(this.日历CToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripButton5,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1140, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton1.Text = "显示行数";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton2.Text = "显示列数";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton3.Text = "保存";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton4.Text = "另存为";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton5.Text = "显示时间：";
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(381, 24);
            this.toolStripLabel1.Text = "时间不会动态更新，但可以通过多次点击“显示时间“选项";
            // 
            // richTextBox1
            // 
            this.richTextBox1.AcceptsTab = true;
            this.richTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.HideSelection = false;
            this.richTextBox1.Location = new System.Drawing.Point(0, 55);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1140, 624);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            this.richTextBox1.SelectionChanged += new System.EventHandler(this.richTextBox1_SelectionChanged_1);
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            this.richTextBox1.Enter += new System.EventHandler(this.richTextBox1_Enter);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 653);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1140, 26);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(69, 20);
            this.toolStripStatusLabel1.Text = "小康制作";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "ofd1";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkVisited = true;
            this.linkLabel1.Location = new System.Drawing.Point(365, 661);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(858, 18);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://www.bilibili.com/video/BV1GJ411x7h7?spm_id_from=333.337.search-card.all.c" +
    "lick";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 661);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "更多好康的【doge】->";
            // 
            // statusStrip2
            // 
            this.statusStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2});
            this.statusStrip2.Location = new System.Drawing.Point(0, 627);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(1140, 26);
            this.statusStrip2.TabIndex = 6;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(46, 20);
            this.toolStripStatusLabel2.Text = "ANIC";
            this.toolStripStatusLabel2.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.toolStripStatusLabel2.Click += new System.EventHandler(this.toolStripStatusLabel2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(427, 635);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "行数：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(570, 635);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "列数：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(481, 635);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(618, 635);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "label5";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.LinkVisited = true;
            this.linkLabel2.Location = new System.Drawing.Point(438, 28);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(1426, 18);
            this.linkLabel2.TabIndex = 11;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "https://cn.bing.com/search?q=获取有关+windows&中的记事本的帮助&filters=guid:\"4466414-zh-hans-" +
    "dia\"%20lang:\"zh-hans\"&form=T00032&ocid=HelpPane-BingIA";
            this.linkLabel2.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(799, 635);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 18);
            this.label6.TabIndex = 13;
            this.label6.Text = "当前时间：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(891, 635);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 18);
            this.label7.TabIndex = 14;
            this.label7.Text = "label7";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 679);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.statusStrip2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyNotePad";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 编辑EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 格式SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新建CTRLNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存CTRLEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 另存为ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开CTRLOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 复制CTRLCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 剪切CTRLEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除CTRLDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 粘贴CTRLVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 全选CTRLAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 字体FCTRLFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 背景颜色BCTRLBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 字体颜色ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 撤销ZCTRLZToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查找ToolStripMenuItem;
        public System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripMenuItem 替换RCTRLRToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 替换使用说明ToolStripMenuItem;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem 帮助HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 日历CToolStripMenuItem;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
    }
}

