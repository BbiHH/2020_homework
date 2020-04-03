namespace 文本框标签和按钮练习
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lb = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.btnRed = new System.Windows.Forms.Button();
            this.btnBlack = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(56, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(285, 25);
            this.textBox1.TabIndex = 0;
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Location = new System.Drawing.Point(53, 177);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(0, 15);
            this.lb.TabIndex = 1;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(53, 105);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(0, 15);
            this.label.TabIndex = 2;
            // 
            // btnRed
            // 
            this.btnRed.Location = new System.Drawing.Point(36, 151);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(68, 30);
            this.btnRed.TabIndex = 3;
            this.btnRed.Text = "红色";
            this.btnRed.UseVisualStyleBackColor = true;
            this.btnRed.Click += new System.EventHandler(this.btnRed_Click);
            // 
            // btnBlack
            // 
            this.btnBlack.Location = new System.Drawing.Point(148, 151);
            this.btnBlack.Name = "btnBlack";
            this.btnBlack.Size = new System.Drawing.Size(75, 30);
            this.btnBlack.TabIndex = 4;
            this.btnBlack.Text = "黑色";
            this.btnBlack.UseVisualStyleBackColor = true;
            this.btnBlack.Click += new System.EventHandler(this.btnBlack_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(255, 151);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(169, 30);
            this.btnCopy.TabIndex = 5;
            this.btnCopy.Text = "文本内容复制到标签";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 209);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnBlack);
            this.Controls.Add(this.btnRed);
            this.Controls.Add(this.label);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "文本框\\标签\\按钮";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button btnRed;
        private System.Windows.Forms.Button btnBlack;
        private System.Windows.Forms.Button btnCopy;
    }
}

