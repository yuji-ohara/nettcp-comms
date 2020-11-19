using System;
using System.Reflection;
using System.ServiceModel;

namespace MyTcpServer
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    internal class MyTcpServer : IServer
    {
        private Helper _helper;

        public event EventHandler onAction;

        public MyTcpServer()
        {
            _helper = new Helper();
        }

        protected virtual void OnAction(EventArgs e)
        {
            if(onAction != null)
                onAction(this, e);
        }

        public TestModel FetchTestInstanceById(int id)
        {
            OnAction(new MyTcpServerEventArgs("FetchTestInstanceById"));
            return _helper.CreateTestModel(id);
        }

        public string Test()
        {
            OnAction(new MyTcpServerEventArgs("Test"));
            var assemblyName = Assembly.GetExecutingAssembly().GetName();
            return $"Server: {assemblyName.Name} - v:{assemblyName.Version}";
        }
    }

    public class MyTcpServerEventArgs : EventArgs
    {
        public MyTcpServerEventArgs(string actionName)
        {
            ActionName = actionName;
        }

        public string ActionName { get; set; }
    }
}
