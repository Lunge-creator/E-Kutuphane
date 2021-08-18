using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;


namespace WinFormsApp
{
    public partial class KitapOku : Form
    {
        string _vtadresi = "91.151.90.171";
        string _ka = "oguzhanturan";
        string _sifre = "Ozi123456*";
        string _vt = "admin_oguzhanturan";
        public string connection;
        public string kitapadi;
        public KitapOku()
        {
            this.connection= $"SERVER={_vtadresi};DATABASE={_vt};UID={_ka};PWD={_sifre}";
            InitializeComponent();
            kitapgetir();
        }
        private void buttonİndir_Click(object sender, EventArgs e)
        {
            using (var baglan = new MySqlConnection(this.connection))
            {
                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "PDF Documents(*.pdf)|*.pdf", ValidateNames = true })
                {
                    sfd.FileName = kitapadi;
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {   
                        string filename = sfd.FileName;
                        Indir(filename);
                    }
                    else
                    {
                        MessageBox.Show("İndirme işlemi iptal edildi");
                    }
                }
            }
        }
        public void Indir(string file) 
        {
            bool em = false;
            string connection = $"SERVER={_vtadresi};DATABASE={_vt};UID={_ka};PWD={_sifre}";
            using (var baglan = new MySqlConnection(this.connection))
            {
                using (MySqlCommand cmd = new MySqlCommand("Select pdf from kitaplar where id='" + textBox1.Text + "'", baglan))
                {
                    if (baglan.State == ConnectionState.Closed)
                    {
                        baglan.Open();
                    }
                    using (MySqlDataReader dr = cmd.ExecuteReader(CommandBehavior.Default))
                    {
                        if (dr.Read())
                        {
                            em = true;
                            byte[] filedata = (byte[])dr.GetValue(0);
                            using (FileStream fs = new FileStream(file,FileMode.Create,FileAccess.ReadWrite))
                            {
                                using (BinaryWriter bw =new BinaryWriter(fs))
                                {
                                    bw.Write(filedata);
                                    bw.Close();
                                }
                            }
                            MessageBox.Show("Pdf başarılı bir şekilde indirildi");
                        }
                        if (em==false)
                        {
                            MessageBox.Show("Bu kitap bir pdf'ye sahip değil");
                        }
                        dr.Close();
                    }
                }
            }
        }
        private void kitapgetir()
        {
            using (var baglan = new MySqlConnection(this.connection))
            {
                using (var cmd = new MySqlCommand("SELECT id,kitapadi,yazaradi,kitapturu,sayfasayisi,kitapcikis,resim FROM kitaplar", baglan))
                {
                    try
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
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            kitapadi = dataGridView1.CurrentRow.Cells[1].Value.ToString();
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
