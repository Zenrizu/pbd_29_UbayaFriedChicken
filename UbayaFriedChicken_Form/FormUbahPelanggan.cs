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
    public partial class FormUbahPelanggan : Form
    {
        public FormUbahPelanggan()
        {
            InitializeComponent();
        }
        List<Pelanggan> listPelanggan;
        private void buttonUbah_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxId.Text != "" && textBoxNama.Text != "" && textBoxAlamat.Text != "" && textBoxSaldo.Text != "" && textBoxUsername.Text != "" && textBoxPassword.Text != "" && textBoxUlangPassword.Text != "")
                {
                    if (textBoxPassword.Text == textBoxUlangPassword.Text)
                    {

                        Pelanggan p = new Pelanggan(textBoxId.Text, textBoxNama.Text, textBoxAlamat.Text, textBoxTelepon.Text, int.Parse(textBoxSaldo.Text), textBoxUsername.Text, textBoxPassword.Text);
                        Pelanggan.UbahData(p);
                        MessageBox.Show("Data Pelanggan berhasil diubah", "Informasi");
                        buttonKosongi_Click(buttonUbah, e);
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
            catch (Exception ex)
            {
                MessageBox.Show("Perubahan gagal. Pesan Kesalahan : " + ex.Message, "Kesalahan");
            }
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
            }
        }

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

        private void FormUbahPelanggan_Load(object sender, EventArgs e)
        {
            textBoxId.MaxLength = 5;
            textBoxUsername.MaxLength = 20;
            //bikin rata kanan buat yang berhubungan dengan uang
            textBoxSaldo.TextAlign = HorizontalAlignment.Right;
            textBoxNama.Focus();
        }
    }
}
