using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task27
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

            int sum = 0;
            for (int i = 0; i < str.Length; i++)
            {
                sum += int.Parse(str[i].ToString());
            }

            Console.WriteLine("Сумма цифр равна {0}", sum);
        }
    }
}
