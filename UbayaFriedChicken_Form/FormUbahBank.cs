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
    public partial class FormUbahBank : Form
    {
        public FormUbahBank()
        {
            InitializeComponent();
        }
        List<Bank> listBank;

        private void buttonUbah_Click(object sender, EventArgs e)
        {
            if (textBoxId.Text != "" && textBoxNama.Text != "")
            {
                Bank b = new Bank(textBoxId.Text, textBoxNama.Text);
                Bank.UbahData(b);
                MessageBox.Show("Data Bank berhasil diubah", "Informasi");
                //kosongi data
                buttonKosongi_Click(buttonUbah, e);
            }
        }

        private void buttonKosongi_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
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

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            FormDaftarBank formDaftarBank =  (FormDaftarBank) this.Owner;
            formDaftarBank.FormDaftarBank_Load(buttonKeluar, e);
            formDaftarBank.Enabled = true;
            this.Close();
        }

        private void textBoxId_TextChanged(object sender, EventArgs e)
        {
            listBank = Bank.BacaData("IdBank", textBoxId.Text);
            if (listBank.Count > 0)
            {
                textBoxNama.Text = listBank[0].Nama;
            }
        }
    }
}
