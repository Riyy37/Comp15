using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp32
{
    /// <summary>
    /// Генерируется 8 случайных целых чисел в интервале (–30, 30). 
    /// Выводятся эти числа и сообщения: отрицательное – положительное, четное – нечетное (for, if).
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
            for (int x = 0; x < 8; x++)
            {
                int number = random.Next(-30, 30);
                //string num = number > 0 ? "положительное" : "отрицательное";
                //string num1 = x % 2 == 0 ? "чётное" : "нечётное";

                if (number > 0)
                {
                    Console.Write("положительное, ");
                }
                else 
                {
                    Console.Write("отрицательное, ");
                }

                if (number % 2 == 0)
                {
                    Console.Write("чётное = ");
                }
                else
                {
                    Console.Write("нечётное = ");
                }

                if (number == 0)
                {
                    Console.Write("Ноль = ");
                }
                Console.WriteLine(number);
            }

        }
    }
}
