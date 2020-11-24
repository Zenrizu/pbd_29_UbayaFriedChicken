using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pbd_29_UbayaFriedChicken
{
    public class Bank
    {
        #region Fields
        private string idBank;
        private string nama;
        #endregion

        #region Constructors
        public Bank(string idBank, string nama)
        {
            this.IdBank = idBank;
            this.Nama = nama;
        }

        #endregion

        #region Properties
        public string IdBank { get => idBank; set => idBank = value; }
        public string Nama 
        { get => nama;
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
        public static void TambahData(Bank b)
        {
            string sql = "insert into Bank(IdBank,nama)" +
                "values ('" + b.IdBank + "','" + b.Nama.Replace("'", "\\'")  + "')";
            Koneksi.JalankanPerintahDML(sql);
        }

        public static void UbahData(Bank b)
        {
            string sql = "update bank set Nama= '" + b.Nama.Replace("'", "\\'") + "' where IdBank= '" + b.IdBank + "' ";
            Koneksi.JalankanPerintahDML(sql);
        }

        public static void HapusData(Bank b)
        {
            string sql = "delete from bank where IdBank= '" + b.IdBank + "'";
            Koneksi.JalankanPerintahDML(sql);
        }

        public static List<Bank> BacaData(string kriteria, string nilaiKriteria)
        {
            string sql = "";
            if (kriteria == "")
            {
                sql = "Select * from bank";
            }
            else
            {
                sql = "Select * From bank where " + kriteria + " like '%" + nilaiKriteria + "%' ";
            }
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            List<Bank> listBank = new List<Bank>();
            while (hasil.Read() == true)
            {
                Bank b = new Bank
                    (hasil.GetValue(0).ToString(), hasil.GetValue(1).ToString());
                listBank.Add(b);

            }
            return listBank;
        }

        public static string GenerateKode()
        {
            string sql = "select max(IdBank) from bank";
            string hasilKode = "";
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);
            if (hasil.Read() == true)
            {
                if (hasil.GetValue(0).ToString() != "")
                {
                    int kodeAwal = int.Parse(hasil.GetValue(0).ToString()) + 1;
                    hasilKode = kodeAwal.ToString().PadLeft(2, '0');
                }
                else
                {
                    hasilKode = "01";
                }
            }
            return hasilKode;
        }
        #endregion

    }
}