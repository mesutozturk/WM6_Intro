using System;
using System.Windows.Forms;
using Cs.Lib.Abstracts;
using Cs.Lib.Concrete;

namespace Cs.App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Timer seriTimer = new Timer();
        private Silah seciliSilah;
        private void Form1_Load(object sender, EventArgs e)
        {
            cmbSilahlar.Items.AddRange(Enum.GetNames(typeof(Silahlar)));
            seriTimer.Tick += SeriTimer_Tick;
        }

        private void SeriTimer_Tick(object sender, EventArgs e)
        {
            btnAtesEt.PerformClick();
        }

        private void cmbSilahlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSilahlar.SelectedIndex < 0) return;

            Silahlar silah = (Silahlar)Enum.Parse(typeof(Silahlar), cmbSilahlar.SelectedItem.ToString());

            Silahlar silahb = (Silahlar)cmbSilahlar.SelectedIndex;
            byte deger = (byte)silah;

            switch (silah)
            {
                case Silahlar.Bıçak:
                    seciliSilah = new Bicak();
                    break;
                case Silahlar.USP:
                    seciliSilah = new USP();
                    break;
                case Silahlar.Glock:
                    seciliSilah = new Glock();
                    break;
                case Silahlar.DesertEagle:
                    seciliSilah = new DesertEagle();
                    break;
                case Silahlar.AK47:
                    seciliSilah = new AK47();
                    break;
                case Silahlar.M4A1S:
                    seciliSilah = new M4A1S();
                    break;
                case Silahlar.AWP:
                    seciliSilah = new AWP();
                    break;
                case Silahlar.ElBombası:
                    seciliSilah = new ElBombasi();
                    break;
                case Silahlar.FlashBombası:
                    seciliSilah = new FlashBombasi();
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
            panelSilah.Controls.Clear();
            panelSilah.Controls.Add(seciliSilah.SilahResmi);
            seciliSilah.SilahResmi.Dock = DockStyle.Fill;

            SilahBilgisiGoster(seciliSilah);

            gb_AtesliSilah.Visible = seciliSilah is IAtesEdebilen;
            gbYakinSaldiri.Visible = seciliSilah is IVurulabilir;
            gbFirlatilan.Visible = seciliSilah is IFirlatilabilen;
        }

        private void SilahBilgisiGoster(Silah silah)
        {
            lblDetay.Text = $"Ülke: {seciliSilah.Ulke}\nFiyat: {seciliSilah.Fiyat:c2}";
            if (silah is ISarjorlu sarjorSilah)
                lblDurum.Text = $"{sarjorSilah.KalanFisek}/{sarjorSilah.SarjorKapasitesi}";
        }

        private void btnAtesEt_Click(object sender, EventArgs e)
        {
            btnAtesEt.Enabled = false;
            (seciliSilah as IAtesEdebilen).AtesEt();
            SilahBilgisiGoster(seciliSilah);
            btnAtesEt.Enabled = true;
        }

        private void btnYenidenDoldur_Click(object sender, EventArgs e)
        {
            btnYenidenDoldur.Enabled = false;
            (seciliSilah as ISarjorlu).YenidenDoldur();
            SilahBilgisiGoster(seciliSilah);
            btnYenidenDoldur.Enabled = true;
        }

        private void btnSaldir_Click(object sender, EventArgs e)
        {
            btnSaldir.Enabled = false;
            (seciliSilah as IVurulabilir).Vur();
            SilahBilgisiGoster(seciliSilah);
            btnSaldir.Enabled = true;
        }

        private void btnFırlat_Click(object sender, EventArgs e)
        {
            btnFırlat.Enabled = false;
            (seciliSilah as IFirlatilabilen).Firlat();
            SilahBilgisiGoster(seciliSilah);
            btnFırlat.Enabled = true;
        }

        private void btnAtesEt_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliSilah is ISeriAtabilir seriSilah)
            {
                seriTimer.Interval = seriSilah.AtisKatsayisi;
                seriTimer.Start();
            }
        }

        private void btnAtesEt_MouseUp(object sender, MouseEventArgs e)
        {
            if (seciliSilah is ISeriAtabilir)
            {
                seriTimer.Stop();
            }
        }
    }
}
