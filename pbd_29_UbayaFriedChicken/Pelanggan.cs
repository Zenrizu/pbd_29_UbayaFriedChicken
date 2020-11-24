using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Transactions;

namespace pbd_29_UbayaFriedChicken
{
    public class Pelanggan
    {
        #region Fields
        private string idPelanggan;
        private string nama;
        private string alamat;
        private string telepon;
        private int saldo;
        private string username;
        private string password;
        private List<TopUp> listTopUp;


        #endregion

        #region Constructors
        public Pelanggan(string idPelanggan, string nama, string alamat, string telepon, int saldo, string username, string password)
        {
            IdPelanggan = idPelanggan;
            Nama = nama;
            Alamat = alamat;
            Telepon = telepon;
            Username = username;
            Password = password;
            Saldo = saldo;
            ListTopUp = new List<TopUp>();
        }
        #endregion

        #region Properties
        public string IdPelanggan { get => idPelanggan; set => idPelanggan = value; }
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
        public string Alamat { get => alamat; set => alamat = value; }
        public string Telepon { get => telepon; set => telepon = value; }
        public int Saldo
        {
            get => saldo;
            set
            {
                if (value >= 0)
                    saldo = value;
                else
                    throw new ArgumentException("Saldo tidak bisa 0 atau lebih kecil dari 0");
            }
        }

        public string Username
        {
            get => username;
            set
            {

                if (value != "")
                    username = value;
                else
                    throw new ArgumentException("Username harus diisi!");
            }
        }
        public string Password
        {
            get => password;
            set
            {
                if (value != "")
                    password = value;
                else
                    throw new ArgumentException("Password harus diisi!");
            }
        }

        public List<TopUp> ListTopUp { get => listTopUp; set => listTopUp = value; }

        #endregion

        #region Methods
        public void TambahSaldo(Bank bank, Pelanggan pelanggan, string idTransaksi, int jumlah)
        {
            TopUp topup = new TopUp(bank, pelanggan, idTransaksi, jumlah);
            ListTopUp.Add(topup)
; }
        public static void UpdateSaldo(string jenisTransaksi, string idPelanggan, int jumlahTransaksi, string IdBank)
        {
            string sql = "";
            if (jenisTransaksi == "Transfer")
            {
                sql = "update pelanggan set Saldo=Saldo-" + jumlahTransaksi +
                    " where IdPelanggan='" + idPelanggan + "'";
            }
            else if (jenisTransaksi == "Isi")
            {
                sql = "update produk set Saldo=Saldo+" + jumlahTransaksi +
                    " where IdPelanggan='" + idPelanggan + "'";
            }
            Koneksi.JalankanPerintahDML(sql);
        } 
        public static void TambahData(Pelanggan p)
        {
            using (TransactionScope transScope = new TransactionScope())
            {
                try
                {
                    string sql = "insert into pelanggan(IdPelanggan,Nama,Alamat,Telepon,Saldo,Username,Password) values ('" + p.IdPelanggan + "','"
                      + p.Nama.Replace("'", "\\'") + "','" + p.Alamat + "','" + p.Telepon + "','" + p.Saldo + "','" + p.Username + "','" + p.Password + "')";
                    Koneksi.JalankanPerintahDML(sql);
                    foreach (TopUp t in p.ListTopUp)
                    {
                        string sql2 = "insert into TopUp(IdTransaksi,Jumlah,IdPelanngan,IdBank) values ('" +
                        t.IdTransaksi + "','" + t.Jumlah + "','" + t.IdTransaksi + "','" + t.IdTransaksi + "','" + "')";
                        Koneksi.JalankanPerintahDML(sql2);
                        UpdateSaldo("Isi", p.idPelanggan, t.Jumlah, t.Bank.IdBank);
                    }
                }
                catch (Exception exc)
                {
                    transScope.Dispose();
                    throw (new Exception(exc.Message));
                }
            }  
                
        }

        public static void UbahData(Pelanggan p)
        {
            string sql = "update pelanggan set Nama= '" + p.Nama.Replace("'", "\\'") + "', Alamat= '" + p.Alamat + "', Telepon= '" +
                        p.Telepon + "', Saldo= '" +
                        p.Saldo + "', Username= '" + p.Username  + "', Password= '"+ p.Password +  "' where IdPelanggan='" + p.IdPelanggan + "'";

            Koneksi.JalankanPerintahDML(sql);
        }

        public static void HapusData(Pelanggan p)
        {
            string sql = "delete from pelanggan where IdPelanggan = '" + p.IdPelanggan + "'";
            Koneksi.JalankanPerintahDML(sql);
        }
        public static List<Pelanggan> BacaData(string kriteria, string nilaiKriteria)
        {
            string sql = "";
            if (kriteria == "")
            {
                sql = "Select * from pelanggan";
            }
            else
            {
                sql = "Select * From pelanggan where " + kriteria + " like '%" + nilaiKriteria + "%' ";
            }
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            List<Pelanggan> listPelanggan = new List<Pelanggan>();
            while (hasil.Read() == true)
            {
                Pelanggan p = new Pelanggan
                    (hasil.GetValue(0).ToString(), hasil.GetValue(1).ToString(),
                    hasil.GetValue(2).ToString(), hasil.GetValue(3).ToString(), int.Parse(hasil.GetValue(4).ToString()), hasil.GetValue(5).ToString(),hasil.GetValue(6).ToString());
                listPelanggan.Add(p);

            }
            return listPelanggan;
        }

        public  static string GenerateKode()
        {
            string sql = "select max(IdPelanggan) from pelanggan";
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