using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pbd_29_UbayaFriedChicken
{
    public class Pegawai
    {

        #region Pegawai
        private string idPegawai;
        private string nama;
        private DateTime tglLahir;
        private string alamat;
        private int gaji;
        private string username;
        private string password;
        private Jabatan jabatan;
        #endregion

        #region Construction
        public Pegawai(string idPegawai, string nama, DateTime tglLahir, string alamat, int gaji, string username, string password, Jabatan jabatan)
        {
            Jabatan = jabatan;
            IdPegawai = idPegawai;
            Nama = nama;
            TglLahir = tglLahir;
            Alamat = alamat;
            Gaji = gaji;
            Username = username;
            Password = password;
        }
        #endregion

        #region Properties
        public string IdPegawai { get => idPegawai; set => idPegawai = value; }
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
        public DateTime TglLahir
        { get => tglLahir; 
            set
            {
                if (value < DateTime.Now)
                    tglLahir = value;
                else
                    throw (new Exception("Isi Tanggal Lahir salah"));
            } 
        }
        public string Alamat { get => alamat; set => alamat = value; }
        public int Gaji
        {
            get => gaji;
            set
            {
                if (value >= 0)
                    gaji = value;
                else
                    throw new ArgumentException("Gaji tidak bisa 0 atau lebih kecil dari 0");
            }
        }
        public string Username { get => username; set => username = value; }
        public string Password { private get => password; set => password = value; }
        public Jabatan Jabatan { get => jabatan; set => jabatan = value; }
        #endregion

        #region Method
        public static void TambahData(Pegawai p)
        {
            string sql = "Insert into Pegawai(IdPegawai , Nama, TglLahir, Alamat, Gaji, Username, password, IdJabatan ) values('" + p.IdPegawai +
                "','" + p.Nama.Replace("\\'", "") + "','" + p.TglLahir.ToString("yyyyMMdd") + "','" + p.Alamat + "','" + p.Gaji + "','" + p.Username + "','" + p.Password + "','" + p.Jabatan.IdJabatan + "')";
            Koneksi.JalankanPerintahDML(sql);
            string perintah = "tambah";
            ManajemenUser(p, perintah);
        }

        public static void UbahData(Pegawai p)
        {
            string sql = "Update Pegawai set Nama='" + p.Nama.Replace("\\'", "") + "', TglLahir='" + p.TglLahir.ToString("yyyyMMdd") +
                "', Alamat='" + p.Alamat + "', Gaji='" + p.Gaji + "', Username='" + p.Username + "', Password='" + p.Password + "', Jabatan='" + p.Jabatan.IdJabatan + "' where IdPegawai='" + p.IdPegawai + "'";
            Koneksi.JalankanPerintahDML(sql);
            string perintah = "ubah";
            ManajemenUser(p, perintah);
        }

        public static void HapusData(Pegawai p)
        {
            string sql = "Delete from Pegawai where IdPegawai ='" + p.IdPegawai + "'";
            Koneksi.JalankanPerintahDML(sql);
            string perintah = "hapus";
            ManajemenUser(p, perintah);
        }
        public static List<Pegawai> BacaData(string kriteria, string nilaiKriteria)
        {
            string sql = "";
            if (kriteria == "")
            {
                sql = "select p.IdPegawai, p.Nama, p.TglLahir, p.Alamat, p.Gaji, p.Username, p.Password, j.IdJabatan, j.Nama as 'Nama Jabatan'" +
                      "from pegawai p inner join Jabatan j ON p.IdJabatan = j.IdJabatan";
            }
            else
            {
                sql = "select p.IdPegawai, p.Nama, p.TglLahir, p.Alamat, p.Gaji, p.Username, p.Password, j.IdJabatan, j.Nama as 'Nama Jabatan'" +
                      "from pegawai p inner join Jabatan j ON p.IdJabatan = j.IdJabatan where " + kriteria + " LIKE '%" + nilaiKriteria + "%'";
            }
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);
            List<Pegawai> listPegawai = new List<Pegawai>();

            while (hasil.Read() == true)
            {
                string IdPegawai = hasil.GetValue(0).ToString();
                string nama = hasil.GetValue(1).ToString();
                DateTime tglLahir = (DateTime)hasil.GetValue(2);
                string alamat = hasil.GetValue(3).ToString();
                int gaji = int.Parse(hasil.GetValue(4).ToString());
                string username = hasil.GetValue(5).ToString();
                string password = hasil.GetValue(6).ToString();
                Jabatan j = new Jabatan(hasil.GetValue(7).ToString(), hasil.GetValue(8).ToString());
                Pegawai p = new Pegawai(IdPegawai, nama, tglLahir, alamat, gaji, username, password,j);
                listPegawai.Add(p);
            }
            return listPegawai;
        }
        public static void BuatUserBaru(Pegawai p, string namaServer)
        {
            string sql = "create user '" + p.Username + "'@'" + namaServer + "' identified by '" + p.Password + "'";
            Koneksi.JalankanPerintahDML(sql);
        }
        public static void BeriHakAkses(Pegawai p, string namaServer, string namaDatabase)
        {
            if (p.Jabatan.IdJabatan == "J3")
            {
                string sql2 = "grant create user on *.* to '" + p.Username + "'@'" + namaServer + "'";
                Koneksi.JalankanPerintahDML(sql2);
            }
            else
            {
                string sql = "grant all privileges on " + namaDatabase + ".* to '" + p.Username + "'@'" + namaServer + "'";
                Koneksi.JalankanPerintahDML(sql);
            }
        }
        public static void ManajemenUser(Pegawai p, string perintah)
        {
            string namaServer = Koneksi.GetNamaServer();
            string namaDatabase = Koneksi.GetNamaDatabase();
            if (perintah == "tambah")
            {
                Pegawai.BuatUserBaru(p, namaServer);

                Pegawai.BeriHakAkses(p, namaServer, namaDatabase);
            }
            else if (perintah == "ubah")
            {
                Pegawai.UbahPasswordUser(p, namaServer);
            }
            else
            {
                Pegawai.HapusUser(p, namaServer);
            }

        }
        public static void UbahPasswordUser(Pegawai p, string namaServer)
        {
            string sql = "set password for " + p.Username + "'@'" + namaServer + "= password('" + p.Password + "')";
            Koneksi.JalankanPerintahDML(sql);
        }

        public static void HapusUser(Pegawai p, string namaServer)
        {
            string sql = "drop user '" + p.Username + "'@'" + namaServer + "'";
            Koneksi.JalankanPerintahDML(sql);
        }
        public static string GenerateKode()
        {
            string sql = "select max(IdPegawai) from Pegawai ";

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);
            string hasilKode = "";
            if (hasil.Read() == true)
            {
                if (hasil.GetValue(0).ToString() != "")
                {
                    int kodeTerbaru = int.Parse(hasil.GetValue(0).ToString()) + 1;
                    hasilKode = kodeTerbaru.ToString();
                }
                else
                {
                    hasilKode = "1";
                }
            }
            else
            {
                hasilKode = "1";
            }
            return hasilKode;
        }

        #endregion
    }
}