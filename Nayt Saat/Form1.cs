using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Nayt_Saat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bttnMusteriGiris_Click(object sender, EventArgs e)
        {
            StreamReader okuyucu = File.OpenText("D:\\Musteri Bilgi.txt");
            string satir = okuyucu.ReadLine();
            while (satir != null)
            {
                string[] parca = satir.Split('-');
                if (txtKullaniciAdi.Text == parca[3] && txtSifre.Text == parca[4])
                {
                    FrmMusteriGirisEkrani yeni = new FrmMusteriGirisEkrani();
                    yeni.Show();
                    this.Hide();
                    break;
                }
                else
                {
                    MessageBox.Show("Bilgileriniz yanlistir");
                }
                satir = okuyucu.ReadLine();

            }
            okuyucu.Close();
        }

        private void lblYeniKullanici_Click(object sender, EventArgs e)
        {
            FrmYeniKullanici yeni = new FrmYeniKullanici();
            yeni.Show();
            this.Hide();
        }

        private void bttnYoneticiGiris_Click(object sender, EventArgs e)
        {
            StreamReader okuyucu = File.OpenText("D:\\Musteri Bilgi.txt");
            string satir = okuyucu.ReadLine();
            while (satir != null)
            {
                string[] parca = satir.Split('-');
                if (txtKullaniciAdi.Text == parca[0] && txtSifre.Text == parca[1])
                {
                    FrmYoneticiGirisEkrani yeni = new FrmYoneticiGirisEkrani();
                    yeni.Show();
                    this.Hide();
                    break;
                }
                else
                {
                    MessageBox.Show("Bilgileriniz yanlistir");
                }
                satir = okuyucu.ReadLine();

            }
            okuyucu.Close();
        }
    }
}
