using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kital_Uygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            Depo d = new Depo();



            bool devam = true;

            #region Hazır Ürünler
            Console.WriteLine("***HAZIR ÜRÜNLER***" + "   Not: Satın alma için önce ürün listeleyi seçiniz");
            Console.WriteLine(" ");
            AkademikYayin ayk = new AkademikYayin("ATA Yayınevi", " Aziz Bircan ", 80, "Lidelik", 15, 25, "K.Gelişim");
            d.Ekle(ayk);
            Console.WriteLine($"Yayınevi:{ayk.YayinEvi} Yazar:{ayk.Yazar} Sayfa:{ayk.SayfaSayisi} Ad:{ayk.KitapAdi} Stok:{ayk.StokAdedi} İçerik:{ayk.icerik} Fiyat:{ayk.Fiyat} TL");
            Console.WriteLine("-----------------------------------");

            AkademikYayin ayk2 = new AkademikYayin();
            ayk2.YayinEvi = "Ramo Yayınevi";
            ayk2.Yazar = " Abdullah Cingöz";
            ayk2.SayfaSayisi = 240;
            ayk2.KitapAdi = " Sefillik";
            ayk2.StokAdedi = 3;
            ayk2.icerik = " Kişisel Gelişim";
            ayk2.Fiyat = 34;
            d.Ekle(ayk2);
            Console.WriteLine($"Yayınevi:{ayk2.YayinEvi} Yazar:{ayk2.Yazar} Sayfa:{ayk2.SayfaSayisi} Ad:{ayk2.KitapAdi} Stok:{ayk2.StokAdedi} İçerik:{ayk2.icerik} Fiyat:{ayk2.Fiyat} TL");
            Console.WriteLine("-----------------------------------");
            Hikaye hky = new Hikaye("Batı Yayınevi", "Ömer Seyfettin", 120, "İlk Cinayet", 80, 45, 8);
            d.Ekle(hky);
            Console.WriteLine($"Yayınevi:{hky.YayinEvi} Yazar:{hky.Yazar} Sayfa:{hky.SayfaSayisi} Ad:{hky.KitapAdi} Stok:{hky.StokAdedi} Sınıf:{hky.Sinif} Fiyat:{hky.Fiyat} TL");
            Console.WriteLine("-----------------------------------");
            Hikaye hky2 = new Hikaye();
            hky2.YayinEvi = "A Yayınevi";
            hky2.Yazar = "Ö.Seyfettin";
            hky2.SayfaSayisi = 157;
            hky2.KitapAdi = "Diyet";
            hky2.StokAdedi = 50;
            hky2.Sinif = 7;
            hky2.Fiyat = 43;
            d.Ekle(hky2);
            Console.WriteLine($"Yayınevi:{hky2.YayinEvi} Yazar:{hky2.Yazar} Sayfa:{hky2.SayfaSayisi} Ad:{hky2.KitapAdi} Stok:{hky2.StokAdedi} Sınıf:{hky2.Sinif} Fiyat:{hky2.Fiyat} TL");
            Console.WriteLine("-----------------------------------");



            #endregion

            while (devam == true)
            {
                Console.WriteLine(" ");
                Console.WriteLine("***SEKİZ KİTABEVİ***");
                Console.WriteLine(" ");
                Console.WriteLine("0-Satın Alma");
                Console.WriteLine("1-Ürün Ekleme");
                Console.WriteLine("2-Ürün Listele");
                Console.WriteLine("3-Çıkış");

                Console.Write("İşlem giriniz : ");
                string secenek = Console.ReadLine();

                switch (secenek)
                {
                    case "0":

                        d.SatinAlma();

                        break;

                    case "1":
                        Console.Clear();
                        Console.WriteLine("1-Yeni Akademik Yayın ekle ");
                        Console.WriteLine("2-Yeni Hikaye ekle ");
                        Console.WriteLine("3-Yeni Roman ekle");
                        Console.WriteLine(" ");
                        Console.Write("Eklenecek ürünü giriniz : ");
                        int secim = Convert.ToInt32(Console.ReadLine());

                        if (secim == 1)
                        {
                            AkademikYayin ayk3 = new AkademikYayin();
                            Console.WriteLine("Yayınevi giriniz: ");
                            ayk3.YayinEvi = Console.ReadLine();
                            Console.WriteLine("Yazar giriniz: ");
                            ayk3.Yazar = Console.ReadLine();
                            Console.WriteLine("Sayfa Sayısı giriniz: ");
                            ayk3.SayfaSayisi = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Kitap adı giriniz: ");
                            ayk3.KitapAdi = Console.ReadLine();
                            Console.WriteLine("Stokta kaç adet var:");
                            ayk3.StokAdedi = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("İçerik giriniz: ");
                            ayk3.icerik = Console.ReadLine();
                            Console.WriteLine("Fiyat:");
                            ayk3.Fiyat = Convert.ToDouble(Console.ReadLine());
                            d.Ekle(ayk3);
                            Console.Clear();
                        }
                        if (secim == 2)
                        {
                            Hikaye hky3 = new Hikaye();
                            Console.WriteLine("Yayınevi giriniz: ");
                            hky3.YayinEvi = Console.ReadLine();
                            Console.WriteLine("Yazar giriniz: ");
                            hky3.Yazar = Console.ReadLine();
                            Console.WriteLine("Sayfa Sayısı giriniz: ");
                            hky3.SayfaSayisi = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Kitap adı giriniz: ");
                            hky3.KitapAdi = Console.ReadLine();
                            Console.WriteLine("Stokta kaç adet var:");
                            hky3.StokAdedi = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Sınıf giriniz: ");
                            hky3.Sinif = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Fiyat:");
                            hky3.Fiyat = Convert.ToDouble(Console.ReadLine());
                            d.Ekle(hky3);
                            Console.Clear();

                        }
                        if (secim == 3)
                        {
                            Roman rmn = new Roman();
                            Console.WriteLine("Yayınevi giriniz: ");
                            rmn.YayinEvi = Console.ReadLine();
                            Console.WriteLine("Yazar giriniz: ");
                            rmn.Yazar = Console.ReadLine();
                            Console.WriteLine("Sayfa Sayısı giriniz: ");
                            rmn.SayfaSayisi = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Kitap adı giriniz: ");
                            rmn.KitapAdi = Console.ReadLine();
                            Console.WriteLine("Stokta kaç adet var:");
                            rmn.StokAdedi = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Konu giriniz: ");
                            rmn.Konu = Console.ReadLine();
                            Console.WriteLine("Fiyat:");
                            rmn.Fiyat = Convert.ToDouble(Console.ReadLine());
                            d.Ekle(rmn);
                            Console.Clear();
                        }

                        break;

                    case "2":
                        Console.Clear();
                        d.Listele();
                        Console.WriteLine(" ");
                        break;

                    case "3":
                        devam = false;
                        Console.WriteLine("Çıkış yapıldı...");
                        break;
                }






            }



        }
    }
}
