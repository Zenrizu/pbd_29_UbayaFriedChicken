using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Transactions;
using System.IO;
using System.Drawing;
using System.Drawing.Printing;
using MySql.Data.MySqlClient;

namespace pbd_29_UbayaFriedChicken
{
    public class NotaJual
    {
        private string idNota;
        private DateTime tanggal;
        private Pegawai pegawai;
        private Pelanggan pelanggan;
        private List<NotaJualDetil> listNotaJualDetil;
        private List<RewardNotaJual> listRewardNotaJual;

        public NotaJual(string idNota, DateTime tanggal, Pelanggan pelanggan, Pegawai pegawai)
        {
            this.IdNota = idNota;
            this.Tanggal = tanggal;
            this.Pegawai = pegawai;
            this.Pelanggan = pelanggan;
            this.ListNotaJualDetil = new List<NotaJualDetil>();
            this.ListRewardNotaJual = new List<RewardNotaJual>();
        }

        public string IdNota { get => idNota; set => idNota = value; }
        public DateTime Tanggal { get => tanggal; set => tanggal = value; }
        public Pegawai Pegawai { get => pegawai; set => pegawai = value; }
        public Pelanggan Pelanggan { get => pelanggan; set => pelanggan = value; }
        public List<NotaJualDetil> ListNotaJualDetil { get => listNotaJualDetil;private set => listNotaJualDetil = value; }
        public List<RewardNotaJual> ListRewardNotaJual { get => listRewardNotaJual; private set => listRewardNotaJual = value; }

        #region Methods
        //menambahkan detil produk dalam nota jual
        public void TambahNotaJualDetil(Produk produk, int harga, int jmlh)
        {
            NotaJualDetil notaJualDetil = new NotaJualDetil(produk, harga, jmlh);
            this.ListNotaJualDetil.Add(notaJualDetil);
        }
        public void TambahRewardNotaJual(Reward reward)
        {
            RewardNotaJual rewardNotaJual = new RewardNotaJual(reward);
            this.ListRewardNotaJual.Add(rewardNotaJual);
        }

        //menambah nota jual baru
        public static void TambahData(NotaJual nota)
        {
            //satu scope transaction
            using (TransactionScope transScope = new TransactionScope())
            {
                try
                {
                    //menambahkan data nota jual
                    string sql1 = "insert into NotaJual(IdNota,Tanggal,IdPelanggan,IdPegawai) values ('" + nota.IdNota +
                        "','" + nota.Tanggal.ToString("yyyy-MM-dd hh:mm:ss") + "','" + nota.Pelanggan.IdPelanggan + "','" +
                        nota.Pegawai.IdPegawai + "')";
                    Koneksi.JalankanPerintahDML(sql1);

                    foreach (NotaJualDetil notaJualDetil in nota.ListNotaJualDetil)
                    {
                        //menambahkan detil produk dalam nota jual
                        string sql2 = "insert into NotaJualDetil(IdNota,IdProduk,Harga,Jumlah) values ('" + nota.IdNota +
                            "','" + notaJualDetil.Produk.IdProduk + "','" + notaJualDetil.Harga + "','" + notaJualDetil.Jumlah + "')";
                        Koneksi.JalankanPerintahDML(sql2);

                        //update stock dari produk dalam nota jual
                        Produk.UpdateStock("penjualan", notaJualDetil.Produk.IdProduk, notaJualDetil.Jumlah);
                    }
                    //jika semua semua perintah dml berhasil dalam transScope 
                    transScope.Complete(); //simpan semua data secara permanent
                }
                catch (Exception exc)
                {
                    //batalkan semua perintah yang ada dalam transScope
                    transScope.Dispose();//batalkan semua data yang telah tersimpan
                    throw (new Exception(exc.Message));
                }
            }
        }

        //untuk generate nomor nota baru
        public static string GenerateIdNota()
        {
            string sql = "select RIGHT(IdNota,3) as NoUrutTransaksi" +
                    " from notajual " + " where Date(Tanggal) = Date(CURRENT_DATE)" +
                    " order by Tanggal DESC limit 1";

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            string hasilIdNota = "";
            if (hasil.Read() == true)
            {
                if (hasil.GetValue(0).ToString() != "")
                {
                    int idNotaTerakhir = int.Parse(hasil.GetValue(0).ToString()) + 1;

                    hasilIdNota = DateTime.Now.Year +
                        DateTime.Now.Month.ToString().PadLeft(2, '0') +
                        DateTime.Now.Day.ToString().PadLeft(2, '0') +
                        idNotaTerakhir.ToString().PadLeft(3, '0');
                }
            }
            else
            {
                hasilIdNota = DateTime.Now.Year +
                    DateTime.Now.Month.ToString().PadLeft(2, '0') +
                    DateTime.Now.Day.ToString().PadLeft(2, '0') +
                    "001";
            }
            return hasilIdNota;

        }

