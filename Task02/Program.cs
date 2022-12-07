using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task02
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;

            Console.Write("Введите число a: ");
            int.TryParse(Console.ReadLine(), out a);
            Console.Write("Введите число b: ");
            int.TryParse(Console.ReadLine(), out b);

            if (a == b)
                Console.WriteLine("Числа равны");
            else
                if (a > b)
                Console.WriteLine("max = {0}", a);
            else
                Console.WriteLine("max = {0}", b);
        }
    }
}
