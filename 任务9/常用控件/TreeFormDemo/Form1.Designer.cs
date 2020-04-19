namespace TreeFormDemo
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
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("打开");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("新建");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("设置");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("文件", new System.Windows.Forms.TreeNode[] {
            treeNode14,
            treeNode15,
            treeNode16});
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("剪切");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("撤销");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("编辑", new System.Windows.Forms.TreeNode[] {
            treeNode18,
            treeNode19});
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("起始页");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("工具箱");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("视图", new System.Windows.Forms.TreeNode[] {
            treeNode21,
            treeNode22});
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("进入官方网页");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("关于系统");
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("帮助", new System.Windows.Forms.TreeNode[] {
            treeNode24,
            treeNode25});
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.视图ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新建ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.剪切ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.撤销ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.起始页ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.工具箱ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.进入关方网页ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.编辑ToolStripMenuItem,
            this.视图ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(163, 110);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(637, 340);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(0, 110);
            this.treeView1.Name = "treeView1";
            treeNode14.Name = "节点5";
            treeNode14.Text = "打开";
            treeNode15.Name = "节点6";
            treeNode15.Text = "新建";
            treeNode16.Name = "节点7";
            treeNode16.Text = "设置";
            treeNode17.Name = "节点0";
            treeNode17.Text = "文件";
            treeNode18.Name = "节点8";
            treeNode18.Text = "剪切";
            treeNode19.Name = "节点9";
            treeNode19.Text = "撤销";
            treeNode20.Name = "节点1";
            treeNode20.Text = "编辑";
            treeNode21.Name = "节点11";
            treeNode21.Text = "起始页";
            treeNode22.Name = "节点12";
            treeNode22.Text = "工具箱";
            treeNode23.Name = "节点2";
            treeNode23.Text = "视图";
            treeNode24.Name = "节点13";
            treeNode24.Text = "进入官方网页";
            treeNode25.Name = "节点14";
            treeNode25.Text = "关于系统";
            treeNode26.Name = "节点3";
            treeNode26.Text = "帮助";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode17,
            treeNode20,
            treeNode23,
            treeNode26});
            this.treeView1.Size = new System.Drawing.Size(157, 340);
            this.treeView1.TabIndex = 3;
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开ToolStripMenuItem,
            this.新建ToolStripMenuItem,
            this.设置ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 编辑ToolStripMenuItem
            // 
            this.编辑ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.剪切ToolStripMenuItem,
            this.撤销ToolStripMenuItem});
            this.编辑ToolStripMenuItem.Name = "编辑ToolStripMenuItem";
            this.编辑ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.编辑ToolStripMenuItem.Text = "编辑";
            // 
            // 视图ToolStripMenuItem
            // 
            this.视图ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.起始页ToolStripMenuItem,
            this.工具箱ToolStripMenuItem});
            this.视图ToolStripMenuItem.Name = "视图ToolStripMenuItem";
            this.视图ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.视图ToolStripMenuItem.Text = "视图";
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.进入关方网页ToolStripMenuItem,
            this.关于系统ToolStripMenuItem});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // 打开ToolStripMenuItem
            // 
            this.打开ToolStripMenuItem.Name = "打开ToolStripMenuItem";
            this.打开ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.打开ToolStripMenuItem.Text = "打开";
            // 
            // 新建ToolStripMenuItem
            // 
            this.新建ToolStripMenuItem.Name = "新建ToolStripMenuItem";
            this.新建ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.新建ToolStripMenuItem.Text = "新建";
            // 
            // 设置ToolStripMenuItem
            // 
            this.设置ToolStripMenuItem.Name = "设置ToolStripMenuItem";
            this.设置ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.设置ToolStripMenuItem.Text = "设置";
            // 
            // 剪切ToolStripMenuItem
            // 
            this.剪切ToolStripMenuItem.Name = "剪切ToolStripMenuItem";
            this.剪切ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.剪切ToolStripMenuItem.Text = "剪切";
            // 
            // 撤销ToolStripMenuItem
            // 
            this.撤销ToolStripMenuItem.Name = "撤销ToolStripMenuItem";
            this.撤销ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.撤销ToolStripMenuItem.Text = "撤销";
            // 
            // 起始页ToolStripMenuItem
            // 
            this.起始页ToolStripMenuItem.Name = "起始页ToolStripMenuItem";
            this.起始页ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.起始页ToolStripMenuItem.Text = "起始页";
            // 
            // 工具箱ToolStripMenuItem
            // 
            this.工具箱ToolStripMenuItem.Name = "工具箱ToolStripMenuItem";
            this.工具箱ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.工具箱ToolStripMenuItem.Text = "工具箱";
            // 
            // 进入关方网页ToolStripMenuItem
            // 
            this.进入关方网页ToolStripMenuItem.Name = "进入关方网页ToolStripMenuItem";
            this.进入关方网页ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.进入关方网页ToolStripMenuItem.Text = "进入关方网页";
            // 
            // 关于系统ToolStripMenuItem
            // 
            this.关于系统ToolStripMenuItem.Name = "关于系统ToolStripMenuItem";
            this.关于系统ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.关于系统ToolStripMenuItem.Text = "关于系统";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新建ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 编辑ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 剪切ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 撤销ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 视图ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 起始页ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 工具箱ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 进入关方网页ToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ToolStripMenuItem 关于系统ToolStripMenuItem;
    }
}

