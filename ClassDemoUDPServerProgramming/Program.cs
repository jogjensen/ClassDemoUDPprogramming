using System;

namespace ClassDemoUDPServerProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            UDPServerWorker worker =  new UDPServerWorker();
            worker.Start();


            Console.WriteLine("Hello World!");
        }
    }
}
