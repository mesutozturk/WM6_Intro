using System;
using System.Drawing;
using System.Windows.Forms;

namespace UcaksavarOyunu.Lib
{
    public class Ucak : OyunBase, IHareketEdebilir
    {
        public Ucak(Point point, ContainerControl container) : base(container)
        {
            Resim = new PictureBox()
            {
                Size = new Size(52, 44),
                Image = Properties.Resources.ucak,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Location = point
            };
            container.Controls.Add(Resim);
        }

        public void HareketEt(Yonler yon)
        {
            if (yon == Yonler.Asagi)
            {
                Resim.Location = new Point()
                {
                    X = Resim.Location.X,
                    Y = Resim.Location.Y + 5
                };
            }
            else
                throw new Exception("Ucak sadece Asagi hareket edebilir");
        }
    }
}
