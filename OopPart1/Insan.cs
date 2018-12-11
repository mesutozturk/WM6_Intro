using System;

namespace OopPart1
{
    class Insan
    {
        /*
         * Erisim Belirleyiciler Access Modifiers
         * fields alanlar
         * constructors yapici metodlar
         * properties
         * metodlar fonksiyonlar
         * delege
         * event
         * destructors 
         * *kalitim - inheritance
         * *polymorphism
         */


        //Erisim Belirleyiciler Access Modifiers 
        /*
         * private - ayni scope ve alt scope icinde erisimi yapilan nesnelerdir. tanimlanan tum degisken ve metodlar onune yazilmasa dahi private olarak calisirlar.
         *
         * internal - ayni namespace icerisinden erisime aciktir. class interface enum default internaldir
         * public - farkli namespaceden erisim icin kullanilir
         *
         * *protected
         * *protected internal
         */

        private int _yas;
        private DateTime _dogumTarihi;

        public Insan(int yas)
        {
            this._yas = yas;  //this bulundugu sinifi temsil eder. o anki referansina erisimde kullanilir.
        }

        public Insan()
        {

        }
        //Encapsulation oldschool
        public void setYas(int yas)
        {
            if (yas <= 0)
                throw new Exception("Yas 0dan buyuk olmali");
            this._yas = yas;
        }

        public int getYas() => this._yas;
        //{
        //    return this._yas;
        //}
        //Property (ft. encapsulation)
        public int Yas
        {
            //get { return this._yas; }
            get { return this.YasHesapla(_dogumTarihi.Year); }
            set
            {
                if (value <= 0)
                    throw new Exception("Yas 0dan buyuk olmali");
                this._yas = value;
            }
        }

        public DateTime DogumTarihi
        {
            set
            {
                if (DateTime.Now.Year - value.Year < 18)
                    throw new Exception("18 yasindan kuculer sisteme kayit olamaz");
                this._yas = this.YasHesapla(value.Year);
                this._dogumTarihi = value;
            }
        }

        private int YasHesapla(int year) => DateTime.Now.Year - year;
    }
}
