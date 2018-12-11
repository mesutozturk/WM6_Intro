using Cs.Lib.Abstracts;
using System.Media;
using System.Threading;

namespace Cs.Lib.Concrete
{
    public class AWP : Tufek
    {
        public AWP()
        {
            this._atisKatsayisi = 1500;
            this._sarjorKapasitesi = 10;
            this._kalanFisek = this._sarjorKapasitesi;
            this.Fiyat = 4750;
            this.Hasar = 120;
            this.SilahResmi.Image = Properties.Resources.AWP;
            this.Ulke = "İngiltere";
        }
        public override int AtesEt()
        {
            SoundPlayer soundPlayer;
            if (KalanFisek != 0)
            {
                soundPlayer = new SoundPlayer(Properties.Resources.AWP_Ates);
                soundPlayer.Play();
                Thread.Sleep(_atisKatsayisi);
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
            new SoundPlayer(Properties.Resources.M4A1_Reload).Play();
            Thread.Sleep(1250);
            this._kalanFisek = this.SarjorKapasitesi;
            return KalanFisek;
        }
    }
}
