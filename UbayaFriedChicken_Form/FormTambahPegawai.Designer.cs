namespace form
{
    partial class FormTambahPegawai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTambahPegawai));
            this.textBoxUlangPassword = new System.Windows.Forms.TextBox();
            this.labelUlangPass = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.textBoxGaji = new System.Windows.Forms.TextBox();
            this.labelGaji = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxIdJabatan = new System.Windows.Forms.ComboBox();
            this.labelIdJabatan = new System.Windows.Forms.Label();
            this.dateTimePickerTglLahir = new System.Windows.Forms.DateTimePicker();
            this.textBoxAlamat = new System.Windows.Forms.TextBox();
            this.labelAlamat = new System.Windows.Forms.Label();
            this.labelTglLahir = new System.Windows.Forms.Label();
            this.labelNama = new System.Windows.Forms.Label();
            this.textBoxNama = new System.Windows.Forms.TextBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.labelId = new System.Windows.Forms.Label();
            this.buttonSimpan = new System.Windows.Forms.Button();
            this.buttonKeluar = new System.Windows.Forms.Button();
            this.buttonKosongi = new System.Windows.Forms.Button();
            this.labelWarna = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxUlangPassword
            // 
            this.textBoxUlangPassword.Location = new System.Drawing.Point(137, 315);
            this.textBoxUlangPassword.Multiline = true;
            this.textBoxUlangPassword.Name = "textBoxUlangPassword";
            this.textBoxUlangPassword.PasswordChar = '*';
            this.textBoxUlangPassword.Size = new System.Drawing.Size(203, 28);
            this.textBoxUlangPassword.TabIndex = 40;
            // 
            // labelUlangPass
            // 
            this.labelUlangPass.AutoSize = true;
            this.labelUlangPass.BackColor = System.Drawing.Color.Transparent;
            this.labelUlangPass.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUlangPass.ForeColor = System.Drawing.Color.Black;
            this.labelUlangPass.Location = new System.Drawing.Point(12, 316);
            this.labelUlangPass.Name = "labelUlangPass";
            this.labelUlangPass.Size = new System.Drawing.Size(119, 16);
            this.labelUlangPass.TabIndex = 39;
            this.labelUlangPass.Text = "Ulang Password :";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(137, 281);
            this.textBoxPassword.Multiline = true;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(203, 28);
            this.textBoxPassword.TabIndex = 38;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.BackColor = System.Drawing.Color.Transparent;
            this.labelPassword.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.ForeColor = System.Drawing.Color.Black;
            this.labelPassword.Location = new System.Drawing.Point(50, 282);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(80, 16);
            this.labelPassword.TabIndex = 37;
            this.labelPassword.Text = "Password :";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(137, 247);
            this.textBoxUsername.Multiline = true;
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(203, 28);
            this.textBoxUsername.TabIndex = 36;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.BackColor = System.Drawing.Color.Transparent;
            this.labelUsername.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.ForeColor = System.Drawing.Color.Black;
            this.labelUsername.Location = new System.Drawing.Point(50, 248);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(81, 16);
            this.labelUsername.TabIndex = 35;
            this.labelUsername.Text = "Username :";
            // 
            // textBoxGaji
            // 
            this.textBoxGaji.Location = new System.Drawing.Point(137, 213);
            this.textBoxGaji.Multiline = true;
            this.textBoxGaji.Name = "textBoxGaji";
            this.textBoxGaji.Size = new System.Drawing.Size(126, 28);
            this.textBoxGaji.TabIndex = 34;
            // 
            // labelGaji
            // 
            this.labelGaji.AutoSize = true;
            this.labelGaji.BackColor = System.Drawing.Color.Transparent;
            this.labelGaji.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGaji.ForeColor = System.Drawing.Color.Black;
            this.labelGaji.Location = new System.Drawing.Point(90, 214);
            this.labelGaji.Name = "labelGaji";
            this.labelGaji.Size = new System.Drawing.Size(40, 16);
            this.labelGaji.TabIndex = 33;
            this.labelGaji.Text = "Gaji :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.comboBoxIdJabatan);
            this.panel1.Controls.Add(this.labelIdJabatan);
            this.panel1.Controls.Add(this.dateTimePickerTglLahir);
            this.panel1.Controls.Add(this.textBoxUlangPassword);
            this.panel1.Controls.Add(this.labelUlangPass);
            this.panel1.Controls.Add(this.textBoxPassword);
            this.panel1.Controls.Add(this.labelPassword);
            this.panel1.Controls.Add(this.textBoxUsername);
            this.panel1.Controls.Add(this.textBoxAlamat);
            this.panel1.Controls.Add(this.labelUsername);
            this.panel1.Controls.Add(this.labelAlamat);
            this.panel1.Controls.Add(this.textBoxGaji);
            this.panel1.Controls.Add(this.labelGaji);
            this.panel1.Controls.Add(this.labelTglLahir);
            this.panel1.Controls.Add(this.labelNama);
            this.panel1.Controls.Add(this.textBoxNama);
            this.panel1.Controls.Add(this.textBoxId);
            this.panel1.Controls.Add(this.labelId);
            this.panel1.Location = new System.Drawing.Point(12, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(444, 368);
            this.panel1.TabIndex = 44;
            // 
            // comboBoxIdJabatan
            // 
            this.comboBoxIdJabatan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxIdJabatan.FormattingEnabled = true;
            this.comboBoxIdJabatan.Location = new System.Drawing.Point(137, 3);
            this.comboBoxIdJabatan.Name = "comboBoxIdJabatan";
            this.comboBoxIdJabatan.Size = new System.Drawing.Size(202, 21);
            this.comboBoxIdJabatan.TabIndex = 43;
            this.comboBoxIdJabatan.SelectedIndexChanged += new System.EventHandler(this.comboBoxIdJabatan_SelectedIndexChanged);
            // 
            // labelIdJabatan
            // 
            this.labelIdJabatan.AutoSize = true;
            this.labelIdJabatan.BackColor = System.Drawing.Color.Transparent;
            this.labelIdJabatan.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdJabatan.ForeColor = System.Drawing.Color.Black;
            this.labelIdJabatan.Location = new System.Drawing.Point(42, 3);
            this.labelIdJabatan.Name = "labelIdJabatan";
            this.labelIdJabatan.Size = new System.Drawing.Size(87, 16);
            this.labelIdJabatan.TabIndex = 42;
            this.labelIdJabatan.Text = "ID Jabatan :";
            // 
            // dateTimePickerTglLahir
            // 
            this.dateTimePickerTglLahir.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerTglLahir.Location = new System.Drawing.Point(138, 101);
            this.dateTimePickerTglLahir.Name = "dateTimePickerTglLahir";
            this.dateTimePickerTglLahir.Size = new System.Drawing.Size(109, 20);
            this.dateTimePickerTglLahir.TabIndex = 41;
            // 
            // textBoxAlamat
            // 
            this.textBoxAlamat.Location = new System.Drawing.Point(137, 134);
            this.textBoxAlamat.Multiline = true;
            this.textBoxAlamat.Name = "textBoxAlamat";
            this.textBoxAlamat.Size = new System.Drawing.Size(289, 73);
            this.textBoxAlamat.TabIndex = 28;
            // 
            // labelAlamat
            // 
            this.labelAlamat.AutoSize = true;
            this.labelAlamat.BackColor = System.Drawing.Color.Transparent;
            this.labelAlamat.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlamat.ForeColor = System.Drawing.Color.Black;
            this.labelAlamat.Location = new System.Drawing.Point(68, 135);
            this.labelAlamat.Name = "labelAlamat";
            this.labelAlamat.Size = new System.Drawing.Size(63, 16);
            this.labelAlamat.TabIndex = 27;
            this.labelAlamat.Text = "Alamat :";
            // 
            // labelTglLahir
            // 
            this.labelTglLahir.AutoSize = true;
            this.labelTglLahir.BackColor = System.Drawing.Color.Transparent;
            this.labelTglLahir.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTglLahir.ForeColor = System.Drawing.Color.Black;
            this.labelTglLahir.Location = new System.Drawing.Point(28, 101);
            this.labelTglLahir.Name = "labelTglLahir";
            this.labelTglLahir.Size = new System.Drawing.Size(103, 16);
            this.labelTglLahir.TabIndex = 29;
            this.labelTglLahir.Text = "Tanggal Lahir :";
            // 
            // labelNama
            // 
            this.labelNama.AutoSize = true;
            this.labelNama.BackColor = System.Drawing.Color.Transparent;
            this.labelNama.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNama.Location = new System.Drawing.Point(79, 65);
            this.labelNama.Name = "labelNama";
            this.labelNama.Size = new System.Drawing.Size(52, 16);
            this.labelNama.TabIndex = 26;
            this.labelNama.Text = "Nama :";
            // 
            // textBoxNama
            // 
            this.textBoxNama.Location = new System.Drawing.Point(137, 64);
            this.textBoxNama.Multiline = true;
            this.textBoxNama.Name = "textBoxNama";
            this.textBoxNama.Size = new System.Drawing.Size(289, 30);
            this.textBoxNama.TabIndex = 25;
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(137, 30);
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
            this.labelId.Location = new System.Drawing.Point(42, 31);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(89, 16);
            this.labelId.TabIndex = 22;
            this.labelId.Text = "ID Pegawai :";
            // 
            // buttonSimpan
            // 
            this.buttonSimpan.BackColor = System.Drawing.Color.White;
            this.buttonSimpan.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSimpan.ForeColor = System.Drawing.Color.Red;
            this.buttonSimpan.Location = new System.Drawing.Point(12, 436);
            this.buttonSimpan.Name = "buttonSimpan";
            this.buttonSimpan.Size = new System.Drawing.Size(117, 41);
            this.buttonSimpan.TabIndex = 45;
            this.buttonSimpan.Text = "SIMPAN";
            this.buttonSimpan.UseVisualStyleBackColor = false;
            this.buttonSimpan.Click += new System.EventHandler(this.buttonSimpan_Click);
            // 
            // buttonKeluar
            // 
            this.buttonKeluar.BackColor = System.Drawing.Color.White;
            this.buttonKeluar.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKeluar.ForeColor = System.Drawing.Color.Red;
            this.buttonKeluar.Location = new System.Drawing.Point(345, 436);
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
            this.buttonKosongi.Location = new System.Drawing.Point(178, 436);
            this.buttonKosongi.Name = "buttonKosongi";
            this.buttonKosongi.Size = new System.Drawing.Size(128, 41);
            this.buttonKosongi.TabIndex = 46;
            this.buttonKosongi.Text = "KOSONGI";
            this.buttonKosongi.UseVisualStyleBackColor = false;
            this.buttonKosongi.Click += new System.EventHandler(this.buttonKosongi_Click);
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
            this.labelWarna.Text = "TAMBAH PEGAWAI";
            this.labelWarna.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormTambahPegawai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(468, 482);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonSimpan);
            this.Controls.Add(this.buttonKeluar);
            this.Controls.Add(this.buttonKosongi);
            this.Controls.Add(this.labelWarna);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTambahPegawai";
            this.Text = "Tambah Pegawai";
            this.Load += new System.EventHandler(this.FormTambahPegawai_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUlangPassword;
        private System.Windows.Forms.Label labelUlangPass;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.TextBox textBoxGaji;
        private System.Windows.Forms.Label labelGaji;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelTglLahir;
        private System.Windows.Forms.TextBox textBoxAlamat;
        private System.Windows.Forms.Label labelAlamat;
        private System.Windows.Forms.Label labelNama;
        private System.Windows.Forms.TextBox textBoxNama;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Button buttonSimpan;
        private System.Windows.Forms.Button buttonKeluar;
        private System.Windows.Forms.Button buttonKosongi;
        private System.Windows.Forms.Label labelWarna;
        private System.Windows.Forms.DateTimePicker dateTimePickerTglLahir;
        private System.Windows.Forms.ComboBox comboBoxIdJabatan;
        private System.Windows.Forms.Label labelIdJabatan;
    }
}