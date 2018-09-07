using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace getset
{
    class getset
    {
        private int diagonal1;
        private int diagonal2;

        public int getdiagonal1()
        {
            return diagonal1;
        }
        public int setdiagonal1(int ndiagonal1)
        {
            diagonal1 += ndiagonal1;
            return ndiagonal1;
        }

        public int getdiagonal2()
        {
            return diagonal2;
        }
        public int setdiagonal2(int ndiagonal2)
        {
            diagonal2 += ndiagonal2;
            return ndiagonal2;
        }


        private int panjang;
        private int lebar;

        public int getpanjang()
        {
            return panjang;
        }
        public int setpanjang(int npanjang)
        {
           panjang  += npanjang;
            return npanjang;
        }

        public int getlebar()
        {
            return lebar;
        }
        public int setlebar(int nlebar)
        {
            lebar  += nlebar;
            return lebar ;
        }

        private int sisi;

        public int getsisi()
        {
            return sisi ;
        }
        public int setsisi(int nsisi)
        {
            sisi += nsisi;
            return nsisi;
        }


    }
}