        public static List<NotaJual> BacaData(string kriteria, string nilaiKriteria)
        {
            string sql1 = "";
            if (kriteria == "")
            {
                //perintah sql 1 : menampilkan semua data di tabel notaJual
                sql1 = "select n.IdNota, n.Tanggal, n.IdPelanggan, plg.Nama as NamaPelanggan, plg.Alamat as AlamatPelanggan, n.IdPegawai, p.Nama as NamaPegawai" +
                    " from notajual as n inner join pelanggan as plg on n.IdPelanggan = plg.IdPelanggan inner join pegawai as p on n.IdPegawai = p.IdPegawai" +
                    " order by n.IdNota desc";
            }
            else
            {
                sql1 = "select n.IdNota, n.Tanggal, n.IdPelanggan, plg.Nama as NamaPelanggan, plg.Alamat as AlamatPelanggan, n.IdPegawai, p.Nama as NamaPegawai" +
                    " from notajual as n inner join pelanggan as plg on n.IdPelanggan = plg.IdPelanggan inner join pegawai as p on n.IdPegawai = p.IdPegawai" +
                    " where " + kriteria + " like '%" + nilaiKriteria + "%'" +
                    " order by n.IdNota desc";
            }
            //data reader 1 : memperoleh semua data di tabel notaJual
            MySqlDataReader hasilData1 = Koneksi.JalankanPerintahQuery(sql1);
            List<NotaJual> listHasilData = new List<NotaJual>();

            while (hasilData1.Read() == true)
            {
                //mendapatkan nomor nota jual dari hasil data reader
                string IdNota = hasilData1.GetValue(0).ToString();

                //mendapatkan tanggal nota dari hasil daa reader
                DateTime tglNota = DateTime.Parse(hasilData1.GetValue(1).ToString());

                //pelanggan yang melakukan transaksi (cari data di tabel pelanggan sesuai kode pelanggan yang dihasilkan)
                List<Pelanggan> listPelanggan = Pelanggan.BacaData("IdPelanggan", hasilData1.GetValue(2).ToString());

                //pegawai pembuat nota (cari data di tabel pegawai sesuai kode pegawai yang dihasilkan)
                List<Pegawai> listPegawai = Pegawai.BacaData("IdPegawai", hasilData1.GetValue(5).ToString());

                //nota jual
                //create objek bertipe NotaJual
                NotaJual nota = new NotaJual(IdNota, tglNota, listPelanggan[0], listPegawai[0]);

                //query 2 : mendapatkan detil nota jual dari tiap nota jual
                //perintah sql 2 : mendapatkan produk yang ada di nota (dari  tabel NotaJualDetil)
                string sql2 = "select njd.IdProduk, pr.Nama, njd.Harga, njd.Jumlah" +
                    " from notajual as n inner join notajualdetil as njd on n.IdNota = njd.IdNota inner join produk as pr on njd.IdProduk =pr.IdProduk " +
                    " where n.IdNota = '" + IdNota + "'";

                //data reader 2 : memperoleh semua data produk nota di tabel notaJualDetil
                MySqlDataReader hasilData2 = Koneksi.JalankanPerintahQuery(sql2);

                while (hasilData2.Read() == true)
                {
                    //produk yang terjual
                    List<Produk> listProduk = Produk.BacaData("pr.IdProduk", hasilData2.GetValue(0).ToString());

                    //mendapatkan harga jual transaksi
                    int hrgJual = int.Parse(hasilData2.GetValue(2).ToString());

                    //mendapatkan jumlah produk terjual
                    int jumlahJual = int.Parse(hasilData2.GetValue(3).ToString());

                    //create nobjek bertipe detilNotaJual
                    NotaJualDetil detilNota = new NotaJualDetil(listProduk[0], hrgJual, jumlahJual);

                    //simpan detil produk ke nota
                    nota.TambahNotaJualDetil(listProduk[0], hrgJual, jumlahJual);
                }

                //query 3 : mendapatkan detil reward dari tiap nota jual
                //perintah sql 3 : mendapatkan reward yang ada di nota (dari  tabel RewardNotaJual)
                string sql3 = "select njr.IdReward, r.nama, r.jenis_barang, r.batas_minimal" +
                    " from notajual as n inner join notajual_reward as njr on n.IdNota = njr.IdNota inner join reward as r on njr.IdReward =r.IdReward " +
                    " where n.IdNota = '" + IdNota + "'";

                //data reader 3 : memperoleh semua data reward nota di tabel notajual_reward
                MySqlDataReader hasilData3 = Koneksi.JalankanPerintahQuery(sql3);

                while (hasilData3.Read() == true)
                {
                    //produk yang terjual
                    List<Reward> listReward = Reward.BacaData("IdReward", hasilData3.GetValue(0).ToString());

                    //create nobjek bertipe detilNotaJual
                    RewardNotaJual detilNotaReward = new RewardNotaJual(listReward[0]);

                    //simpan detil produk ke nota
                    nota.TambahRewardNotaJual(listReward[0]);
                }
                //simpan ke list
                listHasilData.Add(nota);
            }
            return listHasilData;
        }

