using Hastane.Lib.Models;
using System.Collections.Generic;
using System.Linq;

namespace Hastane.Lib.Helpers
{
    public static class KisiHelper
    {
        public static List<T> Ara<T>(List<T> dataSource, string param) where T : Kisi
        {
            param = param.ToLower();
            return dataSource.Where(x => x.Ad.ToLower().Contains(param)
                                         || x.Soyad.ToLower().Contains(param)
                                         || x.TCKN == param).ToList();
        }
    }
}
