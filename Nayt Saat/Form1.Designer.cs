namespace Nayt_Saat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.lblSifre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.bttnMusteriGiris = new System.Windows.Forms.Button();
            this.lblYeniKullanici = new System.Windows.Forms.Label();
            this.bttnYoneticiGiris = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1810, 818);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaShell;
            this.panel1.Controls.Add(this.bttnYoneticiGiris);
            this.panel1.Controls.Add(this.lblYeniKullanici);
            this.panel1.Controls.Add(this.bttnMusteriGiris);
            this.panel1.Controls.Add(this.txtSifre);
            this.panel1.Controls.Add(this.txtKullaniciAdi);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblSifre);
            this.panel1.Controls.Add(this.lblKullaniciAdi);
            this.panel1.Location = new System.Drawing.Point(178, 186);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(513, 495);
            this.panel1.TabIndex = 1;
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.BackColor = System.Drawing.Color.Bisque;
            this.lblKullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullaniciAdi.ForeColor = System.Drawing.Color.Brown;
            this.lblKullaniciAdi.Location = new System.Drawing.Point(24, 211);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(139, 25);
            this.lblKullaniciAdi.TabIndex = 0;
            this.lblKullaniciAdi.Text = "Kullanıcı Adı:";
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.BackColor = System.Drawing.Color.Bisque;
            this.lblSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSifre.ForeColor = System.Drawing.Color.Brown;
            this.lblSifre.Location = new System.Drawing.Point(45, 287);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(64, 25);
            this.lblSifre.TabIndex = 1;
            this.lblSifre.Text = "Şifre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Bisque;
            this.label1.Font = new System.Drawing.Font("Jokerman", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(17, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(479, 70);
            this.label1.TabIndex = 2;
            this.label1.Text = "NAYT     WATCHES";
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(194, 212);
            this.txtKullaniciAdi.Multiline = true;
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(235, 25);
            this.txtKullaniciAdi.TabIndex = 3;
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(194, 287);
            this.txtSifre.Multiline = true;
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(235, 25);
            this.txtSifre.TabIndex = 4;
            // 
            // bttnMusteriGiris
            // 
            this.bttnMusteriGiris.BackColor = System.Drawing.Color.Bisque;
            this.bttnMusteriGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bttnMusteriGiris.ForeColor = System.Drawing.Color.Brown;
            this.bttnMusteriGiris.Location = new System.Drawing.Point(145, 345);
            this.bttnMusteriGiris.Name = "bttnMusteriGiris";
            this.bttnMusteriGiris.Size = new System.Drawing.Size(120, 56);
            this.bttnMusteriGiris.TabIndex = 5;
            this.bttnMusteriGiris.Text = "Müşreti Girişi";
            this.bttnMusteriGiris.UseVisualStyleBackColor = false;
            this.bttnMusteriGiris.Click += new System.EventHandler(this.bttnMusteriGiris_Click);
            // 
            // lblYeniKullanici
            // 
            this.lblYeniKullanici.AutoSize = true;
            this.lblYeniKullanici.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYeniKullanici.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblYeniKullanici.Location = new System.Drawing.Point(348, 457);
            this.lblYeniKullanici.Name = "lblYeniKullanici";
            this.lblYeniKullanici.Size = new System.Drawing.Size(148, 20);
            this.lblYeniKullanici.TabIndex = 6;
            this.lblYeniKullanici.Text = "YENİ KULLANICI";
            this.lblYeniKullanici.Click += new System.EventHandler(this.lblYeniKullanici_Click);
            // 
            // bttnYoneticiGiris
            // 
            this.bttnYoneticiGiris.BackColor = System.Drawing.Color.Bisque;
            this.bttnYoneticiGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bttnYoneticiGiris.ForeColor = System.Drawing.Color.Brown;
            this.bttnYoneticiGiris.Location = new System.Drawing.Point(299, 345);
            this.bttnYoneticiGiris.Name = "bttnYoneticiGiris";
            this.bttnYoneticiGiris.Size = new System.Drawing.Size(120, 56);
            this.bttnYoneticiGiris.TabIndex = 7;
            this.bttnYoneticiGiris.Text = "Yönetici Girişi";
            this.bttnYoneticiGiris.UseVisualStyleBackColor = false;
            this.bttnYoneticiGiris.Click += new System.EventHandler(this.bttnYoneticiGiris_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1810, 818);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bttnMusteriGiris;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.Label lblKullaniciAdi;
        private System.Windows.Forms.Label lblYeniKullanici;
        private System.Windows.Forms.Button bttnYoneticiGiris;
    }
}

