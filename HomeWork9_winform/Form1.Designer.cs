namespace HomeWork9_winform
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
            this.initialURLBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rightURLrichTextBox1 = new System.Windows.Forms.RichTextBox();
            this.wrongURLrichTextBox2 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // initialURLBox1
            // 
            this.initialURLBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.initialURLBox1.Location = new System.Drawing.Point(336, 122);
            this.initialURLBox1.Name = "initialURLBox1";
            this.initialURLBox1.Size = new System.Drawing.Size(368, 44);
            this.initialURLBox1.TabIndex = 0;
            this.initialURLBox1.TextChanged += new System.EventHandler(this.initialURLBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(118, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "初始URL";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(779, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 57);
            this.button1.TabIndex = 2;
            this.button1.Text = "开始爬虫";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(118, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "已爬取URL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(118, 516);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 33);
            this.label3.TabIndex = 4;
            this.label3.Text = "错误URL";
            // 
            // rightURLrichTextBox1
            // 
            this.rightURLrichTextBox1.Location = new System.Drawing.Point(336, 254);
            this.rightURLrichTextBox1.Name = "rightURLrichTextBox1";
            this.rightURLrichTextBox1.Size = new System.Drawing.Size(631, 190);
            this.rightURLrichTextBox1.TabIndex = 5;
            this.rightURLrichTextBox1.Text = "";
            this.rightURLrichTextBox1.TextChanged += new System.EventHandler(this.rightURLrichTextBox1_TextChanged);
            // 
            // wrongURLrichTextBox2
            // 
            this.wrongURLrichTextBox2.Location = new System.Drawing.Point(336, 516);
            this.wrongURLrichTextBox2.Name = "wrongURLrichTextBox2";
            this.wrongURLrichTextBox2.Size = new System.Drawing.Size(631, 222);
            this.wrongURLrichTextBox2.TabIndex = 6;
            this.wrongURLrichTextBox2.Text = "";
            this.wrongURLrichTextBox2.TextChanged += new System.EventHandler(this.wrongURLrichTextBox2_TextChanged);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1286, 779);
            this.Controls.Add(this.wrongURLrichTextBox2);
            this.Controls.Add(this.rightURLrichTextBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.initialURLBox1);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox initialURLTextBox1;
        private System.Windows.Forms.TextBox initialURLBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rightURLrichTextBox1;
        private System.Windows.Forms.RichTextBox wrongURLrichTextBox2;
    }
}

