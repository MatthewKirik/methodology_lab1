using System;

namespace App.Modes
{
    public class InteractiveMode : IMode
    {
        private static string greetingMsg = "Hello! Please, enter a, b and c coefficients " +
                                            "as in an equation ax^2+bx+c=0";
        private static string aPrompt = "a = ";
        private static string bPrompt = "b = ";
        private static string cPrompt = "c = ";
        private static string parsingFailedMsg = "Sorry, parsing failed for the string you entered. " +
                                                 "Please, try again.";
        private static string finalEquationMsg (double a, double b, double c) 
            => $"Equation is: ({a})x^2 + ({b})x + ({c}) = 0";
        private static string noRootsMsg = "There are no roots for this equation";
        
        public void Start()
        {
            // TODO: Implement solving equations in interactive mode.
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
                    Console.WriteLine(parsingFailedMsg);
            }
            return result;
        }
        
        private static (double, double, double) ReadData()
        {
            Console.WriteLine(greetingMsg);
            var a = ReadInt(aPrompt);
            var b = ReadInt(bPrompt);
            var c = ReadInt(cPrompt);
            return (a, b, c);
        }

        private static void Solve(double a, double b, double c)
        {
            Console.WriteLine(finalEquationMsg(a, b, c));
            
            // find discriminant of the equation (https://en.wikipedia.org/wiki/Discriminant) 
            double d = b * b - 4 * a * c; 
            
            if (d < 0)
                Console.WriteLine(noRootsMsg);
            else if (d == 0)
                SolveForSingleRoot(a, b, c);
            else
                SolveForTwoRoots(a, b, c);
        }

        private static void SolveForSingleRoot(double a, double b, double c)
        {
            // TODO: Implement solving an equation for single root (d=0)
            throw new NotImplementedException();
        }
        private static void SolveForTwoRoots(double a, double b, double c)
        {
            // TODO: Implement solving an equation for two roots (d>0)
            throw new NotImplementedException();
        }
    }
}