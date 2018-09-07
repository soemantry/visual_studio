using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hitungbidangdatar_induk
{
    class persegi : bidang_datar 
    {
        int a;
        public override  double  sisi()
        {
            Console.Write("masukan sisi : ");
             a = Convert.ToInt32(Console.ReadLine());
            return a;
        }

        public override  double luas1()//beda dengan public doublenya
        {
           luas = a *a;
            Console.Write("Luas Persegi :  ", luas);
            return luas ;
        }

        public override  double keliling1()//ini juga beda dengan public doublenya
        {
            Console.WriteLine("Keliling Persegi : {0} ", 4 *a);
            return 4 * a;
        }
      
    }
}
