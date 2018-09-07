using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tringle
{
    class Program
    {
        static void Main(string[] args)
        {
            int baris = 10;
            int a, b, c;

            


            for (a = 0; a < baris; a++)
            {
                for (c = baris; c > a; c--)
                {
                    Console.Write(" ");
                }
                for(b = 0; b < (a*2)-1; b++)
                {
                    Console.Write("*");
                }


                Console.WriteLine();

            }


            Console.ReadLine();

        }
    }
}
