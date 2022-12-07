using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            string str = Console.ReadLine();

            //Проверяем, число ли введено
            int a;
            int.TryParse(str, out a);
            if (a == 0)
            {
                Console.WriteLine("Ошибка преобразования числа");
                return;
            }

            if (a < 1 | a > 7)
            {
                Console.WriteLine("День недели задается числом от 1 до 7");
                return;
            }

            if (a == 6 | a == 7)
                Console.WriteLine("Это выходной: {0}", a);
            else
                Console.WriteLine("Это не выходной: {0}", a);
        }
    }
}
