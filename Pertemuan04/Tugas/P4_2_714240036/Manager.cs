using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_714240036
{
    //Inheritance
    public class Manager : Pegawai
    {
        private const double GajiDasar = 7500000;
        private const double Tunjangan = 2500000;

        //Constructor
        public Manager(string nama, string nip) : base(nama, nip)
        {
        }

        //Polymorphism
        public override double HitungGaji()
        {
            return GajiDasar + Tunjangan;
        }

        public void Rapat()
        {
            Console.WriteLine($"{Nama} sedang memimpin rapat.");
        }
    }
}
