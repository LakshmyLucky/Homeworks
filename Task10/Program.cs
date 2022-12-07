using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите трехзначное число: ");
            string str = Console.ReadLine();

            if (str.Length != 3)
            {
                Console.WriteLine("Это не трехзначное число");
                return;
            }

            int a;
            int.TryParse(str, out a);
            if (a == 0)
            {
                Console.WriteLine("Ошибка преобразования числа");
                return;
            }

            Console.WriteLine("Вторая цифра трехначного числа: {0}", str[1]);
        }
    }
}
