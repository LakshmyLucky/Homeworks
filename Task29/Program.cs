using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task29
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] array = new byte[8];

            Console.WriteLine("Введите массив из 8 элементов:");

            for (int i = 0; i < array.Length; i++)
                byte.TryParse(Console.ReadLine(), out array[i]);

            Console.Write("[");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0}", array[i]);

                //Просто для красоты, чтобы лишнего пробела перед ] не было :)
                if (i != array.Length - 1)
                    Console.Write(" ");
            }
            Console.WriteLine("]");
        }
    }
}
