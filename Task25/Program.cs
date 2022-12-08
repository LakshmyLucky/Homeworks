using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task25
{
    class Program
    {
        //Проверка числа на вшивость :)
        static bool CheckNumber(string s)
        {
            int q;

            int.TryParse(s, out q);
            if (q == 0)
            {
                Console.WriteLine("Ошибка преобразования числа");
                return false;
            }
            return true;
        }

        static void Main(string[] args)
        {
            int a, b;
            string str;

            Console.Write("Введите число a: ");
            str = Console.ReadLine();
            if (CheckNumber(str))
                a = Convert.ToInt32(str);
            else return;

            Console.Write("Введите число b: ");
            str = Console.ReadLine();
            if (CheckNumber(str))
                b = Convert.ToInt32(str);
            else return;

            int z = 1;
            for (int i = 0; i < b; i++) z *= a;

            Console.WriteLine("Число {0}, возведенное в степень {1} = {2}", a, b, z);
        }
    }
}
