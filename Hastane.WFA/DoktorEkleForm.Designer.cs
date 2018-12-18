namespace Hastane.WFA
{
    partial class DoktorEkleForm
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
            this.lstDoktorlar = new System.Windows.Forms.ListBox();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.cmbServis = new System.Windows.Forms.ComboBox();
            this.chlstHemsire = new System.Windows.Forms.CheckedListBox();
            this.btnHemsireleriGuncelle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(60, 27);
            this.txtSoyad.Margin = new System.Windows.Forms.Padding(1);
            // 
            // txtAd
            // 
            this.txtAd.Margin = new System.Windows.Forms.Padding(1);
            // 
            // lstDoktorlar
            // 
            this.lstDoktorlar.FormattingEnabled = true;
            this.lstDoktorlar.Location = new System.Drawing.Point(180, 43);
            this.lstDoktorlar.Margin = new System.Windows.Forms.Padding(2);
            this.lstDoktorlar.Name = "lstDoktorlar";
            this.lstDoktorlar.Size = new System.Drawing.Size(181, 238);
            this.lstDoktorlar.TabIndex = 2;
            this.lstDoktorlar.SelectedIndexChanged += new System.EventHandler(this.lstDoktorlar_SelectedIndexChanged);
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(180, 16);
            this.txtAra.Margin = new System.Windows.Forms.Padding(2);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(181, 20);
            this.txtAra.TabIndex = 3;
            this.txtAra.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtAra_KeyUp);
            // 
            // cmbServis
            // 
            this.cmbServis.FormattingEnabled = true;
            this.cmbServis.Location = new System.Drawing.Point(8, 76);
            this.cmbServis.Margin = new System.Windows.Forms.Padding(2);
            this.cmbServis.Name = "cmbServis";
            this.cmbServis.Size = new System.Drawing.Size(103, 21);
            this.cmbServis.TabIndex = 4;
            this.cmbServis.SelectedIndexChanged += new System.EventHandler(this.cmbServis_SelectedIndexChanged);
            // 
            // chlstHemsire
            // 
            this.chlstHemsire.FormattingEnabled = true;
            this.chlstHemsire.Location = new System.Drawing.Point(368, 16);
            this.chlstHemsire.Margin = new System.Windows.Forms.Padding(2);
            this.chlstHemsire.Name = "chlstHemsire";
            this.chlstHemsire.Size = new System.Drawing.Size(196, 259);
            this.chlstHemsire.TabIndex = 5;
            // 
            // btnHemsireleriGuncelle
            // 
            this.btnHemsireleriGuncelle.Location = new System.Drawing.Point(368, 281);
            this.btnHemsireleriGuncelle.Name = "btnHemsireleriGuncelle";
            this.btnHemsireleriGuncelle.Size = new System.Drawing.Size(196, 96);
            this.btnHemsireleriGuncelle.TabIndex = 6;
            this.btnHemsireleriGuncelle.Text = "Hemsireleri Güncelle";
            this.btnHemsireleriGuncelle.UseVisualStyleBackColor = true;
            this.btnHemsireleriGuncelle.Click += new System.EventHandler(this.btnHemsireleriGuncelle_Click);
            // 
            // DoktorEkleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 389);
            this.Controls.Add(this.btnHemsireleriGuncelle);
            this.Controls.Add(this.chlstHemsire);
            this.Controls.Add(this.cmbServis);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.lstDoktorlar);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "DoktorEkleForm";
            this.Text = "DoktorEkleForm";
            this.Load += new System.EventHandler(this.DoktorEkleForm_Load);
            this.Controls.SetChildIndex(this.txtAd, 0);
            this.Controls.SetChildIndex(this.txtSoyad, 0);
            this.Controls.SetChildIndex(this.lstDoktorlar, 0);
            this.Controls.SetChildIndex(this.txtAra, 0);
            this.Controls.SetChildIndex(this.cmbServis, 0);
            this.Controls.SetChildIndex(this.chlstHemsire, 0);
            this.Controls.SetChildIndex(this.btnHemsireleriGuncelle, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstDoktorlar;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.ComboBox cmbServis;
        private System.Windows.Forms.CheckedListBox chlstHemsire;
        private System.Windows.Forms.Button btnHemsireleriGuncelle;
    }
}