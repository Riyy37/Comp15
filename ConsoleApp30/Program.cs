using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp30
{
    /// <summary>
    /// Генерируются 15 случайных целых чисел в интервале (-20, 30). 
    /// Вывести эти числа и подсчитать количество положительных чисел.
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
            Random random = new Random();
            for (int x = 0; x < 15; x++)
            {
                int number = random.Next(-20, 30);
                Console.WriteLine(number);
                if (number > 0) count++;
            }
            Console.WriteLine($"Положительные числа = {count}");
        }
    }
}
