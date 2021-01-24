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
    public partial class FormGirisEkrani : Form
    {
        public FormGirisEkrani()
        {
            InitializeComponent();
        }
        public static string user="";
        private void btngiris_Click(object sender, EventArgs e)
        {

            if (txtkullanıcı.Text=="" || txtsifre.Text=="")
            {
                MessageBox.Show("Kullanıcı adı ve/veya şifre boş bırakılamaz");
            }
            if ((txtkullanıcı.Text == "yonetici") && (txtsifre.Text == "yonetici"))
            {

                user = "yonetici";
                
                            
                    MessageBox.Show("yonetici girisi yapıldı");
               
                
                araGecis yeni = new araGecis();
                yeni.Show();
                this.Hide();
            }
            if ((txtkullanıcı.Text == "yardimci") && (txtsifre.Text == "yardimci"))
            {

                user = "yardimci";
                
               
                araGecis yeni = new araGecis();
                yeni.Show();
                this.Hide();
                MessageBox.Show("müdür yardımcısı girisi yapıldı");

            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Staticss.ilk_degerler();
        }
    }
}
