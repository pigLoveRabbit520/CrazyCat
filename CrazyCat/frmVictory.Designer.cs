namespace CrayzyCat
{
    partial class frmVictory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVictory));
            this.picVictory = new System.Windows.Forms.PictureBox();
            this.pictExit = new System.Windows.Forms.PictureBox();
            this.picReplay = new System.Windows.Forms.PictureBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picVictory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReplay)).BeginInit();
            this.SuspendLayout();
            // 
            // picVictory
            // 
            this.picVictory.Dock = System.Windows.Forms.DockStyle.Top;
            this.picVictory.Image = global::CrayzyCat.Properties.Resources.victory;
            this.picVictory.Location = new System.Drawing.Point(0, 0);
            this.picVictory.Name = "picVictory";
            this.picVictory.Size = new System.Drawing.Size(467, 354);
            this.picVictory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picVictory.TabIndex = 0;
            this.picVictory.TabStop = false;
            // 
            // pictExit
            // 
            this.pictExit.BackColor = System.Drawing.Color.Transparent;
            this.pictExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictExit.Image = global::CrayzyCat.Properties.Resources.exit;
            this.pictExit.Location = new System.Drawing.Point(12, 372);
            this.pictExit.Name = "pictExit";
            this.pictExit.Size = new System.Drawing.Size(186, 90);
            this.pictExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictExit.TabIndex = 4;
            this.pictExit.TabStop = false;
            this.pictExit.Click += new System.EventHandler(this.pictExit_Click);
            // 
            // picReplay
            // 
            this.picReplay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.picReplay.BackColor = System.Drawing.Color.Transparent;
            this.picReplay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picReplay.Image = ((System.Drawing.Image)(resources.GetObject("picReplay.Image")));
            this.picReplay.Location = new System.Drawing.Point(269, 372);
            this.picReplay.Name = "picReplay";
            this.picReplay.Size = new System.Drawing.Size(186, 90);
            this.picReplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picReplay.TabIndex = 5;
            this.picReplay.TabStop = false;
            this.picReplay.Click += new System.EventHandler(this.picReplay_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.BackColor = System.Drawing.Color.White;
            this.lblInfo.Font = new System.Drawing.Font("新宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblInfo.ForeColor = System.Drawing.Color.Red;
            this.lblInfo.Location = new System.Drawing.Point(103, 161);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(261, 24);
            this.lblInfo.TabIndex = 6;
            this.lblInfo.Text = "您用10步抓住了神经猫";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.White;
            this.lblTitle.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTitle.Location = new System.Drawing.Point(104, 238);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(135, 24);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "获得称号：";
            // 
            // frmVictory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 474);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.picReplay);
            this.Controls.Add(this.pictExit);
            this.Controls.Add(this.picVictory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmVictory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmVictory";
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.Load += new System.EventHandler(this.frmVictory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picVictory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picVictory;
        private System.Windows.Forms.PictureBox pictExit;
        private System.Windows.Forms.PictureBox picReplay;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblTitle;
    }
}