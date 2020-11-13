using System;
using System.Net;
using System.Net.Sockets;
using System.Security.Principal;
using System.Text;


namespace _2020_7_30
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpListener aTcpListener = new TcpListener(IPAddress.Any, 7000);
            //위에 한줄이 밑에 3줄과 같다.
            //Socket Server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //Server.Bind(new IPEndPoint(IPAddress.Any, 7000));                     
            //Server.Listen(100);
            aTcpListener.Start();
            Console.WriteLine("서버가 시작되었습니다...");
            TcpClient aTcpClient = aTcpListener.AcceptTcpClient();
            Console.WriteLine("클라이언트가 접속되었습니다...");
            aTcpListener.Stop();
            byte[] Buffer = new byte[1024];
            NetworkStream aNetworkStream = aTcpClient.GetStream();
            int BufferCount= aNetworkStream.Read(Buffer, 0, Buffer.Length);
            Console.WriteLine("클라이언트가 전송한 크기 : {0}" + BufferCount);
            Console.WriteLine("클라이언트가 전송한 Data 내용 : " + Encoding.UTF8.GetString(Buffer));
            Buffer = Encoding.UTF8.GetBytes("검은 고양이 뇌로~");
            aNetworkStream.Write(Buffer, 0, Buffer.Length);
            Console.WriteLine("클라이언트가 회신한 Data 내용 : " + Encoding.UTF8.GetString(Buffer));

            Console.WriteLine("서버를 종료합니다.");
            aNetworkStream.Close();
            aTcpClient.Close();

        }
    }
}
