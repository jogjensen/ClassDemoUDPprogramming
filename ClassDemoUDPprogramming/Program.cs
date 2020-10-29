using System;

namespace ClassDemoUDPprogramming
{
    class Program
    {
        static void Main(string[] args)
        {
            UDPWorker worker = new UDPWorker();
            worker.Start();


            Console.WriteLine("Hello World!");
        }
    }
}
