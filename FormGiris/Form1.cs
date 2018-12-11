using System;
using System.Windows.Forms;

namespace FormGiris
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string ad = txtAd.Text;

            MessageBox.Show($"Hosgeldin {ad}");
        }

    }
}
