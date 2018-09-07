using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace latihan_artibut
{
   public interface kalkulator1
    {
       
        double  add(double x, double y);

        double min(double x, double y);

        double kali(double x, double y);

        double bagi(double x, double y);

    }

    class hitung : kalkulator1
    {

        public double add(double x, double y)
        {
            return x + y;
        }

        public double bagi(double x, double y)
        {
            return x / y;
        }

        public double kali(double x, double y)
        {
            return x * y;
        }

        public double min(double x, double y)
        {
            return x - y;
        }

     
        
    }
}
