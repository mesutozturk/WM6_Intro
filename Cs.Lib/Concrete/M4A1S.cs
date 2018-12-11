using Cs.Lib.Abstracts;
using System.Media;
using System.Threading;

namespace Cs.Lib.Concrete
{
    public class M4A1S : Tufek
    {
        public M4A1S()
        {
            this._atisKatsayisi = 200;
            this._sarjorKapasitesi = 20;
            this._kalanFisek = this._sarjorKapasitesi;
            this.Fiyat = 3100;
            this.Hasar = 43;
            this.SilahResmi.Image = Properties.Resources.M4A1S;
            this.Ulke = "Amerika";
        }
        public override int AtesEt()
        {
            SoundPlayer soundPlayer;
            if (KalanFisek != 0)
            {
                soundPlayer = new SoundPlayer(Properties.Resources.M4A1_Ates);
                soundPlayer.Play();
                Thread.Sleep(this._atisKatsayisi);
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
            Thread.Sleep(1100);
            this._kalanFisek = this.SarjorKapasitesi;
            return KalanFisek;
        }
    }
}
