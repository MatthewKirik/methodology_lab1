using System;
using App.Localization;
using App.Modes;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            IMode mode = null;
            if (args.Length == 0)
                mode = new InteractiveMode();
            else if (args.Length == 1)
                mode = new FileMode(args[0]);
            
            if (mode == null)
                Console.WriteLine(Locale.WrongArgumentsMsg);
            else
                mode.Start();
        }
    }
}
