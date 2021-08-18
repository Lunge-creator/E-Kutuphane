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
    public partial class KitapSil : Form
    {
        string _vtadresi = "91.151.90.171";
        string _ka = "oguzhanturan";
        string _sifre = "Ozi123456*";
        string _vt = "admin_oguzhanturan";
        public string connection;

        public KitapSil()
        {
            this.connection= $"SERVER={_vtadresi};DATABASE={_vt};UID={_ka};PWD={_sifre}";
            InitializeComponent();
            kitapgetir();
        }
        private void kitapgetir()
        {
            using (var baglan = new MySqlConnection(this.connection))
            {
                using (var cmd = new MySqlCommand("SELECT id,kitapadi,yazaradi,kitapturu,sayfasayisi,kitapcikis,resim FROM kitaplar", baglan))
                {
                    if (baglan.State == ConnectionState.Closed)
                    {
                        baglan.Open();
                    }
                    DataTable tablo = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter();
                    da.SelectCommand = cmd;
                    da.Fill(tablo);
                    dataGridView1.RowHeadersVisible = false;
                    dataGridView1.DataSource = tablo;
                    tablotasarım();
                    baglan.Close();
                }
            }
        }
        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBoxSilinecekKitap.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }
        private void buttonKitapSil_Click(object sender, EventArgs e)
        {
            using (var baglan = new MySqlConnection(this.connection))
            {
                using (var cmd = new MySqlCommand("DELETE FROM kitaplar Where id=@id", baglan))
                {
                    if (baglan.State == ConnectionState.Closed)
                    {
                        baglan.Open();
                    }
                    cmd.Parameters.AddWithValue("@id", Convert.ToInt32(textBoxSilinecekKitap.Text));
                    cmd.ExecuteNonQuery();
                    baglan.Close();
                    kitapgetir();
                    MessageBox.Show("Kitap başarılı bir şekilde silindi.");
                }
            }    
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
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
            dataGridView1.Columns["id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["sayfasayisi"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["kitapcikis"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
    }
}