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

namespace UbayaFriedChicken_Form
{
    public partial class FormDaftarNotaJual : Form
    {
        List<NotaJual> listNotaJual = new List<NotaJual>();
        string kriteria = "";

        public FormDaftarNotaJual()
        {
            InitializeComponent();
        }

        public void buttonTambah_Click(object sender, EventArgs e)
        {
            FormTambahNotaJual formTambahNotaJual = new FormTambahNotaJual();
            formTambahNotaJual.Owner = this;
            formTambahNotaJual.Show();
            this.Enabled = false;
        }

        private void FormDaftarNotaJual_Load(object sender, EventArgs e)
        {
            //panggil method untuk menambah kolom pada datagridview
            FormatDataGrid();

            //tampilkan semua data nota jual
            listNotaJual = NotaJual.BacaData("", "");

            //tampilkan semua isi listNotaJual di datagridview (panggil method TampilDataGrid)
            TampilDataGrid();
        }

        private void FormatDataGrid()
        {
            //kosongi semua kolom di datagridview
            dataGridViewData.Columns.Clear();

            //menambah kolom di datagridview
            dataGridViewData.Columns.Add("IdNota", "Id Nota");
            dataGridViewData.Columns.Add("Tanggal", "Tanggal");
            dataGridViewData.Columns.Add("IdPelanggan", "Id Pelanggan");
            dataGridViewData.Columns.Add("NamaPelanggan", "Nama Pelanggan");
            dataGridViewData.Columns.Add("AlamatPelanggan", "Alamat Pelanggan");
            dataGridViewData.Columns.Add("IdPegawai", "Id Pegawai");
            dataGridViewData.Columns.Add("NamaPegawai", "Nama Pegawai");
            dataGridViewData.Columns.Add("IdProduk", "Id Produk");
            dataGridViewData.Columns.Add("NamaProduk", "Nama Produk");
            dataGridViewData.Columns.Add("Harga", "Harga");
            dataGridViewData.Columns.Add("Jumlah", "Jumlah");

            dataGridViewData.Columns["IdNota"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewData.Columns["Tanggal"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewData.Columns["IdPelanggan"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewData.Columns["NamaPelanggan"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewData.Columns["AlamatPelanggan"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewData.Columns["IdPegawai"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewData.Columns["NamaPegawai"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewData.Columns["IdProduk"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewData.Columns["NamaProduk"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewData.Columns["Harga"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewData.Columns["Jumlah"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            //agar harga dan jumlah rata kanan
            dataGridViewData.Columns["Harga"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewData.Columns["Jumlah"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            //agar harga ditampilkan dengan format pemisah ribuan 
            dataGridViewData.Columns["Harga"].DefaultCellStyle.Format = "#,###";

            //agar datagridview tidak bisa diganti oleh user
            dataGridViewData.AllowUserToAddRows = false;
            dataGridViewData.ReadOnly = true;
        }

        private void TampilDataGrid()
        {
            //kosongi isi datagridview
            dataGridViewData.Rows.Clear();

            //jika listNotaJual terisi data
            if (listNotaJual.Count > 0)
            {
                //tampilkan semua isi listNotaJual di datagridview
                foreach (NotaJual n in listNotaJual)
                {
                    foreach (NotaJualDetil njd in n.ListNotaJualDetil)
                    {
                        dataGridViewData.Rows.Add(n.IdNota, n.Tanggal, n.Pelanggan.IdPelanggan, n.Pelanggan.Nama, n.Pelanggan.Alamat,
                                                    n.Pegawai.IdPegawai, n.Pegawai.Nama, njd.Produk.IdProduk, njd.Produk.Nama, njd.Harga, njd.Jumlah);
                    }
                }
            }
            else
            {
                dataGridViewData.DataSource = null;
            }
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxCari_TextChanged(object sender, EventArgs e)
        {
            if (comboBoxCari.Text == "No Nota")
            {
                kriteria = "n.NoNota";
            }
            else if (comboBoxCari.Text == "Tanggal")
            {
                kriteria = "n.Tanggal";
            }
            else if (comboBoxCari.Text == "Kode Pelanggan")
            {
                kriteria = "n.KodePelanggan";
            }
            else if (comboBoxCari.Text == "Nama Pelanggan")
            {
                kriteria = "plg.Nama";
            }
            else if (comboBoxCari.Text == "Alamat Pelanggan")
            {
                kriteria = "plg.Alamat";
            }
            else if (comboBoxCari.Text == "Kode Pegawai")
            {
                kriteria = "n.KodePegawai";
            }
            else if (comboBoxCari.Text == "Nama Pegawai")
            {
                kriteria = " p.Nama";
            }
            /*
            else if (comboBoxCari.Text == "Kode Barang")
            {
                kriteria = "njd.KodeBarang";
            }
            else if (comboBoxCari.Text == "Nama Barang")
            {
                kriteria = "b.Nama";
            }
            else if (comboBoxCari.Text == "Harga")
            {
                kriteria = "njd.Harga";
            }
            else if (comboBoxCari.Text == "Jumlah")
            {
                kriteria = "njd.Jumlah";
            }
            */
            listNotaJual = NotaJual.BacaData(kriteria, textBoxCari.Text);
            TampilDataGrid();
        }

        private void buttonCetak_Click(object sender, EventArgs e)
        {
            //cetak nota jual yang memenuhi kriteria pencarian user
            //simpan di file dengan nama daftar nota jual txt
            NotaJual.CetakNota(kriteria, textBoxCari.Text, "daftar_nota_jual.txt", new Font("Courier New", 12));
        }

        private void FormDaftarNotaJual_Load_1(object sender, EventArgs e)
        {

        }
    }
}
