using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Socket Server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        Server.Connect(new IPEndPoint(IPAddress.Parse("192.168.0.119"), 7000));

        byte[] Buffer = Encoding.UTF8.GetBytes("서버에서 받았다.");     
        Server.Send(Buffer);

        Buffer = new byte[1024];
        int Num = Server.Receive(Buffer);
        Console.WriteLine(Encoding.UTF8.GetString(Buffer, 0, Num));

        Server.Close();
    }
}