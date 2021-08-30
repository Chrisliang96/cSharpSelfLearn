using System;

namespace cSharpSelfLearn.InjectedAndPoolTest
{
    public class Display
    {
        public void DisplayMessage(string message)
            => Console.WriteLine($"Message arrived: {message}");
    }
}