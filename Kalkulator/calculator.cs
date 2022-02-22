using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator
{
    class calculator : Operasi
    {
        public override double tambah()
        {
            Console.WriteLine("=========Operasi Pertambahan=========");
            Console.Write("Angka Pertama : ");
            pertama = double.Parse(Console.ReadLine());
            Console.Write("Angka Kedua : ");
            kedua = double.Parse(Console.ReadLine());

            hasil = pertama + kedua;
            Console.WriteLine("Hasil :" + hasil);
            return hasil;
        }

        public override double kurang()
        {
            Console.WriteLine("=========Operasi Pengurangan=========");
            Console.Write("Angka Pertama : ");
            pertama = double.Parse(Console.ReadLine());
            Console.Write("Angka Kedua : ");
            kedua = double.Parse(Console.ReadLine());

            hasil = pertama - kedua;
            Console.WriteLine("Hasil :" + hasil);
            return hasil;
        }

        public override double kali()
        {
            Console.WriteLine("==========Operasi Perkalian==========");
            Console.Write("Angka Pertama : ");
            pertama = double.Parse(Console.ReadLine());
            Console.Write("Angka Kedua : ");
            kedua = double.Parse(Console.ReadLine());

            hasil = pertama * kedua;
            Console.WriteLine("Hasil :" + hasil);
            return hasil;
        }

        public override double bagi()
        {
            Console.WriteLine("==========Operasi Pembagian==========");
            Console.Write("Angka Pertama : ");
            pertama = double.Parse(Console.ReadLine());
            Console.Write("Angka Kedua : ");
            kedua = double.Parse(Console.ReadLine());

            hasil = pertama / kedua;
            Console.WriteLine("Hasil :" + hasil);
            return hasil;
        }
    }
}
