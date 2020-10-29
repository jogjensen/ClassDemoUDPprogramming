using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ClassDemoUDPprogramming
{
    internal class UDPWorker
    {
        public UDPWorker()
        {
        }

        public void Start()
        {

            UdpClient client = new UdpClient(); // modtage pakker på 7007 port nummer

            byte[] buffer;

                // Sender
                IPEndPoint modtagerEP = new IPEndPoint(IPAddress.Loopback, 7007);
                String str = "Hej Peter";
                byte[] outbuffer = Encoding.UTF8.GetBytes(str.ToCharArray());
                client.Send(outbuffer, outbuffer.Length, modtagerEP);


                // Modtager
                IPEndPoint remoteEP = new IPEndPoint(IPAddress.Any, 0);
                buffer = client.Receive(ref remoteEP);

                Console.WriteLine($"har modtaget en pakke kommer fra IP {remoteEP.Address} og port {remoteEP.Port}");
                string incommingstr = Encoding.UTF8.GetString(buffer);

                Console.WriteLine("tekst modtaget = " + incommingstr);





            



        }
    }
}