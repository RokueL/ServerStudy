using System.Net;

namespace Dns01
{
    public class dns01
    {
        static void Main(string[] args)
        {
            IPAddress[] IP = Dns.GetHostAddresses("www.naver.com");
            foreach (var HostIP in IP)
            {
                Console.WriteLine($"{HostIP}");
            }
        }
    }
}