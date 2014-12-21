namespace comparission_smooting_method
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.openImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openID = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Location = new System.Drawing.Point(2, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(375, 254);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openImageToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1185, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // openImageToolStripMenuItem
            // 
            this.openImageToolStripMenuItem.Name = "openImageToolStripMenuItem";
            this.openImageToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.openImageToolStripMenuItem.Text = "Open Image";
            this.openImageToolStripMenuItem.Click += new System.EventHandler(this.openImageToolStripMenuItem_Click);
            // 
            // openID
            // 
            this.openID.Filter = " JPEG Images|*.jpg|PNG Images|*.png|BITMAPS Images|*.bmp\";";
            this.openID.InitialDirectory = "System.Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)";
            this.openID.Title = "Insert an Image";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(395, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(383, 273);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Location = new System.Drawing.Point(2, 13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(375, 254);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Location = new System.Drawing.Point(12, 329);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(383, 273);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox3.Location = new System.Drawing.Point(2, 13);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(375, 254);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pictureBox3);
            this.groupBox3.Location = new System.Drawing.Point(401, 329);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(383, 273);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox4.Location = new System.Drawing.Point(2, 13);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(375, 254);
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.pictureBox4);
            this.groupBox4.Location = new System.Drawing.Point(790, 329);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(383, 273);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1185, 637);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Smooting Image";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openImageToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}

