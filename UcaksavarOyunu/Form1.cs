using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UcaksavarOyunu.Lib;

namespace UcaksavarOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Oyun oyun;
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && oyun == null)
                oyun = new Oyun(this);
            else if (e.KeyCode == Keys.Left)
                oyun?.UcakSavar.HareketEt(Yonler.Sola);
            else if (e.KeyCode == Keys.Right)
                oyun?.UcakSavar.HareketEt(Yonler.Saga);
            else if (e.KeyCode == Keys.Space)
                oyun?.UcakSavar.AtesEt();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            oyun?.Resized(this);
        }
    }
}
