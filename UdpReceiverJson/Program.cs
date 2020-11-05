using System;

namespace UdpReceiverJson
{
    class Program
    {
        static void Main(string[] args)
        {
            ReceiverWorker worker = new ReceiverWorker();
            worker.Start();

            Console.ReadLine();
            Console.WriteLine("Hello World!");
        }
    }
}
