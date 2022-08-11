using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kital_Uygulamasi
{
   
        class Depo
        {
            public OrtakKitap[] kitaplar { get; set; }

            public Depo()
            {
                kitaplar = new OrtakKitap[0];
            }
            public void Ekle(AkademikYayin aky)
            {
                OrtakKitap[] gecici = new OrtakKitap[kitaplar.Length + 1];
                Array.Copy(kitaplar, gecici, kitaplar.Length);
                gecici[gecici.Length - 1] = aky;
                kitaplar = gecici;
            }
            public void Ekle(Hikaye hky)
            {
                OrtakKitap[] gecici = new OrtakKitap[kitaplar.Length + 1];
                Array.Copy(kitaplar, gecici, kitaplar.Length);
                gecici[gecici.Length - 1] = hky;
                kitaplar = gecici;
            }
            public void Ekle(Roman rmn)
            {
                OrtakKitap[] gecici = new OrtakKitap[kitaplar.Length + 1];
                Array.Copy(kitaplar, gecici, kitaplar.Length);
                gecici[gecici.Length - 1] = rmn;
                kitaplar = gecici;
            }
            public void Listele()
            {
                for (int i = 0; i < kitaplar.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. Ürün-{kitaplar[i].Yazdir()}");
                }

            }
            public void SatinAlma()
            {

                double toplam = 0;
                string secenek = "e";
                while (secenek == "e")
                {
                    Console.WriteLine("Hangi üründen alacaksınız?");
                    int urunNo = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Bu üründen kaç adet alacaksınız?");
                    int adet = Convert.ToInt32(Console.ReadLine());

                    toplam += kitaplar[urunNo - 1].Fiyat * adet;
                    for (int i = 0; i < adet; i++)
                    {
                        kitaplar[urunNo - 1].StokAdedi--;
                    }

                    Console.WriteLine("Alışverişe devam edilsin mi? (e-h)");
                    secenek = Console.ReadLine();
                }
                Console.WriteLine("Toplam Tutar =" + (toplam));


            }

        }

    }

