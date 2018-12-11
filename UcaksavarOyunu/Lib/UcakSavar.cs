using System;
using System.Collections.Generic;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace UcaksavarOyunu.Lib
{
    public class UcakSavar : OyunBase, IAtesEdebilen, IHareketEdebilir
    {
        private const int hareketBirimi = 10;
        public List<Roket> Roketler { get; set; } = new List<Roket>();
        public UcakSavar(ContainerControl container) : base(container)
        {
            Resim = new PictureBox()
            {
                SizeMode = PictureBoxSizeMode.StretchImage,
                Size = new Size(83, 83),
                Image = Properties.Resources.ucaksavar,
                Location = new Point(container.Size.Width / 2 - 41, container.Size.Height - 125)
            };
            container.Controls.Add(Resim);
        }
        public void AtesEt()
        {
            Point point = new Point()
            {
                X = Resim.Location.X + 30,
                Y = Resim.Location.Y - 30
            };
            Roket roket = new Roket(point, base.container);
            Roketler.Add(roket);
            SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.AWP_Ates);
            soundPlayer.Play();
        }

        public void HareketEt(Yonler yon)
        {
            switch (yon)
            {
                case Yonler.Sola:
                    if (Resim.Location.X > 20)
                        Resim.Location = new Point(Resim.Location.X - hareketBirimi, Resim.Location.Y);
                    break;
                case Yonler.Saga:
                    if (Resim.Location.X < container.Size.Width - 120)
                        Resim.Location = new Point(Resim.Location.X + hareketBirimi, Resim.Location.Y);
                    break;
                default:
                    throw new Exception("Ucaksavar sadece saga sola hareket edebilir");
            }
        }
    }
}
