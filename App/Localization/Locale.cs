namespace App.Localization
{
    public static class Locale
    {
        public static string WrongArgumentsMsg = "You specified the wrong amount of arguments.";
            
        public static string GreetingMsg = "Hello! Please, enter a, b and c coefficients " +
                                            "as in an equation ax^2+bx+c=0";
        
        public static string APrompt = "a = ";
        
        public static string BPrompt = "b = ";
        
        public static string CPrompt = "c = ";
        
        public static string ParsingFailedMsg = "Sorry, parsing failed for the string you entered. " +
                                                 "Please, try again.";
        
        public static string FinalEquationMsg (double a, double b, double c) 
            => $"Equation is: ({a})x^2 + ({b})x + ({c}) = 0";
        
        public static string NoRootsMsg = "There are no roots for this equation";
        
        public static string SingleRootMsg(double x) 
            => $"There is single root x = {x}";
        
        public static string TwoRootsMsg(double x1, double x2) 
            => $"There are two roots: x1 = {x1}; x2 = {x2}";
    }
}