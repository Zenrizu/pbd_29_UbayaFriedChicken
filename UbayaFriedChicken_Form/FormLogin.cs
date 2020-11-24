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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            this.Height = panelLogin.Height;
            this.BringToFront();
            
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxUsername.Text != "")
                {
                    if (textBoxServer.Text != "" && textBoxDatabase.Text != "")
                    {
                        string server = textBoxServer.Text;
                        string database = textBoxDatabase.Text;
                        string user = textBoxUsername.Text;
                        string pass = textBoxPassword.Text;

                        Koneksi koneksi = new Koneksi(server, database, user, pass);
                        MessageBox.Show("Koneksi berhasil. Selamat menggunakan aplikasi", "Informasi");

                        FormUtama formUtama = (FormUtama)this.Owner;
                        formUtama.Enabled = true;
                        formUtama.ubahNama(textBoxUsername.Text);

                        
                        
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Nama server dan nama database harus diisi", "Kesalahan");
                    }
                }
                else
                {
                    MessageBox.Show("Nama username harus diisi", "Kesalahan");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Koneksi gagal. Pesan kesalahan :" + exc.Message, "Kesalahan");
            }

        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            if (textBoxServer.Text != "" && textBoxDatabase.Text != "")
            {
                this.Height = panelLogin.Height;
            }
            else
            {
                MessageBox.Show("Nama server dan nama database tidak boleh dikosongi", "Kesalahan");
            }
        }

        private void linkLabelPengaturan_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Height = 50 + panelLogin.Height + panelPengaturan.Height;
        }
    }
}
