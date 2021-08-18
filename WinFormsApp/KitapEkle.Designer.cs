
namespace WinFormsApp
{
    partial class KitapEkle
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
            this.textBoxKitapAdi = new System.Windows.Forms.TextBox();
            this.textBoxKitapYazari = new System.Windows.Forms.TextBox();
            this.textBoxKitapturu = new System.Windows.Forms.TextBox();
            this.textBoxSayfaSayisi = new System.Windows.Forms.TextBox();
            this.textBoxKitapYili = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.labelKitapAdi = new System.Windows.Forms.Label();
            this.buttonKitapEkle = new System.Windows.Forms.Button();
            this.labelYazarAdi = new System.Windows.Forms.Label();
            this.labelKitapTuru = new System.Windows.Forms.Label();
            this.labelSayfaSayisi = new System.Windows.Forms.Label();
            this.labelCikisYili = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonResim = new System.Windows.Forms.Button();
            this.buttonPdf = new System.Windows.Forms.Button();
            this.buttonCikis = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxKitapAra = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxKitapAdi
            // 
            this.textBoxKitapAdi.BackColor = System.Drawing.Color.DimGray;
            this.textBoxKitapAdi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxKitapAdi.Location = new System.Drawing.Point(63, 331);
            this.textBoxKitapAdi.Name = "textBoxKitapAdi";
            this.textBoxKitapAdi.Size = new System.Drawing.Size(100, 16);
            this.textBoxKitapAdi.TabIndex = 0;
            this.textBoxKitapAdi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxKitapYazari
            // 
            this.textBoxKitapYazari.BackColor = System.Drawing.Color.DimGray;
            this.textBoxKitapYazari.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxKitapYazari.Location = new System.Drawing.Point(183, 331);
            this.textBoxKitapYazari.Name = "textBoxKitapYazari";
            this.textBoxKitapYazari.Size = new System.Drawing.Size(100, 16);
            this.textBoxKitapYazari.TabIndex = 1;
            this.textBoxKitapYazari.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxKitapturu
            // 
            this.textBoxKitapturu.BackColor = System.Drawing.Color.DimGray;
            this.textBoxKitapturu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxKitapturu.Location = new System.Drawing.Point(303, 331);
            this.textBoxKitapturu.Name = "textBoxKitapturu";
            this.textBoxKitapturu.Size = new System.Drawing.Size(100, 16);
            this.textBoxKitapturu.TabIndex = 2;
            this.textBoxKitapturu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxSayfaSayisi
            // 
            this.textBoxSayfaSayisi.BackColor = System.Drawing.Color.DimGray;
            this.textBoxSayfaSayisi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSayfaSayisi.Location = new System.Drawing.Point(423, 331);
            this.textBoxSayfaSayisi.Name = "textBoxSayfaSayisi";
            this.textBoxSayfaSayisi.Size = new System.Drawing.Size(100, 16);
            this.textBoxSayfaSayisi.TabIndex = 3;
            this.textBoxSayfaSayisi.Text = "0";
            this.textBoxSayfaSayisi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxSayfaSayisi.TextChanged += new System.EventHandler(this.textBoxSayfaSayisi_TextChanged);
            // 
            // textBoxKitapYili
            // 
            this.textBoxKitapYili.BackColor = System.Drawing.Color.DimGray;
            this.textBoxKitapYili.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxKitapYili.Location = new System.Drawing.Point(543, 331);
            this.textBoxKitapYili.Name = "textBoxKitapYili";
            this.textBoxKitapYili.Size = new System.Drawing.Size(100, 16);
            this.textBoxKitapYili.TabIndex = 4;
            this.textBoxKitapYili.Text = "0";
            this.textBoxKitapYili.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxKitapYili.TextChanged += new System.EventHandler(this.textBoxKitapYili_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Location = new System.Drawing.Point(63, 349);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(100, 1);
            this.panel2.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Location = new System.Drawing.Point(183, 349);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 1);
            this.panel1.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel3.Location = new System.Drawing.Point(303, 349);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(100, 1);
            this.panel3.TabIndex = 10;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel4.Location = new System.Drawing.Point(423, 349);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(100, 1);
            this.panel4.TabIndex = 10;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel5.Location = new System.Drawing.Point(543, 349);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(100, 1);
            this.panel5.TabIndex = 10;
            // 
            // labelKitapAdi
            // 
            this.labelKitapAdi.AutoSize = true;
            this.labelKitapAdi.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelKitapAdi.Location = new System.Drawing.Point(87, 300);
            this.labelKitapAdi.Name = "labelKitapAdi";
            this.labelKitapAdi.Size = new System.Drawing.Size(55, 15);
            this.labelKitapAdi.TabIndex = 12;
            this.labelKitapAdi.Text = "Kitap Adi";
            // 
            // buttonKitapEkle
            // 
            this.buttonKitapEkle.BackColor = System.Drawing.Color.DarkGray;
            this.buttonKitapEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKitapEkle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonKitapEkle.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonKitapEkle.Location = new System.Drawing.Point(303, 434);
            this.buttonKitapEkle.Name = "buttonKitapEkle";
            this.buttonKitapEkle.Size = new System.Drawing.Size(100, 30);
            this.buttonKitapEkle.TabIndex = 13;
            this.buttonKitapEkle.Text = "Kitap Ekle";
            this.buttonKitapEkle.UseVisualStyleBackColor = false;
            this.buttonKitapEkle.Click += new System.EventHandler(this.buttonKitapEkle_Click);
            // 
            // labelYazarAdi
            // 
            this.labelYazarAdi.AutoSize = true;
            this.labelYazarAdi.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelYazarAdi.Location = new System.Drawing.Point(203, 300);
            this.labelYazarAdi.Name = "labelYazarAdi";
            this.labelYazarAdi.Size = new System.Drawing.Size(55, 15);
            this.labelYazarAdi.TabIndex = 14;
            this.labelYazarAdi.Text = "Yazar Adi";
            // 
            // labelKitapTuru
            // 
            this.labelKitapTuru.AutoSize = true;
            this.labelKitapTuru.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelKitapTuru.Location = new System.Drawing.Point(321, 300);
            this.labelKitapTuru.Name = "labelKitapTuru";
            this.labelKitapTuru.Size = new System.Drawing.Size(61, 15);
            this.labelKitapTuru.TabIndex = 15;
            this.labelKitapTuru.Text = "Kitap Türü";
            // 
            // labelSayfaSayisi
            // 
            this.labelSayfaSayisi.AutoSize = true;
            this.labelSayfaSayisi.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelSayfaSayisi.Location = new System.Drawing.Point(438, 300);
            this.labelSayfaSayisi.Name = "labelSayfaSayisi";
            this.labelSayfaSayisi.Size = new System.Drawing.Size(67, 15);
            this.labelSayfaSayisi.TabIndex = 16;
            this.labelSayfaSayisi.Text = "Sayfa Sayisi";
            // 
            // labelCikisYili
            // 
            this.labelCikisYili.AutoSize = true;
            this.labelCikisYili.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelCikisYili.Location = new System.Drawing.Point(566, 300);
            this.labelCikisYili.Name = "labelCikisYili";
            this.labelCikisYili.Size = new System.Drawing.Size(51, 15);
            this.labelCikisYili.TabIndex = 17;
            this.labelCikisYili.Text = "Çıkış Yılı";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(183, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 225);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // buttonResim
            // 
            this.buttonResim.BackColor = System.Drawing.Color.DarkGray;
            this.buttonResim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonResim.Font = new System.Drawing.Font("Calibri", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonResim.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonResim.Location = new System.Drawing.Point(321, 362);
            this.buttonResim.Name = "buttonResim";
            this.buttonResim.Size = new System.Drawing.Size(66, 30);
            this.buttonResim.TabIndex = 20;
            this.buttonResim.Text = "Resim Seç";
            this.buttonResim.UseVisualStyleBackColor = false;
            this.buttonResim.Click += new System.EventHandler(this.buttonResim_Click);
            // 
            // buttonPdf
            // 
            this.buttonPdf.BackColor = System.Drawing.Color.DarkGray;
            this.buttonPdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPdf.Font = new System.Drawing.Font("Calibri", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonPdf.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonPdf.Location = new System.Drawing.Point(321, 398);
            this.buttonPdf.Name = "buttonPdf";
            this.buttonPdf.Size = new System.Drawing.Size(66, 30);
            this.buttonPdf.TabIndex = 21;
            this.buttonPdf.Text = "Pdf Seç";
            this.buttonPdf.UseVisualStyleBackColor = false;
            this.buttonPdf.Click += new System.EventHandler(this.buttonPdf_Click);
            // 
            // buttonCikis
            // 
            this.buttonCikis.BackColor = System.Drawing.Color.DarkRed;
            this.buttonCikis.FlatAppearance.BorderSize = 0;
            this.buttonCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCikis.Location = new System.Drawing.Point(648, 12);
            this.buttonCikis.Name = "buttonCikis";
            this.buttonCikis.Size = new System.Drawing.Size(40, 25);
            this.buttonCikis.TabIndex = 22;
            this.buttonCikis.Text = "X";
            this.buttonCikis.UseVisualStyleBackColor = false;
            this.buttonCikis.Click += new System.EventHandler(this.buttonCikis_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(423, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(150, 225);
            this.dataGridView1.TabIndex = 23;
            // 
            // textBoxKitapAra
            // 
            this.textBoxKitapAra.Location = new System.Drawing.Point(447, 14);
            this.textBoxKitapAra.Name = "textBoxKitapAra";
            this.textBoxKitapAra.Size = new System.Drawing.Size(100, 23);
            this.textBoxKitapAra.TabIndex = 24;
            this.textBoxKitapAra.Text = "Kitap Ara";
            this.textBoxKitapAra.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxKitapAra_MouseClick);
            this.textBoxKitapAra.TextChanged += new System.EventHandler(this.textBoxKitapAra_TextChanged);
            // 
            // KitapEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(700, 474);
            this.Controls.Add(this.textBoxKitapAra);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonCikis);
            this.Controls.Add(this.buttonPdf);
            this.Controls.Add(this.buttonResim);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelCikisYili);
            this.Controls.Add(this.labelSayfaSayisi);
            this.Controls.Add(this.labelKitapTuru);
            this.Controls.Add(this.labelYazarAdi);
            this.Controls.Add(this.buttonKitapEkle);
            this.Controls.Add(this.labelKitapAdi);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.textBoxKitapYili);
            this.Controls.Add(this.textBoxSayfaSayisi);
            this.Controls.Add(this.textBoxKitapturu);
            this.Controls.Add(this.textBoxKitapYazari);
            this.Controls.Add(this.textBoxKitapAdi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KitapEkle";
            this.Text = "KitapEkle";
            this.Load += new System.EventHandler(this.KitapEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxKitapAdi;
        private System.Windows.Forms.TextBox textBoxKitapYazari;
        private System.Windows.Forms.TextBox textBoxKitapturu;
        private System.Windows.Forms.TextBox textBoxSayfaSayisi;
        private System.Windows.Forms.TextBox textBoxKitapYili;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label labelKitapAdi;
        private System.Windows.Forms.Button buttonKitapEkle;
        private System.Windows.Forms.Label labelYazarAdi;
        private System.Windows.Forms.Label labelKitapTuru;
        private System.Windows.Forms.Label labelSayfaSayisi;
        private System.Windows.Forms.Label labelCikisYili;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonResim;
        private System.Windows.Forms.Button buttonPdf;
        private System.Windows.Forms.Button buttonCikis;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxKitapAra;
    }
}