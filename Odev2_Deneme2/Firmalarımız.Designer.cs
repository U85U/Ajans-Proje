namespace Odev2_Deneme2
{
    partial class FormFirmalarımız
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGeriCik = new System.Windows.Forms.Button();
            this.listView_FİRMALAR_ÇF = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblFirmaAd = new System.Windows.Forms.Label();
            this.txtFirmaAdı = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAnlasilanPara = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBulunulanSehir = new System.Windows.Forms.TextBox();
            this.btnArama = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.label_tarih = new System.Windows.Forms.Label();
            this.dateTimePicker_tarih = new System.Windows.Forms.DateTimePicker();
            this.txtara = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGeriCik
            // 
            this.btnGeriCik.BackColor = System.Drawing.Color.Black;
            this.btnGeriCik.ForeColor = System.Drawing.Color.White;
            this.btnGeriCik.Location = new System.Drawing.Point(16, 686);
            this.btnGeriCik.Name = "btnGeriCik";
            this.btnGeriCik.Size = new System.Drawing.Size(118, 35);
            this.btnGeriCik.TabIndex = 35;
            this.btnGeriCik.Text = "GERİ ÇIK";
            this.btnGeriCik.UseVisualStyleBackColor = false;
            this.btnGeriCik.Click += new System.EventHandler(this.btnGeriCik_Click);
            // 
            // listView_FİRMALAR_ÇF
            // 
            this.listView_FİRMALAR_ÇF.CheckBoxes = true;
            this.listView_FİRMALAR_ÇF.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView_FİRMALAR_ÇF.GridLines = true;
            this.listView_FİRMALAR_ÇF.HideSelection = false;
            this.listView_FİRMALAR_ÇF.Location = new System.Drawing.Point(16, 93);
            this.listView_FİRMALAR_ÇF.Name = "listView_FİRMALAR_ÇF";
            this.listView_FİRMALAR_ÇF.Size = new System.Drawing.Size(1358, 504);
            this.listView_FİRMALAR_ÇF.TabIndex = 37;
            this.listView_FİRMALAR_ÇF.UseCompatibleStateImageBehavior = false;
            this.listView_FİRMALAR_ÇF.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "      FİRMA İSMİ";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ANLAŞILAN ÜCRET";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "BULUNDUĞU ŞEHİR";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 200;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "ÇALIŞMA SAYISI";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 200;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "ÇALIŞMA TARİHİ";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 200;
            // 
            // lblFirmaAd
            // 
            this.lblFirmaAd.BackColor = System.Drawing.Color.Black;
            this.lblFirmaAd.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFirmaAd.ForeColor = System.Drawing.Color.White;
            this.lblFirmaAd.Location = new System.Drawing.Point(12, 9);
            this.lblFirmaAd.Name = "lblFirmaAd";
            this.lblFirmaAd.Size = new System.Drawing.Size(193, 30);
            this.lblFirmaAd.TabIndex = 38;
            this.lblFirmaAd.Text = "Firma Adı";
            // 
            // txtFirmaAdı
            // 
            this.txtFirmaAdı.Location = new System.Drawing.Point(16, 42);
            this.txtFirmaAdı.Multiline = true;
            this.txtFirmaAdı.Name = "txtFirmaAdı";
            this.txtFirmaAdı.Size = new System.Drawing.Size(193, 29);
            this.txtFirmaAdı.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(258, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 30);
            this.label1.TabIndex = 40;
            this.label1.Text = "Kaç Paraya Anlaştık?";
            // 
            // txtAnlasilanPara
            // 
            this.txtAnlasilanPara.Location = new System.Drawing.Point(262, 42);
            this.txtAnlasilanPara.Multiline = true;
            this.txtAnlasilanPara.Name = "txtAnlasilanPara";
            this.txtAnlasilanPara.Size = new System.Drawing.Size(193, 29);
            this.txtAnlasilanPara.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(516, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 30);
            this.label2.TabIndex = 42;
            this.label2.Text = "Bulunduğu Şehir";
            // 
            // txtBulunulanSehir
            // 
            this.txtBulunulanSehir.Location = new System.Drawing.Point(516, 42);
            this.txtBulunulanSehir.Multiline = true;
            this.txtBulunulanSehir.Name = "txtBulunulanSehir";
            this.txtBulunulanSehir.Size = new System.Drawing.Size(193, 29);
            this.txtBulunulanSehir.TabIndex = 43;
            // 
            // btnArama
            // 
            this.btnArama.BackColor = System.Drawing.Color.Navy;
            this.btnArama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnArama.ForeColor = System.Drawing.Color.White;
            this.btnArama.Location = new System.Drawing.Point(767, 626);
            this.btnArama.Name = "btnArama";
            this.btnArama.Size = new System.Drawing.Size(138, 41);
            this.btnArama.TabIndex = 46;
            this.btnArama.Text = "Ara";
            this.btnArama.UseVisualStyleBackColor = false;
            this.btnArama.Click += new System.EventHandler(this.btnArama_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.Navy;
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.ForeColor = System.Drawing.Color.White;
            this.btnEkle.Location = new System.Drawing.Point(962, 30);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(137, 41);
            this.btnEkle.TabIndex = 47;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // label_tarih
            // 
            this.label_tarih.BackColor = System.Drawing.Color.Black;
            this.label_tarih.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_tarih.ForeColor = System.Drawing.Color.White;
            this.label_tarih.Location = new System.Drawing.Point(763, 9);
            this.label_tarih.Name = "label_tarih";
            this.label_tarih.Size = new System.Drawing.Size(193, 30);
            this.label_tarih.TabIndex = 50;
            this.label_tarih.Text = "TARİH";
            // 
            // dateTimePicker_tarih
            // 
            this.dateTimePicker_tarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_tarih.Location = new System.Drawing.Point(767, 42);
            this.dateTimePicker_tarih.Name = "dateTimePicker_tarih";
            this.dateTimePicker_tarih.Size = new System.Drawing.Size(110, 22);
            this.dateTimePicker_tarih.TabIndex = 51;
            // 
            // txtara
            // 
            this.txtara.Location = new System.Drawing.Point(520, 626);
            this.txtara.Multiline = true;
            this.txtara.Name = "txtara";
            this.txtara.Size = new System.Drawing.Size(189, 41);
            this.txtara.TabIndex = 52;
            // 
            // FormFirmalarımız
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1386, 735);
            this.Controls.Add(this.txtara);
            this.Controls.Add(this.dateTimePicker_tarih);
            this.Controls.Add(this.label_tarih);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnArama);
            this.Controls.Add(this.txtBulunulanSehir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAnlasilanPara);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFirmaAdı);
            this.Controls.Add(this.lblFirmaAd);
            this.Controls.Add(this.listView_FİRMALAR_ÇF);
            this.Controls.Add(this.btnGeriCik);
            this.Name = "FormFirmalarımız";
            this.Text = "Firmalarımız";
            this.Load += new System.EventHandler(this.FormFirmalarımız_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGeriCik;
        private System.Windows.Forms.ListView listView_FİRMALAR_ÇF;
        private System.Windows.Forms.Label lblFirmaAd;
        private System.Windows.Forms.TextBox txtFirmaAdı;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAnlasilanPara;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBulunulanSehir;
        private System.Windows.Forms.Button btnArama;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label label_tarih;
        private System.Windows.Forms.DateTimePicker dateTimePicker_tarih;
        private System.Windows.Forms.TextBox txtara;
    }
}