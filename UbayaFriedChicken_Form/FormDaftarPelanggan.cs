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
    public partial class FormDaftarPelanggan : Form
    {
        public List<Pelanggan> listPelanggan = new List<Pelanggan>();
        public FormDaftarPelanggan()
        {
            InitializeComponent();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            FormTambahPelanggan form = new FormTambahPelanggan();
            form.Owner = this;
            form.Show();
            this.Enabled = false;
        }

        private void buttonUbah_Click(object sender, EventArgs e)
        {
            FormUbahPelanggan form = new FormUbahPelanggan();
            form.Owner = this;
            form.Show();
            this.Enabled = false;
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            FormHapusPelanggan form = new FormHapusPelanggan();
            form.Owner = this;
            form.Show();
            this.Enabled = false;
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FormatDataGrid()
        {
            dataGridViewData.Columns.Clear();
            //menambah data di dataGridView
            dataGridViewData.Columns.Add("IdPelanggan", "ID Pelanggan");
            dataGridViewData.Columns.Add("Nama", "Nama");
            dataGridViewData.Columns.Add("Alamat", "Alamat");
            dataGridViewData.Columns.Add("Telepon", "Telepon");
            dataGridViewData.Columns.Add("Saldo", "Saldo");
            dataGridViewData.Columns.Add("Username", "Username");

            dataGridViewData.Columns["IdPelanggan"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewData.Columns["Nama"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewData.Columns["Alamat"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewData.Columns["Telepon"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
           
            dataGridViewData.Columns["Saldo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewData.Columns["Username"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            
        }
        public void FormDaftarPelanggan_Load(object sender, EventArgs e)
        { 
            listPelanggan = Pelanggan.BacaData("", "");
            FormatDataGrid();
            IsiDataGrid();
        }
        private void IsiDataGrid()
        {
            if (listPelanggan.Count > 0)
            {
                //kosongi dulu data grid view
                dataGridViewData.Rows.Clear();
                foreach (Pelanggan p in listPelanggan)
                {
                    //menambahkan data barang satu-persatu ke datagridview
                    dataGridViewData.Rows.Add(p.IdPelanggan, p.Nama, p.Alamat, p.Telepon, p.Saldo, p.Username); ;
                }
            }
            else
            {
                dataGridViewData.DataSource = null;
            }
        }
        private void textBoxCari_TextChanged(object sender, EventArgs e)
        {
            if (comboBoxCari.SelectedIndex == 0)
            {

                listPelanggan = Pelanggan.BacaData("idpelanggan", textBoxCari.Text);
            }
            else if (comboBoxCari.SelectedIndex == 1)
            {
                listPelanggan = Pelanggan.BacaData("nama", textBoxCari.Text);
            }
            else if (comboBoxCari.SelectedIndex == 2)
            {
                listPelanggan = Pelanggan.BacaData("alamat", textBoxCari.Text);
            }
            else if (comboBoxCari.SelectedIndex == 3)
            {
                listPelanggan = Pelanggan.BacaData("telepon", textBoxCari.Text);
            }
            else if (comboBoxCari.SelectedIndex == 4)
            {
                listPelanggan = Pelanggan.BacaData("username", textBoxCari.Text);
            }
            else if (comboBoxCari.SelectedIndex == 5)
            {
                listPelanggan = Pelanggan.BacaData("password", textBoxCari.Text);
            }
            FormatDataGrid();
            IsiDataGrid();
        }
    }
}
