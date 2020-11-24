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
    public partial class FormHapusKategori : Form
    {
        public List<Kategori> listKategori = new List<Kategori>();

        public FormHapusKategori()
        {
            InitializeComponent();
        }

        private void FormHapusKategori_Load(object sender, EventArgs e)
        {
            textBoxId.MaxLength = 2;
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            DialogResult konfirmasi = MessageBox.Show("Data kategori akan terhapus. Apakah Anda yakin ? ", "Konfirmasi", MessageBoxButtons.YesNo);

            if (konfirmasi == System.Windows.Forms.DialogResult.Yes) //jika user yakin menghapus data
            {
                Kategori k = new Kategori(textBoxId.Text, textBoxNama.Text);
                Kategori.HapusData(k);
                MessageBox.Show("Data kategori berhasil dihapus", "Informasi");
            }
            else
            {
                MessageBox.Show("Data kategori tidak jadi dihapus", "Informasi");
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

        private void textBoxId_TextChanged(object sender, EventArgs e)
        {
            if (textBoxId.Text.Length == textBoxId.MaxLength)
            {
                listKategori = Kategori.BacaData("IdKategori", textBoxId.Text);
                if (listKategori.Count > 0)
                {
                    textBoxNama.Text = listKategori[0].Nama;
                    textBoxNama.Enabled = false;
                    buttonHapus.Focus();
                }
                else
                {
                    MessageBox.Show("ID Kategori tidak ditemukan", "Kesalahan");
                    textBoxNama.Text = "";
                }
            }
        }
    }
}
