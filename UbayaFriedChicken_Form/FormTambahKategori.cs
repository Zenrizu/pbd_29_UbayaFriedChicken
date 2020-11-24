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
    public partial class FormTambahKategori : Form
    {
        public FormTambahKategori()
        {
            InitializeComponent();
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                Kategori k = new Kategori(textBoxId.Text, textBoxNama.Text);
                Kategori.TambahData(k);
                MessageBox.Show("Data Kategori telah tersimpan.", "Info");
            }
            catch (Exception exc)
            {
                MessageBox.Show("Penyimpanan gagal. Pesan Kesalahan : " + exc.Message, "Kesalahan");
            }

        }

        private void buttonKosongi_Click(object sender, EventArgs e)
        {
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

        private void FormTambahKategori_Load(object sender, EventArgs e)
        {
            string kodebaru = Kategori.GenerateKode();

            textBoxId.Text = kodebaru;
            textBoxId.Enabled = false;
            textBoxNama.Focus();
        }
    }
}
