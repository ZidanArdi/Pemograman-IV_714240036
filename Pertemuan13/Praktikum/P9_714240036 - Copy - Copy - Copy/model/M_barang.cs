using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P9_714240036.model
{
    public class M_barang
    {
        public string IdBarang { get; set; } // Gunakan string jika ingin fleksibel, atau int
        public string NamaBarang { get; set; }
        public string Harga { get; set; }
    }
}
