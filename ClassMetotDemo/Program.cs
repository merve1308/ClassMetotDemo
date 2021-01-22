using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Adi = "Merve";
            musteri1.Soyadi = "Öğredik";
            musteri1.Numara = 0552;
            musteri1.Adres = "Adana";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Adi = "Nazlı";
            musteri2.Soyadi = "Öğredik";
            musteri2.Numara = 0537;
            musteri2.Adres = "Antalya";

           Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Adi = "Münire";
            musteri3.Soyadi = "Öğredik";
            musteri3.Numara = 0542;
            musteri3.Adres = "Ankara";

            MusteriManager musteriManager = new MusteriManager();
            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            foreach (Musteri musteri in musteriler)
            {
                musteriManager.Add(musteri);
            }
            foreach (Musteri musteri in musteriler)
            {
                musteriManager.List(musteri);

            }
            foreach (Musteri musteri in musteriler)
            {
                musteriManager.Clear(musteri);
            }    




        }

    }

}
