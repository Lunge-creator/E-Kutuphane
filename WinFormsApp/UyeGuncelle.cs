using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class UyeGuncelle : Form
    {
        string _vtadresi = "91.151.90.171";
        string _ka = "oguzhanturan";
        string _sifre = "Ozi123456*";
        string _vt = "admin_oguzhanturan";
        public string connection;
        public UyeGuncelle()
        {
            this.connection = $"SERVER={_vtadresi};DATABASE={_vt};UID={_ka};PWD={_sifre}";
            InitializeComponent();
            uyegetir();
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
        private void uyegetir()
        {
            using (var baglan = new MySqlConnection(this.connection))
            {
                using (var cmd = new MySqlCommand("SELECT * FROM kullanicilar", baglan))
                {
                    baglantıac();
                    MySqlDataAdapter da = new MySqlDataAdapter();
                    da.SelectCommand = cmd;
                    DataTable tablo = new DataTable();
                    da.Fill(tablo);
                    dataGridView1.RowHeadersVisible = false;
                    dataGridView1.DataSource = tablo;
                    tablotasarım();
                    baglan.Close();
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void labelKitapAdi_Click(object sender, EventArgs e)
        {
        }
        private void buttonUyeGuncelle_Click(object sender, EventArgs e)
        {
            if (textBoxÜyeSirasi.Text=="1")
            {
                MessageBox.Show("Bu kullanıcı güncellenemez");
            }
            else
            {
                if (textBoxÜyeAdi.Text == textBoxÜyeSifre.Text)
                {
                    MessageBox.Show("Güncellenen Kullanıcın Adı ve Şifresi aynı olamaz.");
                }
                else
                {
                    using (var baglan = new MySqlConnection(this.connection))
                    {
                        using (var cmd = new MySqlCommand("UPDATE kullanicilar SET kullaniciadi=@kullaniciadi,sifre=@sifre,eposta=@eposta,numara=@numara WHERE id=@id", baglan))
                        {
                            if (baglan.State == ConnectionState.Closed)
                            {
                                baglan.Open();
                            }
                            cmd.Parameters.AddWithValue("@id", textBoxÜyeSirasi.Text);
                            cmd.Parameters.AddWithValue("@kullaniciadi", textBoxÜyeAdi.Text);
                            cmd.Parameters.AddWithValue("@sifre", textBoxÜyeSifre.Text);
                            cmd.Parameters.AddWithValue("@eposta", textBoxÜyePosta.Text);
                            cmd.Parameters.AddWithValue("@numara", textBoxÜyeTelefon.Text);
                            baglantıac();
                            cmd.ExecuteNonQuery();
                            baglan.Close();
                            uyegetir();
                            MessageBox.Show("Kullanıcı başarılı şekilde güncellendi");
                        }
                    }
                }
            }
        }
        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBoxÜyeSirasi.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBoxÜyeAdi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBoxÜyeSifre.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBoxÜyePosta.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBoxÜyeTelefon.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }
        private void tablotasarım()
        {
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Columns["id"].HeaderText = "Kullanıcı İd";
            dataGridView1.Columns["kullaniciadi"].HeaderText = "Kullanıcı Adı";
            dataGridView1.Columns["sifre"].HeaderText = "Sifre";
            dataGridView1.Columns["eposta"].HeaderText = "E-Posta";
            dataGridView1.Columns["numara"].HeaderText = "Telefon Numara";
            dataGridView1.Columns["id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
    }
}
