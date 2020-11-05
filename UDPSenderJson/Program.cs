using System;

namespace UDPSenderJson
{
    class Program
    {
        static void Main(string[] args)
        {
            SenderWorker worker = new SenderWorker();
            worker.Start();

            Console.ReadLine();
            Console.WriteLine("Hello World!");
        }
    }
}
