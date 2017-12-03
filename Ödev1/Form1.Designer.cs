namespace Ödev1
{
    partial class Form1
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
            this.btBiletAl = new System.Windows.Forms.Button();
            this.BtBiletIptal = new System.Windows.Forms.Button();
            this.txtKoltuk = new System.Windows.Forms.TextBox();
            this.btKisiSayisi = new System.Windows.Forms.Button();
            this.btBosKoltuklar = new System.Windows.Forms.Button();
            this.btDoluKoltuklar = new System.Windows.Forms.Button();
            this.txtMusteriAd = new System.Windows.Forms.TextBox();
            this.lbMusteriAd = new System.Windows.Forms.Label();
            this.txtMusteriSoyad = new System.Windows.Forms.TextBox();
            this.lbMusteriSoyad = new System.Windows.Forms.Label();
            this.lbKoltukNo = new System.Windows.Forms.Label();
            this.btKoltukNoOgrenme = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btBiletAl
            // 
            this.btBiletAl.BackColor = System.Drawing.Color.Silver;
            this.btBiletAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btBiletAl.ForeColor = System.Drawing.Color.Black;
            this.btBiletAl.Location = new System.Drawing.Point(11, 121);
            this.btBiletAl.Name = "btBiletAl";
            this.btBiletAl.Size = new System.Drawing.Size(126, 27);
            this.btBiletAl.TabIndex = 4;
            this.btBiletAl.Text = "Bilet Al";
            this.btBiletAl.UseVisualStyleBackColor = false;
            this.btBiletAl.Click += new System.EventHandler(this.btBiletAl_Click);
            // 
            // BtBiletIptal
            // 
            this.BtBiletIptal.BackColor = System.Drawing.Color.Silver;
            this.BtBiletIptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtBiletIptal.ForeColor = System.Drawing.Color.Black;
            this.BtBiletIptal.Location = new System.Drawing.Point(191, 121);
            this.BtBiletIptal.Name = "BtBiletIptal";
            this.BtBiletIptal.Size = new System.Drawing.Size(118, 27);
            this.BtBiletIptal.TabIndex = 6;
            this.BtBiletIptal.Text = "Bilet İptal Et";
            this.BtBiletIptal.UseVisualStyleBackColor = false;
            this.BtBiletIptal.Click += new System.EventHandler(this.BtBiletIptal_Click);
            // 
            // txtKoltuk
            // 
            this.txtKoltuk.BackColor = System.Drawing.Color.Silver;
            this.txtKoltuk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKoltuk.ForeColor = System.Drawing.Color.Black;
            this.txtKoltuk.Location = new System.Drawing.Point(156, 78);
            this.txtKoltuk.Name = "txtKoltuk";
            this.txtKoltuk.Size = new System.Drawing.Size(153, 21);
            this.txtKoltuk.TabIndex = 3;
            // 
            // btKisiSayisi
            // 
            this.btKisiSayisi.BackColor = System.Drawing.Color.Silver;
            this.btKisiSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btKisiSayisi.ForeColor = System.Drawing.Color.Black;
            this.btKisiSayisi.Location = new System.Drawing.Point(11, 212);
            this.btKisiSayisi.Name = "btKisiSayisi";
            this.btKisiSayisi.Size = new System.Drawing.Size(298, 23);
            this.btKisiSayisi.TabIndex = 7;
            this.btKisiSayisi.Text = "Salondaki Kişi Sayısı";
            this.btKisiSayisi.UseVisualStyleBackColor = false;
            this.btKisiSayisi.Click += new System.EventHandler(this.btKisiSayisi_Click);
            // 
            // btBosKoltuklar
            // 
            this.btBosKoltuklar.BackColor = System.Drawing.Color.Silver;
            this.btBosKoltuklar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btBosKoltuklar.ForeColor = System.Drawing.Color.Black;
            this.btBosKoltuklar.Location = new System.Drawing.Point(191, 241);
            this.btBosKoltuklar.Name = "btBosKoltuklar";
            this.btBosKoltuklar.Size = new System.Drawing.Size(118, 23);
            this.btBosKoltuklar.TabIndex = 9;
            this.btBosKoltuklar.Text = "Boş Koltuklar";
            this.btBosKoltuklar.UseVisualStyleBackColor = false;
            this.btBosKoltuklar.Click += new System.EventHandler(this.btBosKoltuklar_Click);
            // 
            // btDoluKoltuklar
            // 
            this.btDoluKoltuklar.BackColor = System.Drawing.Color.Silver;
            this.btDoluKoltuklar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btDoluKoltuklar.ForeColor = System.Drawing.Color.Black;
            this.btDoluKoltuklar.Location = new System.Drawing.Point(12, 241);
            this.btDoluKoltuklar.Name = "btDoluKoltuklar";
            this.btDoluKoltuklar.Size = new System.Drawing.Size(125, 23);
            this.btDoluKoltuklar.TabIndex = 8;
            this.btDoluKoltuklar.Text = "Dolu Koltuklar";
            this.btDoluKoltuklar.UseVisualStyleBackColor = false;
            this.btDoluKoltuklar.Click += new System.EventHandler(this.btDoluKoltuklar_Click);
            // 
            // txtMusteriAd
            // 
            this.txtMusteriAd.BackColor = System.Drawing.Color.Silver;
            this.txtMusteriAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMusteriAd.ForeColor = System.Drawing.Color.Black;
            this.txtMusteriAd.Location = new System.Drawing.Point(156, 9);
            this.txtMusteriAd.Name = "txtMusteriAd";
            this.txtMusteriAd.Size = new System.Drawing.Size(153, 21);
            this.txtMusteriAd.TabIndex = 1;
            // 
            // lbMusteriAd
            // 
            this.lbMusteriAd.AutoSize = true;
            this.lbMusteriAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbMusteriAd.ForeColor = System.Drawing.Color.Silver;
            this.lbMusteriAd.Location = new System.Drawing.Point(12, 15);
            this.lbMusteriAd.Name = "lbMusteriAd";
            this.lbMusteriAd.Size = new System.Drawing.Size(74, 15);
            this.lbMusteriAd.TabIndex = 9;
            this.lbMusteriAd.Text = "Müşteri Adı :";
            // 
            // txtMusteriSoyad
            // 
            this.txtMusteriSoyad.BackColor = System.Drawing.Color.Silver;
            this.txtMusteriSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMusteriSoyad.ForeColor = System.Drawing.Color.Black;
            this.txtMusteriSoyad.Location = new System.Drawing.Point(156, 39);
            this.txtMusteriSoyad.Name = "txtMusteriSoyad";
            this.txtMusteriSoyad.Size = new System.Drawing.Size(153, 21);
            this.txtMusteriSoyad.TabIndex = 2;
            // 
            // lbMusteriSoyad
            // 
            this.lbMusteriSoyad.AutoSize = true;
            this.lbMusteriSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbMusteriSoyad.ForeColor = System.Drawing.Color.Silver;
            this.lbMusteriSoyad.Location = new System.Drawing.Point(12, 42);
            this.lbMusteriSoyad.Name = "lbMusteriSoyad";
            this.lbMusteriSoyad.Size = new System.Drawing.Size(94, 15);
            this.lbMusteriSoyad.TabIndex = 11;
            this.lbMusteriSoyad.Text = "Müşteri Soyadı :";
            // 
            // lbKoltukNo
            // 
            this.lbKoltukNo.AutoSize = true;
            this.lbKoltukNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbKoltukNo.ForeColor = System.Drawing.Color.Silver;
            this.lbKoltukNo.Location = new System.Drawing.Point(12, 84);
            this.lbKoltukNo.Name = "lbKoltukNo";
            this.lbKoltukNo.Size = new System.Drawing.Size(66, 15);
            this.lbKoltukNo.TabIndex = 12;
            this.lbKoltukNo.Text = "Koltuk No :";
            // 
            // btKoltukNoOgrenme
            // 
            this.btKoltukNoOgrenme.BackColor = System.Drawing.Color.Silver;
            this.btKoltukNoOgrenme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btKoltukNoOgrenme.ForeColor = System.Drawing.Color.Black;
            this.btKoltukNoOgrenme.Location = new System.Drawing.Point(11, 179);
            this.btKoltukNoOgrenme.Name = "btKoltukNoOgrenme";
            this.btKoltukNoOgrenme.Size = new System.Drawing.Size(298, 27);
            this.btKoltukNoOgrenme.TabIndex = 14;
            this.btKoltukNoOgrenme.Text = "Kişinin Koltuk Numarasını Bul";
            this.btKoltukNoOgrenme.UseVisualStyleBackColor = false;
            this.btKoltukNoOgrenme.Click += new System.EventHandler(this.btKisiOgrenme_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(325, 289);
            this.Controls.Add(this.btKoltukNoOgrenme);
            this.Controls.Add(this.lbKoltukNo);
            this.Controls.Add(this.txtMusteriSoyad);
            this.Controls.Add(this.lbMusteriSoyad);
            this.Controls.Add(this.txtMusteriAd);
            this.Controls.Add(this.lbMusteriAd);
            this.Controls.Add(this.btDoluKoltuklar);
            this.Controls.Add(this.btBosKoltuklar);
            this.Controls.Add(this.btKisiSayisi);
            this.Controls.Add(this.txtKoltuk);
            this.Controls.Add(this.BtBiletIptal);
            this.Controls.Add(this.btBiletAl);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "BOLLYWOOD";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btBiletAl;
        private System.Windows.Forms.Button BtBiletIptal;
        private System.Windows.Forms.TextBox txtKoltuk;
        private System.Windows.Forms.Button btKisiSayisi;
        private System.Windows.Forms.Button btBosKoltuklar;
        private System.Windows.Forms.Button btDoluKoltuklar;
        private System.Windows.Forms.TextBox txtMusteriAd;
        private System.Windows.Forms.Label lbMusteriAd;
        private System.Windows.Forms.TextBox txtMusteriSoyad;
        private System.Windows.Forms.Label lbMusteriSoyad;
        private System.Windows.Forms.Label lbKoltukNo;
        private System.Windows.Forms.Button btKoltukNoOgrenme;
    }
}

