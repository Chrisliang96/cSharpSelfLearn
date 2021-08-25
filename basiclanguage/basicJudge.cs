using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using basicGrammertestnamespace;


class classExtre
{
     public string GetWeatherFromOutside(int weather)
    {
        return weather.ToString();
    }
}

class basicJudge{

    static string GetWeatherDisplay(int tempInCelsius){
         StringBuilder stringBuilder = new StringBuilder();
         stringBuilder.Append("123");
         if (tempInCelsius < 20 ) Console.WriteLine("cold");
         string result = stringBuilder.ToString();
         return result;
    }

    static void Main(String[] args){
        int result = Convert.ToInt32(13L);
        int target = Convert.ToInt32(22L);
        GetWeatherDisplay(result);
        classExtre ex = new classExtre();
        string weatherFromOutside = ex.GetWeatherFromOutside(target);
        Console.WriteLine(weatherFromOutside);
        basicGrammertestnamespace.program.programInside();
        testnamespace.Program.programInside();
    }
}