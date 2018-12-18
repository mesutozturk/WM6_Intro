namespace Hastane.WFA
{
    partial class RandevuForm
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
            this.lstHastalar = new System.Windows.Forms.ListBox();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.cmbServis = new System.Windows.Forms.ComboBox();
            this.cmbDoktor = new System.Windows.Forms.ComboBox();
            this.flpSaatler = new System.Windows.Forms.FlowLayoutPanel();
            this.btnRandevuKaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstHastalar
            // 
            this.lstHastalar.FormattingEnabled = true;
            this.lstHastalar.Location = new System.Drawing.Point(12, 44);
            this.lstHastalar.Name = "lstHastalar";
            this.lstHastalar.Size = new System.Drawing.Size(191, 407);
            this.lstHastalar.TabIndex = 0;
            this.lstHastalar.SelectedIndexChanged += new System.EventHandler(this.lstHastalar_SelectedIndexChanged);
            this.lstHastalar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstHastalar_KeyDown);
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(12, 13);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(191, 20);
            this.txtAra.TabIndex = 1;
            this.txtAra.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtAra_KeyUp);
            // 
            // cmbServis
            // 
            this.cmbServis.FormattingEnabled = true;
            this.cmbServis.Location = new System.Drawing.Point(210, 13);
            this.cmbServis.Name = "cmbServis";
            this.cmbServis.Size = new System.Drawing.Size(156, 21);
            this.cmbServis.TabIndex = 2;
            this.cmbServis.Visible = false;
            this.cmbServis.SelectedIndexChanged += new System.EventHandler(this.cmbServis_SelectedIndexChanged);
            // 
            // cmbDoktor
            // 
            this.cmbDoktor.FormattingEnabled = true;
            this.cmbDoktor.Location = new System.Drawing.Point(372, 13);
            this.cmbDoktor.Name = "cmbDoktor";
            this.cmbDoktor.Size = new System.Drawing.Size(156, 21);
            this.cmbDoktor.TabIndex = 3;
            this.cmbDoktor.Visible = false;
            this.cmbDoktor.SelectedIndexChanged += new System.EventHandler(this.cmbDoktor_SelectedIndexChanged);
            // 
            // flpSaatler
            // 
            this.flpSaatler.AutoScroll = true;
            this.flpSaatler.Location = new System.Drawing.Point(210, 44);
            this.flpSaatler.Name = "flpSaatler";
            this.flpSaatler.Size = new System.Drawing.Size(513, 360);
            this.flpSaatler.TabIndex = 4;
            this.flpSaatler.Visible = false;
            // 
            // btnRandevuKaydet
            // 
            this.btnRandevuKaydet.Location = new System.Drawing.Point(537, 410);
            this.btnRandevuKaydet.Name = "btnRandevuKaydet";
            this.btnRandevuKaydet.Size = new System.Drawing.Size(186, 41);
            this.btnRandevuKaydet.TabIndex = 5;
            this.btnRandevuKaydet.Text = "Randevu Kaydet";
            this.btnRandevuKaydet.UseVisualStyleBackColor = true;
            this.btnRandevuKaydet.Visible = false;
            this.btnRandevuKaydet.Click += new System.EventHandler(this.btnRandevuKaydet_Click);
            // 
            // RandevuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 506);
            this.Controls.Add(this.btnRandevuKaydet);
            this.Controls.Add(this.flpSaatler);
            this.Controls.Add(this.cmbDoktor);
            this.Controls.Add(this.cmbServis);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.lstHastalar);
            this.Name = "RandevuForm";
            this.Text = "RandevuForm";
            this.Load += new System.EventHandler(this.RandevuForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstHastalar;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.ComboBox cmbServis;
        private System.Windows.Forms.ComboBox cmbDoktor;
        private System.Windows.Forms.FlowLayoutPanel flpSaatler;
        private System.Windows.Forms.Button btnRandevuKaydet;
    }
}