using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kital_Uygulamasi
{
   
        class OrtakKitap
        {
            public string YayinEvi { get; set; }
            public string Yazar { get; set; }
            public int SayfaSayisi { get; set; }
            public string KitapAdi { get; set; }
            public int StokAdedi { get; set; }
            public double Fiyat { get; set; }



            public OrtakKitap() { }
            public OrtakKitap(string YayinEvi, string Yazar, int SayfaSayisi, string KitapAdi, int StokAdedi, double Fiyat)
            {
                this.YayinEvi = YayinEvi;
                this.Yazar = Yazar;
                this.SayfaSayisi = SayfaSayisi;
                this.KitapAdi = KitapAdi;
                this.StokAdedi = StokAdedi;
                this.Fiyat = Fiyat;
            }
            public virtual string Yazdir()
            {
                return "Yayınevi:" + YayinEvi + "\t" + "Yazar:" + Yazar + "\t" + "Sayfa:" + SayfaSayisi + "\t" + "Ad:" + KitapAdi + "\t" + "Stok:" + StokAdedi + "\t" + "Fiyat:" + Fiyat + " TL";

            }
        }



    }

