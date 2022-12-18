using System;

namespace Task34
{

    class Program
    {
        static float[] InputArray(float[] arr)
        {
            //Честно - с рандомом в # ни разу не работала, не знаю как правильно
            Random random = new Random();

            for (int i = 0; i < arr.Length; i++)
                arr[i] = random.Next(100, 999);

            return arr;
        }

        static void OutputArray(float[] arr)
        {
            Console.WriteLine("Исходный массив");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i].ToString());
                Console.Write(" ");
            }
            Console.WriteLine();
        }

        static void MinMax(float[] arr)
        {
            float min = arr[0], max = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min) min = arr[i];
                if (arr[i] > max) max = arr[i];
            }
            Console.Write("Максимальный элемент = ");
            Console.WriteLine(max);
            Console.Write("Минимальный элемент = ");
            Console.WriteLine(min);
            Console.Write("Разница между максимальным и минимальным элементами = ");
            Console.WriteLine(max - min);
        }
        static void Main(string[] args)
        {
            float[] array = new float[10];

            //Фомирование массива
            InputArray(array);
            //Вывод массива
            OutputArray(array);
            //Вывод результата
            MinMax(array);
        }
    }
}
