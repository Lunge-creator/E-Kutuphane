using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace WinFormsApp
{
    public partial class Registration : Form
    {
        string _vtadresi = "91.151.90.171";
        string _ka = "oguzhanturan";
        string _sifre = "Ozi123456*";
        string _vt = "admin_oguzhanturan";
        public string connection;
        public Registration()
        {
            this.connection= $"SERVER={_vtadresi};DATABASE={_vt};UID={_ka};PWD={_sifre}";
            InitializeComponent();
            this.Opacity = 0.95;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            using (var baglan = new MySqlConnection(this.connection)) {
                using (var kontrol = new MySqlCommand("Select*From kullanicilar where kullaniciadi='" + textBoxUsername.Text + "'", baglan))
                {
                    if (baglan.State == ConnectionState.Closed)
                    {
                        baglan.Open();
                    }
                    MySqlDataReader datareader2 = kontrol.ExecuteReader();
                    if (datareader2.Read())
                    {
                        MessageBox.Show("Bu kullanıcı adına sahip kullanıcı bulunmaktadır", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        baglan.Close();
                    }
                    else if (textBoxUsername.Text == "" || textBoxPassword.Text == "")
                    {
                        MessageBox.Show("Lütfen Kayıt olabilmek için kullanıcı adı ve şifre giriniz");
                        baglan.Close();
                    }
                    else if (textBoxUsername.Text == textBoxPassword.Text)
                    {
                        MessageBox.Show("Kullanıcı adı ve şifre aynı olamaz");
                        baglan.Close();
                    }
                    else
                    {
                        if (textBoxPassword.Text.Length < 5)
                        {
                            MessageBox.Show("Şifre çok kısa");
                            textBoxPassword.Text = "0";
                            baglan.Close();
                        }
                        else
                        {
                            using (var komut = new MySqlCommand("insert into kullanicilar(kullaniciadi,sifre,eposta,numara) values(@kullaniciadi,@sifre,@eposta,@numara)", baglan))
                            {
                                try
                                {
                                    baglan.Close();
                                    baglan.Open();
                                    komut.CommandType = CommandType.Text;
                                    komut.Parameters.AddWithValue("@kullaniciadi", textBoxUsername.Text.Trim());
                                    komut.Parameters.AddWithValue("@sifre", textBoxPassword.Text.Trim());
                                    komut.Parameters.AddWithValue("@eposta", textBoxeposta.Text.Trim());
                                    komut.Parameters.AddWithValue("@numara", textBoxtelno.Text.Trim());
                                    Clear();
                                    komut.ExecuteNonQuery();
                                    baglan.Close();
                                    MessageBox.Show("Kayıt olundu.Giriş yapabilirsiniz");
                                    this.Close();
                                    Clear();
                                }
                                catch (Exception hata)
                                {
                                    MessageBox.Show("Hata Mesajı:" + hata.ToString(), "Hata:" + hata.Message);
                                }
                            }
                        }
                    }
                    baglan.Close();
                }
            }
        }
        void Clear()
        {
            textBoxUsername.Text = "";
            textBoxPassword.Text = "";
            textBoxeposta.Text = "";
            textBoxtelno.Text = "0";
        }
        private void Registration_Load(object sender, EventArgs e)
        {
        }
        private void textBoxtelno_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(textBoxtelno.Text,"^[0-9]"))
            {
                textBoxtelno.Text = "";
                MessageBox.Show("Sadece rakam yazılabilir");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ıconPictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
