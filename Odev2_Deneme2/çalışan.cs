using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev2_Deneme2
{
    class çalışan
    {
        public string çalışan_ad { get; set; }
        private double çalışan_maas_;
        public double çalışan_maas
        {
            get {
                    return çalışan_maas_;
            }
            set {
                if (FormGirisEkrani.user !="yardimci")
                {
                    çalışan_maas_ = value;
                }
            }
        }

        public string çalışan_bölüm { get; set; }
        public int izin_günü { get; set; }
        public int ek_izin { get; set; }
        

        public int izin_kullanılan { get; set; }
        
        public string giris = "yonetici";
        
        
        public double çalışan_gider = 0;
        



        
    }
}
