using System;
using System.Drawing;
using System.Windows.Forms;

namespace UcaksavarOyunu.Lib
{
    public class Roket : OyunBase, IHareketEdebilir
    {
        public Roket(Point point, ContainerControl container) : base(container)
        {
            Resim = new PictureBox()
            {
                Size = new Size(28, 36),
                Image = Properties.Resources.mermi1,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Location = point
            };
            container.Controls.Add(Resim);
        }

        public void HareketEt(Yonler yon)
        {
            if (yon == Yonler.Yukari)
            {
                Resim.Location = new Point()
                {
                    X = Resim.Location.X,
                    Y = Resim.Location.Y - 5
                };
            }
            else
                throw new Exception("Roket sadece yukari hareket edebilir");
        }
    }
}
