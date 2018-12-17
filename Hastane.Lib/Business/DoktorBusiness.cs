using Hastane.Lib.Models;
using System;

namespace Hastane.Lib.Business
{
    public class DoktorBusiness : IAtama<Doktor, Hemsire>
    {
        public void AtamaYap(Doktor nereye, Hemsire neyi)
        {
            if (neyi.AtandiMi)
                throw new Exception("Bu hemsire daha once baska bir doktora atamasi yapilmistir");
            if (nereye.Servis != neyi.Servis)
                throw new Exception("Doktor ve hemsire ayni serviste olmalidir");
            neyi.AtandiMi = true;
            nereye.Hemsireler.Add(neyi);
        }

        public void Cikart(Doktor nereden, Hemsire neyi)
        {
            neyi.AtandiMi = false;
            nereden.Hemsireler.Remove(neyi);
        }
    }
}
