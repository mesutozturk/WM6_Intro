using Hastane.Lib.Models;

namespace Hastane.Lib.Data
{
    public class MockData
    {
        public Context Context { get; set; }
        public MockData()
        {
            Context = new Context();

            for (int i = 0; i < 90; i++)
            {
                Context.Hastalar.Add(new Hasta()
                {
                    Ad = FakeData.NameData.GetFirstName(),
                    DogumTarihi = FakeData.DateTimeData.GetDatetime(),
                    Soyad = FakeData.NameData.GetSurname(),
                    TCKN = FakeData.TextData.GetNumeric(11),
                    Telefon = "5" + FakeData.TextData.GetNumeric(9)
                });
            }
            for (int i = 0; i < 10; i++)
            {
                Context.Doktorlar.Add(new Doktor()
                {
                    Ad = FakeData.NameData.GetFirstName(),
                    DogumTarihi = FakeData.DateTimeData.GetDatetime(),
                    Soyad = FakeData.NameData.GetSurname(),
                    TCKN = FakeData.TextData.GetNumeric(11),
                    Telefon = "5" + FakeData.TextData.GetNumeric(9),
                    Maas = FakeData.NumberData.GetNumber(4000, 10000),
                    Servis = FakeData.EnumData.GetElement<Servis>()
                });
            }
            for (int i = 0; i < 20; i++)
            {
                Context.Hemsireler.Add(new Hemsire()
                {
                    Ad = FakeData.NameData.GetFirstName(),
                    DogumTarihi = FakeData.DateTimeData.GetDatetime(),
                    Soyad = FakeData.NameData.GetSurname(),
                    TCKN = FakeData.TextData.GetNumeric(11),
                    Telefon = "5" + FakeData.TextData.GetNumeric(9),
                    Maas = FakeData.NumberData.GetNumber(3000, 7000),
                    Servis = FakeData.EnumData.GetElement<Servis>()
                });
            }
        }
    }
}
