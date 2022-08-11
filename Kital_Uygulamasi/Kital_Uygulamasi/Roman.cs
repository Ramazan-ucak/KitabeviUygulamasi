using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kital_Uygulamasi
{
    class Roman : OrtakKitap
    {
        public string Konu { get; set; }

        public Roman() { }
        public Roman(string Yayinevi, string Yazar, int SayfaSayisi, string KitapAdi, int StokAdedi, double Fiyat, string Konu)
            : base(Yayinevi, Yazar, SayfaSayisi, KitapAdi, StokAdedi, Fiyat)
        {
            this.Konu = Konu;
        }
        public override string Yazdir()
        {
            return base.Yazdir() + "    Konu=" + Konu;
        }
    }
}
