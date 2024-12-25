using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Function();
            Console.ReadKey();
        }
        static void Function()
        {
            double price = 20.4;
            for (int i=2; i<=20; i++)
            {
                Console.WriteLine($"{i} шт = {price*i} руб");
            }
        }
    }
}
