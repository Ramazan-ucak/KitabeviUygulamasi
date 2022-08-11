using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kital_Uygulamasi
{
    class AkademikYayin : OrtakKitap
    {
        public string icerik { get; set; }

        public AkademikYayin() { }
        public AkademikYayin(string Yayinevi, string Yazar, int SayfaSayisi, string KitapAdi, int StokAdedi, double Fiyat, string icerik)
            : base(Yayinevi, Yazar, SayfaSayisi, KitapAdi, StokAdedi, Fiyat)
        {
            this.icerik = icerik;
        }
        public override string Yazdir()
        {
            return base.Yazdir() + "   İçerik=" + icerik;
        }
    }
}
