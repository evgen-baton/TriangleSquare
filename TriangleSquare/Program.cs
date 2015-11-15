
using System;

namespace TriangleSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            var triangle = new Triangle(6, 8, 10);
            Console.WriteLine(triangle.CanTriangleExist());
            Console.WriteLine(triangle.GetSquare());

            Console.ReadLine();
        }
    }
}
