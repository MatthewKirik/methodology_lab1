using System;
using App.Localization;
using App.Math;

namespace App.Modes
{
    public class InteractiveMode : Mode
    {
        public override void Start()
        {
            var (a, b, c) = ReadData();
            Mode.Solve(a, b, c);
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
    }
}