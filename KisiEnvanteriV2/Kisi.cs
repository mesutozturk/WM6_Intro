using System;
using System.Text.RegularExpressions;

namespace KisiEnvanteriV2
{
    public class Kisi
    {
        private string _ad, _soyad, _telefon, _email, _tckn;

        public String Ad
        {
            get => this._ad;
            set
            {
                NameValid(value, "Ad");
                value = value.Trim();
                this._ad = value.Substring(0, 1).ToUpper() + value.Substring(1).ToLower();
            }
        }
        public String Soyad
        {
            get => this._soyad;
            set
            {
                NameValid(value, "Soyad");
                value = value.Trim();
                this._soyad = value.Substring(0, 1).ToUpper() + value.Substring(1).ToLower();
            }
        }
        public String Telefon
        {
            get => this._telefon;
            set
            {
                if (!value.StartsWith("0"))
                    throw new Exception("Telefon numarasi 0 ile baslamali");
                if (value.Length != 12)
                    throw new Exception("Telefon numaraniz 12 hane olmali");
                foreach (char harf in value)
                {
                    if (!char.IsDigit(harf))
                        throw new Exception("Telefon numaraniz sadece rakamlardan olusmalidir");
                }

                this._telefon = value;
            }
        }
        public String Email
        {
            get => this._email;
            set
            {
                Regex rgx = new Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
                if (!rgx.IsMatch(value))
                    throw new Exception("Lutfen bir email adresi giriniz");
                this._email = value;
            }
        }
        public String TCKN
        {
            get => this._tckn;
            set
            {
                if (value.Length != 11)
                    throw new Exception("TCKN 11 haneli olmalidir");
                foreach (char harf in value)
                {
                    if (!char.IsDigit(harf))
                        throw new Exception("TCKN sadece rakamlardan olusmalidir");
                }

                this._tckn = value;
            }
        }
        public byte[] Fotograf { get; set; }
        private void NameValid(string value, string propertyName)
        {
            foreach (char harf in value)
            {
                if (!(char.IsLetter(harf) || char.IsWhiteSpace(harf)))
                    throw new Exception($"{propertyName} girisi sadece harf ve bosluklarla yapilmalidir.");

            }
        }

        public override string ToString()
        {
            return $"{this.Ad} {this.Soyad}";
        }
    }
}
