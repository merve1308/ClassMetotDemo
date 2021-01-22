using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Add(Musteri musteri)
        {
         Console.WriteLine( "Musteri eklendi." + musteri.Adi);
        }
        public void List(Musteri musteri)
        {
            Console.WriteLine(musteri.Id + "TC Kimlik Nolu Müşteri" + musteri.Adi +" " + musteri.Soyadi);
        }

        public void Clear (Musteri musteri)
        {
            Console.WriteLine(musteri.Numara + "Cep telefonu numarası silindi.");
        }
    }


}
