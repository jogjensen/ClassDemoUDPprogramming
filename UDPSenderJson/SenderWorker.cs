using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using ModelLibrary.model;
using Newtonsoft.Json;

namespace UDPSenderJson
{
    public class SenderWorker
    {
        public SenderWorker()
        {
        }

        public void Start()
        {
            UdpClient client = new UdpClient(); 

            byte[] buffer;

            // opretter en bil og lave en json string
            Car car = new Car("Tesla", "Green", "EL23401");
            String jsonString = JsonConvert.SerializeObject(car);

            // Sender
            IPEndPoint modtagerEP = new IPEndPoint(IPAddress.Loopback, 10110);
            byte[] outbuffer = Encoding.UTF8.GetBytes(jsonString);
            client.Send(outbuffer, outbuffer.Length, modtagerEP);


            // Modtager
            IPEndPoint remoteEP = new IPEndPoint(IPAddress.Any, 0);
            buffer = client.Receive(ref remoteEP);
            string incommingstr = Encoding.UTF8.GetString(buffer);

            Console.WriteLine("tekst modtaget = " + incommingstr);
        }
    }
}