using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_714240036
{
    //Abstract Class
    public abstract class Pegawai
    {
        //Encapsulation - Property public dengan private set
        public string Nama { get; private set; }

        //Encapsulation - Field private
        private string NIP;

        //Constructor
        public Pegawai(string nama, string nip)
        {
            this.Nama = nama;
            this.NIP = nip;
        }
        public string GetNIP()
        {
            return NIP;
        }

        //Abstract Method
        public abstract double HitungGaji();

        //Method
        public void Absen()
        {
            Console.WriteLine($"{Nama} telah absen.");
        }
    }
}
