using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task41
{
    class Program
    {
        static void InputArray(int m, int[] arr)
        {
            Console.WriteLine("Введите элементы массива: ");
            for (int i = 0; i < m; i++)
                arr[i] = int.Parse(Console.ReadLine());
        }

        static int OutputArray(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                    sum++;
            }
            return sum;
        }

        static void Main(string[] args)
        {
            Console.Write("Введите количество элементов в массиве: ");
            int M = int.Parse(Console.ReadLine());
            int[] array = new int[M];
            InputArray(M, array);
            Console.WriteLine("Количество чисел больше нуля: {0}", OutputArray(array));
        }
    }
}
