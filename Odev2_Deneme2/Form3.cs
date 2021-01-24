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
    public partial class araGecis : Form
    {
        public araGecis()
        {
            InitializeComponent();
        } 

        private void btnCalisanlar_Click(object sender, EventArgs e)
        {
            ajansform yeni = new ajansform();
            yeni.Show();
            this.Hide();
        }

        

        private void btnFirmayaGit_Click(object sender, EventArgs e)
        {
            FormFirmalarımız yeni = new FormFirmalarımız();
            yeni.Show();
            this.Hide();
        }
    }
}
