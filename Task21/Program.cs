using System;

namespace Task21
{
    class Program
    {
        static void InputPoint(out double x, out double y, out double z)
        {
            Console.Write("x = ");
            double.TryParse(Console.ReadLine(), out x);
            Console.Write("y = ");
            double.TryParse(Console.ReadLine(), out y);
            Console.Write("z = ");
            double.TryParse(Console.ReadLine(), out z);
        }

        static void Main(string[] args)
        {
            double aX, aY, aZ, bX, bY, bZ, distance;

            Console.WriteLine("Введите координаты точки A: ");
            InputPoint(out aX, out aY, out aZ);
            Console.WriteLine("Введите координаты точки B: ");
            InputPoint(out bX, out bY, out bZ);

            distance = Math.Sqrt(Math.Pow((bX - aX), 2) +
                Math.Pow((bY - aY), 2) + Math.Pow((bZ - aZ), 2));

            Console.WriteLine("Расстояние между двумя точками = {0:f}", distance);
        }
    }
}
