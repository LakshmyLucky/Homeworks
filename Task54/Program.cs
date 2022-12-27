using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task54
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
        static int[,] SortToStrings(int[,] arr, int m, int n)
        {
            int temp;
            for (int k = 0; k < m; k++)
                for (int i = 0; i < n; i++)
                    for (int j = 0; j < n - 1; j++)
                        if (arr[k, j + 1] > arr[k, j])
                        {
                            temp = arr[k, j + 1];
                            arr[k, j + 1] = arr[k, j];
                            arr[k, j] = temp;
                        }
            return arr;
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

            SortToStrings(array, m, n);

            Console.WriteLine();
            Console.WriteLine("---Массив, отсортированный по убыванию по строкам---");
            OutputArray(array, m, n);
        }
    }
}
