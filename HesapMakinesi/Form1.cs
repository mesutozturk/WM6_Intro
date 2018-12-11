using System;
using System.Windows.Forms;

namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitMyComponents();
            txtEkran.Text = "0";
        }

        private double sayi = 0, ekran = 0;
        private char islem = '0';
        private void InitMyComponents()
        {
            //eventleri olustur
            btn0.Click += BtnSayi_Click;
            btn1.Click += BtnSayi_Click;
            btn2.Click += BtnSayi_Click;
            btn3.Click += BtnSayi_Click;
            btn4.Click += BtnSayi_Click;
            btn5.Click += BtnSayi_Click;
            btn6.Click += BtnSayi_Click;
            btn7.Click += BtnSayi_Click;
            btn8.Click += BtnSayi_Click;
            btn9.Click += BtnSayi_Click;

            btnEsittir.Click += BtnIslem_Click;
            btnTopla.Click += BtnIslem_Click;
            btnCikart.Click += BtnIslem_Click;
            btnBol.Click += BtnIslem_Click;
            btnCarp.Click += BtnIslem_Click;
        }

        private void BtnIslem_Click(object sender, System.EventArgs e)
        {
            Button btn = sender as Button;

            if (islem == '0')
            {
                sayi = ekran;
                ekran = 0;
                txtEkran.Text = "0";
            }
            else if (islem == '+')
            {
                sayi += ekran;
                ekran = 0;
                txtEkran.Text = sayi.ToString();
            }
            else if (islem == '-')
            {
                sayi = sayi - ekran;
                ekran = 0;
                txtEkran.Text = sayi.ToString();
            }
            else if (islem == '/')
            {
                sayi /= ekran;
                ekran = 0;
                txtEkran.Text = sayi.ToString();
            }
            else if (islem == 'x')
            {
                sayi *= ekran;
                ekran = 0;
                txtEkran.Text = sayi.ToString();
            }
            else if (islem == '=')
            {
                txtEkran.Text = sayi.ToString();
            }
            islem = Convert.ToChar(btn.Text);

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '0':
                    btn0.PerformClick();
                    break;
                case '1':
                    btn1.PerformClick();
                    break;
                case '2':
                    btn2.PerformClick();
                    break;
                case '3':
                    btn3.PerformClick();
                    break;
                case '4':
                    btn4.PerformClick();
                    break;
                case '5':
                    btn5.PerformClick();
                    break;
                case '6':
                    btn6.PerformClick();
                    break;
                case '7':
                    btn7.PerformClick();
                    break;
                case '8':
                    btn8.PerformClick();
                    break;
                case '9':
                    btn9.PerformClick();
                    break;
                case '+':
                    btnTopla.PerformClick();
                    break;
                case '-':
                    btnCikart.PerformClick();
                    break;
                case 'x':
                    btnCarp.PerformClick();
                    break;
                case '/':
                    btnBol.PerformClick();
                    break;
                case '=':
                    btnEsittir.PerformClick();
                    break;
                case '\u001b':
                    sayi = 0;
                    ekran = 0;
                    txtEkran.Text = "0";
                    break;
                case '\r':
                    btnEsittir.PerformClick();
                    break;
            }
        }

        private void BtnSayi_Click(object sender, System.EventArgs e)
        {
            //Button btn = sender as Button;
            Button btn = (Button)sender;
            string birlestirme = ekran + btn.Text;
            ekran = double.Parse(birlestirme);
            txtEkran.Text = ekran.ToString();
        }
    }
}
