using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hitungbidangdatar_induk
{
    class persegi_panjang : bidang_datar
    {
        int a,b;
        public override double panjang()
        {
            Console.Write("masukan  panjang : ");
             a = Convert.ToInt32(Console.ReadLine());
            return panjang1;
        }

        public override  double lebar()
        {
            Console.Write("masukan lebar : ");
            int lebar = Convert.ToInt32(Console.ReadLine());
            return lebar1;
        }



        public override double luas1()//beda dengan public doublenya
        {
            
            Console.Write("Luas Persegi panjang : {0}", a*b);
            return luas;
        }

        public override  double keliling1()//ini juga beda dengan public doublenya
        {
            keliling = a * b;
            Console.WriteLine("Keliling Persegi panjang : "+keliling);
            return keliling;
        }
    }
}
