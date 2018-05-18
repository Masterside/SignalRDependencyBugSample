using Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    class Program
    {
        static void Main(string[] args)
        {
            Connector connector = new Connector();
            connector.ConnectToServer("http://localhost:5000/chat");
            Console.Read();
        }
    }
}
