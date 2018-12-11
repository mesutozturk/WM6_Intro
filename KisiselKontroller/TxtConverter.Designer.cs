namespace KisiselKontroller
{
    partial class TxtConverter
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nuSayi = new System.Windows.Forms.NumericUpDown();
            this.txtOkunus = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.nuSayi)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nuSayi
            // 
            this.nuSayi.Location = new System.Drawing.Point(3, 3);
            this.nuSayi.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nuSayi.Name = "nuSayi";
            this.nuSayi.Size = new System.Drawing.Size(120, 20);
            this.nuSayi.TabIndex = 0;
            this.nuSayi.ValueChanged += new System.EventHandler(this.nuSayi_ValueChanged);
            // 
            // txtOkunus
            // 
            this.txtOkunus.Location = new System.Drawing.Point(3, 29);
            this.txtOkunus.Name = "txtOkunus";
            this.txtOkunus.ReadOnly = true;
            this.txtOkunus.Size = new System.Drawing.Size(120, 20);
            this.txtOkunus.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.nuSayi);
            this.flowLayoutPanel1.Controls.Add(this.txtOkunus);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(128, 55);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // TxtConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.flowLayoutPanel1);
            this.MaximumSize = new System.Drawing.Size(128, 55);
            this.Name = "TxtConverter";
            this.Size = new System.Drawing.Size(128, 55);
            ((System.ComponentModel.ISupportInitialize)(this.nuSayi)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nuSayi;
        private System.Windows.Forms.TextBox txtOkunus;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
