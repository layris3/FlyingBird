namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            this.bird = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.timer_bird = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.tree3 = new WindowsFormsApp1.Tree();
            this.tree2 = new WindowsFormsApp1.Tree();
            this.tree1 = new WindowsFormsApp1.Tree();
            this.timer_tree = new System.Windows.Forms.Timer(this.components);
            this.score = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer_IsCrash = new System.Windows.Forms.Timer(this.components);
            this.timer_score = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bird)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bird
            // 
            this.bird.BackColor = System.Drawing.Color.DarkKhaki;
            this.bird.Location = new System.Drawing.Point(297, 175);
            this.bird.Name = "bird";
            this.bird.Size = new System.Drawing.Size(29, 28);
            this.bird.TabIndex = 0;
            this.bird.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(312, 565);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 41);
            this.button1.TabIndex = 1;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer_bird
            // 
            this.timer_bird.Interval = 20;
            this.timer_bird.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.bird);
            this.panel1.Controls.Add(this.tree3);
            this.panel1.Controls.Add(this.tree2);
            this.panel1.Controls.Add(this.tree1);
            this.panel1.Location = new System.Drawing.Point(50, 110);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 396);
            this.panel1.TabIndex = 2;
            // 
            // tree3
            // 
            this.tree3.Location = new System.Drawing.Point(900, -17);
            this.tree3.Name = "tree3";
            this.tree3.Size = new System.Drawing.Size(75, 580);
            this.tree3.TabIndex = 1;
            // 
            // tree2
            // 
            this.tree2.Location = new System.Drawing.Point(700, -17);
            this.tree2.Name = "tree2";
            this.tree2.Size = new System.Drawing.Size(75, 580);
            this.tree2.TabIndex = 1;
            // 
            // tree1
            // 
            this.tree1.Location = new System.Drawing.Point(500, -17);
            this.tree1.Name = "tree1";
            this.tree1.Size = new System.Drawing.Size(75, 580);
            this.tree1.TabIndex = 1;
            // 
            // timer_tree
            // 
            this.timer_tree.Interval = 20;
            this.timer_tree.Tick += new System.EventHandler(this.timer_tree_Tick);
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score.Location = new System.Drawing.Point(424, 40);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(38, 43);
            this.score.TabIndex = 3;
            this.score.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(211, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "your score:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // timer_IsCrash
            // 
            this.timer_IsCrash.Interval = 20;
            this.timer_IsCrash.Tick += new System.EventHandler(this.timer_IsCrash_Tick);
            // 
            // timer_score
            // 
            this.timer_score.Interval = 20;
            this.timer_score.Tick += new System.EventHandler(this.timer_score_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 676);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.score);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.bird)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox bird;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer_bird;
        private System.Windows.Forms.Panel panel1;
        private Tree tree1;
        private System.Windows.Forms.Timer timer_tree;
        private Tree tree3;
        private Tree tree2;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer_IsCrash;
        private System.Windows.Forms.Timer timer_score;
    }
}

