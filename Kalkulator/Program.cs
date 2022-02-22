using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("======= Kelompok XI RPL5 =======");
                Console.WriteLine("1. Lutfina Nararya Dewi Wibowo (19)");
                Console.WriteLine("2. Muamar Zidan Tri Antoro (21)");
                Console.WriteLine("3. Nur Aliya Fajri (25)");
                Console.WriteLine("4. Rifdah Inas Nazhifah (29)");
                Console.WriteLine("========== Kalkulator ==========");
                Console.WriteLine("1. Tambah");
                Console.WriteLine("2. Kurang");
                Console.WriteLine("3. Kali");
                Console.WriteLine("4. Bagi");
                Console.Write("Masukkan Pilihanmu : ");
                int x = int.Parse(Console.ReadLine());

                switch (x)
                {
                    case 1:
                        calculator tambah = new calculator();
                        tambah.tambah();
                        break;
                    case 2:
                        calculator kurang = new calculator();
                        kurang.kurang();
                        break;
                    case 3:
                        calculator kali = new calculator();
                        kali.kali();
                        break;
                    case 4:
                        calculator bagi = new calculator();
                        bagi.bagi();
                        break;
                }
            }
            catch(FormatException)
            {
                Console.WriteLine("Maaf yang anda inputkan harusnya angka");
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("Maaf tidak bisa melakukan operasi");
            }
            finally
            {
                Console.WriteLine("Terimakasih telah menggunakan kalkulator kami");
            }
        }
    }
}
