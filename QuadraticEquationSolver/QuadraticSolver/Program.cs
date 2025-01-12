using System;

namespace QuadraticSolver
{
    public class Solver
    {
        public static (double[] Roots, string Message) SolveQuadratic(double a, double b, double c)
        {
            if (a == 0)
            {
                return (null, "Not a quadratic equation.");
            }

            double discriminant = b * b - 4 * a * c;

            if (discriminant < 0)
            {
                return (null, "No real roots.");
            }
            else if (discriminant == 0)
            {
                double root = -b / (2 * a);
                return (new double[] { root }, "One real root.");
            }
            else
            {
                double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                return (new double[] { root1, root2 }, "Two real roots.");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var result = Solver.SolveQuadratic(1, -3, 2);
            Console.WriteLine(result.Message);
            if (result.Roots != null)
            {
                Console.WriteLine("Roots: " + string.Join(", ", result.Roots));
            }
        }
    }
}
