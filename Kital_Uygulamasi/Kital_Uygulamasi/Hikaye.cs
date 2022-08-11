using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kital_Uygulamasi
{
    class Hikaye : OrtakKitap
    {
        public int Sinif { get; set; }

        public Hikaye() { }
        public Hikaye(string YayinEvi, string Yazar, int SayfaSayisi, string KitapAdi, int StokAdedi, int Sinif, double Fiyat)
            : base(YayinEvi, Yazar, SayfaSayisi, KitapAdi, StokAdedi, Fiyat)
        {
            this.Sinif = Sinif;
        }
        public override string Yazdir()
        {
            return base.Yazdir() + "    Sınıf aralığı=" + Sinif;
        }
    }
}
