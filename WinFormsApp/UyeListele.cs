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
    public partial class UyeListele : Form
    {
        string _vtadresi = "91.151.90.171";
        string _ka = "oguzhanturan";
        string _sifre = "Ozi123456*";
        string _vt = "admin_oguzhanturan";
        public string connection;
        public UyeListele()
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
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void uyegetir()
        {
            using (var baglan = new MySqlConnection(this.connection))
            {
                using (var cmd = new MySqlCommand("SELECT * FROM kullanicilar", baglan))
                {
                    try
                    {
                        MySqlDataAdapter da = new MySqlDataAdapter();
                        da.SelectCommand = cmd;
                        DataTable tablo = new DataTable();
                        da.Fill(tablo);
                        dataGridView1.RowHeadersVisible = false;
                        dataGridView1.DataSource = tablo;
                        tablotasarım();
                    }
                    catch (Exception hata)
                    {
                        MessageBox.Show("Hata kodu:" + hata.ToString(), "Hata:" + hata.Message);
                    }
                }
            }
        }
        private void tablotasarım()
        {
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
