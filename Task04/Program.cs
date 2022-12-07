using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, max;

            Console.Write("Введите число a: ");
            int.TryParse(Console.ReadLine(), out a);
            Console.Write("Введите число b: ");
            int.TryParse(Console.ReadLine(), out b);
            Console.Write("Введите число c: ");
            int.TryParse(Console.ReadLine(), out c);

            if (a == b & a == c)
                Console.WriteLine("Числа равны");
            else
            {
                max = a;
                if (b > max) max = b;
                if (c > max) max = c;
                Console.WriteLine("max = {0}", max);
            }
        }
    }
}
