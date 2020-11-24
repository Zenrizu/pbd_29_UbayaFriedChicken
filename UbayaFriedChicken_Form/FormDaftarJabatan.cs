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
    public partial class FormDaftarJabatan : Form
    {
        public FormDaftarJabatan()
        {
            InitializeComponent();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        List<Jabatan> listJabatan = new List<Jabatan>();
        private void FormDaftarJabatan_Load(object sender, EventArgs e)
        {
            listJabatan = Jabatan.BacaData("", "");
            comboBoxCari.SelectedIndex = 0;
            if (listJabatan.Count > 0)
            {
                dataGridViewData.DataSource = listJabatan;
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
                listJabatan = Jabatan.BacaData("IdJabatan", textBoxCari.Text);
            }
            else if (comboBoxCari.SelectedIndex == 1)
            {
                listJabatan = Jabatan.BacaData("Nama", textBoxCari.Text);
            }

            if (listJabatan.Count > 0)
            {
                dataGridViewData.DataSource = listJabatan;
            }
            else
            {
                dataGridViewData.DataSource = null;
            }
        }
    }
}
