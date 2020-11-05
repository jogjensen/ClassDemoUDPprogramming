using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using ModelLibrary.model;
using Newtonsoft.Json;

namespace UdpReceiverJson
{
    internal class ReceiverWorker
    {
        public ReceiverWorker()
        {
        }

        public void Start()
        {
            UdpClient client = new UdpClient(10110); // modtage pakker på 10110 port nummer

            byte[] buffer;

            while (true)
            {
                IPEndPoint remoteEP = new IPEndPoint(IPAddress.Any, 0);
                buffer = client.Receive(ref remoteEP);
                string jsonStr = Encoding.UTF8.GetString(buffer);
                Car car = JsonConvert.DeserializeObject<Car>(jsonStr);


                Console.WriteLine("Bil modtaget :\n" + car);

                // sender en 'alm' tostring tekst tilbage
                byte[] outbuffer = Encoding.UTF8.GetBytes(car.ToString());
                client.Send(outbuffer, outbuffer.Length, remoteEP);
            }
        }
    }
}