using Soyut.Lib;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Soyut.App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Sekil> sekiller = new List<Sekil>();
        private void Form1_Load(object sender, EventArgs e)
        {

            Kare kare = new Kare();
            kare.X = 10;
            //MessageBox.Show($"karenin alani: {kare.AlanHesapla()}");
            //Object Initializer
            Dikdortgen dikdortgen = new Dikdortgen()
            {
                X = 5,
                Y = 12
            };
            //MessageBox.Show($"dikdortgenin kosegeni: {dikdortgen.KosegenHesapla()}");

            sekiller.Add(kare);
            sekiller.Add(dikdortgen);

            Sekil dikdortgen2 = new Dikdortgen()
            {
                X = 3,
                Y = 4
            };
            Sekil kare2 = new Kare() { X = 5 };
            sekiller.Add(dikdortgen2);
            sekiller.Add(kare2);

            foreach (Sekil sekil in sekiller)
            {
                MessageBox.Show($"Seklin alani: {sekil.AlanHesapla()}");
            }
        }
    }
}
