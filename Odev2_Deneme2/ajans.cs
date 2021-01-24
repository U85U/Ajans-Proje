using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev2_Deneme2
{
    class ajans
    {
        public double ajans_sabigider = 18000;

        public double gider_maaslar()
        {
            double gider_maas = 0;
            foreach (var oyuncu in Staticss.Oyuncular)
            {
                gider_maas += oyuncu.çalışan_maas;
            }
            foreach (var teknik in Staticss.Teknikler)
            {
                gider_maas += teknik.çalışan_maas;
            }
            foreach (var calisann in Staticss.calisanlar)
            {
                gider_maas += calisann.çalışan_maas;
            }
            return gider_maas;
        }

        public void calisanEkle(string bolumu, string adSoyad, string category, double maasi)
        {
            if (bolumu == "OYUNCU") {
                Staticss.Oyuncular.Add(new Oyuncu()
                {
                    çalışan_ad = adSoyad,
                    çalışan_bölüm = bolumu,
                    çalışan_kategori = category,
                    çalışan_maas = maasi,
                    izin_kullanılan = 0,
                    izin_günü = 15,
                    ek_izin = 0,
                    projesinin_adi = "yok",
                    proje_baslangic = "belirtilmedi",
                    proje_bitis = "belirtilmedi"
                });
            }
            else if (bolumu == "OFİS") {
                Staticss.Teknikler.Add(new Teknik()
                {
                    çalışan_ad = adSoyad,
                    çalışan_bölüm = bolumu,
                    çalışan_maas = maasi,
                    izin_kullanılan = 0,
                    izin_günü = 15,
                    ek_izin = 0,
                    projesinin_adi = "yok",
                    proje_baslangic = "belirtilmedi",
                    proje_bitis = "belirtilmedi"
                });
            } 
            else{
                Staticss.calisanlar.Add(new çalışan()
                {
                    çalışan_ad = adSoyad,
                    çalışan_bölüm = bolumu,
                    çalışan_maas = maasi,
                    izin_kullanılan = 0,
                    izin_günü = 15,
                    ek_izin = 0
                });
            }
        }

        public void calisanCikart(string bolumu, int index)
        {
            if (bolumu == "OYUNCU")
            {
                Staticss.Oyuncular.RemoveAt(index);
            }
            else if (bolumu == "OFİS")
            {
                Staticss.Teknikler.RemoveAt(index);
            }
            else
            {
                Staticss.calisanlar.RemoveAt(index);
            }
        }

        public void maas_guncelle(string bolumu, double yeniMaas, int indexi) {
            if (bolumu == "OYUNCU")
            {
                Staticss.Oyuncular[indexi].çalışan_maas = yeniMaas;
            }
            else if (bolumu == "OFİS")
            {
                Staticss.Teknikler[indexi].çalışan_maas = yeniMaas;
            }
            else
            {
                Staticss.calisanlar[indexi].çalışan_maas = yeniMaas;
            }
        }

        public void izin_kullan(string bolumu, int kullan, int indexi) {
            if (bolumu == "OYUNCU")
            {
                Staticss.Oyuncular[indexi].izin_kullanılan += kullan;
            }
            else if (bolumu == "OFİS")
            {
                Staticss.Teknikler[indexi].izin_kullanılan += kullan;
            }
            else
            {
                Staticss.calisanlar[indexi].izin_kullanılan += kullan;
            }
        }

        public void ek_izin_tanimla(string bolumu, int ekİzin, int indexi) {
            if (bolumu == "OYUNCU")
            {
                Staticss.Oyuncular[indexi].ek_izin += ekİzin;
            }
            else if (bolumu == "OFİS")
            {
                Staticss.Teknikler[indexi].ek_izin += ekİzin;
            }
            else
            {
                Staticss.calisanlar[indexi].ek_izin += ekİzin;
            }
        }

        public void is_ata(string bolumu, string projenin_adi, DateTime baslangici, DateTime bitisi, int indexis) {
            if (bolumu == "OYUNCU")
            {
                Staticss.Oyuncular[indexis].projesinin_adi = projenin_adi;
                Staticss.Oyuncular[indexis].proje_baslangic = baslangici.ToString();
                Staticss.Oyuncular[indexis].proje_bitis = bitisi.ToString();
                Staticss.Oyuncular[indexis].çalışan_aktıiflik = "hayir";
            }
            else if (bolumu == "OFİS")
            {
                Staticss.Teknikler[indexis].projesinin_adi = projenin_adi;
                Staticss.Teknikler[indexis].proje_baslangic = baslangici.ToString();
                Staticss.Teknikler[indexis].proje_bitis = bitisi.ToString();
                Staticss.Teknikler[indexis].çalışan_aktıiflik = "hayir";
            }
        }
    }

}
