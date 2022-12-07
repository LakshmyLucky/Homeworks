using System;

namespace Task23
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.Write("Введите число n, отличное от нуля: ");
            int.TryParse(Console.ReadLine(), out n);

            if (n == 0)
            {
                Console.WriteLine("Ошибка преобразования числа");
                return;
            }

            for (int i = 1; i <= n; i++)
                Console.Write("{0} ", Math.Pow(i, 3));

            Console.WriteLine();
        }
    }
}
