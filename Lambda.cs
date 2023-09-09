using Amazon.Runtime.Internal.Util;

namespace MyApp
{
    public class Lambda
    {
        public string FunctionHandler(string input) {
            Console.WriteLine("Hello World");

            return input.ToUpper();
        }
    }   
}