using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace pbd_29_UbayaFriedChicken
{
    public class Kategori
    {
        #region Fields
        private string idKategori;
        private string nama;
        #endregion

        #region Constructor
        public Kategori(string idKategori, string nama)
        {
            IdKategori = idKategori;
            Nama = nama;
        }
        #endregion

        #region Properties
        public string IdKategori
        {
            get => idKategori;
            set
            {
                if (value != "")
                {
                    idKategori = value;
                }
                else
                {
                    throw (new Exception("ID Kategori tidak boleh kosong"));
                }
            }
        }
        public string Nama
        {
            get => nama;
            set
            {
                bool detect = true;
                foreach (char c in value)
                {
                    if (c < '0' || c > '9')
                        detect = false;
                    else
                    {
                        detect = true;
                        break;
                    }
                }
                if (detect == false && value != "")
                {
                    nama = value;
                }
                else
                {
                    throw (new Exception("Nama harus berupa huruf dan tidak boleh kosong"));
                }
            }
        }
        #endregion

        #region Methods
        public static void TambahData(Kategori k)
        {
            string sql = "insert into kategori(IdKategori,Nama) values('" + k.IdKategori + "','" + k.Nama.Replace("'", "\\'") + "')";
            Koneksi.JalankanPerintahDML(sql);
        }

        public static void UbahData(Kategori k)
        {
            string sql = "update kategori set Nama= '" + k.Nama.Replace("'", "\\'") + "' where IdKategori= '" + k.IdKategori + "'";
            Koneksi.JalankanPerintahDML(sql);
        }

        public static void HapusData(Kategori k)
        {
            string sql = "delete from kategori where IdKategori = '" + k.IdKategori + "'";
            Koneksi.JalankanPerintahDML(sql);
        }

        public static List<Kategori> BacaData(string k, string nk)
        {
            string sql = "";
            if (k == "")
            {
                sql = "select * from kategori";
            }
            else
            {
                sql = "select * from kategori where " + k + " like '%" + nk + "%'";
            }
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);
            List<Kategori> listKategori = new List<Kategori>();
            while (hasil.Read() == true)
            {
                Kategori kat = new Kategori(hasil.GetValue(0).ToString(), hasil.GetValue(1).ToString());
                listKategori.Add(kat);
            }
            return listKategori;
        }

        public static string GenerateKode()
        {
            string sql = "select max(IdKategori) from kategori";
            string hasilkode = "";
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);
            if (hasil.Read() == true)
            {
                int kodebaru = int.Parse(hasil.GetValue(0).ToString()) + 1;
                hasilkode = kodebaru.ToString().PadLeft(2, '0');
            }
            else
            {
                hasilkode = "01";
            }
            return hasilkode;
        }
        #endregion
    }
}