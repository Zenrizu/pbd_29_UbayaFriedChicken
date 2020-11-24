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
    public partial class FormUbahPegawai : Form
    {
        List<Pegawai> listPegawai = new List<Pegawai>();
        public FormUbahPegawai()
        {
            InitializeComponent();
        }

        private void buttonUbah_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxId.Text != "" && textBoxNama.Text != "" && textBoxAlamat.Text != "" && textBoxGaji.Text != "" && textBoxUsername.Text != "" && textBoxPassword.Text != "" && textBoxUlangPassword.Text != "")
                {
                    if (textBoxPassword.Text == textBoxUlangPassword.Text)
                    {

                        Pegawai p = new Pegawai(textBoxId.Text, textBoxNama.Text, dateTimePickerTglLahir.Value, textBoxAlamat.Text, int.Parse(textBoxGaji.Text), textBoxUsername.Text, textBoxPassword.Text, listPegawai[0].Jabatan);

                        Pegawai.UbahData(p);
                        MessageBox.Show("Data Pegawai telah terubah", "Info");
                    }
                    else
                    {
                        MessageBox.Show("Password haruslah sama", "Kesalahan");
                    }
                }
                else
                {
                    MessageBox.Show("Semua textbox harus diisi dan tidak boleh dikosongi", "Kesalahan");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Penyimpanan gagal. Pesan Kesalahan : " + ex.Message, "Kesalahan");
            }
        }

        private void buttonKosongi_Click(object sender, EventArgs e)
        {
            textBoxId.Text = "";
            textBoxNama.Text = "";
            dateTimePickerTglLahir.Value = DateTime.Now;
            textBoxAlamat.Text = "";
            textBoxGaji.Text = "";
            textBoxUsername.Text = "";
            textBoxPassword.Text = "";
            textBoxUlangPassword.Text = "";
            textBoxIdJabatan.Text = "";
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            FormDaftarPegawai formDaftarPegawai = (FormDaftarPegawai)this.Owner;
            formDaftarPegawai.FormDaftarPegawai_Load(buttonKeluar, e);
            formDaftarPegawai.Enabled = true;
            this.Close();
        }

        private void FormUbahPegawai_Load(object sender, EventArgs e)
        {
            //isi batasan karakter yang bisa diinputkan  
            textBoxId.MaxLength = 5;
            textBoxUsername.MaxLength = 20;
            dateTimePickerTglLahir.Value = DateTime.Now;
            textBoxGaji.TextAlign = HorizontalAlignment.Right;
            textBoxIdJabatan.Enabled = false;
        }

        private void textBoxId_TextChanged(object sender, EventArgs e)
        {
            listPegawai = Pegawai.BacaData("IdPegawai", textBoxId.Text);
            if (listPegawai.Count > 0)
            {
                textBoxNama.Text = listPegawai[0].Nama;
                textBoxAlamat.Text = listPegawai[0].Alamat;
                textBoxGaji.Text = (listPegawai[0].Gaji).ToString();
                textBoxUsername.Text = (listPegawai[0].Username).ToString();
                dateTimePickerTglLahir.Text = (listPegawai[0].TglLahir).ToString();
                textBoxIdJabatan.Text = listPegawai[0].Jabatan.Nama.ToString();


            }
        }
    }
}
