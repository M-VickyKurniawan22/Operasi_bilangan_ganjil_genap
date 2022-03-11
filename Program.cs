using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menghitung_Bilangan_Ganjil_Genap
{
    /// <summary>
    /// main class
    /// </summary>
    public class Program
    {
        /// <summary>
        /// operasi menentukan bilangan ganjil genap
        /// </summary>
        /// <param name="Format"> Bilangan yang muncul adalah bilangan genap</param>
        /// <param name="Format"> Bilangan yang muncul adalah bilangan ganjil</param>
        /// <param name="n"> Bilanga yang di input</param>
        /// <returns>Menampilkan hasil bilangan itu ganjil atau genap</returns>
        private const string Format = "Bilangan {0} adalah genap";
        private const string Format1 = "Bilangan {0} adalah ganjil";
        public static void Main(string[] args)
        {

            double n;
  
            Console.Write("Masukkan Jumlah n Bilangan : ");
            n = Convert.ToDouble(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(Format, i);
                }
                else
                {
                    Console.WriteLine(Format1, i);
                }
            }
            Console.ReadKey();
        }
    }
}
