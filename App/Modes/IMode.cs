using System;
using App.Localization;
using App.Math;

namespace App.Modes
{
    public abstract class IMode
    {
        public abstract void Start();

        protected static void Solve(double a, double b, double c)
        {
            Console.WriteLine(Locale.FinalEquationMsg(a, b, c));
            var solution = EquationSolver.Solve(a, b, c);
            switch (solution.type)
            {
                case QuadraticEquasionResultType.NoRoots:
                    Console.WriteLine(Locale.NoRootsMsg);
                    break;
                case QuadraticEquasionResultType.SingleRoot:
                    Console.WriteLine(Locale.SingleRootMsg(solution.x1));
                    break;
                case QuadraticEquasionResultType.TwoRoots:
                    Console.WriteLine(Locale.TwoRootsMsg(solution.x1, solution.x2));
                    break;
            }
        }
    }
}