        public static void CetakNota(string pKriteria, string pNilaiKriteria, string pNamaFile, Font pFont)
        {
            List<NotaJual> listNotaJual = new List<NotaJual>();

            //baca data nota tertentu yang akan dicetak
            listNotaJual = NotaJual.BacaData(pKriteria, pNilaiKriteria);

            //simpan dulu isi nota yang akan ditampilakn ke objek file (StreamWriter)
            StreamWriter file = new StreamWriter(pNamaFile);

            foreach (NotaJual nota in listNotaJual)
            {
                //tampilkan info perusahaan
                file.WriteLine("");
                file.WriteLine("TOKO MAJU MAKMUR UNTUNG SELALU");
                file.WriteLine("Jl. Raya Kalirungkut Surabaya");
                file.WriteLine("Telp. (031) - 12345678");
                file.WriteLine("=".PadRight(50, '='));

                //tampilkan ehader nota
                file.WriteLine("Id Nota : " + nota.IdNota);
                file.WriteLine("Tanggal : " + nota.Tanggal);
                file.WriteLine("");
                file.WriteLine("Pelanggan : " + nota.Pelanggan.Nama);
                file.WriteLine("Alamat : " + nota.Pelanggan.Alamat);
                file.WriteLine("");
                file.WriteLine("Kasir : " + nota.Pegawai.Nama);
                file.WriteLine("=".PadRight(50, '='));

                //tampilkan produk yang terjual
                int grandTotal = 0;//untuk menampilkan grand total nota

                foreach (NotaJualDetil njd in nota.ListNotaJualDetil)
                {
                    string nama = njd.Produk.Nama;

                    //jika nama terlalu panjang maka hanya tapilkan 30 karakter pertama saja
                    if (nama.Length > 30)
                    {
                        nama = nama.Substring(0, 30);
                    }
                    int jumlah = njd.Jumlah;
                    int harga = njd.Harga;
                    int subTotal = jumlah * harga;
                    file.Write(nama.PadRight(30, ' '));
                    file.Write(jumlah.ToString().PadRight(3, ' '));
                    file.Write(harga.ToString("#,###").PadRight(8, ' ')); //agar harga ditampilkan dengan pemisah ribuan
                    file.Write(subTotal.ToString("#,###").PadRight(10, ' ')); //agar subTotal ditampilkan dengan pemisah ribuan
                    file.WriteLine("");
                    grandTotal = grandTotal + subTotal;
                }

                foreach (RewardNotaJual njr in nota.ListRewardNotaJual)
                {
                    string nama = njr.Reward.Nama;
                    string jenis_barang = njr.Reward.Jenis_barang;
                    
                    //jika nama terlalu panjang maka hanya tapilkan 30 karakter pertama saja
                    if (nama.Length > 30)
                    {
                        nama = nama.Substring(0, 30);
                    }            
                    file.Write(nama.PadRight(30, ' '));
                    file.Write(jenis_barang);
                    file.WriteLine("");         
                }
                file.WriteLine("=".PadRight(50, '='));
                file.WriteLine("TOTAL : " + grandTotal.ToString("#,###"));
                file.WriteLine("=".PadRight(50, '='));
                file.WriteLine("Terima kasih atas kunjungan anda");
                file.WriteLine("");
            }
            file.Close();
            //cetak ke printer
            Cetak c = new Cetak(pNamaFile, pFont, 20, 10, 10, 10);
            c.CetakKePrinter("text");
        }
        #endregion
    }
}