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
        
        public void Start()
        {
            // TODO: Implement file mode to solve equations using file input
            throw new System.NotImplementedException();
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
    }
}