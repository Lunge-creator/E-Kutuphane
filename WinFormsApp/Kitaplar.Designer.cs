
namespace WinFormsApp
{
    partial class Kitaplar
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1Boş = new System.Windows.Forms.Label();
            this.label2Boş = new System.Windows.Forms.Label();
            this.label3Boş = new System.Windows.Forms.Label();
            this.label4Boş = new System.Windows.Forms.Label();
            this.label5Boş = new System.Windows.Forms.Label();
            this.labelKitapAdi = new System.Windows.Forms.Label();
            this.labelKitapYazari = new System.Windows.Forms.Label();
            this.labelKitapTürü = new System.Windows.Forms.Label();
            this.labelKitapSayfasi = new System.Windows.Forms.Label();
            this.labelKitapYili = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ap = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(532, 417);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkRed;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(648, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 25);
            this.button2.TabIndex = 2;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ımageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(545, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 225);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label1Boş
            // 
            this.label1Boş.AutoSize = true;
            this.label1Boş.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1Boş.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1Boş.Location = new System.Drawing.Point(541, 286);
            this.label1Boş.Name = "label1Boş";
            this.label1Boş.Size = new System.Drawing.Size(56, 13);
            this.label1Boş.TabIndex = 10;
            this.label1Boş.Text = "Kitap Adı:";
            // 
            // label2Boş
            // 
            this.label2Boş.AutoSize = true;
            this.label2Boş.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2Boş.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2Boş.Location = new System.Drawing.Point(541, 311);
            this.label2Boş.Name = "label2Boş";
            this.label2Boş.Size = new System.Drawing.Size(67, 13);
            this.label2Boş.TabIndex = 11;
            this.label2Boş.Text = "Kitap Yazarı:";
            // 
            // label3Boş
            // 
            this.label3Boş.AutoSize = true;
            this.label3Boş.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3Boş.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3Boş.Location = new System.Drawing.Point(541, 336);
            this.label3Boş.Name = "label3Boş";
            this.label3Boş.Size = new System.Drawing.Size(63, 13);
            this.label3Boş.TabIndex = 12;
            this.label3Boş.Text = "Kitap Türü:";
            // 
            // label4Boş
            // 
            this.label4Boş.AutoSize = true;
            this.label4Boş.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4Boş.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4Boş.Location = new System.Drawing.Point(541, 361);
            this.label4Boş.Name = "label4Boş";
            this.label4Boş.Size = new System.Drawing.Size(97, 13);
            this.label4Boş.TabIndex = 13;
            this.label4Boş.Text = "Kitap Sayfa Sayısı:";
            // 
            // label5Boş
            // 
            this.label5Boş.AutoSize = true;
            this.label5Boş.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5Boş.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5Boş.Location = new System.Drawing.Point(541, 386);
            this.label5Boş.Name = "label5Boş";
            this.label5Boş.Size = new System.Drawing.Size(80, 13);
            this.label5Boş.TabIndex = 14;
            this.label5Boş.Text = "Kitap Çıkış Yılı:";
            // 
            // labelKitapAdi
            // 
            this.labelKitapAdi.AutoSize = true;
            this.labelKitapAdi.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelKitapAdi.Location = new System.Drawing.Point(600, 286);
            this.labelKitapAdi.Name = "labelKitapAdi";
            this.labelKitapAdi.Size = new System.Drawing.Size(13, 13);
            this.labelKitapAdi.TabIndex = 15;
            this.labelKitapAdi.Text = "0";
            // 
            // labelKitapYazari
            // 
            this.labelKitapYazari.AutoSize = true;
            this.labelKitapYazari.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelKitapYazari.Location = new System.Drawing.Point(612, 311);
            this.labelKitapYazari.Name = "labelKitapYazari";
            this.labelKitapYazari.Size = new System.Drawing.Size(13, 13);
            this.labelKitapYazari.TabIndex = 16;
            this.labelKitapYazari.Text = "0";
            // 
            // labelKitapTürü
            // 
            this.labelKitapTürü.AutoSize = true;
            this.labelKitapTürü.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelKitapTürü.Location = new System.Drawing.Point(606, 336);
            this.labelKitapTürü.Name = "labelKitapTürü";
            this.labelKitapTürü.Size = new System.Drawing.Size(13, 13);
            this.labelKitapTürü.TabIndex = 17;
            this.labelKitapTürü.Text = "0";
            // 
            // labelKitapSayfasi
            // 
            this.labelKitapSayfasi.AutoSize = true;
            this.labelKitapSayfasi.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelKitapSayfasi.Location = new System.Drawing.Point(642, 361);
            this.labelKitapSayfasi.Name = "labelKitapSayfasi";
            this.labelKitapSayfasi.Size = new System.Drawing.Size(13, 13);
            this.labelKitapSayfasi.TabIndex = 18;
            this.labelKitapSayfasi.Text = "0";
            // 
            // labelKitapYili
            // 
            this.labelKitapYili.AutoSize = true;
            this.labelKitapYili.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelKitapYili.Location = new System.Drawing.Point(626, 386);
            this.labelKitapYili.Name = "labelKitapYili";
            this.labelKitapYili.Size = new System.Drawing.Size(13, 13);
            this.labelKitapYili.TabIndex = 19;
            this.labelKitapYili.Text = "0";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(325, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(110, 23);
            this.comboBox1.TabIndex = 20;
            this.comboBox1.Text = "İD";
            // 
            // ap
            // 
            this.ap.BackColor = System.Drawing.Color.DarkGray;
            this.ap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ap.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ap.ForeColor = System.Drawing.SystemColors.Control;
            this.ap.Location = new System.Drawing.Point(441, 12);
            this.ap.Name = "ap";
            this.ap.Size = new System.Drawing.Size(69, 23);
            this.ap.TabIndex = 21;
            this.ap.Text = "Sırala";
            this.ap.UseVisualStyleBackColor = false;
            this.ap.Click += new System.EventHandler(this.buttonKitapEkle_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(84, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 22;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Kitaplar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(700, 474);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ap);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.labelKitapYili);
            this.Controls.Add(this.labelKitapSayfasi);
            this.Controls.Add(this.labelKitapTürü);
            this.Controls.Add(this.labelKitapYazari);
            this.Controls.Add(this.labelKitapAdi);
            this.Controls.Add(this.label5Boş);
            this.Controls.Add(this.label4Boş);
            this.Controls.Add(this.label3Boş);
            this.Controls.Add(this.label2Boş);
            this.Controls.Add(this.label1Boş);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Kitaplar";
            this.Text = "Kitaplar";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1Boş;
        private System.Windows.Forms.Label label2Boş;
        private System.Windows.Forms.Label label3Boş;
        private System.Windows.Forms.Label label4Boş;
        private System.Windows.Forms.Label label5Boş;
        private System.Windows.Forms.Label labelKitapAdi;
        private System.Windows.Forms.Label labelKitapYazari;
        private System.Windows.Forms.Label labelKitapTürü;
        private System.Windows.Forms.Label labelKitapSayfasi;
        private System.Windows.Forms.Label labelKitapYili;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button ap;
        private System.Windows.Forms.TextBox textBox1;
    }
}