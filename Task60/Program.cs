using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task60
{
    class Program
    {
        //Формирование массива
        static void InputArray(int[,,] arr)
        {
            Random random = new Random();
            HashSet<int> hashSet = new HashSet<int>();
            //Общая длина массива
            int lengthArray = arr.GetLength(0) * arr.GetLength(1) * arr.GetLength(2);

            //С помощью HashSet формируем набор уникальных значений
            while (hashSet.Count != lengthArray)
                hashSet.Add(random.Next(1, 1000));

            int z = 0;
            int[] arrHashSet = hashSet.ToArray();

            //Теперь формируем наш массив
            while (z < hashSet.Count)
            {
                for (int i = 0; i < arr.GetLength(0); i++)
                    for (int j = 0; j < arr.GetLength(1); j++)
                        for (int k = 0; k < arr.GetLength(2); k++)
                        {
                            arr[i, j, k] = arrHashSet[z];
                            z++;
                        }
            }
        }
        //Вывод сформированного массива
        static void OutputArray(int[,,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    for (int k = 0; k < arr.GetLength(2); k++)
                    {
                        Console.Write("{0, 4} ", arr[i, j, k]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int x, y, z;

            Console.Write("Введите количество элементов по x: ");
            int.TryParse(Console.ReadLine(), out x);
            Console.Write("Введите количество элементов по y: ");
            int.TryParse(Console.ReadLine(), out y);
            Console.Write("Введите количество элементов по z: ");
            int.TryParse(Console.ReadLine(), out z);

            //Ограничиваем размерность массива в связи с ограничением Random в InputArray
            if (x * y * z > 99)
            {
                Console.WriteLine("Некорректный размер массива!");
                return;
            }

            int[,,] array = new int[x, y, z];
            InputArray(array);
            OutputArray(array);
        }
    }
}
