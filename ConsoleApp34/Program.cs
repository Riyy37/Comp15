using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp34
{
    /// <summary>
    /// Напишите программу, которая вычисляет сумму всех целых чисел от 1 до N, 
    /// где N вводится пользователем.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = InPut("Введите n-число = ");
            int sum = Function(n);
            Console.WriteLine($"Сумма чисел от 1 до {n} = {sum}");
            Console.ReadKey();

        }
        static int Function(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                
                
                    sum += i;
                
            }
            return sum;
        }
        static int InPut(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }
    }
}
