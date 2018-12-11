using System;
using System.Collections.Generic;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace UcaksavarOyunu.Lib
{
    public class Oyun
    {
        private Timer tmr_Roket, tmr_Uretici, tmr_Ucak, tmr_Kontrol;
        private ContainerControl container;
        public List<Ucak> Ucaklar { get; set; } = new List<Ucak>();
        public UcakSavar UcakSavar { get; set; }
        public Oyun(ContainerControl container)
        {
            this.container = container;
            this.UcakSavar = new UcakSavar(container);
            tmr_Roket = new Timer()
            {
                Enabled = true,
                Interval = 5
            };
            tmr_Roket.Tick += Tmr_Roket_Tick;
            tmr_Uretici = new Timer()
            {
                Enabled = true,
                Interval = 1200
            };
            tmr_Uretici.Tick += Tmr_Uretici_Tick;
            tmr_Ucak = new Timer()
            {
                Enabled = true,
                Interval = 120
            };
            tmr_Ucak.Tick += Tmr_Ucak_Tick;
            tmr_Kontrol = new Timer()
            {
                Enabled = true,
                Interval = 3
            };
            tmr_Kontrol.Tick += Tmr_Kontrol_Tick;
        }

        public void Resized(ContainerControl container)
        {
            this.container = container;
            UcakSavar.Container = container;
            foreach (var ucak in Ucaklar)
            {
                ucak.Container = container;
            }

            foreach (Roket roket in UcakSavar.Roketler)
            {
                roket.Container = container;
            }
        } 
        private void Tmr_Kontrol_Tick(object sender, EventArgs e)
        {
            foreach (Ucak ucak in Ucaklar)
            {
                Rectangle ru = new Rectangle();
                Rectangle rr = new Rectangle();
                
                if (ucak.Resim.Location.Y + ucak.Resim.Height > container.Height - 70)
                {
                    tmr_Kontrol.Stop();
                    tmr_Ucak.Stop();
                    tmr_Uretici.Stop();
                    tmr_Roket.Stop();
                }

                ru.Location = ucak.Resim.Location;
                ru.Width = ucak.Resim.Width;
                ru.Height = ucak.Resim.Height;
                bool vurduMu = false;
                foreach (Roket roket in UcakSavar.Roketler)
                {
                    rr.Location = roket.Resim.Location;
                    rr.Width = roket.Resim.Width;
                    rr.Height = roket.Resim.Height;

                    //if (ru.IntersectsWith(rr))
                    //{
                    //    vurduMu = true;
                    //    container.Controls.Remove(ucak.Resim);
                    //    container.Controls.Remove(roket.Resim);
                    //    Ucaklar.Remove(ucak);
                    //    UcakSavar.Roketler.Remove(roket);
                    //    SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.bomb_small);
                    //    soundPlayer.Play();
                    //    break;
                    //}
                    if (roket.Resim.Bounds.IntersectsWith(ucak.Resim.Bounds))
                    {
                        vurduMu = true;
                        container.Controls.Remove(ucak.Resim);
                        container.Controls.Remove(roket.Resim);
                        Ucaklar.Remove(ucak);
                        UcakSavar.Roketler.Remove(roket);
                        SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.bomb_small);
                        soundPlayer.Play();
                        break;
                    }
                }
                if(vurduMu) break;
            }

            foreach (Roket roket in UcakSavar.Roketler)
            {
                if (roket.Resim.Location.Y < 0)
                {
                    UcakSavar.Roketler.Remove(roket);
                    this.container.Controls.Remove(roket.Resim);
                    break;
                }
            }
        }

        Random rnd = new Random();
        private void Tmr_Uretici_Tick(object sender, System.EventArgs e)
        {
            Point konum = new Point(rnd.Next(20, container.Width - 70), 20);
            Ucak ucak = new Ucak(konum, this.container);
            Ucaklar.Add(ucak);
        }

        private void Tmr_Roket_Tick(object sender, System.EventArgs e)
        {
            foreach (IHareketEdebilir hareket in UcakSavar.Roketler)
            {
                hareket.HareketEt(Yonler.Yukari);
            }
        }
        private void Tmr_Ucak_Tick(object sender, EventArgs e)
        {
            foreach (IHareketEdebilir ucak in Ucaklar)
            {
                ucak.HareketEt(Yonler.Asagi);
            }
        }

    }
}
