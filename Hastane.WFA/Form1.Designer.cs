namespace Hastane.WFA
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kisiİslemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doktorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hemsireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hastaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randevuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randevuAlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raporlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kisiİslemleriToolStripMenuItem,
            this.randevuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1518, 40);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kisiİslemleriToolStripMenuItem
            // 
            this.kisiİslemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doktorToolStripMenuItem,
            this.hemsireToolStripMenuItem,
            this.personelToolStripMenuItem,
            this.hastaToolStripMenuItem});
            this.kisiİslemleriToolStripMenuItem.Name = "kisiİslemleriToolStripMenuItem";
            this.kisiİslemleriToolStripMenuItem.Size = new System.Drawing.Size(159, 38);
            this.kisiİslemleriToolStripMenuItem.Text = "Kisi İslemleri";
            // 
            // doktorToolStripMenuItem
            // 
            this.doktorToolStripMenuItem.Name = "doktorToolStripMenuItem";
            this.doktorToolStripMenuItem.Size = new System.Drawing.Size(324, 38);
            this.doktorToolStripMenuItem.Text = "Doktor";
            this.doktorToolStripMenuItem.Click += new System.EventHandler(this.doktorToolStripMenuItem_Click);
            // 
            // hemsireToolStripMenuItem
            // 
            this.hemsireToolStripMenuItem.Name = "hemsireToolStripMenuItem";
            this.hemsireToolStripMenuItem.Size = new System.Drawing.Size(324, 38);
            this.hemsireToolStripMenuItem.Text = "Hemsire";
            // 
            // personelToolStripMenuItem
            // 
            this.personelToolStripMenuItem.Name = "personelToolStripMenuItem";
            this.personelToolStripMenuItem.Size = new System.Drawing.Size(324, 38);
            this.personelToolStripMenuItem.Text = "Personel";
            // 
            // hastaToolStripMenuItem
            // 
            this.hastaToolStripMenuItem.Name = "hastaToolStripMenuItem";
            this.hastaToolStripMenuItem.Size = new System.Drawing.Size(324, 38);
            this.hastaToolStripMenuItem.Text = "Hasta";
            // 
            // randevuToolStripMenuItem
            // 
            this.randevuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.randevuAlToolStripMenuItem,
            this.raporlarToolStripMenuItem});
            this.randevuToolStripMenuItem.Name = "randevuToolStripMenuItem";
            this.randevuToolStripMenuItem.Size = new System.Drawing.Size(120, 38);
            this.randevuToolStripMenuItem.Text = "Randevu";
            // 
            // randevuAlToolStripMenuItem
            // 
            this.randevuAlToolStripMenuItem.Name = "randevuAlToolStripMenuItem";
            this.randevuAlToolStripMenuItem.Size = new System.Drawing.Size(324, 38);
            this.randevuAlToolStripMenuItem.Text = "Randevu Al";
            // 
            // raporlarToolStripMenuItem
            // 
            this.raporlarToolStripMenuItem.Name = "raporlarToolStripMenuItem";
            this.raporlarToolStripMenuItem.Size = new System.Drawing.Size(324, 38);
            this.raporlarToolStripMenuItem.Text = "Raporlar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1518, 1128);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kisiİslemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doktorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hemsireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hastaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randevuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randevuAlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raporlarToolStripMenuItem;
    }
}

