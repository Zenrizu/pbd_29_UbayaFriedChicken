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
    public partial class FormUbahKategori : Form
    {
        public FormUbahKategori()
        {
            InitializeComponent();
        }
        List<Kategori> listKategori;
        private void textBoxId_TextChanged(object sender, EventArgs e)
        {
            if (textBoxId.Text.Length == textBoxId.MaxLength)
            {
                 listKategori = Kategori.BacaData("IdKategori", textBoxId.Text);
                if (listKategori.Count > 0)
                {
                    textBoxNama.Text = listKategori[0].Nama;
                    textBoxNama.Focus();
                }
                else
                {
                    MessageBox.Show("ID Kategori tidak ditemukan", "Kesalahan");
                    textBoxNama.Text = "";
                }
            }
        }

        private void FormUbahKategori_Load(object sender, EventArgs e)
        {
            textBoxId.MaxLength = 2;
        }

        private void buttonUbah_Click(object sender, EventArgs e)
        {
            try
            {
                Kategori k = new Kategori(textBoxId.Text, textBoxNama.Text);

                Kategori.UbahData(k);

                MessageBox.Show("Data kategori telah diubah.", "Info");
            }
            catch (Exception exc)
            {
                MessageBox.Show("Pengubahan gagal. Pesan kesalahan : " + exc.Message, "Kesalahan");
            }

        }

        private void buttonKosongi_Click(object sender, EventArgs e)
        {
            textBoxId.Text = "";
            textBoxNama.Text = "";
            textBoxId.Focus();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            FormDaftarKategori formDaftarKategori = (FormDaftarKategori)this.Owner;
            formDaftarKategori.FormDaftarKategori_Load(buttonKeluar, e);
            formDaftarKategori.Enabled = true;
            this.Close();
        }
    }
}
