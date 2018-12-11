using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRMEkranYonetimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public List<int> Sayilar { get; set; }
        private FrmNew _frmNew;
        private FrmOpen _frmOpen;
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_frmNew == null || _frmNew.IsDisposed)
            {
                _frmNew = new FrmNew();
                _frmNew.MdiParent = this;
                _frmNew.Show();
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_frmOpen == null || _frmOpen.IsDisposed)
            {
                _frmOpen = new FrmOpen();
                _frmOpen.MdiParent = this;
                _frmOpen.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Sayilar = new List<int>() { 1, 2, 3, 4, 2, 1, 2, 3, 4, 5, 3, 2 };
        }
    }
}
