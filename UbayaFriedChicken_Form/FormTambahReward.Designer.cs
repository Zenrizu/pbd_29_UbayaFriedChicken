namespace UbayaFriedChicken_Form
{
    partial class FormTambahReward
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelIdKategori = new System.Windows.Forms.Label();
            this.textBoxBatasMinimal = new System.Windows.Forms.TextBox();
            this.labelBatasMinimal = new System.Windows.Forms.Label();
            this.textBoxJenisBarang = new System.Windows.Forms.TextBox();
            this.labelJenisBarang = new System.Windows.Forms.Label();
            this.labelNama = new System.Windows.Forms.Label();
            this.textBoxNama = new System.Windows.Forms.TextBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
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
            this.panel1.Controls.Add(this.labelIdKategori);
            this.panel1.Controls.Add(this.textBoxBatasMinimal);
            this.panel1.Controls.Add(this.labelBatasMinimal);
            this.panel1.Controls.Add(this.textBoxJenisBarang);
            this.panel1.Controls.Add(this.labelJenisBarang);
            this.panel1.Controls.Add(this.labelNama);
            this.panel1.Controls.Add(this.textBoxNama);
            this.panel1.Controls.Add(this.textBoxId);
            this.panel1.Location = new System.Drawing.Point(12, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(444, 199);
            this.panel1.TabIndex = 39;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // labelIdKategori
            // 
            this.labelIdKategori.AutoSize = true;
            this.labelIdKategori.BackColor = System.Drawing.Color.Transparent;
            this.labelIdKategori.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdKategori.ForeColor = System.Drawing.Color.Black;
            this.labelIdKategori.Location = new System.Drawing.Point(51, 32);
            this.labelIdKategori.Name = "labelIdKategori";
            this.labelIdKategori.Size = new System.Drawing.Size(85, 16);
            this.labelIdKategori.TabIndex = 31;
            this.labelIdKategori.Text = "ID Reward :";
            // 
            // textBoxBatasMinimal
            // 
            this.textBoxBatasMinimal.Location = new System.Drawing.Point(136, 133);
            this.textBoxBatasMinimal.Multiline = true;
            this.textBoxBatasMinimal.Name = "textBoxBatasMinimal";
            this.textBoxBatasMinimal.Size = new System.Drawing.Size(53, 28);
            this.textBoxBatasMinimal.TabIndex = 30;
            // 
            // labelBatasMinimal
            // 
            this.labelBatasMinimal.AutoSize = true;
            this.labelBatasMinimal.BackColor = System.Drawing.Color.Transparent;
            this.labelBatasMinimal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBatasMinimal.ForeColor = System.Drawing.Color.Black;
            this.labelBatasMinimal.Location = new System.Drawing.Point(30, 137);
            this.labelBatasMinimal.Name = "labelBatasMinimal";
            this.labelBatasMinimal.Size = new System.Drawing.Size(105, 16);
            this.labelBatasMinimal.TabIndex = 29;
            this.labelBatasMinimal.Text = "Batas Minimal :";
            // 
            // textBoxJenisBarang
            // 
            this.textBoxJenisBarang.Location = new System.Drawing.Point(136, 100);
            this.textBoxJenisBarang.Multiline = true;
            this.textBoxJenisBarang.Name = "textBoxJenisBarang";
            this.textBoxJenisBarang.Size = new System.Drawing.Size(158, 28);
            this.textBoxJenisBarang.TabIndex = 28;
            // 
            // labelJenisBarang
            // 
            this.labelJenisBarang.AutoSize = true;
            this.labelJenisBarang.BackColor = System.Drawing.Color.Transparent;
            this.labelJenisBarang.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJenisBarang.ForeColor = System.Drawing.Color.Black;
            this.labelJenisBarang.Location = new System.Drawing.Point(36, 105);
            this.labelJenisBarang.Name = "labelJenisBarang";
            this.labelJenisBarang.Size = new System.Drawing.Size(99, 16);
            this.labelJenisBarang.TabIndex = 27;
            this.labelJenisBarang.Text = "Jenis Barang :";
            // 
            // labelNama
            // 
            this.labelNama.AutoSize = true;
            this.labelNama.BackColor = System.Drawing.Color.Transparent;
            this.labelNama.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNama.Location = new System.Drawing.Point(29, 64);
            this.labelNama.Name = "labelNama";
            this.labelNama.Size = new System.Drawing.Size(106, 16);
            this.labelNama.TabIndex = 26;
            this.labelNama.Text = "Nama Reward :";
            // 
            // textBoxNama
            // 
            this.textBoxNama.Location = new System.Drawing.Point(136, 63);
            this.textBoxNama.Multiline = true;
            this.textBoxNama.Name = "textBoxNama";
            this.textBoxNama.Size = new System.Drawing.Size(289, 30);
            this.textBoxNama.TabIndex = 25;
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(136, 28);
            this.textBoxId.Multiline = true;
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(53, 28);
            this.textBoxId.TabIndex = 23;
            // 
            // buttonSimpan
            // 
            this.buttonSimpan.BackColor = System.Drawing.Color.White;
            this.buttonSimpan.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSimpan.ForeColor = System.Drawing.Color.Red;
            this.buttonSimpan.Location = new System.Drawing.Point(12, 267);
            this.buttonSimpan.Name = "buttonSimpan";
            this.buttonSimpan.Size = new System.Drawing.Size(117, 41);
            this.buttonSimpan.TabIndex = 40;
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
            this.labelWarna.TabIndex = 43;
            this.labelWarna.Text = "TAMBAH REWARD";
            this.labelWarna.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelWarna.Click += new System.EventHandler(this.labelWarna_Click);
            // 
            // buttonKeluar
            // 
            this.buttonKeluar.BackColor = System.Drawing.Color.White;
            this.buttonKeluar.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKeluar.ForeColor = System.Drawing.Color.Red;
            this.buttonKeluar.Location = new System.Drawing.Point(345, 267);
            this.buttonKeluar.Name = "buttonKeluar";
            this.buttonKeluar.Size = new System.Drawing.Size(111, 41);
            this.buttonKeluar.TabIndex = 42;
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
            this.buttonKosongi.TabIndex = 41;
            this.buttonKosongi.Text = "KOSONGI";
            this.buttonKosongi.UseVisualStyleBackColor = false;
            this.buttonKosongi.Click += new System.EventHandler(this.buttonKosongi_Click);
            // 
            // FormTambahReward
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 314);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonSimpan);
            this.Controls.Add(this.labelWarna);
            this.Controls.Add(this.buttonKeluar);
            this.Controls.Add(this.buttonKosongi);
            this.Name = "FormTambahReward";
            this.Text = "FormTambahReward";
            this.Load += new System.EventHandler(this.FormTambahReward_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelIdKategori;
        private System.Windows.Forms.TextBox textBoxBatasMinimal;
        private System.Windows.Forms.Label labelBatasMinimal;
        private System.Windows.Forms.Label labelJenisBarang;
        private System.Windows.Forms.Label labelNama;
        private System.Windows.Forms.TextBox textBoxNama;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Button buttonSimpan;
        private System.Windows.Forms.Label labelWarna;
        private System.Windows.Forms.Button buttonKeluar;
        private System.Windows.Forms.Button buttonKosongi;
        private System.Windows.Forms.TextBox textBoxJenisBarang;
    }
}