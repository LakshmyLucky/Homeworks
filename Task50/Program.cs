using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task50
{
    class Program
    {
        static void InputArray(int[,] arr, int m, int n)
        {
            Random random = new Random();
            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                    arr[i, j] = random.Next(0, 53);
        }

        static void OutputArray(int[,] arr, int m, int n)
        {
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write("{0,3} ", arr[i, j]);
                Console.WriteLine();
            }
        }

        static int? FindItem(int[,] arr, int i, int j)
        {
            try
            {
                return arr[i - 1, j - 1];
            }
            catch (Exception ex)
            {
                Console.WriteLine();
                Console.WriteLine("Ошибка! {0} Элемент не найден.", ex.Message);
                return null;
            }
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

            Console.WriteLine();
            Console.WriteLine("---Поиск элемента в массиве---");
            Console.Write("Введите индекс строки (отсчет с 1): ");
            int i = int.Parse(Console.ReadLine());
            Console.Write("Введите индекс столбца (отсчет с 1): ");
            int j = int.Parse(Console.ReadLine());

            Console.WriteLine();
            int? result = FindItem(array, i, j);
            if (result != null)
                Console.WriteLine("Искомый элемент с индексом [{0}, {1}] = {2}", i, j, result);
            Console.WriteLine();
        }
    }
}
