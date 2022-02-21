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
    }
}