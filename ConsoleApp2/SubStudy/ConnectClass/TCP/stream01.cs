using System.Net.Sockets;

namespace ConsoleApp1.ConnectClass.TCP;

public class stream01
{
    static void Main()
    {
        char[] buffer = new char[100];
        TcpClient tcpClient = new TcpClient("localhost", 3000);
        NetworkStream ns = tcpClient.GetStream();
        using (StreamReader sr = new StreamReader(ns))
        {
            string str = sr.ReadLine();
            Console.WriteLine(str);
            str = sr.ReadLine();
            Console.WriteLine(str);
            str = sr.ReadLine();
            Console.WriteLine(str);
            str = sr.ReadLine();
            Console.WriteLine(str);
        }
        ns.Close();
        tcpClient.Close();
    }
}