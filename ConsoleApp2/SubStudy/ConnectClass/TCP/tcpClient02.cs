using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ConsoleApp1.ConnectClass.TCP;

public class tcpClient02
{
    // static void Main(string[] args)
    // {
    //     TcpClient tcpClient = new TcpClient("localhost", 7);
    //     NetworkStream ns = tcpClient.GetStream();
    //     Console.WriteLine("클라이언트");
    //     
    //     byte[] Buffer = new byte[1024];
    //     byte[] SendMessage = Encoding.ASCII.GetBytes("Hello World");
    //     ns.Write(SendMessage,0,SendMessage.Length);
    //     int TotalCount = 0, ReadCount = 0;
    //     
    //     while (TotalCount < SendMessage.Length)
    //     {
    //         ReadCount = ns.Read(Buffer, 0, Buffer.Length);
    //         TotalCount += ReadCount;
    //
    //         string ReceiveMessage = Encoding.ASCII.GetString(Buffer);
    //         Console.WriteLine(ReceiveMessage);
    //     }
    //     Console.WriteLine($"받은 문자열 바이트 수 : {TotalCount}");
    //     ns.Close();
    //     tcpClient.Close();
    // }
}