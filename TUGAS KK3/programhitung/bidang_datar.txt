using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programhitung
{
    class bidang_datar
    {
        public double luas;
        public double  a;
        public double  b;
        public double   c;
        public double d;



        public virtual double luasK()
        {
            return luas;
        }

        public virtual double inputan1()
        {
            Console.Write("Masukan inputan 1 :  ");
            a = Convert.ToInt32(Console.ReadLine());
            return a;
        }

        public virtual double inputan2()
        {
            Console.Write("Masukan inputan 2 :  ");
            b = Convert.ToInt32(Console.ReadLine());
            return b;
        }

        public virtual double inputan3()
        {
            Console.Write("Masukan inputan 3 :  ");
            c = Convert.ToInt32(Console.ReadLine());
            return c;
        }

        public virtual double inputan4()
        {
            Console.Write("Masukan inputan 4 :  ");
            d = Convert.ToInt32(Console.ReadLine());
            return d;
        }
    }
}
