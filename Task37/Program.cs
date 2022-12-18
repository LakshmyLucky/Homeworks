using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task37
{
 
    class Program
    {

        static int[] InputArray(int[] arr)
        {
            //Честно - с рандомом в # ни разу не работала, не знаю как правильно
            Random random = new Random();

            for (int i = 0; i < arr.Length; i++)
                arr[i] = random.Next(100, 999);

            return arr;
        }

        static void OutputArray(int[] arr)
        {
            Console.WriteLine("Исходный массив");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i].ToString());
                Console.Write(" ");
            }
            Console.WriteLine();
        }

        static void OutputEvenArray(int[] arr)
        {
            byte sum = 0;
            for (int i = 0; i < arr.Length; i++)
                if (arr[i] % 2 == 0) sum++;
            Console.Write("Количество чётных чисел в массиве = ");
            Console.WriteLine(sum);
        }
        static void Main(string[] args)
        {
            int[] array = new int[10];

            //Фомирование массива
            InputArray(array);
            //Вывод массива
            OutputArray(array);
            //Вывод результата
            OutputEvenArray(array);
        }
    }
}
