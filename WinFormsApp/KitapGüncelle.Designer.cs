
namespace WinFormsApp
{
    partial class KitapGüncelle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonKitapGuncelle = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.labelCikisYili = new System.Windows.Forms.Label();
            this.labelSayfaSayisi = new System.Windows.Forms.Label();
            this.labelKitapTuru = new System.Windows.Forms.Label();
            this.labelYazarAdi = new System.Windows.Forms.Label();
            this.labelKitapAdi = new System.Windows.Forms.Label();
            this.textBoxKitapYili = new System.Windows.Forms.TextBox();
            this.textBoxSayfaSayisi = new System.Windows.Forms.TextBox();
            this.textBoxKitapturu = new System.Windows.Forms.TextBox();
            this.textBoxKitapYazari = new System.Windows.Forms.TextBox();
            this.textBoxKitapAdi = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.labelKitapSirasi = new System.Windows.Forms.Label();
            this.textBoxİd = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.buttonResimDegistir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonPdfDegistir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 220);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(607, 396);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // buttonKitapGuncelle
            // 
            this.buttonKitapGuncelle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonKitapGuncelle.BackColor = System.Drawing.Color.Gray;
            this.buttonKitapGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKitapGuncelle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonKitapGuncelle.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonKitapGuncelle.Location = new System.Drawing.Point(255, 172);
            this.buttonKitapGuncelle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonKitapGuncelle.Name = "buttonKitapGuncelle";
            this.buttonKitapGuncelle.Size = new System.Drawing.Size(137, 40);
            this.buttonKitapGuncelle.TabIndex = 7;
            this.buttonKitapGuncelle.Text = "Kitap Güncelle";
            this.buttonKitapGuncelle.UseVisualStyleBackColor = false;
            this.buttonKitapGuncelle.Click += new System.EventHandler(this.buttonKitapGuncelle_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkRed;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(741, 16);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(46, 33);
            this.button2.TabIndex = 20;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelCikisYili
            // 
            this.labelCikisYili.AutoSize = true;
            this.labelCikisYili.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelCikisYili.Location = new System.Drawing.Point(704, 67);
            this.labelCikisYili.Name = "labelCikisYili";
            this.labelCikisYili.Size = new System.Drawing.Size(63, 20);
            this.labelCikisYili.TabIndex = 30;
            this.labelCikisYili.Text = "Çıkış Yılı";
            // 
            // labelSayfaSayisi
            // 
            this.labelSayfaSayisi.AutoSize = true;
            this.labelSayfaSayisi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelSayfaSayisi.Location = new System.Drawing.Point(560, 67);
            this.labelSayfaSayisi.Name = "labelSayfaSayisi";
            this.labelSayfaSayisi.Size = new System.Drawing.Size(86, 20);
            this.labelSayfaSayisi.TabIndex = 29;
            this.labelSayfaSayisi.Text = "Sayfa Sayisi";
            // 
            // labelKitapTuru
            // 
            this.labelKitapTuru.AutoSize = true;
            this.labelKitapTuru.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelKitapTuru.Location = new System.Drawing.Point(429, 67);
            this.labelKitapTuru.Name = "labelKitapTuru";
            this.labelKitapTuru.Size = new System.Drawing.Size(77, 20);
            this.labelKitapTuru.TabIndex = 28;
            this.labelKitapTuru.Text = "Kitap Türü";
            // 
            // labelYazarAdi
            // 
            this.labelYazarAdi.AutoSize = true;
            this.labelYazarAdi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelYazarAdi.Location = new System.Drawing.Point(301, 67);
            this.labelYazarAdi.Name = "labelYazarAdi";
            this.labelYazarAdi.Size = new System.Drawing.Size(71, 20);
            this.labelYazarAdi.TabIndex = 27;
            this.labelYazarAdi.Text = "Yazar Adi";
            // 
            // labelKitapAdi
            // 
            this.labelKitapAdi.AutoSize = true;
            this.labelKitapAdi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelKitapAdi.Location = new System.Drawing.Point(167, 67);
            this.labelKitapAdi.Name = "labelKitapAdi";
            this.labelKitapAdi.Size = new System.Drawing.Size(71, 20);
            this.labelKitapAdi.TabIndex = 26;
            this.labelKitapAdi.Text = "Kitap Adi";
            // 
            // textBoxKitapYili
            // 
            this.textBoxKitapYili.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBoxKitapYili.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxKitapYili.Location = new System.Drawing.Point(675, 93);
            this.textBoxKitapYili.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxKitapYili.Name = "textBoxKitapYili";
            this.textBoxKitapYili.Size = new System.Drawing.Size(114, 20);
            this.textBoxKitapYili.TabIndex = 6;
            this.textBoxKitapYili.Text = "0";
            this.textBoxKitapYili.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxKitapYili.TextChanged += new System.EventHandler(this.textBoxKitapYili_TextChanged);
            // 
            // textBoxSayfaSayisi
            // 
            this.textBoxSayfaSayisi.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBoxSayfaSayisi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSayfaSayisi.Location = new System.Drawing.Point(543, 93);
            this.textBoxSayfaSayisi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxSayfaSayisi.Name = "textBoxSayfaSayisi";
            this.textBoxSayfaSayisi.Size = new System.Drawing.Size(114, 20);
            this.textBoxSayfaSayisi.TabIndex = 5;
            this.textBoxSayfaSayisi.Text = "0";
            this.textBoxSayfaSayisi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxSayfaSayisi.TextChanged += new System.EventHandler(this.textBoxSayfaSayisi_TextChanged);
            // 
            // textBoxKitapturu
            // 
            this.textBoxKitapturu.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBoxKitapturu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxKitapturu.Location = new System.Drawing.Point(411, 93);
            this.textBoxKitapturu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxKitapturu.Name = "textBoxKitapturu";
            this.textBoxKitapturu.Size = new System.Drawing.Size(114, 20);
            this.textBoxKitapturu.TabIndex = 4;
            this.textBoxKitapturu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxKitapYazari
            // 
            this.textBoxKitapYazari.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBoxKitapYazari.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxKitapYazari.Location = new System.Drawing.Point(278, 93);
            this.textBoxKitapYazari.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxKitapYazari.Name = "textBoxKitapYazari";
            this.textBoxKitapYazari.Size = new System.Drawing.Size(114, 20);
            this.textBoxKitapYazari.TabIndex = 3;
            this.textBoxKitapYazari.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxKitapAdi
            // 
            this.textBoxKitapAdi.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBoxKitapAdi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxKitapAdi.Location = new System.Drawing.Point(142, 93);
            this.textBoxKitapAdi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxKitapAdi.Name = "textBoxKitapAdi";
            this.textBoxKitapAdi.Size = new System.Drawing.Size(114, 20);
            this.textBoxKitapAdi.TabIndex = 2;
            this.textBoxKitapAdi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Location = new System.Drawing.Point(142, 115);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(114, 1);
            this.panel2.TabIndex = 31;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel6.Location = new System.Drawing.Point(-114, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(114, 1);
            this.panel6.TabIndex = 32;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Location = new System.Drawing.Point(278, 115);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(114, 1);
            this.panel1.TabIndex = 32;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel3.Location = new System.Drawing.Point(411, 115);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(114, 1);
            this.panel3.TabIndex = 33;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel4.Location = new System.Drawing.Point(543, 115);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(114, 1);
            this.panel4.TabIndex = 34;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel5.Location = new System.Drawing.Point(675, 115);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(114, 1);
            this.panel5.TabIndex = 34;
            // 
            // labelKitapSirasi
            // 
            this.labelKitapSirasi.AutoSize = true;
            this.labelKitapSirasi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelKitapSirasi.Location = new System.Drawing.Point(34, 67);
            this.labelKitapSirasi.Name = "labelKitapSirasi";
            this.labelKitapSirasi.Size = new System.Drawing.Size(83, 20);
            this.labelKitapSirasi.TabIndex = 35;
            this.labelKitapSirasi.Text = "Kitap Sırası";
            // 
            // textBoxİd
            // 
            this.textBoxİd.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBoxİd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxİd.Enabled = false;
            this.textBoxİd.Location = new System.Drawing.Point(10, 93);
            this.textBoxİd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxİd.Name = "textBoxİd";
            this.textBoxİd.Size = new System.Drawing.Size(114, 20);
            this.textBoxİd.TabIndex = 1;
            this.textBoxİd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Location = new System.Drawing.Point(10, 115);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(114, 1);
            this.panel7.TabIndex = 33;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel8.Location = new System.Drawing.Point(-114, 0);
            this.panel8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(114, 1);
            this.panel8.TabIndex = 32;
            // 
            // buttonResimDegistir
            // 
            this.buttonResimDegistir.BackColor = System.Drawing.Color.DarkGray;
            this.buttonResimDegistir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonResimDegistir.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonResimDegistir.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonResimDegistir.Location = new System.Drawing.Point(646, 220);
            this.buttonResimDegistir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonResimDegistir.Name = "buttonResimDegistir";
            this.buttonResimDegistir.Size = new System.Drawing.Size(117, 40);
            this.buttonResimDegistir.TabIndex = 36;
            this.buttonResimDegistir.Text = "Resim Değiştir";
            this.buttonResimDegistir.UseVisualStyleBackColor = false;
            this.buttonResimDegistir.Click += new System.EventHandler(this.buttonResim_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(624, 268);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 225);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // buttonPdfDegistir
            // 
            this.buttonPdfDegistir.BackColor = System.Drawing.Color.DarkGray;
            this.buttonPdfDegistir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPdfDegistir.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonPdfDegistir.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonPdfDegistir.Location = new System.Drawing.Point(646, 576);
            this.buttonPdfDegistir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonPdfDegistir.Name = "buttonPdfDegistir";
            this.buttonPdfDegistir.Size = new System.Drawing.Size(117, 40);
            this.buttonPdfDegistir.TabIndex = 38;
            this.buttonPdfDegistir.Text = "Pdf Değiştir";
            this.buttonPdfDegistir.UseVisualStyleBackColor = false;
            this.buttonPdfDegistir.Click += new System.EventHandler(this.buttonPdfDegistir_Click);
            // 
            // KitapGüncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 632);
            this.Controls.Add(this.buttonPdfDegistir);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonResimDegistir);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.textBoxİd);
            this.Controls.Add(this.labelKitapSirasi);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.labelCikisYili);
            this.Controls.Add(this.labelSayfaSayisi);
            this.Controls.Add(this.labelKitapTuru);
            this.Controls.Add(this.labelYazarAdi);
            this.Controls.Add(this.labelKitapAdi);
            this.Controls.Add(this.textBoxKitapYili);
            this.Controls.Add(this.textBoxSayfaSayisi);
            this.Controls.Add(this.textBoxKitapturu);
            this.Controls.Add(this.textBoxKitapYazari);
            this.Controls.Add(this.textBoxKitapAdi);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonKitapGuncelle);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "KitapGüncelle";
            this.Text = "KitapGüncelle";
            this.Load += new System.EventHandler(this.KitapGüncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonKitapGuncelle;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labelCikisYili;
        private System.Windows.Forms.Label labelSayfaSayisi;
        private System.Windows.Forms.Label labelKitapTuru;
        private System.Windows.Forms.Label labelYazarAdi;
        private System.Windows.Forms.Label labelKitapAdi;
        private System.Windows.Forms.TextBox textBoxKitapYili;
        private System.Windows.Forms.TextBox textBoxSayfaSayisi;
        private System.Windows.Forms.TextBox textBoxKitapturu;
        private System.Windows.Forms.TextBox textBoxKitapYazari;
        private System.Windows.Forms.TextBox textBoxKitapAdi;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label labelKitapSirasi;
        private System.Windows.Forms.TextBox textBoxİd;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button buttonResimDegistir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonPdfDegistir;
    }
}