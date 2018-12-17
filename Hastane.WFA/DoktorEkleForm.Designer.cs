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
            this.btnHemsireAta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(119, 52);
            // 
            // lstDoktorlar
            // 
            this.lstDoktorlar.FormattingEnabled = true;
            this.lstDoktorlar.ItemHeight = 25;
            this.lstDoktorlar.Location = new System.Drawing.Point(361, 82);
            this.lstDoktorlar.Name = "lstDoktorlar";
            this.lstDoktorlar.Size = new System.Drawing.Size(358, 454);
            this.lstDoktorlar.TabIndex = 2;
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(361, 30);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(358, 31);
            this.txtAra.TabIndex = 3;
            // 
            // cmbServis
            // 
            this.cmbServis.FormattingEnabled = true;
            this.cmbServis.Location = new System.Drawing.Point(17, 146);
            this.cmbServis.Name = "cmbServis";
            this.cmbServis.Size = new System.Drawing.Size(202, 33);
            this.cmbServis.TabIndex = 4;
            this.cmbServis.SelectedIndexChanged += new System.EventHandler(this.cmbServis_SelectedIndexChanged);
            // 
            // chlstHemsire
            // 
            this.chlstHemsire.FormattingEnabled = true;
            this.chlstHemsire.Location = new System.Drawing.Point(737, 30);
            this.chlstHemsire.Name = "chlstHemsire";
            this.chlstHemsire.Size = new System.Drawing.Size(388, 498);
            this.chlstHemsire.TabIndex = 5;
            // 
            // btnHemsireAta
            // 
            this.btnHemsireAta.Location = new System.Drawing.Point(737, 556);
            this.btnHemsireAta.Name = "btnHemsireAta";
            this.btnHemsireAta.Size = new System.Drawing.Size(231, 101);
            this.btnHemsireAta.TabIndex = 6;
            this.btnHemsireAta.Text = "Hemsire Ata";
            this.btnHemsireAta.UseVisualStyleBackColor = true;
            this.btnHemsireAta.Click += new System.EventHandler(this.btnHemsireAta_Click);
            // 
            // DoktorEkleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 804);
            this.Controls.Add(this.btnHemsireAta);
            this.Controls.Add(this.chlstHemsire);
            this.Controls.Add(this.cmbServis);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.lstDoktorlar);
            this.Name = "DoktorEkleForm";
            this.Text = "DoktorEkleForm";
            this.Load += new System.EventHandler(this.DoktorEkleForm_Load);
            this.Controls.SetChildIndex(this.txtAd, 0);
            this.Controls.SetChildIndex(this.txtSoyad, 0);
            this.Controls.SetChildIndex(this.lstDoktorlar, 0);
            this.Controls.SetChildIndex(this.txtAra, 0);
            this.Controls.SetChildIndex(this.cmbServis, 0);
            this.Controls.SetChildIndex(this.chlstHemsire, 0);
            this.Controls.SetChildIndex(this.btnHemsireAta, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstDoktorlar;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.ComboBox cmbServis;
        private System.Windows.Forms.CheckedListBox chlstHemsire;
        private System.Windows.Forms.Button btnHemsireAta;
    }
}