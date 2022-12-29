using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task58
{
    class Program
    {
        //Формирование массива
        static void InputArray(int[,] arr, int m, int n)
        {
            Random random = new Random();
            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                    arr[i, j] = random.Next(1, 10);
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
        //Перемножение матриц
        static int[,] MultiplicationArrays(int[,] arrA, int[,] arrB, int rowsA, int _ab, int colsB)
        {
            int[,] arrRes = new int[rowsA, colsB];
            int sum;

            for (int i = 0; i < rowsA; i++)
                for (int j = 0; j < colsB; j++)
                {
                    sum = 0;
                    for (int k = 0; k < _ab; k++)
                        sum += arrA[i, k] * arrB[k, j];

                    arrRes[i, j] = sum;
                }

            return arrRes;
        }

        static void Main(string[] args)
        {
            Console.Write("Введите количество строк массива A: ");
            int rows_A = int.Parse(Console.ReadLine());

            Console.Write("Введите количество столбцов массива A: ");
            int ab = int.Parse(Console.ReadLine());

            //Фикция для пользователя, это мы уже ввели в переменную ab
            Console.Write("Введите количество строк массива B: ");
            int f = int.Parse(Console.ReadLine());

            if (f != ab)
            {
                Console.WriteLine("Число строк массива A не совпадает с числом столбцов массива B!");
                return;
            }

            Console.Write("Введите количество столбцов массива B: ");
            int cols_B = int.Parse(Console.ReadLine());

            //Формируем исходные массивы
            int[,] arrayA = new int[rows_A, ab];
            int[,] arrayB = new int[ab, cols_B];
            InputArray(arrayA, rows_A, ab);
            InputArray(arrayB, ab, cols_B);

            //Выводим исходные массивы
            Console.WriteLine();

            Console.WriteLine("---Массив A---");
            OutputArray(arrayA, rows_A, ab);

            Console.WriteLine();

            Console.WriteLine("---Массив B---");
            OutputArray(arrayB, ab, cols_B);

            Console.WriteLine();

            //Формируем и выводим результирующий массив
            int[,] arrayResult = MultiplicationArrays(arrayA, arrayB, rows_A, ab, cols_B);
            Console.WriteLine("---Массив AxB---");
            OutputArray(arrayResult, rows_A, cols_B);
        }
    }
}
