using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hastane.Lib.Data;
using Hastane.Lib.Helpers;

namespace Hastane.WFA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private DoktorEkleForm frmDoktor;
        private RandevuForm frmRandevu;
        private void doktorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmDoktor == null || frmDoktor.IsDisposed)
            {
                frmDoktor = new DoktorEkleForm
                {
                    Text = "Doktor formu",
                    MdiParent = this
                };
                frmDoktor.Show();
            }
        }
        public static Context Context { get; set; }
        private void Form1_Load(object sender, EventArgs e)
        {
            Context = new MockData().Context;
        }

        private void içeriAktarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Context = DataHelper.Import();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dosya Bulunamadi " + ex.Message);
            }
        }

        private void dışarıAktarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataHelper.Export(Context);
        }

        private void randevuAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmRandevu == null || frmRandevu.IsDisposed)
            {
                frmRandevu = new RandevuForm()
                {
                    Text = "Randevu formu",
                    MdiParent = this
                };
                frmRandevu.Show();
            }
        }
    }
}
