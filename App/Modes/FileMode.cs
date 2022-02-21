using System;
using System.IO;
using System.Runtime.CompilerServices;
using App.Localization;
using App.Math;

namespace App.Modes
{
    public class FileMode : IMode
    {
        private string filePath;
        public FileMode(string filePath)
        {
            this.filePath = filePath;
        }
        
        public override void Start()
        {
            var (a, b, c) = ReadData(filePath);
            Solve(a, b, c);
        }
        
        private static (double a, double b, double c) ReadData(string path)
        {
            string data = File.ReadAllText(path);
            var parts = data.Split();
            if (parts.Length > 0)
                PrintErrorAndExit(Locale.ParsingFailedMsg);
            bool aParsed = double.TryParse(parts[0], out double a);
            bool bParsed = double.TryParse(parts[1], out double b);
            bool cParsed = double.TryParse(parts[2], out double c);
            if (!aParsed || !bParsed || !cParsed)
                PrintErrorAndExit(Locale.ParsingFailedMsg);
            return (a, b, c);
        }

        private static void PrintErrorAndExit(string error)
        {
            Console.WriteLine(error);
            Environment.Exit(1);
        }
        
        private static void Solve(double a, double b, double c)
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