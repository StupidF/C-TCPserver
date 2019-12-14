using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace _021_socket编程_TCP协议
{
    class Program
    {
        static void Main(string[] args)
        {
            //1、创建socket
            Socket tcpServer = new Socket(AddressFamily.InterNetwork,SocketType.Stream,ProtocolType.Tcp);
            //2、绑定IP与端口号
            endpor
            tcpServer.Bind();
        }
    }
}
