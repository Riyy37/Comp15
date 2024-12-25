using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29
{
    /// <summary>
    /// Генерируются 10 случайных целых чисел в интервале (-40, 40). Вывести эти числа.
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
            Random random = new Random();
            for(int x=0; x < 10; x++)
            {
                int number = random.Next(-40,40);
                Console.WriteLine(number);
            }
        }
    }
}
