using Cs.Lib.Abstracts;
using System.Media;
using System.Threading;

namespace Cs.Lib.Concrete
{
    public class ElBombasi : Firlatilan
    {
        public ElBombasi()
        {
            this.Fiyat = 350;
            this.Hasar = 80;
            this.SilahResmi.Image = Properties.Resources.Bomba;
            this.Ulke = "Türkiye";
        }
        public override int Firlat()
        {
            SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.Bomb);
            soundPlayer.Play();
            Thread.Sleep(500);
            return Hasar;
        }
    }
}
