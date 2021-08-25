using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testnamespace
{
    class Program
    {
        public static  String programInside()
        {
            return "test";
        }
    }
}

namespace basicGrammertestnamespace{
    class program{
            
        public static void programInside ( ){
            double firstNumber = 2L;
            double secondNumber = 3L;
            string userName = "lhb";
            Console.WriteLine("Enter your name:");
            Console.WriteLine($"youname {userName}");
            
            Console.WriteLine("Now give me a number:");
            
            Console.WriteLine("Now give me another number:");
            Console.WriteLine($"The sum of {firstNumber} and {secondNumber} is " +
                          $"{firstNumber + secondNumber}.");
            Console.WriteLine($"The result of subtracting {secondNumber} from " +
                          $"{firstNumber} is {firstNumber - secondNumber}.");
            Console.WriteLine($"The product of {firstNumber} and {secondNumber} " +
                          $"is {firstNumber * secondNumber}.");
            Console.WriteLine($"The result of dividing {firstNumber} by " +
                          $"{secondNumber} is {firstNumber / secondNumber}.");
            Console.WriteLine($"The remainder after dividing {firstNumber} by " +
                          $"{secondNumber} is {firstNumber % secondNumber}.");
        }

    }

}