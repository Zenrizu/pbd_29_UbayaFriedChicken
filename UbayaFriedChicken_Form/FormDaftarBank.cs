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
    public partial class FormDaftarBank : Form
    {
        public FormDaftarBank()
        {
            InitializeComponent();
        }
        List<Bank> listBank;
        private void buttonTambah_Click(object sender, EventArgs e)
        {
            FormTambahBank form = new FormTambahBank();
            form.Owner = this;
            form.Show();
            this.Enabled = false;
        }

        private void buttonUbah_Click(object sender, EventArgs e)
        {
            FormUbahBank form = new FormUbahBank();
            form.Owner = this;
            form.Show();
            this.Enabled = false;
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            FormHapusBank form = new FormHapusBank();
            form.Owner = this;
            form.Show();
            this.Enabled = false;
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void FormDaftarBank_Load(object sender, EventArgs e)
        {
             listBank = Bank.BacaData("", "");
            if (listBank.Count > 0)
            {
                dataGridViewData.DataSource = listBank;
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

                listBank = Bank.BacaData("IdBank", textBoxCari.Text);
            }
            else if (comboBoxCari.SelectedIndex == 1)
            {
                listBank = Bank.BacaData("Nama", textBoxCari.Text);
            }

            if (listBank.Count > 0)
            {
                dataGridViewData.DataSource = listBank;
            }
            else
            {
                dataGridViewData.DataSource = null;
            }
        }
    }
}
