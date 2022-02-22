using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator
{
    public abstract class Operasi
    {
        public double pertama;
        public double kedua;
        public double hasil;

        public abstract double tambah();
        public abstract double kurang();
        public abstract double kali();
        public abstract double bagi();
    }
}
