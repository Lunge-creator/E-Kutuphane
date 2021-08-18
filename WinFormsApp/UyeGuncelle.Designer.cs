
namespace WinFormsApp
{
    partial class UyeGuncelle
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
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelUyePosta = new System.Windows.Forms.Label();
            this.labelUyeSifre = new System.Windows.Forms.Label();
            this.labelUyeAdi = new System.Windows.Forms.Label();
            this.labelUyeİd = new System.Windows.Forms.Label();
            this.textBoxÜyePosta = new System.Windows.Forms.TextBox();
            this.textBoxÜyeSifre = new System.Windows.Forms.TextBox();
            this.textBoxÜyeAdi = new System.Windows.Forms.TextBox();
            this.textBoxÜyeSirasi = new System.Windows.Forms.TextBox();
            this.buttonUyeGuncelle = new System.Windows.Forms.Button();
            this.textBoxÜyeTelefon = new System.Windows.Forms.TextBox();
            this.labelÜyeTelefon = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkRed;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(648, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 25);
            this.button2.TabIndex = 6;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 183);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(644, 265);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // labelUyePosta
            // 
            this.labelUyePosta.AutoSize = true;
            this.labelUyePosta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelUyePosta.Location = new System.Drawing.Point(431, 76);
            this.labelUyePosta.Name = "labelUyePosta";
            this.labelUyePosta.Size = new System.Drawing.Size(70, 15);
            this.labelUyePosta.TabIndex = 46;
            this.labelUyePosta.Text = "Üye E-posta";
            // 
            // labelUyeSifre
            // 
            this.labelUyeSifre.AutoSize = true;
            this.labelUyeSifre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelUyeSifre.Location = new System.Drawing.Point(318, 76);
            this.labelUyeSifre.Name = "labelUyeSifre";
            this.labelUyeSifre.Size = new System.Drawing.Size(53, 15);
            this.labelUyeSifre.TabIndex = 45;
            this.labelUyeSifre.Text = "Üye Şifre";
            // 
            // labelUyeAdi
            // 
            this.labelUyeAdi.AutoSize = true;
            this.labelUyeAdi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelUyeAdi.Location = new System.Drawing.Point(211, 76);
            this.labelUyeAdi.Name = "labelUyeAdi";
            this.labelUyeAdi.Size = new System.Drawing.Size(48, 15);
            this.labelUyeAdi.TabIndex = 44;
            this.labelUyeAdi.Text = "Üye Adi";
            // 
            // labelUyeİd
            // 
            this.labelUyeİd.AutoSize = true;
            this.labelUyeİd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelUyeİd.Location = new System.Drawing.Point(90, 76);
            this.labelUyeİd.Name = "labelUyeİd";
            this.labelUyeİd.Size = new System.Drawing.Size(57, 15);
            this.labelUyeİd.TabIndex = 43;
            this.labelUyeİd.Text = "Üye Sırası";
            this.labelUyeİd.Click += new System.EventHandler(this.labelKitapAdi_Click);
            // 
            // textBoxÜyePosta
            // 
            this.textBoxÜyePosta.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBoxÜyePosta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxÜyePosta.Location = new System.Drawing.Point(420, 99);
            this.textBoxÜyePosta.Name = "textBoxÜyePosta";
            this.textBoxÜyePosta.Size = new System.Drawing.Size(100, 16);
            this.textBoxÜyePosta.TabIndex = 3;
            // 
            // textBoxÜyeSifre
            // 
            this.textBoxÜyeSifre.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBoxÜyeSifre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxÜyeSifre.Location = new System.Drawing.Point(305, 99);
            this.textBoxÜyeSifre.Name = "textBoxÜyeSifre";
            this.textBoxÜyeSifre.Size = new System.Drawing.Size(100, 16);
            this.textBoxÜyeSifre.TabIndex = 2;
            this.textBoxÜyeSifre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxÜyeAdi
            // 
            this.textBoxÜyeAdi.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBoxÜyeAdi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxÜyeAdi.Location = new System.Drawing.Point(188, 99);
            this.textBoxÜyeAdi.Name = "textBoxÜyeAdi";
            this.textBoxÜyeAdi.Size = new System.Drawing.Size(100, 16);
            this.textBoxÜyeAdi.TabIndex = 1;
            this.textBoxÜyeAdi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxÜyeSirasi
            // 
            this.textBoxÜyeSirasi.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBoxÜyeSirasi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxÜyeSirasi.Enabled = false;
            this.textBoxÜyeSirasi.Location = new System.Drawing.Point(69, 99);
            this.textBoxÜyeSirasi.Name = "textBoxÜyeSirasi";
            this.textBoxÜyeSirasi.Size = new System.Drawing.Size(100, 16);
            this.textBoxÜyeSirasi.TabIndex = 0;
            this.textBoxÜyeSirasi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonUyeGuncelle
            // 
            this.buttonUyeGuncelle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUyeGuncelle.BackColor = System.Drawing.Color.Gray;
            this.buttonUyeGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUyeGuncelle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonUyeGuncelle.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonUyeGuncelle.Location = new System.Drawing.Point(277, 147);
            this.buttonUyeGuncelle.Name = "buttonUyeGuncelle";
            this.buttonUyeGuncelle.Size = new System.Drawing.Size(120, 30);
            this.buttonUyeGuncelle.TabIndex = 5;
            this.buttonUyeGuncelle.Text = "Üye Güncelle";
            this.buttonUyeGuncelle.UseVisualStyleBackColor = false;
            this.buttonUyeGuncelle.Click += new System.EventHandler(this.buttonUyeGuncelle_Click);
            // 
            // textBoxÜyeTelefon
            // 
            this.textBoxÜyeTelefon.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBoxÜyeTelefon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxÜyeTelefon.Location = new System.Drawing.Point(536, 99);
            this.textBoxÜyeTelefon.Name = "textBoxÜyeTelefon";
            this.textBoxÜyeTelefon.Size = new System.Drawing.Size(100, 16);
            this.textBoxÜyeTelefon.TabIndex = 4;
            this.textBoxÜyeTelefon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelÜyeTelefon
            // 
            this.labelÜyeTelefon.AutoSize = true;
            this.labelÜyeTelefon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelÜyeTelefon.Location = new System.Drawing.Point(547, 76);
            this.labelÜyeTelefon.Name = "labelÜyeTelefon";
            this.labelÜyeTelefon.Size = new System.Drawing.Size(68, 15);
            this.labelÜyeTelefon.TabIndex = 47;
            this.labelÜyeTelefon.Text = "Üye Telefon";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Location = new System.Drawing.Point(69, 121);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(100, 1);
            this.panel7.TabIndex = 48;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel8.Location = new System.Drawing.Point(-100, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(100, 1);
            this.panel8.TabIndex = 32;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(188, 121);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 1);
            this.panel1.TabIndex = 34;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Location = new System.Drawing.Point(-100, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(100, 1);
            this.panel2.TabIndex = 32;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(305, 121);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(100, 1);
            this.panel3.TabIndex = 34;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel4.Location = new System.Drawing.Point(-100, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(100, 1);
            this.panel4.TabIndex = 32;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Location = new System.Drawing.Point(420, 121);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(100, 1);
            this.panel5.TabIndex = 34;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel6.Location = new System.Drawing.Point(-100, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(100, 1);
            this.panel6.TabIndex = 32;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel9.Controls.Add(this.panel10);
            this.panel9.Location = new System.Drawing.Point(536, 121);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(100, 1);
            this.panel9.TabIndex = 34;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel10.Location = new System.Drawing.Point(-100, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(100, 1);
            this.panel10.TabIndex = 32;
            // 
            // UyeGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(700, 474);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.labelÜyeTelefon);
            this.Controls.Add(this.labelUyePosta);
            this.Controls.Add(this.labelUyeSifre);
            this.Controls.Add(this.labelUyeAdi);
            this.Controls.Add(this.labelUyeİd);
            this.Controls.Add(this.textBoxÜyeTelefon);
            this.Controls.Add(this.textBoxÜyePosta);
            this.Controls.Add(this.textBoxÜyeSifre);
            this.Controls.Add(this.textBoxÜyeAdi);
            this.Controls.Add(this.textBoxÜyeSirasi);
            this.Controls.Add(this.buttonUyeGuncelle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UyeGuncelle";
            this.Text = "UyeGuncelle";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelUyePosta;
        private System.Windows.Forms.Label labelUyeSifre;
        private System.Windows.Forms.Label labelUyeAdi;
        private System.Windows.Forms.Label labelUyeİd;
        private System.Windows.Forms.TextBox textBoxÜyePosta;
        private System.Windows.Forms.TextBox textBoxÜyeSifre;
        private System.Windows.Forms.TextBox textBoxÜyeAdi;
        private System.Windows.Forms.TextBox textBoxÜyeSirasi;
        private System.Windows.Forms.Button buttonUyeGuncelle;
        private System.Windows.Forms.TextBox textBoxÜyeTelefon;
        private System.Windows.Forms.Label labelÜyeTelefon;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
    }
}