using System;
using System.Drawing;
using System.Windows.Forms;

namespace Kronometre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private DateTime kronometre = new DateTime(), simdi = DateTime.Now, once = DateTime.Now;
        private bool basladiMi = false;

        private void Yaz()
        {
            lblSaat.Text = $"{kronometre.Hour:00}";
            lblDakika.Text = $"{kronometre.Minute:00}";
            lblSaniye.Text = $"{kronometre.Second:00}";
            lblSalise.Text = $"{kronometre.Millisecond:000}";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (basladiMi) return;

            kronometre = new DateTime();
            Yaz();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            once = simdi;
            simdi = DateTime.Now;
            TimeSpan fark = simdi - once;
            this.Text = $"{fark.TotalMilliseconds:0000}";
            kronometre = kronometre.AddMilliseconds(fark.TotalMilliseconds);
            Yaz();
            if (cbZamanli.Checked)
            {
                DateTime bitis = dtpZamanli.Value;
                TimeSpan toplamFark = bitis - new DateTime(bitis.Year, bitis.Month, bitis.Day);
                TimeSpan baslangictanFark = kronometre - new DateTime();
                int yuzde = (int)(baslangictanFark.TotalMilliseconds / toplamFark.TotalMilliseconds * 100);

                if (yuzde >= 100)
                {
                    yuzde = 100;
                    kronometre = new DateTime(kronometre.Year, kronometre.Month, kronometre.Day, kronometre.Hour, kronometre.Minute, kronometre.Second);
                    btnStartStop.PerformClick();

                    Yaz();
                    kronometre = new DateTime();
                }

                progressBar1.Value = yuzde;
            }
        }

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            basladiMi = !basladiMi;
            if (basladiMi)
            {
                btnStartStop.Text = "Durdur";
                btnStartStop.FlatStyle = FlatStyle.Flat;
                btnStartStop.BackColor = Color.Chartreuse;
                simdi = DateTime.Now;
                btnReset.Enabled = false;
                timer1.Start();
            }
            else
            {
                btnStartStop.Text = "Basla";
                btnStartStop.FlatStyle = FlatStyle.Standard;
                btnStartStop.BackColor = Color.IndianRed;
                btnReset.Enabled = true;
                timer1.Stop();
            }
        }
    }
}
