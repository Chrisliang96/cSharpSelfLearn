using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Convert;

class basicJudge{

    static string GetWeatherDisplay(int tempInCelsius){
         if (tempInCelsius < 20 ) Console.WriteLine("cold");
         return null;
         
    }

    static void Main(String[] args){
        int result = ToInt32(13L);
        int target = ToInt32(22L);
        GetWeatherDisplay(result); 
    }
}