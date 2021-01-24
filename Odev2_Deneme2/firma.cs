using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev2_Deneme2
{
    class firma
    {
        public string firma_ad { get; set; }
        public double firma_ucret { get; set; }
        public string firma_sehir { get; set; }
        public int firma_iş_sayısı { get;  set; }
        public string firma_iş_tarihi { get; set; }

        
        public void firmaEkle(string isim, double fiyat, string nereden, string tarih)
        {

            int sayi = 0;

            for (int i = 0; i < Staticss.firmalar.Count(); i++)
            {
                if (Staticss.firmalar[i].firma_ad == isim)
                {
                    sayi++;
                }
            }

            if (sayi >= 3)
            {
                fiyat = (fiyat * 80) / 100;
            }

            sayi++;

            Staticss.firmalar.Add(new firma()
            {
                firma_ad = isim,
                firma_ucret = fiyat,
                firma_sehir = nereden,
                firma_iş_sayısı = sayi,
                firma_iş_tarihi = tarih
            });
        }
        public double gelirToplam()
        {
            double gelir_firma = 0;
            foreach (var firma in Staticss.firmalar)
            {
                gelir_firma += firma.firma_ucret;
            }
            return gelir_firma;
        }
    }
}
