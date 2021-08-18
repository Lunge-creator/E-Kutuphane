using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;
using MySql.Data.MySqlClient;

namespace WinFormsApp
{
    public partial class Kitaplar : Form
    {
        string _vtadresi = "91.151.90.171";
        string _ka = "oguzhanturan";
        string _sifre = "Ozi123456*";
        string _vt = "admin_oguzhanturan";
        public string connection;
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
        public Kitaplar()
        {
            this.connection=  $"SERVER={_vtadresi};DATABASE={_vt};UID={_ka};PWD={_sifre}";
            InitializeComponent();
            kitapgetir();
            comboBox1.Items.Add("Kitap Adı");
            comboBox1.Items.Add("Yazar Adı");
            comboBox1.Items.Add("Kitap Türü");
            comboBox1.Items.Add("Kitap Sayfa Sayısı");
            comboBox1.Items.Add("Kitap Çıkış Yılı");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void kitapgetir()
        {
            using (var baglan = new MySqlConnection(this.connection))
            {
                using (var cmd = new MySqlCommand("SELECT id,kitapadi,yazaradi,kitapturu,sayfasayisi,kitapcikis,resim FROM kitaplar", baglan))
                {
                    try
                    {
                        baglantıac();
                        MySqlDataAdapter da = new MySqlDataAdapter();
                        da.SelectCommand = cmd;
                        DataTable tablo = new DataTable();
                        da.Fill(tablo);
                        dataGridView1.DataSource = tablo;
                        tablotasarım();
                    }
                    catch (Exception hata)
                    {
                        MessageBox.Show("Bağlantı yapılamadı Hata kodu:" + hata.ToString(), "Hata:" + hata.Message); 
                    }
                }
            }
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dt = dataGridView1.DataSource as DataTable;
            if (dt != null)
            {
                DataRow row = dt.Rows[e.RowIndex];
                pictureBox1.Image = ByteResim((byte[])row["resim"]);
                labelKitapAdi.Text = (string)row["kitapadi"];
                labelKitapYazari.Text = (string)row["yazaradi"];
                labelKitapTürü.Text = (string)row["kitapturu"];
                //sebebibi bilmediğim birşeyden ötürü int değeri labela yazarken (string) yerine tostring kullanmak zorunda kaldım hata veriyor
                labelKitapSayfasi.Text = row["sayfasayisi"].ToString();
                labelKitapYili.Text = row["kitapcikis"].ToString();
            }
        }
        public Image ByteResim(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }
        }

        private void buttonKitapEkle_Click(object sender, EventArgs e)
        {
            using (var baglan = new MySqlConnection(this.connection))
            {
                using (var cmd = new MySqlCommand("SELECT * FROM kitaplar", baglan))
                {

                    if (comboBox1.SelectedItem == "Kitap Adı")
                    {
                        MySqlDataAdapter da = new MySqlDataAdapter("SELECT id,kitapadi,yazaradi,kitapturu,sayfasayisi,kitapcikis,resim FROM kitaplar ORDER BY kitapadi ASC", baglan);
                        DataTable tablo = new DataTable();
                        da.Fill(tablo);
                        dataGridView1.DataSource = tablo;
                        baglan.Close();
                    }
                    else if (comboBox1.SelectedItem == "Yazar Adı")
                    {
                        MySqlDataAdapter da = new MySqlDataAdapter("SELECT id,kitapadi,yazaradi,kitapturu,sayfasayisi,kitapcikis,resim FROM kitaplar ORDER BY yazaradi ASC", baglan);
                        DataTable tablo = new DataTable();
                        da.Fill(tablo);
                        dataGridView1.DataSource = tablo;
                        baglan.Close();
                    }
                    else if (comboBox1.SelectedItem == "Kitap Türü")
                    {
                        MySqlDataAdapter da = new MySqlDataAdapter("SELECT id,kitapadi,yazaradi,kitapturu,sayfasayisi,kitapcikis,resim FROM kitaplar ORDER BY kitapturu ASC", baglan);
                        DataTable tablo = new DataTable();
                        da.Fill(tablo);
                        dataGridView1.DataSource = tablo;
                        baglan.Close();
                    }
                    else if (comboBox1.SelectedItem == "Kitap Sayfa Sayısı")
                    {
                        MySqlDataAdapter da = new MySqlDataAdapter("SELECT id,kitapadi,yazaradi,kitapturu,sayfasayisi,kitapcikis,resim FROM kitaplar ORDER BY sayfasayisi ASC", baglan);
                        DataTable tablo = new DataTable();
                        da.Fill(tablo);
                        dataGridView1.DataSource = tablo;
                        baglan.Close();
                    }
                    else if (comboBox1.SelectedItem == "Kitap Çıkış Yılı")
                    {
                        MySqlDataAdapter da = new MySqlDataAdapter("SELECT id,kitapadi,yazaradi,kitapturu,sayfasayisi,kitapcikis,resim FROM kitaplar ORDER BY kitapcikis ASC", baglan);
                        DataTable tablo = new DataTable();
                        da.Fill(tablo);
                        dataGridView1.DataSource = tablo;
                        baglan.Close();
                    }
                }
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            using (var baglan = new MySqlConnection(this.connection))
            {
                using (var cmd = new MySqlCommand("SELECT * FROM kitaplar", baglan))
                {
                    string sorgu = textBox1.Text;
                    MySqlDataAdapter da = new MySqlDataAdapter("SELECT id,kitapadi,yazaradi,kitapturu,sayfasayisi,kitapcikis,resim FROM kitaplar WHERE kitapadi LIKE '%" + sorgu + "%'", baglan);
                    DataTable tablo = new DataTable();
                    da.Fill(tablo);
                    dataGridView1.DataSource = tablo;
                }
            }
        }
        private void tablotasarım()
        {
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Columns["id"].HeaderText = "Kitap İd";
            dataGridView1.Columns["kitapadi"].HeaderText = "Kitap Adı";
            dataGridView1.Columns["yazaradi"].HeaderText = "Yazar Adı";
            dataGridView1.Columns["kitapturu"].HeaderText = "Türü";
            dataGridView1.Columns["sayfasayisi"].HeaderText = "Sayfa Sayısı";
            dataGridView1.Columns["kitapcikis"].HeaderText = "Çıkış Yılı";
            dataGridView1.Columns["resim"].HeaderText = "Resim";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridView1.Columns["id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["sayfasayisi"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["kitapcikis"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
    }
}
