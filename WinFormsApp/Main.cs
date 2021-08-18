using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace WinFormsApp
{
    public partial class Main : Form
    {
        public int renk;
        public Main()
        {
            InitializeComponent();
            System.Media.SoundPlayer ses = new System.Media.SoundPlayer();
            ses.SoundLocation = "";
            panelKitapİşlemler.Visible = false;
            panelUyeİslemler.Visible = false;
            ıconButtonGri.Visible = false;
            ıconButtonYesil.Visible = false;
            ıconButtonMavi.Visible = false;
            ıconButtonTuruncu.Visible = false;
            this.Opacity = 0.85;
        }
        
        private void panelkapatma()
        {
            if (panelKitapİşlemler.Visible==true)
            {
                panelKitapİşlemler.Visible = false;
            }
            if (panelUyeİslemler.Visible==true)
            {
                panelUyeİslemler.Visible = false;
            }
        }

        private void panelacma(Panel panel01)
        {
            if (panel01.Visible == false)
            {
                panelkapatma();
                panel01.Visible = true;
            }
            else
            {
                panel01.Visible = false;
            }
        }
        private void Main_Load(object sender, EventArgs e)
        {
        }
        private void button2_Click(object sender, EventArgs e)
        {
            panelkapatma();
            anaformacma(new KitapEkle());
        }
        private void button3_Click(object sender, EventArgs e)
        {
            panelkapatma();
            anaformacma(new KitapGüncelle());
        }
        private void button4_Click(object sender, EventArgs e)
        {
            panelkapatma();
            anaformacma(new KitapSil());
        }
        private Form aktifForm = null;
        private void anaformacma(Form altForm) 
        {
            if (aktifForm !=null)
            {
                aktifForm.Close();
            }
            aktifForm = altForm;
            altForm.TopLevel = false;
            altForm.FormBorderStyle = FormBorderStyle.None;
            altForm.Dock = DockStyle.Fill;
            panel4.Controls.Add(altForm);
            panel4.Tag = altForm;
            altForm.BringToFront();
            altForm.Show();
        }
        private void ButtonKitapİslem_Click(object sender, EventArgs e)
        {
            panelacma(panelKitapİşlemler);
        }
        private void ıconButton1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
        private void buttonUyeİslemleri_Click(object sender, EventArgs e)
        {
            panelkapatma();
            panelacma(panelUyeİslemler);
        }
        private void buttonUyeListele_Click(object sender, EventArgs e)
        {
            anaformacma(new UyeListele());
            panelkapatma();
        }
        private void buttonUyeSil_Click(object sender, EventArgs e)
        {
            anaformacma(new UyeSil());
            panelkapatma();
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            anaformacma(new UyeGuncelle());
            panelkapatma();  
        }
        private void button1_Click(object sender, EventArgs e)
        {
            panelkapatma();
            anaformacma(new Kitaplar());
        }
        public int sayac = 0;
        private void ıconButton2_Click(object sender, EventArgs e)
        {
            if (sayac % 2 == 0)
            {
                sayac = sayac + 1;
                ıconButtonGri.Visible = true;
                ıconButtonYesil.Visible = true;
                ıconButtonTuruncu.Visible = true;
                ıconButtonMavi.Visible = true;
                ıconButtonIcon1.Visible = true;
            }
            else
            {
                sayac = sayac + 1;
                ıconButtonGri.Visible = false;
                ıconButtonYesil.Visible = false;
                ıconButtonTuruncu.Visible = false;
                ıconButtonMavi.Visible = false;
                ıconButtonIcon1.Visible = false;
            }   
        }
        private void buttonKitapOku_Click(object sender, EventArgs e)
        {
            anaformacma(new KitapOku());
        }
        private void ıconButtonYesil_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            buttonKitapEkle.BackColor = System.Drawing.ColorTranslator.FromHtml("#C1FFC4");
            buttonKitapGüncelle.BackColor = System.Drawing.ColorTranslator.FromHtml("#C1FFC4");
            buttonKitapSil.BackColor = System.Drawing.ColorTranslator.FromHtml("#C1FFC4");
            buttonÜyeGüncelle.BackColor = System.Drawing.ColorTranslator.FromHtml("#C1FFC4");
            buttonUyeListele.BackColor = System.Drawing.ColorTranslator.FromHtml("#C1FFC4");
            buttonUyeSil.BackColor = System.Drawing.ColorTranslator.FromHtml("#C1FFC4");
            panel4.BackColor = System.Drawing.ColorTranslator.FromHtml("#C1FFC4");
            panel3.BackColor = System.Drawing.ColorTranslator.FromHtml("#96DE9A");
            panel2.BackColor = System.Drawing.ColorTranslator.FromHtml("#8ACC8D");
            panel1.BackColor = System.Drawing.ColorTranslator.FromHtml("#8ACC8D");
            buttonKitapEkle.ForeColor = Color.Black;
            buttonKitapGüncelle.ForeColor = Color.Black;
            buttonKitaplar.ForeColor = Color.Black;
            buttonKitapOku.ForeColor = Color.Black;
            buttonKitapSil.ForeColor = Color.Black;
            buttonUyeListele.ForeColor = Color.Black;
            buttonUyeSil.ForeColor = Color.Black;
            buttonUyeİslemleri.ForeColor = Color.Black;
            buttonÜyeGüncelle.ForeColor = Color.Black;
            ButtonKitapİslem.ForeColor = Color.Black;
            labelKullaniciAdi.ForeColor = Color.Black;
            label2.ForeColor = Color.Black;
        }

        private void ıconButtonGri_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            renk = 2;
            buttonKitapEkle.BackColor = System.Drawing.ColorTranslator.FromHtml("64; 64; 64");
            buttonKitapGüncelle.BackColor = System.Drawing.ColorTranslator.FromHtml("64; 64; 64");
            buttonKitapSil.BackColor = System.Drawing.ColorTranslator.FromHtml("64; 64; 64");
            buttonÜyeGüncelle.BackColor = System.Drawing.ColorTranslator.FromHtml("64; 64; 64");
            buttonUyeListele.BackColor = System.Drawing.ColorTranslator.FromHtml("64; 64; 64");
            buttonUyeSil.BackColor = System.Drawing.ColorTranslator.FromHtml("64; 64; 64");
            panel4.BackColor = Color.DimGray;
            panel3.BackColor = System.Drawing.ColorTranslator.FromHtml("64; 64; 64");
            panel2.BackColor = Color.Black;
            panel1.BackColor = Color.Black;
            buttonKitapEkle.ForeColor = Color.LightGray;
            buttonKitapGüncelle.ForeColor = Color.LightGray;
            buttonKitaplar.ForeColor = Color.LightGray;
            buttonKitapOku.ForeColor = Color.LightGray;
            buttonKitapSil.ForeColor = Color.LightGray;
            buttonUyeListele.ForeColor = Color.LightGray;
            buttonUyeSil.ForeColor = Color.LightGray;
            buttonUyeİslemleri.ForeColor = Color.LightGray;
            buttonÜyeGüncelle.ForeColor = Color.LightGray;
            ButtonKitapİslem.ForeColor = Color.LightGray;
            labelKullaniciAdi.ForeColor = Color.LightGray;
            label2.ForeColor = Color.LightGray;
        }

        private void ıconButtonTuruncu_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            renk = 3;
            buttonKitapEkle.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFDE9A");
            buttonKitapGüncelle.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFDE9A");
            buttonKitapSil.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFDE9A");
            buttonÜyeGüncelle.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFDE9A");
            buttonUyeListele.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFDE9A");
            buttonUyeSil.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFDE9A");
            panel4.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFFFC4");
            panel3.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFDE9A");
            panel2.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFCC8D");
            panel1.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFCC8D");
            buttonKitapEkle.ForeColor = Color.Black;
            buttonKitapGüncelle.ForeColor = Color.Black;
            buttonKitaplar.ForeColor = Color.Black;
            buttonKitapOku.ForeColor = Color.Black;
            buttonKitapSil.ForeColor = Color.Black;
            buttonUyeListele.ForeColor = Color.Black;
            buttonUyeSil.ForeColor = Color.Black;
            buttonUyeİslemleri.ForeColor = Color.Black;
            buttonÜyeGüncelle.ForeColor = Color.Black;
            ButtonKitapİslem.ForeColor = Color.Black;
            labelKullaniciAdi.ForeColor = Color.Black;
            label2.ForeColor = Color.Black;
        }

        private void ıconButtonMavi_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            renk = 4;
            buttonKitapEkle.BackColor = System.Drawing.ColorTranslator.FromHtml("#96DEFF");
            buttonKitapGüncelle.BackColor = System.Drawing.ColorTranslator.FromHtml("#96DEFF");
            buttonKitapSil.BackColor = System.Drawing.ColorTranslator.FromHtml("#96DEFF");
            buttonÜyeGüncelle.BackColor = System.Drawing.ColorTranslator.FromHtml("#96DEFF");
            buttonUyeListele.BackColor = System.Drawing.ColorTranslator.FromHtml("#96DEFF");
            buttonUyeSil.BackColor = System.Drawing.ColorTranslator.FromHtml("#96DEFF");
            panel4.BackColor = System.Drawing.ColorTranslator.FromHtml("#C1FFFF");
            panel3.BackColor = System.Drawing.ColorTranslator.FromHtml("#96DEFF");
            panel2.BackColor = System.Drawing.ColorTranslator.FromHtml("#8ACCFF");
            panel1.BackColor = System.Drawing.ColorTranslator.FromHtml("#8ACCFF");
            buttonKitapEkle.ForeColor = Color.Black;
            buttonKitapGüncelle.ForeColor = Color.Black;
            buttonKitaplar.ForeColor = Color.Black;
            buttonKitapOku.ForeColor = Color.Black;
            buttonKitapSil.ForeColor = Color.Black;
            buttonUyeListele.ForeColor = Color.Black;
            buttonUyeSil.ForeColor = Color.Black;
            buttonUyeİslemleri.ForeColor = Color.Black;
            buttonÜyeGüncelle.ForeColor = Color.Black;
            ButtonKitapİslem.ForeColor = Color.Black;
            labelKullaniciAdi.ForeColor = Color.Black;
            label2.ForeColor = Color.Black;
        }
    }
}
