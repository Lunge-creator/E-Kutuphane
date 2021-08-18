using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class SifreSıfırlama : Form
    {
        string _vtadresi = "91.151.90.171";
        string _ka = "oguzhanturan";
        string _sifre = "Ozi123456*";
        string _vt = "admin_oguzhanturan";
        public string connection;
        public SifreSıfırlama()
        {
            InitializeComponent();
            this.connection = $"SERVER={_vtadresi};DATABASE={_vt};UID={_ka};PWD={_sifre}";
            this.Opacity = 0.85;
        }
        private void buttonCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSifreSıfırla_Click(object sender, EventArgs e)
        {
            if (labelİdSıfırlama.Text == "admin")
            {
                MessageBox.Show("Bu kullanıcı Şifresi Sıfırlanamaz");
                this.Close();
            }
            else
            {
                if (textBoxSifre.Text == textBoxSifreTekrar.Text)
                {
                    if (textBoxSifre.Text.Length < 5)
                    {
                        MessageBox.Show("Şifre çok kısa");
                        textBoxSifre.Text = "";
                        textBoxSifreTekrar.Text = "";
                    }
                    else
                    {
                        using (var baglan = new MySqlConnection(this.connection))
                        {
                            using (var cmd = new MySqlCommand("UPDATE kullanicilar SET sifre=@sifre WHERE kullaniciadi=@kullaniciadi", baglan))
                            {
                                cmd.Parameters.AddWithValue("@kullaniciadi", labelIsım.Text);
                                cmd.Parameters.AddWithValue("@sifre", textBoxSifre.Text);
                                if (baglan.State == ConnectionState.Closed)
                                {
                                    baglan.Open();
                                }
                                cmd.ExecuteNonQuery();
                                baglan.Close();
                                MessageBox.Show("Şifre başarılı bir şekilde değiştirildi.");
                                this.Close();
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Girmiş olduğunuz şifreler eşleşmiyor");
                }
            }
            
        }
    }
}
