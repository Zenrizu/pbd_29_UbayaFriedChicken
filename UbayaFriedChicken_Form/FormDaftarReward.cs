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
    public partial class FormDaftarReward : Form
    {
        public List<Reward> listReward = new List<Reward>();
        public FormDaftarReward()
        {
            InitializeComponent();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            FormTambahReward formTambahReward = new FormTambahReward();
            formTambahReward.Owner = this;
            formTambahReward.Show();
            this.Enabled = false;
        }

        private void buttonUbah_Click(object sender, EventArgs e)
        {
            FormUbahReward formUbahReward = new FormUbahReward();
            formUbahReward.Owner = this;
            formUbahReward.Show();
            this.Enabled = false;
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            FormHapusReward formHapusReward = new FormHapusReward();
            formHapusReward.Owner = this;
            formHapusReward.Show();
            this.Enabled = false;
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void FormdaftarReward_Load(object sender, EventArgs e)
        {
            FormatDataGrid();
            listReward = Reward.BacaData("", "");
            TampilDataGrid();
        }
        private void FormatDataGrid()
        {
            dataGridViewData.Columns.Clear();

            //parameter 1 nama kolom, parameter 2 nama yang muncul
            dataGridViewData.Columns.Add("IdReward", "ID Reward");
            dataGridViewData.Columns.Add("nama", "Nama");
            dataGridViewData.Columns.Add("jenis_Barang", "Jenis Barang");
            dataGridViewData.Columns.Add("batas_minimal", "Stok");
           
            dataGridViewData.Columns["IdProduk"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewData.Columns["nama"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewData.Columns["jenis_barang"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewData.Columns["batas_minimal"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            
            dataGridViewData.Columns["batas_minimal"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
         }

        private void TampilDataGrid()
        {
            dataGridViewData.Rows.Clear();

            if (listReward.Count > 0)
            {
                foreach (Reward r in listReward)
                {
                    dataGridViewData.Rows.Add(r.IdReward, r.Nama,
                        r.Jenis_barang, r.Batas_minimal);
                }
            }
            else
            {
                dataGridViewData.DataSource = null;
            }
        }

        private void textBoxCari_TextChanged(object sender, EventArgs e)
        {

            string kriteria = "";
            if (comboBoxCari.Text == "ID Reward")
            {
                kriteria = "IdReward";
            }
            else if (comboBoxCari.Text == "Nama")
            {
                kriteria = "nama";
            }
            else if (comboBoxCari.Text == "Jenis Barang")
            {
                kriteria = "jenis_barang";
            }
            else if (comboBoxCari.Text == "Batas Minimal")
            {
                kriteria = "batas_minimal";
            }

            listReward = Reward.BacaData(kriteria, textBoxCari.Text);
            TampilDataGrid();

        }

        private void labelWarna_Click(object sender, EventArgs e)
        {

        }

        private void panelWarna_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridViewData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
