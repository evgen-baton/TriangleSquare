using static System.Math;
namespace TriangleSquare
{
    public class Triangle
    {
        public Triangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        /// <summary>
        /// Triangle's side
        /// </summary>
        public double SideA { get; private set; }
        /// <summary>
        /// Triangle's side
        /// </summary>
        public double SideB { get; private set; }
        /// <summary>
        /// Triangle's side
        /// </summary>
        public double SideC { get; private set; }
        /// <summary>
        /// Triangle's perimeter
        /// </summary>
        public double Perimeter => SideA + SideB + SideC;
        /// <summary>
        /// Checks whether such triangle can exist
        /// </summary>
        /// <returns></returns>
        public bool CanTriangleExist()
        {
            return CanTriangleExist(this);
        }
        /// <summary>
        /// Calculates square of such triangle
        /// </summary>
        /// <returns></returns>
        public double GetSquare()
        {
            return GetSquare(this);
        }
        /// <summary>
        /// Checks whether such triangle can exist
        /// </summary>
        /// <param name="triangle">Triangle to check</param>
        /// <returns></returns>
        public static bool CanTriangleExist(Triangle triangle)
        {
            if (triangle.SideA + triangle.SideB <= triangle.SideC)
            {
                return false;
            }
            if (triangle.SideA + triangle.SideC <= triangle.SideB)
            {
                return false;
            }
            if (triangle.SideB + triangle.SideC <= triangle.SideA)
            {
                return false;
            }
            return true;
        }
        /// <summary>
        /// Calculates square of the triangle
        /// </summary>
        /// <param name="triangle">Triangle to calculate</param>
        /// <returns></returns>
        public static double GetSquare(Triangle triangle)
        {
            double p = triangle.Perimeter/2;

            return Sqrt(p*(p - triangle.SideA)*(p - triangle.SideB)*(p - triangle.SideC));
        }
    }
}
