using System;
using System.Drawing;
using System.Windows.Forms;

namespace KisiselKontroller
{
    public delegate void SinirAsimiHandler(string mesaj);
    public delegate void FalanHandler(object sender, EventArgs e);
    public partial class TxtConverter : UserControl
    {
        public TxtConverter()
        {
            InitializeComponent();
        }
        public event SinirAsimiHandler SinirAsildi;
        public event FalanHandler FalanOldu;

        public int Sayi { get; set; }
        public DateTime Tarih { get; set; }
        public bool AktifMi { get; set; }
        public Color Renk { get; set; }

        public decimal Value
        {
            get => nuSayi.Value;
            set => nuSayi.Value = value;
        }

        public string ConvertedText => txtOkunus.Text; //ReadOnly Prop

        private void nuSayi_ValueChanged(object sender, EventArgs e)
        {
            //txtOkunus.Text = nuSayi.Value.ToString();
            //this.ParentForm.Text = txtOkunus.Text;
            int sayi = Convert.ToInt32(nuSayi.Value);
            if (sayi < 0)
            {
                nuSayi.Value = 0;

                SinirAsildi?.Invoke("Sayi 0 dan kucuk olamaz");
                return;
            }
            else if (sayi > 9999)
            {
                nuSayi.Value = 9999;
                SinirAsildi?.Invoke("Sayi 9999 dan buyuk olamaz");
                FalanOldu?.Invoke(sender, e);
                return;
            }

            txtOkunus.Text = sayi.OkunusuGetir();

        }
    }
}
