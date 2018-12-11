using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using  Geometri.Lib;

namespace Geometri.App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Kare kare = new Kare();
            kare.X = 5;
            Dikdortgen dikdortgen = new Dikdortgen();
            dikdortgen.X = 3;
            dikdortgen.Y = 4;
            Dikucgen ucgen = new Dikucgen();
            ucgen.X = 5;
            ucgen.Y = 12;
            //MessageBox.Show($"ucgenin alani: {ucgen.AlanHesapla()}");
            //MessageBox.Show($"ucgenin çevresi: {ucgen.CevreHesapla()}");
            //MessageBox.Show($"ucgenin hipotenus: {ucgen.KosegenHesapla()}");

            //Sekil sekil = new Sekil();
            //sekil.X = 10;
            //MessageBox.Show($"Sekil alan: {sekil.AlanHesapla()}");
        }
    }
}
