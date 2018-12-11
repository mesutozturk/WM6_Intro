using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cs.Lib.Abstracts;

namespace Cs.Lib.Concrete
{
    public class Bicak : YakinSaldiri
    {
        public Bicak()
        {
            this.Fiyat = 50;
            this.Hasar = 45;
            this.SilahResmi.Image = Properties.Resources.Bicak;
            this.Ulke = "Türkiye";
            this._vurusKatsayisi = 350;
            SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.Bicak_Cikarma);
            soundPlayer.Play();
        }

        public override int Vur()
        {
            SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.Bicak_Saplama);
            soundPlayer.Play();
            Thread.Sleep(VurusKatsayisi);
            return Hasar;
        }
    }
}
