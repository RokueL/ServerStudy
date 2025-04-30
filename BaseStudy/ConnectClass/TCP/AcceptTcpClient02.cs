using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ConsoleApp1.ConnectClass.TCP;

public class AcceptTcpClient02
{
    // static void Main(string[] args)
    // {
    //     TcpListener tcpListener = new TcpListener(IPAddress.Parse("127.0.0.1"), 7);
    //     tcpListener.Start();
    //     Console.WriteLine("대기 상태");
    //     TcpClient tcpClient = tcpListener.AcceptTcpClient();
    //     NetworkStream ns = tcpClient.GetStream();
    //     byte[] ReceieveMessage = new byte[100];
    //     ns.Read(ReceieveMessage, 0, 100);
    //     string strMessage = Encoding.ASCII.GetString(ReceieveMessage);
    //     Console.WriteLine($"{strMessage}");
    //
    //     string EchoMessage = "Hi~~~";
    //     byte[] SendMessage = Encoding.ASCII.GetBytes(EchoMessage);
    //     ns.Write(SendMessage,0,SendMessage.Length);
    //     ns.Close();
    //     tcpClient.Close();
    //     tcpListener.Stop();
    //     Console.ReadKey();
    // }
}