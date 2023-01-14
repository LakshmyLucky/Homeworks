using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task66
{
    class Program
    {
        static int Recursion(int m, int n)
        {
            if (m == n) return m;
            return m + Recursion(m + 1, n);
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
