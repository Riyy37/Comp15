using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp31
{
    /// <summary>
    /// Генерируется 12 случайных целых чисел в интервале (-50,50). 
    /// Вывести эти числа и сообщения: отрицательное-положительное.
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
            for (int x = 0; x < 12;x++)
            {
                int number = random.Next(-50, 50);
                
                if (number > 0)  Console.WriteLine($"{number} - положительные");
                if (number < 0) Console.WriteLine($"{number} - отрицательные");
            }
            
        }
    }
}
