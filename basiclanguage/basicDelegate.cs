using System;
using basicGrammertestnamespace;

namespace cSharpSelfLearn.basiclanguage
{
    public class BasicDelegate
    {
        public static string totalToString(int input1, int input2) => (input2*input1).ToString();
        
        public static string addTotalToString(int input1, int input2, Func<int, int, string> handle)
        {
            int a;
            System.Int32 b;
            string abc;
            System.String bcd;
            return handle(input1, input2);
        }
    }

    public class Calc
    {
        public double Arg1 { get; set; }
        public double Arg2 { get; set; }
        public Func<double,double,double> Operator { get; set; }

        public double Handler()
        {
            return Operator(Arg1, Arg2);
        }
    }
}