using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pbd_29_UbayaFriedChicken
{
    public class TopUp
    {
        #region Data Members
        private string idTransaksi;
        private int jumlah;
        private Bank bank;
        private Pelanggan pelanggan;
        #endregion

        #region Constructor
        public TopUp(Bank bank, Pelanggan pelanggan, string idTransaksi, int jumlah)
        {
            Bank = bank;
            Pelanggan = pelanggan;
            IdTransaksi = idTransaksi;
            Jumlah = jumlah;
        }
        #endregion

        #region Properties
   



        public string IdTransaksi { get => idTransaksi; set => idTransaksi = value; }
        public int Jumlah { get => jumlah; set => jumlah = value; }
       
        public Pelanggan Pelanggan { get => pelanggan; set => pelanggan = value; }

        public Bank Bank
        {
            get => default;
            set => bank = value;
  
        }

        #endregion

        #region Methods


        public static void TambahData(TopUp t)
        {
            string sql = "insert into TopUp(IdTransaksi,Jumlah,IdPelanngan,IdBank) values ('" +
                         t.IdTransaksi + "','" + t.Jumlah + "','" + t.IdTransaksi + "','" + t.IdTransaksi + "','" + "')";
            Koneksi.JalankanPerintahDML(sql);
        }

        public static void UbahData(TopUp t)
        {
            string sql = "update transaksi set IdTopUp= '" + t.IdTransaksi + "', Jumlah= '" + t.Jumlah + "', IdPelanggan= '" +
                        t.Pelanggan.IdPelanggan  + "', IdBank= '" + t.Bank.IdBank+ "' where IdTransaksi='" + t.IdTransaksi + "'";

            Koneksi.JalankanPerintahDML(sql);
        }

        public static void HapusData(TopUp t)
        {
            string sql = "delete from TopUp where IdTransaksi = '" + t.IdTransaksi + "'";
            Koneksi.JalankanPerintahDML(sql);
        }
        public static List<TopUp> BacaData(string kriteria, string nilaiKriteria)
        {
            string sql = "";
            if (kriteria == "")
            {
                sql = "Select * from transaksi";
            }
            else
            {
                sql = "Select * From transaksi where " + kriteria + " like '%" + nilaiKriteria + "%' ";
            }
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            List<TopUp> listTopUp = new List<TopUp>();
            while (hasil.Read() == true)
            {
                Bank b = new Bank(hasil.GetValue(2).ToString(), hasil.GetValue(3).ToString());
                Pelanggan p = new Pelanggan(hasil.GetValue(4).ToString(), hasil.GetValue(5).ToString(), hasil.GetValue(6).ToString(), hasil.GetValue(7).ToString(),int.Parse(hasil.GetValue(7).ToString()), hasil.GetValue(8).ToString(),hasil.GetValue(9).ToString());
                TopUp t = new TopUp(b,p,hasil.GetValue(0).ToString(),int.Parse(hasil.GetValue(1).ToString()));
                listTopUp.Add(t);

            }
            return listTopUp;
        }

        public static string GenerateKode()
        {
            string sql = "select max(IdTransaksi) from transaksi";
            string hasilKode;
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);
            if (hasil.Read() == true)
            {
                int kodeAwal = int.Parse(hasil.GetValue(0).ToString()) + 1;
                hasilKode = kodeAwal.ToString().PadLeft(2, '0');
            }
            else
            {
                hasilKode = "01";
            }
            return hasilKode;
        }

        #endregion
    }
}