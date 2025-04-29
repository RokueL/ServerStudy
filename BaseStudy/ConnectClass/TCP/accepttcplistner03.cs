using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ConsoleApp1.ConnectClass.TCP;

public class accepttcpclient03
{
    // static void Main(string[] args)
    // {
    //     TcpListener tcpListener = new TcpListener(IPAddress.Parse("127.0.0.1"), 7);
    //     tcpListener.Start();
    //     byte[] Buffer = new byte[1024];
    //     int TotalByteCount = 0, ReadByteCount = 0;
    //
    //     Console.WriteLine("서버");
    //
    //     TcpClient tcpClient = tcpListener.AcceptTcpClient();
    //     NetworkStream ns = tcpClient.GetStream();
    //
    //     while (true)
    //     {
    //         ReadByteCount = ns.Read(Buffer, 0, Buffer.Length);
    //         if (ReadByteCount == 0)
    //             break;
    //         TotalByteCount += ReadByteCount;
    //         ns.Write(Buffer, 0, ReadByteCount);
    //         Console.WriteLine(Encoding.ASCII.GetString(Buffer));
    //     }
    //     ns.Close();
    //     tcpClient.Close();
    //     tcpListener.Stop();
    // }
}