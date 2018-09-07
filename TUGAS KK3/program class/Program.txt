using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP_DIptya
{
    class Program
    {
        static void Main(string[] args)
        {
            menu:
            bangun_datar luasKeliling = new bangun_datar() ;
            Console.WriteLine("Pilih yang akan di hitung");
            Console.WriteLine("1. Segitiga ");
            Console.WriteLine("2. Persegi ");
            Console.WriteLine("3. Lingkaran ");
            Console.WriteLine("4. Trapesium");
            Console.WriteLine("5. Persegi Panjang ");
            Console.WriteLine("Masukan Pilihan Anda : ");
            {
                double a = Convert.ToInt64(Console.ReadLine());
                if (a == 1)
                {
                    luasKeliling.luasSegitiga();
                }
                {
                    if (a == 2)
                    {
                        luasKeliling.luaspsg();
                    }
                    if (a == 3)
                    {
                        luasKeliling.luasling();
                    }
                    if (a == 4)
                    {
                        luasKeliling.luastrp();
                    }
                    if (a == 5)
                    {
                        luasKeliling.luaspsgpanj();
                    }
                    Console.WriteLine("");
                    Console.Clear();
                    goto menu;
                }

            }
        }
    }
}
