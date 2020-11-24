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
    public partial class FormHapusPegawai : Form
    {
        List<Pegawai> listPegawai = new List<Pegawai>();
        public FormHapusPegawai()
        {
            InitializeComponent();
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxId.Text != "" && textBoxNama.Text != "" && textBoxAlamat.Text != "" && textBoxGaji.Text != "" && textBoxUsername.Text != "")
                {
                    DialogResult konfirmasi = MessageBox.Show("Data pegawai akan terhapus. Apakah anda yakin ? ", "Konfirmasi", MessageBoxButtons.YesNo);
                    if (konfirmasi == System.Windows.Forms.DialogResult.Yes)
                    {

                        Pegawai p = new Pegawai(textBoxId.Text, textBoxNama.Text, dateTimePickerTglLahir.Value, textBoxAlamat.Text, int.Parse(textBoxGaji.Text), textBoxUsername.Text, textBoxPassword.Text, listPegawai[0].Jabatan);

                        Pegawai.HapusData(p);
                        MessageBox.Show("Data Pegawai telah terhapus", "Info");
                    }
                    else
                    {
                        MessageBox.Show("Data pegawai tidak jadi dihapus", "Informasi");
                    }
                }
                else
                {
                    MessageBox.Show("Semua data tidak boleh dikosongi", "Kesalahan");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Penghapusan gagal. Pesan Kesalahan : " + ex.Message, "Kesalahan");
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

        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            FormDaftarPegawai formDaftarPegawai = (FormDaftarPegawai)this.Owner;
            formDaftarPegawai.FormDaftarPegawai_Load(buttonKeluar, e);
            formDaftarPegawai.Enabled = true;
            this.Close();
        }

        private void FormHapusPegawai_Load(object sender, EventArgs e)
        {
            textBoxNama.Enabled = false;
            textBoxAlamat.Enabled = false;
            textBoxGaji.Enabled = false;
            textBoxUsername.Enabled = false;
            textBoxJabatan.Enabled = false;
            dateTimePickerTglLahir.Enabled = false;
            textBoxPassword.Enabled = false;
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
                textBoxJabatan.Text = listPegawai[0].Jabatan.Nama.ToString();


            }
        }
    }
}
