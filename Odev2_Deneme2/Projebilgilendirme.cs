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
    public partial class Projebilgilendirme : Form
    {
        int indexi { get; set; }
        public Projebilgilendirme(string mesaj, string bolumu, int indexi)
        {
            InitializeComponent();
            baslik.Text = mesaj;
            if (bolumu == "OYUNCU") {
                txtcalad.Text = Staticss.Oyuncular[indexi].çalışan_ad;
                txtcalproje.Text = Staticss.Oyuncular[indexi].projesinin_adi;
                txtcalprobas.Text = Staticss.Oyuncular[indexi].proje_baslangic;
                txtcalprobit.Text = Staticss.Oyuncular[indexi].proje_bitis;
            } 
            else if (bolumu == "OFİS") {
                txtcalad.Text = Staticss.Teknikler[indexi].çalışan_ad;
                txtcalproje.Text = Staticss.Teknikler[indexi].projesinin_adi;
                txtcalprobas.Text = Staticss.Teknikler[indexi].proje_baslangic;
                txtcalprobit.Text = Staticss.Teknikler[indexi].proje_bitis;
           }
        }

        private void btnizinKullandi_Click(object sender, EventArgs e)
        {
            ajansform ajansForm = new ajansform();
            ajansForm.Show();
            this.Close();
        }

        private void projeTemizle_Click(object sender, EventArgs e)
        {
            if (Staticss.aktifFiltre == "OYUNCU") {
                Staticss.Oyuncular[indexi].çalışan_aktıiflik = "evet";
                Staticss.Oyuncular[indexi].projesinin_adi = "yok";
                Staticss.Oyuncular[indexi].proje_baslangic = "Belirtilmedi";
                Staticss.Oyuncular[indexi].proje_bitis = "Belirtilmedi";
                ajansform ajansForm = new ajansform();
                ajansForm.Show();
            } 
            else if (Staticss.aktifFiltre == "OFİS") {
                Staticss.Teknikler[indexi].çalışan_aktıiflik = "evet";
                Staticss.Teknikler[indexi].projesinin_adi = "yok";
                Staticss.Teknikler[indexi].proje_baslangic = "Belirtilmedi";
                Staticss.Teknikler[indexi].proje_bitis = "Belirtilmedi";
                ajansform ajansForm = new ajansform();
                ajansForm.Show();
            }
            this.Close();

        }
    }
}
