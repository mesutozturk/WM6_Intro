using Cs.Lib.Abstracts;
using System.Media;
using System.Threading;

namespace Cs.Lib.Concrete
{
    public class FlashBombasi : Firlatilan
    {
        public FlashBombasi()
        {
            this.Fiyat = 200;
            this.Hasar = 0;
            this.SilahResmi.Image = Properties.Resources.Flash;
            this.Ulke = "Almanya";
        }
        public override int Firlat()
        {
            SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.Flashbang);
            soundPlayer.Play();
            Thread.Sleep(500);
            return Hasar;
        }
    }
}
