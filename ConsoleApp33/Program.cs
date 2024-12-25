using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp33
{
    /// <summary>
    /// Генерируется 10 случайных целых чисел в интервале (– 20, 20). 
    /// Выводятся только положительные числа и сообщения: четное – нечетное (for, if).
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
            for (int x = 0; x < 10; x++)
            {
                int number = random.Next(-20, 20);

                if (number > 0)
                {
                    if (number % 2 == 0)
                    {
                        Console.Write("Чётное = ");
                    }
                    else
                    {
                        Console.Write("Нечётное = ");
                    }
                    Console.WriteLine(number);
                }
                
            }
        }
    }
}
