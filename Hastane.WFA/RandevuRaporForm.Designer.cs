namespace Hastane.WFA
{
    partial class RandevuRaporForm
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
            this.cmbDoktorlar = new System.Windows.Forms.ComboBox();
            this.dgvRandevu = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRandevu)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbDoktorlar
            // 
            this.cmbDoktorlar.FormattingEnabled = true;
            this.cmbDoktorlar.Location = new System.Drawing.Point(13, 13);
            this.cmbDoktorlar.Name = "cmbDoktorlar";
            this.cmbDoktorlar.Size = new System.Drawing.Size(157, 21);
            this.cmbDoktorlar.TabIndex = 0;
            this.cmbDoktorlar.SelectedIndexChanged += new System.EventHandler(this.cmbDoktorlar_SelectedIndexChanged);
            // 
            // dgvRandevu
            // 
            this.dgvRandevu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRandevu.Location = new System.Drawing.Point(13, 41);
            this.dgvRandevu.Name = "dgvRandevu";
            this.dgvRandevu.Size = new System.Drawing.Size(540, 375);
            this.dgvRandevu.TabIndex = 1;
            // 
            // RandevuRaporForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 457);
            this.Controls.Add(this.dgvRandevu);
            this.Controls.Add(this.cmbDoktorlar);
            this.Name = "RandevuRaporForm";
            this.Text = "RandevuRaporForm";
            this.Load += new System.EventHandler(this.RandevuRaporForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRandevu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDoktorlar;
        private System.Windows.Forms.DataGridView dgvRandevu;
    }
}