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

        static int NumberPower(int a_, int b_)
        {
            int z = 1;
            for (int i = 0; i < b_; i++) z *= a_;
            return z;
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

            Console.WriteLine("Число {0}, возведенное в степень {1} = {2}", a, b, NumberPower(a, b));
        }
    }
}
