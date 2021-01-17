using System;
using System.Collections.Generic;
using System.Text;

namespace MusteriTakip
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine(musteri.Adi+ " " + musteri.Soyadi +" eklendi");
        }
        public void MusteriListele(params Musteri[] musteriler)
        {
            for (int i = 0; i < musteriler.Length; i++)
            {
                Console.WriteLine(musteriler[i].Adi+" "+ musteriler[i].Soyadi);
            }
            Console.WriteLine("Müşteriler Listelendi");
        }
        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine(musteri.Adi + " " + musteri.Soyadi +" silindi");
        }
    }
}
