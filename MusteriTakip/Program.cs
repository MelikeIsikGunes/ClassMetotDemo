using System;

namespace MusteriTakip
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Adi = "Melike";
            musteri1.Soyadi = "Işık Güneş";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Adi = "Fatih";
            musteri2.Soyadi = "Güneş";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Adi = "Engin";
            musteri3.Soyadi = "Demiroğ";

            MusteriManager musteri = new MusteriManager();
            musteri.MusteriEkle(musteri1);
            musteri.MusteriEkle(musteri2);
            musteri.MusteriEkle(musteri3);


            Console.WriteLine("-------------------------");

            musteri.MusteriListele(musteri1,musteri2,musteri3);

            Console.WriteLine("-------------------------");

            musteri.MusteriSil(musteri3);



        }
    }
}
