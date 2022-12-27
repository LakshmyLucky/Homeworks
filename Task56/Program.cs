using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task56
{
    class Program
    {
        //Формирование массива
        static void InputArray(int[,] arr, int m, int n)
        {
            Random random = new Random();
            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                    arr[i, j] = random.Next(0, 50);
        }
        //Вывод массива
        static void OutputArray(int[,] arr, int m, int n)
        {
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write("{0,3} ", arr[i, j]);
                Console.WriteLine();
            }
        }
        //Подсчет и вывод среднего арифметического по каждому столбцу
        static int SumToStrings(int[,] arr, int m, int n)
        {
            int[] arrSum = new int[m];

            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                    arrSum[i] += arr[i, j];

            int min = arrSum[0], str = 0;
            for (int i = 1; i < m; i++)
                if (arrSum[i] < min)
                {
                    min = arrSum[i];
                    str = i;
                }

            return str + 1;
        }

        static void Main(string[] args)
        {
            Console.Write("Введите количество строк массива: ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Введите количество столбцов массива: ");
            int n = int.Parse(Console.ReadLine());

            int[,] array = new int[m, n];

            InputArray(array, m, n);

            Console.WriteLine();
            Console.WriteLine("---Исходный массив---");
            OutputArray(array, m, n);

            Console.WriteLine();
            Console.WriteLine("Наименьшая сумма элементов в {0} строке",
                SumToStrings(array, m, n));
        }
    }
}
