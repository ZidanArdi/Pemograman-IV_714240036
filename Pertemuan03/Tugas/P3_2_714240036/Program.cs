using System;

namespace P3_2_NPM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int menu;
            bool ulangMenu = true;

            while (ulangMenu)
            {
                Console.Clear();
                Console.WriteLine("===============================");
                Console.WriteLine("     MENU PERSEGI PANJANG");
                Console.WriteLine("===============================");
                Console.WriteLine("1. Hitung Luas");
                Console.WriteLine("2. Hitung Keliling");
                Console.WriteLine("3. Keluar");
                Console.Write("Pilih menu (1-3): ");

                //Validasi input angka
                if (!int.TryParse(Console.ReadLine(), out menu))
                {
                    Console.WriteLine("Menu tidak tersedia!");
                    Console.ReadKey();
                    continue;
                }

                switch (menu)
                {
                    case 1:     //HITUNG LUAS
                        Console.Clear();
                        Console.WriteLine("=== HITUNG LUAS PERSEGI PANJANG ===");

                        Console.Write("Masukkan panjang: ");
                        double p = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Masukkan lebar   : ");
                        double l = Convert.ToDouble(Console.ReadLine());

                        double luas = p * l;

                        Console.WriteLine("-----------------------------");
                        Console.WriteLine("Hasil luas = " + luas);
                        Console.WriteLine("-----------------------------");

                        Console.Write("Ingin menghitung lagi? (Y/T): ");
                        char ulang1 = Convert.ToChar(Console.ReadLine().ToUpper());

                        if (ulang1 == 'T')
                        {
                            Console.WriteLine("Terima kasih!");
                            ulangMenu = false;
                        }
                        break;

                    case 2:     //HITUNG KELILING
                        Console.Clear();
                        Console.WriteLine("=== HITUNG KELILING PERSEGI PANJANG ===");

                        Console.Write("Masukkan panjang: ");
                        double p2 = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Masukkan lebar   : ");
                        double l2 = Convert.ToDouble(Console.ReadLine());

                        double keliling = 2 * (p2 + l2);

                        Console.WriteLine("------------------------------");
                        Console.WriteLine("Hasil keliling = " + keliling);
                        Console.WriteLine("------------------------------");

                        Console.Write("Ingin menghitung lagi? (Y/T): ");
                        char ulang2 = Convert.ToChar(Console.ReadLine().ToUpper());

                        if (ulang2 == 'T')
                        {
                            Console.WriteLine("Terima kasih!");
                            ulangMenu = false;
                        }
                        break;

                    case 3:     //KELUAR
                        Console.WriteLine("Program selesai.");
                        Console.WriteLine("Terima kasih!");
                        ulangMenu = false;
                        break;

                    default:
                        Console.WriteLine("Menu tidak tersedia!");
                        break;
                }

                if (ulangMenu)
                {
                    Console.WriteLine("\nTekan ENTER untuk kembali ke menu...");
                    Console.ReadKey();
                }
            }
        }
    }
}
