using Cs.Lib.Abstracts;
using System;
using System.Media;
using System.Threading;

namespace Cs.Lib.Concrete
{
    public class DesertEagle:Tabanca
    {
        public DesertEagle()
        {
            this.Fiyat = 700;
            this._sarjorKapasitesi = 7;
            this.Hasar = 80;
            this.Ulke = "İsrail";
            this.SilahResmi.Image = Properties.Resources.Deagle;
            this._kalanFisek = this._sarjorKapasitesi;
        }

        public override int AtesEt()
        {
            SoundPlayer soundPlayer;
            if (KalanFisek != 0)
            {
                soundPlayer = new SoundPlayer(Properties.Resources.Deagle_Ates);
                soundPlayer.Play();
                Thread.Sleep(600);
                this._kalanFisek--;
            }
            else
            {
                soundPlayer = new SoundPlayer(Properties.Resources.Bitik_Mermi_Sesi);
                soundPlayer.Play();
                Thread.Sleep(250);
            }
            return this._kalanFisek;
        }

        public override int YenidenDoldur()
        {
            new SoundPlayer(Properties.Resources.Deagle_Reload).Play();
            Thread.Sleep(1250);
            this._kalanFisek = this.SarjorKapasitesi;
            return KalanFisek;
        }
    }
}
