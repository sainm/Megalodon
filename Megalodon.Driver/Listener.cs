using System.Net;
using System.Net.Sockets;

namespace Megalodon.Driver
{
    public class Listener
    {
        
        private TcpListener _listener;
        public Listener(int port)
        {
            this.Port = port;
        }

        public int Port { get; }

        public void Start()
        {
            _listener = new TcpListener(IPAddress.Any, Port);
            
            throw new System.NotImplementedException();
        }
    }
}