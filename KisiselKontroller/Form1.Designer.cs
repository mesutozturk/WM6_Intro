namespace KisiselKontroller
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtConverter1 = new KisiselKontroller.TxtConverter();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(162, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 46);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtConverter1
            // 
            this.txtConverter1.AktifMi = false;
            this.txtConverter1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.txtConverter1.Location = new System.Drawing.Point(12, 31);
            this.txtConverter1.MaximumSize = new System.Drawing.Size(128, 55);
            this.txtConverter1.Name = "txtConverter1";
            this.txtConverter1.Renk = System.Drawing.Color.Empty;
            this.txtConverter1.Sayi = 0;
            this.txtConverter1.Size = new System.Drawing.Size(128, 55);
            this.txtConverter1.TabIndex = 0;
            this.txtConverter1.Tarih = new System.DateTime(((long)(0)));
            this.txtConverter1.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtConverter1.SinirAsildi += new KisiselKontroller.SinirAsimiHandler(this.txtConverter1_SinirAsildi);
            this.txtConverter1.FalanOldu += new KisiselKontroller.FalanHandler(this.txtConverter1_FalanOldu);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 395);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtConverter1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private TxtConverter txtConverter1;
        private System.Windows.Forms.Button button1;
    }
}

