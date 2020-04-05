using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public interface IInternet
    {
        void ConnectTo(string serverHost);
    }

    public class RealInternet : IInternet
    {
        public void ConnectTo(string serverHost)
        {
            Console.WriteLine("Connecting to: " + serverHost);
        }
    }

    public class ProxyInternet : IInternet
    {
        private readonly IInternet internet = new RealInternet();

        private readonly List<string> bannedSites = new List<string> { "abc.com", "def.com", "ijk.com" };

        public void ConnectTo(string serverHost)
        {
            if (bannedSites.Contains(serverHost.ToLower()))
            {
                throw new Exception("Access Denied");
            }

            internet.ConnectTo(serverHost);
        }
    }
}
