using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hitungbidangdatar_induk
{
    class Program
    {
        static void Main(string[] args)
        {
            float Memilih;
            char milih;
     
            milih:
            Console.WriteLine("****************************************");
            Console.WriteLine("&&&&&&&&&&&&&&&&&&&&&&&&&&&&&" +
                "&&&&&&&&&&&");
            Console.WriteLine(" Porgram Perhiitungan Luas dan Keliling ");
            Console.WriteLine("&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&");
            Console.WriteLine("****************************************");
            Console.WriteLine("Pilihan Menu");
            Console.WriteLine("1.Persegi");
            Console.WriteLine("2.Persegi Panjang");
            Console.WriteLine("3.segitiga");
            Console.WriteLine("4.Jajar Genjang");
            Console.WriteLine("5. Trapesium");
            Console.Write("Masukan Pilihan Anda : ");
            Memilih = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Clear();
            switch (Memilih)
            {
                case 1:
                    persegi luas = new persegi();
                    persegi keliling = new persegi();
                    persegi Sisi = new persegi();

                    Sisi.sisi();
                    luas.luas1();
                    keliling.keliling1();

                    Console.ReadLine();
                    break;

                case 2:
                    persegi_panjang asikluas = new persegi_panjang();
                    persegi_panjang asikkeliling = new persegi_panjang();
                    persegi_panjang panjang1 = new persegi_panjang();
                    persegi_panjang lebar1 = new persegi_panjang();

                    panjang1.panjang();
                    lebar1.lebar();
                    asikluas.luas1();
                    asikkeliling.keliling1();

                    Console.ReadLine();
                    break;

                case 3:

                    
                    Console.ReadLine();
                    break;

                case 4:


                    Console.ReadLine();
                    break;

                case 5:


                    Console.ReadLine();
                    break;


            }
            Console.Clear();
            goto milih;
            ///Console.ReadKey();
        }
    }
}
