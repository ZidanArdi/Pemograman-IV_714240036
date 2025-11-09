using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_714240036
{
    //Inheritance
    public class Staf : Pegawai
    {
        //Encapsulation
        public double GajiPokok { get; set; }

        //Constructor
        public Staf(string nama, string nip, double gajiPokok) : base(nama, nip)
        {
            this.GajiPokok = gajiPokok;
        }

        //Polymorphism
        public override double HitungGaji()
        {
            return GajiPokok;
        }
    }
}
