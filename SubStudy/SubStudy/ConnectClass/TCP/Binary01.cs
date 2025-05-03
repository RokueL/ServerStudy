using System.Net.Sockets;

namespace ConsoleApp1.ConnectClass.TCP;

public class Binary01
{
    static void Main()
    {
        bool Value1;
        int Number;
        float pi;
        string Message;
        
        TcpClient tcpClient = new TcpClient("localhost", 3000);
        NetworkStream ns = tcpClient.GetStream();

        using (BinaryReader br = new BinaryReader(ns))
        {
            Value1 = br.ReadBoolean();
            Number = br.ReadInt32();
            pi = br.ReadSingle();
            Message = br.ReadString();
        }
        ns.Close();
        tcpClient.Close();
        
        Console.WriteLine($"{Value1}");
        Console.WriteLine($"{Number}");
        Console.WriteLine($"{pi}");
        Console.WriteLine($"{Message}");
    }
}