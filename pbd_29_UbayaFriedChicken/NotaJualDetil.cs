using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pbd_29_UbayaFriedChicken
{
    public class NotaJualDetil
    {
        private int harga;
        private int jumlah;
        private Produk produk;

        public NotaJualDetil(Produk produk, int harga, int jumlah)
        {
            this.Harga = harga;
            this.Jumlah = jumlah;
            this.Produk = produk;
        }

        public int Harga { get => harga; set => harga = value; }
        public int Jumlah { get => jumlah; set => jumlah = value; }
        public Produk Produk { get => produk; set => produk = value; }
    }
}