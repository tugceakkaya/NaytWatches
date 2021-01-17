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
    public partial class FrmYeniKullanici : Form
    {
        public FrmYeniKullanici()
        {
            InitializeComponent();
        }

        private void bttnKaydet_Click(object sender, EventArgs e)
        {
            StreamWriter yaz = File.AppendText("D:\\Musteri Bilgi.txt");
            yaz.Write(txtAd.Text + "-");
            yaz.Write(txtKullaniciAdi.Text + "-");
            yaz.Write(cmbBxCinsiyet.Text + "-");
            yaz.Write(txtSoyad.Text + "-");
            yaz.Write(txtSifre.Text);
            yaz.WriteLine();

            MessageBox.Show("Yeni Kullanıcı Kaydedildi...");
            txtAd.Text = " ";
            txtKullaniciAdi.Text = " ";
            cmbBxCinsiyet.SelectedIndex = -1;
            txtSoyad.Text = " ";
            txtSifre.Text = " ";
            yaz.Close();
            txtAd.Focus();
        }

        private void bttnAnaEkran_Click(object sender, EventArgs e)
        {
            Form1 yeni = new Form1();
            yeni.Show();
            this.Hide();
        }
    }
}
