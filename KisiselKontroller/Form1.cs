using System.Windows.Forms;

namespace KisiselKontroller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            /*
             * Standart kaliplarin oldugu ekranlardan, birden fazla yerde kullanilmasi gerekiyorsa bu ekranlar UserControl olarak tasarlanip istenilen yere toolbox uzerinden surukle birakla olusturulabilir.
             */
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("Okunan :" + txtConverter1.ConvertedText);
        }

        private void txtConverter1_SinirAsildi(string mesaj)
        {
            MessageBox.Show(mesaj);
        }

        private void txtConverter1_FalanOldu(object sender, System.EventArgs e)
        {

        }
    }
}
