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
    public partial class FormDaftarKategori : Form
    {
        public List<Kategori> listKategori = new List<Kategori>();

        public FormDaftarKategori()
        {
            InitializeComponent();
        }

        public void FormDaftarKategori_Load(object sender, EventArgs e)
        {
            listKategori = Kategori.BacaData("", "");
            if (listKategori.Count > 0)
            {
                dataGridViewData.DataSource = listKategori;
            }
            else
            {
                dataGridViewData.DataSource = null;
            }
        }

        private void textBoxCari_TextChanged(object sender, EventArgs e)
        {
            if (comboBoxCari.Text == "ID Kategori")
            {
                listKategori = Kategori.BacaData("IdKategori", textBoxCari.Text);
            }
            else if (comboBoxCari.Text == "Nama")
            {
                listKategori = Kategori.BacaData("Nama", textBoxCari.Text);
            }

            //jika listKategori sudah terisi data
            if (listKategori.Count > 0)
            {
                dataGridViewData.DataSource = listKategori;
            }
            else
            {
                dataGridViewData.DataSource = null;
            }

        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            FormTambahKategori formTambahKategori = new FormTambahKategori();
            formTambahKategori.Owner = this;
            formTambahKategori.Show();
            this.Enabled = false;
        }

        private void buttonUbah_Click(object sender, EventArgs e)
        {
            FormUbahKategori formUbahKategori = new FormUbahKategori();
            formUbahKategori.Owner = this;
            formUbahKategori.Show();
            this.Enabled = false;
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            FormHapusKategori formHapusKategori = new FormHapusKategori();
            formHapusKategori.Owner = this;
            formHapusKategori.Show();
            this.Enabled = false;
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
