using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pbd_29_UbayaFriedChicken;

namespace UbayaFriedChicken_Form
{
    public partial class FormTambahReward : Form
    {
        public FormTambahReward()
        {
            InitializeComponent();
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                Reward r = new Reward(textBoxId.Text, textBoxNama.Text, textBoxJenisBarang.Text, int.Parse(textBoxBatasMinimal.Text));
                Reward.TambahData(r);
                MessageBox.Show("Data reward telah tersimpan.", "Info");
            }
            catch (Exception exc)
            {
                MessageBox.Show("Penyimpanan gagal. Pesan Kesalahan : " + exc.Message, "Kesalahan");
            }

        }

        private void buttonKosongi_Click(object sender, EventArgs e)
        {
            textBoxNama.Text = "";
            textBoxJenisBarang.Text = "";
            textBoxBatasMinimal.Text = "";    
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            FormDaftarReward formdaftarReward = (FormDaftarReward)this.Owner;
            formdaftarReward.FormdaftarReward_Load(buttonKeluar, e);
            formdaftarReward.Enabled = true;
            this.Close();

        }

        private void FormTambahReward_Load(object sender, EventArgs e)
        {
            string kodebaru = Reward.GenerateKode();

            textBoxId.Text = kodebaru;
            textBoxId.Enabled = false;
            textBoxNama.Focus();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelWarna_Click(object sender, EventArgs e)
        {

        }
    }
}
