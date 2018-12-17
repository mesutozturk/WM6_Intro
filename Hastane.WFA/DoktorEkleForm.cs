using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hastane.Lib.Business;
using Hastane.Lib.Models;

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
            var hemsireleri= hemsireler
                .Where(x => x.Servis == servis)
                .OrderByDescending(x=>x.AtandiMi)
                .ToList();
            chlstHemsire.DataSource = hemsireleri;

            for (int i = 0; i < hemsireleri.Count; i++)
            {
                var hms = hemsireleri[i];
                if (hms.AtandiMi)
                    chlstHemsire.SetItemCheckState(i, CheckState.Checked);
            }

            lstDoktorlar.DataSource = Form1.Context.Doktorlar
                .Where(x => x.Servis == servis)
                .ToList();
        }

        private void btnHemsireAta_Click(object sender, EventArgs e)
        {
            DoktorBusiness doktorBusiness = new DoktorBusiness();
            Doktor dr = lstDoktorlar.SelectedItem as Doktor;
            foreach (object checkedItem in chlstHemsire.CheckedItems)
            {
                Hemsire hms = checkedItem as Hemsire;
                if (hms.AtandiMi) continue;
                doktorBusiness.AtamaYap(dr, hms);

            }

        }
    }
}
