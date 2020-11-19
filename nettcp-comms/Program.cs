using System;
using System.Configuration;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace MyTcpServer
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var hostAddress = new Uri(ConfigurationManager.AppSettings["ServerAddress"]);
                var binding = new NetTcpBinding(SecurityMode.None, false);
                var myTcpServer = new MyTcpServer();
                myTcpServer.onAction += MyTcpServer_onAction;
                var serviceHost = new ServiceHost(myTcpServer, hostAddress);
                var behavior = new ServiceMetadataBehavior();

                serviceHost.AddServiceEndpoint(typeof(IServer), binding, hostAddress);
                serviceHost.Description.Behaviors.Add(behavior);
                

                serviceHost.Open();
                ConsoleLog($"Service runnning on {hostAddress}");
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private static void MyTcpServer_onAction(object sender, EventArgs e)
        {
            ConsoleLog($"Action: {(e as MyTcpServerEventArgs).ActionName}");
        }

        internal static void ConsoleLog(string message)
        {
            Console.WriteLine(message);
        }
    }
}
