using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programhitung
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
            Console.WriteLine("1. Persegi");
            Console.WriteLine("2. Persegi Panjang");
            Console.WriteLine("3. Segitiga");
            Console.WriteLine("4. Jajar Genjang");
            Console.WriteLine("5. Trapesium");
            Console.WriteLine("6. Belah Ketupa");
            Console.WriteLine("7. Layang-Layang");
            Console.Write("Masukan Pilihan Anda : ");
            Memilih = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Clear();
            switch (Memilih)
            {
                case 1:
                    persegi Sisi = new persegi();
                    persegi Luas = new persegi();

                    Sisi.inputan1();
                    Luas.luasK();
                    
                    Console.ReadLine();
                    break;

                case 2:


                    persegi_panjang a = new persegi_panjang();
                    persegi_panjang b  = new persegi_panjang();
                    persegi_panjang luas = new persegi_panjang();

                    a.inputan1();
                    b.inputan2();
                    luas.luasK();
    
                    Console.ReadLine();
                    break;

                case 3:
                    segitiga  ab = new segitiga();
                 

                    ab.inputan1();
                    ab.inputan2();
                    ab.luasK();



                    Console.ReadLine();
                    break;

                case 4:
                    Jajargenjang jr = new Jajargenjang();
                    jr .inputan1();
                    jr .inputan2();
                    jr .luasK();


                    Console.ReadLine();
                    break;

                case 5:
                    Trapesium tp = new Trapesium();
                    tp .inputan1();
                    tp .inputan2();
                    tp .luasK();


                    Console.ReadLine();
                    break;

                case 6:
                    belah_ketupat bh = new belah_ketupat();
                    bh .inputan1();
                    bh .inputan2();
                    bh .luasK();



                    Console.ReadLine();
                    break;

                case 7:
                    layang_layang lay = new layang_layang();
                    lay .inputan1();
                    lay .inputan2();
                    lay .luasK();


                    Console.ReadLine();
                    break;


            }
            Console.Clear();
            goto milih;
           
        }
    }
}
