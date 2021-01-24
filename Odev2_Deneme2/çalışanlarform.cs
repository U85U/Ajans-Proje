using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev2_Deneme2
{
    public partial class ajansform : Form
    {
        public ajansform()
        {
            InitializeComponent();
        }
        
        ajans ajans = new ajans();
        firma Firma = new firma();
        çalışan calisan = new çalışan();

        
        private void btnGeriCik_ÇF_Click(object sender, EventArgs e)
        {
            araGecis yeni = new araGecis();
            yeni.Show();
            this.Hide();
        }

        private void çalışanlarform_Load(object sender, EventArgs e)
        {
            Staticss.aktifFiltre = "OYUNCU";
            filtreOyuncu.Checked = true;
            listViewçalışan_ÇF.View = View.Details;
            listViewçalışan_ÇF.GridLines = true;
            listViewçalışan_ÇF.FullRowSelect = true; 
            


            sirala();
        }

        private void CMBBÖLÜM_ÇF_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CMBBÖLÜM_ÇF.SelectedItem == "OYUNCU" && FormGirisEkrani.user == "yonetici")
            {
                CMBKATEGORİ_ÇF.Enabled = true;
            }
            else
            {
                CMBKATEGORİ_ÇF.Text = "";
                CMBKATEGORİ_ÇF.Enabled = false;
            }
        }
        
        private void btnEkle_ÇF_Click(object sender, EventArgs e)
        {
            if (FormGirisEkrani.user != "yonetici")
            {
                MessageBox.Show("yetkiniz yok");
                txtADSOYAD_ÇF.Clear();
                CMBBÖLÜM_ÇF.Text = " ";
                CMBKATEGORİ_ÇF.Text = " ";
                txt_MAAS_ÇF.Clear();
            }
            else
            {
                string txtad = txtADSOYAD_ÇF.Text;
                string txtbolum = CMBBÖLÜM_ÇF.Text;
                string txtkategori = CMBKATEGORİ_ÇF.Text;
                double txtmaas = Convert.ToDouble(txt_MAAS_ÇF.Text);
                ajans.calisanEkle(txtbolum, txtad, txtkategori, txtmaas);

                sirala();
                txtADSOYAD_ÇF.Clear();
                CMBBÖLÜM_ÇF.Text = " ";
                CMBKATEGORİ_ÇF.Text = " ";
                txt_MAAS_ÇF.Clear();
            }
        }

        private void btnTEMİZLE_ÇF_Click(object sender, EventArgs e)
        {
            int seçilen_sayısı = listViewçalışan_ÇF.CheckedItems.Count;
            if (seçilen_sayısı > 1)
            {
                MessageBox.Show("Tek seferde yalnızca 1 kişi silebilirsiniz!");
            }
            else if (seçilen_sayısı == 0)
            {
                MessageBox.Show("Seçim yapmadınız!");
            }
            else {
                foreach (int index in listViewçalışan_ÇF.CheckedIndices)
                {
                    ajans.calisanCikart(Staticss.aktifFiltre ,index);
                }
                sirala();
            }
        }

        private void btnMaliRaporOlustur_Click(object sender, EventArgs e)
        {
            textBoxAJANS_GİDER.Text = ajans.gider_maaslar().ToString();
            textBoxAJANS_GELİR.Text = Firma.gelirToplam().ToString();
            txtMaliSonuc.Text = (Firma.gelirToplam() - (ajans.gider_maaslar() + ajans.ajans_sabigider)).ToString();
        }

        private void BTN_GÜNCELLE_ÇF_Click(object sender, EventArgs e)
        {
            if (FormGirisEkrani.user == "yardimci")
            {
                MessageBox.Show("yetkiniz yok");
            }
            else
            {
                double yeni_maas = Convert.ToDouble(TXT_YENİ_MAAS.Text);
                foreach (int index in listViewçalışan_ÇF.CheckedIndices)
                {
                    ajans.maas_guncelle(Staticss.aktifFiltre, yeni_maas, index);
                }
                TXT_YENİ_MAAS.Clear();
                sirala();
            }
        }
        public void sirala() {
            listViewçalışan_ÇF.Items.Clear();
            if (Staticss.aktifFiltre == "OYUNCU")
            {
                foreach (var oyuncu in Staticss.Oyuncular)
                {
                    ListViewItem ıtem = new ListViewItem();
                    ıtem.Text = oyuncu.çalışan_ad;
                    ıtem.SubItems.Add(oyuncu.çalışan_bölüm);
                    ıtem.SubItems.Add(oyuncu.çalışan_maas.ToString());
                    ıtem.SubItems.Add(oyuncu.izin_günü.ToString());
                    ıtem.SubItems.Add(oyuncu.ek_izin.ToString());
                    ıtem.SubItems.Add(oyuncu.izin_kullanılan.ToString());
                    ıtem.SubItems.Add(oyuncu.çalışan_aktıiflik);
                    ıtem.SubItems.Add(oyuncu.çalışan_kategori);
                    listViewçalışan_ÇF.Items.Add(ıtem);
                }
            }
            else if (Staticss.aktifFiltre == "OFİS")
            {
                foreach (var teknik in Staticss.Teknikler)
                {
                    ListViewItem ıtem = new ListViewItem();
                    ıtem.Text = teknik.çalışan_ad;
                    ıtem.SubItems.Add(teknik.çalışan_bölüm);
                    ıtem.SubItems.Add(teknik.çalışan_maas.ToString());
                    ıtem.SubItems.Add(teknik.izin_günü.ToString());
                    ıtem.SubItems.Add(teknik.ek_izin.ToString());
                    ıtem.SubItems.Add(teknik.izin_kullanılan.ToString());
                    ıtem.SubItems.Add(teknik.çalışan_aktıiflik);
                    listViewçalışan_ÇF.Items.Add(ıtem);
                }
            }
            else if (Staticss.aktifFiltre == "EVRAK")
            {
                foreach (var calisanim in Staticss.calisanlar)
                {
                    ListViewItem ıtem = new ListViewItem();
                    ıtem.Text = calisanim.çalışan_ad;
                    ıtem.SubItems.Add(calisanim.çalışan_bölüm);
                    ıtem.SubItems.Add(calisanim.çalışan_maas.ToString());
                    ıtem.SubItems.Add(calisanim.izin_günü.ToString());
                    ıtem.SubItems.Add(calisanim.ek_izin.ToString());
                    ıtem.SubItems.Add(calisanim.izin_kullanılan.ToString());
                    listViewçalışan_ÇF.Items.Add(ıtem);
                }
            }
        }

        private void btnizinKullandi_Click(object sender, EventArgs e)
        {
            int seçilen_sayısı = listViewçalışan_ÇF.CheckedItems.Count;
            int kullandigi_izin = int.Parse(txtkullanilanİzin.Text);
            if (seçilen_sayısı > 1)
            {
                MessageBox.Show("Tek seferde yalnızca 1 kişi seçebilirsiniz!");
            }
            else if (seçilen_sayısı == 0)
            {
                MessageBox.Show("Seçim yapmadınız!");
            }
            else
            {
                foreach (int index in listViewçalışan_ÇF.CheckedIndices)
                {
                    ajans.izin_kullan(Staticss.aktifFiltre, kullandigi_izin, index);
                }
                txtkullanilanİzin.Clear();
                sirala();
            }
        }

        private void btnekİzinVer_Click(object sender, EventArgs e)
        {
            int seçilen_sayısı = listViewçalışan_ÇF.CheckedItems.Count;
            int verilen_ek_izin = int.Parse(txtVerilenizin.Text);
            if (seçilen_sayısı > 1)
            {
                MessageBox.Show("Tek seferde yalnızca 1 kişi seçebilirsiniz!");
            }
            else if (seçilen_sayısı == 0)
            {
                MessageBox.Show("Seçim yapmadınız!");
            }
            else
            {
                foreach (int index in listViewçalışan_ÇF.CheckedIndices)
                {
                    ajans.ek_izin_tanimla(Staticss.aktifFiltre, verilen_ek_izin, index);
                }
                txtVerilenizin.Clear();
                sirala();
            }
        }

        private void BTN_İŞATA_Click(object sender, EventArgs e)
        {
            int seçilen_sayısı = listViewçalışan_ÇF.CheckedItems.Count;
            string projenin_adi= TXT_PROJEADI_ÇF.Text;
            DateTime baslangici = dtbaslangic.Value;
            DateTime bitisi = dtbitis.Value;
            string secilen_aktifligi = "hayır";
            int indexis = 0;
            string mesaj = "Seçtiğiniz çalışan şu proje ile meşgul";
            if (Staticss.aktifFiltre == "EVRAK")
            {
                MessageBox.Show("Bu bölüm çalışanlarına proje atayamazsınız!");
            }
            else { 
                foreach (int index in listViewçalışan_ÇF.CheckedIndices)
                {
                    secilen_aktifligi = listViewçalışan_ÇF.Items[index].SubItems[6].Text;
                    indexis = index;
                }
                if (seçilen_sayısı > 1)
                {
                    MessageBox.Show("Tek seferde yalnızca 1 kişi seçebilirsiniz!");
                }
                else if (seçilen_sayısı == 0)
                {
                    MessageBox.Show("Seçim yapmadınız!");
                }
                else if (projenin_adi == "")
                {
                    MessageBox.Show("Lütfen proje adı giriniz!");
                }
                else if (secilen_aktifligi == "hayir")
                {
                    if (Staticss.aktifFiltre == "OYUNCU")
                    {
                        Projebilgilendirme bilgiEkran = new Projebilgilendirme(mesaj, Staticss.aktifFiltre, indexis);
                        bilgiEkran.Show();
                    }
                    else if (Staticss.aktifFiltre == "OFİS")
                    {
                        Projebilgilendirme bilgiEkran = new Projebilgilendirme(mesaj, Staticss.aktifFiltre, indexis);
                        bilgiEkran.Show();
                    }
                    this.Close();
                    TXT_PROJEADI_ÇF.Clear();
                }
                else
                {
                    ajans.is_ata(Staticss.aktifFiltre, projenin_adi, baslangici, bitisi, indexis);
                    TXT_PROJEADI_ÇF.Clear();
                    sirala();
                }
            }
        }

        private void projeSorgula_Click(object sender, EventArgs e)
        {
            int seçilen_sayısı = listViewçalışan_ÇF.CheckedItems.Count;
            int indexis = 0;
            string mesaj = "Proje Bilgileri";
            foreach (int index in listViewçalışan_ÇF.CheckedIndices)
            {
                indexis = index;
            }

            if (seçilen_sayısı > 1)
            {
                MessageBox.Show("Tek seferde yalnızca 1 kişi seçebilirsiniz!");
            }
            else if (seçilen_sayısı == 0)
            {
                MessageBox.Show("Seçim yapmadınız!");
            }
            else if (Staticss.aktifFiltre == "EVRAK") {
                MessageBox.Show("Bu bölüm çalışanlarının proje özelliği bulunmamaktadır!");
            }
            else
            {
                if (Staticss.aktifFiltre == "OYUNCU") {
                    Projebilgilendirme bilgiEkran = new Projebilgilendirme(mesaj, Staticss.aktifFiltre, indexis);
                    bilgiEkran.Show();
                } 
                else if (Staticss.aktifFiltre == "OFİS") {                    
                    Projebilgilendirme bilgiEkran = new Projebilgilendirme(mesaj, Staticss.aktifFiltre, indexis);
                    bilgiEkran.Show();
                }
                this.Close();
            }
        }

        private void filtreEvrak_CheckedChanged(object sender, EventArgs e)
        {
            if (filtreEvrak.Checked == true) {
                Staticss.aktifFiltre = "EVRAK";
                listViewçalışan_ÇF.Columns.Clear();
                listViewçalışan_ÇF.Columns.Add("ADI SOYADI", 150);
                listViewçalışan_ÇF.Columns.Add("BÖLÜM", 150);
                listViewçalışan_ÇF.Columns.Add("MAAŞ", 100);
                listViewçalışan_ÇF.Columns.Add("İZİN GÜNÜ", 60);
                listViewçalışan_ÇF.Columns.Add("EK İZİN", 60);
                listViewçalışan_ÇF.Columns.Add("KULLANILAN İZİN", 60);
                sirala();
            }
        }

        private void filtreOyuncu_CheckedChanged(object sender, EventArgs e)
        {
            if (filtreOyuncu.Checked == true) {
                Staticss.aktifFiltre = "OYUNCU";
                listViewçalışan_ÇF.Columns.Clear();
                listViewçalışan_ÇF.Columns.Add("ADI SOYADI", 150);
                listViewçalışan_ÇF.Columns.Add("BÖLÜM", 150);
                listViewçalışan_ÇF.Columns.Add("MAAŞ", 100);
                listViewçalışan_ÇF.Columns.Add("İZİN GÜNÜ", 60);
                listViewçalışan_ÇF.Columns.Add("EK İZİN", 60);
                listViewçalışan_ÇF.Columns.Add("KULLANILAN İZİN", 60);
                listViewçalışan_ÇF.Columns.Add("AKTİFLİK", 50);
                listViewçalışan_ÇF.Columns.Add("KATEGORİ", 150);
                sirala();
            }
        }

        private void filtreTeknik_CheckedChanged(object sender, EventArgs e)
        {
            if (filtreTeknik.Checked == true)
            {
                Staticss.aktifFiltre = "OFİS";
                listViewçalışan_ÇF.Columns.Clear();
                listViewçalışan_ÇF.Columns.Add("ADI SOYADI", 150);
                listViewçalışan_ÇF.Columns.Add("BÖLÜM", 150);
                listViewçalışan_ÇF.Columns.Add("MAAŞ", 100);
                listViewçalışan_ÇF.Columns.Add("İZİN GÜNÜ", 60);
                listViewçalışan_ÇF.Columns.Add("EK İZİN", 60);
                listViewçalışan_ÇF.Columns.Add("KULLANILAN İZİN", 60);
                listViewçalışan_ÇF.Columns.Add("AKTİFLİK", 50);
                sirala();
                
            }
        }
    }
}
