using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace pbd_29_UbayaFriedChicken
{
    public class Produk
    {
        #region Fields
        private string idProduk;
        private string nama;
        private int hargaJual;
        private int stok;
        private Kategori kategori;
        #endregion

        #region Constructor
        public Produk(string idProduk, string nama, int hargaJual, int stok, Kategori kategori)
        {
            IdProduk = idProduk;
            Nama = nama;
            HargaJual = hargaJual;
            Stok = stok;
            Kategori = kategori;
        }
        #endregion

        #region Properties
        public string IdProduk
        {
            get => idProduk;
            set
            {
                if (value != "")
                {
                    idProduk = value;
                }
                else
                {
                    throw (new Exception("ID Produk tidak boleh kosong"));
                }
            }
        }
        public string Nama
        {
            get => nama;
            set
            {
                if (value != "")
                {
                    nama = value;
                }
                else
                {
                    throw (new Exception("Nama Produk tidak boleh kosong"));
                }
            }
        }
        public int HargaJual
        {
            get => hargaJual;
            set
            {
                if (value != 0)
                {
                    hargaJual = value;
                }
                else
                {
                    throw (new Exception("Harga Jual tidak boleh kosong"));
                }
            }
        }
        public int Stok
        {
            get => stok;
            set
            {
                if (value != 0)
                {
                    stok = value;
                }
                else
                {
                    throw (new Exception("Stok tidak boleh kosong"));
                }
            }
        }
        public Kategori Kategori { get => kategori; set => kategori = value; }
        #endregion

        #region Methods
        public static void TambahData(Produk p)
        {
            string sql = "insert into produk(IdProduk,Nama,HargaJual,Stok,IdKategori) values('" + p.IdProduk + "','" + p.Nama.Replace("'", "\\'") + "','" + p.HargaJual +
                "','" + p.Stok + "','" + p.Kategori.IdKategori + "')";
            Koneksi.JalankanPerintahDML(sql);
        }

        public static void UbahData(Produk p)
        {
            string sql = "update produk set Nama= '" + p.Nama.Replace("'", "\\'") + "', HargaJual = '" + p.HargaJual + "', stok = '" + p.Stok + "', IdKategori = '" + p.Kategori.IdKategori
                + "' where IdProduk = '" + p.IdProduk + "'";
            Koneksi.JalankanPerintahDML(sql);
        }
        public static void HapusData(Produk p)
        {
            string sql = "delete from produk where IdProduk = '" + p.IdProduk + "'";
            Koneksi.JalankanPerintahDML(sql);
        }

        public static List<Produk> BacaData(string k, string nk)
        {
            string sql = "";
            if (k == "")
            {
                sql = "select p.IdProduk, p.Nama as 'Nama Produk', p.HargaJual, p.Stok, p.IdKategori, k.Nama as 'Nama Kategori'" +
                    " from produk p inner join kategori k on p.IdKategori = k.IdKategori";
            }
            else
            {
                sql = "select p.IdProduk, p.Nama as 'Nama Produk', p.HargaJual, p.Stok, p.IdKategori, k.Nama as 'Nama Kategori'" +
                    "from produk p inner join kategori k on p.IdKategori = k.IdKategori where " + k + " like '%" + nk + "%'";
            }
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);
            List<Produk> listProduk = new List<Produk>();
            while (hasil.Read() == true)
            {
                Kategori kat = new Kategori(hasil.GetValue(4).ToString(), hasil.GetValue(5).ToString());
                Produk p = new Produk(hasil.GetValue(0).ToString(), hasil.GetValue(1).ToString(), int.Parse(hasil.GetValue(2).ToString()),
                    int.Parse(hasil.GetValue(3).ToString()), kat);
                listProduk.Add(p);
            }
            return listProduk;
        }

        public static string GenerateKode(Kategori k)
        {
            string sql = "select max(right(IdProduk,3)) from Produk where IdKategori = '" + k.IdKategori + "'";

            string hasilKode = "";

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);
            if (hasil.Read() == true)
            {
                if (hasil.GetValue(0).ToString() != "")
                {
                    int kodeTerbaru = int.Parse(hasil.GetValue(0).ToString()) + 1;
                    hasilKode = k.IdKategori + kodeTerbaru.ToString().PadLeft(3, '0');
                }
                else
                {
                    hasilKode = k.IdKategori + "001";
                }
            }
            return hasilKode;
        }
        public static void UpdateStock(string jenisTransaksi, string idProduk, int jumlahTransaksi)
        {
            string sql = "";
            if (jenisTransaksi == "penjualan")
            {
                //mengurangi stok produk tertentu sesuai jumlah yang terjual
                sql = "update produk set Stok=Stok-" + jumlahTransaksi +
                    " where IdProduk='" + idProduk + "'";
            }
            else if (jenisTransaksi == "pembelian")
            {
                //menambah stok produk tertentu sesuai jumlah yang terjual
                sql = "update produk set Stok=Stok+" + jumlahTransaksi +
                    " where IdProduk='" + idProduk + "'";
            }
            Koneksi.JalankanPerintahDML(sql);
        }
        #endregion
    }
}