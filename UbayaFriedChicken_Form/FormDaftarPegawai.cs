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
    public partial class FormDaftarPegawai : Form
    {
        List<Pegawai> listPegawai = new List<Pegawai>();
        public FormDaftarPegawai()
        {
            InitializeComponent();
        }
        private void IsiDataGrid()
        {
            if (listPegawai.Count > 0)
            {
                //kosongi dulu data grid view
                dataGridViewList.Rows.Clear();
                foreach (Pegawai p in listPegawai)
                {
                    //menambahkan data barang satu-persatu ke datagridview
                    dataGridViewList.Rows.Add(p.IdPegawai, p.Nama, p.TglLahir, p.Alamat, p.Gaji, p.Username, p.Jabatan.IdJabatan);
                }
            }
            else
            {
                dataGridViewList.DataSource = null;
            }
        }
        private void FormatDataGrid()
        {
            //menambah data di dataGridView
            dataGridViewList.Columns.Add("IdPegawai", "ID Pegawai");
            dataGridViewList.Columns.Add("Nama", "Nama");
            dataGridViewList.Columns.Add("TglLahir", "Tanggal Lahir");
            dataGridViewList.Columns.Add("Alamat", "Alamat");
            dataGridViewList.Columns.Add("Gaji", "Gaji");
            dataGridViewList.Columns.Add("Username", "Username");
            dataGridViewList.Columns.Add("IdJabatan", "ID Jabatan");

            //mengatur allignmnent
            dataGridViewList.Columns["TglLahir"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewList.Columns["Gaji"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            //agar harga jual ditampilkan dengan pemisah ribuan
            dataGridViewList.Columns["Gaji"].DefaultCellStyle.Format = "#,###";
            dataGridViewList.Columns["TglLahir"].DefaultCellStyle.Format = "dd/MM/yyyy";
            //agar lebar kolom mengikuti text/isi otomatis
            dataGridViewList.Columns["IdPegawai"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewList.Columns["Nama"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewList.Columns["TglLahir"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewList.Columns["Alamat"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewList.Columns["Gaji"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewList.Columns["Username"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewList.Columns["IdJabatan"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }
        public void FormDaftarPegawai_Load(object sender, EventArgs e)
        { 
            dataGridViewList.Columns.Clear();
            FormatDataGrid();
            comboBoxCari.SelectedIndex = 0;
            listPegawai = Pegawai.BacaData("", "");
            IsiDataGrid();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            FormTambahPegawai formTambahPegawai = new FormTambahPegawai();
            formTambahPegawai.Owner = this;
            formTambahPegawai.Show();
            this.Enabled = false;
        }

        private void buttonUbah_Click(object sender, EventArgs e)
        {
            FormUbahPegawai formUbahPegawai = new FormUbahPegawai();
            formUbahPegawai.Owner = this;
            formUbahPegawai.Show();
            this.Enabled = false;
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            FormHapusPegawai formHapusPegawai = new FormHapusPegawai();
            formHapusPegawai.Owner = this;
            formHapusPegawai.Show();
            this.Enabled = false;
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxCari_TextChanged(object sender, EventArgs e)
        {
            if (comboBoxCari.Text == "ID Pegawai")
            {
                listPegawai = Pegawai.BacaData("IdPegawai", textBoxCari.Text);
            }
            else if (comboBoxCari.Text == "Nama")
            {
                listPegawai = Pegawai.BacaData("Nama", textBoxCari.Text);
            }
            else if (comboBoxCari.Text == "Tgl Lahir")
            {
                listPegawai = Pegawai.BacaData("TglLahir", textBoxCari.Text);
            }
            else if (comboBoxCari.Text == "Gaji")
            {
                listPegawai = Pegawai.BacaData("Gaji", textBoxCari.Text);
            }
            else if (comboBoxCari.Text == "Alamat")
            {
                listPegawai = Pegawai.BacaData("Alamat", textBoxCari.Text);
            }
            else if (comboBoxCari.Text == "Username")
            {
                listPegawai = Pegawai.BacaData("Username", textBoxCari.Text);
            }
            else if (comboBoxCari.Text == "ID Jabatan")
            {
                listPegawai = Pegawai.BacaData("IdJabatan", textBoxCari.Text);
            }

            IsiDataGrid();
        }
    }
}
