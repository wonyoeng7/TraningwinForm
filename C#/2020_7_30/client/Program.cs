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

            TcpClient aTcpClient = new TcpClient("192.168.0.119", 7000);
            Console.WriteLine("클라이언트가 접속합니다.");


            NetworkStream aNetworkStream = aTcpClient.GetStream();
            byte[] Buffer = Encoding.UTF8.GetBytes("검은 고양이 뇌로~");
            aNetworkStream.Write(Buffer, 0, Buffer.Length);
            Console.WriteLine("서버로 전송한 data 내용 : " + Encoding.UTF8.GetString(Buffer));

            Buffer = new byte[1024];
            int BufferCount = aNetworkStream.Read(Buffer, 0, Buffer.Length);
            Console.WriteLine("서버가 전송한 data 크기 : " + BufferCount);
            Console.WriteLine("서버가 전송한 data 내용 : " + Encoding.UTF8.GetString(Buffer));

            Console.WriteLine("클라이언트를 종료합니다.");
            aNetworkStream.Close();
            aTcpClient.Close();

        }
    }
}

