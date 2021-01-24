using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev2_Deneme2
{
    class Staticss
    {
        public static List<firma> firmalar = new List<firma>();

        public static List<çalışan> calisanlar = new List<çalışan>();

        public static List<Oyuncu> Oyuncular = new List<Oyuncu>();

        public static List<Teknik> Teknikler = new List<Teknik>();

        public static string aktifFiltre = "OYUNCU";

        public static int Data = 0;
        public static void ilk_degerler() {
            if (Data == 0)
            {
                Oyuncular.Add(new Oyuncu()
                {
                    çalışan_ad = "Utku Araal",
                    çalışan_bölüm = "OYUNCU",
                    çalışan_kategori = "SİNEMA",
                    çalışan_maas = 10000,
                    izin_kullanılan = 0,
                    izin_günü = 15,
                    ek_izin = 0,
                    projesinin_adi = "yok",
                    proje_baslangic = "belirtilmedi",
                    proje_bitis = "belirtilmedi"
                });

                Teknikler.Add(new Teknik()
                {
                    çalışan_ad = "Umut Can Altıntaş",
                    çalışan_bölüm = "OFİS",
                    çalışan_maas = 10000,
                    izin_kullanılan = 0,
                    izin_günü = 15,
                    ek_izin = 0,
                    projesinin_adi = "yok",
                    proje_baslangic = "belirtilmedi",
                    proje_bitis = "belirtilmedi"
                });

                calisanlar.Add(new çalışan()
                {
                    çalışan_ad = "Ayşe Aleyna Yavuz",
                    çalışan_bölüm = "EVRAK",
                    çalışan_maas = 10000,
                    izin_kullanılan = 0,
                    izin_günü = 15,
                    ek_izin = 0,
                });
                firmalar.Add(new firma()
                {
                    firma_ad = "DARDANEL",
                    firma_ucret = 5000,
                    firma_sehir = "İSTANBUL",
                    firma_iş_sayısı = 1,
                    firma_iş_tarihi = "5.03.2020"
                });
                firmalar.Add(new firma()
                {
                    firma_ad = "DARDANEL",
                    firma_ucret = 5000,
                    firma_sehir = "İSTANBUL",
                    firma_iş_sayısı = 2,
                    firma_iş_tarihi = "5.03.2020"
                });
                firmalar.Add(new firma()
                {
                    firma_ad = "DARDANEL",
                    firma_ucret = 5000,
                    firma_sehir = "İSTANBUL",
                    firma_iş_sayısı = 3,
                    firma_iş_tarihi = "5.03.2020"
                });
                firmalar.Add(new firma()
                {
                    firma_ad = "KOÇ HOLDİNG",
                    firma_ucret = 20000,
                    firma_sehir = "ANKARA",
                    firma_iş_sayısı = 1,
                    firma_iş_tarihi = "8.03.2020"
                });
                firmalar.Add(new firma()
                {
                    firma_ad = "NIKE",
                    firma_ucret = 10000,
                    firma_sehir = "ANKARA",
                    firma_iş_sayısı = 1,
                    firma_iş_tarihi = "12.09.2020"
                });

                Data++;
            }
        }

    }
}
