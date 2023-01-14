using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task64
{
    class Program
    {
        static void Recursion(int n)
        {
            if (n < 1) return;

            Console.Write(n + " ");
            Recursion(n - 1);
        }
        static void Main(string[] args)
        {
            Console.Write("Введите число N: ");
            int n;
            int.TryParse(Console.ReadLine(), out n);
            Recursion(n);
            Console.WriteLine();
        }
    }
}
