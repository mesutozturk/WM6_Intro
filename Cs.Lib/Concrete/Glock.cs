using Cs.Lib.Abstracts;
using System;
using System.Media;
using System.Threading;

namespace Cs.Lib.Concrete
{
    public class Glock:Tabanca
    {
        public Glock()
        {
            this._sarjorKapasitesi = 20;
            this.Ulke = "Avusturya";
            this.Hasar = 24;
            this.Fiyat = 200m;
            this._kalanFisek = this.SarjorKapasitesi;
            this.SilahResmi.Image = Properties.Resources.Glock;
        }
        public override int AtesEt()
        {
            SoundPlayer soundPlayer;
            if (KalanFisek != 0)
            {
                soundPlayer = new SoundPlayer(Properties.Resources.Glock_Ates);
                soundPlayer.Play();
                Thread.Sleep(300);
                this._kalanFisek--;
            }
            else
            {
                soundPlayer = new SoundPlayer(Properties.Resources.Bitik_Mermi_Sesi);
                soundPlayer.Play();
                Thread.Sleep(100);
            }
            return this._kalanFisek;
        }

        public override int YenidenDoldur()
        {
            new SoundPlayer(Properties.Resources.Glock_Reload).Play();
            Thread.Sleep(1000);
            this._kalanFisek = this.SarjorKapasitesi;
            return KalanFisek;
        }
    }
}
