using System;

namespace OgrenciDersYonetimSistemi
{
    class Program
    {
        static void Main(string[] args)
        {
            var ogretimGorevlisi = new OgretimGorevlisi
            {
                Ad = "Ali",
                Soyad = "Yılmaz",
                Unvan = "Doç. Dr.",
                Email = "ali.yilmaz@universite.edu.tr"
            };

            var ders = new Ders
            {
                DersAdi = "Matematik",
                Kredi = 4,
                OgretimGorevlisi = ogretimGorevlisi
            };

            var ogrenci1 = new Ogrenci { Ad = "Ayşe", Soyad = "Demir", OgrenciNo = 123, Email = "ayse.demir@student.edu.tr" };
            var ogrenci2 = new Ogrenci { Ad = "Mehmet", Soyad = "Kaya", OgrenciNo = 456, Email = "mehmet.kaya@student.edu.tr" };

            ders.OgrenciEkle(ogrenci1);
            ders.OgrenciEkle(ogrenci2);

            Console.WriteLine("\nDers Bilgileri:");
            ders.BilgiGoster();

            Console.WriteLine("\nSisteme Girişler:");
            ogretimGorevlisi.Login();
            ogrenci1.Login();
            ogrenci2.Login();
        }
    }
}
