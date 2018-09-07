using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            float Panjang, Lebar, Luas, Keliling;
            Console.WriteLine("2. Persegi Panjang");
            Console.WriteLine();
            Console.Write(" Masukan Panjang :  ");
            Panjang = float.Parse(Console.ReadLine());
            Console.Write("Masukan Lebar : ");
            Lebar = float.Parse(Console.ReadLine());
            Luas = Panjang * Lebar;
            Keliling = 2 * Panjang + 2 * Lebar;
            Console.WriteLine("Jadi, luasnya adalah" + Luas + " dan Kelilingnya adalah" + Keliling);
            Console.ReadLine();





        }
    }
}
