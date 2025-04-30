using System.Net;
using System.Net.Sockets;

namespace ConsoleApp1.ConnectClass.TCP;

public class Binary01
{
    static void Main()
    {
        TcpListener tcpListener = new TcpListener(IPAddress.Any, 3000);
        tcpListener.Start();

        TcpClient tcpClient = tcpListener.AcceptTcpClient();
        NetworkStream ns = tcpClient.GetStream();

        using (BinaryWriter bw = new BinaryWriter(ns))
        {
            bool Value1 = true;
            int Number = 10;
            float pi = 3.14f;
            string Message = "HI";
            
            bw.Write(Value1);
            bw.Write(Number);
            bw.Write(pi);
            bw.Write(Message);
        }
        ns.Close();
        tcpClient.Close();
        tcpListener.Stop();
    }
}