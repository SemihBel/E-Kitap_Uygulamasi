using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Kitap_Uygulamasi.Models
{
    public class Kategori
    {
        public int KategoriID { get; set; }
        public string KategoriAdi { get; set; }



        public ICollection<KitapKategori> KitapKategoriler { get; set; }
    }
}
