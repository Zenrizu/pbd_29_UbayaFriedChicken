namespace form
{
    partial class FormTambahProduk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTambahProduk));
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxIdKategori = new System.Windows.Forms.ComboBox();
            this.labelIdKategori = new System.Windows.Forms.Label();
            this.textBoxStok = new System.Windows.Forms.TextBox();
            this.labelStok = new System.Windows.Forms.Label();
            this.textBoxHargaJual = new System.Windows.Forms.TextBox();
            this.labelHargaJual = new System.Windows.Forms.Label();
            this.labelNama = new System.Windows.Forms.Label();
            this.textBoxNama = new System.Windows.Forms.TextBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.labelId = new System.Windows.Forms.Label();
            this.buttonSimpan = new System.Windows.Forms.Button();
            this.labelWarna = new System.Windows.Forms.Label();
            this.buttonKeluar = new System.Windows.Forms.Button();
            this.buttonKosongi = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.comboBoxIdKategori);
            this.panel1.Controls.Add(this.labelIdKategori);
            this.panel1.Controls.Add(this.textBoxStok);
            this.panel1.Controls.Add(this.labelStok);
            this.panel1.Controls.Add(this.textBoxHargaJual);
            this.panel1.Controls.Add(this.labelHargaJual);
            this.panel1.Controls.Add(this.labelNama);
            this.panel1.Controls.Add(this.textBoxNama);
            this.panel1.Controls.Add(this.textBoxId);
            this.panel1.Controls.Add(this.labelId);
            this.panel1.Location = new System.Drawing.Point(12, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(444, 199);
            this.panel1.TabIndex = 34;
            // 
            // comboBoxIdKategori
            // 
            this.comboBoxIdKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxIdKategori.FormattingEnabled = true;
            this.comboBoxIdKategori.Location = new System.Drawing.Point(136, 31);
            this.comboBoxIdKategori.Name = "comboBoxIdKategori";
            this.comboBoxIdKategori.Size = new System.Drawing.Size(180, 21);
            this.comboBoxIdKategori.TabIndex = 32;
            this.comboBoxIdKategori.SelectedIndexChanged += new System.EventHandler(this.comboBoxIdKategori_SelectedIndexChanged);
            // 
            // labelIdKategori
            // 
            this.labelIdKategori.AutoSize = true;
            this.labelIdKategori.BackColor = System.Drawing.Color.Transparent;
            this.labelIdKategori.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdKategori.ForeColor = System.Drawing.Color.Black;
            this.labelIdKategori.Location = new System.Drawing.Point(40, 32);
            this.labelIdKategori.Name = "labelIdKategori";
            this.labelIdKategori.Size = new System.Drawing.Size(90, 16);
            this.labelIdKategori.TabIndex = 31;
            this.labelIdKategori.Text = "ID Kategori :";
            // 
            // textBoxStok
            // 
            this.textBoxStok.Location = new System.Drawing.Point(136, 162);
            this.textBoxStok.Multiline = true;
            this.textBoxStok.Name = "textBoxStok";
            this.textBoxStok.Size = new System.Drawing.Size(53, 28);
            this.textBoxStok.TabIndex = 30;
            // 
            // labelStok
            // 
            this.labelStok.AutoSize = true;
            this.labelStok.BackColor = System.Drawing.Color.Transparent;
            this.labelStok.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStok.ForeColor = System.Drawing.Color.Black;
            this.labelStok.Location = new System.Drawing.Point(84, 163);
            this.labelStok.Name = "labelStok";
            this.labelStok.Size = new System.Drawing.Size(46, 16);
            this.labelStok.TabIndex = 29;
            this.labelStok.Text = "Stok :";
            // 
            // textBoxHargaJual
            // 
            this.textBoxHargaJual.Location = new System.Drawing.Point(136, 128);
            this.textBoxHargaJual.Multiline = true;
            this.textBoxHargaJual.Name = "textBoxHargaJual";
            this.textBoxHargaJual.Size = new System.Drawing.Size(99, 28);
            this.textBoxHargaJual.TabIndex = 28;
            // 
            // labelHargaJual
            // 
            this.labelHargaJual.AutoSize = true;
            this.labelHargaJual.BackColor = System.Drawing.Color.Transparent;
            this.labelHargaJual.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHargaJual.ForeColor = System.Drawing.Color.Black;
            this.labelHargaJual.Location = new System.Drawing.Point(45, 129);
            this.labelHargaJual.Name = "labelHargaJual";
            this.labelHargaJual.Size = new System.Drawing.Size(85, 16);
            this.labelHargaJual.TabIndex = 27;
            this.labelHargaJual.Text = "Harga Jual :";
            // 
            // labelNama
            // 
            this.labelNama.AutoSize = true;
            this.labelNama.BackColor = System.Drawing.Color.Transparent;
            this.labelNama.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNama.Location = new System.Drawing.Point(29, 93);
            this.labelNama.Name = "labelNama";
            this.labelNama.Size = new System.Drawing.Size(101, 16);
            this.labelNama.TabIndex = 26;
            this.labelNama.Text = "Nama Produk :";
            // 
            // textBoxNama
            // 
            this.textBoxNama.Location = new System.Drawing.Point(136, 92);
            this.textBoxNama.Multiline = true;
            this.textBoxNama.Name = "textBoxNama";
            this.textBoxNama.Size = new System.Drawing.Size(289, 30);
            this.textBoxNama.TabIndex = 25;
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(136, 58);
            this.textBoxId.Multiline = true;
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(53, 28);
            this.textBoxId.TabIndex = 23;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.BackColor = System.Drawing.Color.Transparent;
            this.labelId.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelId.ForeColor = System.Drawing.Color.Black;
            this.labelId.Location = new System.Drawing.Point(51, 59);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(80, 16);
            this.labelId.TabIndex = 22;
            this.labelId.Text = "ID Produk :";
            // 
            // buttonSimpan
            // 
            this.buttonSimpan.BackColor = System.Drawing.Color.White;
            this.buttonSimpan.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSimpan.ForeColor = System.Drawing.Color.Red;
            this.buttonSimpan.Location = new System.Drawing.Point(12, 267);
            this.buttonSimpan.Name = "buttonSimpan";
            this.buttonSimpan.Size = new System.Drawing.Size(117, 41);
            this.buttonSimpan.TabIndex = 35;
            this.buttonSimpan.Text = "SIMPAN";
            this.buttonSimpan.UseVisualStyleBackColor = false;
            this.buttonSimpan.Click += new System.EventHandler(this.buttonSimpan_Click);
            // 
            // labelWarna
            // 
            this.labelWarna.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelWarna.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWarna.ForeColor = System.Drawing.Color.White;
            this.labelWarna.Location = new System.Drawing.Point(12, 9);
            this.labelWarna.Name = "labelWarna";
            this.labelWarna.Size = new System.Drawing.Size(444, 41);
            this.labelWarna.TabIndex = 38;
            this.labelWarna.Text = "TAMBAH PRODUK";
            this.labelWarna.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonKeluar
            // 
            this.buttonKeluar.BackColor = System.Drawing.Color.White;
            this.buttonKeluar.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKeluar.ForeColor = System.Drawing.Color.Red;
            this.buttonKeluar.Location = new System.Drawing.Point(345, 267);
            this.buttonKeluar.Name = "buttonKeluar";
            this.buttonKeluar.Size = new System.Drawing.Size(111, 41);
            this.buttonKeluar.TabIndex = 37;
            this.buttonKeluar.Text = "KELUAR";
            this.buttonKeluar.UseVisualStyleBackColor = false;
            this.buttonKeluar.Click += new System.EventHandler(this.buttonKeluar_Click);
            // 
            // buttonKosongi
            // 
            this.buttonKosongi.BackColor = System.Drawing.Color.White;
            this.buttonKosongi.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKosongi.ForeColor = System.Drawing.Color.Red;
            this.buttonKosongi.Location = new System.Drawing.Point(178, 267);
            this.buttonKosongi.Name = "buttonKosongi";
            this.buttonKosongi.Size = new System.Drawing.Size(128, 41);
            this.buttonKosongi.TabIndex = 36;
            this.buttonKosongi.Text = "KOSONGI";
            this.buttonKosongi.UseVisualStyleBackColor = false;
            this.buttonKosongi.Click += new System.EventHandler(this.buttonKosongi_Click);
            // 
            // FormTambahProduk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(466, 316);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonSimpan);
            this.Controls.Add(this.labelWarna);
            this.Controls.Add(this.buttonKeluar);
            this.Controls.Add(this.buttonKosongi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTambahProduk";
            this.Text = "Tambah Produk";
            this.Load += new System.EventHandler(this.FormTambahProduk_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelNama;
        private System.Windows.Forms.TextBox textBoxNama;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Button buttonSimpan;
        private System.Windows.Forms.Label labelWarna;
        private System.Windows.Forms.Button buttonKeluar;
        private System.Windows.Forms.Button buttonKosongi;
        private System.Windows.Forms.TextBox textBoxHargaJual;
        private System.Windows.Forms.Label labelHargaJual;
        private System.Windows.Forms.ComboBox comboBoxIdKategori;
        private System.Windows.Forms.Label labelIdKategori;
        private System.Windows.Forms.TextBox textBoxStok;
        private System.Windows.Forms.Label labelStok;
    }
}