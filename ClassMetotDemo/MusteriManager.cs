using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.Adi + " " + musteri.Soyadi + ": Yeni müşterimiz olarak eklendi.");
        }

        public void Silme(Musteri musteri)
        {
            Console.WriteLine(musteri.Adi + " " + musteri.Soyadi + ": Müşteri sistemden silindi.");
        }

        public void Listeleme(Musteri[] musteriler)
        {
            Console.WriteLine("Musteriler Listeleniyor");
            foreach (var musteri in musteriler)
            {

                Console.WriteLine(musteri.Adi +" "+ musteri.Soyadi);
            }
           
        }





    }
}
