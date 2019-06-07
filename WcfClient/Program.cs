using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WcfClient.ServiceReference1;

namespace WcfClient
{
    class Program
    {
        static void Main(string[] args)
        {
            EchoClient client = new EchoClient();

            Console.Write("\nSending Echo request to service...");

            string result = client.Echo("Hello, DataCore!");

            Console.WriteLine("done");

            Console.WriteLine("Echo(\"Hello, DataCore!\") = {0}", result);

            Console.WriteLine("\nPress <Enter> to terminate the client.");
            Console.ReadLine();
            client.Close();
        }
    }
}