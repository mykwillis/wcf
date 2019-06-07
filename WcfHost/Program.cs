using System;
using System.ServiceModel;
using System.ServiceModel.Description;
using WcfLib;

namespace WcfHost
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost selfHost = new ServiceHost(typeof(EchoService));
            try
            {
                selfHost.Open();
                Console.WriteLine("The service is ready.");
                foreach (var a in selfHost.BaseAddresses)
                {
                    Console.WriteLine(a);
                }
                Console.WriteLine("Press <Enter> to terminate the service.");
                Console.WriteLine();
                Console.ReadLine();
                selfHost.Close();
            }
            catch (CommunicationException ce)
            {
                Console.WriteLine("An exception occurred: {0}", ce.Message);
                selfHost.Abort();
            }
        }
    }
}