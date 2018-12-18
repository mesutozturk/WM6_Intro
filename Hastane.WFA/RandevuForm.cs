using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hastane.Lib.Helpers;
using Hastane.Lib.Models;

namespace Hastane.WFA
{
    public partial class RandevuForm : Form
    {
        public RandevuForm()
        {
            InitializeComponent();
        }

        private void RandevuForm_Load(object sender, EventArgs e)
        {
            cmbServis.DataSource = Enum.GetNames(typeof(Servis));
            lstHastalar.DataSource = Form1.Context.Hastalar
                .OrderBy(x => x.Ad)
                .ThenBy(x => x.Soyad)
                .ToList();
        }

        private Hasta seciliHasta;
        private Servis seciliServis;
        private Doktor seciliDoktor;
        private Button seciliButon;

        private void lstHastalar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstHastalar.SelectedItem == null) return;
            seciliHasta = lstHastalar.SelectedItem as Hasta;
            cmbServis.Visible = true;
        }

        private void txtAra_KeyUp(object sender, KeyEventArgs e)
        {

            lstHastalar.DataSource = KisiHelper.Ara<Hasta>(Form1.Context.Hastalar, txtAra.Text);
        }

        private void lstHastalar_KeyDown(object sender, KeyEventArgs e)
        {
            txtAra.Focus();
            txtAra.Text = e.KeyCode.ToString();
            txtAra.SelectionStart = 1;
        }

        private void cmbServis_SelectedIndexChanged(object sender, EventArgs e)
        {
            seciliServis = (Servis)Enum.Parse(typeof(Servis), cmbServis.SelectedItem.ToString());
            cmbDoktor.DataSource = Form1.Context.Doktorlar
                .Where(x => x.Servis == seciliServis)
                .ToList();
            cmbDoktor.Visible = true;
        }

        private void cmbDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            seciliDoktor = cmbDoktor.SelectedItem as Doktor;
            flpSaatler.Visible = true;
            SaatleriDoldur();
            Renklendir();
            RandevulariDoldur();
        }

        private Color bosRenk = Color.MediumSpringGreen;
        private Color seciliRenk = Color.Tomato;
        private Color doluRenk = Color.DarkSlateGray;
        private void SaatleriDoldur()
        {
            flpSaatler.Controls.Clear();
            var liste = RandevuHelper.Saatler;
            for (int i = 0; i < liste.Count; i++)
            {
                Button btn = new Button
                {
                    Text = liste[i],
                    Name = "btn_" + i,
                    Font = new Font("Trebuchet MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(162))),
                    Size = new Size(70, 50)
                };
                btn.Click += btnSaat_Click;
                flpSaatler.Controls.Add(btn);
            }
        }
        private void RandevulariDoldur()
        {
            var tumRandevular = Form1.Context.Randevular.Where(x => x.Doktor == seciliDoktor);
            foreach (var randevu in tumRandevular)
            {
                Button kapatilacakButton = flpSaatler.Controls[randevu.Saat] as Button;
                kapatilacakButton.Enabled = false;
                kapatilacakButton.BackColor = doluRenk;
            }
        }
        private void btnSaat_Click(object sender, EventArgs e)
        {
            seciliButon = sender as Button;
            Renklendir(seciliButon);
            btnRandevuKaydet.Visible = true;
        }

        private void Renklendir(Button seciliButon)
        {
            foreach (Button item in flpSaatler.Controls)
            {
                if (item.Enabled)
                    item.BackColor = item == seciliButon ? seciliRenk : bosRenk;
            }
        }
        private void Renklendir()
        {
            foreach (Button item in flpSaatler.Controls)
            {
                item.BackColor = bosRenk;
            }
        }

        private void btnRandevuKaydet_Click(object sender, EventArgs e)
        {
            int saat = RandevuHelper.Saatler.IndexOf(seciliButon.Text);
            var durum = Form1.Context.Randevular
                .FirstOrDefault(x => x.Hasta == seciliHasta && x.Saat == saat);
            if (durum != null)
            {
                string mesaj =
                    $"{seciliHasta} {seciliButon.Text}'da {durum.Doktor.Servis} servisde {durum.Doktor}'a randevusu bulunmaktadir";
                MessageBox.Show(mesaj);
                return;
            }

            Form1.Context.Randevular.Add(new Randevu()
            {
                Doktor = seciliDoktor,
                Hasta = seciliHasta,
                Saat = saat
            });
            Renklendir();
            RandevulariDoldur();
        }
    }
}
