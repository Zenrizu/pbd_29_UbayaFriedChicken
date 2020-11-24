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
    public partial class FormUtama : Form
    {
        public FormUtama()
        {
            InitializeComponent();
        }
        
        public void ubahNama(string nama)
        {
            labelNamaUser.Text = nama;
        }

        private void FormUtama_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.IsMdiContainer = true;
            this.Enabled = false;
            
            /*
            //mencoba koneksi
            try
            {
                Koneksi koneksi = new Koneksi("localhost", "si_jual_beli", "root","");
                MessageBox.Show("Koneksi berhasil", "Informasi");
            }
            catch (Exception exc)
            {
                MessageBox.Show( "Koneksi gagal. Pesan kesalahan :"+exc.Message);
            }
            */

            FormLogin formLogin = new FormLogin();
            formLogin.Owner = this; //bukan termasuk midChild
            formLogin.Show();
            




        }

        private void kategoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormDaftarKategori"];
            if (form == null)
            {
                FormDaftarKategori formDaftarKategori = new FormDaftarKategori();
                formDaftarKategori.MdiParent = this;
                formDaftarKategori.Show();
            }
            else
            {
                form.Show();
                form.BringToFront();
            }

        }

        private void produkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormDaftarProduk"];
            if (form == null)
            {
                FormDaftarProduk formDaftarProduk = new FormDaftarProduk();
                formDaftarProduk.MdiParent = this;
                formDaftarProduk.Show();
            }
            else
            {
                form.Show();
                form.BringToFront();
            }

        }

        private void pelangganToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormDaftarPelanggan"];
            if (form == null)
            {
                FormDaftarPelanggan formDaftarPelanggan = new FormDaftarPelanggan();
                formDaftarPelanggan.MdiParent = this;
                formDaftarPelanggan.Show();
            }
            else
            {
                form.Show();
                form.BringToFront();
            }
        }

        private void pegawaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormDaftarPegawai"];
            if (form == null)
            {
                FormDaftarPegawai formDaftarPegawai = new FormDaftarPegawai();
                formDaftarPegawai.MdiParent = this;
                formDaftarPegawai.Show();
            }
            else
            {
                form.Show();
                form.BringToFront();
            }
        }

        private void jabatanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormDaftarJabatan"];
            if (form == null)
            {
                FormDaftarJabatan formDaftarJabatan = new FormDaftarJabatan();
                formDaftarJabatan.MdiParent = this;
                formDaftarJabatan.Show();
            }
            else
            {
                form.Show();
                form.BringToFront();
            }
        }

        private void bankToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormDaftarBank"];
            if (form == null)
            {
                FormDaftarBank formDaftarBank = new FormDaftarBank();
                formDaftarBank.MdiParent = this;
                formDaftarBank.Show();
            }
            else
            {
                form.Show();
                form.BringToFront();
            }
        }

        private void promoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void keluarSistemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void masterToolStripMenuItem_DropDownOpened(object sender, EventArgs e)
        {
            menuStripMenu.ForeColor = Color.Black;
        }

        private void masterToolStripMenuItem_DropDownClosed(object sender, EventArgs e)
        {
            menuStripMenu.ForeColor = Color.White;
        }
    }
}
