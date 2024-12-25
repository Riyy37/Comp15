using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28
{
    /// <summary>
    /// Вывести четные двузначные числа и подсчитать их количество.
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
            int count = 0;

            for(int x=10;x<=99; x++)
            {
                if (x%2==0)
                {
                    count++;
                    Console.WriteLine(x);
                }
            }
            Console.WriteLine($"count = {count}");
        }
    }
}
