using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication43
{
    /*
        x = (y-b1)/k1
        y = (k1*b2 - k2*b1)/(k1 - k2)
    */
    class Program
    {
        static void CrossingLines
            (float _k1, float _b1, float _k2, float _b2, out float _x, out float _y)
        {
            _y = (_k1*_b2 - _k2*_b1) / (_k1 - _k2);
            _x = (_y - _b1) / _k1;
        }
        static void Main(string[] args)
        {
            float[] k = new float[2];//k[0] = k1, k[1] = k2
            float[] b = new float[2];//b[0] = b1, b[1] = b2
            float[] point = new float[2];//point[0] = x, point[1] = y

            Console.WriteLine("Введите данные для двух прямых");
            Console.Write("Для первой прямой k1 = ");
            k[0] = float.Parse(Console.ReadLine());
            Console.Write("Для первой прямой b1 = ");
            b[0] = float.Parse(Console.ReadLine());
            Console.Write("Для второй прямой k2 = ");
            k[1] = float.Parse(Console.ReadLine());
            Console.Write("Для второй прямой b2 = ");
            b[1] = float.Parse(Console.ReadLine());


            CrossingLines(k[0], b[0], k[1], b[1], out point[0], out point[1]);

            Console.WriteLine("Точка пересечения двух прямых = [{0}; {1}]", 
                point[0], point[1]);
        }
    }
}
