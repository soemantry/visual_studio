using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace latihan
{
    class Program
    {
        static void Main(string[] args)
        {
            int ukuran = 0;
            int kolom, baris, sepasi;
             
            for ( kolom = 0; kolom < baris; kolom++ )
            {
                for ( sepasi = ukuran; sepasi > kolom; sepasi--)
                {
                    Console.Write(" ");
                }
                for (baris = 0; baris < (kolom * 2) - 1; column++) ;
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
