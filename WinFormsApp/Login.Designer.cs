
namespace WinFormsApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.ıconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.ıconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.buttonKayıtOl = new System.Windows.Forms.Button();
            this.ıconButton1 = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ıconButton2 = new FontAwesome.Sharp.IconButton();
            this.ıconButton3 = new FontAwesome.Sharp.IconButton();
            this.buttonZiyaretçi = new System.Windows.Forms.Button();
            this.buttonCikis = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Location = new System.Drawing.Point(35, 269);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(215, 1);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel3.Location = new System.Drawing.Point(35, 350);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(215, 1);
            this.panel3.TabIndex = 2;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.Color.Black;
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPassword.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxPassword.ForeColor = System.Drawing.Color.White;
            this.textBoxPassword.Location = new System.Drawing.Point(35, 328);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(215, 20);
            this.textBoxPassword.TabIndex = 2;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.BackColor = System.Drawing.Color.Black;
            this.textBoxUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUsername.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxUsername.ForeColor = System.Drawing.Color.White;
            this.textBoxUsername.Location = new System.Drawing.Point(35, 247);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(215, 20);
            this.textBoxUsername.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(38, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(40, 310);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Şifre";
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.DarkGray;
            this.buttonLogin.FlatAppearance.BorderSize = 0;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonLogin.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonLogin.Location = new System.Drawing.Point(40, 376);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(83, 30);
            this.buttonLogin.TabIndex = 3;
            this.buttonLogin.Text = "Giriş";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // ıconPictureBox1
            // 
            this.ıconPictureBox1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.ıconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.User;
            this.ıconPictureBox1.IconColor = System.Drawing.SystemColors.AppWorkspace;
            this.ıconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconPictureBox1.IconSize = 31;
            this.ıconPictureBox1.Location = new System.Drawing.Point(217, 238);
            this.ıconPictureBox1.Name = "ıconPictureBox1";
            this.ıconPictureBox1.Size = new System.Drawing.Size(33, 31);
            this.ıconPictureBox1.TabIndex = 8;
            this.ıconPictureBox1.TabStop = false;
            // 
            // ıconPictureBox2
            // 
            this.ıconPictureBox2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.ıconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Key;
            this.ıconPictureBox2.IconColor = System.Drawing.SystemColors.AppWorkspace;
            this.ıconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconPictureBox2.IconSize = 31;
            this.ıconPictureBox2.Location = new System.Drawing.Point(217, 317);
            this.ıconPictureBox2.Name = "ıconPictureBox2";
            this.ıconPictureBox2.Size = new System.Drawing.Size(33, 31);
            this.ıconPictureBox2.TabIndex = 9;
            this.ıconPictureBox2.TabStop = false;
            // 
            // buttonKayıtOl
            // 
            this.buttonKayıtOl.BackColor = System.Drawing.Color.DarkGray;
            this.buttonKayıtOl.FlatAppearance.BorderSize = 0;
            this.buttonKayıtOl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKayıtOl.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonKayıtOl.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonKayıtOl.Location = new System.Drawing.Point(167, 376);
            this.buttonKayıtOl.Name = "buttonKayıtOl";
            this.buttonKayıtOl.Size = new System.Drawing.Size(83, 30);
            this.buttonKayıtOl.TabIndex = 4;
            this.buttonKayıtOl.Text = "Kayıt Ol";
            this.buttonKayıtOl.UseVisualStyleBackColor = false;
            this.buttonKayıtOl.Click += new System.EventHandler(this.buttonKayıtOl_Click);
            // 
            // ıconButton1
            // 
            this.ıconButton1.BackColor = System.Drawing.Color.Transparent;
            this.ıconButton1.FlatAppearance.BorderSize = 0;
            this.ıconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ıconButton1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.ıconButton1.IconChar = FontAwesome.Sharp.IconChar.Github;
            this.ıconButton1.IconColor = System.Drawing.Color.Gray;
            this.ıconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconButton1.IconSize = 40;
            this.ıconButton1.Location = new System.Drawing.Point(0, 456);
            this.ıconButton1.Name = "ıconButton1";
            this.ıconButton1.Size = new System.Drawing.Size(41, 45);
            this.ıconButton1.TabIndex = 10;
            this.ıconButton1.UseVisualStyleBackColor = false;
            this.ıconButton1.Click += new System.EventHandler(this.ıconButton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(284, 226);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // ıconButton2
            // 
            this.ıconButton2.BackColor = System.Drawing.Color.Transparent;
            this.ıconButton2.Cursor = System.Windows.Forms.Cursors.Default;
            this.ıconButton2.FlatAppearance.BorderSize = 0;
            this.ıconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ıconButton2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.ıconButton2.IconChar = FontAwesome.Sharp.IconChar.Instagram;
            this.ıconButton2.IconColor = System.Drawing.Color.Gray;
            this.ıconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconButton2.IconSize = 40;
            this.ıconButton2.Location = new System.Drawing.Point(48, 456);
            this.ıconButton2.Name = "ıconButton2";
            this.ıconButton2.Size = new System.Drawing.Size(35, 45);
            this.ıconButton2.TabIndex = 12;
            this.ıconButton2.UseVisualStyleBackColor = false;
            this.ıconButton2.Click += new System.EventHandler(this.ıconButton2_Click);
            // 
            // ıconButton3
            // 
            this.ıconButton3.BackColor = System.Drawing.Color.Transparent;
            this.ıconButton3.Cursor = System.Windows.Forms.Cursors.Default;
            this.ıconButton3.FlatAppearance.BorderSize = 0;
            this.ıconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ıconButton3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.ıconButton3.IconChar = FontAwesome.Sharp.IconChar.Steam;
            this.ıconButton3.IconColor = System.Drawing.Color.Gray;
            this.ıconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconButton3.IconSize = 40;
            this.ıconButton3.Location = new System.Drawing.Point(89, 456);
            this.ıconButton3.Name = "ıconButton3";
            this.ıconButton3.Size = new System.Drawing.Size(35, 45);
            this.ıconButton3.TabIndex = 13;
            this.ıconButton3.UseVisualStyleBackColor = false;
            this.ıconButton3.Click += new System.EventHandler(this.ıconButton3_Click);
            // 
            // buttonZiyaretçi
            // 
            this.buttonZiyaretçi.BackColor = System.Drawing.Color.DarkGray;
            this.buttonZiyaretçi.FlatAppearance.BorderSize = 0;
            this.buttonZiyaretçi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonZiyaretçi.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonZiyaretçi.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonZiyaretçi.Location = new System.Drawing.Point(102, 412);
            this.buttonZiyaretçi.Name = "buttonZiyaretçi";
            this.buttonZiyaretçi.Size = new System.Drawing.Size(83, 30);
            this.buttonZiyaretçi.TabIndex = 14;
            this.buttonZiyaretçi.Text = "Ziyaretçi";
            this.buttonZiyaretçi.UseVisualStyleBackColor = false;
            this.buttonZiyaretçi.Click += new System.EventHandler(this.buttonZiyaretçi_Click);
            // 
            // buttonCikis
            // 
            this.buttonCikis.BackColor = System.Drawing.Color.DarkRed;
            this.buttonCikis.FlatAppearance.BorderSize = 0;
            this.buttonCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCikis.Location = new System.Drawing.Point(239, 6);
            this.buttonCikis.Name = "buttonCikis";
            this.buttonCikis.Size = new System.Drawing.Size(40, 25);
            this.buttonCikis.TabIndex = 22;
            this.buttonCikis.Text = "X";
            this.buttonCikis.UseVisualStyleBackColor = false;
            this.buttonCikis.Click += new System.EventHandler(this.buttonCikis_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(33, 354);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(98, 15);
            this.linkLabel1.TabIndex = 23;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Şifremi Unuttum!";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(284, 500);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.buttonCikis);
            this.Controls.Add(this.buttonZiyaretçi);
            this.Controls.Add(this.ıconButton3);
            this.Controls.Add(this.ıconButton2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ıconButton1);
            this.Controls.Add(this.buttonKayıtOl);
            this.Controls.Add(this.ıconPictureBox2);
            this.Controls.Add(this.ıconPictureBox1);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş";
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonLogin;
        private FontAwesome.Sharp.IconPictureBox ıconPictureBox1;
        private FontAwesome.Sharp.IconPictureBox ıconPictureBox2;
        private System.Windows.Forms.Button buttonKayıtOl;
        public System.Windows.Forms.TextBox textBoxUsername;
        private FontAwesome.Sharp.IconButton ıconButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton ıconButton2;
        private FontAwesome.Sharp.IconButton ıconButton3;
        private System.Windows.Forms.Button buttonZiyaretçi;
        private System.Windows.Forms.Button buttonCikis;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

