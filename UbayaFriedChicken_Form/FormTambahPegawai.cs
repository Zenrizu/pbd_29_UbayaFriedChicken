using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pbd_29_UbayaFriedChicken;

namespace form
{
    public partial class FormTambahPegawai : Form
    {
        List<Jabatan> listJabatan = new List<Jabatan>();
        public FormTambahPegawai()
        {
            InitializeComponent();
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                //dapatkan objek jabatan dari comboBox
                Jabatan jabatanDipilih = (Jabatan)comboBoxIdJabatan.SelectedItem;
                if (textBoxPassword.Text == textBoxUlangPassword.Text)
                {
                    Pegawai p = new Pegawai(textBoxId.Text, textBoxNama.Text, dateTimePickerTglLahir.Value, textBoxAlamat.Text, int.Parse(textBoxGaji.Text), textBoxUsername.Text, textBoxPassword.Text, jabatanDipilih);

                    Pegawai.TambahData(p);
                    MessageBox.Show("Data Pegawai berhasil ditambahkan", "Informasi");
                    //kosongi data
                    buttonKosongi_Click(buttonSimpan, e);
                }
                else
                {
                    MessageBox.Show("Password haruslah sama", "Kesalahan");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menambahkan data. Pesan kesalahan : " + ex.Message, "Kesalahan");
            }
        }

        private void buttonKosongi_Click(object sender, EventArgs e)
        {
            textBoxNama.Text = "";
            dateTimePickerTglLahir.Value = DateTime.Now;
            textBoxAlamat.Text = "";
            textBoxGaji.Text = "";
            textBoxUsername.Text = "";
            textBoxPassword.Text = "";
            textBoxUlangPassword.Text = "";
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            FormDaftarPegawai formDaftarPegawai = (FormDaftarPegawai)this.Owner;
            formDaftarPegawai.FormDaftarPegawai_Load(buttonKeluar, e);
            formDaftarPegawai.Enabled = true;
            this.Close();
        }

        private void FormTambahPegawai_Load(object sender, EventArgs e)
        {
            //isi batasan karakter yang bisa diinputkan  
            textBoxId.MaxLength = 5;
            textBoxUsername.MaxLength = 20;
            dateTimePickerTglLahir.Value = DateTime.Now;

            //bikin rata kanan buat yang berhubungan dengan uang
            textBoxGaji.TextAlign = HorizontalAlignment.Right;

            //baca data dari tabel jabatan dan generate otomatis
            listJabatan = Jabatan.BacaData("", "");
            //lalu tampilkan semua jabatan ke combobox
            comboBoxIdJabatan.DataSource = listJabatan;
            comboBoxIdJabatan.DisplayMember = "Nama";
            comboBoxIdJabatan.DropDownStyle = ComboBoxStyle.DropDownList;

            //generate code supaya bisa langsung terisi otomatis jadi pegawai tidak perlu mengisi secara manual
            Jabatan jabatanDipilih = (Jabatan)comboBoxIdJabatan.SelectedItem;
            string kodePegawai = Pegawai.GenerateKode(jabatanDipilih);
            //lalu masukan kode yang sudah di generate ke dlm textboxidpegawai
            textBoxId.Text = kodePegawai;
            
            textBoxNama.Focus();
        }

        private void comboBoxIdJabatan_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxId.Enabled = true;
            //generate code supaya bisa langsung terisi otomatis jadi pegawai tidak perlu mengisi secara manual
            Jabatan jabatanDipilih = (Jabatan)comboBoxIdJabatan.SelectedItem;
            string kodePegawai = Pegawai.GenerateKode(jabatanDipilih);
            //lalu masukan kode yang sudah di generate ke dlm textboxidpegawai
            textBoxId.Text = kodePegawai;
            textBoxNama.Focus();
            textBoxId.Enabled = false;
        }
    }
}
