using System;

namespace Task34
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

        static void OutputSumArray(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
                if (i % 2 != 0) sum += arr[i];
            Console.Write("Сумма элементов, стоящих на нечётных позициях (нумерация с 0, 0 чётный) = ");
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
            OutputSumArray(array);
        }
    }
}
