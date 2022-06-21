using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Kitap_Uygulamasi.Models
{
    public class Satis
    {
        public int SatisID { get; set; }
        public int UyeID { get; set; }
        public DateTime SatisTarihi { get; set; }
        public decimal ToplamTutar { get; set; }



        public Uye Uye { get; set; }
        public ICollection<SatisDetay> SatisDetaylar { get; set; }

    }
}
