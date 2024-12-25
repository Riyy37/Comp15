using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    /// <summary>
    /// Напечатать ряд чисел 20 в виде: 20 20 20 20 20 20 20 20 20 20.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Function();
            Console.ReadKey();
        }
        static void Function()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.Write("20 ");
            }
        }
    }
}
