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
    }
}