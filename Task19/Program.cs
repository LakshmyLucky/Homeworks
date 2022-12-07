using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите пятизначное число: ");
            string str = Console.ReadLine();

            //Проверяем, число ли введено
            int a;
            int.TryParse(str, out a);
            if (a == 0)
            {
                Console.WriteLine("Ошибка преобразования числа");
                return;
            }

            if (str.Length != 5)
            {
                Console.WriteLine("Это не пятизначное число");
                return;
            }

            int j = str.Length - 1;
            bool flag = true; //Признак что число является или не является полиндромом 

            for (int i = 0; i < j; i++)
                if (i != j)//Чтобы не сравнивать центральное число само с собой
                {
                    if (str[i] != str[j])
                    {
                        flag = false;
                        break;
                    }
                    j--;
                }

            Console.WriteLine(flag ? "Число является полиндромом" : "Число не является полиндромом");
        }
    }
}
