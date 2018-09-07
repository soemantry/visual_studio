using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programhitung
{
    class Trapesium : bidang_datar 
    {
        public override double luasK()
        {
            double a = inputan1();
            double b = inputan2();
            double c = inputan3();
            Console.Write("Luasnya adalah :  " + (a + b) * c / 2 + "kelilingnya adalah Belum dilanjut");
            

            return luas;

        }
        public override double inputan1()
        {
            Console.Write("Masukan Alas :  ");
            a = Convert.ToInt32(Console.ReadLine());
            return a;
        }

        public override double inputan2()
        {
            Console.Write("Masukan Sisi Sejajar :  ");
            b = Convert.ToInt32(Console.ReadLine());
            return b;
        }

        public override double inputan3()
        {
            Console.Write("Masukan Tinggi :  ");
            c = Convert.ToInt32(Console.ReadLine());
            return c;

        }
    }
}
