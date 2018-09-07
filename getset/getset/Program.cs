using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace getset
{
    class Program
    {
        static void Main(string[] args)
        {
            float Memilih;
            char   milih;

            getset bilangan = new getset();

            milih:
            Console.WriteLine("****************************************");
            Console.WriteLine("&&&&&&&&&&&&&&&&&&&&&&&&&&&&&" +
                "&&&&&&&&&&&");
            Console.WriteLine(" Porgram Perhiitungan Luas dan Keliling ");
            Console.WriteLine("&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&");
            Console.WriteLine("****************************************");
            Console.WriteLine("Pilihan Menu");
            Console.WriteLine("1.Layang-Layang");
            Console.WriteLine("2.Persegi Panjang");
            Console.WriteLine("3.Persegi");
            Console.WriteLine("4.Jajar Genjang");
            Console.Write("Masukan Pilihan Anda : ");
            Memilih = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Clear();
            switch (Memilih)
            {
                case 1:

              
                Console.Write("Masukan Diagonal 1 : ");
                int diagonal1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Masukan Diagonal 2 : ");
                int diagonal2 = Convert.ToInt32(Console.ReadLine());
                int diagonal11 = bilangan.setdiagonal1(diagonal1);
                int diagonal111 = bilangan.getdiagonal1();
                int diagonal22 = bilangan.setdiagonal2(diagonal2);
                int diagonal222 = bilangan.getdiagonal2();
                int luas = diagonal1 * diagonal2 / 2;
                Console.WriteLine("Luas Layang layang adalah = " + luas);
                Console.ReadLine();
                    break;

                case 2:
           
                Console.Write("Masukan panjang : ");
                int panjang = Convert.ToInt32(Console.ReadLine());
                Console.Write("Masukan Lebar : ");
                int lebar = Convert.ToInt32(Console.ReadLine());
                int panjang1 = bilangan.setpanjang(panjang);
                int panjang2 = bilangan.getpanjang();
                int lebar1 = bilangan.setlebar(lebar);
                int lebar2 = bilangan.getlebar();
                int Luas = panjang2 * lebar2;
                Console.WriteLine("Luas persegi panjang adalah = " + Luas);
                Console.ReadLine();
                    break;

                case 3:

                    Console.Write("Masukan sisi : ");
                    int sisi = Convert.ToInt32(Console.ReadLine());
                    int sisi1 = bilangan.setsisi(sisi);
                    int sisi2 = bilangan.getsisi();
                    int Luas = sisi * sisi;
                    Console.WriteLine("Luas persegi  adalah = " + Luas);
                    Console.ReadLine();
                    break;

            }
            Console.Clear();
            goto milih;
            ///Console.ReadKey();
        }
    }
}
