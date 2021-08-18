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
    public partial class UyeSil : Form
    {
        string _vtadresi = "91.151.90.171";
        string _ka = "oguzhanturan";
        string _sifre = "Ozi123456*";
        string _vt = "admin_oguzhanturan";
        public string connection;
        public UyeSil()
        {
            this.connection = $"SERVER={_vtadresi};DATABASE={_vt};UID={_ka};PWD={_sifre}";
            InitializeComponent();
            uyegetir();
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
                    if (baglan.State == ConnectionState.Closed)
                    {
                        baglan.Open();
                    }
                    MySqlDataAdapter da = new MySqlDataAdapter();
                    da.SelectCommand = cmd;
                    DataTable tablo = new DataTable();
                    da.Fill(tablo);
                    dataGridView1.DataSource = tablo;
                    tablotasarım();
                    baglan.Close();
                }
            }
        }
        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBoxSilinecekUye.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }
        private void buttonUyeSil_Click(object sender, EventArgs e)
        {
            if (textBoxSilinecekUye.Text == "1")
            {
                MessageBox.Show("Bu üyeyi silemezsiniz");
            }
            else
            {
                using (var baglan = new MySqlConnection(this.connection))
                {
                    using (var cmd = new MySqlCommand("DELETE FROM kullanicilar Where id=@id", baglan))
                    {
                        if (baglan.State == ConnectionState.Closed)
                        {
                            baglan.Open();
                        }
                        cmd.Parameters.AddWithValue("@id", Convert.ToInt32(textBoxSilinecekUye.Text));
                        cmd.ExecuteNonQuery();
                        baglan.Close();
                        uyegetir();
                        MessageBox.Show("Üye başarılı bir şekilde silindi.");
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
