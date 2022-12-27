using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task52
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
                    Console.Write("{0,5} ", arr[i, j]);

                Console.WriteLine();
            }
        }
        //Подсчет и вывод среднего арифметического по каждому столбцу
        static void GetAverage(int[,] arr, int m, int n)
        {
            float sum;
            //Идем по столбцам
            for (int j = 0; j < n; j++)
            {
                sum = 0;
                for (int i = 0; i < m; i++)
                    sum += arr[i, j];

                Console.Write("{0:F} ", sum / m);
            }
            Console.WriteLine();
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
            Console.WriteLine("---Сгенерированный массив---");

            OutputArray(array, m, n);
            GetAverage(array, m, n);
        }
    }
}
