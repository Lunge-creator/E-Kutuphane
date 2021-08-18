using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using MySql.Data.MySqlClient;

namespace WinFormsApp
{
    public partial class SifreUnuttum : Form
    {
        string _vtadresi = "91.151.90.171";
        string _ka = "oguzhanturan";
        string _sifre = "Ozi123456*";
        string _vt = "admin_oguzhanturan";
        public string connection;
        string randomCode;
        int hak=3;
        public SifreUnuttum()
        {
            this.connection = $"SERVER={_vtadresi};DATABASE={_vt};UID={_ka};PWD={_sifre}";
            InitializeComponent();
            this.Opacity = 0.85;
        }
        private void baglantıac()
        {
            using (var baglan = new MySqlConnection(this.connection))
            {
                if (baglan.State == ConnectionState.Closed)
                {
                    baglan.Open();
                }
            }
        }
        private void buttonSifreGonder_Click(object sender, EventArgs e)
        {
            textBoxKod.Visible = true;
            panelKod.Visible = true;
            using (var baglan = new MySqlConnection(this.connection))
            {
                using (var komut = new MySqlCommand("Select*From kullanicilar where kullaniciadi='" + textBoxUsername.Text + "'And eposta='" +
                   textBoxMail.Text + "'", baglan))
                {
                    baglantıac();
                    baglan.Open();
                    MySqlDataReader dataReader = komut.ExecuteReader();
                    if (dataReader.Read())
                    {
                        try
                        {
                            textBoxKod.Visible = true;
                            buttonKodDogrula.Visible = true;
                            labelKod.Visible = true;
                            buttonSifreGonder.Visible = false;
                            panelKod.Visible = true;
                            Random rnd = new Random();
                            randomCode = (rnd.Next(999999)).ToString();
                            SmtpClient smtpserver = new SmtpClient();
                            MailMessage mail = new MailMessage();
                            String tarih = DateTime.Now.ToLongDateString();
                            String mailadresi = "kotomasyonu@gmail.com";
                            String smpt = "smtp.gmail.com";
                            String sifre = "Ozi123456";
                            String yaz = "Sayın," + dataReader["kullaniciadi"].ToString() + "\n" + "Bizden " + tarih + " Doğrulama kodu " +
                                    "Talebinde Bulundunuz" + "\n" + "Doğrulama kodunuz:" + randomCode;
                            smtpserver.Credentials = new NetworkCredential(mailadresi, sifre);
                            smtpserver.Port = 587;
                            smtpserver.Host = smpt;
                            smtpserver.EnableSsl = true;
                            mail.From = new MailAddress(mailadresi);
                            mail.To.Add(dataReader["eposta"].ToString());
                            mail.Subject = "Doğrulama Kodu Maili";
                            mail.Body = yaz;
                            smtpserver.Send(mail);
                            MessageBox.Show("Doğrulama kodunuz başarılı bir şekilde mail adresinize yollandı.");
                        }
                        catch (Exception hata)
                        {
                            MessageBox.Show("Hata: " + hata);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Girdiğiniz bilgilere ait bir kullanıcı bulunamadı. Lütfen kontrol edip tekrar deneyin");
                    }
                }
            }      
        }
        private void buttonKodDogrula_Click(object sender, EventArgs e)
        {
            if (randomCode==textBoxKod.Text)
            {
                SifreSıfırlama form = new SifreSıfırlama();
                this.Hide();
                form.Show();
                form.labelIsım.Text = textBoxUsername.Text;
            }
            else
            {
                if (hak <= 0)
                {
                    MessageBox.Show("Yeterli deneme hakkınız kalmadı.");
                    this.Close();
                }
                else
                {
                    hak--;
                    MessageBox.Show("Doğrulama kodunu yanlış girdiniz. Lütfen kontrol edip tekrar deneyiniz. " + "\n" + (hak+1) + " Adet deneme hakkınız kaldı");
                }
            }
        }
        private void buttonCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void SifreUnuttum_Load(object sender, EventArgs e)
        {
        }
    }
}
