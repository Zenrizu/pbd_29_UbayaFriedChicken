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
    public partial class FormUbahProduk : Form
    {
        public FormUbahProduk()
        {
            InitializeComponent();
        }
        List<Produk> listProduk = new List<Produk>();
       
        private void FormUbahProduk_Load(object sender, EventArgs e)
        {
            textBoxId.MaxLength = 5;
        }

        private void textBoxId_TextChanged(object sender, EventArgs e)
        {
            if (textBoxId.TextLength == textBoxId.MaxLength)
            {
                listProduk = Produk.BacaData("IdProduk", textBoxId.Text);
                if (listProduk.Count() > 0)
                {
                    textBoxIdKategori.Text = listProduk[0].Kategori.Nama;
                    textBoxNama.Text = listProduk[0].Nama;
                    textBoxHargaJual.Text = listProduk[0].HargaJual.ToString();
                    textBoxStok.Text = listProduk[0].Stok.ToString();

                    textBoxIdKategori.Enabled = false;

                }
                else
                {
                    MessageBox.Show("Data produk tidak ditemukan", "Kesalahan");
                    textBoxNama.Text = "";
                    textBoxHargaJual.Text = "";
                    textBoxStok.Text = "";
                    textBoxIdKategori.Text = "";
                }
            }
        }

        private void buttonUbah_Click(object sender, EventArgs e)
        {
            try
            {
                Produk p = new Produk(textBoxId.Text, textBoxNama.Text, int.Parse(textBoxHargaJual.Text),
                    int.Parse(textBoxStok.Text), listProduk[0].Kategori);
                Produk.UbahData(p);
                MessageBox.Show("Data produk telah diubah", "Info");
            }
            catch (Exception exc)
            {
                MessageBox.Show("Pengubahan gagal. Pesan Kesalahan : " + exc.Message, "Kesalahan");
            }

        }

        private void buttonKosongi_Click(object sender, EventArgs e)
        {
            textBoxId.Text = "";
            textBoxNama.Text = "";
            textBoxHargaJual.Text = "";
            textBoxStok.Text = "";
            textBoxId.Focus();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            FormDaftarProduk formDaftarProduk = (FormDaftarProduk)this.Owner;
            formDaftarProduk.FormDaftarProduk_Load(buttonKeluar, e);
            formDaftarProduk.Enabled = true;
            this.Close();
        }
    }
}
