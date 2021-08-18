
namespace WinFormsApp
{
    partial class UyeSil
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
            this.button2 = new System.Windows.Forms.Button();
            this.buttonUyeSil = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSilinecekUye = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 65);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(736, 453);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
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
            this.button2.TabIndex = 6;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonUyeSil
            // 
            this.buttonUyeSil.BackColor = System.Drawing.Color.Gray;
            this.buttonUyeSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUyeSil.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonUyeSil.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonUyeSil.Location = new System.Drawing.Point(654, 543);
            this.buttonUyeSil.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonUyeSil.Name = "buttonUyeSil";
            this.buttonUyeSil.Size = new System.Drawing.Size(114, 40);
            this.buttonUyeSil.TabIndex = 15;
            this.buttonUyeSil.Text = "Üyeyi Sil";
            this.buttonUyeSil.UseVisualStyleBackColor = false;
            this.buttonUyeSil.Click += new System.EventHandler(this.buttonUyeSil_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(360, 555);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Silinecek Olan Üyenin İd numarası:";
            // 
            // textBoxSilinecekUye
            // 
            this.textBoxSilinecekUye.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBoxSilinecekUye.Location = new System.Drawing.Point(583, 551);
            this.textBoxSilinecekUye.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxSilinecekUye.Name = "textBoxSilinecekUye";
            this.textBoxSilinecekUye.Size = new System.Drawing.Size(26, 27);
            this.textBoxSilinecekUye.TabIndex = 17;
            this.textBoxSilinecekUye.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UyeSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 632);
            this.Controls.Add(this.textBoxSilinecekUye);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonUyeSil);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UyeSil";
            this.Text = "UyeSil";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonUyeSil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSilinecekUye;
    }
}