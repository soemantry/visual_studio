using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programhitung
{
    class persegi : bidang_datar
    {
        
        public override double inputan1()
        {
            Console.Write("Masukan Sisi :  ");
            a = Convert.ToInt32(Console.ReadLine());
            return a;
        }

        public virtual double luasK()
        {
            double a = inputan1();
            Console.Write("luas persegi adalah :  " + a * a+ " dan kelilingnya adalah " + 4 * a);
            return luas;
        }

    }
}
