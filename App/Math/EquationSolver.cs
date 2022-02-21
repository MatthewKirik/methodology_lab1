namespace App.Math
{
    public enum QuadraticEquasionResultType
    {
        NoRoots,
        SingleRoot,
        TwoRoots
    }

    public class EquationSolver
    {
        public static (QuadraticEquasionResultType type, double x1, double x2) 
            Solve(double a, double b, double c)
        {
            // find discriminant of the equation (https://en.wikipedia.org/wiki/Discriminant) 
            double d = b * b - 4 * a * c; 
            if (d < 0)
                return (QuadraticEquasionResultType.NoRoots, 0, 0);
            if (d == 0)
            {
                double x = -b / (2 * a);
                return (QuadraticEquasionResultType.SingleRoot, x, 0);
            }
            else
            {
                double sqrtD = System.Math.Sqrt(d);
                double x1 = (-b + sqrtD) / (2 * a);
                double x2 = (-b - sqrtD) / (2 * a);
                return (QuadraticEquasionResultType.TwoRoots, x1, x2);
            }
        }
    }
}