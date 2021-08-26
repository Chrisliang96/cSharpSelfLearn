using System;

namespace cSharpSelfLearn.ObjectOriented
{
    public class DemoClass
    {
        private string name { set; get; }
        private int age { set; get; }

        public DemoClass(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void ToString()
        {
            Console.WriteLine(name+age);
        }
    }
}