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
    public partial class FormHapusReward : Form
    {
        List<Reward> listReward;
        public FormHapusReward()
        {
            InitializeComponent();
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            DialogResult konfirmasi = MessageBox.Show("Data reward akan dihapus. Apakah Anda yakin ? ", "Konfirmasi", MessageBoxButtons.YesNo);

            if (konfirmasi == System.Windows.Forms.DialogResult.Yes) //jika user yakin menghapus data
            {
                Reward r = new Reward(textBoxId.Text, textBoxNama.Text, textBoxJenisBarang.Text, int.Parse(textBoxBatasMinimal.Text));
                Reward.HapusData(r);
                MessageBox.Show("Data reward berhasil dihapus", "Informasi");
            }
            else
            {
                MessageBox.Show("Data reward tidak jadi dihapus", "Informasi");
            }
        }

        private void buttonKosongi_Click(object sender, EventArgs e)
        {
            textBoxNama.Text = "";
            textBoxJenisBarang.Text = "";
            textBoxBatasMinimal.Text = "";
            textBoxId.Text = "";    
            textBoxId.Focus();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            FormDaftarReward formdaftarReward = (FormDaftarReward)this.Owner;
            formdaftarReward.FormdaftarReward_Load(buttonKeluar, e);
            formdaftarReward.Enabled = true;
            this.Close();
        }

        private void FormHapusReward_Load(object sender, EventArgs e)
        {
            textBoxId.MaxLength = 2;
            textBoxJenisBarang.Enabled = false;
            textBoxBatasMinimal.Enabled = false;
            textBoxNama.Enabled = false;
        }

        private void textBoxId_TextChanged(object sender, EventArgs e)
        {
            if (textBoxId.Text.Length == textBoxId.MaxLength)
            {
                listReward = Reward.BacaData("IdReward", textBoxId.Text);
                if (listReward.Count > 0)
                {
                    textBoxNama.Text = listReward[0].Nama;
                    textBoxJenisBarang.Text = listReward[0].Jenis_barang;
                    textBoxBatasMinimal.Text = listReward[0].Batas_minimal.ToString();
                    textBoxNama.Focus();
                }
                else
                {
                    MessageBox.Show("ID Reward tidak ditemukan", "Kesalahan");
                    textBoxNama.Text = "";
                }
            }
        }
    }
}
