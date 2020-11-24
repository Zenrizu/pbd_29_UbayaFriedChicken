using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing.Printing;
using System.Drawing;

namespace pbd_29_UbayaFriedChicken
{
    class Cetak
    {
        #region Fields
        private Font jenisFont; // menyimpan nama dan ukuran font yang digunakan untuk mencetak ke printer
        private StreamReader fileCetak; //menyimpan file stream berisi tulisan yang akan dibaca dan dicetak ke printer
        private float marginKiri, marginKanan, marginAtas, marginBawah; //menyimpan margin kertas
        #endregion

        #region Constructors
        public Cetak(string namaFile, Font jenisFont, float marginKiri, float marginKanan,
            float marginAtas, float marginBawah)
        {
            this.FileCetak = new StreamReader(namaFile);
            this.JenisFont = jenisFont;
            this.MarginKiri = marginKiri;
            this.MarginKanan = marginKanan;
            this.MarginAtas = marginAtas;
            this.MarginBawah = marginBawah;
        }
        #endregion

        #region Properties
        public Font JenisFont { get => jenisFont; set => jenisFont = value; }
        public StreamReader FileCetak { get => fileCetak; set => fileCetak = value; }
        public float MarginKiri { get => marginKiri; set => marginKiri = value; }
        public float MarginKanan { get => marginKanan; set => marginKanan = value; }
        public float MarginAtas { get => marginAtas; set => marginAtas = value; }
        public float MarginBawah { get => marginBawah; set => marginBawah = value; }
        #endregion

        #region Methods
        private void CetakTulisan(object sender, PrintPageEventArgs e)
        {
            //hitung jumlah baris maksimal uang dapat ditampilkan pada halaman 1 kertas
            int jumBarisPerHalaman = (int)((e.MarginBounds.Height - MarginBawah - MarginAtas) / jenisFont.GetHeight(e.Graphics));

            //untuk menyimpan posisis y terakhir tulisan yang telah tercetak
            float y = MarginAtas;

            //untuk menyimpan jumlah baris tulisan yang telah tercetak
            int jumBaris = 0;

            //untuk menyimpan tulisan yang akan dicetak
            string tulisanCetak = FileCetak.ReadLine();

            //baca filestream untuk mencetak tiap baris tulisan
            while (jumBaris < jumBarisPerHalaman && tulisanCetak != null)
            {
                y = MarginAtas + (jumBaris * jenisFont.GetHeight(e.Graphics));

                //cetak tulisan sesuai jenis font dan margin (warna tulisan hitam)
                e.Graphics.DrawString(tulisanCetak, JenisFont, Brushes.Black, MarginKiri, y);

                //jumlah baris tercetak ditambah 1
                jumBaris++;

                //baca baris file berikutnya
                tulisanCetak = FileCetak.ReadLine();
            }
            //jika masih belum selesai mencetak, cetak di halaman berikutnya
            if (tulisanCetak != null)
            {
                e.HasMorePages = true;
            }
            else
            {
                e.HasMorePages = false;
            }
        }

        public void CetakKePrinter(string pTipe)
        {
            //buat tobjek untuk mencetak
            PrintDocument p = new PrintDocument();

            //jika tipe yang akan dicetak adalah teks dan tulisan
            if (pTipe == "text")
            {
                //tambahkan event handler untuk mencetak tulisan
                p.PrintPage += new PrintPageEventHandler(CetakTulisan);
            }

            //cetak tulisan
            p.Print();

            FileCetak.Close();
        }
        #endregion

    }
}
