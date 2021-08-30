using System;

namespace cSharpSelfLearn.InjectedAndPoolTest
{
    public class Program
    {
        public void TestInjectAndPool()
        {
            Connections myConnection = new Connections();
            Display myDisplay = new Display();
            myDisplay.DisplayMessage("MAIN INPUT");
            myConnection.MessageArrived +=
                new MessageHandler(myDisplay.DisplayMessage);
            myConnection.Connect();
            Console.ReadKey();
        }
    }
}