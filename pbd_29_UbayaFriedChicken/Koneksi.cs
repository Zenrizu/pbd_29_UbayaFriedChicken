using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace pbd_29_UbayaFriedChicken
{
    public class Koneksi
    {
        #region Fields
        private MySqlConnection koneksiDB;
        #endregion

        #region Constructors
        public Koneksi(string strServer, string strDatabase, string strUsername, string strPassword)
        {
            string strCon = "";
            if (strPassword != "")
            {
                strCon = "Server=" + strServer + ";Database=" + strDatabase + ";Uid=" + strUsername + ";Pwd=" + strPassword + "; charset=utf8";
            }
            else
            {
                strCon = "Server=" + strServer + ";Database=" + strDatabase + ";Uid=" + strUsername + "; charset=utf8";
            }


            this.KoneksiDB = new MySqlConnection();
            this.KoneksiDB.ConnectionString = strCon;

            Connect();
            UpdateAppConfig(strCon);
        }
        public Koneksi()
        {
            KoneksiDB = new MySqlConnection();
            KoneksiDB.ConnectionString = ConfigurationManager.ConnectionStrings["namakoneksi"].ConnectionString;
            Connect();
        }
        #endregion

        #region Properties
        public MySqlConnection KoneksiDB { get => koneksiDB; private set => koneksiDB = value; }
        #endregion

        #region Methods
        public void Connect()
        {
            if (KoneksiDB.State == System.Data.ConnectionState.Open)
            {
                KoneksiDB.Close();
            }
            KoneksiDB.Open();
        }
        public void UpdateAppConfig(String con)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.ConnectionStrings.ConnectionStrings["namakoneksi"].ConnectionString = con;
            config.Save(ConfigurationSaveMode.Modified, true);
            ConfigurationManager.RefreshSection("connectionStrings");
        }
        public static void JalankanPerintahDML(string sql)
        {
            Koneksi k = new Koneksi();
            MySqlCommand c = new MySqlCommand(sql, k.KoneksiDB);
            c.ExecuteNonQuery();
        }
        public static MySqlDataReader JalankanPerintahQuery(string sql)
        {
            Koneksi k = new Koneksi();
            MySqlCommand c = new MySqlCommand(sql, k.KoneksiDB);
            MySqlDataReader hasil = c.ExecuteReader();
            return hasil;
        }
        public static string GetNamaServer()
        {
            MySqlConnection c = new MySqlConnection();
            c.ConnectionString = ConfigurationManager.ConnectionStrings["namakoneksi"].ConnectionString;
            return c.DataSource;
        }

        public static string GetNamaDatabase()
        {
            MySqlConnection c = new MySqlConnection();
            c.ConnectionString = ConfigurationManager.ConnectionStrings["namakoneksi"].ConnectionString;
            return c.Database;
        }
        #endregion
    }
}
