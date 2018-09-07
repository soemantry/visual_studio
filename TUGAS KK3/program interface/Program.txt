using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace latihan_artibut
{
    class Program
    {
        static void Main(string[] args)
        {

            hitung a = new hitung();
            menu: 
            Console.WriteLine("Aplikasi Kalkulator Joss");
            Console.WriteLine("########################");

            Console.Write("Masukan Angka Pertama : ");
            double A = Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukan Angka Kedua   : ");
            double B = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Hasil Penambahan  : " + a.add(A, B));
            Console.WriteLine("Hasil Perkalian   : " + a.kali(A, B));
            Console.WriteLine("Hasil pengurangan : " + a.min(A, B));
            Console.WriteLine("Hasil Pembagian   : " + a.bagi(A, B));
            Console.ReadLine();
            Console.Clear();
            goto menu;
        }
    }
}
