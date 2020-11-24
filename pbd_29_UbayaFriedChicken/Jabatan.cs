using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace pbd_29_UbayaFriedChicken
{
    public class Jabatan
    {
        #region Fields
        private string idJabatan;
        private string nama;

        #endregion

        #region Constructors
        public Jabatan(string idJabatan, string nama)
        {
            this.IdJabatan = idJabatan;
            this.Nama = nama;
        }

        #endregion

        #region Properties
        public string IdJabatan { get => idJabatan; set => idJabatan = value; }
        public string Nama { get => nama; set => nama = value; }
        #endregion

        #region Methods
        public static List<Jabatan> BacaData(string kriteria, string nilaikriteria)
        {
            string sql = "";
            if (kriteria == "")
            {
                sql = "select * from jabatan";
            }
            else
            {
                sql = "select * from jabatan where " + kriteria + " like '%" + nilaikriteria + "%'";
            }

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);
            List<Jabatan> listJabatan = new List<Jabatan>();
            while (hasil.Read() == true)
            {
                Jabatan j = new Jabatan(hasil.GetValue(0).ToString(), hasil.GetValue(1).ToString());
                listJabatan.Add(j);
            }
            return listJabatan;
        }
        #endregion
    }
}