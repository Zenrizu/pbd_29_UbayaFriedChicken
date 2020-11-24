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
    public partial class FormTambahProduk : Form
    {

        List<Kategori> listKategori = new List<Kategori>();

        public FormTambahProduk()
        {
            InitializeComponent();
        }

        private void FormTambahProduk_Load(object sender, EventArgs e)
        {
            listKategori = Kategori.BacaData("", "");

            comboBoxIdKategori.DataSource = listKategori;
            comboBoxIdKategori.DisplayMember = "Nama";
            
            textBoxId.MaxLength = 5;
            textBoxNama.MaxLength = 45;

            comboBoxIdKategori.DropDownStyle = ComboBoxStyle.DropDownList;

            textBoxId.Text = "";
            textBoxNama.Text = "";
            textBoxHargaJual.Text = "";
            textBoxStok.Text = "";
            

            textBoxHargaJual.TextAlign = HorizontalAlignment.Right;
            textBoxStok.TextAlign = HorizontalAlignment.Right;

        }

        private void comboBoxIdKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxIdKategori.SelectedIndex != -1)
                {
                    Kategori kategoriDipilih = (Kategori)comboBoxIdKategori.SelectedItem;
                    string kodeTerbaru = Produk.GenerateKode(kategoriDipilih);
                    textBoxId.Text = kodeTerbaru;
                    textBoxId.Enabled = false;
                    textBoxNama.Focus();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Gagal melakukan generate kode. Pesan kesalahan : " + exc.Message, "Kesalahan");
            }
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
        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                Kategori kategoriDipilih = (Kategori)comboBoxIdKategori.SelectedItem;

                Produk p = new Produk(textBoxId.Text, textBoxNama.Text,
                                     int.Parse(textBoxHargaJual.Text), int.Parse(textBoxStok.Text), kategoriDipilih);
                Produk.TambahData(p);
                ClearTextBoxes();
                FormTambahProduk_Load(buttonSimpan, e);
                MessageBox.Show("Data produk berhasil ditambahkan", "Informasi");
            }
            catch (Exception exc)
            {
                MessageBox.Show("Data produk gagal ditambahkan. Pesan kesalahan : " + exc.Message, "Kesalahan");
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
