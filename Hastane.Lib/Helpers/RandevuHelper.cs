using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane.Lib.Helpers
{
    public static class RandevuHelper
    {
        public static List<string> Saatler
        {
            get
            {
                List<string> saatler = new List<string>();
                for (int saat = 8; saat <= 16; saat++)
                {
                    if (saat == 12) continue;
                    for (int dakika = 0; dakika <= 45; dakika += 15)
                    {
                        saatler.Add($"{saat:00}:{dakika:00}");
                    }
                }

                return saatler;
            }
        }
    }
}
