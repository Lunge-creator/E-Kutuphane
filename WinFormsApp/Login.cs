using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Diagnostics;
using MySql.Data.MySqlClient;

namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        string _vtadresi = "91.151.90.171";
        string _ka = "oguzhanturan";
        string _sifre = "Ozi123456*";
        string _vt = "admin_oguzhanturan";
        public string connection;
        public Form1()
        {
            this.connection= $"SERVER={_vtadresi};DATABASE={_vt};UID={_ka};PWD={_sifre}";
            InitializeComponent();
            this.Opacity = 0.85;
        }
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            using (var baglan = new MySqlConnection(this.connection))
            {
                using (var komut = new MySqlCommand("Select*From kullanicilar where kullaniciadi='" + textBoxUsername.Text + "'And sifre='" + 
                   textBoxPassword.Text + "'", baglan))
                {
                    if (baglan.State == ConnectionState.Closed)
                    {
                        baglan.Open();
                    }
                    MySqlDataReader datareader = komut.ExecuteReader();
                    if (datareader.Read())
                    {
                        try
                        {
                            MessageBox.Show("Giriş Başarılı", "Congrates", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            Main form = new Main();
                            form.labelKullaniciAdi.Text = textBoxUsername.Text;
                            form.Show();
                            if (textBoxUsername.Text == "admin")
                            {
                                form.ButtonKitapİslem.Visible = true;
                                form.buttonUyeİslemleri.Visible = true;
                            }
                            else
                            {
                                form.ButtonKitapİslem.Visible = false;
                                form.buttonUyeİslemleri.Visible = false;
                            }
                        }
                        catch (Exception hata)
                        {
                            MessageBox.Show("Hata Mesajı:" + hata.ToString(), "Hata:" + hata.Message);
                        }
                    }
                    else
                    {
                        using (var kontrol = new MySqlCommand("Select*From kullanicilar where kullaniciadi='" + textBoxUsername.Text + "'", baglan))
                        {
                            datareader.Close();
                            MySqlDataReader datareader2 = kontrol.ExecuteReader();
                            if (datareader2.Read())
                            {
                                MessageBox.Show("Kullanıcı adınız veya şifreniz yanlış", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                MessageBox.Show("Bu isme sahip kayıtlı kullanıcı bulunmamaktadır", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    baglan.Close();
                    Clear();
                }
            }
        }
        private void buttonKayıtOl_Click(object sender, EventArgs e)
        {
            Registration kayıtOlma = new Registration();
            kayıtOlma.ShowDialog();
        }
        void Clear() {
            textBoxUsername.Text = "";
            textBoxPassword.Text = "";
        }
        private void ıconButton1_Click(object sender, EventArgs e)
        {
            Process myProcess = new Process();
            try
            {
                myProcess.StartInfo.UseShellExecute = true;
                myProcess.StartInfo.FileName = "https://github.com/Lunge-creator";
                myProcess.Start();
            }
            catch (Exception hata)
            {
                Console.WriteLine(hata.Message);
            }
        }
        private void ıconButton3_Click(object sender, EventArgs e)
        {
            Process myProcess = new Process();
            try
            {
                myProcess.StartInfo.UseShellExecute = true;
                myProcess.StartInfo.FileName = "https://steamcommunity.com/id/porsin/";
                myProcess.Start();
            }
            catch (Exception hata)
            {
                Console.WriteLine(hata.Message);
            }
        }
        private void buttonZiyaretçi_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ziyaretçi olarak giriş yapar iseniz kitap okuma işlemi gerçekleştiremesiniz");
            Main form = new Main();
            form.labelKullaniciAdi.Text = "Ziyaretçi";
            this.Hide();
            form.Show();
            form.ButtonKitapİslem.Visible = false;
            form.buttonUyeİslemleri.Visible = false;
            form.buttonKitapOku.Visible = false;
        }
        private void buttonCikis_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
        private void ıconButton2_Click(object sender, EventArgs e)
        {
            Process myProcess = new Process();
            try
            {
                myProcess.StartInfo.UseShellExecute = true;
                myProcess.StartInfo.FileName = "https://www.instagram.com/og.zhanturan/";
                myProcess.Start();
            }
            catch (Exception hata)
            {
                Console.WriteLine(hata.Message);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SifreUnuttum sifremiUnuttum = new SifreUnuttum();
            sifremiUnuttum.ShowDialog();
        }
    }
}
