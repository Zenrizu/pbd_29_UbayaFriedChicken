using pbd_29_UbayaFriedChicken;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form
{
    public partial class FormHapusPelanggan : Form
    {
        public FormHapusPelanggan()
        {
            InitializeComponent();
        }
        List<Pelanggan> listPelanggan;
        private void buttonKosongi_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }
        private void ClearTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {

            FormDaftarPelanggan formDaftarPelanggan = (FormDaftarPelanggan)this.Owner;
            formDaftarPelanggan.FormDaftarPelanggan_Load(buttonKeluar, e);
            formDaftarPelanggan.Enabled = true;
            this.Close();
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxId.Text != "" && textBoxNama.Text != "" && textBoxAlamat.Text != "" && textBoxSaldo.Text != "" && textBoxUsername.Text != "" && textBoxPassword.Text != "")
                {
                    DialogResult konfirmasi = MessageBox.Show("Data Barang akan terhapus. Apakah anda yakin ? ", "Konfirmasi", MessageBoxButtons.YesNo);
                    if (konfirmasi == System.Windows.Forms.DialogResult.Yes)
                    {
                        Pelanggan p = new Pelanggan(textBoxId.Text, textBoxNama.Text, textBoxAlamat.Text, textBoxTelepon.Text, int.Parse(textBoxSaldo.Text), textBoxUsername.Text, textBoxPassword.Text);
                        Pelanggan.HapusData(p);
                        MessageBox.Show("Data Pelanggan berhasil dihapus", "Informasi");
                        buttonKosongi_Click(buttonHapus, e);
                    }
                    else
                    {
                        MessageBox.Show("Data pelanggan tidak jadi dihapus", "Informasi");
                    }
                }
                else
                {
                    MessageBox.Show("Semua textbox harus diisi dan tidak boleh dikosongi", "Kesalahan");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Perubahan gagal. Pesan Kesalahan : " + ex.Message, "Kesalahan");
            }
        }

        private void FormHapusPelanggan_Load(object sender, EventArgs e)
        {
            textBoxId.MaxLength = 5;
            textBoxUsername.Enabled = false;
            textBoxNama.Enabled = false;
            textBoxPassword.Enabled = false;
            textBoxAlamat.Enabled = false;
            textBoxTelepon.Enabled = false;
            textBoxSaldo.Enabled = false;
            textBoxSaldo.TextAlign = HorizontalAlignment.Right;
        }

        private void textBoxId_TextChanged(object sender, EventArgs e)
        {

            listPelanggan = Pelanggan.BacaData("IdPelanggan", textBoxId.Text);
            if (listPelanggan.Count > 0)
            {
                textBoxNama.Text = listPelanggan[0].Nama;
                textBoxAlamat.Text = listPelanggan[0].Alamat;
                textBoxTelepon.Text = listPelanggan[0].Telepon;
                textBoxSaldo.Text = listPelanggan[0].Saldo.ToString();
                textBoxUsername.Text = listPelanggan[0].Username;
                textBoxPassword.Text = listPelanggan[0].Password;
            }
        }
    }
}
