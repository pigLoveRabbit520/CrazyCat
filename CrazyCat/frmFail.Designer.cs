namespace CrayzyCat
{
    partial class frmFail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFail));
            this.pictExit = new System.Windows.Forms.PictureBox();
            this.picReplay = new System.Windows.Forms.PictureBox();
            this.picFail = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFail)).BeginInit();
            this.SuspendLayout();
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
            this.pictExit.TabIndex = 3;
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
            this.picReplay.TabIndex = 2;
            this.picReplay.TabStop = false;
            this.picReplay.Click += new System.EventHandler(this.picReplay_Click);
            // 
            // picFail
            // 
            this.picFail.BackColor = System.Drawing.SystemColors.Control;
            this.picFail.Dock = System.Windows.Forms.DockStyle.Top;
            this.picFail.Image = global::CrayzyCat.Properties.Resources.failed;
            this.picFail.Location = new System.Drawing.Point(0, 0);
            this.picFail.Name = "picFail";
            this.picFail.Size = new System.Drawing.Size(467, 354);
            this.picFail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFail.TabIndex = 1;
            this.picFail.TabStop = false;
            // 
            // frmFail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(467, 474);
            this.Controls.Add(this.pictExit);
            this.Controls.Add(this.picReplay);
            this.Controls.Add(this.picFail);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmFail";
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            ((System.ComponentModel.ISupportInitialize)(this.pictExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picFail;
        private System.Windows.Forms.PictureBox picReplay;
        private System.Windows.Forms.PictureBox pictExit;
    }
}