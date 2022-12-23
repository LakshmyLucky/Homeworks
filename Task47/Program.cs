using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task47
{
    class Program
    {
        static void InputArray(double[,] arr, int m, int n)
        {
            Random random = new Random();
            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                    arr[i, j] = random.NextDouble() * 20 - 10;
        }

        static void OutputArray(double[,] arr, int m, int n)
        {
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write("{0,4:N1} ", arr[i, j]);
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Введите количество строк массива: ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Введите количество столбцов массива: ");
            int n = int.Parse(Console.ReadLine());

            double[,] array = new double[m, n];

            InputArray(array, m, n);

            Console.WriteLine("Сгенерированный массив:");
            OutputArray(array, m, n);
        }
    }
}
