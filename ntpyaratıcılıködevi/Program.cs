using System;
using System.Collections.Generic;

namespace KutuphaneYonetimSistemi
{
    public class Kitap
    {
        public string Baslik { get; set; }
        public string Yazar { get; set; }
        public int SayfaSayisi { get; set; }
        public string Yayinevi { get; set; }
        public decimal Fiyat { get; set; }

        public Kitap(string baslik, string yazar, int sayfaSayisi, string yayinevi, decimal fiyat)
        {
            Baslik = baslik;
            Yazar = yazar;
            SayfaSayisi = sayfaSayisi;
            Yayinevi = yayinevi;
            Fiyat = fiyat;
        }

        public virtual void BilgiYazdir()
        {
            Console.WriteLine("Başlık: " +Baslik);
            Console.WriteLine("Yazar: " +Yazar);
            Console.WriteLine("Sayfa Sayısı: " +SayfaSayisi);
            Console.WriteLine("Yayın Evi: " +Yayinevi);
            Console.WriteLine("Fiyat: TL  " +Fiyat);
        }
    }
    public class Roman : Kitap
    {
        public string Tur { get; set; }
        public bool Bestseller { get; set; }

        public Roman(string baslik, string yazar, int sayfaSayisi, string yayinevi, decimal fiyat, string tur, bool bestseller)
            : base(baslik, yazar, sayfaSayisi, yayinevi, fiyat)
        {
            Tur = tur;
            Bestseller = bestseller;
        }

        public override void BilgiYazdir()
        {
            base.BilgiYazdir();
            Console.WriteLine("Tür: " +Tur);
            Console.WriteLine("Bestseller: " +Bestseller);
        }
    }
    public class Dergi : Kitap
    {
        public int Cilt { get; set; }
        public int Sayi { get; set; }

        public Dergi(string baslik, string yazar, int sayfaSayisi, string yayinevi, decimal fiyat, int cilt, int sayi)
         : base(baslik, yazar, sayfaSayisi, yayinevi, fiyat)
        {
            Cilt = cilt;
            Sayi = sayi;
        }

        public override void BilgiYazdir()
        {
            base.BilgiYazdir();
            Console.WriteLine("Cilt: " +Cilt);
            Console.WriteLine("Sayı: " +Sayi);
        }
    }
    public class Ansiklopedi : Kitap
    {
        public string Konu { get; set; }
        public int CiltSayisi { get; set; }

        public Ansiklopedi(string baslik, string yazar, int sayfaSayisi, string yayinevi, decimal fiyat, string konu, int ciltSayisi)
         : base(baslik, yazar, sayfaSayisi, yayinevi, fiyat)
        {
            Konu = konu;
            CiltSayisi = ciltSayisi;
        }

        public override void BilgiYazdir()
        {
            base.BilgiYazdir();
            Console.WriteLine("Konu: " +Konu);
            Console.WriteLine("Cilt Sayısı: " +CiltSayisi);
        }
    }
    public class EKitap : Kitap
    {
        public string DosyaFormati { get; set; }
        public double DosyaBoyutu { get; set; } 

        public EKitap(string baslik, string yazar, int sayfaSayisi, string yayinevi, decimal fiyat, string dosyaFormati, double dosyaBoyutu)
        : base(baslik, yazar, sayfaSayisi, yayinevi, fiyat)
        {
            DosyaFormati = dosyaFormati;
            DosyaBoyutu = dosyaBoyutu;
        }

        public override void BilgiYazdir()
        {
            base.BilgiYazdir();
            Console.WriteLine("Dosya Formatı:  "+DosyaFormati);
            Console.WriteLine("Dosya Boyutu: MB  " +DosyaBoyutu);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Kitap> kutuphane = new List<Kitap>();

            Roman roman = new Roman("Suç ve Ceza", "Fyodor Dostoyevski", 671, "Can Yayınları", 35.00m,"Klasik", true);
              
            Dergi dergi = new Dergi( "Bilim ve Teknik","TÜBİTAK",120,"TÜBİTAK Yayınları", 10.00m,55, 650);
             
            Ansiklopedi ansiklopedi = new Ansiklopedi("Büyük Larousse","Çeşitli Yazarlar",1500, "Milliyet Yayınları", 500.00m,"Genel Kültür",24);
                
            EKitap eKitap = new EKitap("1984","George Orwell",328,  "Penguin Books", 20.00m,"PDF", 1.5);
             
            kutuphane.Add(roman);
            kutuphane.Add(dergi);
            kutuphane.Add(ansiklopedi);
            kutuphane.Add(eKitap);

            for (int i = 0; i < kutuphane.Count; i++)
            {
                Kitap kitap = kutuphane[i];
                kitap.BilgiYazdir();
                Console.WriteLine();
            }
        }
    }
}