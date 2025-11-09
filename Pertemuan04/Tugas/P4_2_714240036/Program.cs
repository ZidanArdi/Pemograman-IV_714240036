using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_714240036
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" PENGUJIAN SEMUA KONSEP OOP ");

            //Create objek dari kelas turunan
            Staf pegawaiStaf = new Staf("Budi Hartono", "1001", 5000000);
            Manager pegawaiManager = new Manager("Citra Dewi", "2005");

            //Uji semua konsep OOP
            Console.WriteLine(" Pengujian Encapsulation & Inheritance");

            //Encapsulation & Inheritance
            Console.WriteLine($"- Nama Staf: {pegawaiStaf.Nama}");

            //Encapsulation 
            Console.WriteLine($"- NIP Manager: {pegawaiManager.GetNIP()}");

            //Inheritance
            Console.Write("- Status: ");
            pegawaiStaf.Absen();

            //Polymorphism & Abstraction
            Console.WriteLine(" Pengujian Polymorphism & Abstraction");

            //Polymorphism melalui daftar bertipe Pegawai
            List<Pegawai> daftarPegawai = new List<Pegawai>
            {
                pegawaiStaf,        
                pegawaiManager  
            };

            foreach (Pegawai p in daftarPegawai)
            {
                Console.WriteLine($"- Gaji {p.Nama} ({p.GetType().Name}): Rp{p.HitungGaji().ToString("N0")}");
            }
            //Console.WriteLine(" Pengujian Metode Spesifik ");

            pegawaiManager.Rapat();
        }
    }
}