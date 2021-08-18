using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class KitapEkle : Form
    {
        string _vtadresi = "91.151.90.171";
        string _ka = "oguzhanturan";
        string _sifre = "Ozi123456*";
        string _vt = "admin_oguzhanturan";
        public string connection;
        public KitapEkle()
        {
            this.connection= $"SERVER={_vtadresi};DATABASE={_vt};UID={_ka};PWD={_sifre}";
            InitializeComponent();
            kitapgetir();

        }
        private void KitapEkle_Load(object sender, EventArgs e)
        {

        }
        private void buttonKitapEkle_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image==null)
            {
                MessageBox.Show("Resim seçilmedi lütfen resim seçiniz");
            }
            else
            {

                Ekle(ResimByte(pictureBox1.Image), pdfyükle(pdfOkuyucu));
                MessageBox.Show("Kitap başarıyla eklendi");
                Clear();
                pictureBox1.Image = null;
            }
            
        }
        void Clear()
        {
            textBoxKitapAdi.Text = "";
            textBoxKitapYazari.Text = "";
            textBoxKitapturu.Text = "";
            textBoxKitapYili.Text = "0";
            textBoxSayfaSayisi.Text = "0";
        }
        public void Ekle(byte[] resim,byte[] pdf)
        {
            using (var baglan = new MySqlConnection(this.connection))
            {
                using (var komut = new MySqlCommand("insert into kitaplar(kitapadi,yazaradi,kitapturu,sayfasayisi,kitapcikis,resim,pdf) " +
                "values(@kitapadi,@yazaradi,@kitapturu,@sayfasayisi,@kitapcikis,@resim,@pdf)", baglan))
                {
                    if (baglan.State == ConnectionState.Closed)
                    {
                        baglan.Open();
                    }
                    komut.CommandType = CommandType.Text;
                    komut.Parameters.AddWithValue("@kitapadi", textBoxKitapAdi.Text.Trim());
                    komut.Parameters.AddWithValue("@yazaradi", textBoxKitapYazari.Text.Trim());
                    komut.Parameters.AddWithValue("@kitapturu", textBoxKitapturu.Text.Trim());
                    komut.Parameters.AddWithValue("@sayfasayisi", textBoxSayfaSayisi.Text.Trim());
                    komut.Parameters.AddWithValue("@kitapcikis", textBoxKitapYili.Text.Trim());
                    komut.Parameters.AddWithValue("@resim", resim);
                    komut.Parameters.AddWithValue("@pdf", pdf);
                    komut.ExecuteNonQuery();
                }
            }
            kitapgetir();
        }
        byte[] ResimByte(Image resim)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                resim.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }
        private void buttonResim_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog() { Filter = "Image files(*.jpg)|*.jpg", Multiselect = false })
            {
                MessageBox.Show("Sadece jpg formatında yükleme yapabilirsin");
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(dlg.FileName);
                }
                else
                {
                    MessageBox.Show("Resim seçilmedi");
                }
            }
        }
        public string pdfOkuyucu;
        private void buttonPdf_Click(object sender, EventArgs e)
        {
            using (var baglan = new MySqlConnection(this.connection))
            {

                using (OpenFileDialog dlg = new OpenFileDialog() { Filter = "PDF Documents(*.pdf)|*.pdf", Multiselect = false })
                {
                    MessageBox.Show("Sadece pdf formatında yükleme yapabilirsin ve Dosya boyutu Max 2 mb olmalıdır");
                    if (dlg.ShowDialog() == DialogResult.OK)
                    {
                        var size = new FileInfo(dlg.FileName).Length;
                        if (size>1900000)
                        { 
                            MessageBox.Show("Seçtiğiniz dosya 2 Mb'dan fazladır");
                        }
                        else
                        {
                            string filename = dlg.FileName;
                            pdfOkuyucu = filename;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Pdf seçilmedi");
                    }
                }
            }
        }
        public byte[] pdfyükle(string file)
        {
            FileStream fstream = File.OpenRead(file);
            byte[] converts = new byte[fstream.Length];
            fstream.Read(converts, 0, (int)fstream.Length);
            return converts;
        }
        private void buttonCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void textBoxSayfaSayisi_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(textBoxSayfaSayisi.Text, "^[0-9]") )
            {
                textBoxSayfaSayisi.Text = "0";
                MessageBox.Show("Sadece rakam yazılabilir");
            }
        }
        private void kitapgetir()
        {
            using (var baglan = new MySqlConnection(this.connection))
            {
                using (var cmd = new MySqlCommand("SELECT kitapadi FROM kitaplar ORDER BY kitapadi ASC", baglan))
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
        private void tablotasarım()
        {
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Columns["kitapadi"].HeaderText = "Kitap Adı";
            dataGridView1.MouseWheel += new MouseEventHandler(mousewheel);
            dataGridView1.ScrollBars = ScrollBars.None;
        }
        private void mousewheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0 && dataGridView1.FirstDisplayedScrollingRowIndex > 0)
            {
                dataGridView1.FirstDisplayedScrollingRowIndex--;
            }
            else if (e.Delta < 0)
            {
                dataGridView1.FirstDisplayedScrollingRowIndex++;
            }
        }
        private void textBoxKitapAra_TextChanged(object sender, EventArgs e)
        {
            using (var baglan = new MySqlConnection(this.connection))
            {
                using (var cmd = new MySqlCommand("SELECT * FROM kitaplar", baglan))
                {
                    string sorgu = textBoxKitapAra.Text;
                    MySqlDataAdapter da = new MySqlDataAdapter("SELECT kitapadi FROM kitaplar WHERE kitapadi LIKE '%" + sorgu + "%'", baglan);
                    DataTable tablo = new DataTable();
                    da.Fill(tablo);
                    dataGridView1.DataSource = tablo;
                }
            }
        }
        private void textBoxKitapYili_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(textBoxKitapYili.Text, "^[0-9]"))
            {
                textBoxKitapYili.Text = "0";
                MessageBox.Show("Sadece rakam yazılabilir");
            }
        }
        private void textBoxKitapAra_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxKitapAra.Text = "";
        }
    }
}