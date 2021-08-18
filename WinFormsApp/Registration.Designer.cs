
namespace WinFormsApp
{
    partial class Registration
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
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonKayitOl = new System.Windows.Forms.Button();
            this.textBoxeposta = new System.Windows.Forms.TextBox();
            this.textBoxtelno = new System.Windows.Forms.TextBox();
            this.labelKullaniciAdi = new System.Windows.Forms.Label();
            this.labelSifre = new System.Windows.Forms.Label();
            this.labelEposta = new System.Windows.Forms.Label();
            this.labelTelefon = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.ıconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.ıconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.ıconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            this.ıconPictureBox4 = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.BackColor = System.Drawing.Color.Black;
            this.textBoxUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUsername.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxUsername.Location = new System.Drawing.Point(74, 93);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(100, 16);
            this.textBoxUsername.TabIndex = 0;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.Color.Black;
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPassword.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxPassword.Location = new System.Drawing.Point(73, 141);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(100, 16);
            this.textBoxPassword.TabIndex = 1;
            // 
            // buttonKayitOl
            // 
            this.buttonKayitOl.BackColor = System.Drawing.Color.DarkGray;
            this.buttonKayitOl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKayitOl.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonKayitOl.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonKayitOl.Location = new System.Drawing.Point(105, 273);
            this.buttonKayitOl.Name = "buttonKayitOl";
            this.buttonKayitOl.Size = new System.Drawing.Size(83, 30);
            this.buttonKayitOl.TabIndex = 4;
            this.buttonKayitOl.Text = "Kayit Ol";
            this.buttonKayitOl.UseVisualStyleBackColor = false;
            this.buttonKayitOl.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxeposta
            // 
            this.textBoxeposta.BackColor = System.Drawing.Color.Black;
            this.textBoxeposta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxeposta.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxeposta.Location = new System.Drawing.Point(74, 185);
            this.textBoxeposta.Name = "textBoxeposta";
            this.textBoxeposta.Size = new System.Drawing.Size(100, 16);
            this.textBoxeposta.TabIndex = 2;
            // 
            // textBoxtelno
            // 
            this.textBoxtelno.BackColor = System.Drawing.Color.Black;
            this.textBoxtelno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxtelno.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxtelno.Location = new System.Drawing.Point(74, 233);
            this.textBoxtelno.Name = "textBoxtelno";
            this.textBoxtelno.Size = new System.Drawing.Size(100, 16);
            this.textBoxtelno.TabIndex = 3;
            this.textBoxtelno.TextChanged += new System.EventHandler(this.textBoxtelno_TextChanged);
            // 
            // labelKullaniciAdi
            // 
            this.labelKullaniciAdi.AutoSize = true;
            this.labelKullaniciAdi.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelKullaniciAdi.Location = new System.Drawing.Point(105, 75);
            this.labelKullaniciAdi.Name = "labelKullaniciAdi";
            this.labelKullaniciAdi.Size = new System.Drawing.Size(73, 15);
            this.labelKullaniciAdi.TabIndex = 5;
            this.labelKullaniciAdi.Text = "Kullanıcı Adı";
            // 
            // labelSifre
            // 
            this.labelSifre.AutoSize = true;
            this.labelSifre.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelSifre.Location = new System.Drawing.Point(126, 123);
            this.labelSifre.Name = "labelSifre";
            this.labelSifre.Size = new System.Drawing.Size(30, 15);
            this.labelSifre.TabIndex = 6;
            this.labelSifre.Text = "Şifre";
            // 
            // labelEposta
            // 
            this.labelEposta.AutoSize = true;
            this.labelEposta.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelEposta.Location = new System.Drawing.Point(118, 167);
            this.labelEposta.Name = "labelEposta";
            this.labelEposta.Size = new System.Drawing.Size(47, 15);
            this.labelEposta.TabIndex = 7;
            this.labelEposta.Text = "E-posta";
            // 
            // labelTelefon
            // 
            this.labelTelefon.AutoSize = true;
            this.labelTelefon.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelTelefon.Location = new System.Drawing.Point(119, 215);
            this.labelTelefon.Name = "labelTelefon";
            this.labelTelefon.Size = new System.Drawing.Size(45, 15);
            this.labelTelefon.TabIndex = 8;
            this.labelTelefon.Text = "Telefon";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Location = new System.Drawing.Point(74, 115);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(150, 1);
            this.panel2.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Location = new System.Drawing.Point(73, 163);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 1);
            this.panel1.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel3.Location = new System.Drawing.Point(74, 207);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(150, 1);
            this.panel3.TabIndex = 10;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel4.Location = new System.Drawing.Point(74, 255);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(150, 1);
            this.panel4.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkRed;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(232, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 25);
            this.button2.TabIndex = 21;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ıconPictureBox1
            // 
            this.ıconPictureBox1.ForeColor = System.Drawing.Color.Gray;
            this.ıconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.User;
            this.ıconPictureBox1.IconColor = System.Drawing.Color.Gray;
            this.ıconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconPictureBox1.IconSize = 31;
            this.ıconPictureBox1.Location = new System.Drawing.Point(191, 82);
            this.ıconPictureBox1.Name = "ıconPictureBox1";
            this.ıconPictureBox1.Size = new System.Drawing.Size(33, 31);
            this.ıconPictureBox1.TabIndex = 22;
            this.ıconPictureBox1.TabStop = false;
            this.ıconPictureBox1.Click += new System.EventHandler(this.ıconPictureBox1_Click);
            // 
            // ıconPictureBox2
            // 
            this.ıconPictureBox2.ForeColor = System.Drawing.Color.Gray;
            this.ıconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Key;
            this.ıconPictureBox2.IconColor = System.Drawing.Color.Gray;
            this.ıconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconPictureBox2.IconSize = 31;
            this.ıconPictureBox2.Location = new System.Drawing.Point(190, 130);
            this.ıconPictureBox2.Name = "ıconPictureBox2";
            this.ıconPictureBox2.Size = new System.Drawing.Size(33, 31);
            this.ıconPictureBox2.TabIndex = 23;
            this.ıconPictureBox2.TabStop = false;
            // 
            // ıconPictureBox3
            // 
            this.ıconPictureBox3.ForeColor = System.Drawing.Color.Gray;
            this.ıconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.Envelope;
            this.ıconPictureBox3.IconColor = System.Drawing.Color.Gray;
            this.ıconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconPictureBox3.IconSize = 31;
            this.ıconPictureBox3.Location = new System.Drawing.Point(191, 174);
            this.ıconPictureBox3.Name = "ıconPictureBox3";
            this.ıconPictureBox3.Size = new System.Drawing.Size(33, 31);
            this.ıconPictureBox3.TabIndex = 24;
            this.ıconPictureBox3.TabStop = false;
            // 
            // ıconPictureBox4
            // 
            this.ıconPictureBox4.ForeColor = System.Drawing.Color.Gray;
            this.ıconPictureBox4.IconChar = FontAwesome.Sharp.IconChar.PhoneSquare;
            this.ıconPictureBox4.IconColor = System.Drawing.Color.Gray;
            this.ıconPictureBox4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconPictureBox4.IconSize = 31;
            this.ıconPictureBox4.Location = new System.Drawing.Point(191, 222);
            this.ıconPictureBox4.Name = "ıconPictureBox4";
            this.ıconPictureBox4.Size = new System.Drawing.Size(33, 31);
            this.ıconPictureBox4.TabIndex = 25;
            this.ıconPictureBox4.TabStop = false;
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(284, 411);
            this.Controls.Add(this.ıconPictureBox4);
            this.Controls.Add(this.ıconPictureBox3);
            this.Controls.Add(this.ıconPictureBox2);
            this.Controls.Add(this.ıconPictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.labelTelefon);
            this.Controls.Add(this.labelEposta);
            this.Controls.Add(this.labelSifre);
            this.Controls.Add(this.labelKullaniciAdi);
            this.Controls.Add(this.textBoxtelno);
            this.Controls.Add(this.textBoxeposta);
            this.Controls.Add(this.buttonKayitOl);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Registration";
            this.Text = "+";
            this.Load += new System.EventHandler(this.Registration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonKayitOl;
        private System.Windows.Forms.TextBox textBoxeposta;
        private System.Windows.Forms.TextBox textBoxtelno;
        private System.Windows.Forms.Label labelKullaniciAdi;
        private System.Windows.Forms.Label labelSifre;
        private System.Windows.Forms.Label labelEposta;
        private System.Windows.Forms.Label labelTelefon;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button2;
        private FontAwesome.Sharp.IconPictureBox ıconPictureBox1;
        private FontAwesome.Sharp.IconPictureBox ıconPictureBox2;
        private FontAwesome.Sharp.IconPictureBox ıconPictureBox3;
        private FontAwesome.Sharp.IconPictureBox ıconPictureBox4;
    }
}