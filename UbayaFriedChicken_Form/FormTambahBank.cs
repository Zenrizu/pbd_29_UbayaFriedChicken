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
    public partial class FormTambahBank : Form
    {
        public FormTambahBank()
        {
            InitializeComponent();
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxId.Text != "" && textBoxNama.Text != "")
                {
                    Bank b = new Bank(textBoxId.Text, textBoxNama.Text);
                    Bank.TambahData(b);
                    MessageBox.Show("Data Bank berhasil ditambahkan", "Informasi");
                    //kosongi data
                    buttonKosongi_Click(buttonSimpan, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menambahkan data. Pesan kesalahan : " + ex.Message, "Kesalahan");
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
            FormDaftarBank formDaftarBank = (FormDaftarBank)this.Owner;
            formDaftarBank.FormDaftarBank_Load(buttonKeluar, e);
            formDaftarBank.Enabled = true;
            this.Close();
        }

        private void FormTambahBank_Load(object sender, EventArgs e)
        {
            string kodebaru = Bank.GenerateKode();

            textBoxId.Text = kodebaru;
            textBoxId.Enabled = false;
            textBoxNama.Focus();
        }
    }
}
