using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task64
{
    class Program
    {
        static void Rec(int n)
        {
            while (n > 0)
            {
                Console.Write("{0} ", n);
                n--;
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Введите число N: ");
            int N;
            int.TryParse(Console.ReadLine(), out N);
            Console.Write("Результат: ");
            Rec(N);
            Console.WriteLine();
        }
    }
}
