namespace Megalodon.Driver
{
    public class Listener
    {
        public Listener(int port)
        {
            this.Port = port;
        }

        public int Port { get; }

        public void Start()
        {
            throw new System.NotImplementedException();
        }
    }
}