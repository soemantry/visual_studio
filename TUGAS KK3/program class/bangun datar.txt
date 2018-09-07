using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP_DIptya
{
    class bangun_datar
    {
     
       public double luasSegitiga()
       {
            Console.WriteLine("Segitiga");
            Console.WriteLine("Masukkan alas :");
            double alas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Masukkan tinggi :");
            double tinggi = Convert.ToInt32(Console.ReadLine());


            Console.Write("Luas :{0}", ((alas* tinggi) / 2));
                Console.ReadLine();
                return (alas* tinggi);

            
        }
    public double luaspsg()
    {
        Console.WriteLine("Persegi");
        Console.WriteLine("Masukan sisi :");
        double sisi = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Luas :{0}", sisi * sisi);
            Console.ReadLine();
            return (sisi * sisi);
    }
    public double luasling()
    {
        Console.WriteLine("Lingkaran");
        Console.WriteLine("Masukan Jari-jari    :");
        double jari = Convert.ToInt32(Console.ReadLine());
        double pi = 22 / 7;

        Console.WriteLine("Luas :{0}", 2 * pi * jari * jari);
            Console.ReadLine();
            return (2 * pi * jari * jari);
    }
    public double luastrp()
    {
        Console.WriteLine("Trapesium");
        Console.WriteLine("Masukan sisi bawah   :");
        double sisib = Convert.ToInt64(Console.ReadLine());
        Console.WriteLine("Masukan sisi atas   :");
        double sisia = Convert.ToInt64(Console.ReadLine());
        Console.WriteLine("Masukan tinggi   :");
        double tinggit = Convert.ToInt64(Console.ReadLine());

        Console.WriteLine("Luas :{0}", ((sisib + sisia) * tinggit) / 2);
            Console.ReadLine();
            return ((sisib + sisia) * tinggit / 2);
    }
    public double luaspsgpanj()
    {
        Console.WriteLine("Persegi Panjang");
        Console.WriteLine("Masukan sisi a   :");
        double sisiaz = Convert.ToInt64(Console.ReadLine());
        Console.WriteLine("Masukan sisi b   :");
        double sisibz = Convert.ToInt64(Console.ReadLine());

        Console.WriteLine("Luas :{0}", sisiaz * sisibz);
            Console.ReadLine();
            return (sisiaz * sisibz);
    }
}
}

   
