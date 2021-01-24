namespace Odev2_Deneme2
{
    partial class araGecis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(araGecis));
            this.btnFirmayaGit = new System.Windows.Forms.Button();
            this.btnAJANS = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFirmayaGit
            // 
            this.btnFirmayaGit.BackColor = System.Drawing.Color.Black;
            this.btnFirmayaGit.ForeColor = System.Drawing.Color.White;
            this.btnFirmayaGit.Location = new System.Drawing.Point(85, 170);
            this.btnFirmayaGit.Name = "btnFirmayaGit";
            this.btnFirmayaGit.Size = new System.Drawing.Size(112, 31);
            this.btnFirmayaGit.TabIndex = 1;
            this.btnFirmayaGit.Text = "FİRMALAR";
            this.btnFirmayaGit.UseVisualStyleBackColor = false;
            this.btnFirmayaGit.Click += new System.EventHandler(this.btnFirmayaGit_Click);
            // 
            // btnAJANS
            // 
            this.btnAJANS.BackColor = System.Drawing.Color.Black;
            this.btnAJANS.ForeColor = System.Drawing.Color.White;
            this.btnAJANS.Location = new System.Drawing.Point(344, 170);
            this.btnAJANS.Name = "btnAJANS";
            this.btnAJANS.Size = new System.Drawing.Size(112, 31);
            this.btnAJANS.TabIndex = 2;
            this.btnAJANS.Text = "AJANS";
            this.btnAJANS.UseVisualStyleBackColor = false;
            this.btnAJANS.Click += new System.EventHandler(this.btnCalisanlar_Click);
            // 
            // araGecis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(535, 208);
            this.Controls.Add(this.btnAJANS);
            this.Controls.Add(this.btnFirmayaGit);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "araGecis";
            this.Text = "Geçiş Formu";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnFirmayaGit;
        private System.Windows.Forms.Button btnAJANS;
    }
}