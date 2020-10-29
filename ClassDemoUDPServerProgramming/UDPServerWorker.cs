using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ClassDemoUDPServerProgramming
{
    internal class UDPServerWorker
    {
        public UDPServerWorker()
        {
        }

        public void Start()
        {
            UdpClient client = new UdpClient(7007); // modtage pakker på 7007 port nummer

            byte[] buffer;

            while (true)
            {
                IPEndPoint remoteEP = new IPEndPoint(IPAddress.Any, 0);
                buffer = client.Receive(ref remoteEP);

                Console.WriteLine($"har modtaget en pakke kommer fra IP {remoteEP.Address} og port {remoteEP.Port}");
                string str = Encoding.UTF8.GetString(buffer);

                Console.WriteLine("tekst modtaget = " + str);

                byte[] outbuffer = Encoding.UTF8.GetBytes(str.ToCharArray());
                client.Send(outbuffer, outbuffer.Length, remoteEP);




            }





        }
    }
}