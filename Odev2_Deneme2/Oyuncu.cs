using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev2_Deneme2
{
    class Oyuncu:çalışan
    {
        private string çalışan_kategori_;
        public string çalışan_kategori
        {
            get
            {
                if (FormGirisEkrani.user == "yonetici")
                    return çalışan_kategori_;
                else
                    return "yetki yok";
            }
            set
            {
                if (FormGirisEkrani.user != "yardimci")
                    çalışan_kategori_ = value;
            }
        }
        public string projesinin_adi { get; set; }
        public string proje_baslangic { get; set; }
        public string proje_bitis { get; set; }
        public string çalışan_aktıiflik = "evet";
    }
}
