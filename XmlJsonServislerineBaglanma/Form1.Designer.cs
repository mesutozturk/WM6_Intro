namespace XmlJsonServislerineBaglanma
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
            this.components = new System.ComponentModel.Container();
            this.lblKod = new System.Windows.Forms.Label();
            this.lblDeger = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnHaritadaGoster = new System.Windows.Forms.Button();
            this.lblHereNow = new System.Windows.Forms.Label();
            this.lblAdres = new System.Windows.Forms.Label();
            this.lblFirmaAdi = new System.Windows.Forms.Label();
            this.btnGetir = new System.Windows.Forms.Button();
            this.lstFirmalar = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblKod
            // 
            this.lblKod.AutoSize = true;
            this.lblKod.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKod.ForeColor = System.Drawing.Color.DarkRed;
            this.lblKod.Location = new System.Drawing.Point(24, 9);
            this.lblKod.Name = "lblKod";
            this.lblKod.Size = new System.Drawing.Size(97, 33);
            this.lblKod.TabIndex = 0;
            this.lblKod.Text = "label1";
            // 
            // lblDeger
            // 
            this.lblDeger.AutoSize = true;
            this.lblDeger.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeger.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblDeger.Location = new System.Drawing.Point(24, 68);
            this.lblDeger.Name = "lblDeger";
            this.lblDeger.Size = new System.Drawing.Size(97, 33);
            this.lblDeger.TabIndex = 1;
            this.lblDeger.Text = "label2";
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(30, 175);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(266, 212);
            this.listBox1.TabIndex = 2;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnHaritadaGoster
            // 
            this.btnHaritadaGoster.Location = new System.Drawing.Point(497, 203);
            this.btnHaritadaGoster.Name = "btnHaritadaGoster";
            this.btnHaritadaGoster.Size = new System.Drawing.Size(84, 46);
            this.btnHaritadaGoster.TabIndex = 15;
            this.btnHaritadaGoster.Text = "Haritada Göster";
            this.btnHaritadaGoster.UseVisualStyleBackColor = true;
            this.btnHaritadaGoster.Click += new System.EventHandler(this.btnHaritadaGoster_Click);
            // 
            // lblHereNow
            // 
            this.lblHereNow.AutoSize = true;
            this.lblHereNow.Location = new System.Drawing.Point(494, 165);
            this.lblHereNow.Name = "lblHereNow";
            this.lblHereNow.Size = new System.Drawing.Size(87, 13);
            this.lblHereNow.TabIndex = 12;
            this.lblHereNow.Text = "şuan kaç kişi var";
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Location = new System.Drawing.Point(494, 118);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(34, 13);
            this.lblAdres.TabIndex = 13;
            this.lblAdres.Text = "Adres";
            // 
            // lblFirmaAdi
            // 
            this.lblFirmaAdi.AutoSize = true;
            this.lblFirmaAdi.Location = new System.Drawing.Point(494, 77);
            this.lblFirmaAdi.Name = "lblFirmaAdi";
            this.lblFirmaAdi.Size = new System.Drawing.Size(46, 13);
            this.lblFirmaAdi.TabIndex = 14;
            this.lblFirmaAdi.Text = "firma adı";
            // 
            // btnGetir
            // 
            this.btnGetir.Location = new System.Drawing.Point(494, 12);
            this.btnGetir.Name = "btnGetir";
            this.btnGetir.Size = new System.Drawing.Size(87, 48);
            this.btnGetir.TabIndex = 11;
            this.btnGetir.Text = "Getir de getirelim";
            this.btnGetir.UseVisualStyleBackColor = true;
            this.btnGetir.Click += new System.EventHandler(this.btnGetir_Click);
            // 
            // lstFirmalar
            // 
            this.lstFirmalar.FormattingEnabled = true;
            this.lstFirmalar.Location = new System.Drawing.Point(302, 12);
            this.lstFirmalar.Name = "lstFirmalar";
            this.lstFirmalar.Size = new System.Drawing.Size(186, 329);
            this.lstFirmalar.TabIndex = 10;
            this.lstFirmalar.SelectedIndexChanged += new System.EventHandler(this.lstFirmalar_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 399);
            this.Controls.Add(this.btnHaritadaGoster);
            this.Controls.Add(this.lblHereNow);
            this.Controls.Add(this.lblAdres);
            this.Controls.Add(this.lblFirmaAdi);
            this.Controls.Add(this.btnGetir);
            this.Controls.Add(this.lstFirmalar);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lblDeger);
            this.Controls.Add(this.lblKod);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKod;
        private System.Windows.Forms.Label lblDeger;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnHaritadaGoster;
        private System.Windows.Forms.Label lblHereNow;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.Label lblFirmaAdi;
        private System.Windows.Forms.Button btnGetir;
        private System.Windows.Forms.ListBox lstFirmalar;
    }
}

