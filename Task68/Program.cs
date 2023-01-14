using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task68
{
    class Program
    {
        static int Recursion(int m, int n)
        {
            if (m == 0)
            {
                return n + 1;
            }
            else if (m > 0 && n == 0)
            {
                return Recursion(m - 1, 1);
            }
            else
            {
                return Recursion(m - 1, Recursion(m, n - 1));
            }
        }
        static void Main(string[] args)
        {
            int m, n;
            Console.Write("Введите число M: ");
            int.TryParse(Console.ReadLine(), out m);
            Console.Write("Введите число N: ");
            int.TryParse(Console.ReadLine(), out n);
            Console.WriteLine(Recursion(m, n));
        }
    }
}
