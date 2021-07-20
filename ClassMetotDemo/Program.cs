using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Adi = "Ayşegül";
            musteri1.Soyadi = "Doğruoğlu";
            musteri1.HesapNo = "123125354";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Adi = "Volkan";
            musteri2.Soyadi = "Önder";
            musteri2.HesapNo = "48651653";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Adi = "Yeşim";
            musteri3.Soyadi = "Özlü";
            musteri3.HesapNo = "658644545";



            MusteriManager musteriManager = new MusteriManager();

            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);

            Console.WriteLine();

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };
            musteriManager.Listeleme(musteriler);

            


            


            


           

        }
    }
}
