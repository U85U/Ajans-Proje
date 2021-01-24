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
    public partial class FormFirmalarımız : Form
    {
        public FormFirmalarımız()
        {
            InitializeComponent();
        }
        firma firma = new firma();
        //public static string x;
        //double iş_ücret;

        private void btnGeriCik_Click(object sender, EventArgs e)
        {
            araGecis yeni = new araGecis();
           // iş_ücret = 0;
           // foreach (var firmam in Staticss.firmalar)
           //{
           //     iş_ücret += firmam.firma_ucret;
           // }
           // x = iş_ücret.ToString();
            yeni.Show();
            this.Hide();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
           
           
            
                DateTime dt = dateTimePicker_tarih.Value;
                string ad = txtFirmaAdı.Text;
                double para = double.Parse(txtAnlasilanPara.Text);
                string şehir = txtBulunulanSehir.Text;
                string tarih = dt.ToString();
                firma.firmaEkle(ad, para, şehir, tarih);
                txtFirmaAdı.Clear();
                txtAnlasilanPara.Clear();
                txtBulunulanSehir.Clear();
                listView_FİRMALAR_ÇF.Items.Clear();
                sırala();
            
            
        }
        void sırala()
        {
            foreach(var firmam in Staticss.firmalar)
            {
                ListViewItem ıtem = new ListViewItem();
                ıtem.Text = firmam.firma_ad;
                ıtem.SubItems.Add(firmam.firma_ucret.ToString());
                ıtem.SubItems.Add(firmam.firma_sehir);
                ıtem.SubItems.Add(firmam.firma_iş_sayısı.ToString());
                ıtem.SubItems.Add(firmam.firma_iş_tarihi.ToString());
                listView_FİRMALAR_ÇF.Items.Add(ıtem);
            }
        }

        private void FormFirmalarımız_Load(object sender, EventArgs e)
        {
            sırala();
        }

        private void btnArama_Click(object sender, EventArgs e)
        {
            string aranan = txtara.Text;
            if (aranan != "")
            {
                listView_FİRMALAR_ÇF.Items.Clear();
                foreach (var firmam in Staticss.firmalar)
                {
                    if (firmam.firma_ad == aranan)
                    {
                        ListViewItem add = new ListViewItem();

                        ListViewItem ıtem = new ListViewItem();
                        ıtem.Text = firmam.firma_ad;
                        ıtem.SubItems.Add(firmam.firma_ucret.ToString());
                        ıtem.SubItems.Add(firmam.firma_sehir);
                        ıtem.SubItems.Add(firmam.firma_iş_sayısı.ToString());
                        ıtem.SubItems.Add(firmam.firma_iş_tarihi.ToString());
                        listView_FİRMALAR_ÇF.Items.Add(ıtem);
                    }
                }

            }
            else
            {
                listView_FİRMALAR_ÇF.Items.Clear();
                sırala();
            }
        }
    }
}
