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
    public partial class FormHapusProduk : Form
    {
        List<Produk> listProduk = new List<Produk>();
        

        public FormHapusProduk()
        {
            InitializeComponent();
        }

        private void FormHapusProduk_Load(object sender, EventArgs e)
        {
            textBoxId.MaxLength = 5;
            //disabled texbox
            textBoxKategori.Enabled = false;
            textBoxNama.Enabled = false;
            textBoxHargaJual.Enabled = false;
            textBoxStok.Enabled = false;
        }

        private void textBoxId_TextChanged(object sender, EventArgs e)
        {
            if (textBoxId.TextLength == textBoxId.MaxLength)
            {
                listProduk = Produk.BacaData("IdProduk", textBoxId.Text);
                if (listProduk.Count() > 0)
                {
                    textBoxKategori.Text = listProduk[0].Kategori.Nama;
                    textBoxNama.Text = listProduk[0].Nama;
                    textBoxHargaJual.Text = listProduk[0].HargaJual.ToString();
                    textBoxStok.Text = listProduk[0].Stok.ToString();
                }
                else
                {
                    MessageBox.Show("Data produk tidak ditemukan", "Kesalahan");
                    textBoxId.Text = "";
                    textBoxNama.Text = "";
                    textBoxHargaJual.Text = "";
                    textBoxStok.Text = "";
                    textBoxKategori.Text = "";
                }
            }

        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            DialogResult konfirm = MessageBox.Show("Data barang akan terhapus. Apakah Anda yakin ?", "Konfirmasi", MessageBoxButtons.YesNo);
            if (konfirm == System.Windows.Forms.DialogResult.Yes)
            {
                Produk p = new Produk(textBoxId.Text, textBoxNama.Text,
                     int.Parse(textBoxHargaJual.Text), int.Parse(textBoxStok.Text), listProduk[0].Kategori);
                Produk.HapusData(p);
                MessageBox.Show("Produk telah dihapus.", "Informasi");
                textBoxId.Text = "";
                textBoxNama.Text = "";
                textBoxHargaJual.Text = "";
                textBoxStok.Text = "";
                textBoxKategori.Text = "";
                textBoxId.Focus();
            }
            else
            {
                MessageBox.Show("Produk tidak jadi dihapus", "Informasi");
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
            FormDaftarProduk formDaftarProduk = (FormDaftarProduk) this.Owner;
            formDaftarProduk.FormDaftarProduk_Load(buttonKeluar, e);
            formDaftarProduk.Enabled = true;
            this.Close();
        }
    }
}
