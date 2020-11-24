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
    public partial class FormUbahReward : Form
    {
        List<Reward> listReward;
        public FormUbahReward()
        {
            InitializeComponent();
        }

        private void buttonUbah_Click(object sender, EventArgs e)
        {
            try
            {
                Reward r = new Reward(textBoxId.Text, textBoxNama.Text,textBoxJenisBarang.Text , int.Parse(textBoxBatasMinimal.Text));

                Reward.UbahData(r);

                MessageBox.Show("Data reward telah diubah.", "Info");
            }
            catch (Exception exc)
            {
                MessageBox.Show("Pengubahan gagal. Pesan kesalahan : " + exc.Message, "Kesalahan");
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

        private void FormUbahReward_Load(object sender, EventArgs e)
        {
            textBoxId.MaxLength = 2;
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
