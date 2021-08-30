using System;
using System.Collections.Generic;
using System.Timers;

//using System.Timers;



namespace cSharpSelfLearn.InjectedAndPoolTest
{
    public delegate void MessageHandler(string messageText);
    public class Connections 
    {
        public event MessageHandler MessageArrived;
        private Timer pollTimer;
        public Connections()
        {
            pollTimer = new Timer(1000);
            pollTimer.Elapsed += new ElapsedEventHandler(CheckForMessage);
        }
        public void Connect() => pollTimer.Start();
        public void Disconnect() => pollTimer.Stop();
        private static Random random = new Random();
        private void CheckForMessage(object source, ElapsedEventArgs e)
        {
            Console.WriteLine("Checking for new messages.");
            if ((random.Next(5) == 0) && (MessageArrived != null))
            {
                MessageArrived("Hello Donna!");
            }
        }
        
    }
}