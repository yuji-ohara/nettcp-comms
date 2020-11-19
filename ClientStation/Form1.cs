using MyTcpServer;
using System;
using System.Configuration;
using System.ServiceModel;
using System.Threading;
using System.Windows.Forms;

namespace ClientStation
{
    public partial class Form1 : Form
    {
        private MyTcpClient _tcpClient;
        private SynchronizationContext _synchronizationContext;

        public Form1()
        {
            InitializeComponent();
            var binding = new NetTcpBinding(SecurityMode.None, false);
            var endpoint = new EndpointAddress(ConfigurationManager.AppSettings["ServerAddress"]);
            _tcpClient = new MyTcpClient(binding, endpoint);
            _synchronizationContext = WindowsFormsSynchronizationContext.Current;
        }

        private void btnGetServerVersion_Click(object sender, EventArgs e)
        {
            var serverVersion = _tcpClient.Test();
            Output(serverVersion);
        }

        internal void Output(string message)
        {
            _synchronizationContext.Post((m) => {
                tbxOutput.AppendText($"{message}{Environment.NewLine}");
            }, message);
        }

        private void btnGetModel_Click(object sender, EventArgs e)
        {
            var modelInstance = _tcpClient.FetchTestInstanceById(1);
            Output("Instance details:");
            Output($"Id: {modelInstance.Id}");
            Output($"Name: {modelInstance.Name}");
            Output($"Active: {modelInstance.Active}");
            Output($"Internal Dictionary: {modelInstance.InternalDictionary.Count}");
            foreach(var item in modelInstance.InternalDictionary)
            {
                Output("{ KeyValuePair: " + item.Key + " - " + item.Value + " }");
            }
        }
    }
}
