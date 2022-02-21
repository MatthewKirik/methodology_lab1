using System;
using App.Localization;

namespace App.Modes
{
    public class InteractiveMode : IMode
    {
        public void Start()
        {
            var (a, b, c) = ReadData();
            Solve(a, b, c);
        }
        
        private static double ReadInt(string prompt)
        {
            double result = 0;
            var isInputCorrect = false;
            while (!isInputCorrect)
            {
                Console.WriteLine(prompt);
                string input = Console.ReadLine();
                isInputCorrect = double.TryParse(input, out result);
                if (!isInputCorrect)
                    Console.WriteLine(Locale.ParsingFailedMsg);
            }
            return result;
        }
        
        private static (double a, double b, double c) ReadData()
        {
            Console.WriteLine(Locale.GreetingMsg);
            var a = ReadInt(Locale.APrompt);
            var b = ReadInt(Locale.BPrompt);
            var c = ReadInt(Locale.CPrompt);
            return (a, b, c);
         }

        private static void Solve(double a, double b, double c)
        {
            Console.WriteLine(Locale.FinalEquationMsg(a, b, c));
            
            // find discriminant of the equation (https://en.wikipedia.org/wiki/Discriminant) 
            double d = b * b - 4 * a * c; 
            
            if (d < 0)
                Console.WriteLine(Locale.NoRootsMsg);
            else if (d == 0)
                SolveForSingleRoot(a, b);
            else
                SolveForTwoRoots(a, b, d);
        }

        private static void SolveForSingleRoot(double a, double b)
        {
            double x = -b / (2 * a);
            Console.WriteLine(Locale.SingleRootMsg(x));
        }
        private static void SolveForTwoRoots(double a, double b, double d)
        {
            double sqrtD = Math.Sqrt(d);
            double x1 = (-b + sqrtD) / (2 * a);
            double x2 = (-b - sqrtD) / (2 * a);
            Console.WriteLine(Locale.TwoRootsMsg(x1, x2));
        }
    }
}