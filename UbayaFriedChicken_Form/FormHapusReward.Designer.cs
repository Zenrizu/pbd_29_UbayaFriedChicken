namespace UbayaFriedChicken_Form
{
    partial class FormHapusReward
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
            this.labelWarna = new System.Windows.Forms.Label();
            this.buttonHapus = new System.Windows.Forms.Button();
            this.buttonKeluar = new System.Windows.Forms.Button();
            this.buttonKosongi = new System.Windows.Forms.Button();
            this.labelIdKategori = new System.Windows.Forms.Label();
            this.textBoxBatasMinimal = new System.Windows.Forms.TextBox();
            this.labelBatasMinimal = new System.Windows.Forms.Label();
            this.textBoxJenisBarang = new System.Windows.Forms.TextBox();
            this.labelJenisBarang = new System.Windows.Forms.Label();
            this.labelNama = new System.Windows.Forms.Label();
            this.textBoxNama = new System.Windows.Forms.TextBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
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
            this.panel1.TabIndex = 44;
            // 
            // labelWarna
            // 
            this.labelWarna.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelWarna.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWarna.ForeColor = System.Drawing.Color.White;
            this.labelWarna.Location = new System.Drawing.Point(12, 9);
            this.labelWarna.Name = "labelWarna";
            this.labelWarna.Size = new System.Drawing.Size(444, 41);
            this.labelWarna.TabIndex = 48;
            this.labelWarna.Text = "HAPUS REWARD";
            this.labelWarna.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonHapus
            // 
            this.buttonHapus.BackColor = System.Drawing.Color.White;
            this.buttonHapus.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHapus.ForeColor = System.Drawing.Color.Red;
            this.buttonHapus.Location = new System.Drawing.Point(12, 267);
            this.buttonHapus.Name = "buttonHapus";
            this.buttonHapus.Size = new System.Drawing.Size(117, 41);
            this.buttonHapus.TabIndex = 45;
            this.buttonHapus.Text = "HAPUS";
            this.buttonHapus.UseVisualStyleBackColor = false;
            this.buttonHapus.Click += new System.EventHandler(this.buttonHapus_Click);
            // 
            // buttonKeluar
            // 
            this.buttonKeluar.BackColor = System.Drawing.Color.White;
            this.buttonKeluar.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKeluar.ForeColor = System.Drawing.Color.Red;
            this.buttonKeluar.Location = new System.Drawing.Point(345, 267);
            this.buttonKeluar.Name = "buttonKeluar";
            this.buttonKeluar.Size = new System.Drawing.Size(111, 41);
            this.buttonKeluar.TabIndex = 47;
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
            this.buttonKosongi.TabIndex = 46;
            this.buttonKosongi.Text = "KOSONGI";
            this.buttonKosongi.UseVisualStyleBackColor = false;
            this.buttonKosongi.Click += new System.EventHandler(this.buttonKosongi_Click);
            // 
            // labelIdKategori
            // 
            this.labelIdKategori.AutoSize = true;
            this.labelIdKategori.BackColor = System.Drawing.Color.Transparent;
            this.labelIdKategori.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdKategori.ForeColor = System.Drawing.Color.Black;
            this.labelIdKategori.Location = new System.Drawing.Point(46, 37);
            this.labelIdKategori.Name = "labelIdKategori";
            this.labelIdKategori.Size = new System.Drawing.Size(85, 16);
            this.labelIdKategori.TabIndex = 47;
            this.labelIdKategori.Text = "ID Reward :";
            // 
            // textBoxBatasMinimal
            // 
            this.textBoxBatasMinimal.Location = new System.Drawing.Point(131, 138);
            this.textBoxBatasMinimal.Multiline = true;
            this.textBoxBatasMinimal.Name = "textBoxBatasMinimal";
            this.textBoxBatasMinimal.Size = new System.Drawing.Size(53, 28);
            this.textBoxBatasMinimal.TabIndex = 46;
            // 
            // labelBatasMinimal
            // 
            this.labelBatasMinimal.AutoSize = true;
            this.labelBatasMinimal.BackColor = System.Drawing.Color.Transparent;
            this.labelBatasMinimal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBatasMinimal.ForeColor = System.Drawing.Color.Black;
            this.labelBatasMinimal.Location = new System.Drawing.Point(25, 142);
            this.labelBatasMinimal.Name = "labelBatasMinimal";
            this.labelBatasMinimal.Size = new System.Drawing.Size(105, 16);
            this.labelBatasMinimal.TabIndex = 45;
            this.labelBatasMinimal.Text = "Batas Minimal :";
            // 
            // textBoxJenisBarang
            // 
            this.textBoxJenisBarang.Location = new System.Drawing.Point(131, 105);
            this.textBoxJenisBarang.Multiline = true;
            this.textBoxJenisBarang.Name = "textBoxJenisBarang";
            this.textBoxJenisBarang.Size = new System.Drawing.Size(158, 28);
            this.textBoxJenisBarang.TabIndex = 44;
            // 
            // labelJenisBarang
            // 
            this.labelJenisBarang.AutoSize = true;
            this.labelJenisBarang.BackColor = System.Drawing.Color.Transparent;
            this.labelJenisBarang.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJenisBarang.ForeColor = System.Drawing.Color.Black;
            this.labelJenisBarang.Location = new System.Drawing.Point(31, 110);
            this.labelJenisBarang.Name = "labelJenisBarang";
            this.labelJenisBarang.Size = new System.Drawing.Size(99, 16);
            this.labelJenisBarang.TabIndex = 43;
            this.labelJenisBarang.Text = "Jenis Barang :";
            // 
            // labelNama
            // 
            this.labelNama.AutoSize = true;
            this.labelNama.BackColor = System.Drawing.Color.Transparent;
            this.labelNama.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNama.Location = new System.Drawing.Point(24, 69);
            this.labelNama.Name = "labelNama";
            this.labelNama.Size = new System.Drawing.Size(106, 16);
            this.labelNama.TabIndex = 42;
            this.labelNama.Text = "Nama Reward :";
            // 
            // textBoxNama
            // 
            this.textBoxNama.Location = new System.Drawing.Point(131, 68);
            this.textBoxNama.Multiline = true;
            this.textBoxNama.Name = "textBoxNama";
            this.textBoxNama.Size = new System.Drawing.Size(289, 30);
            this.textBoxNama.TabIndex = 41;
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(131, 33);
            this.textBoxId.Multiline = true;
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(53, 28);
            this.textBoxId.TabIndex = 40;
            this.textBoxId.TextChanged += new System.EventHandler(this.textBoxId_TextChanged);
            // 
            // FormHapusReward
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 316);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelWarna);
            this.Controls.Add(this.buttonHapus);
            this.Controls.Add(this.buttonKeluar);
            this.Controls.Add(this.buttonKosongi);
            this.Name = "FormHapusReward";
            this.Text = "FormHapusReward";
            this.Load += new System.EventHandler(this.FormHapusReward_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelWarna;
        private System.Windows.Forms.Button buttonHapus;
        private System.Windows.Forms.Button buttonKeluar;
        private System.Windows.Forms.Button buttonKosongi;
        private System.Windows.Forms.Label labelIdKategori;
        private System.Windows.Forms.TextBox textBoxBatasMinimal;
        private System.Windows.Forms.Label labelBatasMinimal;
        private System.Windows.Forms.TextBox textBoxJenisBarang;
        private System.Windows.Forms.Label labelJenisBarang;
        private System.Windows.Forms.Label labelNama;
        private System.Windows.Forms.TextBox textBoxNama;
        private System.Windows.Forms.TextBox textBoxId;
    }
}