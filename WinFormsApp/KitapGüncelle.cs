using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class KitapGüncelle : Form
    {
        string _vtadresi = "91.151.90.171";
        string _ka = "oguzhanturan";
        string _sifre = "Ozi123456*";
        string _vt = "admin_oguzhanturan";
        public string connection; 

        public KitapGüncelle()
        {
            this.connection = $"SERVER={_vtadresi};DATABASE={_vt};UID={_ka};PWD={_sifre}";
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
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridView1.Columns["id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["sayfasayisi"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["kitapcikis"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
        private void buttonKitapGuncelle_Click(object sender, EventArgs e)
        {
            using (var baglan = new MySqlConnection(this.connection))
            {
                using (var cmd = new MySqlCommand("UPDATE kitaplar SET kitapadi=@kitapadi,yazaradi=@yazaradi,kitapturu=@kitapturu,sayfasayisi=@sayfasayisi,kitapcikis=@kitapcikis,resim=@resim WHERE id=@id", baglan))
                {
                    if (baglan.State == ConnectionState.Closed)
                    {
                        baglan.Open();
                    }
                    cmd.Parameters.AddWithValue("@id", textBoxİd.Text);
                    cmd.Parameters.AddWithValue("@kitapadi", textBoxKitapAdi.Text);
                    cmd.Parameters.AddWithValue("@yazaradi", textBoxKitapYazari.Text);
                    cmd.Parameters.AddWithValue("@kitapturu", textBoxKitapturu.Text);
                    cmd.Parameters.AddWithValue("@sayfasayisi", Convert.ToInt32(textBoxSayfaSayisi.Text));
                    cmd.Parameters.AddWithValue("@kitapcikis", Convert.ToInt32(textBoxKitapYili.Text));
                    cmd.Parameters.AddWithValue("@resim", ResimByte(pictureBox1.Image));
                    cmd.ExecuteNonQuery();
                    baglan.Close();
                    kitapgetir();
                    MessageBox.Show("Kitap başarılı şekilde güncellendi");
                }
            }
        }
        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dt = dataGridView1.DataSource as DataTable;
            DataRow row = dt.Rows[e.RowIndex];
            pictureBox1.Image = ByteResim((byte[])row["resim"]);
            textBoxİd.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBoxKitapAdi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBoxKitapYazari.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBoxKitapturu.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBoxSayfaSayisi.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBoxKitapYili.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }
        private void KitapGüncelle_Load(object sender, EventArgs e)
        {
        }
        private void buttonResim_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Image files(*.jpg)|*.jpg", Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(ofd.FileName);
                }
                else
                {
                    MessageBox.Show("Resim seçilemedi.");
                }
            }
        }
        byte[] ResimByte(Image resim)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                resim.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }
        public Image ByteResim(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }
        }
        private void textBoxSayfaSayisi_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(textBoxSayfaSayisi.Text, "^[0-9]"))
            {
                textBoxSayfaSayisi.Text = "0";
                MessageBox.Show("Sadece rakam yazılabilir");
            }
        }
        private void buttonPdfDegistir_Click(object sender, EventArgs e)
        {
            using (var baglan = new MySqlConnection(this.connection))
            {
                using (OpenFileDialog dlg = new OpenFileDialog() { Filter = "PDF Documents(*.pdf)|*.pdf", Multiselect = false })
                {
                    MessageBox.Show("Sadece pdf formatında yükleme yapabilirsin ve Dosya boyutu Max 2 mb olmalıdır");
                    if (dlg.ShowDialog() == DialogResult.OK)
                    {
                        string filename = dlg.FileName;
                        FileStream fstream = File.OpenRead(filename);
                        byte[] converts = new byte[fstream.Length];
                        fstream.Read(converts, 0, (int)fstream.Length);
                        using (var komut = new MySqlCommand("UPDATE kitaplar SET pdf = @pdf WHERE id = @id", baglan))
                        {
                            baglan.Open();
                            komut.CommandType = CommandType.Text;
                            komut.Parameters.AddWithValue("@id", textBoxİd.Text);
                            komut.Parameters.AddWithValue("@pdf", converts);
                            komut.ExecuteNonQuery();
                        }
                        MessageBox.Show("Pdf başarıyla güncellendi");
                    }
                    else
                    {
                        MessageBox.Show("Pdf seçilmedi");
                    }
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
    }
}
