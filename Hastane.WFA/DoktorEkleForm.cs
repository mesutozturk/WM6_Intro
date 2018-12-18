using Hastane.Lib.Business;
using Hastane.Lib.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Hastane.Lib.Data;

namespace Hastane.WFA
{
    public partial class DoktorEkleForm : EkleBaseForm
    {
        public DoktorEkleForm()
        {
            InitializeComponent();
        }

        private List<Hemsire> hemsireler;
        private void DoktorEkleForm_Load(object sender, EventArgs e)
        {
            hemsireler = Form1.Context.Hemsireler;
            cmbServis.DataSource = Enum.GetNames(typeof(Servis));
        }

        private void cmbServis_SelectedIndexChanged(object sender, EventArgs e)
        {
            Servis servis = (Servis)Enum.Parse(typeof(Servis), cmbServis.SelectedItem.ToString());


            lstDoktorlar.DataSource = Form1.Context.Doktorlar
                .Where(x => x.Servis == servis)
                .ToList();
        }

        private void btnHemsireleriGuncelle_Click(object sender, EventArgs e)
        {
            DoktorBusiness doktorBusiness = new DoktorBusiness();
            Doktor dr = lstDoktorlar.SelectedItem as Doktor;
            for (var i = 0; i < chlstHemsire.Items.Count; i++)
            {
                Hemsire hms = chlstHemsire.Items[i] as Hemsire;
                if (chlstHemsire.GetItemCheckState(i) == CheckState.Checked)
                {
                    if (hms.AtandiMi) continue;
                    doktorBusiness.AtamaYap(dr, hms);
                }
                else
                {
                    if (!hms.AtandiMi) continue;
                    doktorBusiness.Cikart(dr, hms);
                }
            }
            lstDoktorlar_SelectedIndexChanged(sender,e);
        }

        private void lstDoktorlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstDoktorlar.SelectedItem == null) return;

            Servis servis = (Servis)Enum.Parse(typeof(Servis), cmbServis.SelectedItem.ToString());
            var servisinHemsireleri = hemsireler
                .Where(x => x.Servis == servis)
                .OrderByDescending(x => x.AtandiMi)
                .ToList();
            //chlstHemsire.DataSource = servisinHemsireleri;

            Doktor seciliDoktor = lstDoktorlar.SelectedItem as Doktor;

            List<Hemsire> gosterilecekHemsireler = new List<Hemsire>();

            foreach (Hemsire hemsire in servisinHemsireleri)
            {
                if (hemsire.AtandiMi)
                {
                    if (seciliDoktor.Hemsireler.Any(x => x.Id == hemsire.Id))
                    {
                        gosterilecekHemsireler.Add(hemsire);
                    }
                }
                else
                {
                    gosterilecekHemsireler.Add(hemsire);
                }
            }

            chlstHemsire.DataSource = gosterilecekHemsireler;
           

            for (int i = 0; i < gosterilecekHemsireler.Count; i++)
            {
                var hms = gosterilecekHemsireler[i];
                if (hms.AtandiMi)
                    chlstHemsire.SetItemCheckState(i, CheckState.Checked);
                else
                    chlstHemsire.SetItemCheckState(i, CheckState.Unchecked);
            }
        }
    }
}
