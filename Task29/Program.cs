using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task29
{
    class Program
    {
        static void InputArray(byte[] arr)
        {
            Console.WriteLine("Введите массив из 8 элементов:");

            for (int i = 0; i < arr.Length; i++)
                byte.TryParse(Console.ReadLine(), out arr[i]);
        }

        static void OutputArray(byte[] arr)
        {
            Console.Write("[");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0}", arr[i]);

                //Просто для красоты, чтобы лишнего пробела перед ] не было :)
                if (i != arr.Length - 1)
                    Console.Write(" ");
            }
            Console.WriteLine("]");
        }

        static void Main(string[] args)
        {
            byte[] array = new byte[8];
            InputArray(array);
            OutputArray(array);
        }
    }
}
