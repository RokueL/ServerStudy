using System.Net.Sockets;
using System.Text;

namespace ConsoleApp1.ConnectClass.TCP;

public class tcpClient01
{
    // static void Main(string[] args)
    // {
    //     TcpClient tcpClient = new TcpClient("127.0.0.1", 7);
    //     if (tcpClient.Connected)
    //     {
    //         Console.WriteLine("연결 성공");
    //         NetworkStream ns = tcpClient.GetStream();
    //         string Message = "Hello World";
    //         byte[] SendMessage = Encoding.ASCII.GetBytes(Message);
    //         ns.Write(SendMessage, 0, SendMessage.Length);
    //
    //         byte[] ReceiveByteMessage = new byte[32];
    //         ns.Read(ReceiveByteMessage, 0, ReceiveByteMessage.Length);
    //         string ReceiveMessage = Encoding.ASCII.GetString(ReceiveByteMessage);
    //         Console.WriteLine(ReceiveMessage);
    //         ns.Close();
    //     }
    //     else
    //         Console.WriteLine("연결 실패");
    //     
    //     tcpClient.Close();
    //     Console.ReadKey();
    // }
}