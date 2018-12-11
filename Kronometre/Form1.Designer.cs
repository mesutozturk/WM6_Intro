namespace Kronometre
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.cbZamanli = new System.Windows.Forms.CheckBox();
            this.dtpZamanli = new System.Windows.Forms.DateTimePicker();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnStartStop = new System.Windows.Forms.Button();
            this.lblSalise = new System.Windows.Forms.Label();
            this.lblSaniye = new System.Windows.Forms.Label();
            this.lblDakika = new System.Windows.Forms.Label();
            this.lblSaat = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(11, 117);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(450, 43);
            this.progressBar1.TabIndex = 29;
            // 
            // cbZamanli
            // 
            this.cbZamanli.AutoSize = true;
            this.cbZamanli.Location = new System.Drawing.Point(166, 76);
            this.cbZamanli.Margin = new System.Windows.Forms.Padding(2);
            this.cbZamanli.Name = "cbZamanli";
            this.cbZamanli.Size = new System.Drawing.Size(77, 17);
            this.cbZamanli.TabIndex = 28;
            this.cbZamanli.Text = "Zamanlı Mı";
            this.cbZamanli.UseVisualStyleBackColor = true;
            // 
            // dtpZamanli
            // 
            this.dtpZamanli.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpZamanli.Location = new System.Drawing.Point(11, 73);
            this.dtpZamanli.Margin = new System.Windows.Forms.Padding(2);
            this.dtpZamanli.Name = "dtpZamanli";
            this.dtpZamanli.Size = new System.Drawing.Size(151, 20);
            this.dtpZamanli.TabIndex = 27;
            this.dtpZamanli.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(334, 12);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(70, 37);
            this.btnReset.TabIndex = 25;
            this.btnReset.Text = "Sıfırla";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnStartStop
            // 
            this.btnStartStop.Location = new System.Drawing.Point(259, 12);
            this.btnStartStop.Margin = new System.Windows.Forms.Padding(2);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new System.Drawing.Size(70, 37);
            this.btnStartStop.TabIndex = 26;
            this.btnStartStop.Text = "Başla";
            this.btnStartStop.UseVisualStyleBackColor = true;
            this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click);
            // 
            // lblSalise
            // 
            this.lblSalise.AutoSize = true;
            this.lblSalise.Font = new System.Drawing.Font("Courier New", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSalise.Location = new System.Drawing.Point(184, 9);
            this.lblSalise.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSalise.Name = "lblSalise";
            this.lblSalise.Size = new System.Drawing.Size(59, 40);
            this.lblSalise.TabIndex = 21;
            this.lblSalise.Text = "00";
            // 
            // lblSaniye
            // 
            this.lblSaniye.AutoSize = true;
            this.lblSaniye.Font = new System.Drawing.Font("Courier New", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSaniye.Location = new System.Drawing.Point(124, 9);
            this.lblSaniye.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSaniye.Name = "lblSaniye";
            this.lblSaniye.Size = new System.Drawing.Size(59, 40);
            this.lblSaniye.TabIndex = 22;
            this.lblSaniye.Text = "00";
            // 
            // lblDakika
            // 
            this.lblDakika.AutoSize = true;
            this.lblDakika.Font = new System.Drawing.Font("Courier New", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDakika.Location = new System.Drawing.Point(64, 9);
            this.lblDakika.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDakika.Name = "lblDakika";
            this.lblDakika.Size = new System.Drawing.Size(59, 40);
            this.lblDakika.TabIndex = 23;
            this.lblDakika.Text = "00";
            // 
            // lblSaat
            // 
            this.lblSaat.AutoSize = true;
            this.lblSaat.Font = new System.Drawing.Font("Courier New", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSaat.Location = new System.Drawing.Point(11, 9);
            this.lblSaat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSaat.Name = "lblSaat";
            this.lblSaat.Size = new System.Drawing.Size(59, 40);
            this.lblSaat.TabIndex = 24;
            this.lblSaat.Text = "00";
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 171);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.cbZamanli);
            this.Controls.Add(this.dtpZamanli);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnStartStop);
            this.Controls.Add(this.lblSalise);
            this.Controls.Add(this.lblSaniye);
            this.Controls.Add(this.lblDakika);
            this.Controls.Add(this.lblSaat);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.CheckBox cbZamanli;
        private System.Windows.Forms.DateTimePicker dtpZamanli;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnStartStop;
        private System.Windows.Forms.Label lblSalise;
        private System.Windows.Forms.Label lblSaniye;
        private System.Windows.Forms.Label lblDakika;
        private System.Windows.Forms.Label lblSaat;
        private System.Windows.Forms.Timer timer1;
    }
}

