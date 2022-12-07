using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task08
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n;

            Console.Write("Введите число n: ");
            byte.TryParse(Console.ReadLine(), out n);

            if (n <= 1)
            {
                Console.WriteLine("В последовательности нет четных чисел");
                return;
            }

            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                    Console.Write("{0} ", i);
            }

            Console.WriteLine();
        }
    }
}
