using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programhitung
{
    class persegi_panjang : bidang_datar 
    {
        public override double luasK()
        {
            
            double a = inputan1();
            double b = inputan2 ();
            Console.Write("Luasnya adalah : " + a*b   +  "kelilingnya adalah :    " + b*4);

            return luas;
           
        }
        public override double inputan1()
        {
            Console.Write("Masukan Panjang :  ");
            a = Convert.ToInt32(Console.ReadLine());
            
            return a;
        }

        public override  double inputan2()
        {
            Console.Write("Masukan Lebar :  ");
            b = Convert.ToInt32(Console.ReadLine());
           
            return b;
        }

    }



}

