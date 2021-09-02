using System;
using basicGrammertestnamespace;
using cSharpSelfLearn.basiclanguage;
using cSharpSelfLearn.ObjectOriented.ColonerableAndOperator;
using Microsoft.VisualBasic.CompilerServices;

namespace cSharpSelfLearn
{
    
    static class Mainclass
    {
        static void Main(String[] args)
        {
            // basicJudge.IntoData();
            // program.programInside();
            // basicJudge.CalcExpression();
            //basicException.TryExceptionAndLoop();
            //ObjectOriented.OperateDemoClass.TestDemo();
            //Console.WriteLine();
            //TestColonerAndOperator();
            //new InjectedAndPoolTest.Program().TestInjectAndPool();
            LinqMethod.LinqSearch.LinqSearchTest();
        }

        public static void TestColonerAndOperator()
        {
            Deck myDeck = new Deck();
            myDeck.Shuffle();
            for (int i = 0; i < 30; i++)
            {
                Card tempCard = myDeck.GetCard(i);
                Console.Write(tempCard.ToString() );
                if (i != 29)
                    Console.WriteLine(", ");
                else
                    Console.WriteLine();
            }
        }
    }
}