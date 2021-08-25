using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using basicGrammertestnamespace;
using cSharpSelfLearn.basiclanguage;


class classExtre
{
     public string GetWeatherFromOutside(int weather)
    {
        return weather.ToString();
    }

     public enum testEnumOutside : byte
     {
         north = 1,
         south = 2,
         
     }
     
    
}

class basicJudge{

    enum MyEnum : int
    {
        west = 1,
        east = Int32.MaxValue, 
    }

    static string GetWeatherDisplay(int tempInCelsius){
         StringBuilder stringBuilder = new StringBuilder();
         stringBuilder.Append("123");
         if (tempInCelsius < 20 ) Console.WriteLine("cold");
         string result = stringBuilder.ToString();
         return result;
    }

    private static double Add(double arg1, double arg2)
    {
        return arg1 + arg2;
    }

    public static void CalcExpression()
    {
        
        var cal = new Calc();
        cal.Arg1 = 12;
        cal.Arg2 = 34;
        cal.Operator = Add;
        var result= cal.Handler();
        Console.WriteLine(result);
    }

    public static void IntoData()
    {
        int result = Convert.ToInt32(13L);
        int target = Convert.ToInt32(22L);
        GetWeatherDisplay(result);
        classExtre ex = new classExtre();
        string weatherFromOutside = ex.GetWeatherFromOutside(target);
        Console.WriteLine(weatherFromOutside);
        basicGrammertestnamespace.program.programInside();
        testnamespace.Program.programInside();
        classExtre.testEnumOutside testEnumOutside = classExtre.testEnumOutside.north;
        Console.WriteLine(testEnumOutside);
        var enumOutside = (byte) testEnumOutside;
        Console.WriteLine(enumOutside);
        int east = (int) MyEnum.east;
        Console.WriteLine(east);

        string addTotalToString = BasicDelegate.addTotalToString(result, target, BasicDelegate.totalToString);
        Console.WriteLine(addTotalToString);
        Console.WriteLine(addTotalToString.GetType());
    }
}