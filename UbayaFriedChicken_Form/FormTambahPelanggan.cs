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
    public partial class FormTambahPelanggan : Form
    {
        public FormTambahPelanggan()
        {
            InitializeComponent();
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxPassword.Text == textBoxUlangPassword.Text)
                {
                    Pelanggan p = new Pelanggan(textBoxId.Text, textBoxNama.Text, textBoxAlamat.Text, textBoxTelepon.Text, int.Parse(textBoxSaldo.Text), textBoxUsername.Text, textBoxPassword.Text);
                    Pelanggan.TambahData(p);
                    MessageBox.Show("Data Pelanggan berhasil ditambahkan", "Informasi");
                    buttonKosongi_Click(buttonSimpan, e);
                }
                else
                {
                    MessageBox.Show("Password haruslah sama", "Kesalahan");
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

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            FormDaftarPelanggan formDaftarPelanggan =  (FormDaftarPelanggan) this.Owner;
            formDaftarPelanggan.FormDaftarPelanggan_Load(buttonKeluar, e);
            formDaftarPelanggan.Enabled = true;
            this.Close();
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

        private void FormTambahPelanggan_Load(object sender, EventArgs e)
        {
            textBoxId.MaxLength = 5;
            textBoxUsername.MaxLength = 20;           
            textBoxSaldo.TextAlign = HorizontalAlignment.Right;
            string kodePelanggan = Pelanggan.GenerateKode();
            //lalu masukan kode yang sudah di generate ke dlm textboxidpegawai
            textBoxId.Text = kodePelanggan;
            textBoxId.Enabled = false;
            textBoxNama.Focus();
        }
    }
}
