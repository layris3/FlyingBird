namespace WindowsFormsApp1
{
    partial class Tree
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
            this.upTree = new System.Windows.Forms.PictureBox();
            this.downTree = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.upTree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.downTree)).BeginInit();
            this.SuspendLayout();
            // 
            // upTree
            // 
            this.upTree.BackColor = System.Drawing.Color.Green;
            this.upTree.Location = new System.Drawing.Point(0, 0);
            this.upTree.Name = "upTree";
            this.upTree.Size = new System.Drawing.Size(75, 189);
            this.upTree.TabIndex = 0;
            this.upTree.TabStop = false;
            // 
            // downTree
            // 
            this.downTree.BackColor = System.Drawing.Color.Green;
            this.downTree.Location = new System.Drawing.Point(0, 391);
            this.downTree.Name = "downTree";
            this.downTree.Size = new System.Drawing.Size(75, 189);
            this.downTree.TabIndex = 0;
            this.downTree.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Tree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.downTree);
            this.Controls.Add(this.upTree);
            this.Name = "Tree";
            this.Size = new System.Drawing.Size(75, 580);
            ((System.ComponentModel.ISupportInitialize)(this.upTree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.downTree)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox upTree;
        private System.Windows.Forms.PictureBox downTree;
        private System.Windows.Forms.Timer timer1;
        public int UptreeLeftDownPoint { get { return this.Location.Y + upTree.Height; } }
        public int DowntreeLeftUpPoint { get { return this.Location.Y + downTree.Location.Y; } }
    }
}
