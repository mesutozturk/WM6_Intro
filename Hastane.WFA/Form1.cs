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

namespace Hastane.WFA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private DoktorEkleForm frmDoktor;
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
    }
}
