using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Net.NetworkInformation;
using System.Text;

namespace Bai2
{
    class Program
    {       
        static void Main(string[] args)
        {//1 - 65535
            for (int i = 5; i < 20; i++)
            {
                IPEndPoint ipe = new IPEndPoint(IPAddress.Parse("172.217.24.206"), i);

                try
                {
                    TcpClient tcp = new TcpClient();
                    tcp.Connect(ipe);

                    Console.WriteLine(ipe.ToString() + " is open.");

                }
                catch
                {
                    Console.WriteLine(ipe.ToString() + " is close.");
                }
            }
            

            /*UdpClient udp = new UdpClient();
            udp.Connect(ipe);
            byte[] data = Encoding.ASCII.GetBytes("hello");
            try
            {
                udp.Receive(ref ipe);                
                Console.WriteLine(ipe.ToString() + " is open.");
            }
            catch
            {
                Console.WriteLine(ipe.ToString() + " is close.");
            }*/           
        }
    }
}
