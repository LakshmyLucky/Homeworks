using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task06
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;

            Console.Write("Введите число: ");
            int.TryParse(Console.ReadLine(), out a);

            if (a % 2 == 0)
                Console.WriteLine("Введенное число четное");
            else
                Console.WriteLine("Введенное число нечетное");
        }
    }
}
