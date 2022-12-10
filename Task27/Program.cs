using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task27
{
    class Program
    {
        static int Sum(string str_)
        {
            int sum = 0;
            for (int i = 0; i < str_.Length; i++)
                sum += int.Parse(str_[i].ToString());
            return sum;
        }
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

            Console.WriteLine("Сумма цифр равна {0}", Sum(str));
        }
    }
}
