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
    public partial class FormDaftarProduk : Form
    {
        public FormDaftarProduk()
        {
            InitializeComponent();
        }

        public List<Produk> listProduk = new List<Produk>();

        public void FormDaftarProduk_Load(object sender, EventArgs e)
        {
            FormatDataGrid();
            listProduk = Produk.BacaData("", "");
            TampilDataGrid();
        }

        private void textBoxCari_TextChanged(object sender, EventArgs e)
        {
            string kriteria = "";
            if (comboBoxCari.Text == "ID Produk")
            {
                kriteria = "p.IdProduk";
            }
            else if (comboBoxCari.Text == "Nama")
            {
                kriteria = "p.Nama";
            }
            else if (comboBoxCari.Text == "Harga Jual")
            {
                kriteria = "p.HargaJual";
            }
            else if (comboBoxCari.Text == "Stok")
            {
                kriteria = "p.Stok";
            }
            else if (comboBoxCari.Text == "Kode Kategori")
            {
                kriteria = "p.KodeKategori";
            }
            else if (comboBoxCari.Text == "Nama Kategori")
            {
                kriteria = "k.Nama";
            }

            listProduk = Produk.BacaData(kriteria, textBoxCari.Text);
            TampilDataGrid();

        }

        private void FormatDataGrid()
        {
            dataGridViewData.Columns.Clear();

            //parameter 1 nama kolom, parameter 2 nama yang muncul
            dataGridViewData.Columns.Add("IdProduk", "ID Produk");
            dataGridViewData.Columns.Add("Nama", "Nama");
            dataGridViewData.Columns.Add("HargaJual", "Harga Jual");
            dataGridViewData.Columns.Add("Stok", "Stok");
            dataGridViewData.Columns.Add("KodeKategori", "Kode Kategori");
            dataGridViewData.Columns.Add("NamaKategori", "Nama Kategori");

            dataGridViewData.Columns["IdProduk"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewData.Columns["Nama"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewData.Columns["HargaJual"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewData.Columns["Stok"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewData.Columns["KodeKategori"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewData.Columns["NamaKategori"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dataGridViewData.Columns["HargaJual"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewData.Columns["Stok"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dataGridViewData.Columns["HargaJual"].DefaultCellStyle.Format = "#,###";
        }

        private void TampilDataGrid()
        {
            dataGridViewData.Rows.Clear();

            if (listProduk.Count > 0)
            {
                foreach (Produk p in listProduk)
                {
                    dataGridViewData.Rows.Add(p.IdProduk, p.Nama,
                        p.HargaJual, p.Stok, p.Kategori.IdKategori, p.Kategori.Nama);
                }
            }
            else
            {
                dataGridViewData.DataSource = null;
            }
        }


        private void buttonTambah_Click(object sender, EventArgs e)
        {
            FormTambahProduk formTambahProduk = new FormTambahProduk();
            formTambahProduk.Owner = this;
            formTambahProduk.Show();
            this.Enabled = false;
        }

        private void buttonUbah_Click(object sender, EventArgs e)
        {
            FormUbahProduk formUbahProduk = new FormUbahProduk();
            formUbahProduk.Owner = this;
            formUbahProduk.Show();
            this.Enabled = false;
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            FormHapusProduk formHapusProduk = new FormHapusProduk();
            formHapusProduk.Owner = this;
            formHapusProduk.Show();
            this.Enabled = false;
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
