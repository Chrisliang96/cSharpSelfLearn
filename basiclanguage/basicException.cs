using System;

namespace cSharpSelfLearn.basiclanguage
{
    public class basicException
    {
        static string[] eTypes =
        {
            "none", "simple", "index",
            "nested index", "filter"
        };

        public static void TryExceptionAndLoop()
        {
            foreach (var eType in eTypes)
            {
                ThrowException(eType);
            }
        
        }

        static void ThrowException(string exception)
        {
            switch (exception)
            {
                case "none":
                    Console.WriteLine("Not throwing an exception.");
                    break; // Line 57
                case "simple":
                    Console.WriteLine("Throwing System.Exception.");
                    throw new System.Exception(); // Line 60
                case "index":
                    Console.WriteLine("Throwing System.IndexOutOfRangeException.");
                    eTypes[5] = "error"; // Line 63
                    break;
            }
        }

    }
}