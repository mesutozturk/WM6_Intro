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
    public partial class FrmOpen : Form
    {
        public FrmOpen()
        {
            InitializeComponent();
        }

        private void FrmOpen_Load(object sender, EventArgs e)
        {
            var sayilar = (this.MdiParent as Form1).Sayilar;
            sayilar.RemoveAt(3);
        }
    }
}
