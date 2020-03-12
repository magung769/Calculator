using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator
{
    class Calculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aplikasi Calculator");
			Console.WriteLine();
            Console.WriteLine("1.Penambahan");
            Console.WriteLine("2.Pengurangan");
            Console.WriteLine("3.Perkalian");
            Console.WriteLine("4.Pembagian");
			Console.WriteLine();
            Console.Write("Masukan Pilihan(1-4):");
            int angka1, angka2, total = 0;
            int pilihan = Int32.Parse(Console.ReadLine());

            if (pilihan == 1)
            {
                Console.Write("Inputkan Nilai A = ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Inputkan Nilai B = ");
                int b = Convert.ToInt32(Console.ReadLine());
                total = a + b;
                Console.WriteLine("Jumlah = {0}", total);
            }
            else if (pilihan == 2)
            {
                Console.Write("Inputkan Nilai A = ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Inputkan Nilai B = ");
                int b = Convert.ToInt32(Console.ReadLine());
                total = a - b;
                Console.WriteLine("Jumlah = {0}", total);
            }
            else if (pilihan == 3)
            {
                Console.Write("Inputkan Nilai A = ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Inputkan Nilai B = ");
                int b = Convert.ToInt32(Console.ReadLine());
                total = a * b;
                Console.WriteLine("Jumlah = {0}", total);
            }
            else if (pilihan == 4)
            {
                Console.Write("Inputkan Nilai A = ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Inputkan Nilai B = ");
                int b = Convert.ToInt32(Console.ReadLine());
                total = a / b;
                Console.WriteLine("Jumlah = {0}", total);
            }
            else
            {
                Console.WriteLine("Tidak ada pilihan");
            }

            Console.WriteLine("\nTekan sembarang key untuk keluar");

            // Console.WriteLine();
            // Console.WriteLine("Hasil Penambahan: {0} + {1} = {2}", a, b, Penambahan(a, b));
            // Console.WriteLine("Hasil Pengurangan: {0} - {1} = {2}", a, b, Pengurangan(a, b));
            // Console.WriteLine("Hasil Perkalian: {0} * {1} = {2}", a, b, Perkalian(a, b));
            // Console.WriteLine("Hasil Pengurangan: {0} / {1} = {2}", a, b, Pembagian(a, b));

            Console.ReadKey();
        }

        //static int Penambahan(int a, int b)
        //{
        //return a + b;
        //}
        //static int Pengurangan(int a, int b)
        //{
        //return a - b;
        //}
        //static int Perkalian(int a, int b)
        //{
        //return a * b;
        //}
        //static int Pembagian(int a, int b)
        //{
        //return a / b;
        //}
    }
}
