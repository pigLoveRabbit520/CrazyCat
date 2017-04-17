namespace CrayzyCat
{
    partial class frmMain
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tmrShake = new System.Windows.Forms.Timer(this.components);
            this.picMainReplay = new System.Windows.Forms.PictureBox();
            this.picCat = new System.Windows.Forms.PictureBox();
            this.picBoard = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picMainReplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoard)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrShake
            // 
            this.tmrShake.Enabled = true;
            this.tmrShake.Interval = 38;
            this.tmrShake.Tick += new System.EventHandler(this.tmrShake_Tick);
            // 
            // picMainReplay
            // 
            this.picMainReplay.BackColor = System.Drawing.Color.Transparent;
            this.picMainReplay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picMainReplay.Image = global::CrayzyCat.Properties.Resources.replay_main;
            this.picMainReplay.Location = new System.Drawing.Point(193, 146);
            this.picMainReplay.Name = "picMainReplay";
            this.picMainReplay.Size = new System.Drawing.Size(33, 36);
            this.picMainReplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMainReplay.TabIndex = 2;
            this.picMainReplay.TabStop = false;
            this.picMainReplay.Click += new System.EventHandler(this.picReplay_Click);
            this.picMainReplay.MouseEnter += new System.EventHandler(this.picReplay_MouseEnter);
            this.picMainReplay.MouseLeave += new System.EventHandler(this.picReplay_MouseLeave);
            // 
            // picCat
            // 
            this.picCat.BackColor = System.Drawing.Color.Transparent;
            this.picCat.Location = new System.Drawing.Point(298, 414);
            this.picCat.Name = "picCat";
            this.picCat.Size = new System.Drawing.Size(48, 66);
            this.picCat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCat.TabIndex = 1;
            this.picCat.TabStop = false;
            this.picCat.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picCat_MouseClick);
            // 
            // picBoard
            // 
            this.picBoard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picBoard.BackgroundImage = global::CrayzyCat.Properties.Resources.bg;
            this.picBoard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBoard.Location = new System.Drawing.Point(12, 12);
            this.picBoard.Name = "picBoard";
            this.picBoard.Size = new System.Drawing.Size(488, 630);
            this.picBoard.TabIndex = 0;
            this.picBoard.TabStop = false;
            this.picBoard.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picBoard_MouseClick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 654);
            this.Controls.Add(this.picMainReplay);
            this.Controls.Add(this.picCat);
            this.Controls.Add(this.picBoard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "围住神经猫";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picMainReplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoard)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoard;
        private System.Windows.Forms.PictureBox picCat;
        private System.Windows.Forms.Timer tmrShake;
        private System.Windows.Forms.PictureBox picMainReplay;
    }
}

