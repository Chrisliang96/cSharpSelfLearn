using System;
using basicGrammertestnamespace;
using cSharpSelfLearn.basiclanguage;
using cSharpSelfLearn.BoxingGame.Combat.Services;
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
            //LinqMethod.LinqSearch.LinqSearchTest();
            Console.WriteLine("--MAN VS MONSTER--"); 
            Console.WriteLine("--Chrisliang's RPG--"); 
            GameSimulatorV1.Run();
        }
        
    }
}