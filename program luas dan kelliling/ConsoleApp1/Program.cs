using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_luas_dan_kelliling
{
    class Program
    {
        static void Main(string[] args)
        {

            float Keliling, Luas, Panjang, Lebar, Alas, Tinggi, SisiKanan, SisiKiri;
            double R;
            const double Phi = 3.14;
            char Memilih;

        Memilih:
            Console.WriteLine("****************************************");
            Console.WriteLine("&&&&&&&&&&&&&&&&&&&&&&&&&&&&&" +
                "&&&&&&&&&&&");
            Console.WriteLine(" Porgram Perhiitungan Luas dan Keliling ");
            Console.WriteLine("&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&");
            Console.WriteLine("****************************************");
            Console.WriteLine("Pilihan Menu");
            Console.WriteLine("1.Segitiga");
            Console.WriteLine("2.Persegi Panjang");
            Console.WriteLine("3.Persegi");
            Console.WriteLine("4.Jajargenjang");
            Console.WriteLine("5.Trapesium");
            Console.WriteLine("6.Layang-Layang");
            Console.WriteLine("7.Tabung");
            Console.WriteLine("8.Kubus");
            Console.WriteLine("9.Balok");
            Console.WriteLine("10.Limas");
            Console.WriteLine("11.Prisma");
            Console.WriteLine("12.Bola");
            Console.WriteLine("13.Kerucut");
            Console.WriteLine("14. Keluar");
            Console.WriteLine();
            Console.Write("Masukan Pilihan Anda : ");
            Memilih = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Clear();
            switch (Memilih)

            {
                case 1:

                    Console.WriteLine("1.Luas dan Keliling Segitiga");
                    Console.Write("Masukan Alas          : ");
                    Alas = float.Parse(Console.ReadLine());
                    Console.Write("Masukan Tinggi        : ");
                    Tinggi = float.Parse(Console.ReadLine());
                    Console.Write("Masukan Sisi Kanan    : ");
                    SisiKanan = float.Parse(Console.ReadLine());
                    Console.Write("Sisi Kiri             :  ");
                    SisiKiri = float.Parse(Console.ReadLine());
                    Luas = Alas * Tinggi / 2;
                    Keliling = Alas + SisiKanan + SisiKiri;
                    Console.WriteLine("Jadi luasnya adalah " + Luas + " dan Kelilingnya adalah " + Keliling);
                    Console.ReadKey();
                    break;

                case 2:

                    Console.WriteLine("2.Luas Dan Keliling Persegi Panjang");
                    Console.Write("Masukan Panjang      : ");
                    Panjang = float.Parse(Console.ReadLine());
                    Console.Write("Masukan Lebar         : ");
                    Lebar = float.Parse(Console.ReadLine());
                    Luas = Panjang * Lebar;
                    Keliling = 2 * Panjang + 2 * Lebar;
                    Console.WriteLine("Jadi, luasnya adalah " + Luas + " dan Kelilingnya adalah " + Keliling);
                    Console.ReadKey();
                    break;



                case 3:

                    Console.WriteLine("3. Luas dan Keliling Persegi ");
                    Console.Write("Masukan Panjang Sisi :  ");
                    Panjang = float.Parse(Console.ReadLine());
                    Luas = Panjang * Panjang;
                    Keliling = 4 * Panjang;
                    Console.WriteLine("Jadi, Luas Persegi adalah " + Luas + " dan Kelilingnya adalah " + Keliling);
                    Console.ReadKey();
                    break;

                case 4:

                    Console.WriteLine("4. Luas dan Keliling Jajargenjang");
                    Console.Write("Masukan Sisi Atas  :  ");
                    Panjang = float.Parse(Console.ReadLine());
                    Console.Write("Masukan Sisi Bawah : ");
                    Lebar = float.Parse(Console.ReadLine());
                    Console.Write("Masukan TInggi     : ");
                    Tinggi = float.Parse(Console.ReadLine());
                    Luas = (Panjang + Lebar) * Tinggi / 2;
                    Keliling = Panjang + Lebar;
                    Console.WriteLine("Jadi, Luas Persegi adalah " + Luas + " dan Kelilingnya adalah " + Keliling);
                    Console.ReadKey();
                    break;


            }

            Console.Clear();
            Console.WriteLine("Kemabli Ke Menu : Y/T ");
            Memilih = char.Parse(Console.ReadLine());
            if (Memilih == 'Y') || Memilih == 'y')
                goto Memilih;

            else
            Console.WriteLine("Program Selesai .....");
            Console.ReadKey(true);

        }

    }
}


