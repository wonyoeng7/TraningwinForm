using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Socket Server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        Server.Bind(new IPEndPoint(IPAddress.Any, 7000));                       //IP를 자동으로 입력
        //Server.Bind(new IPEndPoint(IPAddress.Parse("192.168.0.119"), 7000));    IP를 수동으로 입력
        Server.Listen(100);

        Socket Client = Server.Accept();    //블로킹 메소드
        Console.WriteLine("Client Incomming");

        byte[] Buffer = new byte[1024];
        int Num = Client.Receive(Buffer);

        Console.WriteLine(Encoding.UTF8.GetString(Buffer, 0, Num));
        Buffer = Encoding.UTF8.GetBytes("서버에서 보낸다.");
        Client.Send(Buffer);



        Client.Close();
        Server.Close();
    }
}