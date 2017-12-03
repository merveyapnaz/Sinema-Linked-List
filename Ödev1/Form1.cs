using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ödev1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        LinkedList Koltuklar = new LinkedList();
        List<int> BosKoltuklar = new List<int>();        
        
        private void BtBiletIptal_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtKoltuk.Text) < 0 || Convert.ToInt32(txtKoltuk.Text) > 60)
            {
                MessageBox.Show("Girdiğiniz Değer Hatalı Lütfen Tekrar Deneyin");
            }
            else
            {
                MessageBox.Show(Koltuklar.BiletIptal(Convert.ToInt32(txtKoltuk.Text)));
                txtKoltuk.Text = "";
            }
            
        }

        private void btBiletAl_Click(object sender, EventArgs e)
        {
            if (txtKoltuk.Text=="" || Convert.ToInt32(txtKoltuk.Text)<0 || Convert.ToInt32(txtKoltuk.Text)>60 || txtKoltuk.Text=="" || txtMusteriSoyad.Text=="" || txtMusteriAd.Text=="" )
            {
                MessageBox.Show("Girdiğiniz Değerler Hatalı! Lütfen Tekrar Deneyin ");
            }
            else
            {
                MessageBox.Show(Koltuklar.BiletAl(Convert.ToInt32(txtKoltuk.Text), txtMusteriAd.Text, txtMusteriSoyad.Text));
                txtKoltuk.Text = "";
                txtMusteriAd.Text = "";
                txtMusteriSoyad.Text = "";
            }
        }
            

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btKisiSayisi_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Salonda "+Koltuklar.Size.ToString()+" kişi bulunmaktadır.");

        }

        private void btBosKoltuklar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Koltuklar.BosKoltuklariListele(BosKoltuklar));
        }
            
        private void btDoluKoltuklar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Koltuklar.DoluKoltuklariListele());
        }

        private void btKisiOgrenme_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Koltuklar.GetElement(txtMusteriAd.Text,txtMusteriSoyad.Text));
  
        }
    }
}
